/*           Nombre de la practica:PIDETEC.
            * Tema de referencia: INTERFÁZ GRÁFICA DE USUARIO
            * Objetivo de la practica:DESARROLLAR E IMPLEMENTAR UNA APLICACIÓN PARA WINDOWS FORMS,
            HACIENDO USO DEL LENGUAJE DE PROGRAMACIÓN C# Y EL IDE VISUAL STUDIO
            COMMUNITY EDITION (2015+), QUE PERMITA TOMAR ORDENES DE COMIDA EN
            LA CAFETERÍA DE UNA INSTITUCIÓN EDUCATIVA.
            * Materia:Tópicos Avanzados de Programación. 
            * Alumna:Paola Alejandra Scott Carreón.
            */
//liberias del programa
using System;
//liberias del programa
using System.Collections.Generic;
//liberias del programa
using System.ComponentModel;
//liberias del programa
using System.Data;
//liberias del programa
using System.Drawing;
//liberias del programa
using System.Linq;
//liberias del programa
using System.Text;
//liberias del programa
using System.Threading.Tasks;
//liberias del programa
using System.Windows.Forms;
//liberias del programa
using System.Collections.Generic;
//controla el alcance de los nombres de las clases y metodos
namespace PIDETEC
{    //Esta es una clase que manda llamar a un constructor
    public partial class Form1 : Form
    {   //Crear objeto global
        opciones opcion;
        //Los elementos se almacenanan 
        Dictionary<string, string> alumno = new Dictionary<string, string>();
        //Los elementos se almacenanan 
        Dictionary<string, string> trabajadores = new Dictionary<string, string>();
        //Cuando una variable es static se puede utilizar en cualquier parte del proyecto
        public static string NomUsuario;
        public Form1()
        {   //// Este es un método
            InitializeComponent();
            //Agrega los valores especificados al diccionario
            alumno.Add("201000079", "ALVAREZ LOZA JOB ALBERTO");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000180", "AVITIA MUÑIZ ELIENAI AZUCENA");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000175", "CARRIZALES CARRILLO LUIS GAEL");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000068", "CENICEROS CABRERA YOHEL");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000078", "HERNANDEZ AGUILAR NAYDELIN GUADALUPE");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000130", "JIMENEZ IBARRA HECTOR ADAIR");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000133", "LOZA MILAN LEONARDO");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000188", "OCHOA ESPARZA SANJUANA MELISSA");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000152", "SCOTT CARREON PAOLA ALEJANDRA");
            //Agrega los valores especificados al diccionario
            alumno.Add("201000114", "VELASQUEZ VAZQUEZ DIANA KAREN");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("12", "ME. ALEJANDRO HERNANDEZ LOPEZ");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("13", "MTIC. ULISES MARTINEZ RODRIGUEZ");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("14", "ING. AMERICO MARTINEZ OVALLE");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("15", "ME. IDALIA RUIZ ARROYO");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("16", "ING. JOSE LUIS MOTA ESPELETA");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("17", "MC. JOSE MARTIN MENDOZA RODRIGUEZ");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("18", "MTRO EDGAR FRANCISCO VALDEZ ZUÑIGA");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("19", "ME. JULIO CESAR MOLINA RODRIGUEZ");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("20", "ING. OSCAR FABIAN RAMOS OCHOA");
            //Agrega los valores especificados al diccionario
            trabajadores.Add("01", "MC. ELSA CAROLINA AVILA SALOMON");
        }
        //Este es un evento que ocurre cada vez que se modifica el texto por parte del usuario
        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            //Cambia  el color del texto dentro de la caja de texto
            textUsuario.ForeColor = Color.Black;
        }
        //Este es un evento que ocrre cuando el usuario da un click 
        private void textUsuario_Click(object sender, EventArgs e)
        {
            //Nos genera una cadena vacia al dar click
            textUsuario.Text = String.Empty;
        }
        //este esvento permite validar un cuadro de texto cuando un usuario intenta salir de el 
        private void textUsuario_Leave(object sender, EventArgs e)
        {    //Estructura condicional
            if (textUsuario.Text == string.Empty)
            {//Inicio de la estructura
                //Te establece el texto asociado al control
                textUsuario.Text = "Ingresa Usuario";
            }//Fin de la estructura
            //Para saber quien tiene el foco 
            textUsuario.ForeColor = Color.Gray;
        }
       //Evento de nombre: "KeyPress", cuando presionamos y soltamos una tecla
        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {    //Estructura condicional 
            if (invitado.Checked == true)
            {//Inicia la estructura
                //Valida las pulsaciones de taclado
                if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 31 || e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
                {
                    //Devuelve un true si el evento está controlado; en caso contrario,false
                    e.Handled = true;
                    //Devuelve el valor
                    return;
                }
            }//Finaliza la estructura
            if (invitado.Checked == false)
            {     ////Valida las pulsaciones de taclado
                if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 31 || e.KeyChar >= 33 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
                {   ////Devuelve un true si el evento está controlado; en caso contrario,false
                    e.Handled = true;
                    //Devuelve el valor
                    return;
                }
            }//Finaliza la estructura
        }
        //Evento que ocrre cuando el usuario da un click  
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Detecta el error en imput
            const string caption = "";
            ////Muestra un cuadro de dialogo
            DialogResult selecciondelusuario = MessageBox.Show("¿Deseas salir de la aplicación?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Estructura condicional
            if (selecciondelusuario == DialogResult.Yes)
            {//Inicia la estructura if
                //Salir de la aplicacion
                Application.Exit();
            }//Finaliza la estructura
            //Estructura condicional
            if (selecciondelusuario == DialogResult.No)
            {    //Establece el foco en el control.
                textUsuario.Focus();
                //Devuelve el valor
                return;
            }//Finaliza la estructura
        } //Evento que ocurre cuando el mouse ya no está en la parte visible del control
        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {//Agrega una imagen al control 
            btnAceptar.BackgroundImage = Properties.Resources.click;
        }
         //Evento que ocurre cuando el mouse permanece quieto dentro del control
        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {//Agrega una imagen al control
            btnAceptar.BackgroundImage = Properties.Resources.hand;
        }
        //Evento que ocrre cuando el usuario da un click 
        private void btnAceptar_Click(object sender, EventArgs e)
        { //Estructura condicional 
            if (invitado.Checked == false)
            {
                //Estructura condicional
                if (alumno.ContainsKey(textUsuario.Text) || trabajadores.ContainsKey(textUsuario.Text))
                {   //Reprsenta la cadena vacía
                    string mensaje = string.Empty;
                    //Estructura condicional 
                    if (alumno.ContainsKey(textUsuario.Text))
                    {//Remplaza uno o m
                        mensaje = string.Format("Bienvenido a PIDETEC {0}, esperamos atenderte de lo mejor posible", alumno[textUsuario.Text].ToString());
                        NomUsuario = alumno[textUsuario.Text].ToString();
                    }
                    if (trabajadores.ContainsKey(textUsuario.Text))
                    {
                        mensaje = string.Format("Bienvenido a PIDETEC {0}, esperamos atenderte de lo mejor posible", trabajadores[textUsuario.Text].ToString());
                        NomUsuario = trabajadores[textUsuario.Text].ToString();
                    }

                    //Instanciando una clase 
                    opcion = new opciones();
                    //Oculta el control al usuario
                    this.Hide();
                    //Muestra un cuadro de dialogo 
                    DialogResult op = opcion.ShowDialog();
                    //Estructura condicional
                    if (op == DialogResult.OK)
                    {//Muestra el control al usuario
                        this.Show();
                    }
                }//sino
                else
                {//Muestra una ventana de mensaje 
                    MessageBox.Show("no se encuentra el usuario", "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Establece el foco en el control
                    textUsuario.Focus();
                    //Borra todo el texto del controlde cuadro de texto 
                    textUsuario.Clear();
                }
            }
            else//sino
            {    //Establece el foco en el control
                textUsuario.Focus();
                //Asigna un valor a una variable static
                NomUsuario = textUsuario.Text;
                //Muestra una ventana de mensaje 
                MessageBox.Show(NomUsuario, "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Instanciando una clase 
                opcion = new opciones();
                //Oculta el cntrol al usuario
                this.Hide();
                //Muestra un cuadro de dialogo 
                DialogResult op = opcion.ShowDialog();
                //Estructura condicional
                if (op == DialogResult.OK)
                {//Inicia la estructura
                  //Muestra el control al usuario
                    this.Show();
                }//Finaliza la estructura
            }//cierre del else 
        }//cierre del if
   


    }//cierre de la llave de la clase
}//cierre de la llave glogabl
