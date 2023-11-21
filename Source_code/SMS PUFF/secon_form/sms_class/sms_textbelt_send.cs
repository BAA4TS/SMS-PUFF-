using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SMS_PUFF.secon_form.sms_class
{
    internal class sms_textbelt_send
    {
        public string sms_send(string number, string mensaje)
        {
            if (number.Substring(0,1) != "+")
            {
                number = $"+{number}";
            }
            using (WebClient client = new WebClient())
            {
                byte[] respuesta = client.UploadValues("http://textbelt.com/text", new NameValueCollection()
                {
                    { "phone", $"{number}" },
                    { "message", $"{mensaje}" },
                    { "key", "textbelt" },

                });
                string salida = System.Text.Encoding.UTF8.GetString(respuesta);
                return salida;
            }
            
        }
    }
}
