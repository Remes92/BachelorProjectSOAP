using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BachelorProjectBackend.Models;
using BachelorProjectBackend.Repository;


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
    public class SoapService : WebService
    {
        //Mongo functions
        [WebMethod]
        public Product TestCase1Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeById(id);
            return product;
        }

        [WebMethod]
        public Product TestCase2Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase3Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeAndCompanyById(id);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase4Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase5Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase6Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeAndCompanyById(lower, upper);
            return product;
        }
        [WebMethod]
        public Product TestCase7Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase8Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase9Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeAndCompanyById(id);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase10Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase11Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase12Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeAndCompanyById(lower, upper);
            return product;
        }
        [WebMethod]
        public Product TestCase13Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase14Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase15Mongo(int id)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeAndCompanyById(id);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase16Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase17Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase18Mongo(int lower, int upper)
        {
            MongoHandler mongohandler = new MongoHandler();
            var product = mongohandler.GetProductJoinProductTypeAndCompanyById(lower, upper);
            return product;
        }

        //MySql Functions
        [WebMethod]
        public Product TestCase1MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase2MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase3MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeAndCompanyById(id);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase4MySql(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase5MySql(int lower,int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase6MySql(int lower,int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var products = sqlhander.GetProductJoinProductTypeAndCompanyById(lower, upper);
            return products;
        }
        [WebMethod]
        public Product TestCase7MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase8MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase9MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeAndCompanyById(id);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase10MySql(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase11MySql(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase12MySql(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var products = sqlhander.GetProductJoinProductTypeAndCompanyById(lower, upper);
            return products;
        }
        [WebMethod]
        public Product TestCase13MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase14MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(id);
            return product;
        }
        [WebMethod]
        public Product TestCase15MySql(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeAndCompanyById(id);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase16MySql(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase17MySql(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(lower, upper);
            return product;
        }
        [WebMethod]
        public List<Product> TestCase18MySql(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var products = sqlhander.GetProductJoinProductTypeAndCompanyById(lower, upper);
            return products;
        }
    }
}
