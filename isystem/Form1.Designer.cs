namespace isystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кураторыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fKСтудентыКураторыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кураторыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кураторыDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.предметыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметыDataGridView = new System.Windows.Forms.DataGridView();
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавателиDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кураторыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСтудентыКураторыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кураторыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кураторыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(103, 43);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(121, 93);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(99, 43);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(226, 93);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(101, 43);
            this.listBox3.TabIndex = 2;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(333, 93);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(105, 43);
            this.listBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Группа";
            // 
            // fKСтудентыКураторыBindingSource
            // 
            this.fKСтудентыКураторыBindingSource.DataSource = this.кураторыBindingSource;
            // 
            // кураторыDataGridView
            // 
            this.кураторыDataGridView.AllowUserToAddRows = false;
            this.кураторыDataGridView.AllowUserToDeleteRows = false;
            this.кураторыDataGridView.AutoGenerateColumns = false;
            this.кураторыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.кураторыDataGridView.DataSource = this.кураторыBindingSource;
            this.кураторыDataGridView.Location = new System.Drawing.Point(444, 28);
            this.кураторыDataGridView.Name = "кураторыDataGridView";
            this.кураторыDataGridView.ReadOnly = true;
            this.кураторыDataGridView.Size = new System.Drawing.Size(485, 82);
            this.кураторыDataGridView.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Студенты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Кураторы";
            // 
            // предметыDataGridView
            // 
            this.предметыDataGridView.AllowUserToAddRows = false;
            this.предметыDataGridView.AllowUserToDeleteRows = false;
            this.предметыDataGridView.AutoGenerateColumns = false;
            this.предметыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.предметыDataGridView.DataSource = this.предметыBindingSource;
            this.предметыDataGridView.Location = new System.Drawing.Point(623, 148);
            this.предметыDataGridView.Name = "предметыDataGridView";
            this.предметыDataGridView.ReadOnly = true;
            this.предметыDataGridView.Size = new System.Drawing.Size(294, 110);
            this.предметыDataGridView.TabIndex = 11;
            // 
            // преподавателиDataGridView
            // 
            this.преподавателиDataGridView.AllowUserToAddRows = false;
            this.преподавателиDataGridView.AllowUserToDeleteRows = false;
            this.преподавателиDataGridView.AutoGenerateColumns = false;
            this.преподавателиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.преподавателиDataGridView.DataSource = this.преподавателиBindingSource;
            this.преподавателиDataGridView.Location = new System.Drawing.Point(12, 186);
            this.преподавателиDataGridView.Name = "преподавателиDataGridView";
            this.преподавателиDataGridView.ReadOnly = true;
            this.преподавателиDataGridView.Size = new System.Drawing.Size(543, 96);
            this.преподавателиDataGridView.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Преподаватели";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(44, 142);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(34, 17);
            this.listBox5.TabIndex = 14;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(197, 142);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(149, 17);
            this.listBox6.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.преподавателиDataGridView);
            this.Controls.Add(this.предметыDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.кураторыDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кураторыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСтудентыКураторыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кураторыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кураторыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private System.Windows.Forms.BindingSource кураторыBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource fKСтудентыКураторыBindingSource;
        private System.Windows.Forms.BindingSource кураторыBindingSource1;
        private System.Windows.Forms.DataGridView кураторыDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource предметыBindingSource;
        private System.Windows.Forms.DataGridView предметыDataGridView;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private System.Windows.Forms.DataGridView преподавателиDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
    }
}

