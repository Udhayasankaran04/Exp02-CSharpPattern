# Exp02-CSharpPattern

## Aim:
To write a C# program for a pascal's triangle.

## Algorithm:

## Step1:
Begin by prompting the user to enter the number of rows for the pattern.

## Step2:
Read the input from the user and store it in a variable row. Initialize loop variables i and j to iterate over rows and columns respectively. Also, initialize variable c to hold the value of each element in the pattern.

## Step3:
Start a loop to iterate over each row (i), and within this loop, start another loop to print spaces before each element in the row. Inside the inner loop, print spaces based on the row number (row - i). Then, start another loop (j) to calculate and print the elements of the pattern for the current row.

## Step4:
Within the innermost loop, calculate the value of each element using the binomial coefficient formula (n choose k), where n is the row number and k is the column number. For each element, if j is 0 or equal to i, set c to 1, otherwise, update c by multiplying it with (i - j + 1) / j.

## Step5:
Inside the innermost loop, after calculating the value of c, print it followed by a space.

## Program:
```
using System;
public class Pattern
{
    public static void Main()
    {
    int r=Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<r;i++)
    {
        for(int s=0;s<r-i;s++)
        {
            Console.Write(" ")
            for( int j=0; j<i;j++)
            {
                if(i==0||j==0)
                {
                    c=1;
                }
                else
                {
                    c=c*(i-j+1)/i;
                    Console.Write(c+" ");
                }
            }

        }
    }   
    }
}

```
## Output:
![pattern](https://github.com/Udhayasankaran04/Exp02-CSharpPattern/assets/119393933/cc221efe-d8bc-44c2-8782-dcba6a59f568)

## Result:

Thus the above C# program for pascal's triangle is successfully executed
