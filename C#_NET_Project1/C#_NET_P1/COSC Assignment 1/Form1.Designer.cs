namespace COSC_Assignment_1
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
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.dayLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.Location = new System.Drawing.Point(65, 88);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(383, 173);
            this.listBoxValues.TabIndex = 0;
            this.listBoxValues.TabStop = false;
            this.toolTip.SetToolTip(this.listBoxValues, "Displays all entered sales values for the Week");
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(337, 370);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(111, 35);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "E&xit";
            this.toolTip.SetToolTip(this.btn_exit, "Exit Page (x)");
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.exitClick);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(65, 370);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(111, 35);
            this.btn_enter.TabIndex = 1;
            this.btn_enter.Text = "E&nter";
            this.toolTip.SetToolTip(this.btn_enter, "Enter Value (n)");
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.enterClick);
            // 
            // btn_reset
            // 
            this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_reset.Location = new System.Drawing.Point(201, 370);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(111, 35);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "&Reset";
            this.toolTip.SetToolTip(this.btn_reset, "Reset Page(r)");
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.resetClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(62, 39);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Video Game Sales";
            this.toolTip.SetToolTip(this.lbl1, "Video Game Sales");
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(187, 32);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(164, 20);
            this.txtEntry.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtEntry, "Enter sales value");
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(69, 322);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(379, 20);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.TabStop = false;
            this.txtOutput.Text = "Average Video Game Sales: $0.00";
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.txtOutput, "The average Video Game Sales");
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(402, 38);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(36, 13);
            this.dayLabel.TabIndex = 7;
            this.dayLabel.Text = "Day #";
            this.toolTip.SetToolTip(this.dayLabel, "Number of Values Entered");
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_reset;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listBoxValues);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Video Game Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

