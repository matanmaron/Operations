namespace SrvFolloweR
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_SaveExit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CallEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_LoadCalls = new System.Windows.Forms.Button();
            this.callIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reprepresentativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SaveExit
            // 
            this.button_SaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SaveExit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button_SaveExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_SaveExit.Location = new System.Drawing.Point(12, 668);
            this.button_SaveExit.Name = "button_SaveExit";
            this.button_SaveExit.Size = new System.Drawing.Size(241, 49);
            this.button_SaveExit.TabIndex = 2;
            this.button_SaveExit.UseVisualStyleBackColor = false;
            this.button_SaveExit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.callIDDataGridViewTextBoxColumn,
            this.reprepresentativeDataGridViewTextBoxColumn,
            this.contentsDataGridViewTextBoxColumn,
            this.callDateDataGridViewTextBoxColumn,
            this.CallEnd,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.callBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(10, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(984, 650);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // CallEnd
            // 
            this.CallEnd.DataPropertyName = "CallEnd";
            this.CallEnd.HeaderText = "CallEnd";
            this.CallEnd.Name = "CallEnd";
            this.CallEnd.ReadOnly = true;
            this.CallEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.BackColor = System.Drawing.Color.SpringGreen;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Save.Location = new System.Drawing.Point(755, 668);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(241, 49);
            this.button_Save.TabIndex = 6;
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_LoadCalls
            // 
            this.button_LoadCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LoadCalls.BackColor = System.Drawing.Color.Turquoise;
            this.button_LoadCalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_LoadCalls.Location = new System.Drawing.Point(508, 668);
            this.button_LoadCalls.Name = "button_LoadCalls";
            this.button_LoadCalls.Size = new System.Drawing.Size(241, 49);
            this.button_LoadCalls.TabIndex = 7;
            this.button_LoadCalls.UseVisualStyleBackColor = false;
            this.button_LoadCalls.Click += new System.EventHandler(this.button_LoadCalls_Click);
            // 
            // callIDDataGridViewTextBoxColumn
            // 
            this.callIDDataGridViewTextBoxColumn.DataPropertyName = "CallID";
            this.callIDDataGridViewTextBoxColumn.HeaderText = "CallID";
            this.callIDDataGridViewTextBoxColumn.Name = "callIDDataGridViewTextBoxColumn";
            this.callIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // reprepresentativeDataGridViewTextBoxColumn
            // 
            this.reprepresentativeDataGridViewTextBoxColumn.DataPropertyName = "Reprepresentative";
            this.reprepresentativeDataGridViewTextBoxColumn.HeaderText = "Reprepresentative";
            this.reprepresentativeDataGridViewTextBoxColumn.Name = "reprepresentativeDataGridViewTextBoxColumn";
            // 
            // contentsDataGridViewTextBoxColumn
            // 
            this.contentsDataGridViewTextBoxColumn.DataPropertyName = "Contents";
            this.contentsDataGridViewTextBoxColumn.HeaderText = "Contents";
            this.contentsDataGridViewTextBoxColumn.Name = "contentsDataGridViewTextBoxColumn";
            // 
            // callDateDataGridViewTextBoxColumn
            // 
            this.callDateDataGridViewTextBoxColumn.DataPropertyName = "CallDate";
            this.callDateDataGridViewTextBoxColumn.HeaderText = "CallDate";
            this.callDateDataGridViewTextBoxColumn.Name = "callDateDataGridViewTextBoxColumn";
            this.callDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.callDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // callBindingSource
            // 
            this.callBindingSource.DataSource = typeof(SrvFolloweR.Call);
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Back.BackColor = System.Drawing.Color.Thistle;
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Back.Location = new System.Drawing.Point(259, 668);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(241, 49);
            this.button_Back.TabIndex = 8;
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_LoadCalls);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_SaveExit);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_SaveExit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource callBindingSource;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_LoadCalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn callIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reprepresentativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Back;
    }
}

