# Top-down Tiles — la vista cuadrada del mapa

Top-down Tiles dibuja los mapas de tiles directamente desde arriba, sobre una cuadrícula cuadrada, al estilo de los RPG clásicos en 2D. Es una de las dos vistas de mapa del motor común Tile Rendering; la otra es Isometric Tiles. RPG Plus usa esta vista.

![La aldea de RPG Plus al mediodía en la vista superior: casas, la plaza con farolas, aldeanos, el estanque y el héroe.](assets/village-topdown.jpg)

## Qué cambia y qué no

Este mod solo decide **cómo una casilla del mapa se convierte en píxeles en pantalla**: cada casilla es un cuadrado del tamaño del tile del tileset, y un objeto elevado se dibuja más arriba en pantalla sin cambiar de casilla.

Todo lo demás pertenece a otros mods y no cambia al alternar de vista:

- **el mapa y su contenido** — tiles, edificios, gente, cofres — vienen de mods de contenido (por ejemplo RPG Demo y Village Pack);
- **caminar, colisiones, eventos, combates y guardado** corresponden al mod RPG y usan la misma cuadrícula en ambas vistas;
- **el dibujo, la iluminación y la hora del día** los hace Tile Rendering.

Las flechas y WASD mueven hacia arriba, abajo, izquierda y derecha de la pantalla.

![El mismo mapa de la aldea en ambas vistas: vista superior a la izquierda, isométrica a la derecha.](assets/same-map-two-projections.jpg)

## Actívalo

En el esquema del juego (**Mods → Colecciones → el juego → Editar esquema**), incluye este mod y pon **Proyección del mapa** en **Vista superior**. El valor del ajuste `tile.renderer` es `topdown`:

```json
"settings": { "tile.renderer": "topdown" }
```

Para una sola partida, añade `--tile-renderer=topdown` a la línea de comandos. Si un juego incluye solo este renderizador y deja el ajuste vacío, se usa automáticamente.

## Si algo falla

1. **El mapa está vacío.** La **Proyección del mapa** del juego pide un renderizador que no está incluido; incluye este mod o elige otra proyección.
