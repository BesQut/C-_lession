int a = 1;
int b = 6;
int d = 8;
int c = 2;
int i = 3;

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(d > max) max = d;
if(c > max) max = c;
if(i > max) max = i;

Console.Write("max= ");
Console.WriteLine(max);