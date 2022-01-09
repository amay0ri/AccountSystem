﻿


namespace Banco
{
    public class ContaCorrente
    {

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotaldeContas++;
        }
        public static int TotaldeContas { get; private set; }

       
        public Cliente Titular { get; set; }
        private int _agencia;
        public int Agencia 
        { 
            get
            {
                return _agencia;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
               _agencia = value;
            } }   
        public int Numero { get; set; }
        private double _saldo;







        public double Saldo
        {
            get { return _saldo; }
            set { 
                
                if (value < 0)
                {
                    return;

                }

                _saldo = value;
            }
        } 




        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            conta.Depositar(valor);
            return true;
        }
    }


}