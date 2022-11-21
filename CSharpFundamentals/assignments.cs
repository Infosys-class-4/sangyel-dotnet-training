using System;

class Assignment
{
    public void question4()
    {
        int l = 0;
        for (int j = 1; j <= 3; j++)
        {
            for (int k = 1; k <= 4; k++)
            {
                l = l + 1;
                Console.Write(l + " ");
            }
            Console.WriteLine(" ");
        }
    }

    public void question6()
    {
        int ii, jj;
        for (ii = 1; ii < 90; ii++)
        {
            for (jj = 1; jj <= 10; jj++)
            {
                Console.WriteLine(ii + " * " + jj + " = " + ii * jj);
            }
        }
    }
}