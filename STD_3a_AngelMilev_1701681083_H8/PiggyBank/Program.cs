﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumb = 0;

            double sqrt = 0;

            double sum = 0;



            for (int i = 1; i <= 30; i++)

            {

                randomNumb = random.Next(1, 999 * 999 + 1);

                sqrt = Math.Sqrt(randomNumb);

                if (sqrt >= 1 && sqrt <= 300)

                {

                    sum += sqrt * 5.1d;

                }

                else if (sqrt >= 301 && sqrt <= 600)

                {

                    sum += sqrt * 10.098d;

                }

                else

                {

                    sum += sqrt * 100.00001d;

                }

            }

            Console.WriteLine("The savings for one month are " + Math.Round(sum, 4).ToString("#0.0000"));




            
        }
    } }

          


     
