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

            List<Table> tables = _tableService.GetAll();

            MasaCount = tables.Count;
        }

        private ILogEntryService _logEntryService;
        private ITableService _tableService;

        /// <summary>
        /// Global Variables
        /// </summary>
        private int MasaCount;
        List<Panel> panels = new List<Panel>();
        List<Label> labels = new List<Label>();
        List<PictureBox> pboxes = new List<PictureBox>();

        private List<Table> LoadTables()
        {
            return _tableService.GetAll();
        }

        private void AddNewTable()
        {
            Table table = _tableService.CreateTable();
            
            LoadTable(ButtonTableText(table.TableName, 0.00m));
        }

        private void Table_Click(object sender, EventArgs e)
        {
            MasaPanel masa = new MasaPanel();
            masa.Show();
        }

        // deprecated
        //private void LoadTable(decimal balance = 0.00m)
        //{
        //    // Create Table

        //    System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
        //    System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
        //    System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();

        //    System.Windows.Forms.PictureBox pBoxTable = new System.Windows.Forms.PictureBox();
        //    System.Windows.Forms.Panel stPanel = new System.Windows.Forms.Panel();
        //    System.Windows.Forms.Label labelPrice = new System.Windows.Forms.Label();
        //    System.Windows.Forms.Label labelTableID = new System.Windows.Forms.Label();

        //    // 
        //    // stPanel(i)
        //    // 

        //    panels.Add(stPanel);
        //    pboxes.Add(pBoxTable);
        //    labels.Add(labelTableID);
        //    labels.Add(labelPrice);


        //    //  this.stPanel.Controls.Add(labels[1]);
        //    stPanel.Location = new System.Drawing.Point(236, 3);
        //    stPanel.Name = "stPanel" + iteration;
        //    stPanel.Size = new System.Drawing.Size(227, 274);
        //    stPanel.TabIndex = 26;

        //    pBoxTable.Image = global::AlisPark.WebFormsUI.Properties.Resources._1864766__1_;
        //    pBoxTable.Location = new System.Drawing.Point(0, 40);
        //    pBoxTable.Name = "pictureBox" + iteration;
        //    pBoxTable.Size = new System.Drawing.Size(227, 132);
        //    pBoxTable.TabIndex = 0;
        //    pBoxTable.TabStop = false;
        //    pBoxTable.Click += new System.EventHandler(pBoxTable_Click);

        //    // 
        //    // labelPrice
        //    // 
        //    labelPrice.AutoSize = true;
        //    labelPrice.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        //    labelPrice.ForeColor = System.Drawing.Color.RosyBrown;
        //    labelPrice.Location = new System.Drawing.Point(3, 175);
        //    labelPrice.Name = "label" + iteration;
        //    labelPrice.Size = new System.Drawing.Size(206, 26);
        //    labelPrice.TabIndex = 19;
        //    labelPrice.Text = balance + " TL Ödenmedi"; // 0.00 Balance

        //    // 
        //    // labelTableID
        //    // 
        //    labelTableID.AutoSize = true;
        //    labelTableID.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        //    labelTableID.ForeColor = System.Drawing.Color.AliceBlue;
        //    labelTableID.Location = new System.Drawing.Point(3, 9);
        //    labelTableID.Name = "label" + iteration;
        //    labelTableID.Size = new System.Drawing.Size(98, 28);
        //    labelTableID.TabIndex = 4;
        //    labelTableID.Text = "MASA " + (iteration);

        //    stPanel.Controls.Add(labels[0 + (2 * (iteration))]);
        //    stPanel.Controls.Add(labels[0 + 1 + (2 * (iteration))]);
        //    stPanel.Controls.Add(pboxes[iteration]);
        //    this.flowLayoutPanel1.Controls.Add(stPanel);

        //    iteration++;
        //}

        private void LoadTable(string tableText, bool online = true)
        {
            System.Windows.Forms.Button Table = new System.Windows.Forms.Button();
            // 
            // Table
            // 
            if(online)
                Table.BackColor = System.Drawing.Color.LimeGreen; // whether table is open or not
            else
                Table.BackColor = System.Drawing.Color.IndianRed;

            Table.FlatAppearance.BorderSize = 0;
            Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Table.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Table.ForeColor = System.Drawing.Color.White;
            Table.Location = new System.Drawing.Point(3, 3);
            Table.Name = "Table";
            Table.Size = new System.Drawing.Size(187, 121);
            Table.TabIndex = 0;
            Table.Text = tableText;
            Table.UseVisualStyleBackColor = false;
            Table.Click += new System.EventHandler(Table_Click);

            this.TableLayoutPanel.Controls.Add(Table);
        }

        private string ButtonTableText(string tableName, decimal tableBalance)
        {
            return tableName + "\nÖdeme: " + tableBalance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Table> tables = _tableService.GetAll();
            MasaCount = tables.Count;           

            AddNewTable(); // Add a table to database
        }

        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            foreach (Table tab in LoadTables())
            {
                LoadTable(ButtonTableText(tab.TableName, tab.TableBalance));
            }
        }
    }
}
