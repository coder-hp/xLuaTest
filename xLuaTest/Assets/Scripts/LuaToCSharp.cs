using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLua;

[LuaCallCSharp]
class LuaToCSharp
{
    public int num = 12;
    public static int num_static = 13;

    public int CSharpAdd(int a, int b)
    {
        return a + b;
    }

    public static int CSharpAdd_Static(int a, int b)
    {
        return a + b;
    }
}