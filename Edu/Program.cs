using System;
using Edu.Types.Conversions;
using Edu.Types.Operations;
using Edu.Types.Condition;
using Edu.Loops;
using Edu.Types.ReferenceTypes;

namespace Edu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Conversion.PrintConvertedValueTypes();
            //Conversion.PrintCastingResults();
            //Operation.PrintValueTypeOperations();
            //Condition.PrintConditions();
            //Loop.PrintLoopResults();

            ReferenceTypeProvider.PrintReferenceTypeResults();
        }
    }
}
