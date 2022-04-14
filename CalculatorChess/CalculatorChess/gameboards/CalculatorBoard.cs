using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChess.gameboards
{
    class CalculatorBoard<T>:GameBoard<T>
    {

        public CalculatorBoard(T[,] spaces) : base(spaces){

            this.SpaceDictionary = generateSpaceDictionary();
        }

        private Dictionary<T, int[]> generateSpaceDictionary()
        {
            Dictionary<T, int[]> rtn = new Dictionary<T, int[]>();

            for (int i = 0; i < Spaces.GetLength(0); i++){
                for (int j = 0; j < Spaces.GetLength(1); j++){
                    if (isValidSpace(i,j)){
                        rtn.Add(Spaces[i,j], new int[]{i,j});
                    }
                    
                }

            }
            
            return rtn;
        }

        public override bool isValidSpace(int x, int y)
        {
            if (this.Spaces[x, y].Equals('*') || this.Spaces[x, y].Equals('#'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
