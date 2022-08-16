
using Lambda_Expression;

Add obj = (a) =>
  {
    a=+10;
      Console.WriteLine(a);

  };
obj.Invoke(10);