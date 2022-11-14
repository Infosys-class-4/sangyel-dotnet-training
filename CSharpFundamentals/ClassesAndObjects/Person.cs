// Programming Paradigms

// procedural language - C, PASCAL, BASIC, Go
// imperative: Go, C# each and every step needs to be defined - C, C, C++
// declarative: python, C# 
// object oriented - c#, java, python, C++
// functional - E.G. F#, scala, Haskell, C#
// dynamic: JS, ruby, python
// static: c#, java, C++, C

// C# is a multi-paradigm language

// shift alt f - for indentation


class Person 
{
    public string name;
    public byte age;
    
    public string GetLegalGreeting()
    {
        if(age < 18)
        {
            return "You are under age";
        }
        else
        {
            return "You are of legal age";
        }

    }

}

