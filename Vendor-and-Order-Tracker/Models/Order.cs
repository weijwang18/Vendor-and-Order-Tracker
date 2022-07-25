using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Description { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set;}
    public int Id { get; }

    public Order(string title, string description, int price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}