using System;
using static System.Console;
class InchesToCentimeters
{
    static void Main()
    {
        const double cpi = 2.54;
        double inches = 15994;

        double centimeters = inches * cpi;

      WriteLine(inches + " inches is " + centimeters + " centimeters.");
    }
} 