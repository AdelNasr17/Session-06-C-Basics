namespace Assignment_06_C__Basics
{

    #region Example Q01
    ////1.Passing by Value
    //static int SumArray(int[] Arr)//Arr = num = { 20 , 2 , 3}
    //{
    //    int SUM = 0;
    //    if (Arr != null)
    //    {
    //        Arr[0] = 50;
    //        for (int i = 0; i < Arr.Length; i++)
    //        {
    //            SUM += Arr[i];

    //        }

    //    }
    //    return SUM;
    //}

    ////2.Passing by Reference
    //static int SumArray(ref int[] Arr)
    //{
    //    int SUM = 0;
    //    if (Arr != null)
    //    {
    //        Arr[0] = 50;
    //        for (int i = 0; i < Arr.Length; i++)
    //        {
    //            SUM += Arr[i];

    //        }

    //    }
    //    return SUM;
    //}


    #endregion

    #region Q2: Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

    // static void SumSubMul(int X, int Y, out int Sum, out int Sub, out int Mul)
    //{
    //    Sum = X + Y;
    //    Sub = X - Y;
    //    Mul = X * Y;

    //}

    #endregion

    #region Q 03 : Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

    //static void MinMaxArray(int[] array, out int max, out int min)
    //{

    //    max = array[0];
    //    min = array[0];

    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] > max)
    //            max = array[i];
    //    }

    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] < min)
    //            min = array[i];
    //    }
    //}

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 01 : Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.


            ////1 - Passing By Value
            ////Passing by value  with  Reference type  Copies the Reference
            ////Allow the Object to be Modified but the Original Reference remains UnChanged 
            //// Example: 
            //int[] num = { 10, 20, 30 };

            //int total;
            //total = SumArray(num); // SumArray( Address of Array)
            //Console.WriteLine(num[0]);//50



            //// 2- Passing By Reference 
            //// Passing by Reference Allow both Modifying thr Object and Changing thr Original Reference itself 
            //// Example 

            //total = SumArray(ref num); // SumArray( Array It Self( Reference Of Array : num))
            //Console.WriteLine(num[0]);//50

            #endregion

            #region Q 02 : Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int A = 3, B = 5, Sum, Mul, Sub;
            //SumSubMul(A , B , out Sum , out Sub , out Mul);

            //Console.WriteLine($" Sum = {Sum} "); // 8
            //Console.WriteLine($" Sub = {Sub} "); // -2 
            //Console.WriteLine($" Mul = {Mul} "); // 15


            #endregion

            #region Q 03 : Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //int Max, Min;
            //MinMaxArray(num, out Max, out Min);
            //Console.WriteLine($" Maximum Element  = {Max}");
            //Console.WriteLine($" Minimum Element  = {Min}");



            #endregion

        }
    }
}
