using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            HandleMenuOptions(option);
            
        }
        public static void DrawScreen()
        {
            Columns();
            Lines();
            Columns();
        }
        public static void Columns()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        public static void Lines()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML.");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("____________________________");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Selecione uma das opções: ");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 11);
            Console.Write("Opção: ");


        }
        public static void HandleMenuOptions(short option)
        {
            switch(option)
            {
                case 1 :Editor.Show();break;
                case 2 :Viewer.Show("");break;
                case 0 :
                {
                    Console.Clear();
                    Environment.Exit(0);
                };break;
                default:
                {
                    Console.SetCursorPosition(3, 1);
                    Console.WriteLine("Opção Inválida! ");
                    Thread.Sleep(2000);
                    Show();
                }
                break;

            }
        }

    }
}