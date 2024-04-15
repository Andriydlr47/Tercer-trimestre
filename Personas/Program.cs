namespace Personas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una_persona();
            //Lista_personas();
            //
            Cola_personas();
        }
        private static void Una_persona() 
        {
            Persona contribuyente = new Persona(12345678, 'Z', "Adela", 27);
            // contribuyente.Nombre = "Jose"
        }
        private static void Lista_personas() 
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona(12345678, 'Z', "Juan", 12));
            personas.Add(new Persona(12345678, 'Z', "Juan", 11));
            personas.Add(new Persona(12345678, 'Z', "Juan Pedro", 12));
            personas.Add(new Persona(12345677, 'Z', "Silvia", 24));
            personas.Add(new Persona(12345660, 'Z', "Jose Gregorio", 45));
        }
        private static void Cola_personas() 
        {
            Persona atendido;
            Queue<Persona> cola_personas = new Queue<Persona>();
            Stack<Persona> pila_personas = new Stack<Persona>();

            cola_personas.Enqueue(new Persona(12345678, 'z', "Juan", 12));
            cola_personas.Enqueue(new Persona(12345678, 'z', "Silvia", 24));
            cola_personas.Enqueue(new Persona(12345678, 'z', "José Gregorio", 45));
            Tablas.mostrar(cola_personas.ToArray());
            cola_personas.Enqueue(new Persona(12345678, 'z', "Adal", 3));
            Tablas.mostrar(cola_personas.ToArray());


            Console.WriteLine("Cola de la tienda...");
        }
        private static void Conjunto_personas() 
        {
            HashSet<Persona> personas = new HashSet<Persona>();
            personas.Add(new Persona(12345678, 'z', "Juan", 12));
            personas.Add(new Persona(12345678, 'z', "Juancito", 12));
            personas.Add(new Persona(12345678, 'z', "Pepe Juan", 12));
            
            personas.Add(new Persona(12345670, 's', "Silvia", 24));
            personas.Add(new Persona(12345679, 'z', "José Gregorio", 45));
            Tablas.listar(personas.ToArray());
            
            personas.Add(new Persona(12345681, 'v', "Adal", 3));
            Tablas.listar(personas.ToArray());

            Persona p = new Persona(12345679, 's', "M Silvia", 24);
            
        }
    }
}