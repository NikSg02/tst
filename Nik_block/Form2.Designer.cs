namespace Tinker_quest
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvIdProdukts = new System.Windows.Forms.DataGridView();
            this.IdGoods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdProdukts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Признак удаления";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(128, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(172, 92);
            this.txtArt.Multiline = true;
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(117, 20);
            this.txtArt.TabIndex = 6;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(172, 171);
            this.txtRemove.Multiline = true;
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(117, 20);
            this.txtRemove.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 131);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 8;
            // 
            // dgvIdProdukts
            // 
            this.dgvIdProdukts.AllowUserToDeleteRows = false;
            this.dgvIdProdukts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvIdProdukts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdProdukts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGoods,
            this.Articul,
            this.Name,
            this.Remove});
            this.dgvIdProdukts.Location = new System.Drawing.Point(346, 59);
            this.dgvIdProdukts.Name = "dgvIdProdukts";
            this.dgvIdProdukts.ReadOnly = true;
            this.dgvIdProdukts.Size = new System.Drawing.Size(442, 296);
            this.dgvIdProdukts.TabIndex = 9;
            this.dgvIdProdukts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdProdukts_CellContentClick);
            this.dgvIdProdukts.DoubleClick += new System.EventHandler(this.dgvIdProdukts_DoubleClick);
            // 
            // IdGoods
            // 
            this.IdGoods.DataPropertyName = "IdGoods";
            this.IdGoods.HeaderText = "Id Товара";
            this.IdGoods.Name = "IdGoods";
            this.IdGoods.ReadOnly = true;
            // 
            // Articul
            // 
            this.Articul.DataPropertyName = "Articul";
            this.Articul.HeaderText = "Артикул";
            this.Articul.Name = "Articul";
            this.Articul.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Наименование";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.DataPropertyName = "Remove";
            this.Remove.HeaderText = "Признак удаления";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Поставщики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvIdProdukts);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdProdukts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvIdProdukts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remove;
        private System.Windows.Forms.Button button1;
    }
}