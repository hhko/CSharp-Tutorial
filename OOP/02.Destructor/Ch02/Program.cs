using System;

namespace Ch02;

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();

        // e1 = null;
        // e2 = null;
        // e1.Dispose();
        // e2.Dispose();

        e1 = null;
        e2 = null;
        //GC.Collect(2, GCCollectionMode.Forced);
        // var x = GC.WaitForFullGCComplete(10000);
        // if (x == GCNotificationStatus.Succeeded)
        // {
        //     Console.WriteLine("GC");
        // }
        GC.WaitForPendingFinalizers();

        //Console.ReadKey();
    }
}