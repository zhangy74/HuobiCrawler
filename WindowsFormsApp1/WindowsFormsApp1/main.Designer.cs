﻿
namespace WindowsFormsApp1


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
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.lowbuyprice = new System.Windows.Forms.Label();
            this.lowsellprice = new System.Windows.Forms.Label();
            this.buyBox = new System.Windows.Forms.ListBox();
            this.sellBox = new System.Windows.Forms.ListBox();
            this.refresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "距离下次刷新时间";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(780, 414);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前最购买价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(30, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "当前最低出售价";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(45, 61);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(105, 32);
            this.time.TabIndex = 4;
            this.time.Text = "label4";
            // 
            // lowbuyprice
            // 
            this.lowbuyprice.AutoSize = true;
            this.lowbuyprice.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowbuyprice.Location = new System.Drawing.Point(39, 61);
            this.lowbuyprice.Name = "lowbuyprice";
            this.lowbuyprice.Size = new System.Drawing.Size(105, 32);
            this.lowbuyprice.TabIndex = 5;
            this.lowbuyprice.Text = "label5";
            // 
            // lowsellprice
            // 
            this.lowsellprice.AutoSize = true;
            this.lowsellprice.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowsellprice.Location = new System.Drawing.Point(35, 60);
            this.lowsellprice.Name = "lowsellprice";
            this.lowsellprice.Size = new System.Drawing.Size(105, 32);
            this.lowsellprice.TabIndex = 6;
            this.lowsellprice.Text = "label6";
            // 
            // buyBox
            // 
            this.buyBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBox.FormattingEnabled = true;
            this.buyBox.ItemHeight = 19;
            this.buyBox.Location = new System.Drawing.Point(22, 160);
            this.buyBox.Name = "buyBox";
            this.buyBox.Size = new System.Drawing.Size(550, 422);
            this.buyBox.TabIndex = 7;
            // 
            // sellBox
            // 
            this.sellBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBox.FormattingEnabled = true;
            this.sellBox.ItemHeight = 19;
            this.sellBox.Location = new System.Drawing.Point(592, 160);
            this.sellBox.Name = "sellBox";
            this.sellBox.Size = new System.Drawing.Size(550, 422);
            this.sellBox.TabIndex = 8;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(1014, 31);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 9;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 94);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "秒";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(1014, 82);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 12;
            this.load.Text = "启动数据库";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1014, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "停止数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.Red;
            this.backPanel.Location = new System.Drawing.Point(1009, 77);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(80, 28);
            this.backPanel.TabIndex = 14;
            this.backPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 120);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lowbuyprice);
            this.panel2.Location = new System.Drawing.Point(299, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 120);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lowsellprice);
            this.panel3.Location = new System.Drawing.Point(592, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 120);
            this.panel3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 623);
            this.Controls.Add(this.load);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.sellBox);
            this.Controls.Add(this.buyBox);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label lowbuyprice;
        private System.Windows.Forms.Label lowsellprice;
        private System.Windows.Forms.ListBox buyBox;
        private System.Windows.Forms.ListBox sellBox;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

