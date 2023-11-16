using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cal.Tests

{ 

 [TestClass()]
public class CalculatorTests
{


    [TestMethod()]
    public void AddTest()
    {
        CalculatorTests calculator = new CalculatorTests();
        Assert.AreEqual(15, calculator.Add(7, 8));

    }

    private int Add(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    [TestMethod()]
    public void SubtractTest()
    {
        CalculatorTests calculator = new CalculatorTests();
        Assert.AreEqual(15, calculator.Subtract(20, 5));
    }

    private int Subtract(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    [TestMethod()]
    public void MultiplyTest()
    {
        CalculatorTests calculator = new CalculatorTests();
        Assert.AreEqual(15, calculator.Multiply(5, 3));
    }

    private int Multiply(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    [TestMethod()]
    public void DivideTest()
    {
        CalculatorTests calculator = new CalculatorTests();
        Assert.AreEqual(15, calculator.Divide(120, 8));
    }

    private int Divide(int v1, int v2)
    {
        throw new NotImplementedException();
    }
}

}



















