using System.Windows.Forms;

namespace SwissTransport
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ComboBoxStart = new System.Windows.Forms.ComboBox();
            this.ComboBoxEnd = new System.Windows.Forms.ComboBox();
            this.DateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.BtnConnections = new System.Windows.Forms.Button();
            this.DateTimeClock = new System.Windows.Forms.DateTimePicker();
            this.BtnSwap = new System.Windows.Forms.Button();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListViewResult = new System.Windows.Forms.ListView();
            this.clmto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmdeparture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOperator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmarrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmtrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnTimetable = new System.Windows.Forms.Button();
            this.BtnGmapsStart = new System.Windows.Forms.Button();
            this.BtnGmapsEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMyLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxStart
            // 
            this.ComboBoxStart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxStart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxStart.FormattingEnabled = true;
            this.ComboBoxStart.Location = new System.Drawing.Point(5, 120);
            this.ComboBoxStart.Name = "ComboBoxStart";
            this.ComboBoxStart.Size = new System.Drawing.Size(243, 24);
            this.ComboBoxStart.TabIndex = 0;
            this.ComboBoxStart.DropDown += new System.EventHandler(this.ComboBoxStartStop_DropDown);
            this.ComboBoxStart.TextChanged += new System.EventHandler(this.ComboBoxStart_TextChanged);
            // 
            // ComboBoxEnd
            // 
            this.ComboBoxEnd.FormattingEnabled = true;
            this.ComboBoxEnd.Location = new System.Drawing.Point(421, 120);
            this.ComboBoxEnd.Name = "ComboBoxEnd";
            this.ComboBoxEnd.Size = new System.Drawing.Size(243, 24);
            this.ComboBoxEnd.TabIndex = 1;
            this.ComboBoxEnd.DropDown += new System.EventHandler(this.ComboBoxStartStop_DropDown);
            this.ComboBoxEnd.TextChanged += new System.EventHandler(this.ComboBoxEnd_TextChanged);
            // 
            // DateTimeDate
            // 
            this.DateTimeDate.Location = new System.Drawing.Point(762, 89);
            this.DateTimeDate.Name = "DateTimeDate";
            this.DateTimeDate.Size = new System.Drawing.Size(157, 22);
            this.DateTimeDate.TabIndex = 2;
            // 
            // BtnConnections
            // 
            this.BtnConnections.Enabled = false;
            this.BtnConnections.Location = new System.Drawing.Point(5, 150);
            this.BtnConnections.Name = "BtnConnections";
            this.BtnConnections.Size = new System.Drawing.Size(157, 43);
            this.BtnConnections.TabIndex = 3;
            this.BtnConnections.Text = "Verbindung suchen";
            this.BtnConnections.UseVisualStyleBackColor = true;
            this.BtnConnections.Click += new System.EventHandler(this.BtnConnections_Click);
            // 
            // DateTimeClock
            // 
            this.DateTimeClock.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimeClock.Location = new System.Drawing.Point(762, 120);
            this.DateTimeClock.Name = "DateTimeClock";
            this.DateTimeClock.ShowUpDown = true;
            this.DateTimeClock.Size = new System.Drawing.Size(157, 22);
            this.DateTimeClock.TabIndex = 4;
            // 
            // BtnSwap
            // 
            this.BtnSwap.Location = new System.Drawing.Point(340, 89);
            this.BtnSwap.Name = "BtnSwap";
            this.BtnSwap.Size = new System.Drawing.Size(75, 57);
            this.BtnSwap.TabIndex = 6;
            this.BtnSwap.Text = "----->\r\n<-----\r\n";
            this.BtnSwap.UseVisualStyleBackColor = true;
            this.BtnSwap.Click += new System.EventHandler(this.btnswap_Click);
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(SwissTransport.Transport);
            // 
            // ListViewResult
            // 
            this.ListViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmto,
            this.clmdeparture,
            this.clmOperator,
            this.clmarrival,
            this.clmtrack});
            this.ListViewResult.Location = new System.Drawing.Point(5, 199);
            this.ListViewResult.Name = "ListViewResult";
            this.ListViewResult.Size = new System.Drawing.Size(914, 423);
            this.ListViewResult.TabIndex = 7;
            this.ListViewResult.UseCompatibleStateImageBehavior = false;
            this.ListViewResult.View = System.Windows.Forms.View.Details;
            // 
            // clmto
            // 
            this.clmto.Text = "Nach";
            this.clmto.Width = 107;
            // 
            // clmdeparture
            // 
            this.clmdeparture.Text = "Abfahrt";
            this.clmdeparture.Width = 207;
            // 
            // clmOperator
            // 
            this.clmOperator.Text = "Betreiber";
            this.clmOperator.Width = 126;
            // 
            // clmarrival
            // 
            this.clmarrival.Text = "Ankunft";
            this.clmarrival.Width = 253;
            // 
            // clmtrack
            // 
            this.clmtrack.Text = "Gleis";
            // 
            // BtnTimetable
            // 
            this.BtnTimetable.BackColor = System.Drawing.Color.Gray;
            this.BtnTimetable.Enabled = false;
            this.BtnTimetable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnTimetable.Location = new System.Drawing.Point(762, 150);
            this.BtnTimetable.Name = "BtnTimetable";
            this.BtnTimetable.Size = new System.Drawing.Size(157, 43);
            this.BtnTimetable.TabIndex = 8;
            this.BtnTimetable.Text = "Fahrplan anzeigen";
            this.BtnTimetable.UseVisualStyleBackColor = false;
            this.BtnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // BtnGmapsStart
            // 
            this.BtnGmapsStart.Enabled = false;
            this.BtnGmapsStart.Location = new System.Drawing.Point(254, 89);
            this.BtnGmapsStart.Name = "BtnGmapsStart";
            this.BtnGmapsStart.Size = new System.Drawing.Size(71, 57);
            this.BtnGmapsStart.TabIndex = 9;
            this.BtnGmapsStart.Text = "Maps";
            this.BtnGmapsStart.UseVisualStyleBackColor = true;
            this.BtnGmapsStart.Click += new System.EventHandler(this.BtnGmapsStart_Click);
            // 
            // BtnGmapsEnd
            // 
            this.BtnGmapsEnd.Enabled = false;
            this.BtnGmapsEnd.Location = new System.Drawing.Point(670, 89);
            this.BtnGmapsEnd.Name = "BtnGmapsEnd";
            this.BtnGmapsEnd.Size = new System.Drawing.Size(71, 57);
            this.BtnGmapsEnd.TabIndex = 10;
            this.BtnGmapsEnd.Text = "Maps";
            this.BtnGmapsEnd.UseVisualStyleBackColor = true;
            this.BtnGmapsEnd.Click += new System.EventHandler(this.BtnGmapsEnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Starthaltestelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Endhaltestelle";
            // 
            // BtnMyLocation
            // 
            this.BtnMyLocation.Location = new System.Drawing.Point(168, 150);
            this.BtnMyLocation.Name = "BtnMyLocation";
            this.BtnMyLocation.Size = new System.Drawing.Size(157, 43);
            this.BtnMyLocation.TabIndex = 13;
            this.BtnMyLocation.Text = "Mein Standort";
            this.BtnMyLocation.UseVisualStyleBackColor = true;
            this.BtnMyLocation.Click += new System.EventHandler(this.BtnMyLocation_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(927, 632);
            this.Controls.Add(this.BtnMyLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGmapsEnd);
            this.Controls.Add(this.BtnGmapsStart);
            this.Controls.Add(this.BtnTimetable);
            this.Controls.Add(this.ListViewResult);
            this.Controls.Add(this.BtnSwap);
            this.Controls.Add(this.DateTimeClock);
            this.Controls.Add(this.BtnConnections);
            this.Controls.Add(this.DateTimeDate);
            this.Controls.Add(this.ComboBoxEnd);
            this.Controls.Add(this.ComboBoxStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Fahrplan Schweiz";
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxStart;
        private System.Windows.Forms.ComboBox ComboBoxEnd;
        private System.Windows.Forms.DateTimePicker DateTimeDate;
        private System.Windows.Forms.Button BtnConnections;
        private System.Windows.Forms.DateTimePicker DateTimeClock;
        private Button BtnSwap;
        private BindingSource transportBindingSource;
        private ListView ListViewResult;
        private Button BtnTimetable;
        private ColumnHeader clmtrack;
        private ColumnHeader clmdeparture;
        private ColumnHeader clmarrival;
        private ColumnHeader clmto;
        private ColumnHeader clmOperator;
        private Button BtnGmapsStart;
        private Button BtnGmapsEnd;
        private Label label1;
        private Label label2;
        private Button BtnMyLocation;
    }
}