
namespace MikulasCsomagEditor
{
    partial class FrmCsomagEpito
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valueUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.itemCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pieceTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.packetDGV = new System.Windows.Forms.DataGridView();
            this.pirceLBL = new System.Windows.Forms.Label();
            this.addBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Termek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.valueUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Értékhatár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(331, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Írd be az azonosítód:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Termék:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(382, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Csomagtartalma jelenleg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(331, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Csomag értéke jelenleg:";
            // 
            // valueUD
            // 
            this.valueUD.Enabled = false;
            this.valueUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.valueUD.Location = new System.Drawing.Point(118, 27);
            this.valueUD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.valueUD.Name = "valueUD";
            this.valueUD.Size = new System.Drawing.Size(85, 20);
            this.valueUD.TabIndex = 5;
            this.valueUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(209, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ft";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(494, 27);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(76, 20);
            this.idTB.TabIndex = 7;
            this.idTB.TextChanged += new System.EventHandler(this.idTB_TextChanged);
            // 
            // itemCB
            // 
            this.itemCB.Enabled = false;
            this.itemCB.FormattingEnabled = true;
            this.itemCB.Location = new System.Drawing.Point(28, 138);
            this.itemCB.Name = "itemCB";
            this.itemCB.Size = new System.Drawing.Size(121, 21);
            this.itemCB.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(155, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "x";
            // 
            // pieceTB
            // 
            this.pieceTB.Enabled = false;
            this.pieceTB.Location = new System.Drawing.Point(177, 138);
            this.pieceTB.Name = "pieceTB";
            this.pieceTB.Size = new System.Drawing.Size(76, 20);
            this.pieceTB.TabIndex = 10;
            this.pieceTB.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(259, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "db";
            // 
            // packetDGV
            // 
            this.packetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packetDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Termek,
            this.Db});
            this.packetDGV.Location = new System.Drawing.Point(335, 138);
            this.packetDGV.Name = "packetDGV";
            this.packetDGV.Size = new System.Drawing.Size(240, 217);
            this.packetDGV.TabIndex = 12;
            // 
            // pirceLBL
            // 
            this.pirceLBL.AutoSize = true;
            this.pirceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pirceLBL.ForeColor = System.Drawing.Color.White;
            this.pirceLBL.Location = new System.Drawing.Point(516, 368);
            this.pirceLBL.Name = "pirceLBL";
            this.pirceLBL.Size = new System.Drawing.Size(68, 20);
            this.pirceLBL.TabIndex = 13;
            this.pirceLBL.Text = "1900 FT";
            // 
            // addBTN
            // 
            this.addBTN.Enabled = false;
            this.addBTN.Location = new System.Drawing.Point(28, 165);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(225, 23);
            this.addBTN.TabIndex = 14;
            this.addBTN.Text = "Csomagba tesz!";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(335, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Csomag megvásárlása";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(28, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Statisztika";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Termek
            // 
            this.Termek.HeaderText = "Termek";
            this.Termek.Name = "Termek";
            this.Termek.ReadOnly = true;
            // 
            // Db
            // 
            this.Db.HeaderText = "Db";
            this.Db.Name = "Db";
            this.Db.ReadOnly = true;
            // 
            // FrmCsomagEpito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(613, 445);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.pirceLBL);
            this.Controls.Add(this.packetDGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pieceTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itemCB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valueUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCsomagEpito";
            this.Text = "FrmCsomagEpito";
            this.Load += new System.EventHandler(this.FrmCsomagEpito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valueUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown valueUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.ComboBox itemCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pieceTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView packetDGV;
        private System.Windows.Forms.Label pirceLBL;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Db;
    }
}