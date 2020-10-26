using System;
using System.Collections.Generic;
using System.Text;

namespace JSON.NET
{
    [Serializable]
    class MyObjectClass
    {
        public class Movie
        {
            public string Name { get; set; }
            public double Rating { get; set; }
        }
    }
}
