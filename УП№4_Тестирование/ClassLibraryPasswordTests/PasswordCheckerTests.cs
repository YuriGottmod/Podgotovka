using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void ValidatePasswordTest()
        {
            string password = "ASqw12$$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_4Symbols_ReturnsTrue()
        {
            string password = "Aq1$";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowerSymbols_ReturnsTrue()
        {
            string password = "ASDqWE123$";
            bool expected = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowerSymbols_ReturnsFalse()
        {
            string password = "ASDQWE123$";
            bool expected = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_Password()
        {
            string password = "AAAAA";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_Password_P()
        {
            string password = "PPP";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_Password_D()
        {
            string password = "DDD";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_Passwor_T()
        {
            string password = "TTT";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_Password_Y()
        {
            string password = "YYY";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_Password_L()
        {
            string password = "LLL";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_Password_J()
        {
            string password = "jjjjjj";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }
    }
}