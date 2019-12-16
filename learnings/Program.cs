using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace learnings
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("enter text");
            string fullName = Console.ReadLine(); // "keerthi sai yanumula";
            string[] fname = fullName.Split(' ');
            string nameconverted = "";
            StringBuilder sb = new StringBuilder();
            foreach(var name in fname)
            {
                if(name.Length > 2)
                {
                    string distinct = new string(name.Substring(1, name.Length - 2).Distinct().ToArray());
                    nameconverted = $"{name[0]}{distinct.Length}{name[name.Length - 1]}";
                }
                else
                {
                    nameconverted = name;
                }
                sb.Append(nameconverted + " ");
            }
            string result = sb.ToString();
            Console.WriteLine(result);
            Console.ReadKey();
        }
       


    }
}
