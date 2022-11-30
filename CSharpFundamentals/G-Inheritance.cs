using System;

class Mansion : House //single inheritance
{
    public Mansion()
    {

    }

    public Mansion(short nf, short nr) : base(nf, nr)
    {

    }
    float swimmingPoolArea;
    float numberOfHelipads;

    void CallStaff()
    {
        Console.WriteLine("clean swimming pool");
    }

}

class Palace : Mansion // multi-level inheritance
{
    short numberOfRoyalGuards;
}

class A
{
    public virtual void Sleep()
    {

    }
    public virtual float Sleep(int x, float r)
    {
        return r + x;
    }

}

interface IB //permits multiple inheritance in C# and Java//solely used for abstraction
{
    public void Start()
    {

    }
    public void Stop()
    {

    }
}

class C:IB
{


}

class D: A, IB // multiple inheritance
{
    public override float Sleep(int x, float y)
    {
        return 45.6f;
    }
} 

abstract class School
{

}