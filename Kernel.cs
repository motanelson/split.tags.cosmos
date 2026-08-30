using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Cosmostags
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            while (true) 
            {
                tagsplint.Main();
                var input = Console.ReadLine();
            
            
            }
            
            
        }
    }
    class splits
    {
        public static String[] tags(String strings, String separator1, String separator2)
        {
            String[] s = { };
            int i = 0;
            String ss = strings;
            while (true)
            {
                i = ss.IndexOf(separator1);
                if (i == -1)
                {
                    Array.Resize(ref s, s.Length + 1);
                    s[s.Length - 1] = ss;
                    break;
                }

                Array.Resize(ref s, s.Length + 2);
                s[s.Length - 2] = ss.Substring(0, i);
                s[s.Length - 1] = "";
                ss = ss.Substring(i);
                i = ss.IndexOf(separator2);
                if (i == -1)
                {
                    s[s.Length - 1] = ss;
                    break;
                }

                s[s.Length - 1] = ss.Substring(0, i + 1);
                if (i + separator2.Length >= ss.Length - 1) break;
                ss = ss.Substring(i + separator2.Length);




            }


            return s;



        }



    }

    class splitstests
    {
        public static void mainloop()

        {
            String s = "<html><head><title>hello world</title></head><body tag='####'><h1>hello world</h1></body></html>";
            String[] ss = splits.tags(s, "<", ">");
            foreach (var sss in ss)
            {
                Console.WriteLine(sss);


            }


        }



    }











    class tagsplint


    {
        public static void Main()
        {

 
            splitstests.mainloop();



        }




    }


}
