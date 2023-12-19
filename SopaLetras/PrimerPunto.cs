using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SopaLetras
{
    internal class PrimerPunto
    {
        public PrimerPunto() {


        } 

        public bool tieneLaMismaLongitud(string[] info)
        {
            if(info != null && info.Length > 0)
            {
                int longitudInicial = info[0].Length;
                foreach (string cadena in info)
                {
                    if (cadena.Length != longitudInicial)
                    {
                        return false; // Se encontró una cadena con longitud diferente
                    }
                }

                return true;
            }
            else
            {
                return false;
            }

        }


        public bool contieneNombre(string[] info, string nombre)
        {

            if (tieneLaMismaLongitud(info))
            {
                char[,] matriz = rellenarMatriz(info);
                imprimirMatriz(matriz);
                /*
                if (validarHorizontal(matriz, nombre) || validarVertical(matriz, nombre) || validarDiagonalAscendente(matriz, nombre) || validarDiagonalDescendente(matriz, nombre))
                {
                    return true;
                }*/
                // Console.WriteLine(":..........................." + );
                //  Console.WriteLine(":..........................." + validarVertical(matriz, nombre));
                //Console.WriteLine(":..........................."+ validarDiagonalAscendente(matriz, nombre));
                // Console.WriteLine(":..........................." + validarDiagonalDescendente(matriz, nombre));
                //Console.WriteLine(":..........................." + validarDiagonalAscendentePrincipal(matriz, nombre));

                // Console.WriteLine(":..........................." + validarDiagonalAscendenteSecundaria(matriz, nombre));
                  if (   validarHorizontal(matriz, nombre) 
                      || validarVertical(matriz, nombre) 
                      || validarDiagonalDescendentePrincipal(matriz, nombre)
                      || validarDiagonalDescendenteSecundaria(matriz, nombre)
                      || validarDiagonalAscendentePrincipal(matriz, nombre)
                      || validarDiagonalAscendenteSecundaria(matriz, nombre)
                      || validarHorizontalAtras(matriz, nombre)
                      || validarVerticalArriba(matriz, nombre))
                  {
                      return true;
                  }
                return false;
            }
            return false;       
        }


        public char[,] rellenarMatriz(string[] filas)
        
        {

            char[,] matrix = new char[filas.Length, filas[0].Length];

             for (int i = 0; i < filas.Length; i++)
             {

                    for (int j = 0; j < filas[0].Length; j++)
                    {
                  
                    matrix[i, j] = filas[i][j];
                    }
             }

             return matrix;

         }


        public void imprimirMatriz(char[,] matriz)
        {


            //Numero de columnas
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                //Numero de filas
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write("[ " + matriz[i, j] + " ]");
                }
                Console.WriteLine();
            }
        }

        public bool validarHorizontal(char[,] matriz, string nombre)
        {
            try
            {
                char primerValor = nombre[0];
                string result = "";
                int count = 0;
                //Numero de columnas
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    //Numero de filas
                    for (int j = 0; j < matriz.GetLength(0); j++)
                    {
                       // Console.WriteLine("*****" + matriz[i, j]);
                        if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[i, j]))
                        {
                            result += primerValor;
                            //Console.WriteLine("---------" + result);
                            if (validarPalabra(result, nombre))
                            {
                                return true;
                            }
                            count++;
                            primerValor = nombre[count];

                        }
                        else
                        {
                            primerValor = nombre[0];
                            result = "";
                            count = 0;

                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
           

        }


        public bool validarHorizontalAtras(char[,] matriz, string nombre)
        {
            try
            {
                char primerValor = nombre[0];
                string result = "";
                int count = 0;
                //Numero de columnas
                for (int i = matriz.GetLength(1) - 1; i >= 0; i--)
                {
                    //Numero de filas
                    for (int j = matriz.GetLength(0) - 1; j >= 0; j--)
                    {
                        //Console.WriteLine("*****" + matriz[i, j]);
                        if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[i, j]))
                        {
                            result += primerValor;
                           // Console.WriteLine("---------" + result);
                            if (validarPalabra(result, nombre))
                            {
                                return true;
                            }
                            count++;
                            primerValor = nombre[count];

                        }
                        else
                        {
                            primerValor = nombre[0];
                            result = "";
                            count = 0;

                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }


        }


        public bool validarVertical(char[,] matriz, string nombre)
        {
            try
            {
                char primerValor = nombre[0];
                string result = "";
                int count = 0;
                //Numero de filas
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    //Numero de columnas
                    for (int j = 0; j < matriz.GetLength(1); j++)

                    {
                        //Console.WriteLine("*****" + matriz[j, i]);
                        if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[j, i]))
                        {
                            result += primerValor;
                            //Console.WriteLine("---------" + result);
                            if (validarPalabra(result, nombre))
                            {
                                return true;
                            }
                            count++;
                            primerValor = nombre[count];

                        }
                        else
                        {
                            primerValor = nombre[0];
                            result = "";
                            count = 0;

                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }


        }



        public bool validarVerticalArriba(char[,] matriz, string nombre)
        {
            try
            {
                char primerValor = nombre[0];
                string result = "";
                int count = 0;
                //Numero de filas
                for (int i = matriz.GetLength(1) - 1; i >= 0; i--)
                {
                    //Numero de columnas
                    for (int j = matriz.GetLength(0) - 1; j >= 0; j--)

                    {
                        if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[j, i]))
                        {
                            result += primerValor;
                            if (validarPalabra(result, nombre))
                            {
                                return true;
                            }
                            count++;
                            primerValor = nombre[count];

                        }
                        else
                        {
                            primerValor = nombre[0];
                            result = "";
                            count = 0;

                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }


        }


        public bool validarDiagonalDescendentePrincipal(char[,] matriz, string nombre)
        {

            try
            {
                char primerValor = nombre[0];
                string result = "";
                //Numero de filas
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    //Numero de columnas
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[i, j]))
                        {
                           // Console.WriteLine("*****" + matriz[i, j]);
                            //Console.WriteLine("FILA: " + i);
                            //Console.WriteLine("columna: " + j);
                            result += primerValor;
                            if (validarPalabra(result, nombre))
                            {
                                return true;
                            }
                            if (esValidaPalabraDiagonalDescendentePrincipal(matriz, nombre, i, j, result))
                            {
                                return true;
                            }

                        }
                        else
                        {
                            primerValor = nombre[0];
                            result = "";
                        }
                    }
                }
                return false;



            }
            catch (Exception)
            {
                return false;
            }

        }


        public bool esValidaPalabraDiagonalDescendentePrincipal(char[,] matriz, string nombre,int indiceFila,int indiceColumna,string result)
        {

           // Console.WriteLine("Entro a metodo de validacion");

            int count = 1; // Contador para validar la longitud maxima de la palabra
            indiceFila++; // empezamos con una fila mas 1
            indiceColumna++; // empezamos con una columna 3
            char primerValor = nombre[1]; // H
            //Console.WriteLine("FILA dentro metodo: " + indiceFila);
            //Console.WriteLine("columna dentro metodo: " + indiceColumna);
            
            while (count < nombre.Length && (indiceFila < matriz.GetLength(0) && indiceColumna < matriz.GetLength(1)))
            {
               // Console.WriteLine("Longitud " + nombre.Length);
               // Console.WriteLine("Contador " + count);
               // Console.WriteLine("FILA dentro del while: " + indiceFila);
                //Console.WriteLine("columna dentro del while: " + indiceColumna);
                //Console.WriteLine("---------" + result);
                //Console.WriteLine("Primer valor: " + primerValor);
                //Console.WriteLine("valor recuperado: " + matriz[indiceFila, indiceColumna]);
                if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[indiceFila, indiceColumna])){
                    //Console.WriteLine("Entro a la condicion");
                    result += primerValor;
                    count++;
                    if (validarPalabra(result, nombre))
                    {
                        return true;
                    }
                 
 
                    primerValor = nombre[count];
                    indiceFila++; //le suma uno a la fila
                    indiceColumna++; // le suma uno a la columna
                   // Console.WriteLine("valor de resultado dentro de la condicion del metodo :" + result);
                    //Console.WriteLine("valor de la matriz dentro de la condicion : " + matriz[indiceFila, indiceColumna]);
                }
                else
                {
                   // Console.WriteLine("ENTRA A FALSOOO");
                    return false;
                }

            }           
            return false;
        }


        public bool validarDiagonalDescendenteSecundaria(char[,] matriz, string nombre)
        {

            try
            {
                char primerValor = nombre[0];
                string result = "";
                //Numero de filas
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    //Numero de columnas
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[i, j]))
                        {
                            /*
                            Console.WriteLine("*****" + matriz[i, j]);
                            Console.WriteLine("FILA: " + i);
                            Console.WriteLine("columna: " + j);*/
                            result += primerValor;
                            if (validarPalabra(result, nombre))
                            {
                                return true;
                            }
                            if (esValidaPalabraDiagonalDescendenteSecundaria(matriz, nombre, i, j, result))
                            {
                                return true;
                            }

                        }
                        else
                        {
                            primerValor = nombre[0];
                            result = "";
                        }
                    }
                }
                return false;



            }
            catch (Exception)
            {
                return false;
            }

        }


        public bool esValidaPalabraDiagonalDescendenteSecundaria(char[,] matriz, string nombre, int indiceFila, int indiceColumna, string result)
        {

            //Console.WriteLine("Entro a metodo de validacion");
            int count = 1; // Contador para validar la longitud maxima de la palabra
            indiceFila++; // empezamos con una fila mas 1
            indiceColumna--; // empezamos con una columna 3
            char primerValor = nombre[1]; // H
            //Console.WriteLine("FILA dentro metodo: " + indiceFila);
            //Console.WriteLine("columna dentro metodo: " + indiceColumna);

            while (count < nombre.Length && (indiceFila <  matriz.GetLength(0) && indiceColumna >= 0))
            {
               /* Console.WriteLine("Longitud " + nombre.Length);
                Console.WriteLine("Contador " + count);
                Console.WriteLine("FILA dentro del while: " + indiceFila);
                Console.WriteLine("columna dentro del while: " + indiceColumna);
                Console.WriteLine("---------" + result);
                Console.WriteLine("Primer valor: " + primerValor);
                Console.WriteLine("valor recuperado: " + matriz[indiceFila, indiceColumna]);*/
                if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[indiceFila, indiceColumna]))
                {
                    //Console.WriteLine("Entro a la condicion");
                    result += primerValor;
                    count++;
                    if (validarPalabra(result, nombre))
                    {
                        return true;
                    }

                    primerValor = nombre[count];
                    indiceFila++; //le suma uno a la fila
                    indiceColumna--; // le resto uno a la columna
                   // Console.WriteLine("valor de resultado dentro de la condicion del metodo :" + result);
                    //Console.WriteLine("valor de la matriz dentro de la condicion : " + matriz[indiceFila, indiceColumna]);
                }
                else
                {
                   // Console.WriteLine("ENTRA A FALSOOO");
                    return false;
                }

            }
            return false;
        }



        public bool validarDiagonalAscendentePrincipal(char[,] matriz, string nombre)
        {

            try
            {
                char primerValor = nombre[0];
                string result = "";
                //Numero de filas
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    //Numero de columnas
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[i, j]))
                        {
                            /*
                            Console.WriteLine("*****" + matriz[i, j]);
                            Console.WriteLine("FILA: " + i);
                            Console.WriteLine("columna: " + j);*/
                            result += primerValor;
                            if (validarPalabra(result, nombre))
                            {
                                return true;
                            }
                            if (esValidaPalabraDiagonalAscendentePrincipal(matriz, nombre, i, j, result))
                            {
                                return true;
                            }

                        }
                        else
                        {
                            primerValor = nombre[0];
                            result = "";
                        }
                    }
                }
                return false;



            }
            catch (Exception)
            {
                return false;
            }

        }


        public bool esValidaPalabraDiagonalAscendentePrincipal(char[,] matriz, string nombre, int indiceFila, int indiceColumna, string result)
        {

            //Console.WriteLine("Entro a metodo de validacion");
            int count = 1; // Contador para validar la longitud maxima de la palabra
            indiceFila--; // empezamos con una fila mas 1
            indiceColumna++; // empezamos con una columna 3
            char primerValor = nombre[1]; // H
            /*
            Console.WriteLine("FILA dentro metodo: " + indiceFila);
            Console.WriteLine("columna dentro metodo: " + indiceColumna);*/

            while (count < nombre.Length && (indiceFila >= 0) && indiceColumna < matriz.GetLength(1))
            {
                /*
                Console.WriteLine("Longitud " + nombre.Length);
                 Console.WriteLine("Contador " + count);
                 Console.WriteLine("FILA dentro del while: " + indiceFila);
                 Console.WriteLine("columna dentro del while: " + indiceColumna);
                 Console.WriteLine("---------" + result);
                 Console.WriteLine("Primer valor: " + primerValor);
                 Console.WriteLine("valor recuperado: " + matriz[indiceFila, indiceColumna]);*/
                if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[indiceFila, indiceColumna]))
                {
                    //Console.WriteLine("Entro a la condicion");
                    result += primerValor;
                    count++;
                    if (validarPalabra(result, nombre))
                    {
                        return true;
                    }

                    primerValor = nombre[count];
                    indiceFila--; //le suma uno a la fila
                    indiceColumna++; // le resto uno a la columna
                    /*
                    Console.WriteLine("valor de resultado dentro de la condicion del metodo :" + result);
                    Console.WriteLine("valor de la matriz dentro de la condicion : " + matriz[indiceFila, indiceColumna]);*/
                }
                else
                {
                   // Console.WriteLine("ENTRA A FALSOOO");
                    return false;
                }

            }
            return false;
        }





        public bool validarDiagonalAscendenteSecundaria(char[,] matriz, string nombre)
        {

            try
            {
                char primerValor = nombre[0];
                string result = "";
                //Numero de filas
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    //Numero de columnas
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[i, j]))
                        {
                            /*
                            Console.WriteLine("*****" + matriz[i, j]);
                            Console.WriteLine("FILA: " + i);
                            Console.WriteLine("columna: " + j);*/
                            result += primerValor;
                            if (validarPalabra(result, nombre))
                            {
                                return true;
                            }
                            if (esValidaPalabraDiagonalAscendenteSecundaria(matriz, nombre, i, j, result))
                            {
                                return true;
                            }

                        }
                        else
                        {
                            primerValor = nombre[0];
                            result = "";
                        }
                    }
                }
                return false;



            }
            catch (Exception)
            {
                return false;
            }

        }


        public bool esValidaPalabraDiagonalAscendenteSecundaria(char[,] matriz, string nombre, int indiceFila, int indiceColumna, string result)
        {

           // Console.WriteLine("Entro a metodo de validacion");
            int count = 1; // Contador para validar la longitud maxima de la palabra
            indiceFila--; // empezamos con una fila mas 1
            indiceColumna--; // empezamos con una columna 3
            char primerValor = nombre[1]; // H

            /*
            Console.WriteLine("FILA dentro metodo: " + indiceFila);
            Console.WriteLine("columna dentro metodo: " + indiceColumna);*/

            while (count < nombre.Length && (indiceFila >= 0) && indiceColumna >= 0)
            {
                /*
                Console.WriteLine("Longitud " + nombre.Length);
                Console.WriteLine("Contador " + count);
                Console.WriteLine("FILA dentro del while: " + indiceFila);
                Console.WriteLine("columna dentro del while: " + indiceColumna);
                Console.WriteLine("---------" + result);
                Console.WriteLine("Primer valor: " + primerValor);
                Console.WriteLine("valor recuperado: " + matriz[indiceFila, indiceColumna]);*/
                if (Char.ToUpper(primerValor) == Char.ToUpper(matriz[indiceFila, indiceColumna]))
                {
                    //Console.WriteLine("Entro a la condicion");
                    result += primerValor;
                    count++;
                    if (validarPalabra(result, nombre))
                    {
                        return true;
                    }

                    primerValor = nombre[count];
                    indiceFila--; //le suma uno a la fila
                    indiceColumna--; // le resto uno a la columna
                    /*
                    Console.WriteLine("valor de resultado dentro de la condicion del metodo :" + result);
                    Console.WriteLine("valor de la matriz dentro de la condicion : " + matriz[indiceFila, indiceColumna]);*/
                }
                else
                {
                    //Console.WriteLine("ENTRA A FALSOOO");
                    return false;
                }

            }
            return false;
        }



        public bool validarPalabra(string result, string nombre)
            
        {
            return result.Equals(nombre);
        }



    }
}
