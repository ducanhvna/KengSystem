using LibKengModel;
using KengService.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KengService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        PGDbContext m_context = new PGDbContext();
        public Service1()
        {
            m_context = new PGDbContext();
        }
        public string GetData(int value)
        {
            var data = m_context.Customers.ToList();
            var productData = m_context.Products.ToList();
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="composite"></param>
        /// <returns></returns>
        public ListStoreSupported GetListStoreSupported(ListStoreSupported composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            composite.StoreCategories = new List<StoreSupported>();
            composite.StoreCategories.Add(
                new StoreSupported
                {
                    id = 1,
                    name = "sssssssss",
                }
                );
            return composite;
        }

      
    }
}
