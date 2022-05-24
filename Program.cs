/*
Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
Pueden adjuntarnos el archivo .cs, o el codigo como texto.
*/

int [] num = new int [10];
int acc = 0;
int mayor = num[0];
int menor = 2147483647;


for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Ingrese el {i+1} número: ");
    num[i] = int.Parse(Console.ReadLine());
    
 
    if(num[i]> mayor){
        mayor = num[i];
    }
    if(num[i] < menor){
        menor = num[i];
    }
    acc += num[i];
}

int promedio = acc/num.Length;

Console.WriteLine($"La suma de los numeros ingresados es {acc}");
Console.WriteLine($"El mayor número ingresado es {mayor}");
Console.WriteLine($"El menor número ingresado es {menor}");
Console.WriteLine($"El promedio de los nùmeros ingresados es {promedio}");

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"El {i +1} numero ingresado es {num[i]}");
}