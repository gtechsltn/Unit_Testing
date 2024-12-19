﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany.MyLib.Tests
{
    [TestClass]
    public class MyClassTest
    {
        [TestMethod]
        public void HasDuplicate_NormalCase_Returns_False()
        {
            //Arrange
            var arr = new int[] { 17213, 17214, 17215, 17212, 17211, 17208, 17209, 17210, 17207, 17205, 17206, 17204, 17203, 17202, 17191, 17192, 17189, 17190, 17175, 17172, 7104, 7105, 7106, 7107, 7108, 7109, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7117, 7118, 7119 };

            //Act
            IMyClass myClass = new MyClass();

            bool hasDuplicate = myClass.HasDuplicate(arr);

            //Assert
            Assert.AreEqual(false, hasDuplicate);
        }
    }
}