using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    } 

   [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "Tom's order";
      string description = "three croissants";
      int price = 10;
      DateTime date = new DateTime (2022, 7, 22, 7,00,0);
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Tom's order";
      string description = "three croissants";
      int price = 10;
      DateTime date = new DateTime (2022, 7, 22, 7,00,0);
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "Tom's order";
      string description = "three croissants";
      int price = 10;
      DateTime date = new DateTime (2022, 7, 22, 7,00,0);
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title1 = "Tom's order";
      string description1 = "three croissants";
      int price1 = 10;
      DateTime date1 = new DateTime (2022, 7, 22, 7,00,0);
      Order newOrder1 = new Order(title1, description1, price1, date1);
      string title2 = "Sam's order";
      string description2 = "four croissants";
      int price2 = 15;
      DateTime date2 = new DateTime (2022, 7, 23, 8,00,0);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
   }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title1 = "Tom's order";
      string description1 = "three croissants";
      int price1 = 10;
      DateTime date1 = new DateTime (2022, 7, 22, 7,00,0);
      Order newOrder1 = new Order(title1, description1, price1, date1);
      string title2 = "Sam's order";
      string description2 = "four croissants";
      int price2 = 15;
      DateTime date2 = new DateTime (2022, 7, 23, 8,00,0);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
}
}