using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAcct;

namespace BankAcctTest
{
    [TestClass]
    public class BankAccountTest
    {
        [DataTestMethod]
        [DataRow("Pham Huynh Anh Thu", 50, 20)]
        [DataRow("Pham Huynh Yen Vi", 70, 50)]
        public void CheckBalanceAfterCredit(string name, int balance, int credit)
        {
            BankAccount ba = new BankAccount(name, balance);
            ba.Credit(credit);
            Assert.AreEqual(balance + credit, ba.Balance);
        }

        [DataTestMethod]
        [DataRow("Pham Huynh Anh Thu", 50, 20)]
        [DataRow("Pham Huynh Yen Vi", 70, 50)]
        public void CheckBalanceAfterDebit(string name, int balance, int debit)
        {
            BankAccount ba = new BankAccount(name, balance);
            ba.Debit(debit);
            Assert.AreEqual(balance - debit, ba.Balance);
        }
    }
}
