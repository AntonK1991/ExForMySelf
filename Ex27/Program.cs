// Определить количество цифр в числе

// int DigitAmount (int a)
// {
//     int count = 0;
//     while (a>0)
//     {
//         a = a/10; 
//         count++;
//     } 
//     return count;   
// }


// int a = 612345;
// int b = DigitAmount(a);

// Console.WriteLine(b);


int a = 123456;
string res = Convert.ToString(a);
Console.WriteLine(res.Length);