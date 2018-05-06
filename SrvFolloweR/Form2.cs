using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SrvFolloweR
{
    public partial class Form2 : Form1
    {
        internal List<Call> callslist;
        //internal static double LastCallId = 1;
        DateTimePicker dtp;
        string formHeader;
        int selectedrow;

        public Form2(string callsfilename)
        {
            formHeader = callsfilename;
            InitializeComponent();
            callslist = new List<Call>();
            callBindingSource.DataSource = callslist;
            //CsvLoad();
            Ui_Language();
            DataGrid_Language();
            Update();
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            if (DataHandler.isuser)
            {
                DataHandler.mainfullscreen = !DataHandler.mainfullscreen;
            }
            dtp.Width = dataGridView2.Columns[4].Width;
            dataGridView2.Columns[0].Width = 80;
            dataGridView2.Columns[1].Width = 100;
            if (DataHandler.mainfullscreen)
                dataGridView2.Columns[2].Width = 600;
            else
                dataGridView2.Columns[2].Width = 300;
            dataGridView2.Columns[5].Width = 200;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = false;
            dtp.Font = new Font("Microsoft Sans Serif", 14);
            dataGridView2.Controls.Add(dtp);
            dtp.ValueChanged += this.dtp_ValueChanged;
            dataGridView2.Columns[0].Width = 80;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Width = 300;
            dataGridView2.Columns[5].Width = 200;
            dataGridView2.Columns[2].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView2.Columns[5].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            if (DataHandler.mainfullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            DataHandler.isuser = true;
        }
        private void Ui_Language()
        {
            this.Text = formHeader;
        }
        private void DataGrid_Language()
        {
            if (!DataHandler.Benglish)
            {
                dataGridView2.RightToLeft = RightToLeft.Yes;
                dataGridView2.Columns[0].HeaderText = "מס'";
                dataGridView2.Columns[1].HeaderText = "נציג";
                dataGridView2.Columns[2].HeaderText = "תוכן השיחה";
                dataGridView2.Columns[3].HeaderText = "תאריך שיחה";
                dataGridView2.Columns[4].HeaderText = "סיום מבצע";
                dataGridView2.Columns[5].HeaderText = "הערות";
            }
            else
            {
                dataGridView2.RightToLeft = RightToLeft.No;
                dataGridView2.Columns[0].HeaderText = "ID";
                dataGridView2.Columns[1].HeaderText = "Reprepresentative";
                dataGridView2.Columns[2].HeaderText = "Call Content";
                dataGridView2.Columns[3].HeaderText = "Call Date";
                dataGridView2.Columns[4].HeaderText = "End Date";
                dataGridView2.Columns[5].HeaderText = "Remarks";
            }
            dataGridView2.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView2.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void button_LoadCalls_Click(object sender, EventArgs e)
        {
            //LoadCalls();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            //LastSave();
            Form1 form1 = new Form1();
            this.Close();
            form1.Close();
            form1.WriteSettings();
            SaveFile();
            Environment.Exit(0);
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        void LoadFile()
        {
            DataHandler.Load();
        }
        void SaveFile()
        {
            DataHandler.Save();
        }
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Focused && dataGridView2.CurrentCell.ColumnIndex == 0)
            {
                if (callBindingSource != null)
                {
                    Call temp = (Call)callBindingSource[callBindingSource.Count - 1];
                    //LastCallId = temp.CallID + 1;
                }
            }
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.CurrentCell.Value = dtp.Text;
        }
        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    dataGridView2.Rows.RemoveAt(selectedrow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtp.Visible = false;
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            try
            {
                if (dataGridView2.Focused && (dataGridView2.CurrentCell.ColumnIndex == 3 || dataGridView2.CurrentCell.ColumnIndex == 4))
                {
                    dtp.Width = dataGridView2.Columns[e.ColumnIndex].Width;
                    Point myp = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    myp.Y += (dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Height / 2) - (dtp.Size.Height/2);
                    dtp.Location = myp;
                    dtp.Visible = true;
                    dtp.Size = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Size;
                    if (dataGridView2.CurrentCell.Value != DBNull.Value)
                    {
                        dtp.Value = (DateTime)dataGridView2.CurrentCell.Value;
                    }
                    else
                    {
                        dtp.Value = DateTime.Today;
                    }
                }
                else
                {
                    dtp.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}