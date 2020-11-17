namespace ElevatorSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCreat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStart.Location = new System.Drawing.Point(3, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(145, 88);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Запустить систему";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreat
            // 
            this.buttonCreat.Location = new System.Drawing.Point(154, 3);
            this.buttonCreat.Name = "buttonCreat";
            this.buttonCreat.Size = new System.Drawing.Size(147, 88);
            this.buttonCreat.TabIndex = 1;
            this.buttonCreat.Text = "Добавить человека";
            this.buttonCreat.UseVisualStyleBackColor = true;
            this.buttonCreat.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ElevatorSystem.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1226, 650);
            this.Controls.Add(this.buttonCreat);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainForm";
            this.Text = "Elevator System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCreat;
        private System.Windows.Forms.Timer timer1;
    }
}

