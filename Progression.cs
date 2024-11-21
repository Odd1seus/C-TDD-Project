using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLabOne
{
    public class Progression : IProgression 
    {

        public double StartingElement { get; set ; }
        public double Coefficient { get; set; }

        public Progression(double startElem, double coef)
        {
            StartingElement = startElem;
            Coefficient = coef;
        }

        public Progression()
        {
            StartingElement = 0;
            Coefficient = 0;
        }

        public Progression ProgressionAdd(Progression other) //coefficients must be equal
        {
            if (this.Coefficient != other.Coefficient ) 
            {
                throw new InvalidOperationException("Coefficients must be at least equal to add two progressions");
            }
            else
            {
                return new Progression(this.StartingElement + other.StartingElement, this.Coefficient);
            }
        }

        public Progression ProgressionSubtract(Progression other) //coefficients must be equal
        {
            if (this.Coefficient != other.Coefficient)
            {
                throw new InvalidOperationException("Coefficients must be at least equal to subtract two progressions");
            }
            else
            {
                return new Progression(this.StartingElement - other.StartingElement, this.Coefficient);
            }
        }

        public Progression ProgressionMultiplyByNumber(double number)
        {
            return new Progression(this.StartingElement * number, this.Coefficient);
        }

        public double ProgressionSumOfFirstElements(int n)
        {
            if (Coefficient == 1)
            {
                return StartingElement * n;
            }
            else
            {
                return StartingElement * (1 - Math.Pow(Coefficient, n)) / (1 - Coefficient);
            }
        }

        public double ProgressionGetElementByNo(int n)
        {
            return StartingElement * Math.Pow(Coefficient, n - 1);
        }

        public override bool Equals(object obj)
        {
            return obj is Progression progression &&
                   StartingElement == progression.StartingElement &&
                   Coefficient == progression.Coefficient;
        }

        public override int GetHashCode()
        {
            int hashCode = -1261117659;
            hashCode = hashCode * -1521134295 + StartingElement.GetHashCode();
            hashCode = hashCode * -1521134295 + Coefficient.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format("Progression: starting element = {0} , coefficient = {1}",StartingElement,Coefficient);
        }
    }
}
