using System.Collections.Generic;
using GildedTros.App.Factory;
using GildedTros.App.Models;

namespace GildedTros.App
{
    public class GildedTrosClient
    {
        internal IList<Item> Items = new List<Item>(); 
        
        public GildedTrosClient() 
        {
            this.Initialize();
        }
        public GildedTrosClient(IList<Item> items)
        {
            this.Items = items;

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
            item.Quality = quality;
            Items.Add(item);
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Good Wine"
                    && Items[i].Name != "Backstage passes for Re:factor"
                    && Items[i].Name != "Backstage passes for HAXX")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "B-DAWG Keychain")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes for Re:factor"
                        || Items[i].Name == "Backstage passes for HAXX")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "B-DAWG Keychain")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Good Wine")
                    {
                        if (Items[i].Name != "Backstage passes for Re:factor"
                            && Items[i].Name != "Backstage passes for HAXX")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "B-DAWG Keychain")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
