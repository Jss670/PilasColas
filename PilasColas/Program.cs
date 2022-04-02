using Arreglos;
using Listas;

Console.WriteLine("-----------------array pilas");

Arreglos.Pilas pilas = new Arreglos.Pilas(10);
pilas.Agregar("cero");
pilas.Agregar("uno");
pilas.Agregar("dos");
pilas.Agregar("tres");
pilas.Agregar("cuatro");
pilas.Agregar("cinco");
Console.WriteLine(pilas.Imprimir());

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("-----------------------");
        pilas.Eliminar();
        Console.WriteLine(pilas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("-----------------array colas");

Arreglos.Colas colas = new Arreglos.Colas(10);
colas.Agregar("cero");
colas.Agregar("uno");
colas.Agregar("dos");
colas.Agregar("tres");
colas.Agregar("cuatro");
colas.Agregar("cinco");
Console.WriteLine(colas.Imprimir());

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("-----------------------");
        colas.Eliminar();
        Console.WriteLine(colas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("-----------------listas pilas");

Listas.Pilas pilas1 = new Listas.Pilas(10);
pilas1.Agregar("cero");
pilas1.Agregar("uno");
pilas1.Agregar("dos");
pilas1.Agregar("tres");
pilas1.Agregar("cuatro");
pilas1.Agregar("cinco");
Console.WriteLine(pilas1.Imprimir());

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("-----------------------");
        pilas1.Eliminar();
        Console.WriteLine(pilas1.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("-----------------Listas Colas");
Listas.Colas colas1 = new Listas.Colas(10);
colas1.Agregar("cero");
colas1.Agregar("uno");
colas1.Agregar("dos");
colas1.Agregar("tres");
colas1.Agregar("cuatro");
colas1.Agregar("cinco");
Console.WriteLine(colas1.Imprimir());

for (int i= 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("-----------------------");
        colas1.Eliminar();
        Console.WriteLine(colas1.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}