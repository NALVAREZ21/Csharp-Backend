// Console.WriteLine("Buen día");

// Tipos de Datos
// int number=15;
// Console.WriteLine(number.GetType());
// float real=10.5f;
// Console.WriteLine(real.GetType());
// double real_doble=15.8f;
// Console.WriteLine(real_doble);
// bool estado=false;
// Console.WriteLine(estado.GetType());
// string parrafo="Repasando Laboratorio";
// Console.WriteLine(parrafo);
// char letra='z';
// Console.WriteLine(letra);//

// // Estructura Selectiva
// Console.Write("Ingrese su nombre: ");
// string Nombre=Console.ReadLine();
// if(Nombre=="Jose"){
//    Console.WriteLine("Bienvenido"+ Nombre);
// }
// else if (Nombre!="Jose")
// {
// Console.WriteLine("Acceso denegado");
// }
//Estructura de Repetición
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
}*/
/*int i=40;
do{
Console.WriteLine(i);
i++;
} while(i<51);*/

int[]edades_personas=new int[4];
/* Mostrar por array de uno a uno, sin ciclo de repetición*/
edades_personas[0]=24;
edades_personas[1]=97;
edades_personas[2]=54;
edades_personas[3]=22;
/*
Console.WriteLine(edades_personas[1]);*/
/*Ciclo de repetición FOR*/
/*
for(int i=0; i<edades_personas.Length; i++){
    Console.WriteLine(edades_personas[i]);

}*/
/*
string [] nombres_mascotas = new string [3];
Console.WriteLine(nombres_mascotas.Length);
for(int i=0; i<nombres_mascotas.Length; i++){
    Console.WriteLine("ingrese el nombre de su mascota: " + i);
    nombres_mascotas[i]=Console.ReadLine();
}

for (int i=0; i<nombres_mascotas.Length; i++){
    Console.WriteLine(nombres_mascotas[i]);
}
*/

double [] reales =new double [ 2];
reales [0]= 1.23;
reales[1]= 19.58;

foreach(var real  in reales ){
    Console.WriteLine(real);
}
