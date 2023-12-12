using System;
using System.Xml.Linq;

namespace Convencoes 
{
    internal class ContaBancaria
    {
        public string Titular {  get; set; }
        private double _saldo;
        public void Deposito (double quantia)
        {
            _saldo += quantia;
        }
        public double GetSaldo() 
        {
            return _saldo;
        }
    }

    //Camel Case: (parâmetros de métodos, variáveis de métodos)

    // Pascal Case: LastName(namespaces, classes, properties e métodos)

    //Padrão _lastName: (atributos "internos" da classe)
}