using ApprovalUtilities.Utilities;
using System;
using System.Collections.Generic;
using GildedTros.App.Models;

namespace GildedTros.App
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var app = new GildedTrosClient(true);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                app.Items.ForEach(item => { Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");} );
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
