using Xunit;
using GildedTros.App.Models;

namespace GildedTros.App.Tests
{
    public class GildedTrosItemQualityTest
    {
        [Fact]
        public void GoodWineQualityTest()
        {
            GildedTrosQualityItem item = new GildedTrosQualityItem();
            item.Name = "Good Wine";
            item.Quality = 5;
            item.SellIn = 2;

            item.UpdateQuality();

            Assert.True(item.Quality == 6);
        }

        [Fact]
        public void CommonQualityTest()
        {
            GildedTrosCommonItem item = new GildedTrosCommonItem();
            item.Name = "Common";
            item.Quality = 7;
            item.SellIn = 7;

            item.UpdateQuality();

            Assert.True(item.Quality == 6);

        }
    }
}
