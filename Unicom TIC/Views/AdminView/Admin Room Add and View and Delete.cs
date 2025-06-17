using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Controller;
using Unicom_TIC.Model;

namespace Unicom_TIC.Views.AdminView
{
    public partial class Admin_Room_Add_and_View_and_Delete : UserControl
    {
        private int selectedRoomId = -1;

        public Admin_Room_Add_and_View_and_Delete()
        {
           
            InitializeComponent();
            AminRoomView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AminRoomView.MultiSelect = false;
            AminRoomView.CellContentClick += AminRoomView_CellContentClick;
            AminRoomView.CellClick += AminRoomView_CellClick;

            LoadRooms();
        }

        // ============================ VIEW ============================
        public void LoadRooms()
        {
            var controller = new RoomController();
            List<Room> rooms = controller.ViewAllRooms();

            AminRoomView.DataSource = null;
            AminRoomView.DataSource = rooms;
        }

        private void Admin_Room_Add_and_View_and_Delete_Load(object sender, EventArgs e)
        {
            // ============================ Add items to the role dropdown ============================
            AdminRoomRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            if (AdminRoomRoomType.Items.Count == 0)
            {
                AdminRoomRoomType.Items.Add("Lab");
                AdminRoomRoomType.Items.Add("Hall");
            }
            LoadRooms(); ;
            
        }

        private void AdminRoomSave_Click(object sender, EventArgs e)
        {
            // Room Object Creation ================================================================
            Room room = new Room
            {
                RoomName = AdminRoomRoomName.Text,
                RoomType = AdminRoomRoomType.Text,


            };



            // ============================ Input Validation ============================
            if (string.IsNullOrWhiteSpace(AdminRoomRoomName.Text) ||
                string.IsNullOrWhiteSpace(AdminRoomRoomType.Text) 
                
               )

            {
                MessageBox.Show("Please enter room details", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };

            // ============================ Save using Controller ONLY ============================
            RoomController roomController = new RoomController();


            try
            {
                roomController.AddRoom(room);
                MessageBox.Show("New Room Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFields();
            LoadRooms();
        }

        private void ClearFields()
        {
            AdminRoomRoomName.Text = "";
            AdminRoomRoomType.SelectedIndex = -1;
            selectedRoomId = -1;
            AminRoomView.ClearSelection();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AdminRoomDelete_Click(object sender, EventArgs e)
        {
            DeleteRoom();
        }

        private void DeleteRoom()
        {
            if (AminRoomView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = AminRoomView.SelectedRows[0].Index;
                int roomID = Convert.ToInt32(AminRoomView.Rows[selectedRowIndex].Cells["RoomID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    RoomController controller = new RoomController();
                    controller.DeleteRoom(roomID);
                    MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRooms();
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void AdminRoomUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room from the list to update.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(AdminRoomRoomName.Text) ||
                string.IsNullOrWhiteSpace(AdminRoomRoomType.Text))
            {
                MessageBox.Show("Room Name and Type are required.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var room = new Room
            {
                RoomID = selectedRoomId,
                RoomName = AdminRoomRoomName.Text.Trim(),
                RoomType = AdminRoomRoomType.Text.Trim()
            };

            try
            {
                new RoomController().UpdateRoom(room);
                MessageBox.Show("Room updated successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                selectedRoomId = -1;
                ClearFields();
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ============================ DATAGRIDVIEW EVENTS ============================
        private void AminRoomView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AminRoomView.Rows[e.RowIndex];
                selectedRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
                AdminRoomRoomName.Text = row.Cells["RoomName"].Value.ToString() ?? "";
                AdminRoomRoomType.Text = row.Cells["RoomType"].Value.ToString();
            }
        }
        private void AminRoomView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AdminRoomRoomName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
