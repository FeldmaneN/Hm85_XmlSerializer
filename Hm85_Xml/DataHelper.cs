using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hm85_Xml
{
    internal class DataHelper
    {
        private const string filePath = @"Menu.xml";
        internal static void Save(List<Food> food)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Food>));
            using (var writer = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(writer, food);
            }
        }
        internal static List<Food> Load()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Food>));
            using (var reader = new StreamReader(filePath))
            {
                var food = xmlSerializer.Deserialize(reader);
                return (List<Food>)food;
            }
        }
    }

}
