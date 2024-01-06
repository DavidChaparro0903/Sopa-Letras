// See https://aka.ms/new-console-template for more information
using SopaLetras;

PrimerPunto primer = new PrimerPunto();
String[] arreglo = new String[] { "ATFVRA", "B4KHES", "5JENTY", "T6IRF3", "ELLJ54", "24JKRT" };
String[] arreglo2 = new String[] { "ATFVR", "B4KHES", "5JENTY", "T6IRF3", "ELLJ54", "24JKRT" };
String[] arreglo3 = new String[] { "123", "456", "789"};
/*Horizontal*/
/**
primer.contieneNombre(arreglo, "ATFVRA");
primer.contieneNombre(arreglo, "5JENTY");
primer.contieneNombre(arreglo, "ELLJ54");
primer.contieneNombre(arreglo, "XYZ123");
primer.contieneNombre(arreglo, "B4KHT");
primer.contieneNombre(arreglo, "");
primer.contieneNombre(arreglo, "t");**/

/*Vertical*/
/**
primer.contieneNombre(arreglo, "aB5TE2");
primer.contieneNombre(arreglo, "5JENTY");
primer.contieneNombre(arreglo, "ELLJ54");
primer.contieneNombre(arreglo, "XYZ123");
primer.contieneNombre(arreglo, "t");
primer.contieneNombre(arreglo, "");**/

/*Diagonal descendente principal*/
/* 
primer.contieneNombre(arreglo, "BJI");
primer.contieneNombre(arreglo, "R5T");
primer.contieneNombre(arreglo, "R5T4");
primer.contieneNombre(arreglo, "6l");
primer.contieneNombre(arreglo, "er5");
primer.contieneNombre(arreglo, "t");
primer.contieneNombre(arreglo, "");*/
/*Diagonal descendente secundaria*/
/*
primer.contieneNombre(arreglo, "aEnIL2");
primer.contieneNombre(arreglo, "TB");
primer.contieneNombre(arreglo, "VKJT");
primer.contieneNombre(arreglo, "6l");
primer.contieneNombre(arreglo, "il2");
primer.contieneNombre(arreglo, "t");
primer.contieneNombre(arreglo, "");
primer.contieneNombre(arreglo, "kj");
primer.contieneNombre(arreglo, "eni");
primer.contieneNombre(arreglo, "x");
primer.contieneNombre(arreglo, "5k7");*/
/*Diagonal ascendente principal*/
//Console.WriteLine(primer.contieneNombre(arreglo, "lINeA"));
/*Diagonal ascendente secundaria*/
//Console.WriteLine(primer.contieneNombre(arreglo, "5Re"));
//Console.WriteLine(primer.contieneNombre(arreglo, "ATFVRA"));
//primer.contieneNombre(arreglo, "5JENTY");
//primer.contieneNombre(arreglo, "ELLJ54");
//primer.contieneNombre(arreglo, "XYZ123");
//primer.contieneNombre(arreglo, "B4KHT");
//primer.contieneNombre(arreglo, "");

//Horizontal
/*
Console.WriteLine(primer.contieneNombre(arreglo, "JeN")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "EllJ54")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "krt")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "*")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "IRT34")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "4jKP")); //falso*/

//Vertical
/*
Console.WriteLine(primer.contieneNombre(arreglo, "ab5te2")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "Kei")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "34T")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "5Y345")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "KEIL3")); //falso
*/

/*Diagonal secundaria descendente*/

/*
Console.WriteLine(primer.contieneNombre(arreglo, "4eR5t")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "er5")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "t3")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "56")); //VERDADEA
Console.WriteLine(primer.contieneNombre(arreglo, "6LK3")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "KnT")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "jijo")); //falso*/


/*Diagonal secundaria descendente*/

/**
Console.WriteLine(primer.contieneNombre(arreglo, "4eR5t")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "er5")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "t3")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "56")); //VERDADEA
Console.WriteLine(primer.contieneNombre(arreglo, "6LK3")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "KnT")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "jijo")); //falso
**/



/*Diagonal ASCENDENTE principal*/


/*
Console.WriteLine(primer.contieneNombre(arreglo, "LiNeA")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "jfy")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "6ehr")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "4f")); //VERDADEA
Console.WriteLine(primer.contieneNombre(arreglo, "LINEAS")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "jfye")); //falso
Console.WriteLine(primer.contieneNombre(arreglo, "GEHRA")); //falso
*/


//Validacion Secundaria


/*
Console.WriteLine(primer.contieneNombre(arreglo3, "123")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo3, "147")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo3, "753")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo3, "951")); //VERDADEA
Console.WriteLine(primer.contieneNombre(arreglo3, "51")); //VERDADEA
Console.WriteLine(primer.contieneNombre(arreglo3, "15")); //VERDADEA
Console.WriteLine(primer.contieneNombre(arreglo3, "353")); //falso
Console.WriteLine(primer.contieneNombre(arreglo3, "7")); //VERDADERO
Console.WriteLine(primer.contieneNombre(arreglo3, "852")); //verdadero
Console.WriteLine(primer.contieneNombre(arreglo3, "321")); //VERDADERO
*/
//Validacion Horizontal hacia atras

/*

Console.WriteLine(primer.contieneNombre(arreglo, "Rvf")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "I6")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "lle")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "42")); //VERDADERA
Console.WriteLine(primer.contieneNombre(arreglo, "423")); //FALSO
Console.WriteLine(primer.contieneNombre(arreglo, "jllet")); //FALSO
Console.WriteLine(primer.contieneNombre(arreglo, "ej56")); //FALSO
*/


//Validacion vertical hacia arriba



/*

Console.WriteLine(primer.contieneNombre(arreglo, "KJRNHV")); //VERDADERO
Console.WriteLine(primer.contieneNombre(arreglo, "j4T")); //VERDADERO
Console.WriteLine(primer.contieneNombre(arreglo, "5BA")); //VERDADERO
Console.WriteLine(primer.contieneNombre(arreglo, "YSA")); //VERDADERO
Console.WriteLine(primer.contieneNombre(arreglo, "43")); //VERDADERO
Console.WriteLine(primer.contieneNombre(arreglo, "5BAT")); //FALSO
Console.WriteLine(primer.contieneNombre(arreglo, "KTL")); //FALSO
Console.WriteLine(primer.contieneNombre(arreglo, "YSA3")); //FALSO

*/