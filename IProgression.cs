using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLabOne
{
    public interface IProgression
    {
        double StartingElement { get; set; }
        double Coefficient { get; set; }

        Progression ProgressionAdd(Progression other);

        Progression ProgressionSubtract(Progression other);

        Progression ProgressionMultiplyByNumber(double nubmer);

        double ProgressionSumOfFirstElements(int n);

        double ProgressionGetElementByNo(int n);
    }
}
