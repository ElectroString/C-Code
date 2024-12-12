namespace GameMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxP2Symbol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxP1Symbol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxP2Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxP1Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCurrentTurn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNextTurn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxWinner = new System.Windows.Forms.TextBox();
            this.winnersList = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBoxP2Symbol);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBoxP1Symbol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxP2Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxP1Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(106, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Setup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Player 2 Symbol:";
            // 
            // txtBoxP2Symbol
            // 
            this.txtBoxP2Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxP2Symbol.Location = new System.Drawing.Point(414, 68);
            this.txtBoxP2Symbol.Name = "txtBoxP2Symbol";
            this.txtBoxP2Symbol.Size = new System.Drawing.Size(100, 22);
            this.txtBoxP2Symbol.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtBoxP2Symbol, "Symbol for player 2 to use");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Player 1 Symbol:";
            // 
            // txtBoxP1Symbol
            // 
            this.txtBoxP1Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxP1Symbol.Location = new System.Drawing.Point(414, 19);
            this.txtBoxP1Symbol.Name = "txtBoxP1Symbol";
            this.txtBoxP1Symbol.Size = new System.Drawing.Size(100, 22);
            this.txtBoxP1Symbol.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtBoxP1Symbol, "Symbol for player 1 to use");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Player 2 Name:";
            // 
            // txtBoxP2Name
            // 
            this.txtBoxP2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxP2Name.Location = new System.Drawing.Point(144, 63);
            this.txtBoxP2Name.Name = "txtBoxP2Name";
            this.txtBoxP2Name.Size = new System.Drawing.Size(100, 22);
            this.txtBoxP2Name.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtBoxP2Name, "Player 2 name");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Player 1 Name:";
            // 
            // txtBoxP1Name
            // 
            this.txtBoxP1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxP1Name.Location = new System.Drawing.Point(144, 19);
            this.txtBoxP1Name.Name = "txtBoxP1Name";
            this.txtBoxP1Name.Size = new System.Drawing.Size(100, 22);
            this.txtBoxP1Name.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBoxP1Name, "Player 1 Name");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnContinue);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btn9);
            this.groupBox2.Controls.Add(this.btn8);
            this.groupBox2.Controls.Add(this.btn7);
            this.groupBox2.Controls.Add(this.btn6);
            this.groupBox2.Controls.Add(this.btn5);
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxCurrentTurn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBoxNextTurn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(106, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Area";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(366, 159);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset all games");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(366, 116);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 37);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "&Continue";
            this.toolTip1.SetToolTip(this.btnContinue, "Continue to next Game");
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(366, 73);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 37);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "&Start";
            this.toolTip1.SetToolTip(this.btnStart, "Start the Game");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn9
            // 
            this.btn9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn9.Enabled = false;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(231, 192);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 59);
            this.btn9.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn9, "bottom right tile");
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn8.Enabled = false;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(150, 192);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 59);
            this.btn8.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn8, "bottom middle tile");
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn7.Enabled = false;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(69, 192);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 59);
            this.btn7.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btn7, "Bottom left Tile");
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn6.Enabled = false;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(231, 127);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 59);
            this.btn6.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn6, "middle right tile");
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn5.Enabled = false;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(150, 127);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 59);
            this.btn5.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn5, "middle tile");
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn4.Enabled = false;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(69, 127);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 59);
            this.btn4.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn4, "middle left tile");
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn3.Enabled = false;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(231, 62);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 59);
            this.btn3.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn3, "top right tile");
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn2.Enabled = false;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(150, 62);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 59);
            this.btn2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn2, "top middle tile");
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn1.Enabled = false;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(69, 62);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 59);
            this.btn1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn1, "top left tile");
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Turn";
            // 
            // txtBoxCurrentTurn
            // 
            this.txtBoxCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCurrentTurn.Location = new System.Drawing.Point(163, 16);
            this.txtBoxCurrentTurn.Name = "txtBoxCurrentTurn";
            this.txtBoxCurrentTurn.ReadOnly = true;
            this.txtBoxCurrentTurn.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCurrentTurn.TabIndex = 17;
            this.txtBoxCurrentTurn.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Next Turn";
            // 
            // txtBoxNextTurn
            // 
            this.txtBoxNextTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNextTurn.Location = new System.Drawing.Point(157, 279);
            this.txtBoxNextTurn.Name = "txtBoxNextTurn";
            this.txtBoxNextTurn.ReadOnly = true;
            this.txtBoxNextTurn.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNextTurn.TabIndex = 16;
            this.txtBoxNextTurn.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxWinner);
            this.groupBox3.Controls.Add(this.winnersList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(620, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 272);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Winner";
            // 
            // txtBoxWinner
            // 
            this.txtBoxWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWinner.Location = new System.Drawing.Point(70, 246);
            this.txtBoxWinner.Name = "txtBoxWinner";
            this.txtBoxWinner.ReadOnly = true;
            this.txtBoxWinner.Size = new System.Drawing.Size(100, 22);
            this.txtBoxWinner.TabIndex = 19;
            this.txtBoxWinner.TabStop = false;
            this.toolTip1.SetToolTip(this.txtBoxWinner, "Current Winner");
            // 
            // winnersList
            // 
            this.winnersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnersList.FormattingEnabled = true;
            this.winnersList.ItemHeight = 16;
            this.winnersList.Location = new System.Drawing.Point(6, 22);
            this.winnersList.Name = "winnersList";
            this.winnersList.Size = new System.Drawing.Size(164, 196);
            this.winnersList.TabIndex = 18;
            this.winnersList.TabStop = false;
            this.toolTip1.SetToolTip(this.winnersList, "Displays winners");
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(835, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxWinner;
        private System.Windows.Forms.ListBox winnersList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNextTurn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxP2Symbol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxP1Symbol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxP2Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxP1Name;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCurrentTurn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

