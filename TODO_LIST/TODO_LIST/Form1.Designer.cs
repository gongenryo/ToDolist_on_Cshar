
namespace TODO_LIST
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Regist = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Allselect = new System.Windows.Forms.Button();
            this.Allunselect = new System.Windows.Forms.Button();
            this.Hidden = new System.Windows.Forms.Button();
            this.Redisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 62;
            this.grid.RowTemplate.Height = 27;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid.Size = new System.Drawing.Size(588, 316);
            this.grid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "完了";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 90F;
            this.Column2.HeaderText = "期限";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 250F;
            this.Column3.HeaderText = "内容";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "削除";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // dTP
            // 
            this.dTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP.Location = new System.Drawing.Point(635, 45);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(151, 25);
            this.dTP.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(635, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 25);
            this.textBox1.TabIndex = 2;
            // 
            // Regist
            // 
            this.Regist.Location = new System.Drawing.Point(635, 155);
            this.Regist.Name = "Regist";
            this.Regist.Size = new System.Drawing.Size(64, 42);
            this.Regist.TabIndex = 3;
            this.Regist.Text = "登録";
            this.Regist.UseVisualStyleBackColor = true;
            this.Regist.Click += new System.EventHandler(this.Regist_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(705, 155);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(64, 42);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "削除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(635, 203);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(64, 43);
            this.Save.TabIndex = 5;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Allselect
            // 
            this.Allselect.Location = new System.Drawing.Point(12, 334);
            this.Allselect.Name = "Allselect";
            this.Allselect.Size = new System.Drawing.Size(147, 32);
            this.Allselect.TabIndex = 6;
            this.Allselect.Text = "完了全選択";
            this.Allselect.UseVisualStyleBackColor = true;
            this.Allselect.Click += new System.EventHandler(this.Allselect_Click_1);
            // 
            // Allunselect
            // 
            this.Allunselect.Location = new System.Drawing.Point(12, 371);
            this.Allunselect.Name = "Allunselect";
            this.Allunselect.Size = new System.Drawing.Size(147, 33);
            this.Allunselect.TabIndex = 7;
            this.Allunselect.Text = "完了全非選択";
            this.Allunselect.UseVisualStyleBackColor = true;
            this.Allunselect.Click += new System.EventHandler(this.Allunselect_Click_1);
            // 
            // Hidden
            // 
            this.Hidden.Location = new System.Drawing.Point(165, 333);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(147, 32);
            this.Hidden.TabIndex = 8;
            this.Hidden.Text = "完了非表示";
            this.Hidden.UseVisualStyleBackColor = true;
            this.Hidden.Click += new System.EventHandler(this.Hidden_Click_1);
            // 
            // Redisplay
            // 
            this.Redisplay.Location = new System.Drawing.Point(165, 371);
            this.Redisplay.Name = "Redisplay";
            this.Redisplay.Size = new System.Drawing.Size(147, 33);
            this.Redisplay.TabIndex = 9;
            this.Redisplay.Text = "完了再表示";
            this.Redisplay.UseVisualStyleBackColor = true;
            this.Redisplay.Click += new System.EventHandler(this.Redisplay_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "期限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "内容";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Redisplay);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.Allunselect);
            this.Controls.Add(this.Allselect);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Regist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dTP);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "TODO LIST";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Regist;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Allselect;
        private System.Windows.Forms.Button Allunselect;
        private System.Windows.Forms.Button Hidden;
        private System.Windows.Forms.Button Redisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

