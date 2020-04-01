using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2.1, 2.2, 2.3, 2.4, 2.5
            Console.WriteLine("Exercise_2.1, 2.2, 2.3, 2.4, 2.5");
            Console.WriteLine("Enter a size of an array=");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[n];
            Random random1=new Random();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=random1.Next(1000);
                Console.WriteLine($"arr[{i}]="+arr[i]);
            }
            int max=arr[0];
            int min=arr[0];
            int sum=0;
            int count=0;
            int medium=0;
            for(int i=0;i<arr.Length;i++)
            {
                if(max<arr[i])
                {
                    max=arr[i];        
                }
                if(min>arr[i])
                {
                    min=arr[i];
                }
                count++;
                sum=sum+arr[i];
                medium=sum/count;
                
            }
            Console.WriteLine();
            Console.WriteLine("Max="+max);
            Console.WriteLine("Min="+min);
            Console.WriteLine("Sum="+sum);
            Console.WriteLine("Medium="+medium);
            Console.WriteLine();
            Console.WriteLine("Odd values in array:");
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2!=0)
                {
                    Console.WriteLine($"arr[{i}]="+arr[i]);
                }
            }
            Console.WriteLine();

            //Exercise 3
            Console.WriteLine("Exercise_3");
            Console.WriteLine("Enter an array:");
            int m=Convert.ToInt32(Console.ReadLine());
            int[]arr2=new int[m];
            Random rand=new Random();
            for(int j=0;j<arr2.Length;j++)
            {
                arr2[j]=rand.Next(1000);
                Console.WriteLine($"arr2[{j}]="+arr2[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Entered array:");
            for(int j=0;j<arr2.Length;j++)
            {
                Console.WriteLine($"arr2[{j}]="+arr2[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Inverse array:");
            for(int j=arr2.Length-1;j>=0;j--)
            {
                Console.WriteLine($"arr2= "+arr2[j]);
            }
            Console.WriteLine();

            //Exercise 4
            Console.WriteLine("Exercise_4");
            int arrSize=Convert.ToInt32(Console.ReadLine());
            Random random=new Random();
            int[]arr3=new int[arrSize];
            for(int t=0;t<arr3.Length;t++)
            {
                arr3[t]=random.Next(1000);
            }
            Console.WriteLine();
            for(int t=0;t<arr3.Length;t++)
            {
                Console.WriteLine($"arr3=[{t}]="+arr3[t]);
            }
            Console.WriteLine();

            Console.Write("count=");
            int Count=Convert.ToInt32(Console.ReadLine());
            Console.Write("index=");
            int index=Convert.ToInt32(Console.ReadLine());
            int []arr4=new int[Count];
            for(int l=0;l<Count;l++)
            {
                if(l+index<arr3.Length)
                {
                    arr4[l]=arr3[l+index];
                }
                else
                {
                    arr4[l]=1;
                }
            }
            
            System.Console.WriteLine("Values:");
            for(int l=0;l<arr4.Length;l++)
            {
                Console.WriteLine($"arr[{l}]="+arr4[l]);
            }
            Console.ReadKey();
        }
    }
}
