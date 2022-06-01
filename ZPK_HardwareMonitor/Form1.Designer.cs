
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
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.textBoxAvaiableRAM = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCpuName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotalMem = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.graph3 = new ZPK_HardwareMonitor.graph();
            this.graph2 = new ZPK_HardwareMonitor.graph();
            this.graph1 = new ZPK_HardwareMonitor.graph();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.integratedGpu = new System.Windows.Forms.TextBox();
            this.dedicatedGpu = new System.Windows.Forms.TextBox();
            this.labelMaxRamGb = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCPUUsage
            // 
            this.textBoxCPUUsage.Location = new System.Drawing.Point(93, 46);
            this.textBoxCPUUsage.Name = "textBoxCPUUsage";
            this.textBoxCPUUsage.Size = new System.Drawing.Size(240, 22);
            this.textBoxCPUUsage.TabIndex = 0;
            this.textBoxCPUUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCPUTemp
            // 
            this.textBoxCPUTemp.Location = new System.Drawing.Point(93, 141);
            this.textBoxCPUTemp.Name = "textBoxCPUTemp";
            this.textBoxCPUTemp.Size = new System.Drawing.Size(240, 22);
            this.textBoxCPUTemp.TabIndex = 1;
            this.textBoxCPUTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(70, 300);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(73, 22);
            this.textBoxTimer.TabIndex = 3;
            // 
            // textBoxAvaiableRAM
            // 
            this.textBoxAvaiableRAM.Location = new System.Drawing.Point(93, 15);
            this.textBoxAvaiableRAM.Name = "textBoxAvaiableRAM";
            this.textBoxAvaiableRAM.Size = new System.Drawing.Size(240, 22);
            this.textBoxAvaiableRAM.TabIndex = 4;
            this.textBoxAvaiableRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPU Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Avaiable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPU Temp";
            // 
            // labelCpuName
            // 
            this.labelCpuName.AutoSize = true;
            this.labelCpuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpuName.Location = new System.Drawing.Point(3, 21);
            this.labelCpuName.Name = "labelCpuName";
            this.labelCpuName.Size = new System.Drawing.Size(52, 17);
            this.labelCpuName.TabIndex = 12;
            this.labelCpuName.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelCpuName);
            this.groupBox1.Controls.Add(this.graph2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCPUTemp);
            this.groupBox1.Controls.Add(this.graph1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCPUUsage);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 248);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.labelMaxRamGb);
            this.groupBox2.Controls.Add(this.labelTotalMem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelModel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelManufacturer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.graph3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxAvaiableRAM);
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 196);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Manufacturer";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturer.Location = new System.Drawing.Point(108, 109);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(52, 17);
            this.labelManufacturer.TabIndex = 16;
            this.labelManufacturer.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Model";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(108, 136);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(46, 17);
            this.labelModel.TabIndex = 18;
            this.labelModel.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total";
            // 
            // labelTotalMem
            // 
            this.labelTotalMem.AutoSize = true;
            this.labelTotalMem.Location = new System.Drawing.Point(108, 163);
            this.labelTotalMem.Name = "labelTotalMem";
            this.labelTotalMem.Size = new System.Drawing.Size(46, 17);
            this.labelTotalMem.TabIndex = 20;
            this.labelTotalMem.Text = "label9";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dedicatedGpu);
            this.groupBox3.Controls.Add(this.integratedGpu);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(365, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 107);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPU";
            // 
            // graph3
            // 
            this.graph3.Location = new System.Drawing.Point(67, 43);
            this.graph3.Name = "graph3";
            this.graph3.Size = new System.Drawing.Size(268, 63);
            this.graph3.TabIndex = 0;
            // 
            // graph2
            // 
            this.graph2.Location = new System.Drawing.Point(66, 169);
            this.graph2.Name = "graph2";
            this.graph2.Size = new System.Drawing.Size(268, 63);
            this.graph2.TabIndex = 11;
            // 
            // graph1
            // 
            this.graph1.Location = new System.Drawing.Point(66, 74);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(268, 63);
            this.graph1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "0%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "100 °C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "0 °C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Uptime";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Integraded GPU";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Dedicated GPU";
            // 
            // integratedGpu
            // 
            this.integratedGpu.Location = new System.Drawing.Point(126, 26);
            this.integratedGpu.Name = "integratedGpu";
            this.integratedGpu.Size = new System.Drawing.Size(207, 22);
            this.integratedGpu.TabIndex = 18;
            // 
            // dedicatedGpu
            // 
            this.dedicatedGpu.Location = new System.Drawing.Point(126, 64);
            this.dedicatedGpu.Name = "dedicatedGpu";
            this.dedicatedGpu.Size = new System.Drawing.Size(207, 22);
            this.dedicatedGpu.TabIndex = 19;
            // 
            // labelMaxRamGb
            // 
            this.labelMaxRamGb.AutoSize = true;
            this.labelMaxRamGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxRamGb.Location = new System.Drawing.Point(17, 43);
            this.labelMaxRamGb.Name = "labelMaxRamGb";
            this.labelMaxRamGb.Size = new System.Drawing.Size(41, 15);
            this.labelMaxRamGb.TabIndex = 17;
            this.labelMaxRamGb.Text = "10 GB";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "0 GB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 330);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxTimer);
            this.Name = "Form1";
            this.Text = "Hardware Monitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCPUUsage;
        private System.Windows.Forms.TextBox textBoxCPUTemp;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.TextBox textBoxAvaiableRAM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private graph graph1;
        private graph graph2;
        private System.Windows.Forms.Label labelCpuName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private graph graph3;
        private System.Windows.Forms.Label labelTotalMem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dedicatedGpu;
        private System.Windows.Forms.TextBox integratedGpu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelMaxRamGb;
        private System.Windows.Forms.Label label15;
    }
}

