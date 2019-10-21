using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem.Models {
    public class Objeto {
        string[] lixos = { };

        public string ReciclarLixo () {
            int lixo = new Random ().Next (lixos.Length - 1);
            return lixos[lixo];
        }
    }

}