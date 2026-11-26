namespace Assignment_03_GNet_c50_Basics_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            // Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion


            #region Q2
            // Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //  int[,] shelfCopies = {
            //     { 3, 5 },
            //   { 1, 4 }
            //  };
            // Console.WriteLine(shelfCopies[1, 0]);
            #endregion



            #region Q3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
            // Printwelcommassage.PrintWelcomeMessage();
            #endregion


            #region Q4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with "Clean Code".
            // PrintBookTitles.PrintBookTitle("Clean Code");
            #endregion

            #region
            #region Q5
            //Write a method AddBonusPages(int pages) that adds 50 to pages.
            //Call it with a variable int pages = 400; and print pages afterward.
            //What do you expect to see, and why?
            int pages = 400;
            AddBounsPages.AddBonusPages(pages);
            Console.WriteLine(pages);
            // i expect to see 400 because when we call the method it creates a copy of the original variable and work on it without affecting the original variable
            // and after the method is done it deletes the copy and returns to the original variable which is still 400
            #endregion
            #endregion




        }
    }
}
