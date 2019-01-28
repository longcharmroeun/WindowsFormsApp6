using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ProcessData
    {
        public string Title { get; set; }
        public string Process_ID { get; set; }
        public string Process_Name { get; set; }
        public string Location { get; set; }
        public string Parent_ID { get; set; }
        public string Parent_Location { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
