using System;

namespace Dependencies
{
    class Program
    {
        static void Main()
        {
            ClassLibrary1.B.Print();
            ClassLibrary2.C.Print();            
            /* 假如使用“依赖项（.net core / .net standard）”的方式，
             * 即使只添加了 ClassLibrary1 的依赖，
             * 也可以访问到 ClassLibrary2 （自动添加了 ClassLibrary2 ）。
             */
        }
    }
}
