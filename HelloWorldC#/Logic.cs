int month = 1;
string monthName;

switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    default:
        monthName = "Unknown";
        break;
}

System.Console.WriteLine(monthName);