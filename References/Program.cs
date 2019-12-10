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
             * 则不能访问到 ClassLibrary2 。
             */
        }
    }
}
