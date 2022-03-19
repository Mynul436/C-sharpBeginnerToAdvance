namespace OOP
{
    internal interface IDice
    {
       double[] FaceValue { get; }
       double[] Size { get; }

        void Roll();
    }
}