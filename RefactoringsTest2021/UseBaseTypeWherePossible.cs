using System;

namespace RefactoringsTest2021
{
    public class UseBaseTypeWherePossible : UseBaseTypeWherePossibleBase, ISomeInterface, IFormatProvider
    {
        public void Use()
        {
            var t = new UseBaseTypeWherePossible() is UseBaseTypeWherePossible;
            var test = typeof(UseBaseTypeWherePossible);
            var test2 = test is UseBaseTypeWherePossible;

            var cl1_1 = new UseBaseTypeWherePossible();
            Console.WriteLine(cl1_1 is IFormatProvider);
            Console.WriteLine(cl1_1 is Object);
            Console.WriteLine(cl1_1 is UseBaseTypeWherePossible);
            Console.WriteLine(cl1_1 is UseBaseTypeWherePossible);
            Console.WriteLine();

            var cl2 = new UseBaseTypeWherePossible();
            Console.WriteLine(cl2 is IFormatProvider);
            Console.WriteLine(cl2 is UseBaseTypeWherePossible);
            Console.WriteLine(cl2 is UseBaseTypeWherePossible);
            Console.WriteLine();

            UseBaseTypeWherePossible cl = cl2;
            Console.WriteLine(cl is { });
            Console.WriteLine(cl is UseBaseTypeWherePossible);
        }

        public object? GetFormat(Type? formatType)
        {
            throw new NotImplementedException();
        }
    }

    #region Helpers

    public class UseBaseTypeWherePossibleBase
    {

    }

    public interface ISomeInterface
    {
    }

    #endregion
}