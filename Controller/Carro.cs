using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_LG.Controller
{
    public class Carro
    {

        public int Id_carro {  get; set; }  
        public string Name { get; set; }
        public string Placa { get; set; }
        public int Id_motorista_principal { get; set; } ///chave de relacionamento com a tabela motorista
        public int Id_motorista_adicional { get; set; } ///chave de relacionamento com a tabela motorista



    }
}
