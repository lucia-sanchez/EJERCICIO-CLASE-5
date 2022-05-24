

var respuesta = "S";

while (respuesta.ToUpper() == "S"){
    //BORRO LA PANTALLA
Console.Clear();
    //PIDO QUE EL USUARIO INGRESE DATOS
Console.WriteLine("Por favor, ingrese su nombre");
    //GUARDO EL NOMBRE EN UNA VARIABLE
var name = Console.ReadLine();
    //MUESTRO EL SALUDO
Console.WriteLine($"Hola! {name}");
    //MUESTRO LA PREGUNTA
Console.WriteLine("¿Desea continuar?");
    //GUARDO LA RESPUESTA EN LA MISMA VARIABLE QUE AL COMIENZO
respuesta = Console.ReadLine();
}

if (respuesta.ToUpper()== "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}

else{
    Console.WriteLine("Opción no valida");
}



