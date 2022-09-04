
namespace PLC_Siemens.Forms
{
    partial class ReadReportPage
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
            this.records_ListView = new System.Windows.Forms.ListView();
            this.totalRegistryCount_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // records_ListView
            // 
            this.records_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.records_ListView.HideSelection = false;
            this.records_ListView.Location = new System.Drawing.Point(12, 15);
            this.records_ListView.Name = "records_ListView";
            this.records_ListView.Size = new System.Drawing.Size(776, 420);
            this.records_ListView.TabIndex = 19;
            this.records_ListView.UseCompatibleStateImageBehavior = false;
            // 
            // totalRegistryCount_TextBox
            // 
            this.totalRegistryCount_TextBox.Enabled = false;
            this.totalRegistryCount_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalRegistryCount_TextBox.Location = new System.Drawing.Point(314, 452);
            this.totalRegistryCount_TextBox.Name = "totalRegistryCount_TextBox";
            this.totalRegistryCount_TextBox.Size = new System.Drawing.Size(141, 38);
            this.totalRegistryCount_TextBox.TabIndex = 129;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 32);
            this.label6.TabIndex = 128;
            this.label6.Text = "Total Registry Count:";
            // 
            // ReadReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.totalRegistryCount_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.records_ListView);
            this.MaximizeBox = false;
            this.Name = "ReadReportPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadReportPage";
            this.Load += new System.EventHandler(this.ReadReportPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView records_ListView;
        private System.Windows.Forms.TextBox totalRegistryCount_TextBox;
        private System.Windows.Forms.Label label6;
    }
}