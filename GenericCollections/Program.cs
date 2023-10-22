namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapar object från empleyee klassen

            Employee employee1 = new Employee(1, "Micke", "Male", 50000);

            Employee employee2 = new Employee(2, "Maria", "Female", 40000);

            Employee employee3 = new Employee(3, "Hannes", "Male", 60000);

            Employee employee4 = new Employee(4, "Tess", "Female", 100000);

            Employee employee5 = new Employee(5, "Andres", "Male", 200000);

            //Skapar en Stack

            Stack<Employee> StackE = new Stack<Employee>();

            // Lägger in alla employees objekt i stacken
            StackE.Push(employee1);
            StackE.Push(employee2);
            StackE.Push(employee3);
            StackE.Push(employee4);
            StackE.Push(employee5);


            //loppar genom stacken för att sedan skriva ut varje object och räknar antal objekt kvar i stacken
            foreach ( Employee emp in StackE )
            {
                Console.WriteLine($"Items left in the Stack {StackE.Count}");
                Console.WriteLine( $"Id: {emp.Id} - Name: {emp.Name} - Gender: {emp.Gender} - Salary: {emp.Salary}" );

            }

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Retrive using pop method");

            //kör så länge stacken har object och visar antal objekt i stacken

            while (StackE.Count > 0)
            {
                Employee employee = StackE.Pop();
                Console.WriteLine($"Id: {employee.Id} - Name: {employee.Name} - Gender: {employee.Gender} - Salary: {employee.Salary}");
                Console.WriteLine($"Items left in the Stack {StackE.Count}");
            }

            // pushar in de objekt som blev pop ut
            StackE.Push(employee1);
            StackE.Push(employee2);
            StackE.Push(employee3);
            StackE.Push(employee4);
            StackE.Push(employee5);

            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("Retrive using peek method");


            //visar den sista objekt som kom in i stacken
            Employee emppeek1 = StackE.Peek();
            Console.WriteLine($"Id: {emppeek1.Id} - Name: {emppeek1.Name} - Gender: {emppeek1.Gender} - Salary: {emppeek1.Salary}");
            Console.WriteLine($"Items left in the stack: {StackE.Count}");
             // samma här
            Employee emppeek2 = StackE.Peek();
            Console.WriteLine($"Id: {emppeek2.Id} - Name: {emppeek2.Name} - Gender: {emppeek2.Gender} - Salary: {emppeek2.Salary}");
            Console.WriteLine($"Items left in the stack: {StackE.Count}");

            Console.WriteLine("-------------------------------------------------------------");

            //kollar om employee med id 3 finns i stacken
            foreach ( Employee CheckO in StackE ) 
            {
                if ( CheckO.Id == 3)
                {
                    Console.WriteLine("Emp3 is in stack");
                }
            }

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Del 2");

            Console.WriteLine("-------");

            Console.WriteLine();

            //skappar en lista av objekt
            List<Employee> listE = new List<Employee>();

            //lägger till objekt i listan
            listE.Add(employee1);
            listE.Add(employee2);
            listE.Add(employee3);
            listE.Add(employee4);
            listE.Add(employee5);

            // kollar om employee2 objektet finns i listan
            if ( listE.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in list");
            }
            else
            {
                Console.WriteLine("Employee2 Doesn't exist in list");
            }

            Console.WriteLine();

            // kollar efter första objekt i listan med Male Gender och printar ut hela objektet
            Employee FindMale = listE.Find(emp => emp.Gender == "Male");
            Console.WriteLine($"ID = {FindMale.Id}, Name = {FindMale.Name}, Gender = {FindMale.Gender}, Salary = {FindMale.Salary}");

            Console.WriteLine();

            // skapar en lista av alla male gender objekt
            List<Employee> MaleE = listE.FindAll(emp => emp.Gender == "Male");

            //loppar genom listan med male gender för att sedan skriva ut alla dessa.
            foreach( Employee Male in MaleE )
            {
                Console.WriteLine($"ID = {Male.Id}, Name = {Male.Name}, Gender = {Male.Gender}, Salary = {Male.Salary}");
            }
        }
    }
}