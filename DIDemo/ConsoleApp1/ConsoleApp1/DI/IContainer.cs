using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DI
{
    public interface IContainer
    {
        /// <summary>
        /// 获取注册类
        /// </summary>
        /// <typeparam name="T">父类</typeparam>
        /// <returns></returns>
        T ResolveNamed<T>() where T : class;


        /// <summary>
        /// 获取注册类
        /// </summary>
        /// <typeparam name="T">父类</typeparam>
        /// <param name="name">别名</param>
        /// <returns></returns>
        T ResolveNamed<T>(string name) where T : class;
    }
}
