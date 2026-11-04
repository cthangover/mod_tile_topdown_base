# Top-down Tiles — 方格地图视图

Top-down Tiles 以经典 2D RPG 的风格，在方格网格上从正上方绘制图块地图。它是共享引擎 Tile Rendering 的两种地图视图之一；另一种是 Isometric Tiles。RPG Plus 用的就是这种视图。

![正午时俯视下的 RPG Plus 村庄：房屋、挂着路灯的广场、村民、池塘和主角。](assets/village-topdown.jpg)

## 什么变了，什么没变

本模组将格子映射为屏幕像素。每格为地图 `TileSize` 大小的正方形（默认 32 像素）。图片和几何由 `rpg_object` 定义；物件高度不会改变其逻辑格子。

其余一切都归其他模组所有，切换视图时不会改变：

- **地图及其内容**——图块、建筑、人物、宝箱——来自内容模组（例如 RPG Plus 和 Village Pack）；
- **行走、碰撞、事件、战斗和存档**属于 RPG 模组，两种视图下用的都是同一网格；
- **绘制、光照和昼夜**由 Tile Rendering 完成。

方向键和 WASD 沿屏幕的上、下、左、右移动。

![同一张村庄地图的两种视图：左边俯视，右边等距。](assets/same-map-two-projections.jpg)

## 如何启用

在游戏的方案（**模组与合集 → 合集 → 对应游戏 → 编辑结构**）中加入这个模组，并把**地图投影**设为**俯视**。设置 `tile.renderer` 的值为 `topdown`：

```json
"settings": { "tile.renderer": "topdown" }
```

只想用一次时，在命令行加上 `--tile-renderer=topdown`。如果游戏只包含这一个渲染器而设置留空，它会自动启用。

## 如果遇到问题

1. **地图是空的。** 游戏的**地图投影**要求一个未包含的渲染器；请加入这个模组，或选择其他投影。
