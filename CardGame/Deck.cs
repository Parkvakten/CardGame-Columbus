using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CardGame
{
    public class Deck
    {
        
        
       List<Card> deckList = new List<Card>();        
       public RichTextBox mainTextBox = new RichTextBox();

        /*
        Initialisera listan vid start av programmet.
        i & j i loopen börjar på 1 för att det minsta enum värdet för namnet för kortet och vilket typ den är börjar på 1.
        Man hade ju kunnat börja med att Ess ligger på 0, men oftast har Ess ett värde på 1 i kortspel så det kändes logiskt att göra så här.
            
        Yttre loopen körs 4 gången för (Hjärter, Ruter, Klöver och Spader)
        Innre loopen körs 13 gången för varje kort (Ess,1,2...Kung) och lägger till kortet i kortleken.
             
        */
        public bool InitializeDeck()
        {
            try { 
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    deckList.Add(new Card(j, i));
                }
                
            };
            mainTextBox.AppendText("Number of cards in the deck: " + deckList.Count + "\n" + "\n");
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }


        public bool Shuffle()
        {

            try { 
            mainTextBox.Clear();
            mainTextBox.AppendText("Shuffling deck...\n");


            Random random = new Random();

            /*
             Logik för att blanda korten:
             En variation på Fisher-Yates blandningen
             https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
             
             Börjar med att hämta totala längden av listan och sista positionen.
             Skapar ett random värde mellan 0-52
             Sparar värdet som finns på positionen av det slumpmässiga nummret
             Byt värdet på den första positionen till den slumpmässiga positionen
             */
            int count = deckList.Count;
            int last = count - 1;
            for (int i = 0; i < last; i++)
            {
                int j = random.Next(last + 1);
                Card value = deckList[j];
                deckList[j] = deckList[i];
                deckList[i] = value;

            }
            
            foreach(var card in deckList)
            {                
                mainTextBox.AppendText(card.cardName + " of " + card.cardSuite + "\n");
            }
                return true;
            }catch(Exception ex)
            {
                throw ex;
            }


        }

        public bool Pull()
        {
            /*
             Logik för att dra ett kort:
             Kolla om det finns några kort kvar i kortleken.
             Dra det första kortet som finns i kortleken(Det högst upp i kortleken)
             */
            try { 
            if (deckList.Any()) { 
            Card pulledCard = deckList.First();
            
            deckList.RemoveAt(0);                
                mainTextBox.AppendText("\n"+pulledCard.cardName + " of " + pulledCard.cardSuite + "\n");
                mainTextBox.AppendText("Number of cards in the deck: " + deckList.Count + "\n" + "\n");
            }
            else
            {
                mainTextBox.AppendText("\nNo more cards in the deck, adding all cards back to the deck...");
                InitializeDeck();
            }
                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Sort()
        {
            try
            {
                mainTextBox.Clear();
                mainTextBox.AppendText("\nSorting deck....\n");
                /*
                 Logik för sortering:
                 Använde Linq för enkel sortering av listan.
                 Sorteringen görs först på värde 1,2,3,4.....13
                 Sedan på Hjärter, Ruter, Klöver och Spader

                 */
                deckList = deckList.OrderBy(x => x.cardName).OrderBy(y => y.cardSuite).ToList();

                foreach (var card in deckList)
                {
                    mainTextBox.AppendText(card.cardName + " of " + card.cardSuite + "\n");
                }
                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
