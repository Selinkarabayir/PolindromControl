namespace polindromodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char answer;
            string kelime;
            do
            {

                Console.Write("Kelimeyi giriniz...: "); kelime = Console.ReadLine();
                stack Stack = new stack(kelime.Length);
                Queue queue = new Queue(kelime.Length);
                Stack.push(kelime);
                Console.WriteLine("---STACK YAPISI---");
                Stack.Sprint();
                Console.WriteLine();


                queue.enQueue(kelime);
                Console.WriteLine("---QUEUE YAPISI---");
                queue.Qprint();
                Console.WriteLine();


                int s = 0;
                while (Stack.top > 0)
                {
                    if (Stack.pop() != queue.deQueue())
                    {
                        Console.WriteLine("******Girilen kelime palindrom değil...");
                        s++;
                        break;
                    }
                }
                if (s == 0)
                {
                    Console.WriteLine("******Polindrom bir kelime girdiniz...");
                }

                Console.Write("******Devam etmek istiyormusunuz? (e/h)...: "); answer = Convert.ToChar(Console.ReadLine());
            } while (answer == 'e' || answer == 'E');
            Console.ReadKey();
        }

    }
}
