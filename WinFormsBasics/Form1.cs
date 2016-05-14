using AirlinePresenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineModel;

namespace WinFormsBasics
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event EventHandler<FlightEventArgs> DeleteFlights;
        public event EventHandler PopulateGrid;

        private void populateButton_Click(object sender, EventArgs e)
        {
            var handler = PopulateGrid;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        void IView.ShowFlights(IEnumerable<Flight> flights)
        {
            dataGridView1.DataSource = flights;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var handler = DeleteFlights;
            List<Flight> flightsToDelete = new List<Flight>();
            foreach(var row in dataGridView1.SelectedRows)
            {
                var dataRow = row as DataGridViewRow;
                flightsToDelete.Add(dataRow.DataBoundItem as Flight);
            }
            dataGridView1.DataSource = null;
            if (handler != null)
            {
                     
                handler(sender, new FlightEventArgs() { Flights = flightsToDelete});
                   
            }

        }
    }
}
