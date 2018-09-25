using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Check
    class BaseballGameSolution
    {
        List<int> _Scores = new List<int>();
        int _Sum = 0;

        public int CalPoints(string[] operations)
        {
            foreach (string operation in operations)
            {
                int point;

                if (operation == "C")
                {
                    if (_Scores.Count == 0)
                        continue;

                    _Sum -= _Scores[_Scores.Count - 1];
                    _Scores.RemoveAt(_Scores.Count - 1);
                }
                else if (operation == "D")
                {
                    if (_Scores.Count == 0)
                        continue;

                    int newPoint = _Scores[_Scores.Count - 1] * 2;

                    _Sum += newPoint;
                    _Scores.Add(newPoint);
                }
                else if (operation == "+")
                {
                    if (_Scores.Count < 2)
                        continue;

                    int newPoint = _Scores[_Scores.Count - 1] + _Scores[_Scores.Count - 2];

                    _Sum += newPoint;
                    _Scores.Add(newPoint);
                }
                else if (int.TryParse(operation, out point))
                {
                    _Scores.Add(point);
                    _Sum += point;
                }
            }

            return _Sum;
        }
    }
}
