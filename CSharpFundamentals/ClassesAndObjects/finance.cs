// Think of a real world class which contains:
// 3 fields,
// a parameterless constructor,
// a constructor with 2 parameters and
// a method
// a property with full definition
// a read only property

namespace Bonds;
using System;

class Mortgage
{
    public byte amortization;
    int amount;
    public byte term;
    bool fixedOrVariable;
    float rates;
    public float payment(get; set;)
    public Mortgage()
    {

    }

    public Mortgage(byte months, float interestRate, float pmt)
    {
        amortization = months;
        rates = (interestRate/12)/100;
        payment = pmt;
    }

    public float GetMonthlyPayments() => amount[rates*Math.Pow(1+rates,months)]/[Math.Pow(1+rates,GetMonthlyPayments-1)];

}
