using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckPassword.Tests
{
    [TestClass]
    public class PswrdTests
    {

        [TestMethod]
        public void CheckPswrd_OnlyStrings_1Point()
        {
                // arrange
                string password = "abcd"; 
                ChkPswrd pswrdValidator = new ChkPswrd();
                int expectedPoints = 1;

                // act
                int result = pswrdValidator.CheckPswrd(password);

                // assert
                Assert.AreEqual(expectedPoints, result);
        }

        [TestMethod]
        public void CheckPswrd_StringsAndCaps_2Points()
        {
            // arrange
            string password = "Abcd";
            ChkPswrd pswrdValidator = new ChkPswrd();
            int expectedPoints = 2;

            // act
            int result = pswrdValidator.CheckPswrd(password);

            // assert
            Assert.AreEqual(expectedPoints, result);
        }

        [TestMethod]
        public void CheckPswrd_StringsAndCapsAndNumbers_3Points()
        {
            // arrange
            string password = "Abcd1";
            ChkPswrd pswrdValidator = new ChkPswrd();
            int expectedPoints = 3;

            // act
            int result = pswrdValidator.CheckPswrd(password);

            // assert
            Assert.AreEqual(expectedPoints, result);
        }

        [TestMethod]
        public void CheckPswrd_StringsAndCapsAndNumbersAndSpecSymbol_4Points()
        {
            // arrange
            string password = "Abcd1!";
            ChkPswrd pswrdValidator = new ChkPswrd();
            int expectedPoints = 4;

            // act
            int result = pswrdValidator.CheckPswrd(password);

            // assert
            Assert.AreEqual(expectedPoints, result);
        }

        [TestMethod]
        public void CheckPswrd_StringsAndCapsAndNumbersAndSpecSymbolAnd10Symbol_5Points()
        {
            // arrange
            string password = "Abcd13232354334534!";
            ChkPswrd pswrdValidator = new ChkPswrd();
            int expectedPoints = 5;

            // act
            int result = pswrdValidator.CheckPswrd(password);

            // assert
            Assert.AreEqual(expectedPoints, result);
        }

        [TestMethod]
        public void CheckPswrd_Null_0Points()
        {
            // arrange
            string password = "";
            ChkPswrd pswrdValidator = new ChkPswrd();
            int expectedPoints = 0;

            // act
            int result = pswrdValidator.CheckPswrd(password);

            // assert
            Assert.AreEqual(expectedPoints, result);
        }

        [TestMethod]
        public void CheckPswrd_StringAndNumbers_2Points()
        {
            // arrange
            string password = "Abcd1";
            ChkPswrd pswrdValidator = new ChkPswrd();
            int expectedPoints = 2;

            // act
            int result = pswrdValidator.CheckPswrd(password);

            // assert
            Assert.AreEqual(expectedPoints, result);
        }
    }
}
