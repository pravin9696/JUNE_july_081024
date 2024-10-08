using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace JUNE_july_081024.Collection081024
{
    internal class ArrayListDemo
    {
        public void UseArrayList()
        {
           ArrayList ar1 = new ArrayList(4);
            
            ar1.Add(111);//0 index
            ar1.Add( "pune");//1 index
            ar1.Add(3.14);//2 index 3.14
            ArrayList ar2 = new ArrayList();
            ar2.Add("this is first element");//0 index element
            //for (int i = 0; i < ar1.Count; i++)
            //{
            //    ar2.Add(ar1[i]);
            //}

            ar2.Add(ar1);//1 index 

            Console.WriteLine("elements in ar2");
            //foreach (var item in ar2)
            //{
            //    Console.WriteLine(item);
            //}

            var x = ar2[0];
           // Console.WriteLine(x);
            //var y=ar2[1];
            //ArrayList temp = (ArrayList)y;
            //foreach (var item in temp)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in (ArrayList)ar2[1])
            //{
            //    Console.WriteLine(item);
            //}

            int[] aa = new int[] { 1, 2, 3, 4, 5 };
            ar2.AddRange(aa);
            for (int i = 0; i < ar2.Count; i++)
            {
                if (i==2)
                {
                    Console.WriteLine("-----------------");
                    foreach (var item in (ArrayList)ar2[i])
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-----------------");
                }
                else
                Console.WriteLine(ar2[i]);
            }
        }
    }
}
