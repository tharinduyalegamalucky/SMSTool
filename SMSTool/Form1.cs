using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Net;

namespace SMSTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String result;
            string username = "farmsprideuser@cbs";
            string digest = "D!2L0g$mScry";
            string q = "14355541128558";
            string destination = txtPhoneNumber.Text;
            string message = txtMessage.Text;

            string url = "https://richcommunication.dialog.lk/api/sms/inline/send?username=" + username + "&digest=" + digest + "&q=" + q + "&destination=" + destination + "&message=" + message;

            StreamWriter smsWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";

            try
            {
                smsWriter = new StreamWriter(objRequest.GetRequestStream());
                smsWriter.Write(url);

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(ex.Message);

            }
            finally
            {
                smsWriter.Close();

            }

            //try
            //{




            //    ////This is a User Name Code.....
            //    //SerialPort sp = new SerialPort();
            //    //sp.PortName = txtUserName.Text;
            //    //sp.Open();
            //    //sp.WriteLine("AI" + Environment.NewLine);
            //    //Thread.Sleep(100);

            //    //sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
            //    //Thread.Sleep(100);

            //    //sp.WriteLine("AT+CMGS=\"" + txtPhoneNumber.Text + "\"" + Environment.NewLine);
            //    //Thread.Sleep(100);

            //    //sp.WriteLine(txtMessage.Text + Environment.NewLine);
            //    //Thread.Sleep(100);


            //    //sp.Write(new byte[] { 26 }, 0, 1);
            //    //Thread.Sleep(100);

            //    //var response = sp.ReadExisting();
            //    //if (response.Contains("ERROR"))
            //    //    MessageBox.Show("Send failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //else
            //    //MessageBox.Show("Message has been sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //    sp.Close();

            //}
            //catch (Exception ex){
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }
    }
}
