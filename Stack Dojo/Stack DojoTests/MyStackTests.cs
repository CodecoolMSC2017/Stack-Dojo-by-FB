using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack_Dojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Dojo.Tests
{
    [TestClass()]
    public class MyStackTests
    {
        MyStack<int> mystack;

        [TestInitialize]
        public void TestInitialize()
        {
           mystack = new MyStack<int>(5);
        }

        [TestMethod()]
        public void PushTest()
        {
            mystack.Push(2);
            mystack.Push(4);
            mystack.Push(3);
            Assert.AreEqual(3, mystack.Peek());
            Assert.AreEqual(2, mystack.GetFreeSpacesLeft());
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void PushTest_Throws()
        {
            mystack.Push(2);
            mystack.Push(4);
            mystack.Push(3);
            mystack.Push(2);
            mystack.Push(4);
            mystack.Push(3);
        }


        [TestMethod()]
        public void PopTest()
        {
            mystack.Push(2);
            mystack.Push(4);
            mystack.Push(3);
            Assert.AreEqual(3, mystack.Pop());
            Assert.AreEqual(4, mystack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(StackUnderflowException))]
        public void PopTest_Throws()
        {
            mystack.Push(2);
            mystack.Pop();
            mystack.Pop();
        }

        [TestMethod()]
        public void PeekTest()
        {
            mystack.Push(2);
            mystack.Push(4);
            mystack.Push(3);
            Assert.AreEqual(3, mystack.Peek());
        }

        [TestMethod]
        [ExpectedException(typeof(StackUnderflowException))]
        public void PeekTest_Throws()
        {
            mystack.Peek();
        }

        [TestMethod()]
        public void GetFreeSpacesLeftTest()
        {
            mystack.Push(2);
            Assert.AreEqual(4, mystack.GetFreeSpacesLeft());
            mystack.Push(4);
            Assert.AreEqual(3, mystack.GetFreeSpacesLeft());
            mystack.Push(3);
            Assert.AreEqual(2, mystack.GetFreeSpacesLeft());
            mystack.Push(3);
            Assert.AreEqual(1, mystack.GetFreeSpacesLeft());
            mystack.Push(3);
            Assert.AreEqual(0, mystack.GetFreeSpacesLeft());
        }
    }
}