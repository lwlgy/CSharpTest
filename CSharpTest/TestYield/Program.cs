using System;
using System.Collections;

namespace TestYield
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List list = new List();
            IEnumerable items = list.ForExample();
            foreach (object item in items)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }

    public class List
    {
        public bool onOff = true;
        /// <summary>
        /// 第一次循环返回1 第二次返回2 第三次取决于onOff，为true时就break掉，后面的不再循环，否则继续循环输出后面的
        /// </summary>
        /// <returns></returns>
        public IEnumerable ForExample()
        {
            yield return "1"; // 第一次调用时执行  
            yield return "2"; // 第二次调用时执行  
            if (onOff) // 第三次调用时执行  
                yield break;
            // 否则,onOff为 false  
            yield return "3"; // 第四次调用时执行  
            yield return "4"; // 第五次调用时执行  
        }
    }
}