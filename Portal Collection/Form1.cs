using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;
using Steamworks;
using System;
using System.Drawing;
using static System.Windows.Forms.DataFormats;

namespace Portal_Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 400; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 620; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 280740; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 317400; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 1255980; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 286080; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 684410; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 70; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 220; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 134870; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // Get the app ID of the game you want to launch
            uint appId = 601360; // replace with the app ID of your game

            // Get the Steam install path
            string steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", null).ToString();
            if (string.IsNullOrEmpty(steamPath))
            {
                MessageBox.Show("Could not find Steam install path.");
                return;
            }

            // Construct the launch command
            string launchCommand = $"steam://run/{appId}";

            // Set the launch options (optional)
            string launchOptions = "-novid -high";
            launchCommand += $" {launchOptions}";

            // Launch the game
            try
            {
                Process.Start(steamPath + "\\steam.exe", launchCommand);
                MessageBox.Show("Game launched successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch game. Error: " + ex.Message);
            }
        }
    }       
}