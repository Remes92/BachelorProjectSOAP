using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BachelorProjectBackend.Models;


namespace BachelorProjectSOAP
{
    /// <summary>
    /// Summary description for SoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class SoapService : System.Web.Services.WebService
    {
        //Mongo funktioner
        [WebMethod]
        public List<test> TestCase1Mongo(int num)
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }

        [WebMethod]
        public List<test> TestCase2Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase3Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase4Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase5Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase6Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase7Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase8Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase9Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase10Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase11Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase12Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase13Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase14Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase15Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase16Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase17Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase18Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }

        //MySql Funktioner. 
        [WebMethod]
        public List<test> TestCase1MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase2MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase3MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase4MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase5MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase6MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase7MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase8MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase9MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase10MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase11MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase12MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase13MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase14MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase15MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase16MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase17MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
        [WebMethod]
        public List<test> TestCase18MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
    }
}
