namespace TView
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ozzy",
            "Osbourne",
            "Birmingham",
            "CA 90212",
            "03.12.1948"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nathan",
            "Explosion",
            "New York",
            "CA 64543",
            "21.03.1976"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Moa",
            "Kikuchi",
            "Nagoja",
            "212-6544",
            "04.06.1999"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Maciej",
            "Januszko",
            "Warszawa",
            "01-376",
            "18.08.1953"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kiriko",
            "Takemura",
            "Tokio",
            "106-0044",
            "29.01.1993"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Damian",
            "Poniedziałek",
            "Honolulu",
            "00-001",
            "01.01.2020"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Brendon",
            "Small",
            "Springfield",
            "CA 45633",
            "15.02.1975"}, -1);
            this.List_View = new System.Windows.Forms.ListView();
            this.Namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Forname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_View
            // 
            this.List_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namee,
            this.Forname,
            this.City,
            this.Address,
            this.Birthday});
            this.List_View.FullRowSelect = true;
            this.List_View.GridLines = true;
            this.List_View.HideSelection = false;
            this.List_View.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.List_View.LabelEdit = true;
            this.List_View.Location = new System.Drawing.Point(12, 9);
            this.List_View.Name = "List_View";
            this.List_View.Size = new System.Drawing.Size(387, 355);
            this.List_View.TabIndex = 15;
            this.List_View.UseCompatibleStateImageBehavior = false;
            this.List_View.View = System.Windows.Forms.View.Details;
            this.List_View.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.List_View_ColumnClick);
            // 
            // Namee
            // 
            this.Namee.Text = "Imię";
            // 
            // Forname
            // 
            this.Forname.Text = "Nazwisko";
            this.Forname.Width = 80;
            // 
            // City
            // 
            this.City.Text = "Miasto";
            // 
            // Address
            // 
            this.Address.Text = "Adres";
            // 
            // Birthday
            // 
            this.Birthday.Text = "Urodzony";
            this.Birthday.Width = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.List_View);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView List_View;
        private System.Windows.Forms.ColumnHeader Namee;
        private System.Windows.Forms.ColumnHeader Forname;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

