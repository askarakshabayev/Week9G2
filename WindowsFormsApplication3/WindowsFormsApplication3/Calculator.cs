using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Calculator
    {
        public enum Operation {
            NONE, 
            NUMBER, 
            PLUS, 
            MINUS, 
            EQUAL
        };
        public Operation operation;
        public int firstNumber, secondNumber;

        public Calculator()
        {
            operation = Operation.NONE;
            firstNumber = 0;
            secondNumber = 0;
        }

        public void saveFirstNumber(string s)
        {
            firstNumber = int.Parse(s);
        }

        public void saveSecondNumber(string s)
        {
            secondNumber = int.Parse(s);
        }

        public int getResultPlus()
        {
            return firstNumber + secondNumber;
        }
    }
}
