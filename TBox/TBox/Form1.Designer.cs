namespace TBox
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
            this.List_Box = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_Box
            // 
            this.List_Box.FormattingEnabled = true;
            this.List_Box.Items.AddRange(new object[] {
            "Value1",
            "Value2",
            "Value3",
            "Value4"});
            this.List_Box.Location = new System.Drawing.Point(12, 12);
            this.List_Box.Name = "List_Box";
            this.List_Box.Size = new System.Drawing.Size(237, 121);
            this.List_Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter New Value";
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(256, 29);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(100, 20);
            this.ValueBox.TabIndex = 3;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(255, 55);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(102, 22);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(255, 83);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(101, 23);
            this.Clear_button.TabIndex = 5;
            this.Clear_button.Text = "Clear List";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(255, 112);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(101, 23);
            this.Remove_button.TabIndex = 6;
            this.Remove_button.Text = "Remove From List";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 141);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Remove_button;
    }
}

