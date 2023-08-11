using DataAccessLayer;
using DataAccessLayer.NewFolder.DALS;
using Shared;



IDal_Persona personaSrv = new DAL_Persona();

do
{
    Console.Clear();
    try
    {
        string nombre;
        string apellido;
        string documento;
        DateTime fecha_nacimiento;

        Console.WriteLine("Por favor ingresa tu nombre");
        nombre = Console.ReadLine();


        Console.WriteLine("Por favor ingresa tu apellido");
        apellido = Console.ReadLine();

        Console.WriteLine("Por favor ingresa tu documento");
        documento = Console.ReadLine();



  

        
        Console.WriteLine("Por favor ingresa tu fecha de nacimiento");
        fecha_nacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);



        Persona newPersona = new Persona();
        newPersona.nombre = nombre;
        newPersona.apellido = apellido;
        newPersona.Documento = documento;
        newPersona.fecha_nacimiento = fecha_nacimiento;

        personaSrv.insert(newPersona);
     

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally
    {
        Console.WriteLine("Escribe 'exit' si deseas finalizar");
        

    }



} while (!Console.ReadLine().ToUpper().Equals("EXIT"));


Console.Clear();

Console.WriteLine("--------LISTADO DE PERSONAS-------------------");
personaSrv.GetPersonas().OrderBy(x=> x.fecha_nacimiento).ToArray().ToList().ForEach(persona => {
    Console.WriteLine(persona.ToString());
    Console.WriteLine("---------------------------");
});



