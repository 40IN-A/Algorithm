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
        }
    }

    public class BenchmarkClass
    {
        public static int SizeOfData = 10000;
        public static int SizeOfSingleString = 20;
        public string[] StringArray;
        public HashSet<string> hashSet;
        public BenchmarkClass()
        {
            StringArray = new string[SizeOfData];
            hashSet = new HashSet<string>();

            var rnd = new Random();
            for (int i = 0; i < StringArray.Length; i++)
            {
                byte[] byteArray = new byte[SizeOfSingleString];
                rnd.NextBytes(byteArray);
                string str = Encoding.UTF8.GetString(byteArray);
                StringArray[i] = str;
                hashSet.Add(str);
            }
        }

        [Benchmark]
        public void SearchStringArray()
        {
            string str = "flag";
            for (int i = 0; i < StringArray.Length; i++)
            {
                if (str == StringArray[i])
                {
                    str = "";
                }       
            }
        }

        [Benchmark]
        public void SearchStringHash()
        {
            string str = "flag";
            hashSet.Contains(str);
        }

    }
}
