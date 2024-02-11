using System;
using System.Threading;

namespace CSharpTutorial.Threading;

//https://leetcode.com/problems/print-foobar-alternately/
public class FooBar
{
    private int n;

    private static SemaphoreSlim s1;
    private static SemaphoreSlim s2;

    public FooBar(int n)
    {
        this.n = n;
        s1 = new SemaphoreSlim(1, 1);
        s2 = new SemaphoreSlim(0, 1);
    }

    public void Foo(Action printFoo)
    {

        for (int i = 0; i < n; i++)
        {
            s1.Wait();
            // printFoo() outputs "foo". Do not change or remove this line.
            printFoo();
            s2.Release();
        }
    }

    public void Bar(Action printBar)
    {

        for (int i = 0; i < n; i++)
        {
            s2.Wait();
            // printBar() outputs "bar". Do not change or remove this line.
            printBar();
            s1.Release();
        }
    }
}
