namespace L_ClassesEstaticas
{
    static class Matematica
    {
        public static int taxa = 10;

        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }
    }
}
