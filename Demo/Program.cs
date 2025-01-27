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
        }
    }
}
