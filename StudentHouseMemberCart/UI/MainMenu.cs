using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UI
{
    public partial class MainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;


        public MainMenu()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {

            int index = random.Next(ThemeColorcs.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColorcs.ColorList.Count);

            }
            tempIndex = index;
            string color = ThemeColorcs.ColorList[index];
            return ColorTranslator.FromHtml(color);
        } // color choose random not dupplicate

        private void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    // currentButton.Font = new System.Drawing.Font("");
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button) )
                    {

                    previousBtn.BackColor = Color.FromArgb(255, 255, 255);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);


                }



            }




        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }
    }
}
