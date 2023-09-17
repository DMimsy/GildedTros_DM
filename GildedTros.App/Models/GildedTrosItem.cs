using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GildedTros.App.Models
{

    internal abstract class GildedTrosItem : Item
    {
        internal GildedTrosItem() { }

        internal abstract void UpdateQuality();
    }

    internal class GildedTrosCommonItem : GildedTrosItem
    {
        internal override void UpdateQuality()
        {
            this.SellIn--;
            if (this.Quality == 0)
                return;

            this.Quality--;

            if (this.SellIn < 0 && this.Quality > 0)
                this.Quality--;
                
        }
    }
    internal class GildedTrosQualityItem : GildedTrosItem
    {
        internal override void UpdateQuality()
        {
            this.SellIn--;
            if (this.Quality == 50)
                return;
            
            this.Quality++;

            if (this.SellIn < 0 && this.Quality < 50)
                this.Quality++;
        }
    }
    internal class GildedTrosLegendaryItem : GildedTrosItem
    {
        internal override void UpdateQuality()
        {
            this.SellIn--;
            this.Quality = 80;
        }
    }
    internal class GildedTrosSmellyItem : GildedTrosItem
    {
        internal override void UpdateQuality()
        {
            this.SellIn--;

            if (this.Quality <= 1)
                this.Quality = 0;
            else
            {
                this.Quality -= 2;

                if (this.SellIn < 0 & this.Quality >= 2)
                    this.Quality -= 2;
                else if (this.SellIn < 0 & this.Quality > 0)
                    this.Quality = 0;

            }

        }
    }
    internal class GildedTrosBackstageItem : GildedTrosItem
    {
        internal override void UpdateQuality()
        {
            this.SellIn--;

            if (SellIn < 0)
            {
                this.Quality = 0;
                return;
            }

            this.Quality++;

            if (this.SellIn < 10 & this.Quality < 50)
                this.Quality++;
            if (this.SellIn < 5 & this.Quality < 50)
                this.Quality++;

        }
    }
}
