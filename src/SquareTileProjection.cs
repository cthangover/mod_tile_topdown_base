namespace Cthangover.Mods.TileTopdown
{
    using Cthangover.Mods.TileRender;
    using Godot;
    /// <summary>Square cells. Elevation changes the vertical image position without changing map coordinates.</summary>
    public class SquareTileProjection : ITileProjection
    {
        public float Unit { get; }
        public SquareTileProjection(int size) { Unit = size > 0 ? size : throw new System.ArgumentOutOfRangeException(nameof(size)); }
        public Vector2 Project(Vector3 p) => new(p.X * Unit, (p.Y - p.Z) * Unit);
        public Vector2 Unproject(Vector2 p) => p / Unit;
        public int CharsetRow(int facing) => facing;
        public TileVisualPlacement Place(TileVisual visual)
            => TileVisualPlacement.FromQuad(TileDrawing.CellPolygon(this, visual.Bounds),
                TileDrawing.Project(this, visual.SortAnchor ?? visual.Anchor), visual.DrawOrder == TileDrawOrder.ByPosition);
    }
}
