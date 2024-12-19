using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_Collection
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string text = @"Half-Life:

    noclip - Toggle no-clip mode (allows the player to move through objects)
    sv_gravity - Set the gravity level (default is 800)
    sv_cheats - Enable cheats (must be set to 1 to use cheats)
    give - Give the specified item or weapon to the player (e.g. give item_healthkit)
    god - Toggle god mode (invincibility)
    notarget - Toggle AI ignoring the player
    impulse 101 - Give all items and weapons

Portal:

    noclip - Toggle no-clip mode (allows the player to move through objects)
    sv_gravity - Set the gravity level (default is 600)
    sv_cheats - Enable cheats (must be set to 1 to use cheats)
    give - Give the specified item or weapon to the player (e.g. give portalgun)
    god - Toggle god mode (invincibility)
    notarget - Toggle AI ignoring the player
    sv_infinite_aux_power - Toggle infinite auxiliary power (for portal gun)

Half-Life 2:

    noclip - Toggle no-clip mode (allows the player to move through objects)
    sv_gravity - Set the gravity level (default is 800)
    sv_cheats - Enable cheats (must be set to 1 to use cheats)
    give - Give the specified item or weapon to the player (e.g. give item_healthkit)
    god - Toggle god mode (invincibility)
    notarget - Toggle AI

Portal 2:
    
    noclip - Toggle no-clip mode (allows the player to move through objects)
    sv_gravity - Set the gravity level (default is 600)
    sv_cheats - Enable cheats (must be set to 1 to use cheats)
    give - Give the specified item or weapon to the player (e.g. give portalgun)
    god - Toggle god mode (invincibility)
    notarget - Toggle AI ignoring the player



To open the developer console in the Half-Life, Half-Life 2 and Portal, Portal 2 games, you will need to do the following:

    Start the game
    From the main menu, go to the ""Options"" menu and select ""Keyboard/Mouse""
    In the ""Keyboard/Mouse"" menu, find the ""Advanced"" tab
    Check the box next to ""Enable Developer Console""
    Press the ~ key (tilde) to open the console

Alternatively, you can also enable the developer console through the game's launch options. To do this, right-click on the game in your Steam library and select ""Properties"". In the ""General"" tab, click the ""Set Launch Options"" button and enter -console in the text box.

Please note that the developer console may not be available in all versions of the games. Additionally, the key to open the console may be different depending on your keyboard layout.";
            richTextBox1.Text = text;
        }
    }
}
