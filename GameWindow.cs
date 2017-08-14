using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSaysGame
{
    public partial class GameWindow : Form
    {
        // Private data members
        private int score;          // Increments with each successful sequence entry
        private bool difficult;     // If true, speed of sequence display increases as score increases
        private bool arrowKeys;     // Use arrow keys if true; WASD keys if false
        private List<int> sequence; // Contains the sequence to display and verify
        private Random randomizer;  // Our random number generator
        private int currentStep;    // Where currently iterating in sequence
        private Timer dispTimer;    // Timer for displaying sequence (affected by difficulty)
        private Timer inputTimer;   // Timer for input delay (not affected by difficulty)
        //Eventually add strings for paths and streams to hold .wav files
        //Eventually add SoundPlayer class to playback .wav files
        //Need a path to the file to store options
        //Need a path to the file to store high scores

        // Constants
        const int UP = 0;           // Sequence items for which button is used
        const int LEFT = 1;
        const int RIGHT = 2;
        const int DOWN = 3;
        const int EASY_TIME = 5000; // Milliseconds for pause between note display on standard difficulty
        const int MAX_HARD_TIME = 1000;
        
        // Properties
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public bool Difficult
        {
            get
            {
                return difficult;
            }
            set
            {
                difficult = value;
            }
        }

        public bool ArrowKeys
        {
            get
            {
                return arrowKeys;
            }
            set
            {
                arrowKeys = value;
            }
        }

        // Constructors
        public GameWindow()
        {
            // Use the constructor to initialize the game
            // Note that this does not start a game, just prepares it

            // Initialize the score
            score = 0;

            // Set currentStep to zero as well
            currentStep = 0;

            // Since the difficulty radio buttons are on Easy by default...
            difficult = false;      // TODO: Modify based on options file
            // TODO: Update the radio button based on the settings

            // Initialize the buttons to be arrow keys by default
            arrowKeys = true;       // TODO: Modify based on options file

            // Prepare the random number generator
            randomizer = new Random();

            // Prepare the timers
            inputTimer = new Timer();
            dispTimer = new Timer();

            // Initialize the list to start at 25 items in the sequence
            sequence = new List<int>(25);

            // TODO: use a function to initialize SoundPlayer and .wav files
            // This will allow me to do this with the Options dialog too.

            // Show all the things
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Starts up a new game, resetting everything

            // Reset the score to 0 and display it
            score = 0;
            lblScore.Text = score.ToString();

            // Reset the currentStep to 0
            currentStep = 0;

            // Check the difficulty radio buttons and set the flag
            difficult = radioHardDiff.Checked;      // If false, easy is checked

            // Develop the initial sequence
            // Must reset sequence.Capacity to 25 or it will run away!
            sequence.Clear();
            sequence.TrimExcess();
            sequence.Capacity = 25;
            for (int i = 0; i < sequence.Capacity; i++)
            {
                sequence.Add(randomizer.Next(UP, DOWN+1));
            }

            // Initialize timers with Easy difficulty timing first
            inputTimer.Interval = EASY_TIME;
            dispTimer.Interval = EASY_TIME;


            // Begin the game loop...
            // Need to quit thinking like sequential programming and start
            // using events to do all of this!
            while (true)
            {
                /* Here is a breakdown of the cycle:
                 * 1. Display the sequence up to the current iteration
                 *    a. Use score to know where we are stepping to
                 *    b. Use currentStep to mark spot in sequence to display/check
                 * 2. Accept user input
                 *    a. A timer checks for how long user hasn't made an input
                 *    b. If time goes over, the game is over.
                 *    c. If input made in time, check input versus sequence.
                 *    d. If incorrect, the game is over.
                 *    e. If correct, move to the next item in sequence.
                 *    f. If reached score, increase score/start loop over again.
                 *    g. If score > sequence capacity, get new direction.
                 * 3. Handle a game over state (outside of game loop)
                 *    a. Display the score
                 *    b. If a new high score, take user name
                 *    c. Update/display high scores
                 * */

                // Display the sequence up to the current iteration
                do
                {
                    switch (sequence[currentStep])
                    {
                        case UP:        // Red
                            btnUp.BackColor = Color.Red;
                            // TODO: Play a sound for Up button
                            // TODO: Delay for time based on difficulty
                            btnUp.BackColor = DefaultBackColor;
                            break;

                        case LEFT:        // Blue
                            btnLeft.BackColor = Color.Blue;
                            // TODO: Play a sound for Left button
                            // TODO: Delay for time based on difficulty
                            btnLeft.BackColor = DefaultBackColor;
                            break;

                        case RIGHT:        // Yellow
                            btnRight.BackColor = Color.Yellow;
                            // TODO: Play a sound for Right button
                            // TODO: Delay for time based on difficulty
                            btnRight.BackColor = DefaultBackColor;
                            break;

                        case DOWN:        // Green
                            btnDown.BackColor = Color.Green;
                            // TODO: Play a sound for Down button
                            // TODO: Delay for time based on difficulty
                            btnDown.BackColor = DefaultBackColor;
                            break;

                        default:
                            // ERROR!!!
                            MessageBox.Show("BUG: Invalid direction in sequence", "BUG!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    // Increment currentStep
                    currentStep++;
                } while (currentStep <= score);

                // Accept user input
                // TODO: Initiate timer to check for too long of a delay
                
                // All that follows should be within a loop for the timer
                // TODO: Check the input from the keyboard or button press

                // 
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // Displays the Options form as a modal dialog box
            OptionsDialog optionsDialog = new OptionsDialog(this);
            optionsDialog.ShowDialog(this);

            // Set the options based on the selections in the dialog
            if (optionsDialog.RadioArrows.Checked == true)
            {
                arrowKeys = true;
            }
            else if (optionsDialog.RadioWasd.Checked == true)
            {
                arrowKeys = false;
            }

            // Clean up when done
            optionsDialog.Dispose();

            // Update the game window with changes based on new options
            if (arrowKeys == true)
            {
                // Set the button text to show arrow keys
                btnUp.Text = "↑";
                btnDown.Text = "↓";
                btnLeft.Text = "←";
                btnRight.Text = "→";
            }
            else
            {
                // Set the button text to show WASD
                btnUp.Text = "W";
                btnDown.Text = "S";
                btnLeft.Text = "A";
                btnRight.Text = "D";
            }
        }
    }
}
