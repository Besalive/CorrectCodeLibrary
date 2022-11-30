using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorrectCodeLibrary;

namespace CorrectCodeLibraryTests
{
    [TestClass]
    public class CorrectCodeClassTests
    {
        /// <summary>
        /// Позитивный тест
        /// </summary>
        [TestMethod]
      
        public void IsCorrectCode_normal()
            
        {
           
            //arrange
            string cod = "1234123400";
            //act
            CorrectCodeClass obj = new CorrectCodeClass();
            bool actual = obj.IsCorrectCode(cod);
            //assert
            Assert.AreEqual(true,actual);
        }
        /// <summary>
        /// Тест на пустую строку
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_null()
        {
            //arrange
            string cod = "";
            //act
            CorrectCodeClass obj = new CorrectCodeClass();
            bool actual = obj.IsCorrectCode(cod);
            //assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Тест на лимит символов
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_outlimit()
        {
            //arrange
            string cod = "123123123123123";
            //act
            CorrectCodeClass obj = new CorrectCodeClass();
            bool actual = obj.IsCorrectCode(cod);
            //assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Тест на наличие в коде меньше 10 символов
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_smalllimit()
        {
            //arrange
            string cod = "123";
            //act
            CorrectCodeClass obj = new CorrectCodeClass();
            bool actual = obj.IsCorrectCode(cod);
            //assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Тест на некоректные символы
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_uncorsym()
        {
            //arrange
            string cod = "strokasymb";
            //act
            CorrectCodeClass obj = new CorrectCodeClass();
            bool actual = obj.IsCorrectCode(cod);
            //assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Отрицательный тест на котрольную цифру 0
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_falsecodzero()
        {
            //arrange
            string cod = "1234123401";
            //act
            CorrectCodeClass obj = new CorrectCodeClass();
            bool actual = obj.IsCorrectCode(cod);
            //assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Отрицательный тест на котрольную цифру 1
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_falsecodone()
        {
            //arrange
            string cod = "3000030001";
            //act
            CorrectCodeClass obj = new CorrectCodeClass();
            bool actual = obj.IsCorrectCode(cod);
            //assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Отрицательный тест на котрольную цифру 9
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_falsecodnien()
        {
            //arrange
            string cod = "3000130009";
            //act
            CorrectCodeClass obj = new CorrectCodeClass();
            bool actual = obj.IsCorrectCode(cod);
            //assert
            Assert.AreEqual(false, actual);
        }
    }
}
