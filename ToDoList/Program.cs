Console.WriteLine("Welcome to our To-Do List App");
while (true)
{
Console.WriteLine("Select a day to enter your TO-do List");
Console.WriteLine($"1. Monday\n2. Tuesday\n3. Wednesday\n4. Thursday\n5. Friday\n6. Saturday\n7. Sunday\n8. Exit");
int daysOfTheWeek = int.Parse(Console.ReadLine());
    switch (daysOfTheWeek)
    {
        case 1:
           TaskDay("Monday");
            break;
        case 2:
            TaskDay("TuesDay");
            break;
        case 3:
            Console.WriteLine($"Assessment Day");
            break;
        case 4:
           TaskDay("Thursday");
            break;
        case 5:
           TaskDay("Friday");
            break;
        case 6:
            NoTaskDay("Saturday");
            break;
        case 7:
            NoTaskDay("Sunday");
            break;
        case 8:
            Console.WriteLine("Enter 8 to exit");
            return;
        default:
            Console.WriteLine("Enter a valid number");
            break;
    }
}

string TaskDay(string day)
{
    Console.WriteLine($"Enter your To-do List");
    string toDoListForFriday = Console.ReadLine();
    Console.WriteLine("Enter the time for your task in the format eg 12:00 or 12:00PM");
    TimeOnly timeToCompleteToDoList = TimeOnly.Parse(Console.ReadLine());
    return day;
}
string NoTaskDay(string day)
{
    Console.WriteLine("No Task Allowed");
    return day;
}