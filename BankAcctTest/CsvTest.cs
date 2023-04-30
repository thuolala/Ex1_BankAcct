using BankAcct;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAcct;

namespace BankAcctTest
{
    [TestClass]
    public class CsvTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data1.csv", "Data1#csv", DataAccessMethod.Sequential), DeploymentItem("Data1.csv")]
        public void Test_Credit()
        {
            string name = TestContext.DataRow[0].ToString();
            int balance = Convert.ToInt32(TestContext.DataRow[1]);
            int credit = Convert.ToInt32(TestContext.DataRow[2]);
            BankAccount ba = new BankAccount(name, balance);
            ba.Credit(credit);
            Assert.AreEqual(balance + credit , ba.Balance);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data1.csv", "Data1#csv", DataAccessMethod.Sequential), DeploymentItem("Data1.csv")]
        public void Test_Debit()
        {
            string name = TestContext.DataRow[0].ToString();
            int balance = Convert.ToInt32(TestContext.DataRow[1]);
            int debit = Convert.ToInt32(TestContext.DataRow[2]);
            BankAccount ba = new BankAccount(name, balance);
            ba.Debit(debit);
            Assert.AreEqual(balance - debit, ba.Balance);
        }
    }
}
