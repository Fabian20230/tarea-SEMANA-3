//// CALCULAR EL MAYOR DE TRES NUMEROS

//try { 
//int num1, num2, num3, resultado;


//    Console.WriteLine("INGRESE EL PRIMER NUMERO");
//    num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
//    num2 = int.Parse(Console.ReadLine());

//    Console.WriteLine("INGRESE EL TERCER NUMERO");
//    num3 = int.Parse(Console.ReadLine());

//    resultado = num1;

//    if (resultado < num2)
//    {
//        resultado = num2;
//    }
//    else if (num3 > resultado)
//    {
//        resultado = num3;
//    }
//    Console.WriteLine($"El numero mayor es: {resultado}");
//}
//catch (Exception exe)
//{
//    Console.WriteLine("Escriba bien el formato >:(");

//}















////VALIDAR SI ES MAYOR O IGUAL A 18 AÑOS

//try
//{
//    Console.WriteLine("INGRESE SU EDAD");
//    byte edad = byte.Parse(Console.ReadLine()); // Dispuse del byte debido a que acepta numeros negativos.
//    if (edad > 18)
//    {
//        Console.WriteLine("Puede entrar :)");
//    }
//    else if (edad < 18)
//    {
//        Console.WriteLine("No puedes entrar jaja");
//    }
//    else
//    {
//        Console.WriteLine("Apenas puedes entrar felicidades!!!");
//    }

//}
//catch (Exception ex)
//{
//    Console.WriteLine("Error se debe poner una edad!!!!!!");
//}


















////Calcular el Precio Final de un Producto:

//try
//{
//    Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO:");
//    decimal precio = decimal.Parse(Console.ReadLine());

//    if (precio > 100)
//    {
//        precio = precio / 0.9m;
//        Console.WriteLine($"EL PRECIO DEL PRODUCTO ES DE {precio}");
//    }
//    else
//    {
//        Console.WriteLine($"EL PRECIO DEL PRODUCTO ES DE {precio}");

//    }
//}
//catch (Exception x)
//{
//    Console.WriteLine($"ERROR, CAUSA: {x.Message}");
//}

















////Validar Usuario y Contraseña:

//try
//{
//    string contraseña = "LELELA";
//    string usuario = "PROGRAMACION";



//    Console.WriteLine("INGRESE EL USUARIO");
//    string a = Console.ReadLine();

//    Console.WriteLine("INGRESE LA CONTRASEÑA");
//    string b = Console.ReadLine();

//    bool f = (a == usuario) && (b == contraseña);

//    if (f)
//    {
//        Console.WriteLine("FELICIDADES ACABAS DE ENTRAR :)");
//    }
//    else
//    {
//        Console.WriteLine("Usuario o Contraseña incorrecos");
//    }
//}catch (Exception xe)
//{
//    Console.WriteLine(xe.Message);
//}

















////Determinar si un Número es Par o Impar:

//try
//{
//    Console.WriteLine("INGRESE UN NUMERO");
//    byte q = byte.Parse(Console.ReadLine());

//    if (q % 2 == 0)
//    {
//        Console.WriteLine("EL NUMERO ES PAR");

//    }
//    else
//    {
//        Console.WriteLine("EL NUMERO ES IMPAR");
//    }
//}catch (Exception exxe)
//{
//    Console.WriteLine("ERROR DE FORMATO");

//}



















////Mostrar un Mensaje de Aprobación o Rechazo de Préstamo:


//try
//{

//    Console.WriteLine("INGRESE SU EDAD:");
//    int edad = int.Parse(Console.ReadLine());

//    Console.WriteLine("INGRESE EL MONTO QUE DESEA PRESTAR:");
//    int prestamo = int.Parse(Console.ReadLine());

//    if ((edad > 60) || (prestamo < 5000))
//    {
//        Console.WriteLine("FELICIDADES, ACABAS DE RECIBIR TU PRESTAMO EXITOSAMENTE");
//    }
//    else
//    {
//        Console.WriteLine("LO SENTIMOS, NO FUE APROBADO TU PRESTAMO");

