# Top-down Tiles — the square map view

Top-down Tiles draws tile maps straight from above, on a square grid, in the style of classic 2D RPGs. It is one of two map views for the shared Tile Rendering engine; the other is Isometric Tiles. RPG Plus uses this view.

![The village of RPG Plus at noon in the top-down view: houses, the square with lamps, villagers, the pond and the hero.](assets/village-topdown.jpg)

## What changes and what does not

This mod only decides **how a map cell becomes pixels on screen**: each cell is a square of the tileset's tile size, and a raised object is drawn higher on screen without changing its cell.

Everything else is owned by other mods and does not change when you switch views:

- **the map and its content** — tiles, buildings, people, chests — come from content mods (for example RPG Demo and Village Pack);
- **walking, collisions, events, battles and saves** belong to the RPG mod and use the same grid in both views;
- **drawing, lighting and time of day** are done by Tile Rendering.

The arrow keys and WASD move along the screen's up, down, left and right.

![The same village map drawn in both views: top-down on the left, isometric on the right.](assets/same-map-two-projections.jpg)

## Turn it on

In the game's scheme (**Mods & Collections → Collections → the game → Edit scheme**), include this mod and set **Map projection** to **Top-down**. The value of the `tile.renderer` setting is `topdown`:

```json
"settings": { "tile.renderer": "topdown" }
```

For a single run, add `--tile-renderer=topdown` to the command line. If a game includes only this renderer and leaves the setting empty, it is used automatically.

## If something goes wrong

1. **The map is empty.** The game's **Map projection** asks for a renderer that is not included; include this mod or choose another projection.
