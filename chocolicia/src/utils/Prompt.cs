using chocolicia.src.models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chocolicia.src.models.errors;

namespace chocolicia.src.utils
{
    public class Prompt
    {
        public void ask(string message)
        {
            Console.WriteLine(message);
        }

        public string askSexCat()
        {
            Console.Write("Entre com o sexo do seu felino, digite 0 para masculino e 1 para feminino: ");
            string sexCat = Console.Read().ToString();

            if (sexCat != SexCat.MALE.ToString() && sexCat != SexCat.FEMALE.ToString())
            {
                throw new SexCatExceptions("Deu ruim");
            }

            return sexCat;
        }
    }
}
