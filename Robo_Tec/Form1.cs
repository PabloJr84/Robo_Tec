using EasyAutomationFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace Robo_Tec
{
    public partial class Robo_Form : Form
    {
        public Robo_Form()
        {
            InitializeComponent();
        }

        private void Robo_Form_Load(object sender, EventArgs e)
        {
           

        }

        private void Btn_acessar_Click(object sender, EventArgs e)
        {
            var web = new Web();

            web.StartBrowser();

            web.Navigate("https://www.youtube.com");

            web.AssignValue(TypeElement.Name, "search_query", "Cruzeiro").element.SendKeys(Keys.Enter);

        }
    }
}
