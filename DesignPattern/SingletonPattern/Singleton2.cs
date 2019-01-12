using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonPattern
{
    public class Singleton2//登記式/內部靜態class
    {
        private static class Singleton2Holder
        {
            public static readonly Singleton2 singleton = new Singleton2();
        }
        private Singleton2() { }
        public static Singleton2 GetSingleton()
        {
            return Singleton2Holder.singleton;
        }
        public void SingletonTest()
        {
            Console.WriteLine("=== Singleton2 Test Text ===");
        }
    }
}
