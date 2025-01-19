using ExileCore2.PoEMemory.Components;
using ExileCore2.Shared;

namespace WaystoneHighlight
{
    internal struct TabletItem
    {
        public Base baseComponent;
        public Mods mods;
        public RectangleF rect;
        public ItemLocation location;
        public ItemType type;

        public TabletItem(Base baseComponent, Mods modsComponent, RectangleF rectangleF, ItemLocation location)
        {
            this.baseComponent = baseComponent;
            this.mods = modsComponent;
            this.rect = rectangleF;
            this.location = location;
            this.type = DetermineItemType(modsComponent);
        }

        private static ItemType DetermineItemType(Mods mods)
        {
            if (mods == null) return ItemType.Waystone;

            foreach (var mod in mods.ItemMods)
            {
                if (mod.Name.Contains("TowerDropped"))
                    return ItemType.PrecursorTablet;
            }

            return ItemType.Waystone;
        }
    }
}