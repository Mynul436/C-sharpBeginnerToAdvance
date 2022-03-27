namespace Akash;
public struct Coordinate<Data>
{
    public Data x { get; set; }
    public Data y { get; set; }
    public Data DoSomething<P,Q>(Data d, P p, Q q)
    {
        throw new NotImplementedException();
    }
}
public class TestCode
{
    void Test(string[] arg)
    {
        Coordinate<int> incoordinate =new Coordinate<int>();
        incoordinate.x = 100;
        incoordinate.y = 200;
        Coordinate<double> outcoordinate = new Coordinate<double>();
        outcoordinate.x = 100.11;
         outcoordinate.y = 100.15;
        incoordinate.DoSomething<int, double>(10, 10, 10.11);
        
    }
}