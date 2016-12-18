using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{

    public class Product : IProduct
    {
       private  String _serialNumber;
       private DateTime _productDate;

    public Product(String serialNumber)
    {
        _serialNumber = serialNumber;
        _productDate = new DateTime();
    }
         
       public String getProductName()
    {
        return "i am product";
    }
         
       public String getProductSerialNumber()
    {
        return _serialNumber;
    }
         
       public DateTime getProductionDate()
    {
        return _productDate;
    }

        DateTime IProduct.getProductionDate()
        {
            throw new NotImplementedException();
        }
    }
}
