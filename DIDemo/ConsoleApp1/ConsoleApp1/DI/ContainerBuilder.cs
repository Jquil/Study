using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DI
{
    public class ContainerBuilder : IContainerBuilder
    {
        Dictionary<string, List<DIType>> container = new Dictionary<string, List<DIType>>();

        DIType tempType = null;

        public IContainer Build()
        {
            return new Container(container);
        }

        public IContainerBuilder Named<T>()
        {
            string key = typeof(T).FullName;
            Add(key);
            return this;
        }

        public IContainerBuilder Named<T>(string name)
        {
            string key = typeof(T).FullName;
            tempType.name = name;
            Add(key);
            return this;
        }

        public IContainerBuilder RegisterType<T>()
        {
            tempType = new DIType()
            {
                name = "",
                qualifiedName = typeof(T).FullName
            };
            return this;
        }

        /// <summary>
        /// 将注册类信息添加进字典
        /// </summary>
        /// <param name="key"></param>
        private void Add(string key)
        {
            bool isExit = container.ContainsKey(key);
            if (isExit)
            {
                List<DIType> models;
                container.TryGetValue(key, out models);
                models.Add(tempType);
            }
            else
            {
                List<DIType> models = new List<DIType>() { tempType };
                container.Add(key, models);
            }
        }
    }
}
