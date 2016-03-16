using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace YouTrackSharp.Issues
{
    public class Workitem : DynamicObject
    {
        public string url { get; set; }
        public string id { get; set; }
        public DateTime date { get; set; }
        public int duration { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string worktype { get; set; }
    }
}
