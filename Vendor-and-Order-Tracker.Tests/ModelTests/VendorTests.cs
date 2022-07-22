using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests 
  {

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
  }
}
