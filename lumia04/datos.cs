using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lumia04
{
    class datos
    {
        public Random rnd = new Random();
        public int[] _nResultadosPosibles = new int[3]; //dos aleatorios, y el bueno (en un orden aleatorio); son las 3 posibilidades que se le dan
        int _nResultadoCorrecto; 
        int _nOperando1, _nOperando2;  //operandos aleatorios
        

        /* Properties de Operandos */
        public int nOperando1 //primer operando de la operación
        {
            get
            {
                return _nOperando1;
            }
        }

        public int nOperando2 //segundo operando de la operación
        {
            get
            {
                return _nOperando2;
            }
        }

        /* Resultados */
        public int nResultadoCorrecto
        {
            get
            {
                return _nResultadoCorrecto;
            }
        }

        public int[] nResultadosPosibles
        {
            get
            {
                return _nResultadosPosibles;
            }
        }


        public void calculaValores() //calculamos la suma
        {

            // Primer operando 
            for (int i = 0; i < 100; i++)     //vamos a randomizar mejor
            {
                _nOperando1 = rnd.Next(0, 1000);
            }
            _nOperando1 = rnd.Next(0, 9);


            // Segundo operando
            for (int i = 0; i < 100; i++)     //vamos a randomizar mejor
            {
                rnd.Next(0, 1000);
            }
            _nOperando2 = rnd.Next(0, 9);

            // Resultado correcto
            _nResultadoCorrecto = _nOperando1 + _nOperando2; //calculamos la suma de verdad

            // Envío el resultado correcto a una posición aleatoria del array de posibles            
            _nResultadosPosibles[rnd.Next(0, 2)] = _nResultadoCorrecto;

            //y rellenamos los demás
            for (int j = 0; j < 3; j++)  
            {
                for (int i = 0; i < 100; i++)     //vamos a randomizar mejor
                {
                    rnd.Next(0, 1000);
                }

                if (nResultadosPosibles[j] == 0) { _nResultadosPosibles[j] = rnd.Next(0, 9); }

            }       
            
        }


        public datos()
        {
            this._nOperando1 = 0;
            this._nOperando2 = 0;
            this._nResultadoCorrecto = 0;
            this._nResultadosPosibles[0] = 0;
            this._nResultadosPosibles[1] = 0;
            this._nResultadosPosibles[2] = 0;
        }

    }
}
