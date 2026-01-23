// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program //you can chenge name the class
{ 

        static void Main()
        {
            string userName;
            int age;
            float savingsAccount = 0.0f;
            //userName = "Spencer";
            //Console.WriteLine("Please input your age");
            //age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please put 0: add an amount to the account 1: remove some money from the account 2: send money to someone account");
            int UserInput; 
            float amount;
            int account;
            
            UserInput = int.Parse(Console.ReadLine());

            switch (UserInput)
            {
                case 0:
                    //HERE CASE 0
                    Console.WriteLine("Put amount of money want to add");
                    amount = float.Parse(Console.ReadLine());
                    savingsAccount += amount;
                    //Add to the balance
                    Console.WriteLine("Your Balance " + savingsAccount);
                break;

                case 1:
                    //CASE 1
                    Console.WriteLine("Put amount of money want to remove");
                    amount = float.Parse(Console.ReadLine());
                    ;
                    //Remove an amount from the bill
                    if (savingsAccount >= amount){
                        savingsAccount -= amount;
                    Console.WriteLine("Your Balance "); Console.WriteLine(savingsAccount);}
                    else { Console.WriteLine("Invalid : You do not have enough balance");}

                break;

                case 2:
                    //CASE 2
                    Console.WriteLine("Put amount of money want to send");
                    amount = float.Parse(Console.ReadLine());
                    //Send money to sommone account
                    if (savingsAccount >= amount){
                    Console.WriteLine("Put the account you want to transfer");
                    account = int.Parse(Console.ReadLine());
                    savingsAccount -= amount;
                    Console.WriteLine("You sent money to " + account  + "Your Balance " + savingsAccount);
                    }
                    else { 
                        Console.WriteLine("Invalid : You do not have enough balance");
                        }
                break;



                default:
                    //Default case
                    Console.WriteLine("Invalid : Number");
                    //Current account balance
                break;
            }



        
        // Console.WriteLine("Put the account number you want to send");

          /*  if (age >= 18){
            Console.WriteLine("Welcome to the website");
            Console.WriteLine(userName);
            Console.WriteLine(" age; " + age);
        }
        else if (age>0 && age<18)
        {
            Console.WriteLine("To young go awey");

        }
        else{
            Console.WriteLine("Invalid age");
        }*/
            

        }

}
