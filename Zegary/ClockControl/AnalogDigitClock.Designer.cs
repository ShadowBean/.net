namespace ClockControl
{
    partial class AnalogDigitClock
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
            this.Digit = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.backBox = new System.Windows.Forms.PictureBox();
            this.dotBox = new System.Windows.Forms.PictureBox();
            this.hourBox = new System.Windows.Forms.PictureBox();
            this.minuteBox = new System.Windows.Forms.PictureBox();
            this.secondBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Digit
            // 
            this.Digit.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit.Location = new System.Drawing.Point(3, 0);
            this.Digit.Name = "Digit";
            this.Digit.Size = new System.Drawing.Size(282, 71);
            this.Digit.TabIndex = 0;
            this.Digit.Text = "--:--   --";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // backBox
            // 
            this.backBox.BackColor = System.Drawing.Color.Transparent;
            this.backBox.Location = new System.Drawing.Point(14, 74);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(312, 309);
            this.backBox.TabIndex = 1;
            this.backBox.TabStop = false;
            // 
            // dotBox
            // 
            this.dotBox.BackColor = System.Drawing.Color.Transparent;
            this.dotBox.Location = new System.Drawing.Point(14, 74);
            this.dotBox.Name = "dotBox";
            this.dotBox.Size = new System.Drawing.Size(312, 309);
            this.dotBox.TabIndex = 2;
            this.dotBox.TabStop = false;
            // 
            // hourBox
            // 
            this.hourBox.BackColor = System.Drawing.Color.Transparent;
            this.hourBox.Location = new System.Drawing.Point(14, 74);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(312, 309);
            this.hourBox.TabIndex = 3;
            this.hourBox.TabStop = false;
            // 
            // minuteBox
            // 
            this.minuteBox.BackColor = System.Drawing.Color.Transparent;
            this.minuteBox.Location = new System.Drawing.Point(14, 74);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(312, 309);
            this.minuteBox.TabIndex = 4;
            this.minuteBox.TabStop = false;
            // 
            // secondBox
            // 
            this.secondBox.BackColor = System.Drawing.Color.Transparent;
            this.secondBox.Location = new System.Drawing.Point(14, 74);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(312, 309);
            this.secondBox.TabIndex = 5;
            this.secondBox.TabStop = false;
            // 
            // AnalogDigitClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.dotBox);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.Digit);
            this.Name = "AnalogDigitClock";
            this.Size = new System.Drawing.Size(354, 401);
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Digit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox backBox;
        private System.Windows.Forms.PictureBox dotBox;
        private System.Windows.Forms.PictureBox hourBox;
        private System.Windows.Forms.PictureBox minuteBox;
        private System.Windows.Forms.PictureBox secondBox;
    }
}
