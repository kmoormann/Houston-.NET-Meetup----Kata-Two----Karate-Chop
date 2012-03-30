using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HDNMeetup;

namespace FinaryChop.Test
{
    [TestClass]
    public class FinaryChopTestClass
    {
        private readonly int NOT_FOUND = -1;

        [TestMethod]
        public void HandlesEmptyArrayTest()
        {
            //Arrange
            int[] searchArray = new int[] { };

            int actual = 0;

            //Act

            actual = FinaryChopper.Chop(0,searchArray);

            //Assert

            Assert.AreEqual(NOT_FOUND, actual);
        }
        
        [TestMethod]
        public void SingleElementArrayFoundTest()
        {
            //Arrange
            int[] searchArray = new int[] { 1 };
            int actual = NOT_FOUND;
            int expected = 0;
            //Act

            actual = FinaryChopper.Chop(1, searchArray);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod]
        public void SingleElementArrayNotFoundTest()
        {
            //Arrange
            int[] searchArray = new int[] { 1 };
            int actual = NOT_FOUND;
            int expected = -1;
            //Act

            actual = FinaryChopper.Chop(1, searchArray);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }
        

        [TestMethod]
        public void FindsLeftMostElementTest()
        {
            int[] searchArray = new int[] { 1, 2, 3, 4, 5 };

            int expected = 0;

            //Act

            int actual = FinaryChopper.Chop(1, searchArray);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void FindsRightMostElementTest()
        {
            int[] searchArray = new int[] { 1, 2, 3, 4, 5 };
            int expected = 4;

            //Act
            int actual = FinaryChopper.Chop(5, searchArray);

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void FindsAnyElementPosition()
        {
            //Arrange 
            int []  searchArray = new int[] { 0, 1, 2, 3, 4 };
            int expected, actual = -1;

            foreach(int i in searchArray)
            {
                expected = i;
                actual = FinaryChopper.Chop(i, searchArray);
                Assert.AreEqual(expected, actual);
            }
        }
        
    }
}
