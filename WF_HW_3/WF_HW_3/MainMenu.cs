using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW_3
{
    public partial class MainMenuForm : Form
    {
        List<int> buttons = new List<int>();
        List<int> sortedButtons = new List<int>();
        int arrPosition;
        SoundPlayer soundTrue = new("true.wav");
        SoundPlayer soundFalse = new("false.wav");
        SoundPlayer soundFinishTrue = new("true_finish.wav");
        SoundPlayer soundFinishFalse = new("false_finish.wav");
        DateTime stopwatch;
        public MainMenuForm()
        {
            InitializeComponent();
            deactivateButtons();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                activateButtons();
                arrPosition = 0;
                fillTheArrOfButtons();
                fillTheTextOfButtons();
                stopwatch = newTime();
                listBoxResults.Items.Clear();
                timer.Start();
                this.Text = stopwatch.ToString("mm:ss");
                numericUpDownTimeCount.Enabled = false;
                progressBar.Maximum = (int)numericUpDownTimeCount.Value;
                progressBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }
        private void fillTheArrOfButtons()
        {
            try
            {
                Random random = new();
                int countOfButons = 16;
                int commonNumber;
                int countNumber = 0;
                buttons.Clear();
                while (countNumber < countOfButons)
                {
                    commonNumber = random.Next(1, 100);
                    if (buttons.Contains(commonNumber))
                        continue;
                    else
                    {
                        buttons.Add(commonNumber);
                        countNumber++;
                    }   
                }
                sortedButtons.Clear();
                sortedButtons.AddRange(buttons.ToArray());
                sortedButtons.Sort();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }
        private void fillTheTextOfButtons()
        {
            try
            {
                button1.Text = buttons[0].ToString();
                button2.Text = buttons[1].ToString();
                button3.Text = buttons[2].ToString();
                button4.Text = buttons[3].ToString();
                button5.Text = buttons[4].ToString();
                button6.Text = buttons[5].ToString();
                button7.Text = buttons[6].ToString();
                button8.Text = buttons[7].ToString();
                button9.Text = buttons[8].ToString();
                button10.Text = buttons[9].ToString();
                button11.Text = buttons[10].ToString();
                button12.Text = buttons[11].ToString();
                button13.Text = buttons[12].ToString();
                button14.Text = buttons[13].ToString();
                button15.Text = buttons[14].ToString();
                button16.Text = buttons[15].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }
        #region buttons_click
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(buttons[0] == sortedButtons[arrPosition])
                {
                    button1.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button1.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[1] == sortedButtons[arrPosition])
                {
                    button2.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button2.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[2] == sortedButtons[arrPosition])
                {
                    button3.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button3.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[3] == sortedButtons[arrPosition])
                {
                    button4.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button4.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[4] == sortedButtons[arrPosition])
                {
                    button5.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button5.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[5] == sortedButtons[arrPosition])
                {
                    button6.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button6.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[6] == sortedButtons[arrPosition])
                {
                    button7.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button7.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[7] == sortedButtons[arrPosition])
                {
                    button8.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button8.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[8] == sortedButtons[arrPosition])
                {
                    button9.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button9.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[9] == sortedButtons[arrPosition])
                {
                    button10.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button10.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[10] == sortedButtons[arrPosition])
                {
                    button11.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button11.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[11] == sortedButtons[arrPosition])
                {
                    button12.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button12.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[12] == sortedButtons[arrPosition])
                {
                    button13.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button13.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[13] == sortedButtons[arrPosition])
                {
                    button14.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button14.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[14] == sortedButtons[arrPosition])
                {
                    button15.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button15.Text);
                    arrPosition++;                   
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttons[15] == sortedButtons[arrPosition])
                {
                    button16.Enabled = false;
                    soundTrue.Play();
                    listBoxResults.Items.Add(button16.Text);
                    arrPosition++;
                    if (arrPosition == 16)
                    {
                        finalTrueEvent();
                    }
                }
                else
                {
                    soundFalse.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            fillProgressBar();
            stopwatch = stopwatch.AddSeconds(1);
            this.Text = stopwatch.ToString("mm:ss");
            finalFalseEvent();
        }
        private DateTime newTime()
        {
            DateTime newTime = new(0, 0);
            return newTime;
        }
        private void finalFalseEvent()
        {
            try
            {
                int seconds = stopwatch.Second;
                if (seconds >= numericUpDownTimeCount.Value)
                {
                    deactivateButtons();
                    timer.Stop();
                    soundFinishFalse.Play();
                    MessageBox.Show("You lose!", "Try again");
                    numericUpDownTimeCount.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }
        private void activateButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }
        private void deactivateButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
        }
        private void finalTrueEvent()
        {
            try
            {
                timer.Stop();
                soundFinishTrue.Play();
                MessageBox.Show("You win!", "Congrats!");
                numericUpDownTimeCount.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }
        private void fillProgressBar()
        {
            try
            {
                ++progressBar.Value;
                if (progressBar.Value == numericUpDownTimeCount.Value)
                {
                    progressBar.Maximum++;
                    progressBar.Value++;
                    progressBar.Maximum = (int)numericUpDownTimeCount.Value;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }
    }
}