//    }
//}
//catch(Exception eeee)
//{
//    Console.WriteLine("DEBES DE CORREGIR TUS DATOS");

//}


















////Calcular el Área de una Figura Geométrica:
//try
//{
//    Console.WriteLine("¿QUE FIGURA DESEA CALCULAR EL AREA?");
//    Console.WriteLine("¿TRIANGULO,CUADRADO O CIRCULO?");
//    string figura = Console.ReadLine().ToUpper();

//    if (figura == "TRIANGULO")
//    {
//        Console.WriteLine("INGRESE SUS DIMENSIONES POR APARTE");
//        Console.WriteLine("INGRESE SU BASE");
//        double a = double.Parse(Console.ReadLine());

//        Console.WriteLine("INGRESE SU ALTURA");
//        double b = double.Parse(Console.ReadLine());
//        double c;

//        c = (a * b) / 2;
//        Console.WriteLine($"El area del triangulo es: {c}");
//    }
//    else if (figura == "CUADRADO")
//    {
//        Console.WriteLine("INGRESE SU BASE");
//        double a = double.Parse(Console.ReadLine());
//        double c;

//        c = a * a;
//        Console.WriteLine($"El area del cuadrado es: {c}");

//    }
//    else if (figura == "CIRCULO")
//    {
//        Console.WriteLine("INGRESE SU RADIO");
//        double a = double.Parse(Console.ReadLine());
//        double b;

//        b = (a * a) * Math.PI;
//        Console.WriteLine($"El area del circulo es: {b}");

//    }
//    else
//    {
//        Console.WriteLine("No se reconoce lo que desea");
//    }



//}catch(Exception eex)
//{
//    Console.WriteLine(eex.Message);

//}


















////Convertir un Número de Letra a Número:

//try
//{
//    Console.WriteLine("INTRODUZCA UN NUMERO DEL 1 AL 5 EN LETRAS");
//    string letra = Console.ReadLine().ToLower();

//    int numero;
//    switch (letra)
//    {
//        case "uno":
//            numero = 1;
//            break;
//        case "dos":
//            numero = 2;
//            break;
//        case "tres":
//            numero = 3;
//            break;
//        case "cuatro":
//            numero = 4;
//            break;
//        case "cinco":
//            numero = 5;
//            break;
//        default:
//            Console.WriteLine("NUMERO NO VALIDO");
//            return;
//    }

//    Console.WriteLine($"El numero en digito de {letra} es: {numero}");

//}catch(Exception exxxx)
//{
//    Console.WriteLine("ERROR AAAAAAAAAA");
//}

















////Mostrar el Día de la Semana a partir de un Número:


//try
//{
//    Console.WriteLine("Ingrese un numero del 1 al 7 para revelar el dia al que pertenece");
//    int numero = int.Parse(Console.ReadLine());

//    string letra;

//    switch (numero)
//    {
//        case 1:
//            letra = "Lunes";
//            break;
//        case 2:
//            letra = "Martes";
//            break;
//        case 3:
//            letra = "Miércoles";
//            break;
//        case 4:
//            letra = "Jueves";
//            break;
//        case 5:
//            letra = "Viernes";
//            break;
//        case 6:
//            letra = "Sabado";
//            break;
//        case 7:
//            letra = "Domingo";
//            break;
//        default:
//            Console.WriteLine("Numero no vaido en el rango");
//            return;
//    }

//    Console.WriteLine($"El dia que le corresponde al numero {numero} es: {letra}.");
//}catch(Exception exeex)
//{
//    Console.WriteLine("NO SE PERMITEN LETRAS");
//}

















////Calcular el Importe a Pagar por un Servicio:


//try
//{

//    string a;


//    Console.WriteLine("Que servicio requiere?");
//    Console.WriteLine("Lavado, cambio de aceite o revison mecanica");
//    a = Console.ReadLine().ToLower();

