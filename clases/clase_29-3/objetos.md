### Clase 3 - 29-03
# Objetos

Un objeto es un bloque de memoria que ha sido asignado y configurado en base a un molde o plano (clase). Se crean en tiempo de ejecucion.
Tambien se los denomina instancias de una clase. Para crearlos se usa la palabra reservada ***new***.

### Declarar e instanciar un objeto

```C#
NombreClase nombreObjeto;
nombreObjeto = new NombreClase();
// NombreClase() es el constructor del objeto
// En una misma linea -> NombreClase nombreObjeto = new NombreClase();
```

> Es importante que la clase no sea `static`. De lo contrario, no podremos instanciarla.   
> Para acceder a los miembros de una clase estatica:  
> ```C#
>  UtilityClass.MethodA();
>  ````

## Ciclo de vida de un objeto

1. Creacion del objeto
    * Se usa **new** para asignar memoria
    * Se usa un constructor para inicializar un objeto en esa memoria

2. Utilizacion del objeto
    * Llamadas a metodos y atributos

3. Destruccion del objeto
    * Se pierde la referencia en memoria y el *-*Garbage Collector*** libera esa memoria

## Common Language Runtime (CLR)

El CLR es un entorno de ejecucion para los programas que corren sobre .NET. Compila a codigo
maquinan nativo, mediante un compilador en tiempo de ejecucion.
El CLR nos provee de servicios esenciales en tiempo de ejecucion, como lo son la administracion automatica
de la memoria y el manejo de excepciones. Tiene un Garbage Collector que se ejecuta como parte del programa y 
es el encargado de liberar la memoria de los objetos que ya no estan siendo referenciados. 

## Constructores de instancia

Son metodos utilizados para inicializar objetos en el momento de su creacion.
Su nombre y tipo de retorno se reducen al nombre de la clase.

```C#
Panda p = new Panda("Peter"); // Llamada al constructor

public Class Panda
{
  string name;                // Atributo
  public Panda(string n)      // Definicion del constructor
  {
    name = n;                 // Inicializacion del campo name
  }
}
```

**Dato** ⚡  
 Los constructores de una sola sentencia pueden escribirse de la siguiente manera:    
 `public Panda(string n) => name = n;`

Si no definimos ningun constructor, C# creara un **constructor** sin parametros **por defecto**. El mismo sera de acceso
publico, no tiene tipo retorno e inicializa todos los campos a cero, false o null.

```C#
class MiClase 
{
  public MiClase()
  {
    // ...
  }
}
```

## Usando this

**this** hace referencia a la instancia actual de la clase. 

```C#
class Program
{
  static void Main(string[] args)
  {
    Persona persona = new Persona("Jose", 50);
  }
}
public class Persona 
{
  public string nombre;
  public int edad;
  
  public Persona(string nombre, int edad)
  {
    this.nombre = nombre;
    this.edad = edad;
  }
}
```

### Codigo de la clase

[Program.cs (Main)](https://github.com/valentinbegnis/notas_prog-lab_II/blob/main/clases/clase_29-3/Program.cs)  
[MiClase.cs (Clase)](https://github.com/valentinbegnis/notas_prog-lab_II/blob/main/clases/clase_29-3/MiClase.cs)

