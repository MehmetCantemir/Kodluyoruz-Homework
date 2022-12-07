namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /// QUESTION 1
            Console.WriteLine("Enter the positive number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            if(number1<=0) 
            {
               
                while (number1<=0)
                {
                    Console.WriteLine("Please enter the positive number");
                    number1 = Convert.ToInt32(Console.ReadLine());
                  
                }
            }

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Please Enter the  number : ");
            int[] evenNumbers= new int[number1];
            int counter = 0;
            for (int i = 0; i < number1; i++)
            {
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number2 % 2 == 0)
                {
                    evenNumbers[counter] =number2;
                    counter++;
                }
                  
            }
            for(int i=0;i<counter;i++)
            {
                Console.WriteLine(" Even Numbers : " + evenNumbers[i]);
            }


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("---------------QUESTİONS 2-----------------------------");

            // QUESTİON 2

            Console.WriteLine("Please enter the two pozitive number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the n amount positive numbers");
            int[] arraysN1= new int[n1];
            int[] arraysN2= new int[n1];
            int counter1 = 0;
            for (int i = 0; i <n1; i++)
            {
                arraysN1[i]= Convert.ToInt32(Console.ReadLine());
                if (arraysN1[i]==n2 || arraysN1[i]%n2==0 )
                {
                    arraysN2[counter1] = arraysN1[i];
                    counter1++;
                }
            }
            for (int i = 0; i < counter1; i++)
            {
                Console.WriteLine("Eşit yada tam bölünen sayılar : " + arraysN2[i]);
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("---------------QUESTİONS 3-----------------------------");

            //QUESTION 3

            Console.WriteLine("Enter the positive number : ");
            int pNumber=Convert.ToInt32(Console.ReadLine());
            string[]words= new string[pNumber];
            for (int i = 0; i < pNumber; i++)
            {
                Console.WriteLine("Enter the word");
                words[i] = Console.ReadLine();
            }
            Array.Reverse(words);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }



        }


    }
}