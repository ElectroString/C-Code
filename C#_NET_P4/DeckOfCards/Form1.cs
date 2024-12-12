/*
 * Cam Davies
 * 8/11/2024
 * Card Dealing System
 */



namespace DeckOfCards
{

    public partial class Form1 : Form
    {
        // Creates Custom Deck and Cards
        CustomDeck deck = new CustomDeck();
        List<Card> cards = new List<Card>();

        // Initializes Form
        public Form1()
        {

            InitializeComponent();
            cards = deck.Cards.ToList();


        }

        // Adds a custom card to the deck using user inputs
        private void btn_addCustom_Click(object sender, EventArgs e)
        {
            if (!isStringValid(txtBox_Suit.Text) || !isStringValid(txtBox_rank.Text))
            {
                MessageBox.Show("Error: Fields cannot be left blank");
            }
            else
            {
                cards.Add(new Card(txtBox_Suit.Text, txtBox_rank.Text));
                txtBox_Suit.Text = string.Empty;
                txtBox_rank.Text = string.Empty;
            }

        }

        // Adds a user selected amount of cards to the users Dealt cards
        private void btn_dealCards_Click(object sender, EventArgs e)
        {
            if (!isIntValid(txtBox_draw.Text))
            {
                MessageBox.Show("Error: Input must be an integer");
            }
            else
            {
                if (Convert.ToInt32((string)txtBox_draw.Text) > cards.Count)
                {
                    MessageBox.Show($"Error, Not enough Cards, available remaining cards: {cards.Count}");
                }
                else
                {
                    for (int i = 0; i < Convert.ToInt32((string)txtBox_draw.Text); i++)
                    {
                        ListViewItem item = new ListViewItem(cards[0].Rank);
                        item.SubItems.Add(cards[0].Suit);
                        listViewDealtCards.Items.Add(item);
                        cards.RemoveAt(0);
                    }
                }
            }
        }

        // Shuffles the current deck
        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            int count = cards.Count;
            Random random = new Random();

            while (count > 1)
            {
                count--;
                int k = random.Next(count + 1);
                Card value = cards[k];
                cards[k] = cards[count];
                cards[count] = value;

            }
        }
        // Views the current deck order
        private void btn_viewDeck_Click(object sender, EventArgs e)
        {
            listViewDeck.Items.Clear();
            foreach (Card card in cards)
            {
                ListViewItem item = new ListViewItem(card.Rank);
                item.SubItems.Add(card.Suit);
                listViewDeck.Items.Add(item);
                //listViewDeck.Items.Add(card.ToString());
            }
        }

        // Resets the deck and all hands. Deletes User created Cards
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtBox_draw.Text = string.Empty;
            txtBox_rank.Text = string.Empty;
            txtBox_Suit.Text = string.Empty;

            listViewDeck.Items.Clear();
            listViewDealtCards.Items.Clear();

            cards.Clear();
            cards = deck.Cards.ToList();
        }

        // Exits the Application
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Checks if a string is empty or  whitespace
        private bool isStringValid(String input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }
            return true;
        }

        // Checks if a inputted string is a valid integer
        private bool isIntValid(String input)
        {
            try
            {
                Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




    }

}
