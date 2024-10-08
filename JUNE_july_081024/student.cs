using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUNE_july_081024
{
    class person
    {
        public long adhar { get; set; }
        public string name { get; set; }
        public string PAN { get; set; }
    }
    internal class student:person
    {
        public int roll { get; set; }
        // public int[] sub { get; set; }
        public int[] sub;
        public int totalMarks { get; set; }
        public float per { get; set; }
        
        public void setInfo(long adhar,string nm,string PAN1,int r, int[]sb)
        {
            this.adhar = adhar;
            name = nm;
            PAN = PAN1;
            roll = r;
            try
            {
                sub = sb;
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //sub=new int[sb.Length];
            //sb.CopyTo(sub,0);
           // sub = (int[])sb.Clone();
         
            for (int i = 0; i < sub.Length; i++)
            {
                totalMarks += sub[i];
            }
            per = totalMarks / sub.Length;

        }
        public void showStudent()
        {
            Console.WriteLine();
            Console.Write($"Adhar :{adhar} Name :{name} PAN {PAN}");
            Console.Write($" roll :{roll} Total Marks :{totalMarks} Per {per}");

            
        }
    }
}
