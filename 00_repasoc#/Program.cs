// Console.WriteLine("Buen día");

/*Tipos de Datos
int number=15;
Console.WriteLine(number.GetType());
float real=10.5f;
Console.WriteLine(real.GetType());
double real_doble=15.8f;
Console.WriteLine(real_doble);
bool estado=false;
Console.WriteLine(estado.GetType());
string parrafo="Repasando Laboratorio";
Console.WriteLine(parrafo);
char letra='z';
Console.WriteLine(letra);*/
/*
var nombre="Maria";
Console.WriteLine(nombre);
// Estructura Selectiva
Console.Write("Ingrese su nombre: ");
string Nombre=Console.ReadLine();
if(Nombre=="Jose"){
   Console.WriteLine("Bienvenido"+ Nombre);
}
else if (Nombre!="Jose")
{
Console.WriteLine("Acceso denegado");
}

// Estructura de Repetición
/*
for(int i=0;i<11;i++){
    Console.WriteLine(i);
}
*/
/*
int i=20;
while(i<31)
{
    
    Console.WriteLine(i);
    i++;
}
int i=40;
do{
Console.WriteLine(i);
i++;
} while(i<51);*/

/*Funciones*/

Console.WriteLine("ingrese su nombre: ");
string name=Console.ReadLine();
 static void saludar(string name){
    Console.WriteLine("Hola Buenas noches: "+ name);
}
saludar(name);
saludar(name);
saludar(name);

/*

Console.WriteLine("Ingrese num: ");
int num = Int32.Parse(Console.ReadLine());

static string calcular (int num){
    string mensaje;
    if (num % 2 == 0){
        mensaje = "par";
    }
    else{
        mensaje = "impar";
    }
    return mensaje;
}
string m = calcular(num);
Console.Write(m);

/*
int num1=2,num2=9;
int resultado;
 int producto(int num1,int num2){
resultado=num1*num2;
return resultado;
}
Console.WriteLine(producto( num1,num2));*/
