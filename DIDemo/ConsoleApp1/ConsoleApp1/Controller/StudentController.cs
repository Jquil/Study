using ConsoleApp1.BLL.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class StudentController : IBaseController
    {
        public StudentController(IStudentBLL _BLL)
        {
            _BLL.SayName("StudentController: Jq8686");
        }
    }
}
