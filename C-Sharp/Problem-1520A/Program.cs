
int TestCase=Convert.ToInt32(Console.ReadLine());



while (TestCase!=0)
{
    int num=Convert.ToInt32(Console.ReadLine());

   // String[] str=new String[num];
  //  str = Console.ReadLine().Split();
        String str =Console.ReadLine();
   
    for (int i=0; i<num; i++)
    {
        for (int j = i+1; j < num; j++)
        {
            if (str[i]==str[j])
            {

            }
            if(str[i]!=str[j])
            {
                for (int k = j+1; k < str.Length; k++)
                {
                    if (str[i] == str[k])
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
        }
      // Console.WriteLine("YES");
    }
  Console.WriteLine("YES");

    TestCase--;
}