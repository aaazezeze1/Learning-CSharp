﻿static string GetDay(int dayNum)
{
    string dayName;

    switch (dayNum)
    {
        case 0:
            dayName = "Sunday";
            break;
        case 1:
            dayName = "Monday";
            break;
        case 3:
            dayName = "Tuesday";
            break;
        case 4:
            dayName = "Wednesday";
            break;
        case 5:
            dayName = "Thursday";
            break;
        case 6:
            dayName = "Friday";
            break;
        case 7:
            dayName = "Saturday";
            break;
            //If none of the cases are true then output this
        default:
            dayName = "Invalid Day Number";
            break;
    }

    return dayName;
}

Console.WriteLine(GetDay(0));
Console.WriteLine(GetDay(4));
Console.ReadLine();