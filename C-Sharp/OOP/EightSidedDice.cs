namespace OOP
{
    internal class EightSidedDice : Dice
    {
        public EightSidedDice()
        {
            Size = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Size[i] = i + 1;
            }
        }
        //hrllo
        public override void Roll()
        {
            Console.WriteLine("Rolling for eight sided Dice");
            Console.WriteLine(Size);
            Console.WriteLine();
        }
    }
}
