
namespace Microwave_Wattage_Conversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.watt1In = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time1In = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.watt2In = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.time2Out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Wattage on Instructions:";
            // 
            // watt1In
            // 
            this.watt1In.Location = new System.Drawing.Point(20, 100);
            this.watt1In.Name = "watt1In";
            this.watt1In.Size = new System.Drawing.Size(100, 20);
            this.watt1In.TabIndex = 1;
            this.watt1In.TextChanged += new System.EventHandler(this.watt1In_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Time on Instructions (in seconds):";
            // 
            // time1In
            // 
            this.time1In.Location = new System.Drawing.Point(20, 200);
            this.time1In.Name = "time1In";
            this.time1In.Size = new System.Drawing.Size(100, 20);
            this.time1In.TabIndex = 3;
            this.time1In.TextChanged += new System.EventHandler(this.time1In_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Your Microwave\'s Wattage:";
            // 
            // watt2In
            // 
            this.watt2In.Location = new System.Drawing.Point(20, 300);
            this.watt2In.Name = "watt2In";
            this.watt2In.Size = new System.Drawing.Size(100, 20);
            this.watt2In.TabIndex = 5;
            this.watt2In.TextChanged += new System.EventHandler(this.watt2In_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time to Cook on Your Microwave:";
            // 
            // time2Out
            // 
            this.time2Out.AutoSize = true;
            this.time2Out.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time2Out.Location = new System.Drawing.Point(325, 200);
            this.time2Out.Name = "time2Out";
            this.time2Out.Size = new System.Drawing.Size(227, 79);
            this.time2Out.TabIndex = 7;
            this.time2Out.Text = "00:00";
            this.time2Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time2Out.TextChanged += new System.EventHandler(this.watt2In_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.time2Out);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.watt2In);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time1In);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.watt1In);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Microwave Wattage Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox watt1In;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time1In;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox watt2In;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label time2Out;
    }
}

