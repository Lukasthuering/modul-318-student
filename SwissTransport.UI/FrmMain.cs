using SwissTransport.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport
{
    public partial class FrmMain : Form 
    {
        private readonly ITransport mainTransport = new Transport();
        private DateTime Date;
        public FrmMain()
        {
            InitializeComponent();
        }
        

    //This event controls the actions, if the Button "Verbindung suchen" is clicked.
    private void BtnConnections_Click(object sender, EventArgs e)
        {
            //The items and columns in the ListView will be cleared if the button is clicked. Also 4 new Colums are getting created.
            //The Event .Items.Clear and .Colums.Clear, deletes eery item and every Column in the ListView.
            //.Columns.Add ist responsible for creating new Colums. These colums are used to view the Details for the Route.
            ListViewResult.Items.Clear();
            ListViewResult.Columns.Clear();
            ListViewResult.Columns.Add("Gleis");
            ListViewResult.Columns.Add("Abfahrt");
            ListViewResult.Columns.Add("Dauer");
            ListViewResult.Columns.Add("Ankunft");

            //In this section of the Code the Connections are geting calculated.
            //The object "transport" ist geting created from the class "SwissTransoport.Transport"
            //The variable "foundConnections" is geting defined. Now the Values from the two Comboboxes are written to the variable.
            //The ListView gets again cleared from the Items. If the user wants to search for another connection between two new Stations,
            //The Items will be cleared if the user clicks the button again.
            //Now the foreach loop calculates the connections between the two stations, which are selected by the user.

            SwissTransport.Transport transport = new SwissTransport.Transport();
            var foundConnections = transport.GetConnections(ComboBoxStart.Text, ComboBoxEnd.Text);
            ListViewResult.Items.Clear();
            foreach (Connection conn in transport.GetConnections(ComboBoxStart.Text, ComboBoxEnd.Text).ConnectionList)
            {
                //The Date and the Time is geting parsed from the Depature and Arrival time.
                //After this step, the string for the ListView is getting created. the Values for the connection are saved in the string now.
                //Then, the String is added to the Listview with the .Items.Add(lvitem)
                //In the end the Colums are getting auto resized, for a better view.
                DateTime departure = DateTime.Parse(conn.From.Departure);
                DateTime arrival = DateTime.Parse(conn.To.Arrival);
                String[] item = { conn.From.Platform, departure.ToString(), conn.Duration, arrival.ToString()};
                ListViewItem lvitem = new ListViewItem(item);
                ListViewResult.Items.Add(lvitem);
                ListViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                ListViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        //In this code section the Stations will be written down to the Comboboxes.
        private void ComboBoxStartStop_DropDown(object sender, EventArgs e)
        {
            //The stations from the API are written down to the checkbox
            ComboBox comboboxload = (ComboBox)sender;
            SwissTransport.Transport transport = new SwissTransport.Transport();
            var foundStations = transport.GetStations(comboboxload.Text);

            //Every station, that is found, is written down in the che^ckbox.
            foreach (var station in foundStations.StationList)
            {
                comboboxload.Items.Add(station.Name);
            }
            
        }
        //With this Button, the Connections from one Station will be showed to the user.
        private void btnTimetable_Click(object sender, EventArgs e)
        {
            try
            {

                //Again the items and de colums are getting cleared, and new Columns are getting created.
                ListViewResult.Items.Clear();
                ListViewResult.Columns.Clear();
                ListViewResult.Columns.Add("Verkehrsmittel");
                ListViewResult.Columns.Add("Nach");
                ListViewResult.Columns.Add("Abfahrt");
                ListViewResult.Columns.Add("Betreiber");


                //In this section the Departures from one selected station will be calculated.
                string strAbfahrt = ComboBoxStart.SelectedItem.ToString();
                string id = mainTransport.GetStations(strAbfahrt).StationList[0].Id;
                StationBoardRoot sbRoot = mainTransport.GetStationBoard(strAbfahrt, id);
                //In this loop, the Results for the Departures are getting calculated, and the Items will be wirtten down,
                //to a string, then, a new ListViewItem is created and will be written down in the ListView.
                foreach (StationBoard sb in sbRoot.Entries)
                {
                    String[] result = { sb.Name, sb.To, sb.Stop.Departure.ToString(), sb.Operator };
                    ListViewItem lvItem = new ListViewItem(result);
                    ListViewResult.Items.Add(lvItem);
                }
                //In the end the Colums are getting auto resized again, for a better view.
                ListViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                ListViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch(WebException ex)
            {
                MessageBox.Show("Zu viele Anfragen an den Server, bitte warten");
            }

        }
        //This Button is responsible to switch the selected Deparute and Arrival Station.
        private void btnswap_Click(object sender, EventArgs e)
        {
            //The String from the ComboBoxStart is now the string "from"
            string from = "";

            
            from = ComboBoxStart.Text;

            //Now the new created string "from" can easily be switched with the existing Text from the ComboBoxEnd.
            ComboBoxStart.Text = ComboBoxEnd.Text;
            ComboBoxEnd.Text = from;
            return;
        }
        //This Event tests if there is Text in the Combobox, if theres Text in the ComboBoxStart, the Connections Button will be disabled,
        //and the Timetable Button ist getting enabled.
        private void ComboBoxStart_TextChanged(object sender, EventArgs e)
        {
            
            
            if(ComboBoxStart.Text != "")
            {
                BtnConnections.Enabled = false;
                BtnTimetable.Enabled = true;
                BtnGmapsStart.Enabled = true;
            }
            
        }
        //This Event tests if there is Text in the Combobox, if theres Text in the ComboBoxStart, the Connections Button will be enabled,
        //and the Timetable Button ist getting disabled.
        private void ComboBoxEnd_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxStart.Text != "")
            {
                BtnConnections.Enabled = true;
                BtnTimetable.Enabled = false;
                BtnGmapsEnd.Enabled = true;

            }
        }
        //Here is the Google Maps intergration, it open the Googe Maps URL and attaches the Text from th ComboBox and the additional Text Haltestelle.
        private void BtnGmapsStart_Click(object sender, EventArgs e)
        {


            //webBrowser1.Navigate("http://www.google.com/maps/place/" + ComboBoxStart.Text + " Haltestelle");
            System.Diagnostics.Process.Start("http://www.google.com/maps/place/" + ComboBoxStart.Text + " Haltestelle");
        }

        private void BtnGmapsEnd_Click(object sender, EventArgs e)
        {
            
            //webBrowser1.Navigate("http://www.google.com/maps/place/" + ComboBoxEnd.Text + " Haltestelle");
            System.Diagnostics.Process.Start("http://www.google.com/maps/place?&z=15/" + ComboBoxEnd.Text + " Haltestelle");
        }
            //"My location" is implemented. Simple, but it works.
        private void BtnMyLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com/maps/search/" + " Mein Standort");
        }

        
    }
}

