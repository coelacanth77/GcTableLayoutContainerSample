namespace MultiRowSample
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            this.ユーザーBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDataSet = new MultiRowSample.SampleDataSet();
            this.ユーザーTableAdapter = new MultiRowSample.SampleDataSetTableAdapters.ユーザーTableAdapter();
            this.tableAdapterManager = new MultiRowSample.SampleDataSetTableAdapters.TableAdapterManager();
            this.gcTableLayoutContainer1 = new GrapeCity.Win.Containers.GcTableLayoutContainer();
            this.tableColumn1 = new GrapeCity.Win.Containers.TableColumn();
            this.tableColumn2 = new GrapeCity.Win.Containers.TableColumn();
            this.tableRow2 = new GrapeCity.Win.Containers.TableRow();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gcMultiRow1 = new GrapeCity.Win.MultiRow.GcMultiRow();
            this.sampleTemplate1 = new MultiRowSample.SampleTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.ユーザーBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTableLayoutContainer1)).BeginInit();
            this.gcTableLayoutContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMultiRow1)).BeginInit();
            this.SuspendLayout();
            // 
            // ユーザーBindingSource
            // 
            this.ユーザーBindingSource.DataMember = "ユーザー";
            this.ユーザーBindingSource.DataSource = this.sampleDataSet;
            // 
            // sampleDataSet
            // 
            this.sampleDataSet.DataSetName = "SampleDataSet";
            this.sampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ユーザーTableAdapter
            // 
            this.ユーザーTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MultiRowSample.SampleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ユーザーTableAdapter = this.ユーザーTableAdapter;
            // 
            // gcTableLayoutContainer1
            // 
            this.gcTableLayoutContainer1.Columns.AddRange(new GrapeCity.Win.Containers.TableColumn[] {
            this.tableColumn1,
            this.tableColumn2});
            this.gcTableLayoutContainer1.Rows.AddRange(new GrapeCity.Win.Containers.TableRow[] {
            this.tableRow2});
            this.gcTableLayoutContainer1.Controls.Add(this.listBox1, 0, 0);
            this.gcTableLayoutContainer1.Controls.Add(this.gcMultiRow1, 1, 0);
            this.gcTableLayoutContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTableLayoutContainer1.Location = new System.Drawing.Point(0, 0);
            this.gcTableLayoutContainer1.Name = "gcTableLayoutContainer1";
            this.gcTableLayoutContainer1.Size = new System.Drawing.Size(713, 523);
            this.gcTableLayoutContainer1.TabIndex = 1;
            // 
            // tableColumn1
            // 
            this.tableColumn1.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.tableColumn1.Width = 100F;
            // 
            // tableColumn2
            // 
            this.tableColumn2.Width = 100F;
            // 
            // tableRow2
            // 
            this.tableRow2.Height = 100F;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this.listBox1.Location = new System.Drawing.Point(5, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 376);
            this.listBox1.TabIndex = 1;
            // 
            // gcMultiRow1
            // 
            this.gcMultiRow1.AllowAutoExtend = true;
            this.gcMultiRow1.DataSource = this.ユーザーBindingSource;
            this.gcMultiRow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMultiRow1.Location = new System.Drawing.Point(105, 5);
            this.gcMultiRow1.Name = "gcMultiRow1";
            this.gcMultiRow1.Size = new System.Drawing.Size(603, 513);
            this.gcMultiRow1.TabIndex = 0;
            this.gcMultiRow1.Template = this.sampleTemplate1;
            this.gcMultiRow1.Text = "gcMultiRow1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 523);
            this.Controls.Add(this.gcTableLayoutContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ユーザーBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTableLayoutContainer1)).EndInit();
            this.gcTableLayoutContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMultiRow1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.Win.MultiRow.GcMultiRow gcMultiRow1;
        private SampleTemplate sampleTemplate1;
        private SampleDataSet sampleDataSet;
        private System.Windows.Forms.BindingSource ユーザーBindingSource;
        private SampleDataSetTableAdapters.ユーザーTableAdapter ユーザーTableAdapter;
        private SampleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GrapeCity.Win.Containers.GcTableLayoutContainer gcTableLayoutContainer1;
        private GrapeCity.Win.Containers.TableColumn tableColumn1;
        private GrapeCity.Win.Containers.TableColumn tableColumn2;
        private System.Windows.Forms.ListBox listBox1;
        private GrapeCity.Win.Containers.TableRow tableRow2;
    }
}

