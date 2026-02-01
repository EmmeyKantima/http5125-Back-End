

class Program //you can chenge name the class
{ 
    public float savingsAccount=0.0f;

    public Program()
    {
        savingsAccount = 0.0f;
    }
    static void Main()
    {
        Program program_ = new Program();
        program_.savingsAccount = 100.0f;
        
        int UserInput;

        Console.WriteLine("Please put 0: add an amount to the account 1: remove some money from the account 2: send money to someone account");
        UserInput = int.Parse(Console.ReadLine());

        switch (UserInput)
        {
            case 0:
                program_.AddToSaving();
            break;
            case 1:
                program_.Withdraw();
            break;
            case 2:
                program_.Transfer();
            break;
            default:
                Console.WriteLine("Invalid Number");
            break;
        }

    }

    public void AddToSaving()
    {
        Console.WriteLine("Put amount of money want to add");
        float amount = float.Parse(Console.ReadLine());
        savingsAccount += amount;
        Console.WriteLine("Savings are now : " + savingsAccount);
    }

    public void Withdraw()
    {
        Console.WriteLine("Put amount of money want to withdraw");
        float amount = float.Parse(Console.ReadLine());
        if (amount < savingsAccount )
        {savingsAccount -= amount;
        Console.WriteLine("Savings are now : " + savingsAccount);
        } else{
        Console.WriteLine("Invalid : You do not have enough balance");
        }
    }

    public void Transfer()
    {
        Console.WriteLine("Put amount of money want to send");
        float amount = float.Parse(Console.ReadLine());
         if (amount < savingsAccount )
        {savingsAccount -= amount;
        Console.WriteLine("Savings balance : " + savingsAccount);
        } else{
        Console.WriteLine("Invalid : You do not have enough balance");
        }
    }

}
    