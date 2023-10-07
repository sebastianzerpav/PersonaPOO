namespace PersonaPOO_SebasZerpa
{
    public class Program
    {
        static void Main(string[] args)
        {
            string FIRST_NAME, LAST_NAME;
            int YEAR_BIRTH;

            Console.Write("Ingrese su primer nombre: ");
            FIRST_NAME = Console.ReadLine();
            Console.Write("Ingrese su primer apellido: ");
            LAST_NAME = Console.ReadLine();
            Console.Write("Ingrese su año de nacimiento: ");
            YEAR_BIRTH = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Person person = new Person(FIRST_NAME, LAST_NAME, YEAR_BIRTH);

            Console.WriteLine(person.showPersonInfo);
            Console.WriteLine($"Su edad calculada es: {person.CalculateAge()}");

        }
    }
}
