using ConsoleApp1.BLL.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BLL.BLL
{
    public class StudentBLL : IStudentBLL
    {
        public void SayName(string name)
        {
            Console.WriteLine($"StudentBLL.SayName：{name}");
        }
    }
}
