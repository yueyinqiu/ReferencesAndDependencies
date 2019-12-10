using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    class Program
    {
        static void Main()
        {
            ClassLibrary1.B.Print();
            ClassLibrary2.C.Print();
            /* 假如使用“引用（.net framework）”的方式，
             * 若添加了 ClassLibrary1 的引用，
             * 则不能直接访问到 ClassLibrary2 （但可以经过 ClassLibrary1 间接访问），
             * 除非也同时添加了 ClassLibrary2 。
             */
        }
    }
}
