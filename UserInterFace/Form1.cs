using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDay1Demo;
namespace UserInterFace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBMRCodeneWV2Entities db = new DBMRCodeneWV2Entities();
                var x = DateTime.Now;
                var xc = db.GetstudentDataBycat(1);

                MessageBox.Show(xc.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
