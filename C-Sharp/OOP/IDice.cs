namespace OOP
{
    internal interface IDice
    {
        int[] FaceValue { get; }
        int[] Size { get; }

        void Roll();
    }
}