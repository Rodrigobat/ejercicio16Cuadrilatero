namespace EjercicioClase16
{
    public abstract class Cuadrilatero
    {
        public Cuadrilatero()
        {
            //cargamos los datos
            Console.WriteLine("ingrese la coordenada X del primer vertice");
            vertice1x=double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada Y del primer vertice");
            vertice1y=double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la coordenada X del segundo vertice");
            vertice2x=double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada Y del segundo vertice");
            vertice2y=double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la coordenada X del tercer vertice");
            vertice3x=double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada Y del tercer vertice");
            vertice3y=double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la coordenada X del cuarto vertice");
            vertice4x=double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la coordenada Y del cuarto vertice");
            vertice4y=double.Parse(Console.ReadLine());

        }
        //definimos los campos
        private double _x=0, _y=0, _x2=0, _y2=0, _x3=0, _y3=0, _x4=0, _y4=0;
        //creamos las propiedades para dar valor a los campos
        public double vertice1x
        {
            get => _x;
            set => _x=value;
        }
        public double vertice1y
        {
            get => _y;
            set => _y = value;
        }
        public double vertice2x
        {
            get => _x2;
            set => _x2=value;
        }
        public double vertice2y
        {
            get => _y2;
            set => _y2=value;
        }
        public double vertice3x
        {
            get => _x3;
            set => _x3=value;
        }
        public double vertice3y
        {
            get => _y3;
            set => _y3=value;
        }
        public double vertice4x
        {
            get => _x4;
            set => _x4=value;
        }
        public double vertice4y
        {
            get => _y4;
            set => _y4=value;
        }
        //metodo abstracto
       public abstract double calcularArea();
    }
}