﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;


namespace CalcTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsTrue()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void IsFalse()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void AddsTwoNumbers()
        {

            Assert.AreEqual(5,Calc.Addition(2,3),"Doesn't Add Up");
            Assert.AreEqual(35, Calc.Addition(12, 23), "Doesn't Add Up");
            Assert.AreEqual(5.9, Calc.Addition(2.2, 3.7), "Doesn't Add Up");
        }

        [TestMethod]
        public void SubtractTwoNumbers()
        {
            Assert.AreEqual(-1, Calc.Subtraction(2, 3), "Doesn't Add Up");
            Assert.AreEqual(-11, Calc.Subtraction(12, 23), "Doesn't Add Up");
            Assert.AreEqual(-1.5, Calc.Subtraction(2.2, 3.7), "Doesn't Add Up");
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            Assert.AreEqual(6, Calc.Multiply(2, 3), "Doesn't Add Up");
            Assert.AreEqual(276, Calc.Multiply(12, 23), "Doesn't Add Up");
            Assert.AreEqual(8.14, Calc.Multiply(2.2, 3.7), "Doesn't Add Up");
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            Assert.AreEqual(1.5, Calc.Divide(3.0, 2.0), "Doesn't Add Up");
            //Assert.AreEqual(12/23, Calc.Divide(12, 23), "Doesn't Add Up");
            Assert.AreEqual(2.2/3.7, Calc.Divide(2.2, 3.7), "Doesn't Add Up");
        }

        [TestMethod]
        public void Square()
        {
            Assert.AreEqual(9, Calc.Square(3));
        }

        [TestMethod]
        public void SquareRoot()
        {
            Assert.AreEqual(3, Calc.SquareRoot(9));
        }


        [TestMethod]
        public void ChangeSign()
        {
            Assert.AreEqual(3, Calc.ChangeSign(-3));
            Assert.AreEqual(-8, Calc.ChangeSign(8));
        }

        [TestMethod]
        public void ClearResult()
        {
            
            Assert.AreEqual("0", Calc.ClearResult());
        }
        [TestMethod]
        public void ReturnResult()
        {
            Calc.CreateResult();
            Calc.Result.Add(56);
            Assert.AreEqual("56",Calc.ReturnResult());
        }

        [TestMethod]
        public void SetOperation()
        {
            Calc.SetOperation("+");
            Assert.AreEqual("+", Calc.Operation);
            Calc.SetOperation("-");
            Assert.AreEqual("-", Calc.Operation);
            Calc.SetOperation("/");
            Assert.AreEqual("/", Calc.Operation);
            Calc.SetOperation("*");
            Assert.AreEqual("*", Calc.Operation);
        }

        [TestMethod]
        public void Evaluate()
        {
            Calc.CreateResult();
            Calc.Operation = "+";
            Calc.Evaluate(12, 56);
            Assert.AreEqual("68", Calc.ReturnResult());
            Calc.Operation = "-";
            Calc.Evaluate(12, 56);
            Assert.AreEqual("44", Calc.ReturnResult());
            Calc.Operation = "*";
            Calc.Evaluate(12, 56);
            Assert.AreEqual("672", Calc.ReturnResult());
            Calc.Operation = "/";
            Calc.Evaluate(3, 9);
            Assert.AreEqual("3", Calc.ReturnResult());
        }
    }
}
