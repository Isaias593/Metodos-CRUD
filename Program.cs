using app1_Migrations.Modelos;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        //agregarEstudiante();
        //consultarEstudiantes();
        //consultarEstudiante();
        modificarEstudiante();
        //eliminarEstudiante();
        consultarEstudiantesFunciones();
    }

    //agregar estudiante
    public static void agregarEstudiante()
    {
        AplicationDbContext context = new AplicationDbContext();

        Console.WriteLine("Metodo agregar estudiante");
        Usuario user = new Usuario();
        user.Name = "Isaaias";
        user.Lastname = "PCZ";
        user.Direccion = "Mapasingue este";
        user.Phone = "1234555";
        user.Birthday = "12/06/2001";
        user.Status = true;
        context.Usuarios.Add(user);
        context.SaveChanges();

        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Name);

    }

    public static void consultarEstudiantes()
    {
        AplicationDbContext context = new AplicationDbContext();

        List<Usuario> listEstudiantes = context.Usuarios.ToList();

        foreach (var item in listEstudiantes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Name: " + item.Name);
        }

    }

    public static void consultarEstudiante()
    {
        Console.WriteLine("Metodo consultar estudiante por Id");
        AplicationDbContext context = new AplicationDbContext();
        Usuario user = new Usuario();
        user = context.Usuarios.Find(1);

        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Name);

    }

    public static void modificarEstudiante()
    {
        Console.WriteLine("Metodo modificar estudiante");
        AplicationDbContext context = new AplicationDbContext();
        Usuario user = new Usuario();
        user = context.Usuarios.Find(1);

        user.Name = "Anahi";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Name);

    }

    public static void eliminarEstudiante()
    {
        Console.WriteLine("Metodo eliminar estudiante");
        AplicationDbContext context = new AplicationDbContext();
        Usuario user = new Usuario();
        user = context.Usuarios.Find(5);
        context.Remove(user);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Name);

    }
    public static void consultarEstudiantesFunciones()
    {
        Console.WriteLine("Metodo consultar estudiantes con el uso de funciones");
        AplicationDbContext context = new AplicationDbContext();
        List<Usuario> listEstudiantes;

        Console.WriteLine("Cantidad de registros: " + context.Usuarios.Count());
        Usuario user = context.Usuarios.First();

        Console.WriteLine("Primer elemento de la tabla:" + user.Id + "-" + user.Name);

        listEstudiantes = context.Usuarios.Where(s => s.Name.StartsWith("A")).ToList();



        foreach (var item in listEstudiantes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Name: " + item.Name);
        }
    }
}
