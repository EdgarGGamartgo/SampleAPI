using System;
using System.Collections.Generic;

namespace SampleAPI.Responses
{
    public class OrderResponse
    {
       public Guid Id {get; set;}
        public IEnumerable<string> ItemsIds {get; set;}
        public string Currency {get; set;}


    }
}

