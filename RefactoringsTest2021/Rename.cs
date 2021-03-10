using System;
using System.Linq;

namespace RefactoringsTest2021
{
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    // IRename
    public interface IRename
    {
    }

    public class Rename<T>  : IRename where T : class, new()
    {
        private IRename renameField;
        private int _products;
        public Rename(int products) => _products = products;

        private void RenamePropertyOfAnonymousType()
        {
            var dates = new[]
            {
                DateTime.UtcNow.AddHours(-1),
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
            };

            foreach (var anonymous in
                dates.Select(
                    date => new { Formatted = $"{date:MMM dd, yyyy hh:mm zzz}", date.Ticks }))
            {
                Console.WriteLine($"Ticks: {anonymous.Ticks}, formatted: {anonymous.Formatted}");
            }
        }

        (T generic1, U) RenameWithOverloadPopup<U>(T? t)
        {
            return (generic1: t, default)!;
        }
        (T generic1, U) RenameWithOverloadPopup<U>()
        {
            return (generic1: null, default)!;
        }

        private void Test2()
        {
            (T generic1, string) tuple = RenameWithOverloadPopup<string>(null);
            var generic1 = tuple.generic1;

            Console.WriteLine(generic1);
        }
    }

    #region Helpers

    class RenameA : IRename
    {
    }

    public class RenameB : IRename
    {
    }

    public class RenameC : IRename
    {
    }
    public class RenameD : IRename
    {
    }
    public class RenameE : IRename
    {
    }

    #endregion
}