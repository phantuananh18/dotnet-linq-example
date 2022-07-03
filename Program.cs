// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  public class Product
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string[] Colors { get; set; }
    public int Brand { get; set; }

    //Constructor
    public Product(int id, string name, double price, string[] colors, int brand)
    {
      ID = id;
      Name = name;
      Price = price;
      Colors = colors;
      Brand = brand;
    }

    public override string ToString()
    {
      return $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
    }
  }

  public class Brand
  {
    public string Name { get; set; }
    public int ID { get; set; }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      var brands = new List<Brand>{
        new Brand{ID=1,Name="Công ty AAA"},
        new Brand{ID=2,Name="Công ty BBB"},
        new Brand{ID=3,Name="Công ty CCC"},
      };

      var products = new List<Product>{
        new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
        new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
        new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
        new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
        new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
        new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
        new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
      };

      var res = from product in products
                where product.Price == 400
                select product;
      // foreach (var product in res)
      // {
      //   Console.WriteLine(product.ToString());
      // }

      // int[] scores = { 97, 92, 81, 60 };

      // //define the query expression
      // IEnumerable<int> scoreQuery = from score in scores
      //                               where score > 80
      //                               select score;
      //Execute the query
      // foreach (int i in scoreQuery)
      // {
      //   Console.Write(i + " ");
      // }
    }
  }
}

