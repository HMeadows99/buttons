namespace buttons
{
    partial class Frmbuttons
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
            this.btncow = new System.Windows.Forms.Button();
            this.lblmilkshake = new System.Windows.Forms.Label();
            this.btnpizza = new System.Windows.Forms.Button();
            this.lblcheesy = new System.Windows.Forms.Label();
            this.btnsquid = new System.Windows.Forms.Button();
            this.lbltickles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncow
            // 
            this.btncow.Location = new System.Drawing.Point(40, 24);
            this.btncow.Name = "btncow";
            this.btncow.Size = new System.Drawing.Size(195, 25);
            this.btncow.TabIndex = 0;
            this.btncow.Text = "What do you get from a nervous cow?";
            this.btncow.UseVisualStyleBackColor = true;
            this.btncow.Click += new System.EventHandler(this.btncow_Click);
            // 
            // lblmilkshake
            // 
            this.lblmilkshake.AutoSize = true;
            this.lblmilkshake.Location = new System.Drawing.Point(40, 56);
            this.lblmilkshake.Name = "lblmilkshake";
            this.lblmilkshake.Size = new System.Drawing.Size(0, 13);
            this.lblmilkshake.TabIndex = 1;
            // 
            // btnpizza
            // 
            this.btnpizza.Location = new System.Drawing.Point(40, 86);
            this.btnpizza.Name = "btnpizza";
            this.btnpizza.Size = new System.Drawing.Size(195, 23);
            this.btnpizza.TabIndex = 2;
            this.btnpizza.Text = "Want to hear a pizza joke?";
            this.btnpizza.UseVisualStyleBackColor = true;
            this.btnpizza.Click += new System.EventHandler(this.btnpizza_Click);
            // 
            // lblcheesy
            // 
            this.lblcheesy.AutoSize = true;
            this.lblcheesy.Location = new System.Drawing.Point(43, 116);
            this.lblcheesy.Name = "lblcheesy";
            this.lblcheesy.Size = new System.Drawing.Size(0, 13);
            this.lblcheesy.TabIndex = 3;
            // 
            // btnsquid
            // 
            this.btnsquid.Location = new System.Drawing.Point(40, 154);
            this.btnsquid.Name = "btnsquid";
            this.btnsquid.Size = new System.Drawing.Size(195, 37);
            this.btnsquid.TabIndex = 4;
            this.btnsquid.Text = "How many tickles does it take to make an octopus laugh?";
            this.btnsquid.UseVisualStyleBackColor = true;
            this.btnsquid.Click += new System.EventHandler(this.btnsquid_Click);
            // 
            // lbltickles
            // 
            this.lbltickles.AutoSize = true;
            this.lbltickles.Location = new System.Drawing.Point(46, 212);
            this.lbltickles.Name = "lbltickles";
            this.lbltickles.Size = new System.Drawing.Size(0, 13);
            this.lbltickles.TabIndex = 5;
            // 
            // Frmbuttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbltickles);
            this.Controls.Add(this.btnsquid);
            this.Controls.Add(this.lblcheesy);
            this.Controls.Add(this.btnpizza);
            this.Controls.Add(this.lblmilkshake);
            this.Controls.Add(this.btncow);
            this.Name = "Frmbuttons";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncow;
        private System.Windows.Forms.Label lblmilkshake;
        private System.Windows.Forms.Button btnpizza;
        private System.Windows.Forms.Label lblcheesy;
        private System.Windows.Forms.Button btnsquid;
        private System.Windows.Forms.Label lbltickles;
    }
}

