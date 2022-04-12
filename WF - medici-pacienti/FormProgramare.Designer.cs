
namespace WF___medici_pacienti
{
    partial class FormProgramare
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
            this.textBoxMedic = new System.Windows.Forms.TextBox();
            this.textBoxPacient = new System.Windows.Forms.TextBox();
            this.dateTimePickerProgramare = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMedic
            // 
            this.textBoxMedic.Location = new System.Drawing.Point(119, 58);
            this.textBoxMedic.Name = "textBoxMedic";
            this.textBoxMedic.Size = new System.Drawing.Size(210, 22);
            this.textBoxMedic.TabIndex = 0;
            // 
            // textBoxPacient
            // 
            this.textBoxPacient.Location = new System.Drawing.Point(119, 121);
            this.textBoxPacient.Name = "textBoxPacient";
            this.textBoxPacient.Size = new System.Drawing.Size(210, 22);
            this.textBoxPacient.TabIndex = 1;
            // 
            // dateTimePickerProgramare
            // 
            this.dateTimePickerProgramare.Location = new System.Drawing.Point(119, 168);
            this.dateTimePickerProgramare.Name = "dateTimePickerProgramare";
            this.dateTimePickerProgramare.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerProgramare.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(119, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salveaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProgramare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerProgramare);
            this.Controls.Add(this.textBoxPacient);
            this.Controls.Add(this.textBoxMedic);
            this.Name = "FormProgramare";
            this.Text = "FormProgramare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMedic;
        private System.Windows.Forms.TextBox textBoxPacient;
        private System.Windows.Forms.DateTimePicker dateTimePickerProgramare;
        private System.Windows.Forms.Button button1;
    }
}