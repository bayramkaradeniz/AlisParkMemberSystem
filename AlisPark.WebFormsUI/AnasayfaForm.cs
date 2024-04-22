using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AlisPark.Entities.Concrete;
using System.Diagnostics;

namespace AlisPark.WebFormsUI
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();
            _tableService = InstanceFactory.GetInstance<ITableService>();            
        }

        private ILogEntryService _logEntryService;
        private ITableService _tableService;

        /// <summary>
        /// Global Variables
        /// </summary>
        private int MasaCount = 100;
        List<Panel> panels = new List<Panel>();
        List<Label> labels = new List<Label>();
        List<PictureBox> pboxes = new List<PictureBox>();

        private List<Table> LoadTables()
        {
            return _tableService.GetAll();
        }

        private void AddNewTable()
        {
            _tableService.CreateTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // _tableService.AddNewTable();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MasaPanel masa = new MasaPanel();
            masa.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MasaPanel_Click()
        {
            MasaPanel masa = new MasaPanel();
            masa.Show();
        }

        private void pBoxTable_Click(object sender, EventArgs e)
        {
            MasaPanel masa = new MasaPanel();
            masa.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MasaPanel masa = new MasaPanel();
            masa.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MasaPanel masa = new MasaPanel();
            masa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Table

            

            System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label(); 
            System.Windows.Forms.Label label5 = new System.Windows.Forms.Label(); 

            System.Windows.Forms.PictureBox pBoxTable = new System.Windows.Forms.PictureBox();
            System.Windows.Forms.Panel stPanel = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label labelPrice = new System.Windows.Forms.Label(); 
            System.Windows.Forms.Label labelTableID = new System.Windows.Forms.Label();

            // 
            // stPanel(i)
            // 



            panels.Add(stPanel);
            pboxes.Add(pBoxTable);
            labels.Add(labelTableID);
            labels.Add(labelPrice);
            

         //   this.stPanel.Controls.Add(labels[1]);
            stPanel.Location = new System.Drawing.Point(236, 3);
            stPanel.Name = "stPanel"+MasaCount;
            stPanel.Size = new System.Drawing.Size(227, 274);
            stPanel.TabIndex = 26;

            pBoxTable.Image = global::AlisPark.WebFormsUI.Properties.Resources._1864766__1_;
            pBoxTable.Location = new System.Drawing.Point(0, 40);
            pBoxTable.Name = "pictureBox"+MasaCount;
            pBoxTable.Size = new System.Drawing.Size(227, 132);
            pBoxTable.TabIndex = 0;
            pBoxTable.TabStop = false;
            pBoxTable.Click += new System.EventHandler( pBoxTable_Click );

            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            labelPrice.ForeColor = System.Drawing.Color.RosyBrown;
            labelPrice.Location = new System.Drawing.Point(3, 175);
            labelPrice.Name = "label"+MasaCount;
            labelPrice.Size = new System.Drawing.Size(206, 26);
            labelPrice.TabIndex = 19;
            labelPrice.Text = "250,22" + "  TL Ödenmedi";

            // 
            // labelTableID
            // 
            labelTableID.AutoSize = true;
            labelTableID.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            labelTableID.ForeColor = System.Drawing.Color.AliceBlue;
            labelTableID.Location = new System.Drawing.Point(3, 9);
            labelTableID.Name = "label" + MasaCount;
            labelTableID.Size = new System.Drawing.Size(98, 28);
            labelTableID.TabIndex = 4;
            labelTableID.Text = "MASA " + (MasaCount - 100);

            stPanel.Controls.Add(labels[0 + (2*(MasaCount-100))]);
            stPanel.Controls.Add(labels[0 + 1 + (2*(MasaCount-100))]);
            stPanel.Controls.Add(pboxes[MasaCount - 100]);
            this.flowLayoutPanel1.Controls.Add(stPanel);
            MasaCount++;

           
            AddNewTable(); // Add a table to database
        }

        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            foreach (Table tab in LoadTables())
            {
                button1_Click(sender, e);
            }
        }
    }
}
