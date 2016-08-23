﻿namespace CloudStack
{
    partial class Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCheck1 = new System.Windows.Forms.Label();
            this.labelCheck2 = new System.Windows.Forms.Label();
            this.labelCheck3 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downloading CloudStack binaries ...";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Installing CloudStack website on this web server ... ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 135);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alright, let\'s connect this CloudStack instance with your Azure cloud ... please " +
    "enter your Azure subscription Id: ";
            this.label3.Visible = false;
            // 
            // labelCheck1
            // 
            this.labelCheck1.AutoSize = true;
            this.labelCheck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck1.ForeColor = System.Drawing.Color.Green;
            this.labelCheck1.Location = new System.Drawing.Point(20, 25);
            this.labelCheck1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCheck1.Name = "labelCheck1";
            this.labelCheck1.Size = new System.Drawing.Size(59, 44);
            this.labelCheck1.TabIndex = 3;
            this.labelCheck1.Text = "✓";
            this.labelCheck1.Visible = false;
            // 
            // labelCheck2
            // 
            this.labelCheck2.AutoSize = true;
            this.labelCheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck2.ForeColor = System.Drawing.Color.Green;
            this.labelCheck2.Location = new System.Drawing.Point(20, 113);
            this.labelCheck2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCheck2.Name = "labelCheck2";
            this.labelCheck2.Size = new System.Drawing.Size(59, 44);
            this.labelCheck2.TabIndex = 4;
            this.labelCheck2.Text = "✓";
            this.labelCheck2.Visible = false;
            // 
            // labelCheck3
            // 
            this.labelCheck3.AutoSize = true;
            this.labelCheck3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck3.ForeColor = System.Drawing.Color.Green;
            this.labelCheck3.Location = new System.Drawing.Point(20, 202);
            this.labelCheck3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCheck3.Name = "labelCheck3";
            this.labelCheck3.Size = new System.Drawing.Size(59, 44);
            this.labelCheck3.TabIndex = 5;
            this.labelCheck3.Text = "✓";
            this.labelCheck3.Visible = false;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(82, 342);
            this.textBox.Margin = new System.Windows.Forms.Padding(6);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(666, 50);
            this.textBox.TabIndex = 6;
            this.textBox.Visible = false;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(764, 342);
            this.button.Margin = new System.Windows.Forms.Padding(6);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(92, 56);
            this.button.TabIndex = 7;
            this.button.Text = "Go";
            this.button.UseVisualStyleBackColor = true;
            this.button.Visible = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(780, 181);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registering CloudStack in your Azure Active Directory now ... ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 585);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(780, 54);
            this.label5.TabIndex = 9;
            this.label5.Text = "Done!";
            this.label5.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(6);
            this.webBrowser.MinimumSize = new System.Drawing.Size(40, 38);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(928, 1156);
            this.webBrowser.TabIndex = 16;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(928, 1156);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelCheck3);
            this.Controls.Add(this.labelCheck2);
            this.Controls.Add(this.labelCheck1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "CloudStack Installer";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCheck1;
        private System.Windows.Forms.Label labelCheck2;
        private System.Windows.Forms.Label labelCheck3;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

