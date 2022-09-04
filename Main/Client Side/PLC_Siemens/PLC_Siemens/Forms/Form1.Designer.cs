
namespace PLC_Siemens
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
            this.connect_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cpuType_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.disconnect_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ipAdress_TextBox = new System.Windows.Forms.TextBox();
            this.rack_TextBox = new System.Windows.Forms.TextBox();
            this.slot_TextBox = new System.Windows.Forms.TextBox();
            this.PresentValue_TextBox = new System.Windows.Forms.TextBox();
            this.setPoint_TextBox = new System.Windows.Forms.TextBox();
            this.read_Button = new System.Windows.Forms.Button();
            this.write_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cpuStatus_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.address_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.readReport_Button = new System.Windows.Forms.Button();
            this.writeReport_Button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect_Button
            // 
            this.connect_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.connect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connect_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.connect_Button.Location = new System.Drawing.Point(46, 318);
            this.connect_Button.Name = "connect_Button";
            this.connect_Button.Size = new System.Drawing.Size(171, 57);
            this.connect_Button.TabIndex = 18;
            this.connect_Button.Text = "Conncect";
            this.connect_Button.UseVisualStyleBackColor = false;
            this.connect_Button.Click += new System.EventHandler(this.connect_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "CPU:";
            // 
            // cpuType_ComboBox
            // 
            this.cpuType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpuType_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cpuType_ComboBox.FormattingEnabled = true;
            this.cpuType_ComboBox.Location = new System.Drawing.Point(168, 80);
            this.cpuType_ComboBox.Name = "cpuType_ComboBox";
            this.cpuType_ComboBox.Size = new System.Drawing.Size(263, 39);
            this.cpuType_ComboBox.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 104;
            this.label2.Text = "Rack:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 105;
            this.label3.Text = "IP Adress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 32);
            this.label4.TabIndex = 106;
            this.label4.Text = "Slot:";
            // 
            // disconnect_Button
            // 
            this.disconnect_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.disconnect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.disconnect_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disconnect_Button.Location = new System.Drawing.Point(260, 318);
            this.disconnect_Button.Name = "disconnect_Button";
            this.disconnect_Button.Size = new System.Drawing.Size(171, 57);
            this.disconnect_Button.TabIndex = 109;
            this.disconnect_Button.Text = "Disconnect";
            this.disconnect_Button.UseVisualStyleBackColor = false;
            this.disconnect_Button.Click += new System.EventHandler(this.disconnect_Button_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(482, -4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 527);
            this.label7.TabIndex = 110;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(522, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 32);
            this.label8.TabIndex = 111;
            this.label8.Text = "Present Value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(522, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 32);
            this.label9.TabIndex = 112;
            this.label9.Text = "Set Point:";
            // 
            // ipAdress_TextBox
            // 
            this.ipAdress_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipAdress_TextBox.Location = new System.Drawing.Point(168, 142);
            this.ipAdress_TextBox.Name = "ipAdress_TextBox";
            this.ipAdress_TextBox.Size = new System.Drawing.Size(263, 38);
            this.ipAdress_TextBox.TabIndex = 115;
            // 
            // rack_TextBox
            // 
            this.rack_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rack_TextBox.Location = new System.Drawing.Point(168, 188);
            this.rack_TextBox.Name = "rack_TextBox";
            this.rack_TextBox.Size = new System.Drawing.Size(263, 38);
            this.rack_TextBox.TabIndex = 116;
            // 
            // slot_TextBox
            // 
            this.slot_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.slot_TextBox.Location = new System.Drawing.Point(168, 235);
            this.slot_TextBox.Name = "slot_TextBox";
            this.slot_TextBox.Size = new System.Drawing.Size(263, 38);
            this.slot_TextBox.TabIndex = 117;
            // 
            // PresentValue_TextBox
            // 
            this.PresentValue_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PresentValue_TextBox.Location = new System.Drawing.Point(733, 185);
            this.PresentValue_TextBox.Name = "PresentValue_TextBox";
            this.PresentValue_TextBox.Size = new System.Drawing.Size(168, 38);
            this.PresentValue_TextBox.TabIndex = 118;
            // 
            // setPoint_TextBox
            // 
            this.setPoint_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setPoint_TextBox.Location = new System.Drawing.Point(733, 235);
            this.setPoint_TextBox.Name = "setPoint_TextBox";
            this.setPoint_TextBox.Size = new System.Drawing.Size(168, 38);
            this.setPoint_TextBox.TabIndex = 119;
            // 
            // read_Button
            // 
            this.read_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.read_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.read_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.read_Button.Location = new System.Drawing.Point(640, 318);
            this.read_Button.Name = "read_Button";
            this.read_Button.Size = new System.Drawing.Size(120, 57);
            this.read_Button.TabIndex = 120;
            this.read_Button.Text = "Read";
            this.read_Button.UseVisualStyleBackColor = false;
            this.read_Button.Click += new System.EventHandler(this.read_Button_Click);
            // 
            // write_Button
            // 
            this.write_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.write_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.write_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.write_Button.Location = new System.Drawing.Point(781, 318);
            this.write_Button.Name = "write_Button";
            this.write_Button.Size = new System.Drawing.Size(120, 57);
            this.write_Button.TabIndex = 121;
            this.write_Button.Text = "Write";
            this.write_Button.UseVisualStyleBackColor = false;
            this.write_Button.Click += new System.EventHandler(this.write_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(56, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 122;
            this.label5.Text = "CPU Status:";
            // 
            // cpuStatus_Label
            // 
            this.cpuStatus_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuStatus_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cpuStatus_Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cpuStatus_Label.Location = new System.Drawing.Point(236, 426);
            this.cpuStatus_Label.Name = "cpuStatus_Label";
            this.cpuStatus_Label.Size = new System.Drawing.Size(195, 38);
            this.cpuStatus_Label.TabIndex = 123;
            this.cpuStatus_Label.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(522, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 32);
            this.label6.TabIndex = 124;
            this.label6.Text = "Address:";
            // 
            // address_TextBox
            // 
            this.address_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.address_TextBox.Location = new System.Drawing.Point(733, 139);
            this.address_TextBox.Name = "address_TextBox";
            this.address_TextBox.Size = new System.Drawing.Size(168, 38);
            this.address_TextBox.TabIndex = 125;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(925, -16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 527);
            this.label10.TabIndex = 126;
            // 
            // readReport_Button
            // 
            this.readReport_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.readReport_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.readReport_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readReport_Button.Location = new System.Drawing.Point(965, 162);
            this.readReport_Button.Name = "readReport_Button";
            this.readReport_Button.Size = new System.Drawing.Size(194, 57);
            this.readReport_Button.TabIndex = 127;
            this.readReport_Button.Text = "Read Report";
            this.readReport_Button.UseVisualStyleBackColor = false;
            this.readReport_Button.Click += new System.EventHandler(this.readReport_Button_Click);
            // 
            // writeReport_Button
            // 
            this.writeReport_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.writeReport_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.writeReport_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.writeReport_Button.Location = new System.Drawing.Point(965, 271);
            this.writeReport_Button.Name = "writeReport_Button";
            this.writeReport_Button.Size = new System.Drawing.Size(194, 57);
            this.writeReport_Button.TabIndex = 128;
            this.writeReport_Button.Text = "Write Report";
            this.writeReport_Button.UseVisualStyleBackColor = false;
            this.writeReport_Button.Click += new System.EventHandler(this.writeReport_Button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(601, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 32);
            this.label11.TabIndex = 130;
            this.label11.Text = "CONTROL SİDE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(959, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 32);
            this.label12.TabIndex = 131;
            this.label12.Text = "REPORT SİDE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(97, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(273, 32);
            this.label13.TabIndex = 132;
            this.label13.Text = "CONNECTİON SİDE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1186, 491);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.writeReport_Button);
            this.Controls.Add(this.readReport_Button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.address_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cpuStatus_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.write_Button);
            this.Controls.Add(this.read_Button);
            this.Controls.Add(this.setPoint_TextBox);
            this.Controls.Add(this.PresentValue_TextBox);
            this.Controls.Add(this.slot_TextBox);
            this.Controls.Add(this.rack_TextBox);
            this.Controls.Add(this.ipAdress_TextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.disconnect_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpuType_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect_Button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siemens S7-1200";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cpuType_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button disconnect_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ipAdress_TextBox;
        private System.Windows.Forms.TextBox rack_TextBox;
        private System.Windows.Forms.TextBox slot_TextBox;
        private System.Windows.Forms.TextBox PresentValue_TextBox;
        private System.Windows.Forms.TextBox setPoint_TextBox;
        private System.Windows.Forms.Button read_Button;
        private System.Windows.Forms.Button write_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cpuStatus_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address_TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button readReport_Button;
        private System.Windows.Forms.Button writeReport_Button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

