using System.Threading;
using System;

namespace CSharpTutorial.Threading;

//https://leetcode.com/problems/print-in-order/
public class Foo
{
    private static SemaphoreSlim s1;
    private static SemaphoreSlim s2;

    public Foo()
    {
        s1 = new SemaphoreSlim(0, 1);
        s2 = new SemaphoreSlim(0, 1);
    }

    public void First(Action printFirst)
    {
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        s1.Release();
    }

    public void Second(Action printSecond)
    {
        // printSecond() outputs "second". Do not change or remove this line.
        s1.WaitAsync();
        printSecond();
        s2.Release();
    }

    public void Third(Action printThird)
    {
        s2.WaitAsync();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
        s2.Release();
    }
}
