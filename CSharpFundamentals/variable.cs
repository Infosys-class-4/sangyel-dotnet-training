class Variable
{
    void LearnVariable()
    {
        byte a = 255;
        short b = 32353;
        int c = 424324234;
        long d = 32535245232532523;

        // Floating point (with decimal points) for float end with f, for decimal end with m bc system by default assumes double.
        // float type can accurately give decimal points upto 6
        // double upto 15. decimal upto 30 however takes up more memory
        float e = 234234.3453f;
        double f = 242243.23425;
        decimal g = 352353535.35353355m;

        //char only has single quotes vs string double quotes.
        //char h = 'M';

        // boollean 
        bool j = true;

        DateTime x = DateTime.Now;
        Console.WriteLine("Hello, World!");
        Console.WriteLine(x);

        string clientName = "Smith";
        byte age = 31;
        byte weight = 70;
        bool passportStatus = true;
        string Dob = "11/10/1991";
    }

}

// See https://aka.ms/new-console-template for more information

//string personName = "Bishnu";

// Camel casing: personheight, personHeight
// Pascal casing: PersonHeight 

// Numbers
// Integral typec

//byte a = 255;
//short b = 32353;
//int c = 424324234;
//long d = 32535245232532523;

// Floating point (with decimal points) for float end with f, for decimal end with m bc system by default assumes double.
// float type can accurately give decimal points upto 6
// double upto 15. decimal upto 30 however takes up more memory
//float e = 234234.3453f;
//double f = 242243.23425;
//decimal g = 352353535.35353355m;

//char only has single quotes vs string double quotes.
//char h = 'M';

// boollean 
//bool j = true;

