using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    /// <summary>
    /// 反射类
    /// </summary>
    public class ReflectU
    {
        /// <summary>
        /// 初始化容器
        /// </summary>
        /// <param name="map">映射</param>
        /// <param name="root">源</param>
        public Dictionary<int, MethodInfo> InitContainer(Type map,Type root)
        {
            Dictionary<int, MethodInfo> dic = new Dictionary<int, MethodInfo>();
            var mMap = map.GetMembers(BindingFlags.NonPublic| BindingFlags.Default | BindingFlags.Instance);
            var mRoot = root.GetMembers(BindingFlags.Static | BindingFlags.Public);
            for(var i = 0; i < mRoot.Length; i++)
            {
                var tR = mRoot[i];
                for(var j = 0; j < mMap.Length; j++)
                {
                    var tM = mMap[j];
                    if(tR.Name == tM.Name)
                    {
                        var v = (int)root.GetField(tR.Name,BindingFlags.Static | BindingFlags.Public).GetValue(null);
                        var m = map.GetMethod(tM.Name, BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Instance);
                        dic.Add(v, m);
                    }
                }
            }
            return dic;
        }
    }
}
