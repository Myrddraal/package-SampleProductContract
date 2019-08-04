using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace SampleProductContract
{
    // This contract will be shared between server and clients
    public class SampleProduct
    {
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
    }
}
