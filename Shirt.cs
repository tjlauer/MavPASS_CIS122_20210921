// Thomas Lauer
// September 21, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_20210921
{
    public class Shirt
    {
        // Variables
        private int id = -1;
        private string name = "n/a";
        private string color = "n/a";
        private string size = "n/a";
        private double price = 999999999999999999.9;
        
        // Properties
        public int ID
        {
            get { return this.id;  }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        // Constructors
        public Shirt() : this("n/a", "n/a", "n/a", 999999999999999999.9) { }

        public Shirt(string aName, string aColor, string aSize, double aPrice)
        {
            this.Name = aName;
            this.Color = aColor;
            this.Size = aSize;
            this.Price = aPrice;
        }

        // Methods
        public override string ToString()
        {
            string msg = "";
            msg += "ID: " + this.ID + "\n";
            msg += "Name: " + this.Name + "\n";
            msg += "Color: " + this.Color + "\n";
            msg += "Size: " + this.Size + "\n";
            msg += "Price: " + this.Price + "\n";
            return msg;
        }

        public void ApplyDiscount(double perc)
        {
            this.Price = this.Price * (1 - perc);
        }


    }
}
