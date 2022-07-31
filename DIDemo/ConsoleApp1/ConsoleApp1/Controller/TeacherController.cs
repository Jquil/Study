using ConsoleApp1.BLL.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class TeacherController : IBaseController
    {
        public TeacherController(ITeacherBLL _BLL)
        {
            _BLL.SayName("TeacherController: Jq8686");
        }
    }
}
