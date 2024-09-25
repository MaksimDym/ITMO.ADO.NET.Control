namespace ITMO.ADO.NET.Control
{
    partial class Database
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButConnect = new System.Windows.Forms.Button();
            this.postgres = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.Maksim1990 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.txtNewFlightNo = new System.Windows.Forms.TextBox();
            this.ButAdd = new System.Windows.Forms.Button();
            this.ButDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // ButConnect
            // 
            this.ButConnect.Location = new System.Drawing.Point(224, 165);
            this.ButConnect.Name = "ButConnect";
            this.ButConnect.Size = new System.Drawing.Size(114, 27);
            this.ButConnect.TabIndex = 0;
            this.ButConnect.Text = "Connect";
            this.ButConnect.UseVisualStyleBackColor = true;
            this.ButConnect.Click += new System.EventHandler(this.ButConnect_Click);
            // 
            // postgres
            // 
            this.postgres.Location = new System.Drawing.Point(224, 66);
            this.postgres.Name = "postgres";
            this.postgres.Size = new System.Drawing.Size(169, 20);
            this.postgres.TabIndex = 1;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(163, 69);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(29, 13);
            this.User.TabIndex = 2;
            this.User.Text = "User";
            // 
            // Maksim1990
            // 
            this.Maksim1990.Location = new System.Drawing.Point(224, 110);
            this.Maksim1990.Name = "Maksim1990";
            this.Maksim1990.Size = new System.Drawing.Size(169, 20);
            this.Maksim1990.TabIndex = 3;
            this.Maksim1990.UseSystemPasswordChar = true;
            this.Maksim1990.Validated += new System.EventHandler(this.ButConnect_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(145, 113);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(430, 66);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(293, 163);
            this.Table.TabIndex = 5;
            // 
            // txtNewFlightNo
            // 
            this.txtNewFlightNo.Location = new System.Drawing.Point(430, 313);
            this.txtNewFlightNo.Name = "txtNewFlightNo";
            this.txtNewFlightNo.Size = new System.Drawing.Size(293, 20);
            this.txtNewFlightNo.TabIndex = 6;
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(430, 366);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(124, 23);
            this.ButAdd.TabIndex = 7;
            this.ButAdd.Text = "Add";
            this.ButAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // ButDelete
            // 
            this.ButDelete.Location = new System.Drawing.Point(600, 366);
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Size = new System.Drawing.Size(123, 23);
            this.ButDelete.TabIndex = 8;
            this.ButDelete.Text = "Delete";
            this.ButDelete.UseVisualStyleBackColor = true;
            this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 436);
            this.Controls.Add(this.ButDelete);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.txtNewFlightNo);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Maksim1990);
            this.Controls.Add(this.User);
            this.Controls.Add(this.postgres);
            this.Controls.Add(this.ButConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButConnect;
        private System.Windows.Forms.TextBox postgres;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox Maksim1990;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox txtNewFlightNo;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button ButDelete;
    }
}

