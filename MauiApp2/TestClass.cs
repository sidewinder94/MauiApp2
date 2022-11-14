using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2;
public class TestClass
{
#if WINDOWS
    public static void HelloWindows()
    {
        Console.WriteLine("windows");
    }
#endif

#if ANDROID
    public static void HelloAndroid()
    {
        Console.WriteLine("android");
    }
# endif
}
