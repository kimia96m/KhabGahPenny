using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhabGahe_Penny
{
    public partial class Form_AddNewRoom : Form
    {
        Function fc = new Function();
        string query;
        public Form_AddNewRoom()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_AddNewRoom_Load(object sender, EventArgs e)
        {
            labelRoomExists.Visible = false;
            labelRoom.Visible = false;
            query = "select * from Rooms";
            DataSet ds = fc.getData(query);
            RoomsTable.DataSource = ds.Tables[0];
        }

        private void ButtonAddRoom_Click(object sender, EventArgs e)
        {
            var a = textBoxRoomNumber_AddRoom.Text;
            query = $"select * from Rooms where RoomNumber='{a}'";
            DataSet ds = fc.getData(query);
            if (ds.Tables[0].Rows.Count == 0) {
                string status;
                if (checkBoxActivateNewRoom.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "NO";
                }
                labelRoomExists.Visible = false;
                query = $"insert into Rooms (RoomNumber,RoomStatus) values ({a},'{status}')";
                fc.setData(query, "Room Added succeed.");
                Form_AddNewRoom_Load(this, null);
            }
            else {
                labelRoomExists.Text = "Room already exists.";
                labelRoomExists.Visible = true;
            }
        }

        private void ButtonRoomNumber_UpdateOrDelete_Click(object sender, EventArgs e)
        {
            var a = textBoxRoomNumber_UpdateOrDelete.Text;
            query = $"select * from Rooms where RoomNumber='{a}'";
            DataSet ds = fc.getData(query);
            if (ds.Tables[0].Rows.Count == 0) {
                labelRoom.Text = "Room Does Not Exist!";
                labelRoom.Visible = true;
                checkBoxActivateUpdateDeleteRoom.Checked = false;
            }
            else
            {
                labelRoom.Text = "Room Is Found.";
                labelRoom.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes") {
                    checkBoxActivateUpdateDeleteRoom.Checked = true;
                }
                else {
                    checkBoxActivateUpdateDeleteRoom.Checked = false;
                }
            }
        }

        private void ButtonUpdateRoom_Click(object sender, EventArgs e)
        {
            var a = textBoxRoomNumber_UpdateOrDelete.Text;
            string status;
            if (checkBoxActivateUpdateDeleteRoom.Checked)
            {
                status = "Yes";
            }
            else { status = "No"; }
            query = $"update Rooms set RoomStatus='{status}' where RoomNumber={a}";
            fc.setData(query, "Room Updated");
            Form_AddNewRoom_Load(this, null);
        }

        private void ButtonDeleteRoom_Click(object sender, EventArgs e)
        {
            var a = textBoxRoomNumber_UpdateOrDelete.Text;
            if (labelRoom.Text== "Room Is Found.")
            {
                query = $"delete from Rooms where RoomNumber={a}";
                fc.setData(query, "Deleted.");
                Form_AddNewRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Can Not Be Deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
