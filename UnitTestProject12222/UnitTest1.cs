using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using System;
using ClassLibrary1;

namespace UnitTestProject12222
{
    [TestClass]
    public class UnitTest1
        
    { DB db;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=stroi_modern2;User Id=postgres;Password=1111;");

        [TestMethod]
        public void TestMethod1()
        {
            
            
                Assert.IsFalse(db.Login_check("nonexistent_user"));
            }

        }
        }
    