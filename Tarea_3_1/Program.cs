using System;

class Vehiculo
{
    private string brand;
    private string model;
    private int year;

    public string Brand
    {
        get { return brand; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                brand = value;
            }
            else
            {
                Console.WriteLine("La marca no puede estar vacía.");
            }
        }
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                model = value;
            }
            else
            {
                Console.WriteLine("El modelo no puede estar vacío.");
            }
        }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value > 0)
            {
                year = value;
            }
            else
            {
                Console.WriteLine("El año debe ser mayor que cero.");
            }
        }
    }

    public void getInformation()
    {
        Console.WriteLine($"Información del Vehículo: Marca - {Brand}, Modelo - {Model}, Año - {Year}");
    }

    public void runAction()
    {
        Console.WriteLine("Acelerando.");
    }
}

class Automovil : Vehiculo
{
    private int doors;

    public int Doors
    {
        get { return doors; }
        set
        {
            if (value >= 2)
            {
                doors = value;
            }
            else
            {
                Console.WriteLine("Un automóvil debe tener al menos 2 puertas.");
            }
        }
    }

    public new void getInformation()
    {
        base.getInformation();
        Console.WriteLine($"Cantidad de Puertas: {Doors}");
    }
}

class Camioneta : Vehiculo
{
    private double loadcapacity;

    public double LoadCapacity
    {
        get { return loadcapacity; }
        set
        {
            if (value > 0)
            {
                loadcapacity = value;
            }
            else
            {
                Console.WriteLine("La capacidad de carga debe ser mayor que cero.");
            }
        }
    }

    public new void getInformation()
    {
        base.getInformation();
        Console.WriteLine($"Capacidad de Carga: {LoadCapacity} toneladas");
    }
}

class Program
{
    static void Main()
    {
        Automovil miAutomovil = new Automovil();
        miAutomovil.Brand = "Hyundai";
        miAutomovil.Model = "Accent";
        miAutomovil.Year = 1996;
        miAutomovil.Doors = 4;

       miAutomovil.getInformation();

        miAutomovil.runAction();

        Console.WriteLine();

        Camioneta miCamioneta = new Camioneta();
        miCamioneta.Brand = "Chevrolet";
        miCamioneta.Model = "D-Max";
        miCamioneta.Year = 2020;
        miCamioneta.LoadCapacity = 3.7;

        miCamioneta.getInformation();

        miCamioneta.runAction();
    }
}
