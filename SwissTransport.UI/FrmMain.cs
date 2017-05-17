using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport
{
    public partial class FrmMain : Form
    {
        Transport mainTransport;
        public FrmMain()
        {
            InitializeComponent();

        }

        private void BtnConnections_Click(object sender, EventArgs e)
        {

            
                
            
            //SwissTransport.Transport transport = new SwissTransport.Transport();
            var foundConnections = transport.GetConnections(ComboBoxStart.Text, ComboBoxEnd.Text);
            ListViewResult.Items.Clear();
            foreach (Connection conn in transport.GetConnections(ComboBoxStart.Text, ComboBoxEnd.Text).ConnectionList)
            {
                DateTime departure = DateTime.Parse(conn.From.Departure);
                DateTime arrival = DateTime.Parse(conn.To.Arrival);
                String[] item = { conn.From.Platform, departure.ToString(), conn.Duration, arrival.ToString()};
                ListViewItem lvitem = new ListViewItem(item);
                ListViewResult.Items.Add(lvitem);
            }
        }

      
        private void ComboBoxStartStop_DropDown(object sender, EventArgs e)
        {
            ComboBox comboboxload = (ComboBox)sender;
            SwissTransport.Transport transport = new SwissTransport.Transport();
            var foundStations = transport.GetStations(comboboxload.Text);

            foreach(var station in foundStations.StationList)
            {
                comboboxload.Items.Add(station.Name);
            }
            
        }

        private void btnTimeable_Click(object sender, EventArgs e)
        {
            ListViewResult.Items.Clear();
            string Abfahrt = ComboBoxStart.SelectedItem.ToString();
            string id = mainTransport.GetStations(Abfahrt).StationList[0].Id;
            StationBoardRoot stationboardroot = mainTransport.GetStationBoard(Abfahrt, id);
            foreach (StationBoardRoot stationboard in stationboardroot.Entries);
            {
                //foreach machen micha bild
            }



            StationBoardRoot. = new SwissTransport.StationBoard();
            var foundDepartures = StationBoard.GetStationBoard(ComboBoxStart.Text);
            ListViewResult.Items.Clear();
            foreach (StationBoard conn in transport.GetStationBoard(ComboBoxStart.Text).ConnectionList)
            {
                DateTime departure = DateTime.Parse(conn.From.Departure);
                DateTime arrival = DateTime.Parse(conn.To.Arrival);
                String[] item = { conn.From.Platform, departure.ToString(), conn.Duration, arrival.ToString() };
                ListViewItem lvitem = new ListViewItem(item);
                ListViewResult.Items.Add(lvitem);
            }
        }
    }
}
