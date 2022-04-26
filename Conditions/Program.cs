using System;

public class program
{
    public static void Main()
    {
        Console.WriteLine("HEllo");
    }

    //TODO i wil do it later
    //above line will put that comment in task list because it is special comment

    static void ConditionalStatements()
    {
        Console.WriteLine("Enter the day");
        var choice = Convert.ToInt32(Console.ReadLine());
        //ToInt16 is short
        string day = "";
        if(choice==1)
        {
            day = "Sunday";
        }
        else if(choice==2)
        {
            day = "Monday";
        }
        else if(choice==3)
        {
            day = "Tuesday";
        }
        else if(choice==4)
        {
            day = "Wednesday";
        }
        else if(choice==5)
        {
            day = "Thrusday";
            
        }
        else if(choice==6)
        {
            day = "Friday";
        }
        else if(choice==7)
        {
            day = "Saturday";
        }
        else
        {
            Console.WriteLine("Enter valid choice");
        }



        //ternary operator
        //(condition) ? <True value> : <False value>

        day=choice==1?"Sunday":choice==2?"Monday":choice==3?"Tuesday":choice==4?"Wednesday":choice==5?"Thrusday":choice==6?"Friday":choice==7?"Saturday":"Null";

        switch (choice)
        {
            case 1:
                day = "Sunday";
                break;
            case 2:
                day = "Monday";
                break;
            case 3:
                day = "Tuesday";
                break;
            case 4:
                day = "Wednesday";
                break;
            case 5:
                day = "Thrusday";

                break;
            case 6:
                day = "Friday";
                break;
            case 7:
                day = "Saturday";
                break;
            default:
                Console.WriteLine("Enter valid choice");
                break;
        }


    }
}

