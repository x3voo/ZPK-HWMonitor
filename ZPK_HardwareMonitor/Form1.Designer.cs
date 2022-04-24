
namespace ZPK_HardwareMonitor
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
            this.components = new System.ComponentModel.Container();
            this.textBoxCPUUsage = new System.Windows.Forms.TextBox();
            this.textBoxCPUTemp = new System.Windows.Forms.TextBox();
            this.textBoxCPUTempName = new System.Windows.Forms.TextBox();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.textBoxAvaiableRAM = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCPUUsage
            // 
            this.textBoxCPUUsage.Location = new System.Drawing.Point(100, 13);
            this.textBoxCPUUsage.Name = "textBoxCPUUsage";
            this.textBoxCPUUsage.Size = new System.Drawing.Size(240, 22);
            this.textBoxCPUUsage.TabIndex = 0;
            this.textBoxCPUUsage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCPUTemp
            // 
            this.textBoxCPUTemp.Location = new System.Drawing.Point(100, 69);
            this.textBoxCPUTemp.Name = "textBoxCPUTemp";
            this.textBoxCPUTemp.Size = new System.Drawing.Size(240, 22);
            this.textBoxCPUTemp.TabIndex = 1;
            // 
            // textBoxCPUTempName
            // 
            this.textBoxCPUTempName.Location = new System.Drawing.Point(100, 97);
            this.textBoxCPUTempName.Name = "textBoxCPUTempName";
            this.textBoxCPUTempName.Size = new System.Drawing.Size(240, 22);
            this.textBoxCPUTempName.TabIndex = 2;
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(21, 234);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(73, 22);
            this.textBoxTimer.TabIndex = 3;
            // 
            // textBoxAvaiableRAM
            // 
            this.textBoxAvaiableRAM.Location = new System.Drawing.Point(100, 41);
            this.textBoxAvaiableRAM.Name = "textBoxAvaiableRAM";
            this.textBoxAvaiableRAM.Size = new System.Drawing.Size(240, 22);
            this.textBoxAvaiableRAM.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPU Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Avaiable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPU Temp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 344);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAvaiableRAM);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.textBoxCPUTempName);
            this.Controls.Add(this.textBoxCPUTemp);
            this.Controls.Add(this.textBoxCPUUsage);
            this.Name = "Form1";
            this.Text = "Hardware Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCPUUsage;
        private System.Windows.Forms.TextBox textBoxCPUTemp;
        private System.Windows.Forms.TextBox textBoxCPUTempName;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.TextBox textBoxAvaiableRAM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

