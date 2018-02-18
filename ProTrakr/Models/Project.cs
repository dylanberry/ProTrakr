using System;
namespace ProTrakr.Models
{
    public class Project
    {
        public string Name { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset CompletionData { get; set; }
    }
}
