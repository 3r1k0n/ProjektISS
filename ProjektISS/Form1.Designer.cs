namespace ProjektISS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zedGraphControlHR = new ZedGraph.ZedGraphControl();
            this.buttonSimStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1unit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zedGraphControlBR = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zedGraphControlEKG = new ZedGraph.ZedGraphControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zedGraphControlGSR = new ZedGraph.ZedGraphControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.zedGraphControlEMG = new ZedGraph.ZedGraphControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.zedGraphControlRESP = new ZedGraph.ZedGraphControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.zedGraphControlST = new ZedGraph.ZedGraphControl();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSimStop = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControlHR
            // 
            this.zedGraphControlHR.AutoScroll = true;
            this.zedGraphControlHR.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControlHR.IsAntiAlias = true;
            this.zedGraphControlHR.IsShowHScrollBar = true;
            this.zedGraphControlHR.IsShowPointValues = true;
            this.zedGraphControlHR.IsSynchronizeXAxes = true;
            this.zedGraphControlHR.Location = new System.Drawing.Point(28, 324);
            this.zedGraphControlHR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlHR.Name = "zedGraphControlHR";
            this.zedGraphControlHR.ScrollGrace = 0D;
            this.zedGraphControlHR.ScrollMaxX = 0D;
            this.zedGraphControlHR.ScrollMaxY = 0D;
            this.zedGraphControlHR.ScrollMaxY2 = 0D;
            this.zedGraphControlHR.ScrollMinX = 0D;
            this.zedGraphControlHR.ScrollMinY = 0D;
            this.zedGraphControlHR.ScrollMinY2 = 0D;
            this.zedGraphControlHR.Size = new System.Drawing.Size(456, 227);
            this.zedGraphControlHR.TabIndex = 0;
            this.zedGraphControlHR.UseExtendedPrintDialog = true;
            // 
            // buttonSimStart
            // 
            this.buttonSimStart.Location = new System.Drawing.Point(27, 30);
            this.buttonSimStart.Name = "buttonSimStart";
            this.buttonSimStart.Size = new System.Drawing.Size(161, 33);
            this.buttonSimStart.TabIndex = 1;
            this.buttonSimStart.Text = "Simulation Start";
            this.buttonSimStart.UseVisualStyleBackColor = true;
            this.buttonSimStart.Click += new System.EventHandler(this.buttonSimStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 35F);
            this.label1.Location = new System.Drawing.Point(478, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1unit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heart Rate";
            // 
            // label1unit
            // 
            this.label1unit.AutoSize = true;
            this.label1unit.BackColor = System.Drawing.Color.Transparent;
            this.label1unit.Font = new System.Drawing.Font("Calibri", 20F);
            this.label1unit.Location = new System.Drawing.Point(517, 153);
            this.label1unit.Name = "label1unit";
            this.label1unit.Size = new System.Drawing.Size(81, 41);
            this.label1unit.TabIndex = 3;
            this.label1unit.Text = "bpm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F);
            this.label2.Location = new System.Drawing.Point(481, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "units/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 35F);
            this.label3.Location = new System.Drawing.Point(478, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 72);
            this.label3.TabIndex = 2;
            this.label3.Text = "00.00";
            // 
            // zedGraphControlBR
            // 
            this.zedGraphControlBR.AutoScroll = true;
            this.zedGraphControlBR.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControlBR.IsAntiAlias = true;
            this.zedGraphControlBR.IsShowHScrollBar = true;
            this.zedGraphControlBR.IsShowPointValues = true;
            this.zedGraphControlBR.IsSynchronizeXAxes = true;
            this.zedGraphControlBR.Location = new System.Drawing.Point(661, 324);
            this.zedGraphControlBR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlBR.Name = "zedGraphControlBR";
            this.zedGraphControlBR.ScrollGrace = 0D;
            this.zedGraphControlBR.ScrollMaxX = 0D;
            this.zedGraphControlBR.ScrollMaxY = 0D;
            this.zedGraphControlBR.ScrollMaxY2 = 0D;
            this.zedGraphControlBR.ScrollMinX = 0D;
            this.zedGraphControlBR.ScrollMinY = 0D;
            this.zedGraphControlBR.ScrollMinY2 = 0D;
            this.zedGraphControlBR.Size = new System.Drawing.Size(456, 227);
            this.zedGraphControlBR.TabIndex = 4;
            this.zedGraphControlBR.UseExtendedPrintDialog = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(646, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 253);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Breathing Rate";
            // 
            // zedGraphControlEKG
            // 
            this.zedGraphControlEKG.AutoScroll = true;
            this.zedGraphControlEKG.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControlEKG.IsAntiAlias = true;
            this.zedGraphControlEKG.IsShowHScrollBar = true;
            this.zedGraphControlEKG.IsShowPointValues = true;
            this.zedGraphControlEKG.IsSynchronizeXAxes = true;
            this.zedGraphControlEKG.Location = new System.Drawing.Point(843, 30);
            this.zedGraphControlEKG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlEKG.Name = "zedGraphControlEKG";
            this.zedGraphControlEKG.ScrollGrace = 0D;
            this.zedGraphControlEKG.ScrollMaxX = 0D;
            this.zedGraphControlEKG.ScrollMaxY = 0D;
            this.zedGraphControlEKG.ScrollMaxY2 = 0D;
            this.zedGraphControlEKG.ScrollMinX = 0D;
            this.zedGraphControlEKG.ScrollMinY = 0D;
            this.zedGraphControlEKG.ScrollMinY2 = 0D;
            this.zedGraphControlEKG.Size = new System.Drawing.Size(449, 262);
            this.zedGraphControlEKG.TabIndex = 6;
            this.zedGraphControlEKG.UseExtendedPrintDialog = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(834, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 288);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Electrocardiogram (EKG)";
            // 
            // zedGraphControlGSR
            // 
            this.zedGraphControlGSR.AutoScroll = true;
            this.zedGraphControlGSR.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControlGSR.IsAntiAlias = true;
            this.zedGraphControlGSR.IsShowHScrollBar = true;
            this.zedGraphControlGSR.IsShowPointValues = true;
            this.zedGraphControlGSR.IsSynchronizeXAxes = true;
            this.zedGraphControlGSR.Location = new System.Drawing.Point(257, 30);
            this.zedGraphControlGSR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlGSR.Name = "zedGraphControlGSR";
            this.zedGraphControlGSR.ScrollGrace = 0D;
            this.zedGraphControlGSR.ScrollMaxX = 0D;
            this.zedGraphControlGSR.ScrollMaxY = 0D;
            this.zedGraphControlGSR.ScrollMaxY2 = 0D;
            this.zedGraphControlGSR.ScrollMinX = 0D;
            this.zedGraphControlGSR.ScrollMinY = 0D;
            this.zedGraphControlGSR.ScrollMinY2 = 0D;
            this.zedGraphControlGSR.Size = new System.Drawing.Size(550, 262);
            this.zedGraphControlGSR.TabIndex = 8;
            this.zedGraphControlGSR.UseExtendedPrintDialog = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(242, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 288);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Galvanic Skin Response";
            // 
            // zedGraphControlEMG
            // 
            this.zedGraphControlEMG.AutoScroll = true;
            this.zedGraphControlEMG.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControlEMG.IsAntiAlias = true;
            this.zedGraphControlEMG.IsShowHScrollBar = true;
            this.zedGraphControlEMG.IsShowPointValues = true;
            this.zedGraphControlEMG.IsSynchronizeXAxes = true;
            this.zedGraphControlEMG.Location = new System.Drawing.Point(462, 583);
            this.zedGraphControlEMG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlEMG.Name = "zedGraphControlEMG";
            this.zedGraphControlEMG.ScrollGrace = 0D;
            this.zedGraphControlEMG.ScrollMaxX = 0D;
            this.zedGraphControlEMG.ScrollMaxY = 0D;
            this.zedGraphControlEMG.ScrollMaxY2 = 0D;
            this.zedGraphControlEMG.ScrollMinX = 0D;
            this.zedGraphControlEMG.ScrollMinY = 0D;
            this.zedGraphControlEMG.ScrollMinY2 = 0D;
            this.zedGraphControlEMG.Size = new System.Drawing.Size(372, 227);
            this.zedGraphControlEMG.TabIndex = 10;
            this.zedGraphControlEMG.UseExtendedPrintDialog = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(447, 565);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(404, 253);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Electromyograph";
            // 
            // zedGraphControlRESP
            // 
            this.zedGraphControlRESP.AutoScroll = true;
            this.zedGraphControlRESP.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControlRESP.IsAntiAlias = true;
            this.zedGraphControlRESP.IsShowHScrollBar = true;
            this.zedGraphControlRESP.IsShowPointValues = true;
            this.zedGraphControlRESP.IsSynchronizeXAxes = true;
            this.zedGraphControlRESP.Location = new System.Drawing.Point(28, 583);
            this.zedGraphControlRESP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlRESP.Name = "zedGraphControlRESP";
            this.zedGraphControlRESP.ScrollGrace = 0D;
            this.zedGraphControlRESP.ScrollMaxX = 0D;
            this.zedGraphControlRESP.ScrollMaxY = 0D;
            this.zedGraphControlRESP.ScrollMaxY2 = 0D;
            this.zedGraphControlRESP.ScrollMinX = 0D;
            this.zedGraphControlRESP.ScrollMinY = 0D;
            this.zedGraphControlRESP.ScrollMinY2 = 0D;
            this.zedGraphControlRESP.Size = new System.Drawing.Size(400, 227);
            this.zedGraphControlRESP.TabIndex = 12;
            this.zedGraphControlRESP.UseExtendedPrintDialog = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(13, 565);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(428, 253);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Breathing";
            // 
            // zedGraphControlST
            // 
            this.zedGraphControlST.AutoScroll = true;
            this.zedGraphControlST.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControlST.IsAntiAlias = true;
            this.zedGraphControlST.IsShowHScrollBar = true;
            this.zedGraphControlST.IsShowPointValues = true;
            this.zedGraphControlST.IsSynchronizeXAxes = true;
            this.zedGraphControlST.Location = new System.Drawing.Point(872, 583);
            this.zedGraphControlST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlST.Name = "zedGraphControlST";
            this.zedGraphControlST.ScrollGrace = 0D;
            this.zedGraphControlST.ScrollMaxX = 0D;
            this.zedGraphControlST.ScrollMaxY = 0D;
            this.zedGraphControlST.ScrollMaxY2 = 0D;
            this.zedGraphControlST.ScrollMinX = 0D;
            this.zedGraphControlST.ScrollMinY = 0D;
            this.zedGraphControlST.ScrollMinY2 = 0D;
            this.zedGraphControlST.Size = new System.Drawing.Size(418, 227);
            this.zedGraphControlST.TabIndex = 14;
            this.zedGraphControlST.UseExtendedPrintDialog = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(857, 565);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(450, 253);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Simulation time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "0 s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "0 s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Recording time:";
            // 
            // buttonSimStop
            // 
            this.buttonSimStop.Location = new System.Drawing.Point(27, 69);
            this.buttonSimStop.Name = "buttonSimStop";
            this.buttonSimStop.Size = new System.Drawing.Size(161, 33);
            this.buttonSimStop.TabIndex = 20;
            this.buttonSimStop.Text = "Simulation Stop";
            this.buttonSimStop.UseVisualStyleBackColor = true;
            this.buttonSimStop.Click += new System.EventHandler(this.buttonSimStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1320, 820);
            this.Controls.Add(this.buttonSimStop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zedGraphControlST);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.zedGraphControlRESP);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.zedGraphControlEMG);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.zedGraphControlGSR);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.zedGraphControlEKG);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.zedGraphControlBR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSimStart);
            this.Controls.Add(this.zedGraphControlHR);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biomarkers reading station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControlHR;
        private System.Windows.Forms.Button buttonSimStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ZedGraph.ZedGraphControl zedGraphControlBR;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZedGraph.ZedGraphControl zedGraphControlEKG;
        private System.Windows.Forms.GroupBox groupBox3;
        private ZedGraph.ZedGraphControl zedGraphControlGSR;
        private System.Windows.Forms.GroupBox groupBox4;
        private ZedGraph.ZedGraphControl zedGraphControlEMG;
        private System.Windows.Forms.GroupBox groupBox5;
        private ZedGraph.ZedGraphControl zedGraphControlRESP;
        private System.Windows.Forms.GroupBox groupBox6;
        private ZedGraph.ZedGraphControl zedGraphControlST;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSimStop;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

