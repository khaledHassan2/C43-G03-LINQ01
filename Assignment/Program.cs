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

            #region Question 2:LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var Result = ProductList.OrderBy(n =>n.ProductName);
            //foreach (var name in Result)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(n => n, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Rsult = Arr.OrderBy(n => n.Length).ThenBy(N => N);
            //foreach (var item in Rsult)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Rsult = words.OrderBy(n => n.Length).ThenBy(N => N,StringComparer.OrdinalIgnoreCase);
            //foreach (var item in Rsult)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result=Arr.OrderBy(a=>a.Length).ThenByDescending(a=>a,StringComparer.OrdinalIgnoreCase);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // var Result = Arr.Where(n => n[1] =='i').Reverse();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion
        }
    }
}
