using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lumia04
{
    class operaciones
    {
        int _nOperando1, _nOperando2, _nResultado;
        public Random rnd = new Random();

        public int nOperando1
        {
            get
            {
                return _nOperando1;
            }
        }

        public int nOperando2
        {
            get
            {
                return _nOperando2;
            }
        }
        public int nResultado
        {
            get
            {
                return _nResultado;
            }
        }


        public void calculaSuma()
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

            _nResultado = _nOperando1 + _nOperando2;
        }


        public operaciones()
        {
            this._nOperando1 = 0;
            this._nOperando2 = 0;
            this._nResultado = 0;
        }

    }
}
