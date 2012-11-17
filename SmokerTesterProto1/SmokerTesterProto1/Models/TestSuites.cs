using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmokerTesterProto1.Models
{
    public class TestSuite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Test> Tests { get; set; }
    }

    public class Test
    {
        public string Uri { get; set; }
        public string Description { get; set; }
    }
}