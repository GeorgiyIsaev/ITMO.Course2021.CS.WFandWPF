using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// The minimum required windows forms namespaces.
using System.Windows.Forms;
using System.Drawing;

namespace SimpleWinFormsApp
{
    #region Our Window
    //// This is our main window.
    // This is our main window.
    class MainWindow : Form
    {
        //  Members for a simple menu system.
        private MenuStrip mnuMainMenu;

        public MainWindow() { }
        public MainWindow(string title, int height, int width)
        {
            // Set various properties from our parent classes.
            Text = title;
            Width = width;
            Height = height;

            InitComponents();
      }

        private void InitComponents()
        {
            Text = "First application";
            ClientSize = new Size(800, 450);
            // Method to create our menu system.
            BuildMenuSystem();
            // Inherited method to center the form on the screen.
            CenterToScreen();
        }


        #region Build the menu system
        private void BuildMenuSystem()
        {
           mnuMainMenu = new MenuStrip();

           ToolStripMenuItem mnuFile = new ToolStripMenuItem();
           ToolStripMenuItem mnuFileExit = new ToolStripMenuItem();

            // Add the File menu item to the main menu.
            mnuFile.Text = "&File";
            mnuMainMenu.Items.Add(mnuFile);

            // Now add the Exit menu to the File menu.
            mnuFileExit.Text = "E&xit";
            mnuFile.DropDownItems.Add(mnuFileExit);
            mnuFileExit.Click += (o, s) =>
                {
                    MessageBox.Show(string.Format("{0} sent this event", o.ToString()));
                    Application.Exit();
                };

            // Finally, set the menu for this Form.
            Controls.Add(this.mnuMainMenu);
            MainMenuStrip = this.mnuMainMenu;
        }
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(386, 142);
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }
        
    }
    #endregion

    // This is our application object.
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainWindow("My Window", 200, 300));
        }
    }
}
