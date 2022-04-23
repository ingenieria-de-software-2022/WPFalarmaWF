namespace WPFalarmaWF
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.displayedTime = new System.Windows.Forms.Label();
            this.radioButtonActivateAlarm = new System.Windows.Forms.RadioButton();
            this.textBoxAlarm = new System.Windows.Forms.TextBox();
            this.radioButtonDisableAlarm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // displayedTime
            // 
            this.displayedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.displayedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayedTime.Location = new System.Drawing.Point(171, 58);
            this.displayedTime.Name = "displayedTime";
            this.displayedTime.Size = new System.Drawing.Size(175, 41);
            this.displayedTime.TabIndex = 0;
            this.displayedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonActivateAlarm
            // 
            this.radioButtonActivateAlarm.AutoSize = true;
            this.radioButtonActivateAlarm.Location = new System.Drawing.Point(97, 145);
            this.radioButtonActivateAlarm.Name = "radioButtonActivateAlarm";
            this.radioButtonActivateAlarm.Size = new System.Drawing.Size(93, 17);
            this.radioButtonActivateAlarm.TabIndex = 1;
            this.radioButtonActivateAlarm.TabStop = true;
            this.radioButtonActivateAlarm.Text = "Activar Alarma";
            this.radioButtonActivateAlarm.UseVisualStyleBackColor = true;
            // 
            // textBoxAlarm
            // 
            this.textBoxAlarm.Location = new System.Drawing.Point(269, 158);
            this.textBoxAlarm.Name = "textBoxAlarm";
            this.textBoxAlarm.Size = new System.Drawing.Size(155, 20);
            this.textBoxAlarm.TabIndex = 2;
            this.textBoxAlarm.Text = "hh:mm:ss:f-dd/MM/yyyy";
            // 
            // radioButtonDisableAlarm
            // 
            this.radioButtonDisableAlarm.AutoSize = true;
            this.radioButtonDisableAlarm.Location = new System.Drawing.Point(97, 180);
            this.radioButtonDisableAlarm.Name = "radioButtonDisableAlarm";
            this.radioButtonDisableAlarm.Size = new System.Drawing.Size(111, 17);
            this.radioButtonDisableAlarm.TabIndex = 3;
            this.radioButtonDisableAlarm.TabStop = true;
            this.radioButtonDisableAlarm.Text = "Desactivar Alarma";
            this.radioButtonDisableAlarm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 335);
            this.Controls.Add(this.radioButtonDisableAlarm);
            this.Controls.Add(this.textBoxAlarm);
            this.Controls.Add(this.radioButtonActivateAlarm);
            this.Controls.Add(this.displayedTime);
            this.Name = "Form1";
            this.Text = "Alarma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label displayedTime;
        private System.Windows.Forms.RadioButton radioButtonActivateAlarm;
        private System.Windows.Forms.TextBox textBoxAlarm;
        private System.Windows.Forms.RadioButton radioButtonDisableAlarm;
    }
}