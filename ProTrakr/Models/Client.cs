using System;
using System.Collections.Generic;

namespace ProTrakr.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public IList<Project> Projects { get; } = new List<Project>();
    }
}
