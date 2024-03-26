// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("_________________________________________\n" + "*****************************************");

Console.WriteLine($"{"N",-4}{"Название",-20}{"Цена",-6}{"Кол.",-6}{"Сумма",-6}\n");

Console.WriteLine($"{1,-4}{"КОФЕ СТАНДАРТНЫЙ",-20}{"69.00",-6}{"1.00",-6}{"69.00",-6}");
Console.WriteLine($"{"",-4}{"НДС с рассчитанной",-20}{"",-6}{"",-6}{"10.53",-6}");
Console.WriteLine($"{"",-4}{"ставкой 18%"}\n");
Console.WriteLine($"{2,-4}{"РУЛЕТ-СПРИНГ ТВ ИЗ",-20}{"70.00",-6}{"1.00",-6}{"70.00",-6}");
Console.WriteLine($"{"",-4}{"КУ"}");
Console.WriteLine($"{"",-4}{"НДС с рассчитанной",-20}{"",-6}{"",-7}{"6.36",-6}");
Console.WriteLine($"{"",-4}{"ставкой 10%"}\n");



Console.WriteLine("_________________________________________\n");
Console.WriteLine($"{"ИТОГО:",-34} {"139.00"}\n");
Console.WriteLine($"{"Электронные средства",-34} {"139.00"}");
Console.WriteLine($"{"НДС итога чека с",-35} {"10.53"}");
Console.WriteLine($"{"рассчитанной ставкой"}");
Console.WriteLine($"{"18%"}");
Console.WriteLine($"{"НДС итога чека с",-35}  {"6.36"}");
Console.WriteLine($"{"рассчитанной ставкой"}");
Console.WriteLine($"{"10%"}\n");
Console.WriteLine("_________________________________________");
Console.WriteLine($"{"ВИД НАЛОГОБЛАЖЕНИЯ: ОСН"}");
Console.WriteLine($"{"РЕГ НОМЕР ККТ: 0000143873023483"}");
Console.WriteLine($"{"ЗАВОД. N:"}");
Console.WriteLine($"{"ФН N:8710000100265168"}");
Console.WriteLine($"{"ФД N:6026"}");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{"ФПД: 3322278314"}");
