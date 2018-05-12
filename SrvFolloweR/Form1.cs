using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SrvFolloweR
{
    public partial class Form1 : Form
    {
        DateTimePicker dtp;
        int selectedReshRow;
        int selectedCallRow;

        public Form1()
        {
            InitializeComponent();
            ReadSettings();
            Load_Autoload_Settings();
            Ui_Language();
            LoadFile();
            DataGrid_Language();
            reshumaBindingSource.DataSource = DataHandler.reshumas;
            HideCalls();
            Update();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (DataHandler.isuser)
            {
                DataHandler.mainfullscreen = !DataHandler.mainfullscreen;
            }
            dtp.Width = dataGridView1.Columns[4].Width;
            dataGridView1.Columns[0].Width = 80;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = false;
            dtp.Width = dataGridView1.Columns[4].Width;
            dataGridView1.Controls.Add(dtp);
            dtp.ValueChanged += this.dtp_ValueChanged;
            dataGridView1.Columns[0].Width = 80;
            FindDates();
            if (DataHandler.mainfullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            DataHandler.isuser = true;
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            WriteSettings();
            SaveFile();
            Environment.Exit(0);
        }
        void Load_Autoload_Settings()
        {
            if (DataHandler.Benglish)
            {
                checkBox_English.Checked = true;
            }
            else
            {
                checkBox_English.Checked = false;
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(selectedReshRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button2_savelist_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void button1_getlist_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
        private void Ui_Language()
        {
            if (!DataHandler.Benglish)
            {
                checkBox_English.Text = "English";
                this.Text = "מבצעים";
            }
            else
            {
                checkBox_English.Text = "עברית";
                this.Text = "Operations";
            }
        }
        private void DataGrid_Language()
        {
            if (!DataHandler.Benglish)
            {
                dataGridView1.RightToLeft = RightToLeft.Yes;
                dataGridView1.Columns[0].HeaderText = "מס'";
                dataGridView1.Columns[1].HeaderText = "חברה";
                dataGridView1.Columns[2].HeaderText = "תחום";
                dataGridView1.Columns[3].HeaderText = "טלפון";
                dataGridView1.Columns[4].HeaderText = "תאריך סיום";
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
                dataGridView1.RightToLeft = RightToLeft.No;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Company";
                dataGridView1.Columns[2].HeaderText = "Field";
                dataGridView1.Columns[3].HeaderText = "Phone Number";
                dataGridView1.Columns[4].HeaderText = "End Date";
                dataGridView2.RightToLeft = RightToLeft.No;
                dataGridView2.Columns[0].HeaderText = "ID";
                dataGridView2.Columns[1].HeaderText = "Reprepresentative";
                dataGridView2.Columns[2].HeaderText = "Call Content";
                dataGridView2.Columns[3].HeaderText = "Call Date";
                dataGridView2.Columns[4].HeaderText = "End Date";
                dataGridView2.Columns[5].HeaderText = "Remarks";
            }
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView2.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView2.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void checkBox_English_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_English.Checked)
            {
                checkBox_English.Checked = true;
                DataHandler.Benglish = true;
            }
            else
            {
                checkBox_English.Checked = false;
                DataHandler.Benglish = false;
            }
            Ui_Language();
            DataGrid_Language();
            this.Update();
        }
        private void button_GetCalls_Click(object sender, EventArgs e)
        {
            SaveFile();
            GetCalls();
        }
        private void ReadSettings()
        {
            if (File.Exists("confg.set"))
            {
                using (StreamReader readtext = new StreamReader("confg.set"))
                {
                    string readMeText = readtext.ReadLine();
                    string[] words = readMeText.Split(';');
                    DataHandler.Benglish = bool.Parse(words[0]);
                }
            }
        }
        internal void WriteSettings()
        {
            using (StreamWriter writetext = new StreamWriter("confg.set"))
            {
                writetext.WriteLine("{0};", DataHandler.Benglish);
            }
        }
        void GetCalls()
        {
            if (dataGridView1.Rows[selectedReshRow].Cells[1].Value != null && dataGridView1.Rows[selectedReshRow].Cells[2].Value != null)
            {
                DataHandler.selectedid = (int)dataGridView1.Rows[selectedReshRow].Cells[0].Value;
            }
            if (DataHandler.selectedid > 0)
            {
                ShowCalls();
            }
        }

        private void ShowCalls()
        {
            dataGridView1.Hide();
            button_GetCalls.Hide();
            button_Back.Show();
            dataGridView2.DataSource = DataHandler.reshumas.Find(x => x.ReshumaId == DataHandler.selectedid).Calls;
            dataGridView2.Show();
        }
        private void HideCalls()
        {
            button_Back.Hide();
            dataGridView2.DataSource = null;
            dataGridView2.Hide();
            dataGridView1.Show();
            button_GetCalls.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFile();
            WriteSettings();
        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dataGridView1.Focused && dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    dtp.Location = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtp.Visible = true;
                    if (dataGridView1.CurrentCell.Value != DBNull.Value)
                    {
                        dtp.Value = (DateTime)dataGridView1.CurrentCell.Value;
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
            //SaveFile();
        }
        private void SaveFile()
        {
            try
            {
                DataHandler.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadFile()
        {
            try
            {
                DataHandler.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Focused && dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    dataGridView1.CurrentCell.Value = dtp.Value.Date;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SaveFile();
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedReshRow = e.RowIndex;
        }
        void FindDates()
        {
            for (int i = 0; i < reshumaBindingSource.Count; i++)
            {
                Reshuma item = (Reshuma)reshumaBindingSource[i];
                string filename = item.Company.ToString() + item.Zone.ToString();
                if (File.Exists(@"Data/" + filename + ".csv"))
                {
                    List<Call> tempcalls;
                    CsvReader ccsv = null;
                    try
                    {
                        ccsv = new CsvReader(new StreamReader(@"Data/" + filename + ".csv"));
                        tempcalls = ccsv.GetRecords<Call>().ToList();
                        ccsv.Dispose();
                        DateTime tempdate = tempcalls[0].CallEnd;
                        foreach (Call call in tempcalls)
                        {
                            if (call.CallEnd > tempdate)
                                tempdate = call.CallEnd;
                        }
                        item.EndDate = tempdate;
                        if (tempdate < DateTime.Today)
                        {
                            dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.PaleVioletRed;
                            this.Update();
                        }
                        else if ((tempdate.Year == DateTime.Today.Year) && (tempdate.Month == DateTime.Today.Month))
                        {
                            dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.DarkOrange;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        ccsv.Dispose();
                    }

                }
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveFile();
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    dataGridView2.Rows.RemoveAt(selectedCallRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCallRow = e.RowIndex;
            dtp.Visible = false;
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedCallRow = e.RowIndex;
            try
            {
                if (dataGridView2.Focused && (dataGridView2.CurrentCell.ColumnIndex == 3 || dataGridView2.CurrentCell.ColumnIndex == 4))
                {
                    dtp.Width = dataGridView2.Columns[e.ColumnIndex].Width;
                    Point myp = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    myp.Y += (dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Height / 2) - (dtp.Size.Height / 2);
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

        private void button_Back_Click(object sender, EventArgs e)
        {
            SaveFile();
            HideCalls();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFile();
            HideCalls();
        }
    }
}