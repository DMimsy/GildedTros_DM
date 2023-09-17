using System.Collections.Generic;
using ApprovalUtilities.Utilities;
using GildedTros.App.Factory;
using GildedTros.App.Models;

namespace GildedTros.App
{
    public class GildedTrosClient
    {
        internal IList<GildedTrosItem> Items = new List<GildedTrosItem>(); 
        
        public GildedTrosClient(bool shouldInitialize) 
        {
            if(shouldInitialize)
                this.Initialize();
        }
        public GildedTrosClient(IList<Item> items)
        {
            //this.Items = items;

        }

        private void Initialize()
        {

            this.AddItem(name: "Ring of Cleansening Code", sellin: 10, quality: 20);
            this.AddItem(name: "Elixir of the SOLID", sellin: 5, quality: 7);
            this.AddItem(name: "Good Wine", sellin: 2, quality: 0);
            this.AddItem(name: "Elixir of the SOLID", sellin: 5, quality: 7);
            this.AddItem(name: "B-DAWG Keychain", sellin: 0, quality: 80);
            this.AddItem(name: "B-DAWG Keychain", sellin: -1, quality: 80);
            this.AddItem(name: "Backstage passes for Re:factor", sellin: 15, quality: 20);
            this.AddItem(name: "Backstage passes for Re:factor", sellin: 10, quality: 49);
            this.AddItem(name: "Backstage passes for haxx", sellin:10, quality: 49);

            this.AddItem(name: "Duplicate Code", sellin: 3, quality: 6);
            this.AddItem(name: "Long Methods", sellin: 3, quality: 6);
            this.AddItem(name: "Ugly Variable Names", sellin: 3, quality: 6);

        }

        public void AddItem(string name, int sellin, int quality)
        { 
            var item = GildedTrosFactory.GetGildeTrosItem(name);
            
            item.Name = name;
            item.SellIn = sellin;

            if (item is GildedTrosLegendaryItem)
            {
                item.Quality = 80;
            }
            else
            {
                if (quality < 0)
                    item.Quality = 0;
                else if (quality > 50)
                    item.Quality = 50;
                else
                    item.Quality = quality;
            }
            
            Items.Add(item);
        }

        public void UpdateQuality()
        {
            this.Items.ForEach(item => item.UpdateQuality());
        }

 
    }
}
