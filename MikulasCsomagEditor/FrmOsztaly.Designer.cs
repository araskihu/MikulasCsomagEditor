
namespace MikulasCsomagEditor
{
    partial class FrmOsztaly
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
            this.pathTb = new System.Windows.Forms.TextBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.classTb = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathTb
            // 
            this.pathTb.Location = new System.Drawing.Point(12, 47);
            this.pathTb.Name = "pathTb";
            this.pathTb.Size = new System.Drawing.Size(395, 20);
            this.pathTb.TabIndex = 0;
            this.pathTb.TextChanged += new System.EventHandler(this.pathTb_TextChanged);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(413, 45);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(141, 23);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Tallózás";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Osztálynévsor tallózása:";
            // 
            // classTb
            // 
            this.classTb.Enabled = false;
            this.classTb.Location = new System.Drawing.Point(250, 101);
            this.classTb.Name = "classTb";
            this.classTb.Size = new System.Drawing.Size(304, 20);
            this.classTb.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Location = new System.Drawing.Point(12, 143);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(542, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Hozzáadás az adatbázishoz";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Írja be az osztályjelzést:";
            // 
            // FrmOsztaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(568, 182);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.classTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.pathTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOsztaly";
            this.Text = "FrmOsztaly";
            this.Load += new System.EventHandler(this.FrmOsztaly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox classTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
    }
}