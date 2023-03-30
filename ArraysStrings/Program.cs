using System;
using System.Linq;

namespace ArraysStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array basics
            //int age1 = 19;
            //int age2 = 20;
            //int age3 = 22;
            //int age4 = 22;
            //int age5 = 19;
            //int age6 = 20;
            //int age7 = 23;
            ////.....

            //// Arrray Create
            //// DATA_TYPE[] VARIABLE_NAME = new DATA_TYPE[SIZE];


            //int[] studentsAge = new int[100];   //size-1
            //studentsAge[0] = 15;
            //studentsAge[0] = 39;

            //for (int i = 0; i < studentsAge.Length; i++)
            //{
            //    studentsAge[i] = i;
            //}

            //PrintArray(studentsAge);

            //for (int i = 0; i < studentsAge.Length; i++)
            //{
            //    studentsAge[i] = i * 5;
            //}

            //PrintArray(studentsAge);
            #endregion

            #region Array examples
            //string[] studentsName = new string[5];
            //string[] studentsAdress = new string[5];
            //string[] studentsMail = new string[5];
            //FillArray(studentsMail);
            //FillArray(studentsAdress);
            //FillArray(studentsName);


            //int[] studentsAge = new int[5];



            //for (int i = 0; i < studentsAge.Length; i++)
            //{
            //    Console.Write($"Enter {studentsName[i]} age: ");

            //    string ageString = Console.ReadLine();

            //    studentsAge[i] = int.Parse(ageString);
            //    //int.TryParse(ageString, out studentsAge[i]);
            //}


            //Console.WriteLine("Students Name: ");
            //PrintArray(studentsName);
            //Console.WriteLine("------------------------------------------------------");
            //Console.WriteLine("Students Age: ");
            //PrintArray(studentsAge);
            #endregion

            string password = "password42";

            char firstLetter = password[0]; //size-1

            if (char.IsLower(firstLetter))
            {
                Console.WriteLine("Password must start with UpperCase");
            }
            else
            {
                Console.WriteLine("Sign Up Succesufully");
            }

        
            //char x = 'a';
            //string newPassword = password.ToUpper();
            //string lowerPassword = password.ToLower();
            //string[] splitString = password.Split();
            
            //bool EndWithA = password.EndsWith('a');
            //bool StartWithA = password.StartsWith('a');

            //string withTrim = password.Trim();
            //string asdsad = string.Join(',', splitString);
            //string aasdsad = string.Empty; // ""


            //if (string.IsNullOrEmpty(password)) //""  " "
            //{
            //    Console.WriteLine("String is null or Empty");
            //}
            //else
            //{
            //    Console.WriteLine($"string is {password}");
            //}



            //PrintArray(splitString);

            

            //for (int i = 0; i < password.Length; i++)
            //{

            //    password[i] > password[i+1] 
            //}


        

        }


        static void FillArray(string[] array) // array =  studentMail.Copy; studentMail = 0x2ef66b
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter Student info: ");
                array[i] = Console.ReadLine();
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
        }

        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();

        }
    }
}
