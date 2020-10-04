using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sliding_Game
{
    

    public partial class GameScreen : Form
    {
        //Random Count to shuffle buttons
        Random rand = new Random();

        //start locations 
        Point but1Start = new Point(16, 16);
        Point but2Start = new Point(128, 16);
        Point but3Start = new Point(240, 16);
        Point but4Start = new Point(16, 138);
        Point but5Start = new Point(128, 138);
        Point but6Start = new Point(240, 138);
        Point but7Start = new Point(16, 260);
        Point but8Start = new Point(128, 260);
        Point but9Start = new Point(240, 260);

        public GameScreen()
        {
            InitializeComponent();
        }

        void Page_Load(Object sender, EventArgs e)
        {
            
        }

        int moveCounter = 0;
        bool Unicorn, Cerberus, Dragon, Pheonix = false;

        DialogResult changeImg = new DialogResult();

        private void btnPheonix_Click(object sender, EventArgs e)
        {
            Pheonix = true;

            if (Cerberus == true || Unicorn == true || Dragon == true)
            {
                changeImg = MessageBox.Show("Do you want to change the image?", "New Image", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (changeImg == DialogResult.Yes)
                {
                    Cerberus = false;
                    Dragon = false;
                    Unicorn = false;
                    setImage();
                    moveCounter = 0;
                    lblMCount.Text = moveCounter.ToString();
                }
            }
            else
            {
                setImage();
                
            }

            List<Button> buttonList = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, blankButton };
            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Enabled = true;
            }
            grBxGameArea.Visible = true;
        }

        private void btnDragon_Click(object sender, EventArgs e)
        {
            Dragon = true;

            if (Pheonix == true || Unicorn == true || Cerberus == true)
            {
                changeImg = MessageBox.Show("Do you want to change the image?", "New Image", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (changeImg == DialogResult.Yes)
                {
                    Pheonix = false;
                    Cerberus = false;
                    Unicorn = false;
                    setImage();
                    moveCounter = 0;
                    lblMCount.Text = moveCounter.ToString();
                }
            }
            else
            {
                setImage();
            }

            List<Button> buttonList = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, blankButton };
            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Enabled = true;
            }
            grBxGameArea.Visible = true;
        }

        private void btnUnicorn_Click(object sender, EventArgs e)
        {
            Unicorn = true;

            if (Pheonix == true || Cerberus == true || Dragon == true)
            {
                changeImg = MessageBox.Show("Do you want to change the image?", "New Image", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (changeImg == DialogResult.Yes)
                {
                    Pheonix = false;
                    Dragon = false;
                    Cerberus = false;
                    setImage();
                    moveCounter = 0;
                    lblMCount.Text = moveCounter.ToString();
                }
            }
            else
            {
                setImage();
                
            }

            List<Button> buttonList = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, blankButton };
            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Enabled = true;
            }
            grBxGameArea.Visible = true;
        }

        private void bntCerberus_Click(object sender, EventArgs e)
        {
            Cerberus = true;

            if (Pheonix == true || Unicorn == true || Dragon == true)
            {
                changeImg = MessageBox.Show("Do you want to change the image?", "New Image", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (changeImg == DialogResult.Yes)
                {
                    Pheonix = false;
                    Dragon = false;
                    Unicorn = false;
                    setImage();
                    moveCounter = 0;
                    lblMCount.Text = moveCounter.ToString();
                }
            }
            else
            {
                setImage();
                
            }

            List<Button> buttonList = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, blankButton };
            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Enabled = true;
            }
            grBxGameArea.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveButton(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveButton(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveButton(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveButton(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moveButton(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            moveButton(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            moveButton(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            moveButton(button8);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to stop playing?", "Done Already?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                StartScreen start = new StartScreen();
                start.ShowDialog();
                this.Close();
            }

        }

        private void blankButton_Click(object sender, EventArgs e)
        {
            List<Point> startLoc = new List<Point> { but1Start, but2Start, but3Start, but4Start, but5Start, but6Start, but7Start, but8Start};
            List<Point> buttLoca = new List<Point> { button1.Location, button2.Location, button3.Location, button4.Location, button5.Location, button6.Location, button7.Location, button8.Location };
            int correct = 0;
            for (int i = 0; i < buttLoca.Count - 1; i++)
            {
                if (buttLoca[i] == startLoc[i])
                    correct++;
            }

            if (correct == 7)
                MessageBox.Show("Congratulations!!! You have completed the puzzle in " + moveCounter + " moves.", "You Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (correct < 7 && correct > 0)
                MessageBox.Show("There is one or more blocks not in place.", "Not Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (correct == 0)
                MessageBox.Show("There is no blocks in its correct place.", "Not Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void setImage()
        {
            List<Button> buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8 };
            List<Image> cerberus = new List<Image> { Properties.Resources.Cerberus_1, Properties.Resources.Cerberus_2, Properties.Resources.Cerberus_3, Properties.Resources.Cerberus_4, Properties.Resources.Cerberus_5, Properties.Resources.Cerberus_6, Properties.Resources.Cerberus_7, Properties.Resources.Cerberus_8 };
            List<Image> pheonix = new List<Image> { Properties.Resources.Pheonix_1, Properties.Resources.Pheonix_2, Properties.Resources.Pheonix_3, Properties.Resources.Pheonix_4, Properties.Resources.Pheonix_5, Properties.Resources.Pheonix_6, Properties.Resources.Pheonix_7, Properties.Resources.Pheonix_8 };
            List<Image> dragon = new List<Image> { Properties.Resources.Dragon_1, Properties.Resources.Dragon_2, Properties.Resources.Dragon_3, Properties.Resources.Dragon_4, Properties.Resources.Dragon_5, Properties.Resources.Dragon_6, Properties.Resources.Dragon_7, Properties.Resources.Dragon_8 };
            List<Image> unicorn = new List<Image> { Properties.Resources.Unicorn_1, Properties.Resources.Unicorn_2, Properties.Resources.Unicorn_3, Properties.Resources.Unicorn_4, Properties.Resources.Unicorn_5, Properties.Resources.Unicorn_6, Properties.Resources.Unicorn_7, Properties.Resources.Unicorn_8 };

            if (Cerberus == true)
            {
                picturePanel.BackgroundImage = Properties.Resources.Cerberus;
                picturePanel.BackgroundImageLayout = ImageLayout.Zoom;

                for (int i = 0; i < 8; i++)
                {
                    buttons[i].BackgroundImage = cerberus[i];
                    buttons[i].BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            if (Unicorn == true)
            {
                picturePanel.BackgroundImage = Properties.Resources.Unicorn;
                picturePanel.BackgroundImageLayout = ImageLayout.Zoom;

                for (int i = 0; i < 8; i++)
                {
                    buttons[i].BackgroundImage = unicorn[i];
                    buttons[i].BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            if (Pheonix == true)
            {
                picturePanel.BackgroundImage = Properties.Resources.Pheonix;
                picturePanel.BackgroundImageLayout = ImageLayout.Zoom;

                for (int i = 0; i < 8; i++)
                {
                    buttons[i].BackgroundImage = pheonix[i];
                    buttons[i].BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            if (Dragon == true)
            {
                picturePanel.BackgroundImage = Properties.Resources.DragonPiece;
                picturePanel.BackgroundImageLayout = ImageLayout.Zoom;

                for (int i = 0; i < 8; i++)
                {
                    buttons[i].BackgroundImage = dragon[i];
                    buttons[i].BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Button button9 = blankButton;
            List<Button> buttonList = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9};
            int index = rand.Next(8);
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 0; j < buttonList.Count; j++)
                {
                    Button random = buttonList[index];
                    Point temp = random.Location;
                    Point temp2 = buttonList[j].Location;
                    buttonList[j].Location = temp;
                    random.Location = temp2;                    
                }
            }
            moveCounter = 0;
            lblMCount.Text = moveCounter.ToString();
        }

        private void moveButton(Button button)
        {
            //top row
            if (blankButton.Left == button.Right && blankButton.Top == button.Top)
            {
                Point temp = button.Location;
                Point temp2 = blankButton.Location;
                button.Location = temp2;
                blankButton.Location = temp;
                moveCounter++;
                lblMCount.Text = moveCounter.ToString();
            }
            else if (blankButton.Right == button.Left && blankButton.Top == button.Top)
            {
                Point temp = button.Location;
                Point temp2 = blankButton.Location;
                button.Location = temp2;
                blankButton.Location = temp;
                moveCounter++;
                lblMCount.Text = moveCounter.ToString();
            }
            //Bottom row
            else if (blankButton.Left == button.Right && blankButton.Bottom == button.Bottom)
            {
                Point temp = new Point(button.Location.X, button.Location.Y);
                Point temp2 = new Point(blankButton.Location.X, blankButton.Location.Y);
                button.Location = temp2;
                blankButton.Location = temp;
                moveCounter++;
                lblMCount.Text = moveCounter.ToString();
            }
            else if (blankButton.Right == button.Left && blankButton.Bottom == button.Bottom)
            {
                Point temp = new Point(button.Location.X, button.Location.Y);
                Point temp2 = new Point(blankButton.Location.X, blankButton.Location.Y);
                button.Location = temp2;
                blankButton.Location = temp;
                moveCounter++;
                lblMCount.Text = moveCounter.ToString();
            }

            //left side
            else if (blankButton.Left == button.Left && blankButton.Top == button.Bottom)
            {
                Point temp = new Point(button.Location.X, button.Location.Y);
                Point temp2 = new Point(blankButton.Location.X, blankButton.Location.Y);
                button.Location = temp2;
                blankButton.Location = temp;
                moveCounter++;
                lblMCount.Text = moveCounter.ToString();
            }
            else if (blankButton.Left == button.Left && blankButton.Bottom == button.Top)
            {
                Point temp = new Point(button.Location.X, button.Location.Y);
                Point temp2 = new Point(blankButton.Location.X, blankButton.Location.Y);
                button.Location = temp2;
                blankButton.Location = temp;
                moveCounter++;
                lblMCount.Text = moveCounter.ToString();
            }

            //right side
            else if (blankButton.Right == button.Right && blankButton.Top == button.Bottom)
            {
                Point temp = new Point(button.Location.X, button.Location.Y);
                Point temp2 = new Point(blankButton.Location.X, blankButton.Location.Y);
                button.Location = temp2;
                blankButton.Location = temp;
                moveCounter++;
                lblMCount.Text = moveCounter.ToString();
            }
            else if (blankButton.Right == button.Right && blankButton.Bottom == button.Top)
            {
                Point temp = new Point(button.Location.X, button.Location.Y);
                Point temp2 = new Point(blankButton.Location.X, blankButton.Location.Y);
                button.Location = temp2;
                blankButton.Location = temp;
                moveCounter++;
                lblMCount.Text = moveCounter.ToString();
            }
        }
    }

}
