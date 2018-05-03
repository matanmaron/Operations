using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CsvHelper;

namespace SrvFolloweR
{
    internal class Data
    {
        string fname = "data.dat";
        internal bool ReadFile(BindingSource source)
        {
            bool res;
            //read from file
            try
            {
                CsvReader csv = new CsvReader(new StreamReader(fname));
                source.DataSource = csv.GetRecords<Reshuma>().ToList();
                MessageBox.Show("טעינה בוצעה בהצלחה !", "טעינה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
                csv.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("טעינה נכשלה !", "טעינה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = false;
            }
            return res;
        }
        internal void WriteFile(BindingSource source)
        {
            //write to file
            try
            {
                using (StreamWriter sw = new StreamWriter(fname))
                {
                    var writer = new CsvWriter(sw);
                    writer.WriteHeader(typeof(Reshuma));
                    foreach (Reshuma resh in source.DataSource as List<Reshuma>)
                    {
                        writer.WriteRecord(resh);
                    }
                    MessageBox.Show("שמירה בוצעה בהצלחה !", "שמירה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();
                }  
            }
            catch (Exception)
            {
                MessageBox.Show("שמירה נכשלה !", "שמירה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        internal bool NewFile(BindingSource source)
        {
            bool res;
            //write to file
            try
            {
                using (StreamWriter sw = new StreamWriter(fname))
                {
                    var writer = new CsvWriter(sw);
                    writer.WriteHeader(typeof(Reshuma));
                    //foreach (Reshuma resh in source.DataSource as List<Reshuma>)
                    //{
                    //    writer.WriteRecord(resh);
                    //}
                    sw.Close();
                }
                res = true;
            }
            catch (Exception)
            {
                MessageBox.Show("לא ניתן לפתוח קובץ חדש !", "חדש", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = false;
            }
            return res;
        }

    }
}
