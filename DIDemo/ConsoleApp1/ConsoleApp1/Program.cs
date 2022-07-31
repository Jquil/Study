using ConsoleApp1.Application;
using ConsoleApp1.BLL.IBLL;
using ConsoleApp1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApp.InitContainer();
            IBaseController controller1 = MyApp.Container.ResolveNamed<IBaseController>(typeof(StudentController).Name);
            IBaseController controller2 = MyApp.Container.ResolveNamed<IBaseController>(typeof(TeacherController).Name);
            Console.ReadKey();
        }
    }
}
