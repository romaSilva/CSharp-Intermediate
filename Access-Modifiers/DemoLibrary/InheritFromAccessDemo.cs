namespace DemoLibrary
{
    public class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo();
            InternalDemo();
            PrivateProtectedDemo();

        }
    }
}