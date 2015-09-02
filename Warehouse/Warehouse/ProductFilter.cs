using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class ProductFilter
    {
        //DataClassesDataContext dc = new DataClassesDataContext();

        //public List<Product> ProductPriceRange(int Min, int Max)
        //{
        //    var query = dc.Products
        //        .Where(p => p.PriceDKK < Min && p.PriceDKK > Max);

        //    return (IEnumerable<Product>)query;
        //}

        internal static IEnumerable<Product> ProductPriceRange(int Min, int Max)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query = dc.Products
                .Where(p => p.PriceDKK > Min && p.PriceDKK < Max);

            return query;
        }
    }
}
