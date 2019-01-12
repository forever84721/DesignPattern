using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonPattern
{
    public class Singleton//餓漢式 ??
    {
        private Singleton() { }
        private static Singleton instance = new Singleton();
        public static Singleton GetSingleton()
        {
            return instance;
        }
        public void SingletonTest()
        {
            Console.WriteLine("=== Singleton Test Text ===");
        }
    }

}
