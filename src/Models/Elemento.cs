namespace EstruturasLineares
{
    public class Elemento
    {
        public int Num;
        public Elemento Prox;

        public Elemento()
        {
            Num = 0;
            Prox = null;
        }

        public Elemento(int num)
        {
            Num = num;
            Prox = null;
        }
    }
}