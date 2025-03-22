// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
using System.Threading;
WriteLine("Hello");
Thread.Sleep(1000);
WriteLine("Watch this:");
Thread.Sleep(998);
char[] a = {'-','\\','|', '/','-','\\','|', '/'};
int i = 0;
while (true)
{
    if (i > )
        i = 0;
    Clear();
    Write(a[i]);
    Thread.Sleep(100);
    i++;
}
WriteLine("i'm the dumbest person on the planet...");