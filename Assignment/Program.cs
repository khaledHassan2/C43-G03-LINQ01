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

            #region Question 3:LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var Result = ProductList.Select(p => p.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words.Select(w => new
            //{
            //    original = w,
            //    Upper=w.ToUpper(),
            //    Lower=w.ToLower(),
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Result = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Category = p.Category,
            //    Stock = p.UnitsInStock,
            //    Price = p.UnitPrice,

            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result=Arr.Select((a,i)=>new 
            //{
            //    True=a==i,
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.True);
            //}
            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select  $"{a} Is Less Than {b}";
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            //var Result = CustomerList.SelectMany(o => o.Orders).Where(o => o.Total < 500.00m);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.
            //var Result = CustomerList.SelectMany(o => o.Orders).Where(o => o.OrderDate.Year >=1998  );
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
        }
    }
}
