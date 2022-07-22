using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    } 

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "Suzie's Cafe";
      string description = "Specializes in coffee, drinks, and Asian pastries";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzie's Cafe";
      string description = "Specializes in coffee, drinks, and Asian pastries";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Suzie's Cafe";
      string description = "Specializes in coffee, drinks, and Asian pastries";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      string name = "Suzie's Cafe";
      string description = "Specializes in coffee, drinks, and Asian pastries";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_VendorList()
    {
      string name1 = "Cafe1";
      string name2 = "Cafe2";
      string description1 = "Cafe1 good";
      string description2 = "Cafe2 better";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
  }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Cafe1";
      string name2 = "Cafe2";
      string description1 = "Cafe1 good";
      string description2 = "Cafe2 better";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
}
}

