
namespace ZPK_HardwareMonitor
{
    partial class FormMain
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
            this.timerUptime = new System.Windows.Forms.Timer(this.components);
            this.labelCpuUsage = new System.Windows.Forms.Label();
            this.labelAvaiableRam = new System.Windows.Forms.Label();
            this.labelCpuTemp = new System.Windows.Forms.Label();
            this.labelCpuName = new System.Windows.Forms.Label();
            this.groupBoxCpu = new System.Windows.Forms.GroupBox();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelMinCpuUsage = new System.Windows.Forms.Label();
            this.labelMaxCpuUsage = new System.Windows.Forms.Label();
            this.groupBoxRam = new System.Windows.Forms.GroupBox();
            this.labelMinRam = new System.Windows.Forms.Label();
            this.labelMaxRam = new System.Windows.Forms.Label();
            this.labelTotalMemoryValue = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelModelValue = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelManufacturerValue = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.groupBoxGpu = new System.Windows.Forms.GroupBox();
            this.labelDedicatedGpu = new System.Windows.Forms.Label();
            this.dedicatedGpu = new System.Windows.Forms.TextBox();
            this.integratedGpu = new System.Windows.Forms.TextBox();
            this.labelIntegratedGpu = new System.Windows.Forms.Label();
            this.labelUptime = new System.Windows.Forms.Label();
            this.GraphRAM = new ZPK_HardwareMonitor.Graph();
            this.GraphCPUTemp = new ZPK_HardwareMonitor.Graph();
            this.GraphCPUUsage = new ZPK_HardwareMonitor.Graph();
            this.groupBoxCpu.SuspendLayout();
            this.groupBoxRam.SuspendLayout();
            this.groupBoxGpu.SuspendLayout();
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
            // timerUptime
            // 
            this.timerUptime.Enabled = true;
            this.timerUptime.Interval = 500;
            this.timerUptime.Tick += new System.EventHandler(this.timerUptimeTick);
            // 
            // labelCpuUsage
            // 
            this.labelCpuUsage.AutoSize = true;
            this.labelCpuUsage.Location = new System.Drawing.Point(6, 46);
            this.labelCpuUsage.Name = "labelCpuUsage";
            this.labelCpuUsage.Size = new System.Drawing.Size(81, 17);
            this.labelCpuUsage.TabIndex = 5;
            this.labelCpuUsage.Text = "CPU Usage";
            // 
            // labelAvaiableRam
            // 
            this.labelAvaiableRam.AutoSize = true;
            this.labelAvaiableRam.Location = new System.Drawing.Point(7, 18);
            this.labelAvaiableRam.Name = "labelAvaiableRam";
            this.labelAvaiableRam.Size = new System.Drawing.Size(62, 17);
            this.labelAvaiableRam.TabIndex = 6;
            this.labelAvaiableRam.Text = "Avaiable";
            // 
            // labelCpuTemp
            // 
            this.labelCpuTemp.AutoSize = true;
            this.labelCpuTemp.Location = new System.Drawing.Point(11, 144);
            this.labelCpuTemp.Name = "labelCpuTemp";
            this.labelCpuTemp.Size = new System.Drawing.Size(76, 17);
            this.labelCpuTemp.TabIndex = 7;
            this.labelCpuTemp.Text = "CPU Temp";
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
            // groupBoxCpu
            // 
            this.groupBoxCpu.Controls.Add(this.labelMinTemp);
            this.groupBoxCpu.Controls.Add(this.labelMaxTemp);
            this.groupBoxCpu.Controls.Add(this.labelMinCpuUsage);
            this.groupBoxCpu.Controls.Add(this.labelMaxCpuUsage);
            this.groupBoxCpu.Controls.Add(this.labelCpuName);
            this.groupBoxCpu.Controls.Add(this.GraphCPUTemp);
            this.groupBoxCpu.Controls.Add(this.labelCpuUsage);
            this.groupBoxCpu.Controls.Add(this.textBoxCPUTemp);
            this.groupBoxCpu.Controls.Add(this.GraphCPUUsage);
            this.groupBoxCpu.Controls.Add(this.labelCpuTemp);
            this.groupBoxCpu.Controls.Add(this.textBoxCPUUsage);
            this.groupBoxCpu.Location = new System.Drawing.Point(12, 11);
            this.groupBoxCpu.Name = "groupBoxCpu";
            this.groupBoxCpu.Size = new System.Drawing.Size(347, 248);
            this.groupBoxCpu.TabIndex = 13;
            this.groupBoxCpu.TabStop = false;
            this.groupBoxCpu.Text = "CPU";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinTemp.Location = new System.Drawing.Point(30, 212);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(30, 15);
            this.labelMinTemp.TabIndex = 17;
            this.labelMinTemp.Text = "0 °C";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTemp.Location = new System.Drawing.Point(15, 168);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(44, 15);
            this.labelMaxTemp.TabIndex = 17;
            this.labelMaxTemp.Text = "100 °C";
            // 
            // labelMinCpuUsage
            // 
            this.labelMinCpuUsage.AutoSize = true;
            this.labelMinCpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinCpuUsage.Location = new System.Drawing.Point(38, 118);
            this.labelMinCpuUsage.Name = "labelMinCpuUsage";
            this.labelMinCpuUsage.Size = new System.Drawing.Size(25, 15);
            this.labelMinCpuUsage.TabIndex = 17;
            this.labelMinCpuUsage.Text = "0%";
            // 
            // labelMaxCpuUsage
            // 
            this.labelMaxCpuUsage.AutoSize = true;
            this.labelMaxCpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxCpuUsage.Location = new System.Drawing.Point(22, 74);
            this.labelMaxCpuUsage.Name = "labelMaxCpuUsage";
            this.labelMaxCpuUsage.Size = new System.Drawing.Size(39, 15);
            this.labelMaxCpuUsage.TabIndex = 16;
            this.labelMaxCpuUsage.Text = "100%";
            // 
            // groupBoxRam
            // 
            this.groupBoxRam.Controls.Add(this.labelMinRam);
            this.groupBoxRam.Controls.Add(this.labelMaxRam);
            this.groupBoxRam.Controls.Add(this.labelTotalMemoryValue);
            this.groupBoxRam.Controls.Add(this.labelTotal);
            this.groupBoxRam.Controls.Add(this.labelModelValue);
            this.groupBoxRam.Controls.Add(this.labelModel);
            this.groupBoxRam.Controls.Add(this.labelManufacturerValue);
            this.groupBoxRam.Controls.Add(this.labelManufacturer);
            this.groupBoxRam.Controls.Add(this.GraphRAM);
            this.groupBoxRam.Controls.Add(this.labelAvaiableRam);
            this.groupBoxRam.Controls.Add(this.textBoxAvaiableRAM);
            this.groupBoxRam.Location = new System.Drawing.Point(365, 12);
            this.groupBoxRam.Name = "groupBoxRam";
            this.groupBoxRam.Size = new System.Drawing.Size(347, 196);
            this.groupBoxRam.TabIndex = 14;
            this.groupBoxRam.TabStop = false;
            this.groupBoxRam.Text = "RAM";
            // 
            // labelMinRam
            // 
            this.labelMinRam.AutoSize = true;
            this.labelMinRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinRam.Location = new System.Drawing.Point(24, 87);
            this.labelMinRam.Name = "labelMinRam";
            this.labelMinRam.Size = new System.Drawing.Size(34, 15);
            this.labelMinRam.TabIndex = 17;
            this.labelMinRam.Text = "0 GB";
            // 
            // labelMaxRam
            // 
            this.labelMaxRam.AutoSize = true;
            this.labelMaxRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxRam.Location = new System.Drawing.Point(17, 43);
            this.labelMaxRam.Name = "labelMaxRam";
            this.labelMaxRam.Size = new System.Drawing.Size(41, 15);
            this.labelMaxRam.TabIndex = 17;
            this.labelMaxRam.Text = "10 GB";
            // 
            // labelTotalMemoryValue
            // 
            this.labelTotalMemoryValue.AutoSize = true;
            this.labelTotalMemoryValue.Location = new System.Drawing.Point(108, 163);
            this.labelTotalMemoryValue.Name = "labelTotalMemoryValue";
            this.labelTotalMemoryValue.Size = new System.Drawing.Size(46, 17);
            this.labelTotalMemoryValue.TabIndex = 20;
            this.labelTotalMemoryValue.Text = "label9";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(10, 163);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 17);
            this.labelTotal.TabIndex = 19;
            this.labelTotal.Text = "Total";
            // 
            // labelModelValue
            // 
            this.labelModelValue.AutoSize = true;
            this.labelModelValue.Location = new System.Drawing.Point(108, 136);
            this.labelModelValue.Name = "labelModelValue";
            this.labelModelValue.Size = new System.Drawing.Size(46, 17);
            this.labelModelValue.TabIndex = 18;
            this.labelModelValue.Text = "label7";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(10, 136);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(46, 17);
            this.labelModel.TabIndex = 17;
            this.labelModel.Text = "Model";
            // 
            // labelManufacturerValue
            // 
            this.labelManufacturerValue.AutoSize = true;
            this.labelManufacturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturerValue.Location = new System.Drawing.Point(108, 109);
            this.labelManufacturerValue.Name = "labelManufacturerValue";
            this.labelManufacturerValue.Size = new System.Drawing.Size(52, 17);
            this.labelManufacturerValue.TabIndex = 16;
            this.labelManufacturerValue.Text = "label5";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(10, 109);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(92, 17);
            this.labelManufacturer.TabIndex = 15;
            this.labelManufacturer.Text = "Manufacturer";
            // 
            // groupBoxGpu
            // 
            this.groupBoxGpu.Controls.Add(this.labelDedicatedGpu);
            this.groupBoxGpu.Controls.Add(this.dedicatedGpu);
            this.groupBoxGpu.Controls.Add(this.integratedGpu);
            this.groupBoxGpu.Controls.Add(this.labelIntegratedGpu);
            this.groupBoxGpu.Location = new System.Drawing.Point(365, 213);
            this.groupBoxGpu.Name = "groupBoxGpu";
            this.groupBoxGpu.Size = new System.Drawing.Size(347, 107);
            this.groupBoxGpu.TabIndex = 15;
            this.groupBoxGpu.TabStop = false;
            this.groupBoxGpu.Text = "GPU";
            // 
            // labelDedicatedGpu
            // 
            this.labelDedicatedGpu.AutoSize = true;
            this.labelDedicatedGpu.Location = new System.Drawing.Point(10, 67);
            this.labelDedicatedGpu.Name = "labelDedicatedGpu";
            this.labelDedicatedGpu.Size = new System.Drawing.Size(106, 17);
            this.labelDedicatedGpu.TabIndex = 17;
            this.labelDedicatedGpu.Text = "Dedicated GPU";
            // 
            // dedicatedGpu
            // 
            this.dedicatedGpu.Location = new System.Drawing.Point(126, 64);
            this.dedicatedGpu.Name = "dedicatedGpu";
            this.dedicatedGpu.Size = new System.Drawing.Size(207, 22);
            this.dedicatedGpu.TabIndex = 19;
            // 
            // integratedGpu
            // 
            this.integratedGpu.Location = new System.Drawing.Point(126, 26);
            this.integratedGpu.Name = "integratedGpu";
            this.integratedGpu.Size = new System.Drawing.Size(207, 22);
            this.integratedGpu.TabIndex = 18;
            // 
            // labelIntegratedGpu
            // 
            this.labelIntegratedGpu.AutoSize = true;
            this.labelIntegratedGpu.Location = new System.Drawing.Point(10, 29);
            this.labelIntegratedGpu.Name = "labelIntegratedGpu";
            this.labelIntegratedGpu.Size = new System.Drawing.Size(106, 17);
            this.labelIntegratedGpu.TabIndex = 17;
            this.labelIntegratedGpu.Text = "Integrated GPU";
            // 
            // labelUptime
            // 
            this.labelUptime.AutoSize = true;
            this.labelUptime.Location = new System.Drawing.Point(12, 303);
            this.labelUptime.Name = "labelUptime";
            this.labelUptime.Size = new System.Drawing.Size(52, 17);
            this.labelUptime.TabIndex = 16;
            this.labelUptime.Text = "Uptime";
            // 
            // GraphRAM
            // 
            this.GraphRAM.Location = new System.Drawing.Point(67, 43);
            this.GraphRAM.Name = "GraphRAM";
            this.GraphRAM.Size = new System.Drawing.Size(268, 63);
            this.GraphRAM.TabIndex = 0;
            // 
            // GraphCPUTemp
            // 
            this.GraphCPUTemp.Location = new System.Drawing.Point(66, 169);
            this.GraphCPUTemp.Name = "GraphCPUTemp";
            this.GraphCPUTemp.Size = new System.Drawing.Size(268, 63);
            this.GraphCPUTemp.TabIndex = 11;
            // 
            // GraphCPUUsage
            // 
            this.GraphCPUUsage.Location = new System.Drawing.Point(66, 74);
            this.GraphCPUUsage.Name = "GraphCPUUsage";
            this.GraphCPUUsage.Size = new System.Drawing.Size(268, 63);
            this.GraphCPUUsage.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 330);
            this.Controls.Add(this.labelUptime);
            this.Controls.Add(this.groupBoxGpu);
            this.Controls.Add(this.groupBoxRam);
            this.Controls.Add(this.groupBoxCpu);
            this.Controls.Add(this.textBoxTimer);
            this.Name = "FormMain";
            this.Text = "Hardware Monitor";
            this.groupBoxCpu.ResumeLayout(false);
            this.groupBoxCpu.PerformLayout();
            this.groupBoxRam.ResumeLayout(false);
            this.groupBoxRam.PerformLayout();
            this.groupBoxGpu.ResumeLayout(false);
            this.groupBoxGpu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCPUUsage;
        private System.Windows.Forms.TextBox textBoxCPUTemp;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.TextBox textBoxAvaiableRAM;
        private System.Windows.Forms.Timer timerUptime;
        private System.Windows.Forms.Label labelCpuUsage;
        private System.Windows.Forms.Label labelAvaiableRam;
        private System.Windows.Forms.Label labelCpuTemp;
        private Graph GraphCPUUsage;
        private Graph GraphCPUTemp;
        private System.Windows.Forms.Label labelCpuName;
        private System.Windows.Forms.GroupBox groupBoxCpu;
        private System.Windows.Forms.GroupBox groupBoxRam;
        private Graph GraphRAM;
        private System.Windows.Forms.Label labelTotalMemoryValue;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelModelValue;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelManufacturerValue;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.GroupBox groupBoxGpu;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelMinCpuUsage;
        private System.Windows.Forms.Label labelMaxCpuUsage;
        private System.Windows.Forms.Label labelUptime;
        private System.Windows.Forms.Label labelDedicatedGpu;
        private System.Windows.Forms.TextBox dedicatedGpu;
        private System.Windows.Forms.TextBox integratedGpu;
        private System.Windows.Forms.Label labelIntegratedGpu;
        private System.Windows.Forms.Label labelMaxRam;
        private System.Windows.Forms.Label labelMinRam;
    }
}

