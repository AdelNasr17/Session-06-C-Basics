namespace Session_06_C__Basics
{

    #region 5- Null Propagation Operator 
    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; } = null!;
    //    public int Age { get; set; }
    //    public Department? Department { get; set; }

    //}

    //class Department
    //{
    //    public int Code { get; set; }
    //    public string Name { get; set; } = null!;
    //} 
    #endregion



    internal class Demo
    {
        #region 1- Part 02 : Functions

        #region 3- Reference Type Parameters 

        ///1.Passing by Value
        //static int SumArray(int[] Arr)//Arr = num = { 100 , 2 , 3}
        //{
        //    int SUM = 0;
        //    if (Arr != null)
        //    {
        //        Arr[0] = 100;
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            SUM += Arr[i];

        //        }

        //    }
        //    return SUM;
        //}

        ///2.Passing by ref
        //static int SumArray( ref int[] Arr) 
        //{
        //    int SUM = 0;
        //    if (Arr != null)
        //    {
        //        Arr[0] = 100;
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            SUM += Arr[i];

        //        }

        //    }
        //    return SUM;
        //}


        #endregion

        #region 4-Passing bt out
        //static void  SumMul(int x , int y , out int Sum , out int Mul )
        //{
        //     Sum = x + y;
        //    Mul = x * y;         

        //} 
        #endregion

        #region 5-Params
        //static int  SumArray(params int[] array)
        //{
        //    int sum = 0;
        //    if (array != null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            sum += array[i];
        //        }
        //    }
        //    return sum;
        //} 
        #endregion


        #endregion

        #region 6- Exception Handing and protective Code 
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        x = int.Parse(Console.ReadLine());
        //        y = int.Parse(Console.ReadLine());

        //        z = x / y;
        //        int[] arr = { 1, 2, 3, 4, 5, 6 };
        //        arr[100] = 12;
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }


        //}


        //static void DoSomeAProtectiveCode()
        //{
        //    int x, y, z;

        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine(" Please enter the first number");
        //        flag = int.TryParse(Console.ReadLine(), out x);

        //    } while (!flag);

        //    do
        //    {
        //        Console.WriteLine(" please enter number2 : ");
        //        flag = int.TryParse(Console.ReadLine(), out y);

        //    } while (!flag);
        //    z = x / y;


        //    int[] arr = { 1, 2, 3, 4, 5, 6 };
        //    if (arr?.Length > 100)
        //    {
        //        arr[100] = 12;
        //    }

        //} 
        #endregion
        static void Main(string[] args)
        {

            #region 1- Part 02 : Functions
            #region 3- Reference Type Parameters 
            //int[] num = { 1, 2, 3 };

            ////1. passing by value 
            //int total = SumArray(num); // SumArray( Address of Array)
            //Console.WriteLine(num[0]);//100

            ////2. passing by Ref
            //int total = SumArray(ref num); // SumArray( Array It Self( Reference Of Array : num))

            //Console.WriteLine(num[0]);//100
            #endregion

            #region 4-Passing bt out
            //int SResult, MResult, A = 3, B = 5;// 3. Passing by out [ output parameters ]
            //    SumMul(A,B,out SResult , out MResult );
            //Console.WriteLine(SResult);
            //Console.WriteLine( MResult); 
            #endregion

            #region 5-Params
            //int total = SumArray(1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine(total); 
            #endregion

            #endregion

            #region 2-Boxing & UnBoxing

            // Boxing    : Casting From Datatype[ Value type ] to Datatype[Reference type ]
            // UnBoxing  : Casting from Datatype[ Reference type] to Datatype [ Value Type ] 

            #region Example 01 
            //object obj;
            //// declare for Reference  of type " object " , refering to the Default value of Reference type = Null 
            //// This reference ' obj' Will be Allocated at STACK with Size = 4 bytes 
            //// This reference  ' obj' can refer to an Instance   of  type " object " OR antoher  type  inherting from "object " 

            //obj = new object();
            //obj = new string(" Adel");
            //obj = " Adel ";

            //obj = 'A'; // Casting from char  [ Value type ] to object[ Reference type ] =====>> Boxing 
            //obj = 5;   // Casting from Int   [ Value type ] to object[ Reference type ] =====>> Boxing
            //obj = 5.5; // Casting from Double[ Value type ] to object[ Reference type ] =====>> Boxing
            //obj = true;// Casting from Double[ Value type ] to object[ Reference type ] =====>> Boxing



            //bool Flag = (bool)obj;
            //// Casting from object [ Reference Type ] to bool[ Value Type ] ====> UnBoxing 

            #endregion

            #region Example 02 

            #region Boxing
            //int x = 10;
            //object obj = x;
            //// Casting from int [ ValueType ] to object[ Reference Type ] Implicitly 
            ////           10  ----->  new object(10) 
            //// Boxing [ Safe Casting ] 
            #endregion

            #region UnBoxing
            //object obj;
            //obj = 20; // Boxing 
            //int y = (int)obj;
            //// Casting from object [ reference Type ] to int [ ValueType ] Explicitly 
            ////       new object(20) --------> 20 
            //// UnBoxing [ un Safe Casting ] 

            #endregion

            #endregion


            #endregion

            #region 3-Inheritance : Ia a 
            //object obj;
            // obj = new object();


            //obj = new string("Adel ");
            //// Parent = ChildX
            //// Animal = Dog 

            //string str = (string)obj;
            ////ChildX  =( ChildX) Parent
            //// Dog = ( Dog ) Animal 

            #endregion

            #region 4-Nullable
            #region Nullable ValueType 
            // Null is not a valid Value for the variable of dataType : ValueType ( Struct , Num ) 
            // Nullable  ValueTypes : ValueTypes + Allow null as a valid Value 

            #region Part 01 
            //    int? Age;

            //    Age = null;
            //Age = 22;
            //Console.WriteLine(Age);

            #endregion

            #region Casting From int to Nullable<int>
            //int x = 10;

            //// X : int               -> Allow Integers Only 
            //// Y : Nullable <int>    - > Allow integers + Null 
            //int? y = x;

            //// Casting from int to Nullable<int> Implicitly 
            //// Save Casting 


            #endregion


            #region Casting From Nullable<int> to int && Null Coalescing Operator 
            //// X ; Nullable<int>       --> Allow integers + null 
            //// Y : int                 --> Allow integers only 

            //int? X = 10;               // Nullable<int> X = 10;
            //X = null;

            //// Casting From Nullable<int> to int Explicitly 
            //// UnSafe Casting 
            //int Y = X?? 0;
            //// Protective code 

            //if( X is not null )
            //{
            //     Y = (int)X;

            //}
            //else
            //{
            //    Y = 0;
            //}
            ///********************************************/
            //if ( X.HasValue)
            //{
            //    Y = X.Value;
            //}
            //else
            //{
            //    Y = 0;
            //}
            ///**********************************************/
            //Y = X.HasValue ? X.Value : 0;
            ///**********************************************/
            //Y = X ?? 0;
            //// ?? ---> Null Coalescing Operator [ Syntax Sugar ] 



            #endregion



            #endregion

            #region Nullable Reference Types
            ////Null is not a valid Value for the variables of DateType : Reference Type ( Class , Interface)
            //string Message01 = null! ; // null Forgivness operator 

            //Console.WriteLine(Message01);

            //string? message02 = null;
            //Console.WriteLine(message02);

            #endregion

            #endregion

            #region 5-Null Propagation Operator 

            #region Examble 01 
            //decimal Number = default; //0
            //int[]? Numbers = default; // NULL
            //if (Numbers is not null)
            //{
            //    for (int i = 0; i < Numbers.Length /* DeReferenceing*/; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}


            //// Null Propagation Operator
            //int Len02 = Numbers?.Length ?? 0;

            #endregion

            #region Examble 02
            //Employee employee = new Employee()
            //{
            //    Id = 10,
            //    Name= "Adel Nasr",
            //    Age = 22 ,
            //    Department = new Department()
            //    {
            //        Code=1001,
            //        Name = " HR"
            //    }

            //};

            //Console.WriteLine(employee?.Department?.Name ?? "no name");

            #endregion

            #endregion

            #region 6-Exception Handing and protective Code 
            ////DoSomeCode()
            //try
            //{
            //    DoSomeAProtectiveCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //Deallocate | Release | Delete | free | Close UnManaged Resources [ Database Connection ] 
            //    Console.WriteLine("Finally");
            //} 
            #endregion


        }
    }
}
