using System.Diagnostics;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Hm85_Xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var waffles = new Food
            {
                Name = "Belgian Waffles",
                Price = 5.95,
                Description = "Two of our famous Belgian Waffles with plenty of real maple syrup",
                Calories = 650
            };

            var strWaffles = new Food
            {
                Name = "Strawberry Belgian Waffles",
                Price = 7.95,
                Description = "Light Belgian waffles covered with strawberries and whipped cream",
                Calories = 900
            };

           var berWaffles = new Food
           {
                Name = "Berry-Berry Belgian Waffles",
                Price = 8.95,
                Description = "Light Belgian waffles covered with strawberries and whipped cream",
                Calories = 900
            };

            var toast = new Food
            {
                Name = "French Toast",
                Price = 4.50,
                Description = "  Thick slices made from our homemade sourdough bread",
                Calories = 600
            };

            var homestyle = new Food
            {
                Name = "Homestyle Breakfast",
                Price = 6.95,
                Description = "  Two eggs, bacon or sausage, toast, and our ever-popular hash browns",
                Calories = 950
            };

           
            var menu = new List<Food> { waffles, strWaffles, berWaffles, toast, homestyle };

            DataHelper.Save(menu);

            var breakfastMenu = DataHelper.Load();

        }
    }
}