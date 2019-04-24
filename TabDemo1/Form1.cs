using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabDemo1
{
    public partial class Form1 : Form
    {
        private ComboBox mCombo1 = new ComboBox();
        private Button mButton1 = new Button();

        private MenuStrip mMenuStrip =new MenuStrip();
        private ToolStripMenuItem mFileMenu = new ToolStripMenuItem();
        private ToolStripMenuItem mEditMenu = new ToolStripMenuItem();
        private ToolStripMenuItem mViewMenu = new ToolStripMenuItem();
        private ToolStripMenuItem mHelpMenu = new ToolStripMenuItem();
        private ToolStripMenuItem mNewMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem mOpenMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem mExitMenuItem = new ToolStripMenuItem();


        public Form1() {
            InitializeComponent();

            tabControlExtra1.ControlPanel.BackColor = Color.LightCoral; // Color.Transparent;

            tabControlExtra1.ControlPanel.Controls.Add(mMenuStrip);
            mMenuStrip.SuspendLayout();

            mMenuStrip.BackColor = Color.LightGray;

            mMenuStrip.Items.AddRange(new ToolStripItem[] {
                mFileMenu,
                mEditMenu,
                mViewMenu,
                mHelpMenu
            });
            tabControlExtra1.TabOffset = 175 ;
            mMenuStrip.TabIndex = 0;

            mFileMenu.DropDownItems.AddRange(new ToolStripItem[] {
                mNewMenuItem,
                mOpenMenuItem,
                mExitMenuItem
            });
            mFileMenu.Text = "File";
            mEditMenu.Text = "Edit";
            mViewMenu.Text = "View";
            mHelpMenu.Text = "Help";

            mNewMenuItem.Text = "New";
            mOpenMenuItem.Text = "Open...";
            mExitMenuItem.Text = "Exit";

            mMenuStrip.ResumeLayout(false);
            mMenuStrip.PerformLayout();


            tabControlExtra2.ControlPanel.Controls.Add(mCombo1);
            mCombo1.Location = new Point(2, 0);
            mCombo1.Width = 50;

            tabControlExtra2.ControlPanel.Controls.Add(mButton1);
            mButton1.UseVisualStyleBackColor = true;
            mButton1.Width = 25;
            mButton1.Height = 21;
            mButton1.Location = new Point(mCombo1.Right + 2, 0);
            mButton1.Text = "...";

            tabControlExtra2.TabOffset = mButton1.Right + 2;

        }

        private void tabControlExtra1_TabClosed(object sender, TabControlEventArgs e)
        {
            System.Diagnostics.Debug.Print("TabClosed event");
        }

        private void tabControlExtra1_TabClosing(object sender, TabControlCancelEventArgs e)
        {
            System.Diagnostics.Debug.Print("TabClosing event");
        }

        private void tabControlExtra2_TabClosed(object sender, TabControlEventArgs e)
        {
            System.Diagnostics.Debug.Print("TabClosed event");
        }

        private void tabControlExtra2_TabClosing(object sender, TabControlCancelEventArgs e)
        {
            System.Diagnostics.Debug.Print("TabClosing event - cancelling");
            e.Cancel = true;
        }
    }
}
