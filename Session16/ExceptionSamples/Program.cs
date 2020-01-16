using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                A ref_A = null;
                int x = 10;
                int y = 0;
                ref_A.X = 150;
                int z = x / y;
                Console.WriteLine(z);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(string.Format(" Div0 Error : {0}",ex.Message));
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(string.Format("Null Error : {0}", ex.Message));
            }
            catch (Exception)
            {

                throw;
                //Console.WriteLine("E");
               
            }
            finally
            {
                System.Console.ReadLine();
            }
           
           
        }
    }
}
