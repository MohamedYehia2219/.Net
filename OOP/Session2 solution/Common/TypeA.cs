namespace Common
{
    public class TypeA
    {
        /*without inheritance (protected means nothing)
        private protected int x;    // private
        protected int y;            // private
        internal protected int z;   // internal
        private int m;              // private*/

        //In case of inheritance
        private protected int x;    
        protected int y;           
        internal protected int z;  
        private int m;             
    }
}
