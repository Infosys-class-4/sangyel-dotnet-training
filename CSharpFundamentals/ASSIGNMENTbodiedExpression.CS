using System;

class BodiedExpression
{
    int a=0;
    int b=0;
    public int Method1(int c,int d)
    {
        var e = c*d;
        return e;
    }
    public int Method2(int aa, int bb, int cc = 0) => aa + bb + cc;
    public (int, int) Method3(int aaa, int bbb)
    {
        var ccc=aaa+bbb;
        var ddd=aaa*bbb;
        return (ccc,ddd);
    }

}