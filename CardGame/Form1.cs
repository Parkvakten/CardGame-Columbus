using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        Deck deck;
        
        public Form1()
        {            
            InitializeComponent();
            deck = new Deck
            {
                mainTextBox = mainTextBox
            };
            deck.InitializeDeck();
            
            

        }

        private void PullCardButton_Click(object sender, EventArgs e)
        {
            deck.Pull();
        }

        private void ShuffleDeckButton_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
        }

        private void SortDeckButton_Click(object sender, EventArgs e)
        {
            deck.Sort();
        }
    }
}
