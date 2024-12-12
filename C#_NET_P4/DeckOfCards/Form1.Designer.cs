namespace DeckOfCards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listViewDeck = new ListView();
            Rank = new ColumnHeader();
            Suit = new ColumnHeader();
            listViewDealtCards = new ListView();
            cardsDealtRank = new ColumnHeader();
            cardsDealtSuit = new ColumnHeader();
            groupBoxCard = new GroupBox();
            txtBox_rank = new TextBox();
            txtBox_Suit = new TextBox();
            lbl_Rank = new Label();
            lbl_suit = new Label();
            btn_addCustom = new Button();
            btn_viewDeck = new Button();
            btn_shuffle = new Button();
            btn_Reset = new Button();
            btn_Exit = new Button();
            btn_dealCards = new Button();
            lbl_Deck = new Label();
            lbl_dealtCards = new Label();
            lbl_Draw = new Label();
            txtBox_draw = new TextBox();
            toolTip1 = new ToolTip(components);
            groupBoxCard.SuspendLayout();
            SuspendLayout();
            // 
            // listViewDeck
            // 
            listViewDeck.Alignment = ListViewAlignment.Left;
            listViewDeck.Columns.AddRange(new ColumnHeader[] { Rank, Suit });
            listViewDeck.Location = new Point(465, 106);
            listViewDeck.Name = "listViewDeck";
            listViewDeck.RightToLeft = RightToLeft.No;
            listViewDeck.Size = new Size(183, 286);
            listViewDeck.TabIndex = 0;
            listViewDeck.TabStop = false;
            toolTip1.SetToolTip(listViewDeck, "Current Deck");
            listViewDeck.UseCompatibleStateImageBehavior = false;
            listViewDeck.View = View.Details;
            // 
            // Rank
            // 
            Rank.Text = "Rank";
            // 
            // Suit
            // 
            Suit.Text = "Suit";
            Suit.Width = 100;
            // 
            // listViewDealtCards
            // 
            listViewDealtCards.Columns.AddRange(new ColumnHeader[] { cardsDealtRank, cardsDealtSuit });
            listViewDealtCards.Location = new Point(94, 300);
            listViewDealtCards.Name = "listViewDealtCards";
            listViewDealtCards.Size = new Size(246, 92);
            listViewDealtCards.TabIndex = 1;
            listViewDealtCards.TabStop = false;
            toolTip1.SetToolTip(listViewDealtCards, "Cards Dealt");
            listViewDealtCards.UseCompatibleStateImageBehavior = false;
            listViewDealtCards.View = View.Details;
            // 
            // cardsDealtRank
            // 
            cardsDealtRank.Text = "Rank";
            // 
            // cardsDealtSuit
            // 
            cardsDealtSuit.Text = "Suit";
            cardsDealtSuit.Width = 100;
            // 
            // groupBoxCard
            // 
            groupBoxCard.Controls.Add(txtBox_rank);
            groupBoxCard.Controls.Add(txtBox_Suit);
            groupBoxCard.Controls.Add(lbl_Rank);
            groupBoxCard.Controls.Add(lbl_suit);
            groupBoxCard.Controls.Add(btn_addCustom);
            groupBoxCard.Location = new Point(94, 61);
            groupBoxCard.Name = "groupBoxCard";
            groupBoxCard.Size = new Size(348, 119);
            groupBoxCard.TabIndex = 2;
            groupBoxCard.TabStop = false;
            groupBoxCard.Text = "Card";
            // 
            // txtBox_rank
            // 
            txtBox_rank.Location = new Point(60, 74);
            txtBox_rank.Name = "txtBox_rank";
            txtBox_rank.Size = new Size(100, 23);
            txtBox_rank.TabIndex = 1;
            toolTip1.SetToolTip(txtBox_rank, "Ad the Rank of the Card");
            // 
            // txtBox_Suit
            // 
            txtBox_Suit.Location = new Point(60, 42);
            txtBox_Suit.Name = "txtBox_Suit";
            txtBox_Suit.Size = new Size(100, 23);
            txtBox_Suit.TabIndex = 0;
            toolTip1.SetToolTip(txtBox_Suit, "Add A Suit of the Card");
            // 
            // lbl_Rank
            // 
            lbl_Rank.AutoSize = true;
            lbl_Rank.Location = new Point(15, 77);
            lbl_Rank.Name = "lbl_Rank";
            lbl_Rank.Size = new Size(33, 15);
            lbl_Rank.TabIndex = 11;
            lbl_Rank.Text = "Rank";
            // 
            // lbl_suit
            // 
            lbl_suit.AutoSize = true;
            lbl_suit.Location = new Point(15, 45);
            lbl_suit.Name = "lbl_suit";
            lbl_suit.Size = new Size(27, 15);
            lbl_suit.TabIndex = 10;
            lbl_suit.Text = "Suit";
            // 
            // btn_addCustom
            // 
            btn_addCustom.Location = new Point(213, 45);
            btn_addCustom.Name = "btn_addCustom";
            btn_addCustom.Size = new Size(103, 35);
            btn_addCustom.TabIndex = 2;
            btn_addCustom.Text = "Add Custom";
            toolTip1.SetToolTip(btn_addCustom, "Add the Custom Card to the Deck");
            btn_addCustom.UseVisualStyleBackColor = true;
            btn_addCustom.Click += btn_addCustom_Click;
            // 
            // btn_viewDeck
            // 
            btn_viewDeck.Location = new Point(674, 106);
            btn_viewDeck.Name = "btn_viewDeck";
            btn_viewDeck.Size = new Size(100, 37);
            btn_viewDeck.TabIndex = 5;
            btn_viewDeck.Text = "&View Deck";
            toolTip1.SetToolTip(btn_viewDeck, "View the Current Deck ");
            btn_viewDeck.UseVisualStyleBackColor = true;
            btn_viewDeck.Click += btn_viewDeck_Click;
            // 
            // btn_shuffle
            // 
            btn_shuffle.Location = new Point(674, 163);
            btn_shuffle.Name = "btn_shuffle";
            btn_shuffle.Size = new Size(100, 37);
            btn_shuffle.TabIndex = 6;
            btn_shuffle.Text = "&Shuffle";
            toolTip1.SetToolTip(btn_shuffle, "Shuffle the current Deck");
            btn_shuffle.UseVisualStyleBackColor = true;
            btn_shuffle.Click += btn_shuffle_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(674, 223);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(100, 37);
            btn_Reset.TabIndex = 7;
            btn_Reset.Text = "Reset";
            toolTip1.SetToolTip(btn_Reset, "Resets the Application (deletes Custom Cards)");
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(674, 281);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(100, 37);
            btn_Exit.TabIndex = 8;
            btn_Exit.Text = "E&xit";
            toolTip1.SetToolTip(btn_Exit, "Exits the application");
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_dealCards
            // 
            btn_dealCards.Location = new Point(307, 208);
            btn_dealCards.Name = "btn_dealCards";
            btn_dealCards.Size = new Size(103, 38);
            btn_dealCards.TabIndex = 4;
            btn_dealCards.Text = "&Deal";
            toolTip1.SetToolTip(btn_dealCards, "Deals the amount of cards chosen");
            btn_dealCards.UseVisualStyleBackColor = true;
            btn_dealCards.Click += btn_dealCards_Click;
            // 
            // lbl_Deck
            // 
            lbl_Deck.AutoSize = true;
            lbl_Deck.Location = new Point(465, 88);
            lbl_Deck.Name = "lbl_Deck";
            lbl_Deck.Size = new Size(33, 15);
            lbl_Deck.TabIndex = 8;
            lbl_Deck.Text = "Deck";
            // 
            // lbl_dealtCards
            // 
            lbl_dealtCards.AutoSize = true;
            lbl_dealtCards.Location = new Point(94, 281);
            lbl_dealtCards.Name = "lbl_dealtCards";
            lbl_dealtCards.Size = new Size(67, 15);
            lbl_dealtCards.TabIndex = 9;
            lbl_dealtCards.Text = "Cards Dealt";
            // 
            // lbl_Draw
            // 
            lbl_Draw.AutoSize = true;
            lbl_Draw.Location = new Point(109, 220);
            lbl_Draw.Name = "lbl_Draw";
            lbl_Draw.Size = new Size(34, 15);
            lbl_Draw.TabIndex = 11;
            lbl_Draw.Text = "Draw";
            // 
            // txtBox_draw
            // 
            txtBox_draw.Location = new Point(154, 217);
            txtBox_draw.Name = "txtBox_draw";
            txtBox_draw.Size = new Size(100, 23);
            txtBox_draw.TabIndex = 3;
            toolTip1.SetToolTip(txtBox_draw, "Number of Cards you'd like to Draw");
            // 
            // Form1
            // 
            AcceptButton = btn_addCustom;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Reset;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox_draw);
            Controls.Add(lbl_Draw);
            Controls.Add(lbl_dealtCards);
            Controls.Add(lbl_Deck);
            Controls.Add(btn_dealCards);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Reset);
            Controls.Add(btn_shuffle);
            Controls.Add(btn_viewDeck);
            Controls.Add(groupBoxCard);
            Controls.Add(listViewDealtCards);
            Controls.Add(listViewDeck);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deck Builder";
            groupBoxCard.ResumeLayout(false);
            groupBoxCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewDeck;
        private ListView listViewDealtCards;
        private GroupBox groupBoxCard;
        private Label lbl_suit;
        private Button btn_addCustom;
        private Button btn_viewDeck;
        private Button btn_shuffle;
        private Button btn_Reset;
        private Button btn_Exit;
        private Button btn_dealCards;
        private Label lbl_Deck;
        private Label lbl_dealtCards;
        private TextBox txtBox_rank;
        private TextBox txtBox_Suit;
        private Label lbl_Rank;
        private Label lbl_Draw;
        private TextBox txtBox_draw;
        private ColumnHeader Rank;
        private ColumnHeader Suit;
        private ColumnHeader cardsDealtRank;
        private ColumnHeader cardsDealtSuit;
        private ToolTip toolTip1;
    }
}
