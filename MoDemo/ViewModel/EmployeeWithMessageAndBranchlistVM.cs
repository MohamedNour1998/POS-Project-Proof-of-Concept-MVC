using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo.ViewModel
{
    public class EmployeeWithMessageAndBranchlistVM
    {
        public string Message { get; set; }
        public List<string> branch { get; set; }
        public int temp { get; set; }
        public string EmpName { get; set; }
        public int EmpId { get; set; }
    }
}
