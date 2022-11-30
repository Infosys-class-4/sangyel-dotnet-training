// Think of a real world class which contains:
// 3 fields,
// a parameterless constructor,
// a constructor with 2 parameters and
// a method
// a property with full definition
// a read only property

//namespace Bonds;
using System;

class Mortgage
{
    byte amortization;
    int amount;
    short term;
    bool fixedOrVariable;
    float rates;
    public float payment{get; set;}
    public Mortgage()
    {

    }

    public Mortgage(int principal, byte months, float interestRate, float pmt)
    {
        amount = principal;
        amortization = months;
        rates = (interestRate/12)/100;
        payment = pmt;
    }

    public double GetMonthlyPayments() => amount * (rates * Math.Pow( 1+rates, amortization) ) / (Math.Pow( 1+rates, amortization-1) );

}
