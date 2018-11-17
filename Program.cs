﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackToSuccess.Basics;
using BackToSuccess.ListsAndArrays;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Threading;
using BackToSuccess.OopsConcepts;
using BackToSuccess.DS;
using BackToSuccess.Algorithm;
using BackToSuccess.Problems;

namespace BackToSuccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // BinaryTree.Execute();
            // PancakePackager.Execute();
            // LinearSearch.Execute();
            BinarySearch.Execute();
            stopwatch.Stop();
            // Write result.
            Console.WriteLine("Execution time: {0}", stopwatch.Elapsed);

            Console.ReadLine();
        }
    }
}