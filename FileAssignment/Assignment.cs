using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignment
{
    class Assignment
    {


        static void WriteFi(string fileName, string s)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                byte[] c = Encoding.ASCII.GetBytes(s);
                fs.Write(c, 0, c.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Flush();
                fs.Close();
            }
        }
        static void ReadFi(string fileName)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                byte[] b = new byte[1024];
                int bd = fs.Read(b, 0, b.Length);
                Console.WriteLine("The content in the file is: " + Encoding.ASCII.GetString(b, 0, b.Length));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Flush();
                fs.Close();
            }
        }
        static void Main(string[] args)
        {
            String str = null;
            bool b;
            string d1;
            Console.WriteLine("Enter  the text to show in the  file:");
            do
            {
                b =true;
             
                str = str + Console.ReadLine();
   
                d1 = Console.ReadLine();
                if (d1.Equals("N"))
                {
                    b = false;
                }
            } while (b);

            String fileName = @"F:\FilesAssign.txt";

            WriteFi(fileName, str);
            ReadFi(fileName);

        }

    }
}
