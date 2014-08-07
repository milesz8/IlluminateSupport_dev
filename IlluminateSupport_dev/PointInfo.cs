using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IlluminateSupport_dev
{
    class PointInfo
    {
        public string pointNumber { get; set; }
        public string summary { get; set; }
        public string type { get; set; }
        public string createdDate { get; set; }
        public string updatedDate { get; set; }
        public string state { get; set; }
        public string priority { get; set; }
        public string solution { get; set; }
        public string priorityID { get; set; }
        public List<Note> notes { get; set; }
        public string pointDescription { get; set; }
    }
}
