void Programmers()
{
    int programmers = 1114;
    //int programmers = new Random().Next(1, 1000);
    Console.Write(programmers);
    if ( programmers % 10 == 1) Console.Write(" программист");
    else if ( programmers % 10 == 2) Console.Write(" программиста");
    else if ( programmers % 10 == 3) Console.Write(" программиста");
    else if ( programmers % 10 == 4) Console.Write(" программиста");
    else if ( programmers % 100 == 11) Console.Write(" программистов");
    else if ( programmers % 100 == 12) Console.Write(" программистов");
    else if ( programmers % 100 == 13) Console.Write(" программистов");
    else if ( programmers % 100 == 14) Console.Write(" программистов");
    else Console.Write(" программистов");
}

Programmers();
