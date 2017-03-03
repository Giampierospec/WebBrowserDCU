namespace WebBrowser
{
    partial class Browser
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
            this.webBrows = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrows
            // 
            this.webBrows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrows.Location = new System.Drawing.Point(0, 0);
            this.webBrows.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrows.Name = "webBrows";
            this.webBrows.Size = new System.Drawing.Size(888, 577);
            this.webBrows.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(857, 22);
            this.textBox1.TabIndex = 1;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(12, 40);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 2;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(122, 40);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(220, 40);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(75, 23);
            this.forward.TabIndex = 4;
            this.forward.Text = "Forward";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.button3_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(317, 40);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(413, 40);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 6;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button5_Click);
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(522, 40);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 7;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 577);
            this.Controls.Add(this.go);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.home);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrows);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrows;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button go;
    }
}

