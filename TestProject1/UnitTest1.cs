using NUnit.Framework;
using System.Data;
using ClassLibrary1;

namespace TestProject1
{
    public class Tests
    {
        DB db;
        [SetUp]
        public void Setup()
        {
            db = new DB();
        }

        [Test]
        public void Test_open_conn_true()
        {
            db.Open_conn();
            Assert.IsTrue(db.Get_conn().State == System.Data.ConnectionState.Open);
        }
        [Test]
        public void TestGet_conn_false()
        {
            Assert.IsTrue(db.Get_conn().State == System.Data.ConnectionState.Closed);
        }
        [Test]
        public void Test_Account_create_true()
        {
            string username = "test_username";
            string password = "test_password";

            
            bool result = db.Account_create(username, password);

          
            Assert.IsTrue(result);

                    
        }
        [Test]
        public void Test_get_login_true()
        {
            Assert.IsTrue(db.Login_check("test1212"));
        }
        [Test]
        public void Test_acc_create_true()
        {
            Assert.IsTrue(db.Account_create("test0", "test0"));
        }


    }
}