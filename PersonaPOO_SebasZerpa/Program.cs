namespace PersonaPOO_SebasZerpa
{
    public class Program
    {
        static void Main(string[] args)
        {
            string FIRST_NAME, LAST_NAME;
            int YEAR_BIRTH;

            Console.WriteLine("----- CALCULADORA DE EDAD -----\n");
            Console.Write("Ingrese su primer nombre: ");
            FIRST_NAME = Console.ReadLine();
            Console.Write("Ingrese su primer apellido: ");
            LAST_NAME = Console.ReadLine();
            Console.Write("Ingrese su año de nacimiento: ");
            YEAR_BIRTH = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Person person = new Person(FIRST_NAME, LAST_NAME, YEAR_BIRTH);

            Console.WriteLine("----- DATOS RECOPILADOS PARA CALCULAR SU EDAD -----\n");
            Console.WriteLine(person.showPersonInfo());
            Console.WriteLine("----- RESULTADO -----\n");
            Console.WriteLine(person.dirigirseAPersona());
            Console.WriteLine($"Su edad calculada es: {person.CalculateAge()}");
        }
    }
}
