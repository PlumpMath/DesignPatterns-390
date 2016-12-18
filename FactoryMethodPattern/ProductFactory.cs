using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class ProductFactory
    {
        /**seri numarasinin sequential artan bir numara oldugunu varsayalim*/
        private static int _serialNumber = 0;

        public IProduct makeProduct()
        {
            String serialNumber = generateSerialNumber();
            return new Product(serialNumber);
        }

        private String generateSerialNumber()
        {
            return (++_serialNumber) + "";
        }
    }
}
