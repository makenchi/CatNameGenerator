using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chocolicia.src.utils;

namespace chocolicia
{
    class Program
    {
        static void Main(string[] args)
        {

            Prompt _prompt = new Prompt();
                        
            try
            {
                string sexCat = _prompt.askSexCat();
            }
            catch (Exception err)
            {
                Console.WriteLine("Bad Input X-X -> " + err.Message);
                Console.ReadKey();
            }
        }
    }
}
