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
    public partial class send_sms : Form
    {
        public send_sms()
        {
            InitializeComponent();
        }



        public void enviar_mensaje()
        {
            RichTextBox consola = (RichTextBox)this.Controls["console"];
            secon_form.sms_class.sms_textbelt_send sms = new secon_form.sms_class.sms_textbelt_send();
            string numero_telefonico = $"{countrycode_box.Text}{number_box.Text}";
            string mensaje = console.Text;


            string resultado = sms.sms_send(numero_telefonico, mensaje);

            consola.Clear();
            consola.AppendText($"{resultado}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() => { enviar_mensaje(); });
        }
    }
}
