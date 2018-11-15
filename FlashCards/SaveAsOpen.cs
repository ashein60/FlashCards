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
    public partial class SaveAsOpen : Form
    {
        private string type; //save, open

        public SaveAsOpen(string type)
        {
            InitializeComponent();

            this.type = type;

            if (type == "save")
            {
                saveOpen.Text = "Save";
            }
            else
            {
                saveOpen.Text = "Open";
            }
        }

        private void SaveOpen()
        {
            if (fileName.Text.Contains(".txt"))
            {
                if (type == "save") //save
                {
                    string[] everything = new string[MainForm.Cards.Count * 2]; //each card has a front and a back

                    for (int i = 0; i < MainForm.Cards.Count; i++)
                    {
                        everything[i * 2] = MainForm.Cards[i].Title;
                        everything[i * 2 + 1] = MainForm.Cards[i].Text;
                    }

                    File.WriteAllLines(fileName.Text, everything);

                    Close(); //closes the modal window
                    MainForm.FileName = fileName.Text; //gives the MainForm access to the current file name
                }
                else //open
                {
                    if (File.Exists(fileName.Text)) //if the file exists
                    {
                        MainForm.Cards.Clear(); //clears the list for the new file

                        string[] everything = File.ReadAllLines(fileName.Text);

                        for (int i = 0; i < everything.Length / 2; i++)
                        {
                            MainForm.Cards.Add(new FlashCard());
                            MainForm.Cards[i].Title = everything[i * 2];
                            MainForm.Cards[i].Text = everything[i * 2 + 1];
                        }

                        Close(); //closes the modal window
                        MainForm.FileName = fileName.Text; //gives the MainForm access to the current file name
                    }
                    else //file doesn't exist
                    {
                        fileName.Text = "invalid.txt";
                    }
                }

            }
            else
            {
                fileName.Text = "invalid.txt";
            }
        }

        private void Click_SaveOpen(object sender, MouseEventArgs e)
        {
            SaveOpen();
        }
        private void Text_KeyDown(object sender, KeyEventArgs e) //press enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveOpen();
            }
        }
    }
}
