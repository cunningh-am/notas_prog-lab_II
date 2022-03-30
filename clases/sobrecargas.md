### Clase 3 - 30-03
# Sobrecarga

## Sobrecarga de metodos

Los metodos no pueden compartir el mismo nombre que un atributo, pero si qque otro metodo, siempre dentro de la misma clase. A esto se le llama sobrecarga de metodos y se utiliza cuando quiero que un metodo haga lo mismo que otro pero con diferentes parametros. En lugar de definir un nuevo metodo hago una sobrecarga.

Los metodos se pueden sobrecargar siempre y cuando cambie la firma. La firma es la lista de parametros. Que un parametro sea pasado por valor o referencia tambien influye en la firma. void Foo(int) puede coexistir con Foo(ref int) o Foo(out int). Sin embargo, Foo(ref int) y Foo(out int) no pueden coexistir.

```
void Foo(int x) {...}
void Foo(ref int x) {...} // Ok
void Foo(out int x) {...} // Compile Time Error
```
### Ejemplo de sobrecarga:

```
static int PlusMethod(int x, int y)
{
  return x + y;
}

static double PlusMethod(double x, double y)
{
  return x + y;
}

static void Main(string[] args)
{
  int myNum1 = PlusMethod(8, 5);
  double myNum2 = PlusMethod(4.3, 6.26);
  Console.WriteLine("Int: " + myNum1);
  Console.WriteLine("Double: " + myNum2);
}
```

## Sobrecarga de constructores

Un constructor es un metodo que permite ejecutar codigo en el momento en el que se genera una nueva instancia de una clase. Una clase puede sobrecargar constructores. De esta forma, segun los parametros ingresados al instanciar la clase, esta sabra de que forma crear el objeto.

### Ejemplo de sobrecarga de constructores
```
public Book(string title, string author)
{
    Title = title;
    Author = author;
}
 
public Book(string title, string author, string publisher, int pubDate)
{
    Title = title;
    Author = author;
    Publisher = publisher;
    PubDate = pubDate;
}
```

### Ejemplo usando this

```
public class Wine
{
    public decimal price;
    public int year;

    public Wine(decimal n) 
    {
        price = n;
    }

    public Wine(decimal n, int y) : this(n) 
    {
        year = y;
    }
}
```


