using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;
namespace Aula09
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {

                txtResult.Text = await ExecutarWebService();               
                MessageBox.Show("Test");
            }
            catch (Exception es)
            {
                await Log(es.Message);
            }
            finally
            {

            }


        }
        private async Task Log(string msg)
        {
            MessageBox.Show(msg);
        }
        private async Task<string> ExecutarWebService()
        {
            var calc = new Proxy.CalculadoraWebService();
            return calc.Somar(ToInt32(txtx.Text), ToInt32(txty.Text)).ToString();
        }
       

        
    }
}
