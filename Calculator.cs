using System;

namespace Calculator {

class MainClass {
  public static void Main () {
    int num1, num2, opt;

    Console.WriteLine("\n\n");
    Console.WriteLine("A \"Calculator\" Made by Dogel#8821:\n");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("\n\n");

    Console.Write("Enter the first Integer: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the secont Interger: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nChoose option: \n");
    Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit\n");
    Console.Write("\nInput your choice: ");
    opt = Convert.ToInt32(Console.ReadLine());
    
    switch(opt) {
      case 1:
      Console.Write("The Addition of  {0} and {1} is: {2}\n",num1,num2,num1+num2);
      break;

      case 2:
      Console.Write("The Substraction of {0}  and {1} is: {2}\n",num1,num2,num1-num2);
      break;

      case 3:
      Console.Write("The Multiplication of {0}  and {1} is: {2}\n",num1,num2,num1*num2);
      break;

      case 4:
      if(num2==0) {
          Console.Write("The second integer is zero. Devide by zero.\n");
        } else {
          Console.Write("The Division of {0}  and {1} is : {2}\n",num1,num2,num1/num2);
        }  
      break;

      case 5:
      break;

      default:
      Console.WriteLine("This format don't exist!");
      break;
    }
 
    // int fin = num1 + num2;
    // Console.Write("Answer Is: " + fin);
    }
  }
}
