using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_uno
{
    class Practica
    {
        public void EscribiPrimeraIngreso() {
            Console.WriteLine("Ingresar nombre: ");
            String ingreso = Console.ReadLine();
            Console.WriteLine("Hola " + ingreso);
        }

        public void CalcularFactorial() {
            Console.WriteLine("Ingresar un numero para cacular el factorial: ");
            int numero = Int32.Parse(Console.ReadLine());
            if (numero == 0 || numero == 1)
            {
                Console.WriteLine(1);
            }
            else {
                int factorial = 1;
                for (int i = 1; i <= numero; i++) {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
        }

        public long LeerPorConsola() {
            Console.WriteLine("Ingresar un numero: ");
            return long.Parse(Console.ReadLine());
        }
        public void NumeroPar(int numero) {
            if (numero % 2 == 0) {
                Console.WriteLine("Numero par");
            }
            else
            {
                Console.WriteLine("Numero impar");
            }
        }

        public void SumaDeLosDigitos(long numero) {
            long resultado = numero;
            int contador = 0;
            while (resultado != 0) {
                resultado -= resultado % 10;
                resultado /= 10;
                contador++;
            }

            for (int i = 0; i <= contador; i++) {
                resultado += numero % 10;
                numero -= numero % 10;
                numero /= 10;
            }

            Console.WriteLine(resultado);
        }

        public void NumerosAPromediar() {
            String numero="";
            double[] arreglo = new double[500];
            double[] devolucion = new double[2];
            int i = 0;
            Console.WriteLine("Ingresar numeros para promediar y luego 'c' para terminar");
            while (!numero.Equals("c")) { 
                numero = Console.ReadLine();
                
                i++;
                if (!numero.Equals("c")) {
                    arreglo[i] = double.Parse(numero);
                }
                
            }

            PromedioDeNumeros(arreglo, i);
            
            
        }

        public void PromedioDeNumeros(double[] numeros, int cont) {
            double resultado = 0;
            int i = 0;
            
            
            while (i != cont){ 

                
                resultado += numeros[i];
                i++;

            }

            Console.WriteLine("Promedio: " + resultado / (i-1));
        }

        public void IntroducirNumerosEnArreglo() {
            int[] arreglo = new int[50];
            Console.WriteLine("Ingresar numeros positivos para ordenar. Ingresar un negativo para finalizar.");
            int i = 0;
            do{
                arreglo[i] = int.Parse(Console.ReadLine());
                i++;
            }while (arreglo[i-1] >= 0);

            ImprimirArreglo(OrdenarArreglo(arreglo));
            
            
        }

        public int[] OrdenarArreglo(int [] arreglo)
        {
            int auxiliar;
            int ordenado = 1;
            while (ordenado != 0) {
                ordenado = 0;
                for (int i = 0; arreglo[i+1] >= 0; i++) {
                    if (arreglo[i] > arreglo[i+1]) {
                        auxiliar = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = auxiliar;
                        ordenado++;
                    }
                }
            }
            return arreglo;
        }

        public void ImprimirArreglo(int [] arreglo) {
            int i = 0;
            while (arreglo[i] >= 0)
            {
                //INGRESAR DE A UN CARACTER PARA LOS ESPACIOS EN BLACO INGRESAR ESPACIO
                Console.WriteLine(arreglo[i]);
                i++;
            }
            
        }

        public void ConvertirArregloDeCaracteres()
        {
            char[] arreglo = RellenarArreglo();

            Console.WriteLine("Mayusculas:");
            Console.WriteLine(ConvertirAMayusculas(arreglo));
            Console.WriteLine("Minusculas:");
            Console.WriteLine(ConvertirAMinusculas(arreglo));
            Console.WriteLine("Capital:");
            Console.WriteLine(ConvertirACapital(arreglo));



        }

        public char[] RellenarArreglo() {
            char[] arreglo = new char[100];
            Console.WriteLine("Ingresar caracteres. Ingresar un 1 para finalizar.");
            int i = 0;
            do
            {
                arreglo[i] = char.Parse(Console.ReadLine());
                i++;
            } while (arreglo[i-1] != 49);

            return arreglo;

        }

        public char[] ConvertirAMayusculas(char[] arreglo)
        {
            int i = 0;
            while(arreglo[i] != 49){
                if (arreglo[i] > 96 && arreglo[i]<123)
                {
                    arreglo[i] = (char)(arreglo[i] - 32);
                }
                i++;
            }
            return arreglo;
        }

        public char[] ConvertirAMinusculas(char[] arreglo)
        {
            int i = 0;
            while (arreglo[i] != 49)
            {
                if (arreglo[i] > 64 && arreglo[i] < 91)
                {
                    arreglo[i] = (char)(arreglo[i] + 32);
                    
                }
                i++;
            }
            return arreglo;
        }

        public char[] ConvertirACapital(char[] arreglo)
        {
            int i = 0;
            while (arreglo[i] != 49)
            {
                if (i == 0 || arreglo[i-1] == 32 && arreglo[i] > 96 && arreglo[i] < 123)
                {
                    arreglo[i] = (char)(arreglo[i] - 32);
                   
                }
                i++;
            }
            return arreglo;
        }

        public void ImprimirCadenaInvertida() {
            String cadena = Console.ReadLine();
            char primera;
            char ultima;
            String cadenaNueva ="";
            if (cadena.Length % 2 == 0) { 
                for (int i = 0; i <= (cadena.Length/2)-1; i++) {
                    primera = cadena[i];
                    ultima = cadena[(cadena.Length-1) - i];
                    if (i != 0) {
                        cadenaNueva = cadenaNueva.Substring(0, i) + ultima + primera + cadenaNueva.Substring(i, cadenaNueva.Length - i);
                    }
                    else
                    {
                        cadenaNueva = ultima + "" + primera;
                    }
                }

            }
            else
            {
                for (int i = 0; i <= (cadena.Length / 2); i++)
                {
                    primera = cadena[i];
                    ultima = cadena[(cadena.Length - 1) - i];
                    
                    if (i != 0)
                    {
                        cadenaNueva = cadenaNueva.Substring(0, i) + ultima + primera + cadenaNueva.Substring(i, cadenaNueva.Length - i);
                    }
                    else
                    {
                        cadenaNueva = ultima + "" + primera;
                    }
                    
                   
                }
            }
            Console.WriteLine(cadenaNueva);
        }


        public void IngresarCadena() {
            Console.WriteLine("Ingresar cadena, inicio de la subcadena y tamaño de la subcadena separados por coma");
            String[] datos = Console.ReadLine().Split(",");
            Console.WriteLine(DevolverSubString(int.Parse(datos[1].Trim()), int.Parse(datos[2].Trim()), datos[0].Trim()));
        }
        public String DevolverSubString(int inicio, int tamaño, String cadena) {
            String cadenaNueva="";
            if (tamaño+1 < cadena.Length) { 
                for(int i = inicio-1; i <= tamaño+1; i++){
                    cadenaNueva += cadena[i] + "";
                }
            }
            return cadenaNueva;
        }

        public void IngresarCadenaParaContarPalabras()
        {
            Console.WriteLine("Ingresar cadena para contar palabras");
            String cadena = Console.ReadLine();
            Console.WriteLine("La cadena tiene: " + (ContarPalabras(cadena)+1) + " palabras"); 
        }

        public int ContarPalabras(String cadenaRecibida) {
            int contador=0;
            String cadena = cadenaRecibida.Trim(); 
            for(int i = 0; i < cadena.Length; i++){
                if(cadena[i] == 32)
                {
                    contador++;    
                }else if (cadena[i] == 33 || cadena[i] == 34 || cadena[i] == 39
                        || cadena[i] == 40 || cadena[i] == 41 || cadena[i] == 63
                        || cadena[i] == 59 || cadena[i] == 46 || cadena[i] == 44)
                {
                    if(i != 0 && i != cadena.Length - 1)
                    {
                        if (cadena[i-1] != 32 && cadena[i+1] != 32)
                        {
                            contador++;
                        }
                    }
                }
            }
            return contador;
        }
    }
}
