namespace Design_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(360, 97);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.Size = new System.Drawing.Size(242, 40);
            this.materialSlider1.TabIndex = 0;
            this.materialSlider1.Text = "Hi";
            this.materialSlider1.Click += new System.EventHandler(this.materialSlider1_Click);
            // 
            // materialScrollBar1
            // 
            this.materialScrollBar1.BackColor = System.Drawing.Color.Aqua;
            this.materialScrollBar1.Depth = 0;
            this.materialScrollBar1.Location = new System.Drawing.Point(143, 95);
            this.materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialScrollBar1.Name = "materialScrollBar1";
            this.materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            this.materialScrollBar1.ScrollbarSize = 23;
            this.materialScrollBar1.Size = new System.Drawing.Size(23, 258);
            this.materialScrollBar1.TabIndex = 1;
            this.materialScrollBar1.Text = "materialScrollBar1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 3;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(530, 176);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialScrollBar1);
            this.Controls.Add(this.materialSlider1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

