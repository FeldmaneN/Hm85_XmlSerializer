using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hm85_Xml
{
 

    [XmlType("food")]
    public class Food
    {
      [XmlElement("name")]
        public string Name { get; set; }

      [XmlElement("price")]
        public double Price { get; set; }

      [XmlElement("description")]
        public string Description { get; set; }

      [XmlElement("calories")]
        public int Calories { get; set; }
    }
}

