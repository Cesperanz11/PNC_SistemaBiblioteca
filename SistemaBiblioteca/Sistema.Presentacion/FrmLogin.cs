using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;


namespace Sistema.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Funcion de Mensaje de Error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Funcion de Mensaje de OK
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Funcion de Limpiar formulario
        private void Limpiar()
        {
            TxtEmail.Clear();
            TxtPassword.Clear();
        }

        //Funcion para crear el FrmMaestros
        public static void ThreadProcMaestros()
        {
            FrmMaestros f;
            Application.Run(new FrmMaestros());
        }

        //Funcion para crear el FrmAdmin
        public static void ThreadProcAdmin()
        {
            FrmAdmin f;
            Application.Run(new FrmAdmin());
        }

        //Funcion de Login y Verificacion
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;
            string Rol;
            FrmMaestros frm_maestros = new FrmMaestros(); // Creando un formulario hijo de FrmMaestros
            FrmAdmin frm_admin = new FrmAdmin(); // Creando un formulario hijo de FrmAdmin

            try
            {
                string Rpta = "";

                //Validando que ninguno de los datos importantes esten vacios
                if (email == string.Empty)
                {
                    this.MensajeError("Faltan datos por ingresar.");
                    //Mostrar Error Provider donde faltan datos
                    //ErrorIcono.SetError(txtNombre, "Ingrese un nombre");
                }
                else if (password == string.Empty)
                {
                    this.MensajeError("Faltan datos por ingresar.");
                    //Mostrar Error Provider donde faltan datos
                    //ErrorIcono.SetError(txtApellido, "Ingrese un apellido");
                }
                else
                {
                    //Verificar si el usuario que hemos ingresado existe realmente en la BD
                    Rpta = NUsuario.Verificar(email.Trim());
                    if (Rpta.Equals("OK")) //El usuario si existe en la BD
                    {
                        //Verificar si la password que hemos ingresado coincide con las credenciales en la BD
                        Rpta = NUsuario.Login(email.Trim(), password.Trim());
                        if (Rpta.Equals("OK")) //La password es correcta
                        {
                            //this.MensajeOk("Se hizo un login exitosamente"); //Mostrarle al usuario que si se hacer login
                            

                            Rol = NUsuario.Get_Rol(email.Trim()); // Obteniendo el rol del usuario loggeado

                            if (Rol.Equals("1"))
                            {
                                
                                // Pasando el control al FrmMaestros y cerrando el FrmLogin
                                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcMaestros));
                                t.Start();
                                this.Close();
                            }
                            else if(Rol.Equals("2"))
                            {

                                // Pasanda el control al FrmAdmin y cerrando el FrmLogin
                                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcAdmin));
                                t.Start();
                                this.Close();
                            }
                        }
                        else //La password es incorrecta
                        {
                            this.MensajeError(Rpta);
                            this.Limpiar(); //Borrar la informacion de los TextBoxs
                        }
                    }
                    else //El usuario no existe en la BD
                    {
                        this.MensajeError(Rpta);
                        this.Limpiar(); //Borrar la informacion de los TextBoxs
                    }
                    }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtEmail.Clear();
            TxtPassword.Clear();
        }
    }
    
}
