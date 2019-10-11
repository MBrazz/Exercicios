namespace ByteBank {
    public class ContaCorrente {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _Saldo;

        private double Saldo {
            get { return _Saldo; }
        }


        public ContaCorrente (int Agencia, int Numero, string Titular) {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this._Saldo = 0.0;
        }

        public bool Deposito (double valor){
            if (valor >= 0)
            {
                this._Saldo += valor;
            return true;
            } else
            {
               return false;
            }
        }

        public bool Saque (double valor) {
            if(valor >= 0){
            if (this._Saldo >= valor) {
                this._Saldo -= valor;
                return true;
            } else {
                return false;
            }
            }
         return false;
        }
           
        
        public bool transferencia (ContaCorrente contaDestino, double valor) {
            if (this.Saque (valor)) {
                contaDestino.Deposito (valor);
                return true;
            } else {
                return false;
            }
        }

    }
}