namespace Demo_4
{
    enum WeekDays : byte
    {
        Saturday , 
        Sunday , 
        Monday , 
        Tuesday , 
        Wednesday ,
        Thursday ,
        Friday 
    }

    enum Gender : byte
    {
        Male = 1 , 
        M = 1 ,
        Female = 2 ,
        F = 2 
    }
    [Flags]
    enum permissions 
    {
        Read = 8 ,
        Write = 4,
        Execute = 2 ,
        Delete = 1
    }


    internal class Program
    {
        /* static void DoSomeCode()
         {
             int x, y, z;
             x = int.Parse(Console.ReadLine());
             y = int.Parse(Console.ReadLine());

             z = x / y;

             int[] array = { 1, 2, 3, 4 };
             array[10] = 3;


         }
     */

        static void DoProtectiveCode()
        {

            try
            {
                int x, y, z;
                bool Flag;

                do
                {
                    Console.WriteLine("Enter the first number : ");
                    Flag = int.TryParse(Console.ReadLine(), out x);
                }
                while (Flag != true);

                do
                {
                    Console.WriteLine("Enter the second number : ");
                    Flag = int.TryParse(Console.ReadLine(), out y);
                }
                while (Flag != true || y == 0);   // Note : y must be != 0 , cause i can't divide by 0

                z = x / y;

                Console.WriteLine(z);

            }
            catch ( Exception E)
            {
                Console.WriteLine(E.Message);
            }

           

        }
        static void Main(string[] args)
        {
            // The Demo File 


            #region Boxing and UnBoxing 

            // Boxing : Casting a value type to Reference Type 
            // UnBoxing : Casting a Reference type to Value Type 


            //  object o1 = 1;  // i turned the intger value (1) to and reference type (object)
            // How ? Because the object is a built in class and every class inherit from it 
            // so it can points to or (Referes) to any type of variables.

            //o1 = 1.3;
            //o1 = new DateTime();      // All this is boxing 
            //o1 = "String";              // Note : uses Impilict Casting 



            // Unboxing 

            //  int x = o1; // error

            // int x = (int)o1; // Done (but may throw an exception) it is unsafe 
            // Note : Must use Explicit Casting 





            #endregion

            #region Nullable type variables

            // Nullable Value Type

            //  In General i can't do this :  int x = null;  ---> Error !

            //  int? x = null; // --> No Errors The ? allow me to store null value as valid (value) or the int value 

            //  double? Salary = 5000;
            //  Salary = null;         // Allow Double value or null value; 

            // int x = 5;
            // int? y = x; // i can store value of x in the nullable int , cause x has already a value

            // int? x = 5;
            //    int y = x;    // not vice versa , cause x now is the nullable int may has a null value
            // So Explicit Casting is important ( Not Safe ) may throw an exception


            // Nullable Refernce Type 

            // Ex : 

            //  string x = null; // --> This is required 

            //  string? y = null; // Nullable 

            // In general : Reference Types allow nulls 

            //  Console.WriteLine(x.Length);
            //  Console.WriteLine(y);

















            #endregion

            #region Null Propagation operator ' ?? '

            // int[] arr = default;

            // Console.WriteLine(arr);

            // int [] arr = {1,2,3,4,5};

            //for(int i = 0; arr != null && i< arr.Length; i++)
            // {
            //     Console.WriteLine(arr[i]); // 1 , 2 , 3, 4, 5
            // }

            // Best Practice :

            /*  if (arr != null)
              {
                  for (int i = 0; i < arr.Length; i++)
                  {
                      Console.WriteLine(arr[i]); // 1 , 2 , 3, 4, 5
                  }
              }
            */

            // Ex : 

            // int Len = arr?.Length ?? 000;

            //  Console.WriteLine(Len);  

            // arr?.Length means : Does arr points to value ? --> Yes? get the length of array , No? print 000

            // In other way : if arr has a value get it ( left of ?? ) if null ( right if ??)












            #endregion

            #region Exception Handling and Protective Code



            //  DoProtectiveCode(); // Many Runtime Errors 


            // We can Handle the errors with try and catch 
            // But this doesn't resolve the problem 
            // So we have to write defensive code preventing any such errors 
            // and to make the process continue smoothly 

            // After writing the defensive code ? put it in a try catch  (the last defensive line )









            #endregion
        
            #region Enum

            //  WeekDays wk1 = WeekDays.Saturday;

            // Console.WriteLine(wk1);

            // user input : 

            //   Gender G1 = (Gender) Enum.Parse(typeof (Gender), Console.ReadLine() , true );

            // Console.WriteLine(G1); // Unsafe Explicit exception may throw an error 




            // Let's do it with TryParse :


            //Gender G2;

            //Console.WriteLine("Enter your Gender : ");

            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object g2);

            //G2 = (Gender)g2;

            //Console.WriteLine(G2);


            // Enum Advanced : 

          //  permissions p1 = permissions.Read;

        ///    p1 ^= permissions.Write;  // --> ^=  works as Toggle

          //  p1 |= permissions.Write;  // Add permission

          //  p1 ^= permissions.Write; // if the write is already in >> delete it -- not added yet --> then add it.

          //  p1 &= ~(permissions.Write); // Not BitWise  ,, Check Permission 


           //if( (p1&permissions.Write) == permissions.Write )
           // {
           //     Console.WriteLine("Exists");
           // }
           //else
           // {
           //     Console.WriteLine("Not Exists");
           // }



            #endregion









        }
    }
}
