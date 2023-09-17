using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Models
{

    internal abstract class GildedTrosItem : Item
    {
        internal GildedTrosItem() { }

        protected abstract int UpdateQuality();
    }

    internal class GildedTrosCommonItem : GildedTrosItem
    {
        protected override int UpdateQuality()
        {
            throw new NotImplementedException();
        }
    }
    internal class GildedTrosQualityItem : GildedTrosItem
    {
        protected override int UpdateQuality()
        {
            throw new NotImplementedException();
        }
    }
    internal class GildedTrosLegendaryItem : GildedTrosItem
    {
        protected override int UpdateQuality()
        {
            throw new NotImplementedException();
        }
    }
    internal class GildedTrosSmellyItem : GildedTrosItem
    {
        protected override int UpdateQuality()
        {
            throw new NotImplementedException();
        }
    }
    internal class GildedTrosBackstageItem : GildedTrosItem
    {
        protected override int UpdateQuality()
        {
            throw new NotImplementedException();
        }
    }
}
