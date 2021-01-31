using System;

MyArray a = new MyArray(4);
a.Add(1);
a.Add(3);
a.Add(5);
a.Add(7);
a.Print();
a.Remove(2);
a.Print();
Console.WriteLine(a.Get(1));
