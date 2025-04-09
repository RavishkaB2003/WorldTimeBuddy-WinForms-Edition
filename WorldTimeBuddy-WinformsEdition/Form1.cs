using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;


namespace WorldTimeBuddy_WinformsEdition
{
    public partial class mainform: Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        







        private void BackgroundPanel_Paint(object sender, PaintEventArgs e)
        {
            BackgroundPanel.BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundPanel_Resize(null, null);




        }

        private void BackgroundPanel_Resize(object sender, EventArgs e)
        {
            Control ctrl = Header;
            ctrl.Left = (BackgroundPanel.Width - ctrl.Width) / 2;
            ctrl.Top = (BackgroundPanel.Height - ctrl.Height) / 3;

            Control countryselector = CountrySelector;
            countryselector.Left = (BackgroundPanel.Width - countryselector.Width) / 2;
            countryselector.Top = (BackgroundPanel.Height - countryselector.Height) / 2;

            Control reveallabel = LabelToReveal;
            reveallabel.Left = (BackgroundPanel.Width - reveallabel.Width) / 2;
            reveallabel.Top = (BackgroundPanel.Height - reveallabel.Height) / 1 - 50;
        }


        private void changepanelbackground(DateTime currentTime)
        {
            //changing the background image based on the currenttime variable.
            if (currentTime.Hour >= 6 && currentTime.Hour < 18)
            {
                BackgroundPanel.BackgroundImage = Image.FromStream(new MemoryStream(Properties.Resources.day));
                BackgroundPanel.BackgroundImageLayout = ImageLayout.Stretch;  // This will stretch the image to fill the panel


            }
            else
            {
                BackgroundPanel.BackgroundImage = Image.FromStream(new MemoryStream(Properties.Resources.night));
                BackgroundPanel.BackgroundImageLayout = ImageLayout.Stretch;  // This will stretch the image to fill the panel


            }
        }

        private void CountrySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getting the selected country
            string selectedCountry = CountrySelector.SelectedItem.ToString();

            //getting the timezone for the selected country
            Dictionary<string, string> countryToTimezone = new Dictionary<string, string>()
            {
                    { "United States", "Eastern Standard Time" },
                    { "Canada", "Eastern Standard Time" },
                    { "Sri Lanka", "Sri Lanka Standard Time" },
                    { "India", "India Standard Time" },
                    { "Japan", "Tokyo Standard Time" },
                    { "Australia", "AUS Eastern Standard Time" },
                    { "United Kingdom", "GMT Standard Time" },
                    { "Germany", "W. Europe Standard Time" },
                    { "France", "W. Europe Standard Time" },
                    { "Russia", "Russian Standard Time" },
                    { "Brazil", "E. South America Standard Time" },
                    { "South Africa", "South Africa Standard Time" },
                    { "Mexico", "Central Standard Time" },
                    { "Argentina", "Argentina Standard Time" },
                    { "China", "China Standard Time" },
                    { "South Korea", "Korea Standard Time" },
                    { "Italy", "W. Europe Standard Time" },
                    { "Spain", "W. Europe Standard Time" },
                    { "Egypt", "Egypt Standard Time" },
                    { "Saudi Arabia", "Arabian Standard Time" }
            };
            string timezonetocountry = countryToTimezone[selectedCountry]; //getting the timezone for the selected country

            //getting the current time in the selected timezone
            try
            {
                //getting the time zone using timezone ID and updating the currentTime
                TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(timezonetocountry);
                DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, tz);

                //formatting the time to a string
                LabelToReveal.Text = currentTime.ToString("hh:mm tt");

                //change the background panel image
                changepanelbackground(currentTime);
            }
            catch (TimeZoneNotFoundException)
            {
                //if the timezone is not found, show an error message
                MessageBox.Show("Timezone not found for the selected country.");
            }
            ;
        }
            

        private void mainform_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> countryToTimezone = new Dictionary<string, string>() //Creating a dictionary to map countries to their respective timezones
            {
                    { "United States", "Eastern Standard Time" },
                    { "Canada", "Eastern Standard Time" },
                    { "Sri Lanka", "Sri Lanka Standard Time" },
                    { "India", "India Standard Time" },
                    { "Japan", "Tokyo Standard Time" },
                    { "Australia", "AUS Eastern Standard Time" },
                    { "United Kingdom", "GMT Standard Time" },
                    { "Germany", "W. Europe Standard Time" },
                    { "France", "W. Europe Standard Time" },
                    { "Russia", "Russian Standard Time" },
                    { "Brazil", "E. South America Standard Time" },
                    { "South Africa", "South Africa Standard Time" },
                    { "Mexico", "Central Standard Time" },
                    { "Argentina", "Argentina Standard Time" },
                    { "China", "China Standard Time" },
                    { "South Korea", "Korea Standard Time" },
                    { "Italy", "W. Europe Standard Time" },
                    { "Spain", "W. Europe Standard Time" },
                    { "Egypt", "Egypt Standard Time" },
                    { "Saudi Arabia", "Arabian Standard Time" }
            };

            //populate the ComboBox with country names
            foreach (var country in countryToTimezone.Keys)
            {
                CountrySelector.Items.Add(country);
            }
        }
    }
}
