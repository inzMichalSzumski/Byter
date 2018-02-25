using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Byter
{
    class operations
    {
        public static void easyGetDirectories(String directory)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(directory, "*", SearchOption.AllDirectories);
                Console.WriteLine("Amount of directories: ", dirs.Length);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public static List<string> Getfiles(string path, string extension)
        {
            List<string> dirs = Directory.GetDirectories(path).ToList();
            List<string> files = new List<string>();
            int counter = 0;
            while (counter < dirs.Count)
            {
                try
                {
                    dirs.AddRange(Directory.GetDirectories(dirs[counter]));
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                try
                {
                    files.AddRange(Directory.GetFiles(dirs[counter], ("*" + extension)));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                counter++;
            }


            /*foreach(string s in dirs)
            {
                try
                {
                    files.AddRange(Directory.GetFiles(s, ("*" + extension)));
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                //Console.WriteLine(s);
            }

            foreach(string s in files)
            {
                Console.WriteLine(s);
            }*/

            return files;
        }

        public static void replacer(List<string> files, string s1, string s2)
        {
            foreach(string s in files)
            {
                byte[] buff = File.ReadAllBytes(s);
                
                for(int i = 0; i < 1; i++)
                {
                    Console.Write(buff[i].ToString("X"));
                    

                }
                Console.WriteLine("");
            }
        }


    }
}
