using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DI
{
    public class Container : IContainer
    {
        Dictionary<string, List<DIType>> _container = null;

        public Container(Dictionary<string, List<DIType>> container)
        {
            _container = container;
        }

        public T ResolveNamed<T>() where T : class
        {
            string key = typeof(T).FullName;
            List<DIType> values;
            _container.TryGetValue(key, out values);
            return Make<T>(values[0]);
        }

        public T ResolveNamed<T>(string name) where T : class
        {
            string key = typeof(T).FullName;
            List<DIType> values;
            _container.TryGetValue(key, out values);
            foreach(var type in values)
            {
                if(type.name == name)
                {
                    return Make<T>(type);
                }
            }
            throw new Exception($"Container.ResolveNamed(string Name) Error：在'{key}'中找不到'{name}'的类别");
        }

        private T Make<T>(DIType dIType) where T : class
        {
            Type type = Type.GetType(dIType.qualifiedName);

            // 构造器注入
            ConstructorInfo[] constructors = type.GetConstructors();
            var constructorsCount = constructors.Length;
            if(constructorsCount == 0)
            {
                return Activator.CreateInstance(type) as T;
            }
            else
            {
                ParameterInfo[] parameters = constructors[0].GetParameters();
                List<object> paramtersValue = new List<object>();
                var parametersCount = parameters.Length;
                for (var j = 0; j < parametersCount; j++)
                {
                    var paramter = parameters[j];
                    Type thisType = GetType();
                    MethodInfo resolve = thisType.GetMethod("ResolveNamed", new Type[] { }).MakeGenericMethod(paramter.ParameterType);
                    object obj = resolve.Invoke(this, new object[] { });
                    paramtersValue.Add(obj);
                }
                return Activator.CreateInstance(type, paramtersValue.ToArray()) as T;
            }
        }
    }
}
