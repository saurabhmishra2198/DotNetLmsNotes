using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudOperation.BLL;
namespace CrudOperation.PLL
{
    public partial class EventDate : Form
    {
        readonly EventBLL eventBLL = new EventBLL();
        public int result;
        public int eventId;
        public string eventName;
        public decimal eventPrice;
        public string eventDateTime;
        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = eventBLL.GetEventDetails();
        }
        private void DefaultFormData()
        {
            EventId.Text = "0";
            EventName.Text = "";
            EventPrice.Text = "0";
        }
        public EventDate()
        {
            InitializeComponent();
            DefaultFormData();
            UpdateDataGridView();
        }
        public void GetEventData()
        {
            eventId = Convert.ToInt32(EventId.Text);
            eventName = EventName.Text;
            eventPrice = Convert.ToDecimal(EventPrice.Text);
            eventDateTime = EventDateTime.Text;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            GetEventData();
            result = eventBLL.InsertData(eventId,eventName,eventPrice,eventDateTime);
            if (result == 1)
            {
                MessageBox.Show("Event record inserted sucessfully!");
            }
            else
            {
                MessageBox.Show("Event record not inserted!");
            }
            UpdateDataGridView();
            DefaultFormData();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            GetEventData();
            result = eventBLL.DeleteData(eventId);
            if (result == 1)
            {
                MessageBox.Show("Event record deleted sucessfully!");
            }
            else
            {
                MessageBox.Show("Event record not deleted!");
            }
            UpdateDataGridView();
            DefaultFormData();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            GetEventData();
            result = eventBLL.UpdateData(eventId, eventName);
            if (result == 1)
            {
                MessageBox.Show("Event record updated sucessfully!");
            }
            else
            {
                MessageBox.Show("Event record not updated!");
            }
            UpdateDataGridView();
            DefaultFormData();
        }
        private void Display_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
            DefaultFormData();
        }
    }
}
