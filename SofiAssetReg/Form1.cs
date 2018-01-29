using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nustache.Core;
using OstendoAPI.Api;
using OstendoAPI.Client;
using OstendoAPI.Model;
using SofiAssetReg.Annotations;

namespace SofiAssetReg
{
    public partial class Form1 : Form
    {

        public RegFields regFields;
        
        




        public Form1()
        {
            InitializeComponent();
            regFields = new RegFields();

            label8.DataBindings.Add(new Binding("Text", this.regFields, "model"));
            label7.DataBindings.Add(new Binding("Text", this.regFields, "year"));
            label9.DataBindings.Add(new Binding("Text", this.regFields, "zwave"));
            label10.DataBindings.Add(new Binding("Text", this.regFields, "imei"));
            label11.DataBindings.Add(new Binding("Text", this.regFields, "mac"));
            label12.DataBindings.Add(new Binding("Text", this.regFields, "serial"));

       //     var html = Render.FileToString(Properties.Settings.Default.LabelTemplate, regFields.ToDictionary());





        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGreen;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.LightGreen;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.LightGreen;
            textBox4.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.LightGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox5;

        }

        private void printLabel()
        {
            string s = "A50,50,0,2,1,1,N,\"9129302\"\n";
            s += "P1\n";

            // Allow the user to select a printer.
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();

            pd.PrinterSettings.PrinterName = Properties.Settings.Default.PrinterName;
          //  Properties.Settings.Default.Properties.
                //      if (DialogResult.OK == pd.ShowDialog(this))
                //      {
                var bytes = Encoding.ASCII.GetBytes(s);
                // Send a printer-specific to the printer.
                RawPrinterHelper.SendBytesToPrinter(pd.PrinterSettings.PrinterName, bytes, bytes.Length);
                MessageBox.Show("Data sent to printer.");
        //    }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool done = false;

            if (e.KeyChar == '\r')
            {
                if (this.ActiveControl == textBox5)
                {
                    this.ActiveControl = textBox6;
                    return;
                }

                if (this.ActiveControl == textBox6)
                {
                    this.ActiveControl = textBox1;
                    return;
                }

                if (this.ActiveControl == textBox1)
                {
                    this.ActiveControl = textBox2;
                    return;
                }

                if (this.ActiveControl == textBox2)
                {
                    this.ActiveControl = textBox3;
                    return;
                }

                if (this.ActiveControl == textBox3)
                {
                    if (checkBox4.Checked)
                    {
                        done = true;
                    }
                    else
                    {
                        this.ActiveControl = textBox4;
                        return;
                    }
                    
                }

                if (this.ActiveControl == textBox4)
                {
                    done = true;
                }

                if (done)
                {
                    //Print Label
                    if (checkBox1.Checked)
                    {
                        printLabel();
                    }

                    //Register
                    if (checkBox2.Checked)
                    {
                        Configuration myConfig = new Configuration()
                        {
                            BasePath = Properties.Settings.Default.Server,

                           
                        };

                        try
                        {
                            AdminsApi instance = new AdminsApi(myConfig);

                            string apikey = Properties.Settings.Default.ApiKey;
                            string tablename = "ostdef_systemidupload";
                            string keyfield = "dongleid";
                            Ostendoimport assetItem = new Ostendoimport(new Register(regFields.zwave, regFields.mac,
                                regFields.imei, regFields.serial));
                            instance.AddAsset(apikey, tablename, keyfield, assetItem);

                            
                        }
                        catch(Exception )
                        {
                            
                        }



                    }

                    //Clear Fields
                    if (checkBox3.Checked)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }

                    this.ActiveControl = textBox1;
                    return;
                }
            }
        }

        private void printerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lableTemplateFileDialog();


            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            pd.PrinterSettings.PrinterName = Properties.Settings.Default.PrinterName;


            if (DialogResult.OK == pd.ShowDialog(this))
            {
                Properties.Settings.Default.PrinterName = pd.PrinterSettings.PrinterName;
            }
        }


        private void lableTemplateFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Zebra Label (*.lbl)|*.lbl|All Files (*.*)|*.*";
            if (Properties.Settings.Default.LabelTemplate == "")
            {
               ofd.InitialDirectory = Directory.GetCurrentDirectory() + "\\labels";
                 

            }
            else
            {
                ofd.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.LabelTemplate);


            }



            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                Properties.Settings.Default.LabelTemplate = ofd.FileName;
                }


        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = !checkBox4.Checked;
            regFields.autoSerial = checkBox4.Checked;
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
            regFields.year = textBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            regFields.model = textBox5.Text;
            if (checkBox4.Checked)
                textBox4.Text = regFields.serial;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            regFields.mac = textBox1.Text;
            if (checkBox4.Checked)
                textBox4.Text = regFields.serial;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            regFields.zwave = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            regFields.imei = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
                regFields.serial = textBox4.Text;
        }
    }
}
