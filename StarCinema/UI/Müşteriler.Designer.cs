﻿namespace StarCinema.UI
{
    partial class Müşteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müşteriler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMüşteriEkle = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMüşteriBul = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteri = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 360);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMüşteriEkle,
            this.btnMüşteriDüzenle,
            this.btnMüşteriSil,
            this.toolStripSeparator1,
            this.btnMüşteriBul,
            this.btnMüşteri,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMüşteriEkle
            // 
            this.btnMüşteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMüşteriEkle.Image")));
            this.btnMüşteriEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriEkle.Name = "btnMüşteriEkle";
            this.btnMüşteriEkle.Size = new System.Drawing.Size(65, 28);
            this.btnMüşteriEkle.Text = "Add";
            this.btnMüşteriEkle.Click += new System.EventHandler(this.btnMüşteriEkle_Click);
            // 
            // btnMüşteriDüzenle
            // 
            this.btnMüşteriDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnMüşteriDüzenle.Image")));
            this.btnMüşteriDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriDüzenle.Name = "btnMüşteriDüzenle";
            this.btnMüşteriDüzenle.Size = new System.Drawing.Size(63, 28);
            this.btnMüşteriDüzenle.Text = "Edit";
            this.btnMüşteriDüzenle.Click += new System.EventHandler(this.btnMüşteriDüzenle_Click);
            // 
            // btnMüşteriSil
            // 
            this.btnMüşteriSil.Image = ((System.Drawing.Image)(resources.GetObject("btnMüşteriSil.Image")));
            this.btnMüşteriSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriSil.Name = "btnMüşteriSil";
            this.btnMüşteriSil.Size = new System.Drawing.Size(81, 28);
            this.btnMüşteriSil.Text = "Delete";
            this.btnMüşteriSil.Click += new System.EventHandler(this.btnMüşteriSil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnMüşteriBul
            // 
            this.btnMüşteriBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMüşteriBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMüşteriBul.Image = ((System.Drawing.Image)(resources.GetObject("btnMüşteriBul.Image")));
            this.btnMüşteriBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriBul.Name = "btnMüşteriBul";
            this.btnMüşteriBul.Size = new System.Drawing.Size(29, 28);
            this.btnMüşteriBul.Text = "toolStripButton1";
            this.btnMüşteriBul.Click += new System.EventHandler(this.btnMüşteriBul_Click);
            // 
            // btnMüşteri
            // 
            this.btnMüşteri.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMüşteri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMüşteri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMüşteri.Name = "btnMüşteri";
            this.btnMüşteri.Size = new System.Drawing.Size(200, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 28);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnOK);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "müşteriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::StarCinema.Properties.Resources.symbol_cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(675, 401);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 39);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Image = global::StarCinema.Properties.Resources.button_ok_open;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(536, 401);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 39);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 478);
            this.tabControl1.TabIndex = 1;
            // 
            // Müşteriler
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(797, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "Müşteriler";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Müşteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMüşteriEkle;
        private System.Windows.Forms.ToolStripButton btnMüşteriDüzenle;
        private System.Windows.Forms.ToolStripButton btnMüşteriSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMüşteriBul;
        private System.Windows.Forms.ToolStripTextBox btnMüşteri;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}