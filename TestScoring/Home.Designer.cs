namespace TestScoring
{
    partial class Home
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
            this.nudAddScore = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddSubject = new System.Windows.Forms.Label();
            this.lblAddScore = new System.Windows.Forms.Label();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            this.cmdAddSubject = new System.Windows.Forms.ComboBox();
            this.cmdAddStudent = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFindSemester = new System.Windows.Forms.ComboBox();
            this.cmdFindSubjct = new System.Windows.Forms.ComboBox();
            this.lblFindSubject = new System.Windows.Forms.Label();
            this.nudFindYear = new System.Windows.Forms.NumericUpDown();
            this.lblFindYear = new System.Windows.Forms.Label();
            this.lblFindSemester = new System.Windows.Forms.Label();
            this.lblAddSemester = new System.Windows.Forms.Label();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.nudAddYear = new System.Windows.Forms.NumericUpDown();
            this.cmdAddSemester = new System.Windows.Forms.ComboBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpFind = new System.Windows.Forms.GroupBox();
            this.btnAppeal = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFindYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddYear)).BeginInit();
            this.grpAdd.SuspendLayout();
            this.grpFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAddScore
            // 
            this.nudAddScore.Location = new System.Drawing.Point(218, 280);
            this.nudAddScore.Name = "nudAddScore";
            this.nudAddScore.Size = new System.Drawing.Size(50, 19);
            this.nudAddScore.TabIndex = 2;
            this.nudAddScore.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(160, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAddSubject
            // 
            this.lblAddSubject.AutoSize = true;
            this.lblAddSubject.Location = new System.Drawing.Point(37, 177);
            this.lblAddSubject.Name = "lblAddSubject";
            this.lblAddSubject.Size = new System.Drawing.Size(41, 12);
            this.lblAddSubject.TabIndex = 5;
            this.lblAddSubject.Text = "教科名";
            // 
            // lblAddScore
            // 
            this.lblAddScore.AutoSize = true;
            this.lblAddScore.Location = new System.Drawing.Point(37, 280);
            this.lblAddScore.Name = "lblAddScore";
            this.lblAddScore.Size = new System.Drawing.Size(29, 12);
            this.lblAddScore.TabIndex = 7;
            this.lblAddScore.Text = "点数";
            this.lblAddScore.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.Location = new System.Drawing.Point(37, 222);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(29, 12);
            this.lblAddStudent.TabIndex = 8;
            this.lblAddStudent.Text = "名前";
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(243, 352);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(75, 30);
            this.btnTable.TabIndex = 10;
            this.btnTable.Text = "一覧";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdAddSubject
            // 
            this.cmdAddSubject.FormattingEnabled = true;
            this.cmdAddSubject.Location = new System.Drawing.Point(110, 174);
            this.cmdAddSubject.Name = "cmdAddSubject";
            this.cmdAddSubject.Size = new System.Drawing.Size(158, 20);
            this.cmdAddSubject.TabIndex = 100;
            this.cmdAddSubject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmdAddStudent
            // 
            this.cmdAddStudent.FormattingEnabled = true;
            this.cmdAddStudent.Location = new System.Drawing.Point(110, 219);
            this.cmdAddStudent.Name = "cmdAddStudent";
            this.cmdAddStudent.Size = new System.Drawing.Size(158, 20);
            this.cmdAddStudent.Sorted = true;
            this.cmdAddStudent.TabIndex = 100;
            this.cmdAddStudent.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(53, 352);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "編集";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "時期";
            // 
            // cmdFindSemester
            // 
            this.cmdFindSemester.FormattingEnabled = true;
            this.cmdFindSemester.Location = new System.Drawing.Point(199, 130);
            this.cmdFindSemester.Name = "cmdFindSemester";
            this.cmdFindSemester.Size = new System.Drawing.Size(94, 20);
            this.cmdFindSemester.TabIndex = 17;
            this.cmdFindSemester.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmdFindSubjct
            // 
            this.cmdFindSubjct.FormattingEnabled = true;
            this.cmdFindSubjct.Location = new System.Drawing.Point(135, 222);
            this.cmdFindSubjct.Name = "cmdFindSubjct";
            this.cmdFindSubjct.Size = new System.Drawing.Size(158, 20);
            this.cmdFindSubjct.TabIndex = 100;
            this.cmdFindSubjct.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // lblFindSubject
            // 
            this.lblFindSubject.AutoSize = true;
            this.lblFindSubject.Location = new System.Drawing.Point(44, 182);
            this.lblFindSubject.Name = "lblFindSubject";
            this.lblFindSubject.Size = new System.Drawing.Size(41, 12);
            this.lblFindSubject.TabIndex = 19;
            this.lblFindSubject.Text = "教科名";
            // 
            // nudFindYear
            // 
            this.nudFindYear.Location = new System.Drawing.Point(243, 82);
            this.nudFindYear.Name = "nudFindYear";
            this.nudFindYear.Size = new System.Drawing.Size(50, 19);
            this.nudFindYear.TabIndex = 21;
            this.nudFindYear.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblFindYear
            // 
            this.lblFindYear.AutoSize = true;
            this.lblFindYear.Location = new System.Drawing.Point(124, 84);
            this.lblFindYear.Name = "lblFindYear";
            this.lblFindYear.Size = new System.Drawing.Size(29, 12);
            this.lblFindYear.TabIndex = 22;
            this.lblFindYear.Text = "年度";
            this.lblFindYear.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblFindSemester
            // 
            this.lblFindSemester.AutoSize = true;
            this.lblFindSemester.Location = new System.Drawing.Point(94, 133);
            this.lblFindSemester.Name = "lblFindSemester";
            this.lblFindSemester.Size = new System.Drawing.Size(59, 12);
            this.lblFindSemester.TabIndex = 23;
            this.lblFindSemester.Text = "前期・後期";
            this.lblFindSemester.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblAddSemester
            // 
            this.lblAddSemester.AutoSize = true;
            this.lblAddSemester.Location = new System.Drawing.Point(69, 128);
            this.lblAddSemester.Name = "lblAddSemester";
            this.lblAddSemester.Size = new System.Drawing.Size(59, 12);
            this.lblAddSemester.TabIndex = 28;
            this.lblAddSemester.Text = "前期・後期";
            this.lblAddSemester.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblAddYear
            // 
            this.lblAddYear.AutoSize = true;
            this.lblAddYear.Location = new System.Drawing.Point(99, 79);
            this.lblAddYear.Name = "lblAddYear";
            this.lblAddYear.Size = new System.Drawing.Size(29, 12);
            this.lblAddYear.TabIndex = 27;
            this.lblAddYear.Text = "年度";
            // 
            // nudAddYear
            // 
            this.nudAddYear.Location = new System.Drawing.Point(218, 77);
            this.nudAddYear.Name = "nudAddYear";
            this.nudAddYear.Size = new System.Drawing.Size(50, 19);
            this.nudAddYear.TabIndex = 26;
            this.nudAddYear.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // cmdAddSemester
            // 
            this.cmdAddSemester.FormattingEnabled = true;
            this.cmdAddSemester.Location = new System.Drawing.Point(174, 125);
            this.cmdAddSemester.Name = "cmdAddSemester";
            this.cmdAddSemester.Size = new System.Drawing.Size(94, 20);
            this.cmdAddSemester.TabIndex = 25;
            this.cmdAddSemester.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged_1);
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(37, 33);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(29, 12);
            this.lblSeason.TabIndex = 24;
            this.lblSeason.Text = "時期";
            this.lblSeason.Click += new System.EventHandler(this.season_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnSave);
            this.grpAdd.Controls.Add(this.lblSeason);
            this.grpAdd.Controls.Add(this.lblAddSemester);
            this.grpAdd.Controls.Add(this.nudAddScore);
            this.grpAdd.Controls.Add(this.lblAddYear);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.nudAddYear);
            this.grpAdd.Controls.Add(this.lblAddSubject);
            this.grpAdd.Controls.Add(this.cmdAddSemester);
            this.grpAdd.Controls.Add(this.lblAddScore);
            this.grpAdd.Controls.Add(this.lblAddStudent);
            this.grpAdd.Controls.Add(this.cmdAddSubject);
            this.grpAdd.Controls.Add(this.cmdAddStudent);
            this.grpAdd.Controls.Add(this.btnEdit);
            this.grpAdd.Location = new System.Drawing.Point(12, 12);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(365, 404);
            this.grpAdd.TabIndex = 29;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "新規追加";
            this.grpAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 101;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.btnAppeal);
            this.grpFind.Controls.Add(this.btnFind);
            this.grpFind.Controls.Add(this.label1);
            this.grpFind.Controls.Add(this.lblFindSemester);
            this.grpFind.Controls.Add(this.btnTable);
            this.grpFind.Controls.Add(this.lblFindYear);
            this.grpFind.Controls.Add(this.cmdFindSemester);
            this.grpFind.Controls.Add(this.nudFindYear);
            this.grpFind.Controls.Add(this.lblFindSubject);
            this.grpFind.Controls.Add(this.cmdFindSubjct);
            this.grpFind.Location = new System.Drawing.Point(423, 12);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(365, 408);
            this.grpFind.TabIndex = 30;
            this.grpFind.TabStop = false;
            this.grpFind.Text = "検索";
            this.grpFind.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAppeal
            // 
            this.btnAppeal.Location = new System.Drawing.Point(30, 352);
            this.btnAppeal.Name = "btnAppeal";
            this.btnAppeal.Size = new System.Drawing.Size(75, 30);
            this.btnAppeal.TabIndex = 103;
            this.btnAppeal.Text = "アピール";
            this.btnAppeal.UseVisualStyleBackColor = true;
            this.btnAppeal.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(135, 352);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 30);
            this.btnFind.TabIndex = 101;
            this.btnFind.Text = "検索";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button5_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpFind);
            this.Controls.Add(this.grpAdd);
            this.Name = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAddScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFindYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddYear)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudAddScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddSubject;
        private System.Windows.Forms.Label lblAddScore;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.ComboBox cmdAddSubject;
        private System.Windows.Forms.ComboBox cmdAddStudent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdFindSemester;
        private System.Windows.Forms.ComboBox cmdFindSubjct;
        private System.Windows.Forms.Label lblFindSubject;
        private System.Windows.Forms.NumericUpDown nudFindYear;
        private System.Windows.Forms.Label lblFindYear;
        private System.Windows.Forms.Label lblFindSemester;
        private System.Windows.Forms.Label lblAddSemester;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.NumericUpDown nudAddYear;
        private System.Windows.Forms.ComboBox cmdAddSemester;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.GroupBox grpFind;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAppeal;
    }
}

