using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTextWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }

                myReader.Close();

            }
                catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. Are you sure the directory exists?");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. Are you sure you are looking for the correct file?");
            }
            catch (Exception e)
            {
                Console.WriteLine("doh, something wrong: {0}", e.Message);
            }
            finally
            {
                //Perform any cleanup to roll back the data or close connections
                // to files, databases, network, etc.

            }
            Console.ReadLine();
        }
    }
}
