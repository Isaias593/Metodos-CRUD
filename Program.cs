
using DAWA_MetodosCRUD.Models;

class Program
{
    static void Main(string[] args)
    {
        addCliente();
        updateCliente();
        listClientes();
        findClienteId(1);
        findClienteName("Jose");
    }

    public static void addCliente()
    {
        Console.WriteLine("Agregar Cliente:");

        AppDbContext context = new AppDbContext();
        Cliente cliente = new Cliente();

        cliente.Nombre = "NIC";
        cliente.Apellido = "EZAAZ";
        cliente.Direccion = "TRIKITRAKATELAS";
        cliente.Telefono = "0123456789";
        cliente.FechaNacimiento = new DateTime(1999, 4, 19);
        cliente.Estado = true;

        context.Cliente.Add(cliente);
        context.SaveChanges();

        Console.WriteLine("Se agrego el cliente: " + cliente.Nombre + " " + cliente.Apellido);
    }

    public static void updateCliente()
    {
        Console.WriteLine("Modificar Cliente:");

        AppDbContext context = new AppDbContext();
        Cliente cliente = new Cliente();

        cliente = context.Cliente.Find(1);
        cliente.Nombre = "TRIKITRI";
        cliente.Apellido = "SACAKTALE";
        context.SaveChanges();
        Console.WriteLine("Se actualizo información del cliente: " + cliente.Nombre + " " + cliente.Apellido);

    }

    public static void listClientes()
    {
        Console.WriteLine("Listar Clientes");
        AppDbContext context = new AppDbContext();
        List<Cliente> listClientes;
        listClientes = context.Cliente.ToList();
        foreach (var item in listClientes)
        {
            Console.WriteLine("Nombre: " + item.Nombre + " Apellido: " + item.Apellido);
        }
    }

    public static void findClienteId(int Id)
    {
        Console.WriteLine("Buscar Cliente por ID:");

        AppDbContext context = new AppDbContext();
        Cliente cliente = new Cliente();

        cliente = context.Cliente.Find(Id);
        Console.WriteLine("Cliente encontrado Id (" + cliente.IdCliente + "): " +
            cliente.Nombre + " " + cliente.Apellido);
    }

    public static void findClienteName(String name)
    {
        Console.WriteLine("Buscar Cliente por Nombre:");

        AppDbContext context = new AppDbContext();
        List<Cliente> listClientes;
        listClientes = context.Cliente.Where(c => c.Nombre == name).ToList();
        foreach (var item in listClientes)
        {
            Console.WriteLine("Nombre: " + item.Nombre + " Apellido: " + item.Apellido);
        }
    }
}
