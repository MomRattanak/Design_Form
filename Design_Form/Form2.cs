using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Form
{
    public partial class Form2 : Form
    {
        ml o1,o2;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //o1 = new ml(ref panel2, ref button1,false, "HIDE", "SHOW");
            //o2 = new ml(ref panel4, ref button2, false, "H", "S");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o1 = new ml(ref panel2, ref button1, true, "HIDE","SHOW");
            o2 = new ml(ref panel4, ref button2,false, "H", "S");
               
        }
    }
}
