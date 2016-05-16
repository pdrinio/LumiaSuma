using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lumia04
{
    class operaciones
    {
        int _nOperando1, _nOperando2, _nResultadoCorrecto, _nResultado1, _nResultado2, _nResultado3, _nResultado4;
        public Random rnd = new Random();

        /* Operandos */
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

        public int nResultado1
        {
            get
            {
                return _nResultado1;
            }
        }

        public int nResultado2
        {
            get
            {
                return _nResultado2;
            }
        }

        public int nResultado3
        {
            get
            {
                return _nResultado3;
            }
        }

        public int nResultado4
        {
            get
            {
                return _nResultado4;
            }
        }

        public void calculaSuma() //calculamos la suma
        {
          for (int i = 0; i < 1000; i++)     //vamos a randomizar mejor
            {
                _nOperando1 = rnd.Next(0, 1000);
           }

        _nOperando1 = rnd.Next(0, 9);

            for (int i=0; i <1000; i++)     //vamos a randomizar mejor
            {
                rnd.Next(0,1000);
            }

            for (int i = 0; i < 1000; i++)     //vamos a randomizar mejor
            {
                _nOperando2 = rnd.Next(0, 1000);
            }

            _nOperando2 = rnd.Next(0, 9);

            _nResultadoCorrecto = _nOperando1 + _nOperando2; //calculamos la suma de verdad


            //...y otras cuatro posibles (erróneas), sumas)
            for (int i = 0; i < 1000; i++)     //vamos a randomizar mejor
            {
                _nResultado1 = rnd.Next(0, 9);
            }

            for (int i = 0; i < 1000; i++)     //vamos a randomizar mejor
            {
                _nResultado2 = rnd.Next(0, 9);
            }

            for (int i = 0; i < 1000; i++)     //vamos a randomizar mejor
            {
                _nResultado3 = rnd.Next(0, 9);
            }

            for (int i = 0; i < 1000; i++)     //vamos a randomizar mejor
            {
                _nResultado4 = rnd.Next(0, 9);
            }
            
           
        }


        public operaciones()
        {
            this._nOperando1 = 0;
            this._nOperando2 = 0;
            this._nResultadoCorrecto = 0;
            this._nResultado1 = 0;
            this._nResultado2 = 0;
            this._nResultado3 = 0;
            this._nResultado4 = 0;
        }

    }
}
