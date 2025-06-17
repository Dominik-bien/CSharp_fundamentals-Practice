

namespace Day1
{
    public class Exercise2
    {

        private double _SizeA;
        private double _SizeB;
       
        

        public void SetDimensions(double sizeA, double sizeB)
        {
            this._SizeA = sizeA;
            this._SizeB = sizeB;
        }

        public double CalculateArea()
        {
          
            return _SizeA * _SizeB;
        }

        public double CalculatePerimeter()
        {
            return 2 * _SizeA + 2 * _SizeB;
        }
 




    }
}
