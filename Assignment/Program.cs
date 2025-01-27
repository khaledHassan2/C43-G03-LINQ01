using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var Result = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
            //var Result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.UnitPrice > 3.00m
            //             select p;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Select((n, i) => new { name = n, index = i })
            //                  .Where(item => item.name.Length < item.index)
            //                  .Select(item => item.index);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion
        }
    }
}
