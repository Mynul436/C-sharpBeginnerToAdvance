int? x = null;
if(x.HasValue)
    Console.WriteLine(x.Value);
int xx=x==null?0:x.Value;
int z = x ?? 0;
Console.WriteLine(z);