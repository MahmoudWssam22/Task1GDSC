using System.Security.Cryptography.X509Certificates;
public class program
{
    public static void Main(string[] args)
    {
        string desegun;
        Console.WriteLine("CHOSE USING SWITCH STATMENT OR UESING IF STATMENT");
        Console.WriteLine("S:- FOR SWITCH STATMENT");
        Console.WriteLine("F:- FOR IF STATMENT");
        desegun = Console.ReadLine();


        if (desegun=="s" || desegun == "S")
        {
            int x, y;
            int res=0;
            char op;

            Console.WriteLine("enter the first number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the oprator number");
            op =char.Parse( Console.ReadLine());

            Console.WriteLine("enter the second number");
            y = Convert.ToInt32(Console.ReadLine());

            Switch(ref x,ref y, op,  res);
        }

        else if (desegun=="f" || desegun=="F") 
            If_Else();
    }
    public static void Switch(ref int x,ref int y, char op, int res)
    {
        switch (op)
        {
            case '+':
                res = x + y;
                Console.WriteLine("the Resoltes is: "+ res);
                break;
            case '-':
                res = x - y;
                Console.WriteLine("the Resoltes is: "+ res);
                break;
            case '*':
                res = x * y;
                Console.WriteLine("the Resoltes is: "+ res);
                break;
            case '/':
                res = x / y;
                Console.WriteLine("the Resoltes is: "+ res);
                break;
            default:
                Console.WriteLine("THE OPRATOR YOU ENTERT IS WRONG");
                Console.WriteLine("PLESE ENTER AN OPRATOR OF THE FOLLWING (+,-,*,/)");
                break;
        }
    }
    public static void If_Else()
    {
        int? x=0, y=0, res = 0;
        char op;

        Console.WriteLine("enter the first number");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the oprator number");
        op = char.Parse(Console.ReadLine());

        Console.WriteLine("enter the second number");
        y = Convert.ToInt32(Console.ReadLine());

        if (x.HasValue && y.HasValue)
        {
            if (op == '+')
            {
                res = x + y;
                Console.WriteLine("the Resoltes is: " + res);
            }

            else if (op == '-')
            {
                res = x - y;
                Console.WriteLine("the Resoltes is: " + res);
            }
            else if (op == '*')
            {
                res = x * y;
                Console.WriteLine("the Resoltes is: " + res);
            }
            else if (op == '/')
            {
                res = x / y;
                Console.WriteLine("the Resoltes is: " + res);
            }
            else
            {
                Console.WriteLine("THE OPRATOR YOU ENTERT IS WRONG");
                Console.WriteLine("PLESE ENTER AN OPRATOR OF THE FOLLWING (+,-,*,/)");
            }
        }
        else { Console.WriteLine("ONE OF THE VALUES YOU'VE ENTERT IS NULL ... PLEASE ENTER THE VALUES AGINE"); }
    }
}


