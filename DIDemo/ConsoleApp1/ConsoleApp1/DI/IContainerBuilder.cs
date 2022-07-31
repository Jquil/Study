using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DI
{
    public interface IContainerBuilder
    {
        /// <summary>
        /// 注册类
        /// </summary>
        /// <typeparam name="T">类</typeparam>
        /// <returns></returns>
        IContainerBuilder RegisterType<T>();


        /// <summary>
        /// 命名类
        /// </summary>
        /// <typeparam name="T">父类</typeparam>
        /// <returns></returns>
        IContainerBuilder Named<T>();


        /// <summary>
        /// 命名类
        /// </summary>
        /// <typeparam name="T">父类</typeparam>
        /// <param name="name">别名</param>
        /// <returns></returns>
        IContainerBuilder Named<T>(string name);


        /// <summary>
        /// 构建容器
        /// </summary>
        /// <returns></returns>
        IContainer Build();
    }
}
