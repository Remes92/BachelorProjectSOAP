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
        [WebMethod]

        public List<test> TestCase1Mongo()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }

        [WebMethod]
        public List<test> TestCase1MySql()
        {
            return BachelorProjectBackend.SqlRepo.test.test1();
        }
    }
}
