namespace AmbientLight_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_connect = new System.Windows.Forms.Button();
            this.cbb_serial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(125, 40);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(107, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cbb_serial
            // 
            this.cbb_serial.FormattingEnabled = true;
            this.cbb_serial.Location = new System.Drawing.Point(125, 12);
            this.cbb_serial.Name = "cbb_serial";
            this.cbb_serial.Size = new System.Drawing.Size(107, 23);
            this.cbb_serial.TabIndex = 1;
            this.cbb_serial.Click += new System.EventHandler(this.cbb_serial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 도현 OTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "포트 설정";
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(12, 40);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(107, 23);
            this.btn_on.TabIndex = 3;
            this.btn_on.Text = "Rainbow on";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // btn_off
            // 
            this.btn_off.Location = new System.Drawing.Point(125, 69);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(107, 23);
            this.btn_off.TabIndex = 4;
            this.btn_off.Text = "off";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Light on";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_serial);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_connect;
        private ComboBox cbb_serial;
        private Label label1;
        private Button btn_on;
        private Button btn_off;
        private Button button1;
    }
}