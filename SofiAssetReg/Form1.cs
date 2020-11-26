using Microsoft.VisualBasic.FileIO;
using Nustache.Core;
using OstendoAPI.Api;
using OstendoAPI.Client;
using OstendoAPI.Model;
using SofiAssetReg.Properties;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SofiAssetReg
{
    public partial class Form1 : Form
    {
        public RegFields regFields;


        public Form1()
        {
            InitializeComponent();
            regFields = new RegFields(Properties.Settings.Default.SerialFormat);

            lblLabelModel.DataBindings.Add(new Binding("Text", regFields, "model"));
            lblLabelYear.DataBindings.Add(new Binding("Text", regFields, "year"));
            lblLabelZwave.DataBindings.Add(new Binding("Text", regFields, "zwave"));
            lblLabelPrefix.DataBindings.Add(new Binding("Text", regFields, "serialPrefix"));
            lblLabelMac.DataBindings.Add(new Binding("Text", regFields, "mac"));
            lblLabelSerial.DataBindings.Add(new Binding("Text", regFields, "serial"));
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lableTemplateFileDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtMac.BackColor = Color.LightGreen;
            txtZwave.BackColor = Color.White;
            txtSnPrefix.BackColor = Color.White;
            txtImie.BackColor = Color.White;
            txtSerial.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txtMac.BackColor = Color.White;
            txtZwave.BackColor = Color.LightGreen;
            txtSnPrefix.BackColor = Color.White;
            txtImie.BackColor = Color.White;
            txtSerial.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            txtMac.BackColor = Color.White;
            txtZwave.BackColor = Color.White;
            txtSnPrefix.BackColor = Color.LightGreen;
            txtImie.BackColor = Color.White;
            txtSerial.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            txtMac.BackColor = Color.White;
            txtZwave.BackColor = Color.White;
            txtSnPrefix.BackColor = Color.White;
            txtImie.BackColor = Color.White;
            txtSerial.BackColor = Color.LightGreen;
        }

        private void txtImie_Enter(object sender, EventArgs e)
        {
            txtMac.BackColor = Color.White;
            txtZwave.BackColor = Color.White;
            txtSnPrefix.BackColor = Color.White;
            txtImie.BackColor = Color.LightGreen;
            txtSerial.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtYear.Text = DateTime.Now.Year.ToString();
            ActiveControl = txtModel;

        }

        private void printLabel()
        {
            if (File.Exists(Settings.Default.LabelTemplate))
            {
                var fieldDistionary = regFields.ToDictionary(true);
                var labelFile = Render.FileToString(Settings.Default.LabelTemplate, fieldDistionary);

                var pd = new PrintDialog();
                pd.PrinterSettings = new PrinterSettings();
                pd.PrinterSettings.PrinterName = Settings.Default.PrinterName;

                if (pd.PrinterSettings.IsValid)
                {
                    var bytes = Encoding.ASCII.GetBytes(labelFile);
                    // Send a printer-specific to the printer.
                    RawPrinterHelper.SendBytesToPrinter(pd.PrinterSettings.PrinterName, bytes, bytes.Length);
                }
                else
                {
                    MessageBox.Show("Printer Not Found: \"" + Settings.Default.PrinterName + "\"", "Error", MessageBoxButtons.OK);
                }


            }
            else
            {
                MessageBox.Show("Template File Not Found: \"" + Settings.Default.LabelTemplate + "\"", "Error", MessageBoxButtons.OK);
            }

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var done = false;

            if (e.KeyChar == '\r')
            {
                if (ActiveControl == txtModel)
                {
                    ActiveControl = txtYear;
                    return;
                }

                if (ActiveControl == txtYear)
                {
                    ActiveControl = txtMac;
                    return;
                }

                if (ActiveControl == txtMac)
                {
                    ActiveControl = txtZwave;
                    return;
                }

                if (ActiveControl == txtZwave)
                {
                    ActiveControl = txtImie;
                    return;
                }

                if (ActiveControl == txtImie)
                {
                    ActiveControl = txtSnPrefix;
                    return;
                }

                if (ActiveControl == txtSnPrefix)
                    if (chkSerialGenerate.Checked)
                    {
                        done = true;
                    }
                    else
                    {
                        ActiveControl = txtSerial;
                        return;
                    }

                if (ActiveControl == txtSerial) done = true;

                if (done)
                {
                    //Print Label
                    if (chkPrintLabel.Checked) printLabel();

                    //Register
                    if (chkRegisterAsset.Checked)
                    {
                        registerItem();

                    }

                    //Clear Fields
                    if (chkClearFields.Checked)
                    {
                        txtMac.Text = "";
                        txtZwave.Text = "";
                        txtSerial.Text = "";
                    }

                    ActiveControl = txtMac;
                }
            }
        }

        private void registerItem()
        {
            var myConfig = new Configuration
            {
                BasePath = Settings.Default.Server
            };

            try
            {
                var instance = new AdminsApi(myConfig);
                var apikey = Settings.Default.ApiKey;
                var tablename = "ostdef_systemidupload";
                var keyfield = "dongleid";
                var assetItem = new Ostendoimport(new Register(regFields.zwave, regFields.mac,
                    regFields.imei, regFields.serial));
                instance.AddAsset(apikey, tablename, keyfield, assetItem);
            }
            catch (Exception)
            {
            }
        }

        private void printerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {



            var pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            pd.PrinterSettings.PrinterName = Settings.Default.PrinterName;


            if (DialogResult.OK == pd.ShowDialog(this)) Settings.Default.PrinterName = pd.PrinterSettings.PrinterName;
        }


        private void lableTemplateFileDialog()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Zebra Label (*.prn)|*.prn|All Files (*.*)|*.*";
            if (Settings.Default.LabelTemplate == "")
                ofd.InitialDirectory = Directory.GetCurrentDirectory() + "\\labels";
            else
                ofd.InitialDirectory = Path.GetDirectoryName(Settings.Default.LabelTemplate);


            if (DialogResult.OK == ofd.ShowDialog(this)) Settings.Default.LabelTemplate = ofd.FileName;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            txtSerial.Enabled = !chkSerialGenerate.Checked;
            regFields.autoSerial = chkSerialGenerate.Checked;
        }


        /* [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string property = null)
        {
          if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion*/

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            regFields.year = txtYear.Text;
            if (chkSerialGenerate.Checked)
                txtSerial.Text = regFields.serial;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            regFields.model = txtModel.Text;
            if (chkSerialGenerate.Checked)
                txtSerial.Text = regFields.serial;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            regFields.mac = txtMac.Text;
            if (chkSerialGenerate.Checked)
                txtSerial.Text = regFields.serial;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            regFields.zwave = txtZwave.Text;
            if (chkSerialGenerate.Checked)
                txtSerial.Text = regFields.serial;
        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {
            regFields.imei = txtImie.Text;
            if (chkSerialGenerate.Checked)
                txtSerial.Text = regFields.serial;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            regFields.serialPrefix = txtSnPrefix.Text;
            if (chkSerialGenerate.Checked)
                txtSerial.Text = regFields.serial;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!chkSerialGenerate.Checked)
                regFields.serial = txtSerial.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "CSV (*.csv)|*.csv|All Files (*.*)|*.*";
            if (DialogResult.OK == ofd.ShowDialog(this)) txtBatchFile.Text = ofd.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("Model and Year is required", "Error", MessageBoxButtons.OK);
                return;
            }
            if (File.Exists(txtBatchFile.Text))
            {

                try
                {
                    using (TextFieldParser parser = new TextFieldParser(txtBatchFile.Text))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        while (!parser.EndOfData)
                        {
                            //Processing row
                            string[] fields = parser.ReadFields();
                            if (fields.Length < 4 && !(fields.Contains("MAC") && fields.Contains("ZWAVE") && fields.Contains("IMEI") && fields.Contains("SERIAL")))

                            {
                                MessageBox.Show("Fields Missing", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                while (!parser.EndOfData)
                                {
                                    string[] line = parser.ReadFields();


                                    txtZwave.Text = line[0];
                                    txtMac.Text = line[1];
                                    txtImie.Text = line[2];

                                    if (!chkSerialGenerate.Checked)
                                    {
                                        txtSerial.Text = line[3];
                                    }

                                    if (chkRegisterAsset.Checked)
                                    {
                                        registerItem();
                                    }

                                    if (chkPrintLabel.Checked)
                                    {
                                        printLabel();
                                    }


                                }
                            }
                        }



                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error Importing: \"" + exception.Message + "\"", "Error", MessageBoxButtons.OK);

                }
            }
        }


    }
}