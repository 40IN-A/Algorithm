using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadLine();
        }
    }

    public class BenchmarkClass
    {
        public int SumValueType(int value)
        {
            return 9 + value;
        }
        
        public int SumRefType(object value)
        {
            return 9 + (int)value;
        }

        [Benchmark]
        public void TestSum()
        {
            SumValueType(99);
        }

        [Benchmark]
        public void TestSumBoxing()
        {
            object x = 99;
            SumRefType(x);
        }

    }
}
