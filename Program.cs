using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    class operacion
    {
        //declaracion de variables que usa la clase
        //tipo de acceso        tipo de dato          nombre de dato
       
        protected               float                     valor1;
        protected               float                      valor2;
        protected               float                     resultado;


     
        //comentsario desde web

        //metodos o funciones de operacion
        

        public float Valor1 //CAJA DE MEMORIA 1
        {
            get { return valor1; } //vamos por el valor de la caja de texto

            set { valor1 = value; } //lo guardamos en memoria 
        }

        public float Valor2 //CAJA DE MEMORIA 2
        {
            get { return valor2; } //vamos por el valor de la caja de texto

            set { valor2 = value; } //lo guardamos en memoria 
        }

        public float Resultado //CAJA DE MEMORIA 1
        {
            get { return resultado; } //vamos por el valor de la caja de texto

            set { resultado = value; } //lo guardamos en memoria 
        }

    }

    //creamos nuestras clases hijos que usaran los metodos de crear dato
    
    class Sumar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y métodos pueden tener variables 
        //de uso solamente para la clase hijo
        //declarar variables de esta clase 
        //atributos de esta clase 
        //metodos de clase 

        public float operar(float v1, float v2)
        {
            valor1 = v1; //accedemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }

    class Restar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y métodos pueden tener variables 
        //de uso solamente para la clase hijo
        //declarar variables de esta clase 
        //atributos de esta clase 
        //metodos de clase 

        public float operar(float v1, float v2)
        {
            valor1 = v1; //accedemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }

    class Multiplicar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y métodos pueden tener variables 
        //de uso solamente para la clase hijo
        //declarar variables de esta clase 
        //atributos de esta clase 
        //metodos de clase 

        public float operar(float v1, float v2)
        {
            valor1 = v1; //accedemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }

    class Division : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y métodos pueden tener variables 
        //de uso solamente para la clase hijo
        //declarar variables de esta clase 
        //atributos de esta clase 
        //metodos de clase 

        public float operar(float v1, float v2)
        {
            valor1 = v1; //accedemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 / valor2;
        }
    }
    //esto es un comentario nuevo 26 de abril
    //esto es un segunod comentario nuevo 26 de abril
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