//    int importe;

//    switch (a)
//    {
//        case "lavado":
//            importe = 20;
//            break;
//        case "cambio de aceite":
//            importe = 125;
//            break;
//        case "revision mecanica":
//            importe = 200;
//            break;
//        case "lavado y cambio de aceite":
//            importe = 140;
//            break;
//        case "cambio de aceite y lavado":
//            importe = 140;
//            break;
//        case "revision mecanica y lavado":
//            importe = 210;
//            break;
//        case "lavado y revision mecanica":
//            importe = 210;
//            break;
//        case "revision mecanica y cambio de aceite":
//            importe = 300;
//            break;
//        case "cambio de aceite y revision mecanica":
//            importe = 300;
//            break;
//        case "lavado, cambio de aceite y revision mecanica":
//            importe = 310;
//            break;
//        case "cambio de aceite, lavado y revision mecanica":
//            importe = 310;
//            break;
//        case "lavado, revision mecanica y cambio de aceite ":
//            importe = 310;
//            break;
//        case "cambio de aceite, revision mecanica y lavado":
//            importe = 310;
//            break;
//        case "revision mecanica, lavado y cambio de aceite":
//            importe = 310;
//            break;
//        case "revision mecanica, cambio de aceite y lavado":
//            importe = 310;
//            break;
//        default:
//            Console.WriteLine("No existe este servicio");
//            return;
//    }

//    Console.WriteLine($"El importe a pagar es de: {importe}");
//}catch(Exception exxxex)
//{
//    Console.WriteLine(exxxex.Message );
//}


















////Mostrar un Mensaje de Bienvenida en Diferentes Idiomas:

//Console.WriteLine("Ingrese el idioma de su preferencia para su bienvenida");
//Console.WriteLine("Opcion 1: Idioma Ingles");
//Console.WriteLine("Opcion 2: Idioma Español");
//Console.WriteLine("Opcion 3: Idioma Frances");
//Console.WriteLine("Opcion 4: Idioma Japones(Romanji)");
//Console.WriteLine("Opcion 5: Idioma Español(Latam)");
//int opcion = int.Parse(Console.ReadLine());

//string idioma;
//switch (opcion)
//{
//    case 1:
//        idioma = "Hello, welcome to the task I have completed";
//        break;
//    case 2:
//        idioma = "Hola, bienvenido a la tarea que tengo realizada";
//        break;
//    case 3:
//        idioma = "Bonjour, bienvenue dans la tâche que j'ai terminée";
//        break;
//    case 4:
//        idioma = "Kon'nichiwa, kanryō shita tasuku e yōkoso";
//        break;
//    case 5:
//        idioma = "Que tal, bienvenido a la tarea, espero esto termine pronto";
//        break;
//    default:
//        Console.WriteLine("Opcion desconocida, ¡QUE HACESSS!!!");
//        return;
//}

//Console.WriteLine(idioma);


















////Evaluar la Calificación de un Examen:

Console.WriteLine("INGRESE LA CALIFICACION DEL ALUMNO");
double calificacion= double.Parse(Console.ReadLine());
double reondeo = Math.Round(calificacion);  
string mensaje;

switch (reondeo)
    {
    case >= 0 and <= 30.99:
        mensaje = "Muy baja calificacion REPROBADO";
        break;
    case >= 31 and <= 50.99:
        mensaje = "Debemos mejorar mucho REPROBADO";
        break;
    case >= 51 and <= 59.99:
        mensaje = "Insuficiente REPROBADO";
        break;
    case >= 60 and <= 79.99:
        mensaje = "APROBADO";
        break;
    case >= 80 and <= 95.99:
        mensaje = "Muy buena calificacion APROBADO";
        break;
    case >= 96 and <= 100:
        mensaje = "Exelente calificacion APROBADO";
        break;
    default:
        Console.WriteLine("Calificacion mal colocada");
        return;
}
Console.WriteLine($"{mensaje} con: {reondeo}");



