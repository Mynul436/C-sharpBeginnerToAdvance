using AnonymousMethod;

CalculateAddition obj=delegate (int a) {
    a = +10;
    Console.WriteLine(a);

};
obj.Invoke(100);