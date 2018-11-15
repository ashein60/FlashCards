using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        private static List<FlashCard> cards = new List<FlashCard>();
        private static string fileName = "empty"; 

        public static List<FlashCard> Cards
        {
            get { return cards; }
            set { cards = value; }
        }
        public static string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        string current; //can be title or text
        int currentCard; //current card in the list

        public MainForm()
        {
            InitializeComponent();
            current = "title";
            currentCard = -1; 
            mainFlashCard.Enabled = false;
            mainFlashCard.Visible = false;
        }

        //Methods
        private void UpdateMainFlashCard()
        {
            if (cards.Count == 0)
            {
                mainFlashCard.Enabled = false;
                mainFlashCard.Visible = false;
                currentCard = -1;
            }
            else
            {
                if (current == "title")
                {
                    mainFlashCard.Text = cards[currentCard].Title;
                }
                else
                {
                    mainFlashCard.Text = cards[currentCard].Text;
                }
            }

            currentSlide.Text = (currentCard + 1) + "/" + cards.Count();
        }
        private void SaveAsFile()
        {
            SaveAsOpen saveAs = new SaveAsOpen("save");
            saveAs.ShowDialog(this);
        }
        private void SaveFile()
        {
            if (FileName != "empty")
            {
                string[] everything = new string[cards.Count * 2]; //each card has a front and a back

                for (int i = 0; i < cards.Count; i++)
                {
                    everything[i * 2] = cards[i].Title;
                    everything[i * 2 + 1] = cards[i].Text;
                }

                File.WriteAllLines(fileName, everything);
            }
            else
            {
                SaveAsFile();
            }
        }

        private void ScrollLeft()
        {
            if (cards.Count > 1)
            {
                if (currentCard == 0)
                {
                    currentCard = cards.Count - 1;
                }
                else
                {
                    currentCard--;
                }

                UpdateMainFlashCard();
            } 
        }
        private void ScrollRight()
        {
            if (cards.Count > 1)
            {
                if (currentCard == cards.Count - 1)
                {
                    currentCard = 0;
                }
                else
                {
                    currentCard++;
                }

                UpdateMainFlashCard();
            }
        }

        //Typing
        private void Type_MainFlashCard(object sender, EventArgs e) //saves to the FlashCard
        {
            if (current == "title")
            {
                cards[currentCard].Title = mainFlashCard.Text;
            }
            else
            {
                cards[currentCard].Text = mainFlashCard.Text;
            }
        }

        //Key Events
        private void Key_Down(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //arrow key scroll if not typing
        {
            if (!mainFlashCard.Focused)
            {
                if (keyData == Keys.Left)
                {
                    ScrollLeft();
                    return true;
                }
                else if (keyData == Keys.Right)
                {
                    ScrollRight();
                    return true;
                }
                else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        //Button Events
        private void Click_AddNote(object sender, EventArgs e)
        {
            if (!mainFlashCard.Enabled)
            {
                mainFlashCard.Enabled = true;
                mainFlashCard.Visible = true;
            }

            cards.Add(new FlashCard());
            currentCard = cards.Count - 1;
            UpdateMainFlashCard();
        }
        private void Click_DeleteNote(object sender, EventArgs e)
        {
            if (cards.Count == 0)
            {
                currentCard = -1;
            }
            else
            {
                cards.RemoveAt(currentCard);

                if (currentCard == 1)
                {
                    currentCard = 0;
                }
                else
                {
                    ScrollLeft();
                }

                UpdateMainFlashCard();
            }
        }
        private void Click_CurrentWords(object sender, EventArgs e) //Show title or text
        {
            if (currentWords.Text == "Showing Title")
            {
                currentWords.Text = "Showing Text";
                current = "text";
            }
            else
            {
                currentWords.Text = "Showing Title";
                current = "title";
            }

            UpdateMainFlashCard();
        }

        private void Click_Left(object sender, MouseEventArgs e)
        {
            ScrollLeft();
        }
        private void Click_Right(object sender, MouseEventArgs e)
        {
            ScrollRight();
        }

        private void Click_New(object sender, EventArgs e) //reset everything
        {
            currentCard = -1;
            cards.Clear();
            UpdateMainFlashCard();
        }
        private void Click_Open(object sender, EventArgs e) //opens the desired file
        {
            SaveAsOpen saveAs = new SaveAsOpen("open");
            saveAs.ShowDialog(this);

            if (cards.Count != 0) //if the user opens the file
            {
                currentCard = 0;
                current = "title";
                UpdateMainFlashCard();

                if (!mainFlashCard.Enabled)
                {
                    mainFlashCard.Enabled = true;
                    mainFlashCard.Visible = true;
                }
            }
        }
        private void Click_Save(object sender, EventArgs e) //save to current file
        {
            SaveFile();
        }
        private void Click_SaveAs(object sender, EventArgs e) //handles creating the file
        {
            SaveAsFile();
        }
    }
}
