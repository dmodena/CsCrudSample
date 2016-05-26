using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        private int id;
        private string nome;

        public string Nome
        {
            get { return nome; }
            set 
            {
                if (value.Length > 100)
                {
                    throw new Exception("Nome permite até 100 caracteres");
                }
                else {
                    nome = value;
                }
            }
        }

    }
}
