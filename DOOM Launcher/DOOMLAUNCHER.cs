using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Audio;
//using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.GamerServices;
//using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework.Input;
//using Microsoft.Xna.Framework.Media;
using System.Diagnostics;
using SlimDX;
using SlimDX.XInput;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System.Runtime.InteropServices;
//using DoomLauncher.GamepadState;

//using Microsoft.Xna.Framework.Net;  //This is missing the DLL for this
//using Microsoft.Xna.Framework.Storage; //This is missing the DLL for this

namespace DOOM_Launcher
{

    public partial class DOOMLauncher : Form
  {
        private int value;

        public DOOMLauncher()
      {
          InitializeComponent();

      }
    string doomFile = System.IO.Directory.GetCurrentDirectory();

        private void DOOMLauncher_Load(object sender, EventArgs e)
      {
            timer1.Start();
            value = 0;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources._13ArgentEnergy;
            player.PlayLooping();
            previousGamePadState = GamePad.GetState(PlayerIndex.One);

        }
        GamePadState previousGamePadState;
        private void btnLaunchGame_Click(object sender, EventArgs e)
        {
            try
            {
               // MessageBox.Show(doomFile);
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = doomFile + @"\DOOMx64.EXE";
                startInfo.Arguments = "+com_gameMode 0";
                Process.Start(startInfo);
            }       
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                // GC.Collect();
                Dispose();

            }


        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {

            try
            {
               // MessageBox.Show(doomFile);
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = doomFile + @"\DOOMx64.EXE";
                startInfo.Arguments = "+com_gameMode 2";
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                //   GC.Collect();
                Dispose();

            }
        }

        private void btnSnapmap_Click(object sender, EventArgs e)
        {
            try
            {
              //  MessageBox.Show(doomFile);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = doomFile + @"\DOOMx64.EXE";
            startInfo.Arguments = "+com_gameMode 3";
            Process.Start(startInfo);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                Dispose();
            }
        }



        // SinglePlayer image properties.

        private void btnLaunchGame_Enter(object sender, EventArgs e)
        {
            btnLaunchGame.BackgroundImage = Properties.Resources.LaunchGame_Highlight;
        }

        private void btnLaunchGame_Leave(object sender, EventArgs e)
        {
            btnLaunchGame.BackgroundImage = Properties.Resources.LaunchGame;

        }

        private void btnLaunchGame_KeyDown(object sender, KeyEventArgs e)
        {
            btnLaunchGame.BackgroundImage = Properties.Resources.LaunchGame_Select;

        }

        private void btnLaunchGame_MouseEnter(object sender, EventArgs e)
        {
            btnLaunchGame.BackgroundImage = Properties.Resources.LaunchGame_Highlight;

        }

        private void btnLaunchGame_MouseDown(object sender, MouseEventArgs e)
        {
            btnLaunchGame.BackgroundImage = Properties.Resources.LaunchGame_Select;

        }

        private void btnLaunchGame_MouseLeave(object sender, EventArgs e)
        {
            btnLaunchGame.BackgroundImage = Properties.Resources.LaunchGame;

        }

        // Multiplayer image properties.

        private void btnMultiplayer_Enter(object sender, EventArgs e)
        {
            btnMultiplayer.BackgroundImage = Properties.Resources.LaunchMultiplayer_Highlight;

        }

        private void btnMultiplayer_Leave(object sender, EventArgs e)
        {
            btnMultiplayer.BackgroundImage = Properties.Resources.LaunchMultiplayer;

        }

        private void btnMultiplayer_KeyDown(object sender, KeyEventArgs e)
        {
            btnMultiplayer.BackgroundImage = Properties.Resources.LaunchMultiplayer_Selected;

        }

        private void btnMultiplayer_MouseDown(object sender, MouseEventArgs e)
        {
            btnMultiplayer.BackgroundImage = Properties.Resources.LaunchMultiplayer_Selected;

        }

        private void btnMultiplayer_MouseEnter(object sender, EventArgs e)
        {
            btnMultiplayer.BackgroundImage = Properties.Resources.LaunchMultiplayer_Highlight;

        }

        private void btnMultiplayer_MouseLeave(object sender, EventArgs e)
        {
            btnMultiplayer.BackgroundImage = Properties.Resources.LaunchMultiplayer;

        }

        // Snapmap image properties.

        private void btnSnapmap_Enter(object sender, EventArgs e)
        {
            btnSnapmap.BackgroundImage = Properties.Resources.LaunchSnapmap_Highlight;

        }

        private void btnSnapmap_Leave(object sender, EventArgs e)
        {
            btnSnapmap.BackgroundImage = Properties.Resources.LaunchSnapmap;

        }

        private void btnSnapmap_KeyDown(object sender, KeyEventArgs e)
        {
            btnSnapmap.BackgroundImage = Properties.Resources.LaunchSnapmap_Selected;

        }

