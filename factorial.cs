using System;
class HelloWorld {
  static void Main() {
    int fact=1,i;
    Console.WriteLine("Enter the Integer number");
    int n1=Convert.ToInt32(Console.ReadLine());
    for(i=1;i<=n1;i++)
    {
       fact=fact*i;
    }
            Console.WriteLine("The factorial of :"+n1+" is :"+fact);
    }
}