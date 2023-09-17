using GildedTros.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Factory
{
    internal class GildedTrosFactory
    {
        public static GildedTrosItem GetGildedTrosItem(string name)
        {

            switch (name.ToLower())
            {
                case "good wine":
                    return new GildedTrosQualityItem();
                case "b-dawg keychain":
                    return new GildedTrosLegendaryItem();
                case "backstage passes for re:factor":
                case "backstage passes for haxx":
                    return new GildedTrosBackstageItem();
                case "duplicate code":
                case "long methods":
                case "ugly variable names":
                    return new GildedTrosSmellyItem();
                default:
                    return new GildedTrosCommonItem();
            }

        }
    }
}