        private void btnSnapmap_MouseDown(object sender, MouseEventArgs e)
        {
            btnSnapmap.BackgroundImage = Properties.Resources.LaunchSnapmap_Selected;

        }

        private void btnSnapmap_MouseEnter(object sender, EventArgs e)
        {
            btnSnapmap.BackgroundImage = Properties.Resources.LaunchSnapmap_Highlight;

        }

        private void btnSnapmap_MouseLeave(object sender, EventArgs e)
        {
            btnSnapmap.BackgroundImage = Properties.Resources.LaunchSnapmap;

        }
        
        // Settings image properties.
        
        private void btnSettings_Enter(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.LaunchSettings_Highlight;

        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.LaunchSettings;

        }

        private void btnSettings_KeyDown(object sender, KeyEventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.LaunchSettings_Select;

        }

        private void btnSettings_MouseDown(object sender, MouseEventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.LaunchSettings_Select;

        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.LaunchSettings_Highlight;

        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.LaunchSettings;

        }

        private void btnSettings_KeyUp(object sender, KeyEventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.LaunchSettings_Highlight;

        }

        private void btnSettings_MouseUp(object sender, MouseEventArgs e)
        {
            btnSettings.BackgroundImage = Properties.Resources.LaunchSettings_Highlight;

        }

        void UpdateInput()
        {
            // Get the current gamepad state.
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);

            // Process input only if connected and button A is pressed.
            if (currentState.IsConnected && currentState.Buttons.A ==
                Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                timer1.Stop();
                //MessageBox.Show("A");
                if (btnLaunchGame.Focused == true)    
                {
                    btnLaunchGame.BackgroundImage = Properties.Resources.LaunchGame_Select;
                    btnLaunchGame.PerformClick();
                   // MessageBox.Show("Launching Game.");
                }
                else { }
                
                if (btnMultiplayer.Focused == true)
                {
                    btnMultiplayer.BackgroundImage = Properties.Resources.LaunchMultiplayer_Selected;
                    btnMultiplayer.PerformClick();
                  //  MessageBox.Show("Launching Multiplayer.");

                }
                else { }

                if (btnSnapmap.Focused == true)
                {
                   btnSnapmap.BackgroundImage = Properties.Resources.LaunchSnapmap_Selected;
                   btnSnapmap.PerformClick();
                   //MessageBox.Show("Launching Snapmap.");

                }
                else { }

                // Button A is currently being pressed
            }
            else
            {
                timer1.Start();

                // Button A is not being pressed
            }

            if (currentState.IsConnected && currentState.Buttons.B ==
                Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                timer1.Stop();

                var ans =
                MessageBox.Show("Are you sure you wish to exit?", "DOOM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
            else
            {
                timer1.Start();

            }


            //Dpad UP
            if (currentState.IsConnected && currentState.DPad.Up == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                
                timer1.Stop();
                // MessageBox.Show("{0}");
                value--;

                if (value <= 0)
             {
                value = 0;
                //string theVal = Convert.ToString(value);
                // btnLaunchGame.Focus();
                //
                 // MessageBox.Show("{0}");
           
             }
             else
             {
                 // value -= 1;
                 //string theVal = Convert.ToString(value);
           
           
             }
                switch (value)
                {
                    case 0:
                        //MessageBox.Show("0");
                        btnLaunchGame.Focus();
                        break;
                    case 1:
                        // MessageBox.Show("1");
                        btnMultiplayer.Focus();

                        break;
                    case 2:
                        // MessageBox.Show("2");
                        btnSnapmap.Focus();

                        break;
                }
                string theVal = Convert.ToString(value);
                label1.Text = theVal;

                timer1.Start();


            }
            else
            {
                timer1.Start();

            }


            //DPad Down
            if (currentState.IsConnected && currentState.DPad.Down == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {

                timer1.Stop();
                // MessageBox.Show("Down");
                value++;
                if (value >= 2)
                {
                    value = 2;
                    //string theVal = Convert.ToString(value);
                    // btnLaunchGame.Focus();
                    //
                    // MessageBox.Show("{0}");

                }
                else
                {
                    // value -= 1;
                    //string theVal = Convert.ToString(value);


                }
                switch (value)
                {
                    case 0:
                        //MessageBox.Show("0");
                        btnLaunchGame.Focus();
                        break;
                    case 1:
                        // MessageBox.Show("1");
                        btnMultiplayer.Focus();

                        break;
                    case 2:
                        // MessageBox.Show("2");
                        btnSnapmap.Focus();

                        break;
                }
                string theVal = Convert.ToString(value);
                    label1.Text = theVal;
                timer1.Start();


            }
            else
            {
                timer1.Start();

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateInput();

            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //var ans =
            //    MessageBox.Show("Are you sure you wish to exit?", "DOOM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (ans == DialogResult.Yes)
            //{
            //   
            //}
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        

        private void DOOMLauncher_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }

    
}
