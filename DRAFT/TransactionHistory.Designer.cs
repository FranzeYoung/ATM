
namespace DRAFT
{
    partial class TransactionHistory
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
            this.transactionDataSet = new DRAFT.TransactionDataSet();
            this.accountTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTransactionTableAdapter = new DRAFT.TransactionDataSetTableAdapters.AccountTransactionTableAdapter();
            this.tableAdapterManager = new DRAFT.TransactionDataSetTableAdapters.TableAdapterManager();
            this.accountTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionDataSet
            // 
            this.transactionDataSet.DataSetName = "TransactionDataSet";
            this.transactionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTransactionBindingSource
            // 
            this.accountTransactionBindingSource.DataMember = "AccountTransaction";
            this.accountTransactionBindingSource.DataSource = this.transactionDataSet;
            // 
            // accountTransactionTableAdapter
            // 
            this.accountTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTransactionTableAdapter = this.accountTransactionTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DRAFT.TransactionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountTransactionDataGridView
            // 
            this.accountTransactionDataGridView.AutoGenerateColumns = false;
            this.accountTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.accountTransactionDataGridView.DataSource = this.accountTransactionBindingSource;
            this.accountTransactionDataGridView.Location = new System.Drawing.Point(-1, 55);
            this.accountTransactionDataGridView.Name = "accountTransactionDataGridView";
            this.accountTransactionDataGridView.RowHeadersWidth = 51;
            this.accountTransactionDataGridView.RowTemplate.Height = 24;
            this.accountTransactionDataGridView.Size = new System.Drawing.Size(805, 268);
            this.accountTransactionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Transaction ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AccountNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Account Number";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date & Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TransactionType";
            this.dataGridViewTextBoxColumn4.HeaderText = "Transaction Type";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn6.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // return1
            // 
            this.return1.Location = new System.Drawing.Point(343, 355);
            this.return1.Name = "return1";
            this.return1.Size = new System.Drawing.Size(133, 56);
            this.return1.TabIndex = 21;
            this.return1.Text = "Return";
            this.return1.UseVisualStyleBackColor = true;
            this.return1.Click += new System.EventHandler(this.return1_Click);
            // 
            // TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return1);
            this.Controls.Add(this.accountTransactionDataGridView);
            this.Name = "TransactionHistory";
            this.Text = "TransactionHistory";
            this.Load += new System.EventHandler(this.TransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTransactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransactionDataSet transactionDataSet;
        private System.Windows.Forms.BindingSource accountTransactionBindingSource;
        private TransactionDataSetTableAdapters.AccountTransactionTableAdapter accountTransactionTableAdapter;
        private TransactionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView accountTransactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button return1;
    }
}