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