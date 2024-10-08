using JUNE_july_081024.Collection081024;

namespace JUNE_july_081024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception Q14
            //student[] s = new student[2];
            //int[] sb = new int[5];
            //long adhar;
            //string nm;
            //string PAN1;
            //int r;
            //try
            //{

            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine("enter adhar number , name and PAN number of student");
            //    adhar=long.Parse(Console.ReadLine());
            //    nm=Console.ReadLine();
            //    PAN1 = Console.ReadLine();
            //    Console.WriteLine("enter roll number:");
            //    r=int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter 5 subject marks:");
            //        try
            //        {
            //            for (int j = 0; j < sb.Length; j++)
            //            {
            //                sb[j] = int.Parse(Console.ReadLine());
            //            }
            //            try
            //            {
            //                s[i] = new student();
            //                s[i].setInfo(adhar, nm, PAN1, r, sb);
            //            }
            //            catch (NullReferenceException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //        }
            //        catch (IndexOutOfRangeException ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }
             
                
            //}
            //Console.WriteLine("all student info");
            //for (int i = 0; i < s.Length; i++)
            //{
            //    s[i].showStudent();
            //}

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            ArrayListDemo Obj=new ArrayListDemo();
            Obj.UseArrayList();
        }
    }
}
