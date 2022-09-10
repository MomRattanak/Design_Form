using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Form
{
    class ml
    {
        Panel span;
        Button button;
        bool horizontal;
        bool hidden;
        string sText;
        string hText;
        int size;
        Timer t;

        public ml(ref Panel p, ref Button b, bool hor, string hText, string sText)
        {
            this.span = p;
            this.button = b;
            this.horizontal = hor;
            hidden = false;
            this.hText = hText;
            this.sText = sText;
            //
            if (horizontal) size = p.Height;
            else size = p.Width;

            b.Click += new EventHandler(button_clicked);

            t = new Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(t_tick);

        }
        void ChangeSize(int val)
        {
            if(horizontal)
            {
                span.Height += val;

                if(span.Height>=size||span.Height<=0)
                {
                    t.Stop();
                    hidden=!hidden;
                }
            }
            else
            {
                span.Width += val;

                if(span.Height>=size||span.Width<=0)
                {
                    t.Stop();
                    hidden = !hidden;
                }
            }
        }

        private void t_tick(object sender, EventArgs e)
        {
            if (hidden)ChangeSize(+20);
            else ChangeSize(-20); 
              
        }

        private void button_clicked(object sender, EventArgs e)
        {
            if (hidden)button.Text = sText;
            else button.Text = hText;

            t.Start();
        }
    }
}
