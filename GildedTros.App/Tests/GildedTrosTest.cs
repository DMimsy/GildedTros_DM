using System.Collections.Generic;
using Xunit;
using GildedTros.App.Models;

namespace GildedTros.App.Tests
{
    public class GildedTrosTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedTrosClient app = new GildedTrosClient(Items);
            app.UpdateQuality();
            Assert.Equal("fixme", Items[0].Name);
        }
    }
}