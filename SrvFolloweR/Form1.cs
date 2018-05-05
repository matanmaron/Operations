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
        List<Reshuma> resh;
        internal static bool Benglish = false;
        internal static bool mainfullscreen = false;
        internal static bool isuser = false;
        internal static int LastId = 1;
        DateTimePicker dtp;
        int selectedrow;
        internal static string callsfilename;

        #region form handaling
        public Form1()
        {
            InitializeComponent();
            resh = new List<Reshuma>();
            ReadSettings();
            Load_Autoload_Settings();
            Ui_Language();
            CsvLoad();
            DataGrid_Language();
            reshumaBindingSource.DataSource = resh;
            Update();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (isuser)
            {
                mainfullscreen = !mainfullscreen;
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
            if (mainfullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            isuser = true;
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            WriteSettings();
            CsvSave();
            Environment.Exit(0);
        }
        void Load_Autoload_Settings()
        {
            if (Benglish)
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
                    dataGridView1.Rows.RemoveAt(selectedrow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region ui handaling
        private void button2_savelist_Click(object sender, EventArgs e)
        {
            CsvSave();
        }
        private void button1_getlist_Click(object sender, EventArgs e)
        {
            CsvLoad();
        }
        private void Ui_Language()
        {
            if (!Benglish)
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
            if (!Benglish)
            {
                dataGridView1.RightToLeft = RightToLeft.Yes;
                dataGridView1.Columns[0].HeaderText = "מס'";
                dataGridView1.Columns[1].HeaderText = "חברה";
                dataGridView1.Columns[2].HeaderText = "תחום";
                dataGridView1.Columns[3].HeaderText = "טלפון";
                dataGridView1.Columns[4].HeaderText = "תאריך סיום";
            }
            else
            {
                dataGridView1.RightToLeft = RightToLeft.No;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Company";
                dataGridView1.Columns[2].HeaderText = "Field";
                dataGridView1.Columns[3].HeaderText = "Phone Number";
                dataGridView1.Columns[4].HeaderText = "End Date";
            }
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.LightGray;
        }
        private void checkBox_English_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_English.Checked)
            {
                checkBox_English.Checked = true;
                Benglish = true;
            }
            else
            {
                checkBox_English.Checked = false;
                Benglish = false;
            }
            Ui_Language();
            DataGrid_Language();
            this.Update();
        }

        private void button_GetCalls_Click(object sender, EventArgs e)
        {
            CsvSave();
            GetCalls();
        }
        #endregion

        #region save-load handaling
        internal void CsvSave()
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            //FileStream stream = new FileStream(@"Data/dat.xml", FileMode.OpenOrCreate);
            //if (reshumaBindingSource == null) { return; }
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(reshumaBindingSource.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, reshumaBindingSource);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(@"Data/dat.xml");
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        internal void CsvLoad()
        {
            List<Reshuma> objectOut = default(List<Reshuma>);
            if (File.Exists(@"Data/dat.xml"))
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(@"Data/dat.xml");
                    string xmlString = xmlDocument.OuterXml;

                    using (StringReader read = new StringReader(xmlString))
                    {
                        Type outType = typeof(Reshuma);

                        XmlSerializer serializer = new XmlSerializer(outType);
                        using (XmlReader reader = new XmlTextReader(read))
                        {
                            objectOut = (List<Reshuma>)serializer.Deserialize(reader);
                            reader.Close();
                        }

                        read.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            resh = objectOut;
        }
        private void ReadSettings()
        {
            if (File.Exists("confg.set"))
            {
                using (StreamReader readtext = new StreamReader("confg.set"))
                {
                    string readMeText = readtext.ReadLine();
                    string[] words = readMeText.Split(';');
                    Benglish = bool.Parse(words[0]);
                }
            }
        }
        internal void WriteSettings()
        {
            using (StreamWriter writetext = new StreamWriter("confg.set"))
            {
                writetext.WriteLine("{0};{1}", Benglish);
            }
        }
        void GetCalls()
        {
            if (dataGridView1.Rows[selectedrow].Cells[1].Value!=null && dataGridView1.Rows[selectedrow].Cells[2].Value != null)
            {
                callsfilename = dataGridView1.Rows[selectedrow].Cells[1].Value.ToString() + dataGridView1.Rows[selectedrow].Cells[2].Value.ToString();
            }
                if (callsfilename != "" && callsfilename != null)
            {
                Form2 form2 = new Form2(callsfilename);
                form2.Show();
                isuser = false;
                this.Hide();
            }
        }
        #endregion

        #region cell handeling
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteSettings();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dataGridView1.Focused && dataGridView1.CurrentCell.ColumnIndex==4)
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
            CsvSave();
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

            if (dataGridView1.Focused && dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                if (reshumaBindingSource.Count > 0)
                {
                    Reshuma temp = (Reshuma)reshumaBindingSource[reshumaBindingSource.Count - 1];
                    LastId = temp.ReshumaId + 1;
                }
            }
            CsvSave();
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
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
        #endregion
    }
}
