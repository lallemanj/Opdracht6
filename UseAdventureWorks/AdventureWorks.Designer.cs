namespace UseAdventureWorks
{
    partial class AdventureWorks
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
            System.Windows.Forms.Label countryRegionCodeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label currencyCodeLabel;
            System.Windows.Forms.Label nameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventureWorks));
            this.countryRegionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.countryRegionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.countryRegionCodeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countryRegionCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionCurrencyDataGridView = new System.Windows.Forms.DataGridView();
            this.currencyCodeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.countryRegionCurrencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.currencyDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDataSet = new UseAdventureWorks.AdventureWorksDataSet();
            this.countryRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryRegionTableAdapter = new UseAdventureWorks.AdventureWorksDataSetTableAdapters.CountryRegionTableAdapter();
            this.tableAdapterManager = new UseAdventureWorks.AdventureWorksDataSetTableAdapters.TableAdapterManager();
            this.countryRegionCurrencyTableAdapter = new UseAdventureWorks.AdventureWorksDataSetTableAdapters.CountryRegionCurrencyTableAdapter();
            this.currencyTableAdapter = new UseAdventureWorks.AdventureWorksDataSetTableAdapters.CurrencyTableAdapter();
            this.countryRegionCurrencyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionCurrencyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            countryRegionCodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            currencyCodeLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingNavigator)).BeginInit();
            this.countryRegionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // countryRegionCodeLabel
            // 
            countryRegionCodeLabel.AutoSize = true;
            countryRegionCodeLabel.Location = new System.Drawing.Point(22, 72);
            countryRegionCodeLabel.Name = "countryRegionCodeLabel";
            countryRegionCodeLabel.Size = new System.Drawing.Size(111, 13);
            countryRegionCodeLabel.TabIndex = 1;
            countryRegionCodeLabel.Text = "Country Region Code:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 98);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // currencyCodeLabel
            // 
            currencyCodeLabel.AutoSize = true;
            currencyCodeLabel.Location = new System.Drawing.Point(498, 76);
            currencyCodeLabel.Name = "currencyCodeLabel";
            currencyCodeLabel.Size = new System.Drawing.Size(80, 13);
            currencyCodeLabel.TabIndex = 6;
            currencyCodeLabel.Text = "Currency Code:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(498, 102);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 8;
            nameLabel1.Text = "Name:";
            // 
            // countryRegionBindingNavigator
            // 
            this.countryRegionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.countryRegionBindingNavigator.BindingSource = this.countryRegionBindingSource;
            this.countryRegionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.countryRegionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.countryRegionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.countryRegionBindingNavigatorSaveItem});
            this.countryRegionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.countryRegionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.countryRegionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.countryRegionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.countryRegionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.countryRegionBindingNavigator.Name = "countryRegionBindingNavigator";
            this.countryRegionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.countryRegionBindingNavigator.Size = new System.Drawing.Size(937, 25);
            this.countryRegionBindingNavigator.TabIndex = 0;
            this.countryRegionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // countryRegionBindingNavigatorSaveItem
            // 
            this.countryRegionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryRegionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countryRegionBindingNavigatorSaveItem.Image")));
            this.countryRegionBindingNavigatorSaveItem.Name = "countryRegionBindingNavigatorSaveItem";
            this.countryRegionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.countryRegionBindingNavigatorSaveItem.Text = "Save Data";
            this.countryRegionBindingNavigatorSaveItem.Click += new System.EventHandler(this.countryRegionBindingNavigatorSaveItem_Click);
            // 
            // countryRegionCodeTextBox
            // 
            this.countryRegionCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryRegionBindingSource, "CountryRegionCode", true));
            this.countryRegionCodeTextBox.Location = new System.Drawing.Point(139, 69);
            this.countryRegionCodeTextBox.Name = "countryRegionCodeTextBox";
            this.countryRegionCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryRegionCodeTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryRegionBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(139, 95);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // countryRegionCurrencyBindingSource
            // 
            this.countryRegionCurrencyBindingSource.DataMember = "FK_CountryRegionCurrency_CountryRegion_CountryRegionCode";
            this.countryRegionCurrencyBindingSource.DataSource = this.countryRegionBindingSource;
            // 
            // countryRegionCurrencyDataGridView
            // 
            this.countryRegionCurrencyDataGridView.AllowUserToAddRows = false;
            this.countryRegionCurrencyDataGridView.AllowUserToDeleteRows = false;
            this.countryRegionCurrencyDataGridView.AutoGenerateColumns = false;
            this.countryRegionCurrencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryRegionCurrencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.countryRegionCurrencyDataGridView.DataSource = this.countryRegionCurrencyBindingSource;
            this.countryRegionCurrencyDataGridView.Location = new System.Drawing.Point(63, 157);
            this.countryRegionCurrencyDataGridView.Name = "countryRegionCurrencyDataGridView";
            this.countryRegionCurrencyDataGridView.ReadOnly = true;
            this.countryRegionCurrencyDataGridView.Size = new System.Drawing.Size(303, 190);
            this.countryRegionCurrencyDataGridView.TabIndex = 5;
            this.countryRegionCurrencyDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.countryRegionCurrencyDataGridView_CellMouseClick);
            // 
            // currencyCodeTextBox
            // 
            this.currencyCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "CurrencyCode", true));
            this.currencyCodeTextBox.Location = new System.Drawing.Point(584, 73);
            this.currencyCodeTextBox.Name = "currencyCodeTextBox";
            this.currencyCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.currencyCodeTextBox.TabIndex = 7;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(584, 99);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox1.TabIndex = 9;
            // 
            // countryRegionCurrencyBindingSource1
            // 
            this.countryRegionCurrencyBindingSource1.DataMember = "FK_CountryRegionCurrency_Currency_CurrencyCode";
            this.countryRegionCurrencyBindingSource1.DataSource = this.currencyBindingSource;
            // 
            // currencyDataGridView
            // 
            this.currencyDataGridView.AllowUserToAddRows = false;
            this.currencyDataGridView.AllowUserToDeleteRows = false;
            this.currencyDataGridView.AutoGenerateColumns = false;
            this.currencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.currencyDataGridView.DataSource = this.currencyBindingSource;
            this.currencyDataGridView.Location = new System.Drawing.Point(501, 146);
            this.currencyDataGridView.Name = "currencyDataGridView";
            this.currencyDataGridView.ReadOnly = true;
            this.currencyDataGridView.Size = new System.Drawing.Size(346, 201);
            this.currencyDataGridView.TabIndex = 12;
            this.currencyDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.currencyDataGridView_CellMouseEnter);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryRegionCurrencyBindingSource, "CurrencyCode", true));
            this.textBox1.Location = new System.Drawing.Point(139, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CURRENCY CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "CURRENCY MUNT";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "Name", true));
            this.textBox2.Location = new System.Drawing.Point(546, 399);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 15;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(937, 25);
            this.fillByToolStrip.TabIndex = 17;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryRegionBindingSource
            // 
            this.countryRegionBindingSource.DataMember = "CountryRegion";
            this.countryRegionBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CurrencyCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "CurrencyCode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CountryRegionCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "CountryRegionCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CurrencyCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "CurrencyCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // countryRegionTableAdapter
            // 
            this.countryRegionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryRegionCurrencyTableAdapter = this.countryRegionCurrencyTableAdapter;
            this.tableAdapterManager.CountryRegionTableAdapter = this.countryRegionTableAdapter;
            this.tableAdapterManager.CurrencyTableAdapter = this.currencyTableAdapter;
            this.tableAdapterManager.UpdateOrder = UseAdventureWorks.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // countryRegionCurrencyTableAdapter
            // 
            this.countryRegionCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // countryRegionCurrencyBindingSource2
            // 
            this.countryRegionCurrencyBindingSource2.DataMember = "CountryRegionCurrency";
            this.countryRegionCurrencyBindingSource2.DataSource = this.adventureWorksDataSet;
            // 
            // countryRegionCurrencyBindingSource3
            // 
            this.countryRegionCurrencyBindingSource3.DataMember = "CountryRegionCurrency";
            this.countryRegionCurrencyBindingSource3.DataSource = this.adventureWorksDataSet;
            // 
            // AdventureWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 628);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.currencyDataGridView);
            this.Controls.Add(currencyCodeLabel);
            this.Controls.Add(this.currencyCodeTextBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.countryRegionCurrencyDataGridView);
            this.Controls.Add(countryRegionCodeLabel);
            this.Controls.Add(this.countryRegionCodeTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.countryRegionBindingNavigator);
            this.Name = "AdventureWorks";
            this.Text = "Adventure Works";
            this.Load += new System.EventHandler(this.AdventureWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingNavigator)).EndInit();
            this.countryRegionBindingNavigator.ResumeLayout(false);
            this.countryRegionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource countryRegionBindingSource;
        private AdventureWorksDataSetTableAdapters.CountryRegionTableAdapter countryRegionTableAdapter;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator countryRegionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton countryRegionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox countryRegionCodeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private AdventureWorksDataSetTableAdapters.CountryRegionCurrencyTableAdapter countryRegionCurrencyTableAdapter;
        private System.Windows.Forms.BindingSource countryRegionCurrencyBindingSource;
        private AdventureWorksDataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.DataGridView countryRegionCurrencyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.TextBox currencyCodeTextBox;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.BindingSource countryRegionCurrencyBindingSource1;
        private System.Windows.Forms.DataGridView currencyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource countryRegionCurrencyBindingSource2;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource countryRegionCurrencyBindingSource3;
    }
}

