using System;

namespace Tablero
{
    class Program
    {
        static void Main(string[] args)
        {
            string tab;
            char esp = 'X';
           for (int i=0;i<8;i++)
            {
                tab = null;
                for (int j=0; j<8; j++)
                {
                    tab += esp;
                    esp = Cambiar_Espacio(esp);
                }
                Console.WriteLine(tab);
                esp = Cambiar_Espacio(esp);
            }
            Console.ReadKey();
        }

        private static char Cambiar_Espacio(char esp)
        {
            if (esp == 'O')
                esp = 'X';
            else
                esp = 'O';
            return esp;
        }
    }
}