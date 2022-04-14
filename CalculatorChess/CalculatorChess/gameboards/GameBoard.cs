using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChess
{
    abstract class GameBoard<T>
    {
        private T [,] _spaces;
        private Dictionary<T, int[]> _spaceDictionary;

        public GameBoard(T[,] spaces)
        {
            _spaces = spaces;
        }

        public T [,] Spaces
        {
            get { return _spaces; }
            set { _spaces = value; }
        }

        public Dictionary<T, int[]> SpaceDictionary
        {
            get { return _spaceDictionary; }
            set { _spaceDictionary = value; }
        }

        public abstract bool isValidSpace(int x, int y);

    }
}
