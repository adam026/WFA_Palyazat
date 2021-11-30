
namespace WFApalyazat
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnUjPalyazat = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.azonosito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakszama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakosszege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.azonosito,
            this.keretosszeg,
            this.szamlakszama,
            this.szamlakosszege});
            this.dgvMain.Location = new System.Drawing.Point(48, 34);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(642, 318);
            this.dgvMain.TabIndex = 0;
            // 
            // btnUjPalyazat
            // 
            this.btnUjPalyazat.BackColor = System.Drawing.Color.Green;
            this.btnUjPalyazat.Location = new System.Drawing.Point(48, 358);
            this.btnUjPalyazat.Name = "btnUjPalyazat";
            this.btnUjPalyazat.Size = new System.Drawing.Size(318, 83);
            this.btnUjPalyazat.TabIndex = 1;
            this.btnUjPalyazat.Text = "Új pályázat";
            this.btnUjPalyazat.UseVisualStyleBackColor = false;
            this.btnUjPalyazat.Click += new System.EventHandler(this.btnUjPalyazat_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.BackColor = System.Drawing.Color.Red;
            this.btnKilepes.Location = new System.Drawing.Point(372, 358);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(318, 83);
            this.btnKilepes.TabIndex = 1;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = false;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // azonosito
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.azonosito.DefaultCellStyle = dataGridViewCellStyle1;
            this.azonosito.FillWeight = 20F;
            this.azonosito.HeaderText = "ID";
            this.azonosito.Name = "azonosito";
            // 
            // keretosszeg
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.keretosszeg.DefaultCellStyle = dataGridViewCellStyle2;
            this.keretosszeg.HeaderText = "Keretösszeg";
            this.keretosszeg.Name = "keretosszeg";
            // 
            // szamlakszama
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.szamlakszama.DefaultCellStyle = dataGridViewCellStyle3;
            this.szamlakszama.HeaderText = "Számlák száma";
            this.szamlakszama.Name = "szamlakszama";
            // 
            // szamlakosszege
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.szamlakosszege.DefaultCellStyle = dataGridViewCellStyle4;
            this.szamlakosszege.HeaderText = "Számlák összege";
            this.szamlakosszege.Name = "szamlakosszege";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 563);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnUjPalyazat);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnUjPalyazat;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.DataGridViewTextBoxColumn azonosito;
        private System.Windows.Forms.DataGridViewTextBoxColumn keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakszama;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakosszege;
    }
}

