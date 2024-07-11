namespace Common
{
    public class TypeA
    {
        private int x;
        internal int y;
        public int z;
        void fn()
        {
            TypeA typeA = new TypeA();
            TypeB typeB = new TypeB();
            typeA.x = 12;
            typeA.y = 13;
            typeA.z = 14;
        }
    }
}
