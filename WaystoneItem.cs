﻿using ExileCore2.PoEMemory.Components;
using ExileCore2.Shared;

namespace WaystoneHighlight
{
    internal enum ItemLocation
    {
        Inventory = 0,
        Stash = 1
    }

    internal enum ItemType
    {
        Waystone,
        PrecursorTablet
    }

    internal struct WaystoneItem
    {
        public Base baseComponent;
        public Map map;
        public Mods mods;
        public RectangleF rect;
        public ItemLocation location;
        public ItemType type;

        public WaystoneItem(Base baseComponent, Map mapComponent, Mods modsComponent, RectangleF rectangleF, ItemLocation location)
        {
            this.baseComponent = baseComponent;
            this.map = mapComponent;
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