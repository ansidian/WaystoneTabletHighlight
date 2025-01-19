using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExileCore2.PoEMemory.Components;
using ExileCore2.Shared;

namespace WaystoneHighlight
{
    internal struct TabletItem(Base baseComponent, Mods modsComponent, RectangleF rectangleF, ItemLocation location)
    {
        public Base baseComponent = baseComponent;
        public Mods mods = modsComponent;
        public RectangleF rect = rectangleF;
        public ItemLocation location = location;
    }
}