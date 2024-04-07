namespace HotelManagement
{
    partial class Employees
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
            this.label6 = new System.Windows.Forms.Label();
            this.dis = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sea = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.ins = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 23);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(340, 42);
            this.label6.TabIndex = 54;
            this.label6.Text = "EMPLOYEES DETAILS";
            // 
            // dis
            // 
            this.dis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dis.Location = new System.Drawing.Point(195, 541);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(144, 46);
            this.dis.TabIndex = 53;
            this.dis.Text = "DISPLAY";
            this.dis.UseVisualStyleBackColor = false;
            this.dis.Click += new System.EventHandler(this.dis_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(65, 110);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(33, 25);
            this.ID.TabIndex = 52;
            this.ID.Text = "ID";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(185, 110);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(202, 40);
            this.textBox6.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(419, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(662, 390);
            this.dataGridView1.TabIndex = 50;
            // 
            // sea
            // 
            this.sea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sea.Location = new System.Drawing.Point(748, 541);
            this.sea.Name = "sea";
            this.sea.Size = new System.Drawing.Size(143, 46);
            this.sea.TabIndex = 49;
            this.sea.Text = "SEARCH";
            this.sea.UseVisualStyleBackColor = false;
            this.sea.Click += new System.EventHandler(this.sea_Click);
            // 
            // upd
            // 
            this.upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd.Location = new System.Drawing.Point(379, 541);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(143, 46);
            this.upd.TabIndex = 48;
            this.upd.Text = "UPDATE";
            this.upd.UseVisualStyleBackColor = false;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(565, 542);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(140, 44);
            this.del.TabIndex = 47;
            this.del.Text = "DELETE";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // ins
            // 
            this.ins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ins.Location = new System.Drawing.Point(11, 541);
            this.ins.Name = "ins";
            this.ins.Size = new System.Drawing.Size(147, 46);
            this.ins.TabIndex = 46;
            this.ins.Text = "INSERT";
            this.ins.UseVisualStyleBackColor = false;
            this.ins.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "First Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 442);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 40);
            this.textBox4.TabIndex = 41;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 358);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 40);
            this.textBox3.TabIndex = 40;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 40);
            this.textBox2.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 275);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 40);
            this.textBox1.TabIndex = 38;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1091, 611);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sea);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.del);
            this.Controls.Add(this.ins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Employees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dis;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sea;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button ins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}