namespace Cthangover.Mods.TileTopdown
{
    using Cthangover.Mods.TileRender;
    /// <summary>Square projection implementation; does not depend on RPG or the isometric implementation.</summary>
    public class TopdownRendererFactory : ITileRendererFactory
    {
        public string Id => "topdown";
        public ITileProjection Projection(int size) => new SquareTileProjection(size);
        public ITileWorldPresentation Create() => new TileCanvasPresentation(this);
    }
}
