﻿using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            // Case 1
            Console.WriteLine("Start of case 1");
            for (int i = 0; i < 15; i = i + 3)
            {
                 Console.WriteLine(i); // Uncomment to see result
            }
            Console.WriteLine("End of case 1");


            // Case 2
            Console.WriteLine("Start of case 2");
            for (int i = 10; i >= 3; i--)
            {
                 Console.WriteLine(i); // Uncomment to see result
            }
            Console.WriteLine("End of case 2");


            //case 3a - for loop of 3:
            Console.WriteLine("Start of case 3a");
            for (int i = 2; i <= 12; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of case 3a");

            // Case 3 - Change this to a for-loop!
            Console.WriteLine("Start of case 3");
            int c3 = 0;
            while (c3 < 12)
            {
                c3 = c3 + 2;
                Console.WriteLine(c3);
            }
            Console.WriteLine("End of case 3");

            // case 4a - for loop of 4:
            Console.WriteLine("Start of case 4a");
            for (int i = 0; i < 50; i = (i *2) + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of case 4a");

            // Case 4 - Change this to a for-loop!
            Console.WriteLine("Start of case 4");
            int c4 = 0;
            while (c4 < 50)
            {
                Console.WriteLine(c4);
                c4 = c4 * 2 + 2;
            }
            Console.WriteLine("End of case 4");

            // The LAST line of code should be ABOVE this line
        }
    }
}
