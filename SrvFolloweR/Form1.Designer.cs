namespace SrvFolloweR
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_SaveExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reshumaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reshumaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Save = new System.Windows.Forms.Button();
            this.button_GetCalls = new System.Windows.Forms.Button();
            this.checkBox_English = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoLoad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reshumaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Load
            // 
            this.button_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Load.BackColor = System.Drawing.Color.Turquoise;
            this.button_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button_Load.Location = new System.Drawing.Point(506, 668);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(241, 49);
            this.button_Load.TabIndex = 1;
            this.button_Load.UseVisualStyleBackColor = false;
            this.button_Load.Click += new System.EventHandler(this.button1_getlist_Click);
            // 
            // button_SaveExit
            // 
            this.button_SaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SaveExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_SaveExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_SaveExit.Location = new System.Drawing.Point(12, 668);
            this.button_SaveExit.Name = "button_SaveExit";
            this.button_SaveExit.Size = new System.Drawing.Size(241, 49);
            this.button_SaveExit.TabIndex = 2;
            this.button_SaveExit.UseVisualStyleBackColor = false;
            this.button_SaveExit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reshumaIdDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.zoneDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.EndDate});
            this.dataGridView1.DataSource = this.reshumaBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 604);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // reshumaIdDataGridViewTextBoxColumn
            // 
            this.reshumaIdDataGridViewTextBoxColumn.DataPropertyName = "ReshumaId";
            this.reshumaIdDataGridViewTextBoxColumn.HeaderText = "ReshumaId";
            this.reshumaIdDataGridViewTextBoxColumn.Name = "reshumaIdDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Zone";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // reshumaBindingSource
            // 
            this.reshumaBindingSource.DataSource = typeof(SrvFolloweR.Reshuma);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.BackColor = System.Drawing.Color.SpringGreen;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button_Save.Location = new System.Drawing.Point(753, 668);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(241, 49);
            this.button_Save.TabIndex = 6;
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button2_savelist_Click);
            // 
            // button_GetCalls
            // 
            this.button_GetCalls.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_GetCalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button_GetCalls.Location = new System.Drawing.Point(10, 12);
            this.button_GetCalls.Name = "button_GetCalls";
            this.button_GetCalls.Size = new System.Drawing.Size(241, 40);
            this.button_GetCalls.TabIndex = 8;
            this.button_GetCalls.UseVisualStyleBackColor = false;
            this.button_GetCalls.Click += new System.EventHandler(this.button_GetCalls_Click);
            // 
            // checkBox_English
            // 
            this.checkBox_English.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_English.AutoSize = true;
            this.checkBox_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox_English.Location = new System.Drawing.Point(804, 12);
            this.checkBox_English.Name = "checkBox_English";
            this.checkBox_English.Size = new System.Drawing.Size(15, 14);
            this.checkBox_English.TabIndex = 9;
            this.checkBox_English.UseVisualStyleBackColor = true;
            this.checkBox_English.CheckedChanged += new System.EventHandler(this.checkBox_English_CheckedChanged);
            // 
            // checkBox_AutoLoad
            // 
            this.checkBox_AutoLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_AutoLoad.AutoSize = true;
            this.checkBox_AutoLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox_AutoLoad.Location = new System.Drawing.Point(505, 12);
            this.checkBox_AutoLoad.Name = "checkBox_AutoLoad";
            this.checkBox_AutoLoad.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AutoLoad.TabIndex = 10;
            this.checkBox_AutoLoad.UseVisualStyleBackColor = true;
            this.checkBox_AutoLoad.CheckedChanged += new System.EventHandler(this.checkBox_AutoLoad_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.checkBox_AutoLoad);
            this.Controls.Add(this.checkBox_English);
            this.Controls.Add(this.button_GetCalls);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_SaveExit);
            this.Controls.Add(this.button_Load);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reshumaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_SaveExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.BindingSource reshumaBindingSource;
        private System.Windows.Forms.Button button_GetCalls;
        private System.Windows.Forms.CheckBox checkBox_English;
        private System.Windows.Forms.CheckBox checkBox_AutoLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn reshumaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}

