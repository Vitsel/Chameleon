﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace AuthClient.tollgate.home
{
    public partial class SideBarMain : UserControl
    {
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        public SideBarMain()
        {
            InitializeComponent();

            img_icon.Left = ClientRectangle.Left + 16;
            img_icon.Top = (ClientSize.Height - img_icon.Height) / 2;

            Font font = new Font(MainForm.FONT_BOLD, 11);
            label.Font = font;
            label.Left = ClientRectangle.Left + 41;
            label.Top = (ClientSize.Height - label.Height) / 2 - 2;
        }

        public void setOn()
        {
            img_icon.Image = Properties.Resources.mainSideMainOn;
            BackgroundImage = Properties.Resources.mainSideBg;
        }

        public void setOff()
        {
            img_icon.Image = Properties.Resources.mainSideMainOff;
            BackgroundImage = null;
        }
    }
}
