namespace Exceptions
{
    public class ExceptionManagement
    {
        public static void Execute(int? val)
        {
            Console.WriteLine($"Se executa metoda {nameof(Execute)}");
            try
            {
                InternalExecute(val);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Eroare in {nameof(Execute)} ex {ex.Message}");
                Console.WriteLine($"Draga utilizator, te rugam sa pui o valoare in campul VAL!!!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Eroare in {nameof(Execute)} ex {ex.Message}");
                Console.WriteLine($"Ceva anormal s-a intamplat, contactati administratorul!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare in {nameof(Execute)} ex {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine($"Am terminat de executat metoda {nameof(Execute)}");
            }
        }

        private static void InternalExecute(int? val)
        {
                if (val == null)
                {
                    throw new ArgumentNullException(nameof(val));
                }
                var b = 0;
                var x = val / b;
        }
    }
}