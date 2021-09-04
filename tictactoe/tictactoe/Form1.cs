/* clarence yang circa 1/6/20
 * 
 * tic tac toe with AI
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public bool[] togglednoughts = new bool[9]; //toggle for all buttons
        public bool[] toggledcrosses = new bool[9]; //toggle for all buttons

        public int currentplayer = 0; //current player index
        int round = 0; //we begin on 0

        int noughtsScore = 0;
        int crossesScore = 0;

        bool playingwithbot = false;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < togglednoughts.Length; i++)
            {
                togglednoughts[i] = false;
                toggledcrosses[i] = false;
            }

            resetPanels();

            label3.ForeColor = SystemColors.Highlight;
            label4.ForeColor = SystemColors.ControlText;

            if (playingwithbot)
            {
                aiBestMove();
            }
        }

        public void resetPanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    c.BackgroundImage = null;
                }
            }
        }

        //click
        private void TopMiddle_Click(object sender, EventArgs e) //click
        {
            checkBox1.Enabled = false;
            int index = 0; //0 --> 8
            var senderpanel = (Panel)sender;

            switch (senderpanel.Name) 
            {
                case "TopLeft":
                    index = 0;
                    break;
                case "TopMiddle":
                    index = 1;
                    break;
                case "TopRight":
                    index = 2;
                    break;
                case "MiddleLeft":
                    index = 3;
                    break;
                case "MiddleMiddle":
                    index = 4;
                    break;
                case "MiddleRight":
                    index = 5;
                    break;
                case "BottomLeft":
                    index = 6;
                    break;
                case "BottomMiddle":
                    index = 7;
                    break;
                case "BottomRight":
                    index = 8;
                    break;
            }

            if (togglednoughts[index] == false && toggledcrosses[index] == false)
            {
                
                if (currentplayer == 0) //noughts
                {
                    togglednoughts[index] = true;
                    
                    senderpanel.BackgroundImage = Properties.Resources.o__2_;
                }
                else //crosses
                {
                    toggledcrosses[index] = true;
                    
                    senderpanel.BackgroundImage = Properties.Resources.cross;
                }
                round++;
                WinAlgorithm();
                

            }
            else
            {
                //MessageBox.Show("This one is already occupied.");
            }

            

        }
        //

        //the algorithm that checks if a player won
        public void WinAlgorithm()
        {

            /*This algorith checks whether the user won
             * we will loop through all the positions a user has occupied
             * we find one position and loop through all the possible next positions [left, right, up, down]
             * we will check if there is a toggled position at any of the other positions
             */

            if (currentplayer == 0)
            {
                //do it for the first player
                for (int i = 0; i < togglednoughts.Length; i++)
                {
                    if (togglednoughts[i] == true)
                    {
                        
                        //loop through all conditions, such as if number is in the top row, or if it is on the edges
                        if (scanHorizontal(i, currentplayer) || scanDiagL(i, currentplayer) || scanVertical(i, currentplayer) || scanDiagR(i, currentplayer))
                        {
                            //winner
                            //MessageBox.Show("winner!");
                            endgame(0);
                            return;
                        
                        }


                    }
                }

                label4.ForeColor = SystemColors.Highlight;
                label3.ForeColor = SystemColors.ControlText;
                currentplayer = 1;

                //for the bot
                if (playingwithbot)
                {
                    aiBestMove(); //ai will move
                }
            }
            else
            {
                //do it for the second player
                //do it for the first player
                for (int i = 0; i < toggledcrosses.Length; i++)
                {
                    if (toggledcrosses[i] == true)
                    {

                        //loop through all conditions, such as if number is in the top row, or if it is on the edges
                        if (scanHorizontal(i, currentplayer) || scanDiagL(i, currentplayer) || scanVertical(i, currentplayer) || scanDiagR(i, currentplayer))
                        {
                            //winner
                            //MessageBox.Show("winner!");
                            endgame(1);
                            return; 
                        }


                    }
                }
                label3.ForeColor = SystemColors.Highlight;
                label4.ForeColor = SystemColors.ControlText;
                currentplayer = 0;
            }


            if (round == 9)
            {
                //if we have reached the end game
                //end game
                endgame(2);
            }

        }

        public bool scanHorizontal(int index, int player) //works
        {
            bool scanleft = true;
            bool scanright = true;

            int ofthree = 1; //by default, the selected or placed down selection constitutes on one of three in a row.

            if (index == 0 || (index - 3) == 0 || (index-6 == 0)) 
            {
                //on the left side
                //MessageBox.Show("left");
                scanleft = false;
                
            }
            else if (index == 2 || (index - 3) == 2 || (index - 6 == 2))
            {
                //right side
                //MessageBox.Show("right");
                scanright = false;
            }

           

            if (scanleft) //index must NOT be on the left side
            {
                //we are scanning for left
                if (player == 0)
                {
                    if (togglednoughts[index - 1]) //true?
                    {
                        ofthree += 1;
                        //MessageBox.Show($"left{index} true 0");
                        if (scanright == false) //is this at the far right?
                        {
                            if (togglednoughts[index - 2])
                            {
                                //MessageBox.Show($"left{index} true 2 0");
                                ofthree +=1;
                            }
                        }
                    }
                }
                else //other player
                {
                    if (toggledcrosses[index - 1]) //true?
                    {
                        ofthree+=1;
                        //MessageBox.Show($"left{index} true x");
                        if (scanright == false) //is this at the far right?
                        {
                            if (toggledcrosses[index - 2])
                            {
                                ofthree+=1;
                                //MessageBox.Show($"left{index} true 2 x");
                            }
                        }
                    }
                }
            }

            if (scanright) //scanning right, must not be on right side
            {
                
                if (player == 0)
                {
                    if (togglednoughts[index + 1]) //true?
                    {
                        ofthree+=1;
                        //MessageBox.Show($"right{index} true 0");
                        if (scanleft == false) //is this at the far left?
                        {
                            if (togglednoughts[index + 2])
                            {
                                ofthree+=1;
                                //MessageBox.Show($"right{index} true 2 0");
                            }
                        }
                    }
                }
                else
                {
                    if (toggledcrosses[index + 1]) //true?
                    {
                        ofthree+=1;
                        //MessageBox.Show($"right{index} true x");
                        if (scanleft == false) //is this at the far right?
                        {
                            if (toggledcrosses[index + 2])
                            {
                                ofthree+=1;
                                //MessageBox.Show($"right{index} true 2 x");
                            }
                        }
                    }
                }
            }

            if (ofthree == 3)
            {
                //we got a row for horizontal
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public bool scanVertical(int index, int player) 
        {
            bool scandown = true;
            bool scanup = true;

            int ofthree = 1; //by default, the selected or placed down selection constitutes on one of three in a row

            if (index <= 2)
            {
                scanup = false; //dont scan up
                //top row
            }
            else if (index <= 8 && index >=6)
            {
                //bottom row
                scandown = false; //dont scan downwards
            }
            else
            {
                //middle row
            }


            if (scanup) //scan upwards
            {
                
                if (player == 0)
                {
                    if (togglednoughts[index - 3]) //true?
                    {
                        ofthree++;
                        if (scandown == false) //is this at the far bottom?
                        {
                            if (togglednoughts[index - 6])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
                else //scanning upwards
                {
                    if (toggledcrosses[index - 3]) //true?
                    {
                        ofthree++;
                        if (scandown == false) //is this at the far bottom?
                        {
                            if (toggledcrosses[index - 6])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
            }

            if (scandown) //scaning downwards
            {
                //we are scanning for left
                if (player == 0)
                {
                    if (togglednoughts[index + 3]) //true?
                    {
                        ofthree++;
                        if (scanup == false) //is this at the far top?
                        {
                            if (togglednoughts[index + 6])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
                else
                {
                    if (toggledcrosses[index + 3]) //true?
                    {
                        ofthree++;
                        if (scanup == false) //is this at the far top?
                        {
                            if (toggledcrosses[index + 6])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
            }

            if (ofthree == 3)
            {
                //we got a row for horizontal
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool scanDiagL(int index, int player) //scan diagonally left \ 
        {
            int ofthree = 1; //by default, the selected or placed down selection constitutes on one of three in a row.
            bool scanupdiag = true; // scanning up 
            bool scandowndiag = true;// scanning down

            int[] criticalpoints = new int[6] { 1, 2, 3, 5, 6, 7 };

            for (int i = 0; i < criticalpoints.Length; i++)
            {
                if (index == criticalpoints[i])
                {

                    return false; //cant can in those places
                }
            }

            if (index == 0)
            {
                scanupdiag = false;
            }
            else if (index == 8)
            {
                scandowndiag = false;

            }

            if (scanupdiag)
            {
                if (player == 0)
                {
                    if (togglednoughts[index - 4])
                    {
                        ofthree++;
                        if (scandowndiag == false) //at the bottom
                        {
                            if (togglednoughts[index - 8])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
                else
                {
                    if (toggledcrosses[index - 4])
                    {
                        ofthree++;
                        if (scandowndiag == false) //at the bottom
                        {
                            if (toggledcrosses[index - 8])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
            }


            if (scandowndiag)
            {
                if (player == 0)
                {
                    if (togglednoughts[index + 4])
                    {
                        ofthree++;
                        if (scanupdiag == false) //at the bottom
                        {
                            if (togglednoughts[index + 8])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
                else
                {
                    if (toggledcrosses[index + 4])
                    {
                        ofthree++;
                        if (scanupdiag == false) //at the bottom
                        {
                            if (toggledcrosses[index + 8])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
            }

            if (ofthree == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool scanDiagR(int index, int player) // scan diagonally right /
        {

            int ofthree = 1; //by default, the selected or placed down selection constitutes on one of three in a row.
            bool scanupdiag = true; // scanning up 
            bool scandowndiag = true;// scanning down

            int[] criticalpoints = new int[6] { 0, 1, 3, 5, 7, 8 };

            for (int i = 0; i < criticalpoints.Length; i++)
            {
                if (index == criticalpoints[i])
                {

                    return false; //cant can in those places
                }
            }

            if (index == 2)
            {
                scanupdiag = false;
            }
            else if (index == 6)
            {
                scandowndiag = false;

            }

            if (scanupdiag)
            {
                if (player == 0)
                {
                    if (togglednoughts[index - 2])
                    {
                        ofthree++;
                        if (scandowndiag == false) //at the bottom
                        {
                            if (togglednoughts[index - 4])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
                else
                {
                    if (toggledcrosses[index - 2])
                    {
                        ofthree++;
                        if (scandowndiag == false) //at the bottom
                        {
                            if (toggledcrosses[index - 4])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
            }


            if (scandowndiag)
            {
                if (player == 0)
                {
                    if (togglednoughts[index + 2])
                    {
                        ofthree++;
                        if (scanupdiag == false) //at the bottom
                        {
                            if (togglednoughts[index + 4])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
                else
                {
                    if (toggledcrosses[index + 2])
                    {
                        ofthree++;
                        if (scanupdiag == false) //at the bottom
                        {
                            if (toggledcrosses[index + 4])
                            {
                                ofthree++;
                            }
                        }
                    }
                }
            }

            if (ofthree == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void endgame(int situation)
        {
            switch (situation) 
            {
                case 0:
                    //player 1 wins
                    MessageBox.Show("Noughts win!");
                    noughtsScore += 1;
                    break;
                case 1:
                    //player 2 win
                    MessageBox.Show("Crosses win!");
                    crossesScore += 1;
                    break;
                case 2:
                    //tie
                    MessageBox.Show("Tie");
                    break;
            }

            for (int i = 0; i < togglednoughts.Length; i++)
            {
                togglednoughts[i] = false;
                toggledcrosses[i] = false;
            }

            resetPanels();
            currentplayer = 0; //current player index
            round = 0; //we begin on 0
            checkBox1.Enabled = true;



            label5.Text = noughtsScore.ToString();
            label6.Text = crossesScore.ToString();
            label3.ForeColor = SystemColors.Highlight;
            label4.ForeColor = SystemColors.ControlText;

        }

        //new game
        private void button1_Click(object sender, EventArgs e)
        {

            bool check = false;
            for (int i = 0; i < togglednoughts.Length; i++)
            {
                if (togglednoughts[i] == true)
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    return;
                }
            }


            for (int i = 0; i < togglednoughts.Length; i++)
            {
                togglednoughts[i] = false;
                toggledcrosses[i] = false;
            }

            resetPanels();
            currentplayer = 0; //current player index
            round = 0; //we begin on 0
            noughtsScore = 0;
            crossesScore = 0;
            label5.Text = noughtsScore.ToString();
            label6.Text = crossesScore.ToString();
            checkBox1.Enabled = true;
            label3.ForeColor = SystemColors.Highlight;
            label4.ForeColor = SystemColors.ControlText;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                playingwithbot = true;
            }
            else
            {
                playingwithbot = false;
            }
        }

        public void aiBestMove() //move the ai
        {
            //int bestscore = -Math.infin
            double bestscore = double.NegativeInfinity;
            double bestmove = 0;
            //ai plays as crosses by default
            for (int i = 0; i < 9; i++) //loops though all crosses
            {
                if (togglednoughts[i] == false && toggledcrosses[i] == false) //free?
                {
                    //choose this
                    toggledcrosses[i] = true; //set it first, see if it works
                    double score = minimax(i, 0, false); //minimax looks at the current board configuration
                    //MessageBox.Show(score.ToString());
                    toggledcrosses[i] = false; //reset it after it has looked at it.
                    if (score > bestscore) // it checks the score, does it suit us?
                    {
                        bestscore = score; //best score becomes this
                        bestmove = i; //best move becomes this
                    }
                }
            }
            //MessageBox.Show(bestmove.ToString());
            moveBot((int)bestmove);

        }

        public double? checkWinner(int user)
        {
            //string winner = "";
            

            if (user == 0)
            {
                //do it for the first player
                for (int i = 0; i < 9; i++)
                {
                    if (togglednoughts[i] == true)
                    {

                        //loop through all conditions, such as if number is in the top row, or if it is on the edges
                        if (scanHorizontal(i, 0) || scanDiagL(i, 0) || scanVertical(i, 0) || scanDiagR(i, 0))
                        {
                            //winner
                            //MessageBox.Show("winner noughts");
                            return -10;
                    

                        }


                    }
                }



            }
            else if (user == 1)
            {
                //do it for the second player
                //do it for the first player
                for (int i = 0; i < 9; i++)
                {
                    if (toggledcrosses[i] == true)
                    {

                        //loop through all conditions, such as if number is in the top row, or if it is on the edges
                        if (scanHorizontal(i, 1) || scanDiagL(i, 1) || scanVertical(i, 1) || scanDiagR(i, 1))
                        {
                            //MessageBox.Show("winner crosses");
                            return 10;
                            

                        }


                    }
                }

            }
            else if (user == 2)
            {
                int number = 0;
                //draw
                for (int i = 0; i < 9; i++) //loop through an arbitrary array
                {
                    if (toggledcrosses[i] == true || togglednoughts[i] == true) //if the first one is occupied by either crosses or noughts
                    {
                        number+=1;
                    }

                }

                if (number >= 9) //should be draw
                    //MessageBox.Show("draw");
                    return 0;

            }
            //MessageBox.Show("no winner");
            return null;




        }

        public void moveBot(int index)
        {
            Panel p = TopLeft;
            switch (index)
            {
                case 0:
                    p = TopLeft;
                    break;
                case 1:
                    p = TopMiddle;
                    break;
                case 2:
                    p = TopRight;
                    break;
                case 3:
                    p = MiddleLeft;
                    break;
                case 4:
                    p = MiddleMiddle;
                    break;
                case 5:
                    p = MiddleRight;
                    break;
                case 6:
                    p = BottomLeft;
                    break;
                case 7:
                    p = BottomMiddle;
                    break;
                case 8:
                    p = BottomRight;
                    break;
            }

            TopMiddle_Click(p, null);
        }

        public double minimax(int index, int depth, bool ismaximising)
        {
            //if terminating
            //we need to check if we won with this current configuration:

            double? resultCrosses = checkWinner(1);
            if (resultCrosses != null)
            {
                return (double)resultCrosses;
            }

            double? resultNoughts = checkWinner(0);
            if (resultNoughts != null)
            {
                return (double)resultNoughts;
            }



            double? resultDraw = checkWinner(2);
            if (resultDraw != null)
            {
                return (double)resultDraw;
            }

            
            //if cannot find a winner or draw this move, search deeper

            if (ismaximising)
            {
                double bestscore = double.NegativeInfinity;
                for (int i = 0; i < 9; i++) //loops though all crosses
                {
                    if (togglednoughts[i] == false && toggledcrosses[i] == false) //free?
                    {
                        //choose this
                        toggledcrosses[i] = true; //set it first, see if it works
                        double score = minimax(index, depth + 1, false); //minimax looks at the current board configuration
                        toggledcrosses[i] = false; //reset it after it has looked at it.
                        bestscore = Math.Max(score, bestscore);
                    }
                    
                }
                return bestscore;
            }
            else
            {
                double bestscore = double.PositiveInfinity;
                for (int i = 0; i < 9; i++) //loops though all crosses
                {
                    if (togglednoughts[i] == false && toggledcrosses[i] == false) //free?
                    {
                        //choose this
                        togglednoughts[i] = true; //set it first, see if it works
                        double score = minimax(index, depth + 1, true); //minimax looks at the current board configuration
                        togglednoughts[i] = false; //reset it after it has looked at it.
                        bestscore = Math.Min(score, bestscore);
                    }
                    
                }
                return bestscore;
            }
           
 
        }


    }
}
