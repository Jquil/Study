using ConsoleApp1.BLL.BLL;
using ConsoleApp1.BLL.IBLL;
using ConsoleApp1.Controller;
using ConsoleApp1.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Application
{
    public class MyApp
    {
        public static IContainer Container;

        /// <summary>
        /// 初始化容器
        /// </summary>
        public static void InitContainer()
        {
            IContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<StudentBLL>().Named<IStudentBLL>();
            builder.RegisterType<TeacherBLL>().Named<ITeacherBLL>();
            builder.RegisterType<StudentController>().Named<IBaseController>(typeof(StudentController).Name);
            builder.RegisterType<TeacherController>().Named<IBaseController>(typeof(TeacherController).Name);
            Container = builder.Build();
        }
    }
}
