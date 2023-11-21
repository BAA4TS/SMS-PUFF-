using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_PUFF
{
    public partial class formulario_principal : Form
    {

        public formulario_principal()
        {
            InitializeComponent();
        }
        //
        // Dependencias del Sofware // Movimiento desde la Barra DLL
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //



        //
        // Funciones de Botones de exit, minimizar y arrastre de ventana
        //

        private void exit_button_Click(object sender, EventArgs e) // Boton para cerrar la aplicacion
        {
            Application.Exit();
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)  // Funcion de mover la Menu Bar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_minimizar_Click(object sender, EventArgs e) // Boton Minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //
        // Funcion para Canviar de Panel de Principal
        // 
        private void canviar_de_panel(object ventana_a_canviar)
        {
            if (this.panel_de_canvio.Controls.Count > 0)
            {
                this.panel_de_canvio.Controls.RemoveAt(0);
            }
            Form form = ventana_a_canviar as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel_de_canvio.Controls.Add(form);
            this.panel_de_canvio.Tag = form;
            form.Show();
        }

        private void boton_para_ir_al_send_Click(object sender, EventArgs e) // Boton Send
        {
            canviar_de_panel(new send_sms());
        }
    }
}
