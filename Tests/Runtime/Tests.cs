using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using com.trashpandaboy.datastructures;
using System;

public class Tests
{

    [Test]
    public void Test01_AddAndGet()
    {
        DataCollection dc = new DataCollection();

        dc.AddData("test", "ciao");

        var testValue = dc.GetData<string>("test");

        Assert.IsTrue(testValue.Equals("ciao"));
    }

    [Test]
    public void Test02_StringDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<string>("nd");

        Assert.AreEqual(string.Empty, testValue);
    }
    
    [Test]
    public void Test03_IntDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<int>("nd");

        Assert.AreEqual(0, testValue);
    }

    [Test]
    public void Test04_FloatDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<float>("nd");

        Assert.AreEqual(0f, testValue);
    }

    [Test]
    public void Test05_BoolDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<bool>("nd");

        Assert.IsFalse(testValue);
    }

    [Test]
    public void Test06_ObjectDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<object>("nd");

        Assert.IsNull(testValue);
    }

    [Test]
    public void Test07_ByteDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<byte>("nd");

        Assert.AreEqual((byte)0, testValue);
    }

    [Test]
    public void Test08_Int32DefaultValue()
    {
        DataCollection dc = new DataCollection();
    
        var testValue = dc.GetData<int>("nd");
    
        Assert.AreEqual(0, testValue);
    }

    [Test]
    public void Test09_CharDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<char>("nd");

        Assert.AreEqual((char)0, testValue);
    }

    [Test]
    public void Test10_DateTimeDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<DateTime>("nd");

        Assert.AreEqual(DateTime.MinValue, testValue);
    }

    [Test]
    public void Test11_DecimalDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<decimal>("nd");

        Assert.AreEqual((decimal)0, testValue);
    }

    [Test]
    public void Test12_DoubleDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<double>("nd");

        Assert.AreEqual(0d, testValue);
    }

    [Test]
    public void Test13_Int16DefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<Int16>("nd");

        Assert.AreEqual((Int16)0, testValue);
    }

    [Test]
    public void Test14_Int64DefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<Int64>("nd");

        Assert.AreEqual((Int64)0, testValue);
    }

    [Test]
    public void Test15_SByteDefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<byte>("nd");

        Assert.AreEqual((byte)0, testValue);
    }

    [Test]
    public void Test16_UInt16DefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<UInt16>("nd");

        Assert.AreEqual((UInt16)0, testValue);
    }

    [Test]
    public void Test17_UInt32DefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<UInt32>("nd");

        Assert.AreEqual((UInt32)0, testValue);
    }

    [Test]
    public void Test18_UInt64DefaultValue()
    {
        DataCollection dc = new DataCollection();

        var testValue = dc.GetData<UInt64>("nd");

        Assert.AreEqual((UInt64)0, testValue);
    }
    
}
