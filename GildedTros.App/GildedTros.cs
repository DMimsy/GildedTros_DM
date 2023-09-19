using System.Collections.Generic;
using ApprovalUtilities.Utilities;
using GildedTros.App.Factory;
using GildedTros.App.Models;

namespace GildedTros.App
{
    interface IGildedTrosClient
    {
        public void AddItem(string name, int sellin, int quality);
        public void UpdateQuality();

    }
    public class GildedTrosClient : IGildedTrosClient
    {
        internal IList<GildedTrosItem> Items = new List<GildedTrosItem>(); 
        
        /// <summary>
        /// instantiate with parameter shouldInitialize set to true for basic list of items
        /// </summary>
        /// <param name="shouldInitialize"></param>
        public GildedTrosClient(bool shouldInitialize) 
        {
            if(shouldInitialize)
                this.Initialize();
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

        //TODO: alternatief zoeken ivm SRP?
        /// <summary>
        /// Add item to Items list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sellin"></param>
        /// <param name="quality"></param>
        public void AddItem(string name, int sellin, int quality)
        { 
            var item = GildedTrosFactory.GetGildedTrosItem(name);
            
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

        /// <summary>
        /// update qualitity foreach item in Items list
        /// </summary>
        public void UpdateQuality()
        {
            this.Items.ForEach(item => item.UpdateQuality());
        }

 
    }
}
