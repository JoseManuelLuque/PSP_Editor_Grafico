//Main
try
{
    Console.Clear();
    
    //Punto
    Console.WriteLine("Dime un Punto");
    Console.Write("Coordenada X: ");
    string xPunto = Console.ReadLine();
    Console.Write("Coordenada Y: ");
    string yPunto = Console.ReadLine();

    Punto punto = new Punto(Int32.Parse(xPunto) , Int32.Parse(yPunto));
    
    Console.WriteLine("");
    
    //Circulo
    Console.WriteLine("Vamos a crear un Círculo");
    Console.Write("Coordenada X: ");
    string xCirculo = Console.ReadLine();
    Console.Write("Coordenada Y: ");
    string yCirculo = Console.ReadLine();
    Console.Write("Radio: ");
    string radio = Console.ReadLine();

    Punto circulo = new Circulo(Int32.Parse(xCirculo) , Int32.Parse(yCirculo), Int32.Parse(radio));
    
    Console.WriteLine("");
    
    //Rectangulo
    Console.WriteLine("Vamos a crear un Círculo");
    Console.Write("Coordenada X: ");
    string xRectangulo = Console.ReadLine();
    Console.Write("Coordenada Y: ");
    string yRectangulo = Console.ReadLine();
    Console.Write("Alto: ");
    string alto = Console.ReadLine();
    Console.Write("Ancho: ");
    string ancho = Console.ReadLine();
    

    Punto rectangulo = new Rectangulo(Int32.Parse(xRectangulo) , Int32.Parse(yRectangulo), Int32.Parse(alto), Int32.Parse(ancho));
    Console.Clear();
    
    //Menu
    Console.WriteLine("1. Mover el gráfico\n2. Salir");
}

catch (Exception ex)
{   
    Console.Clear();
    Console.WriteLine("Nombre Excepcion: " + ex.Message);
    Console.WriteLine("");
    throw (ex);
}



//Clases
interface IGrafico
{
    bool mover(int x, int y);
    void dibujar();
}

public class Punto:IGrafico
{
    public int X { set; get; }
    public int Y { set; get; }

    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool mover(int x, int y)
    {
        throw new NotImplementedException();
    }

    public void dibujar()
    {
        throw new NotImplementedException();
    }
}

public class GraficoCompuesto:IGrafico
{
    //TODO
    
    public bool mover(int x, int y)
    {
        throw new NotImplementedException();
    }

    public void dibujar()
    {
        throw new NotImplementedException();
    }
}

public class Circulo: Punto
{
    public int Radio { set; get; }

    public Circulo(int X, int Y, int radio):base(X, Y)
    {
        Radio = radio;
    }
}

public class Rectangulo: Punto
{
    public int Ancho { set; get; }
    public int Alto { set; get; }
    
    public Rectangulo(int X, int Y, int ancho, int alto):base(X, Y)
    {
        Alto = alto;
        Ancho = ancho;
    }

}