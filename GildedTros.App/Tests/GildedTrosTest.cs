using System.Collections.Generic;
using Xunit;
using GildedTros.App.Models;

namespace GildedTros.App.Tests
{
    public class GildedTrosTest
    {
        //TODO: tests uitbreiden met verschillende parameters
        [Fact]
        public void UpdateQualityTest()
        {
            GildedTrosClient app = new GildedTrosClient(false);
            app.AddItem("common item", 20, 15);

            app.UpdateQuality();

            Assert.True(app.Items[0].Quality == 14);
        }

        [Fact]
        public void AddItemTest()
        {
            GildedTrosClient app = new GildedTrosClient(false);
            app.AddItem("common item", 20, 15);

            Assert.True(app.Items[0].Name == "common item");
        
        }
        


    }
}