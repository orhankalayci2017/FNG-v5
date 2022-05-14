using System;

namespace FNG_v5
{
    internal class FibonacciNumberGeneratorClass
    {
        public FibonacciNumberGeneratorClass()
        {
        }

        private bool checkIfIndexValid(int index) => ((index >= 0) && (index < 47));

        internal int errorCode => -321;

        internal int getFibonnaci(int index)
        {
            if (!checkIfIndexValid(index)) return errorCode;
            return fibonnaciNumberCalculatingBusinessRules(index);

        }


        internal int fibonnaciNumberCalculatingBusinessRules(int index)
        {

            int fibonacciNumber = 0;  
            if (index == 0) return fibonacciNumber;
            
            fibonacciNumber = 1; 
            if (index == 1) return fibonacciNumber;

            int twoBefore = 0;
            int oneBefore = 1;

            while (index-- > 1)
            {
                fibonacciNumber = oneBefore + twoBefore;

                twoBefore = oneBefore;
                oneBefore = fibonacciNumber;

            }

            return fibonacciNumber;

        }


    }
}
