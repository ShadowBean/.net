namespace Lights
{
    partial class UserControl1
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Green_Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.green_duration = new System.Windows.Forms.NumericUpDown();
            this.yellow_duration = new System.Windows.Forms.NumericUpDown();
            this.red_duration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accept = new System.Windows.Forms.Button();
            this.Yellow_Timer = new System.Windows.Forms.Timer(this.components);
            this.Red_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // Green_Timer
            // 
            this.Green_Timer.Tick += new System.EventHandler(this.Green_Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // green_duration
            // 
            this.green_duration.Location = new System.Drawing.Point(215, 10);
            this.green_duration.Name = "green_duration";
            this.green_duration.Size = new System.Drawing.Size(120, 20);
            this.green_duration.TabIndex = 1;
            // 
            // yellow_duration
            // 
            this.yellow_duration.Location = new System.Drawing.Point(215, 36);
            this.yellow_duration.Name = "yellow_duration";
            this.yellow_duration.Size = new System.Drawing.Size(120, 20);
            this.yellow_duration.TabIndex = 2;
            // 
            // red_duration
            // 
            this.red_duration.Location = new System.Drawing.Point(215, 62);
            this.red_duration.Name = "red_duration";
            this.red_duration.Size = new System.Drawing.Size(120, 20);
            this.red_duration.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Green duration (in seconds)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yellow duration (in seconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Red duration (in seconds)";
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(215, 88);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(120, 25);
            this.accept.TabIndex = 8;
            this.accept.Text = "Set";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Yellow_Timer
            // 
            this.Yellow_Timer.Tick += new System.EventHandler(this.Yellow_Timer_Tick);
            // 
            // Red_Timer
            // 
            this.Red_Timer.Tick += new System.EventHandler(this.Red_Timer_Tick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.red_duration);
            this.Controls.Add(this.yellow_duration);
            this.Controls.Add(this.green_duration);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(352, 173);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Green_Timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown green_duration;
        private System.Windows.Forms.NumericUpDown yellow_duration;
        private System.Windows.Forms.NumericUpDown red_duration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Timer Yellow_Timer;
        private System.Windows.Forms.Timer Red_Timer;
    }
}
