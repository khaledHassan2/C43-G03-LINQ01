using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What Is LINQ
            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> OddNumber= Numbers.Where(n => n%2==1 ).ToList();
            //foreach (var item in OddNumber)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ Syntax

            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #region Fluent Syntax
            // 1- Call "LINQ Opretor" As => Static Method
            //List<int> OddNumbers=Enumerable.Where(Numbers,N => N %2==1).ToList();
            //2 call As Extantion Method
            //var OddNumbers = Numbers.Where(n => n % 2 == 1);
            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Query Syntax
            // Query Syntax : Query Exprssion: (like :SQL Server Style)
            //var OddNum = from n in Numbers
            //             where n % 2 == 1
            //             select n;
            //foreach (var item in OddNum)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion
            #region Execution Ways
            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //// var Result = Numbers.Where(n => n % 2 == 1);// تنفيز متاخر
            //var Result = Numbers.Where(n => n % 2 == 1).ToList(); 
            //Numbers.AddRange(new int[] { 11, 12, 13, 14 ,15});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Data Setup
            // Console.WriteLine(ProductList[0]);

            #endregion
            #region Filtration Operators
            #region 1- Get Product Out Of Stock 
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //var Result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select p;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 2- Get Product in Stock and in Category Of Meat/Poultry
            //var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");
            //var Result =from p in ProductList
            //            where p.Category== "Meat/Poultry" && p.UnitsInStock>0
            //            select p;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3- Get Product out Of Stock And  in First 10 Elements
            // Not Valid For Query Expression
            //var Result = ProductList.Where((p, i) => i < 10 && p.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region TransFormation (Projection) Operators [Select -SelectMany]

            #region select Pruduct Name
            //var Result = ProductList.Select(p => p.ProductName);
            //var Result=from p in ProductList
            //           select p.ProductName;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region select Customer  Name
            //var Result = CustomerList.Select(c => c.CustomerName);
            //var Result=from c in CustomerList
            //           select c.CustomerName;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Select Customer Order [selectMany]
            // var Result = CustomerList.SelectMany(c => c.Orders);
            //var Result=from c in CustomerList
            //           from o in c.Orders
            //           select o;
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region select Prduct Id And Product Name
            //var Result = ProductList.Where(p => p.UnitsInStock > 0).Select(p => (p.ProductID,p.ProductName));
            // var Result = ProductList.Where(p => p.UnitsInStock > 0).Select(p =>new { p.ProductID, p.ProductName });
            //var Result =from p in ProductList
            //            select new {p.ProductID, p.ProductName};

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region Select Pruduct In Stock And Apply Descount 10% On Its Price
            //var Result = ProductList.Where(p => p.UnitsInStock > 0)
            //                       .Select(p => new
            //                       {
            //                           Id = p.ProductID,
            //                           Name = p.ProductName,
            //                           OldPrice = p.UnitPrice,
            //                           NewPrice = p.UnitPrice - p.UnitPrice * 0.1m
            //                       });

            //var Result = from p in ProductList
            //             select new
            //             {
            //                 Id = p.ProductID,
            //                 Name = p.ProductName,
            //                 OldPrice = p.UnitPrice,
            //                 NewPrice = p.UnitPrice - p.UnitPrice * 0.1m
            //             };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Select Index
            //var Result = ProductList.Where(p => p.UnitsInStock > 0)
            //                       .Select((p, i) => new
            //                       {
            //                           Index = i,
            //                           Name = p.ProductName,
            //                       });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
        }
    }
}
