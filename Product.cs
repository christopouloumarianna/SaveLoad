using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace SaveLoad

{

    public class Product

    {



        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double ProductCategory { get; set; }

        



        public Product(int id, string name, double price, double productCategory) 

        {

            Id = id;

            Name = name;

            Price = price;

            ProductCategory = productCategory;

            

        }


        public override string ToString()

        {

            return $" {Id}  {Name}  {Price} {ProductCategory} ";

        }

    }

}

