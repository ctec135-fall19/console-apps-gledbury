using System;
using System.Windows.Forms;

namespace SimpleWFApp
{
    class Program
    {
        static void Main() 
        {
            Application.Run(new MainWindow("My Window", 500, 800));
        }
    }
	
    class MainWindow : Form 
    {
		//simple menu
		private MenuStrip mnuMainMenu = new MenuStrip();
		private ToolStripMenuItem mnuFile = new ToolStripMenuItem();
		private ToolStripMenuItem mnuFileExit = new ToolStripMenuItem();
		
        public MainWindow(string title, int height, int width) 
		{
			//setting properties
			Text = title;
			Width = width;
			Height = height;
			
			CenterToScreen();
			
			// method to create menu
			BuildMenuSystem();
			
		}
		
		private void BuildMenuSystem()
		{
			//add the file menu item to the main menu
			mnuFile.Text = "&File";
			mnuMainMenu.Items.Add(mnuFile);
			
			//add the exit menu to the file menu
			mnuFileExit.Text = "E&xit";
			mnuFile.DropDownItems.Add(mnuFileExit);
			mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			
			//set the menu for this form
			Controls.Add(this.mnuMainMenu);
			MainMenuStrip = this.mnuMainMenu;
		}
		
		//Handler for the file | Exit event
		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
    }
}