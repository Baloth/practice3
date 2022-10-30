

namespace piano
{
    internal class MainCommand
    {
        private int[] currentOctava = { };
        private int[] oktava1 = { 60, 140, 270, 550, 1109, 2217, 4435, 8900, 15000 };
        private int[] oktava2 = { 80, 160, 300, 600, 1209, 2517, 4935, 9900, 17000 };
        private int[] oktava3 = { 110, 180, 340, 650, 1309, 2717, 5635, 10900, 19000 };


        public void Main()
        {
            currentOctava = oktava1;
            Console.CursorVisible = false;
            Header();
            ConsoleKey key = ConsoleKey.D1;

            while (key != ConsoleKey.Escape)
            {
                key = Console.ReadKey().Key;
                
                switch (key)
                {
                    case ConsoleKey.D1:
                        Beep(currentOctava[0]);
                        break;
                    case ConsoleKey.D2:
                        Beep(currentOctava[1]);
                        break;
                    case ConsoleKey.D3:
                        Beep(currentOctava[2]);
                        break;
                    case ConsoleKey.D4:
                        Beep(currentOctava[3]);
                        break;
                    case ConsoleKey.D5:
                        Beep(currentOctava[4]);
                        break;
                    case ConsoleKey.D6:
                        Beep(currentOctava[5]);
                        break;
                    case ConsoleKey.D7:
                        Beep(currentOctava[6]);
                        break;
                    case ConsoleKey.D8:
                        Beep(currentOctava[7]);
                        break;
                    case ConsoleKey.D9:
                        Beep(currentOctava[8]);
                        break;
                    case ConsoleKey.F1:
                        ChangeOktava(oktava1);
                        break;
                    case ConsoleKey.F2:
                        ChangeOktava(oktava2);
                        break;
                    case ConsoleKey.F3:
                        ChangeOktava(oktava3);
                        break;
                    default:
                        
                        break;
                }
                Console.Clear();
                Header();
            }
        }

        private void Header()
        {
            Console.WriteLine("Переключение октав - F1,F2,F3");
            Console.WriteLine("ноты - цифры с 1 до 9");

        }

        private void Beep(int freq)
        {
            Console.Beep(freq, 100);
        }

        private void ChangeOktava(int[] oktava)
        {
            currentOctava = oktava;
        }
        
    }
}
