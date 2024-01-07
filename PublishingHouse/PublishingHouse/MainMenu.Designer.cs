
namespace PublishingHouse
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            Tabs = new System.Windows.Forms.MenuStrip();
            employeeTab = new System.Windows.Forms.ToolStripMenuItem();
            materialTab = new System.Windows.Forms.ToolStripMenuItem();
            printingHouseTab = new System.Windows.Forms.ToolStripMenuItem();
            customersTab = new System.Windows.Forms.ToolStripMenuItem();
            productTab = new System.Windows.Forms.ToolStripMenuItem();
            bookingDataGridView = new System.Windows.Forms.DataGridView();
            Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            inputDataButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            resetSearchButton = new System.Windows.Forms.Button();
            toDataLabel = new System.Windows.Forms.Label();
            fromDataLabel = new System.Windows.Forms.Label();
            toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            dateComboBox = new System.Windows.Forms.ComboBox();
            dateLabel = new System.Windows.Forms.Label();
            searchDateButton = new System.Windows.Forms.Button();
            searchNumbersButton = new System.Windows.Forms.Button();
            generateReportButton = new System.Windows.Forms.Button();
            fromTextBox = new System.Windows.Forms.TextBox();
            toLabel = new System.Windows.Forms.Label();
            toTextBox = new System.Windows.Forms.TextBox();
            fromLabel = new System.Windows.Forms.Label();
            numberComboBox = new System.Windows.Forms.ComboBox();
            intLabel = new System.Windows.Forms.Label();
            stringTextBox = new System.Windows.Forms.TextBox();
            stringDataLabel = new System.Windows.Forms.Label();
            stringComboBox = new System.Windows.Forms.ComboBox();
            stringColumnLabel = new System.Windows.Forms.Label();
            changeLabel = new System.Windows.Forms.Label();
            completeBookingButton = new System.Windows.Forms.Button();
            resetSelectRowsButton = new System.Windows.Forms.Button();
            selectAllRowsButton = new System.Windows.Forms.Button();
            changeButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            resetAddOrChangeButton = new System.Windows.Forms.Button();
            selectForChangeButton = new System.Windows.Forms.Button();
            addLabel = new System.Windows.Forms.Label();
            addButton = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            processingTab = new System.Windows.Forms.ToolStripMenuItem();
            searchTab = new System.Windows.Forms.ToolStripMenuItem();
            Tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookingDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.ImageScalingSize = new System.Drawing.Size(20, 20);
            Tabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { employeeTab, materialTab, printingHouseTab, customersTab, productTab });
            Tabs.Location = new System.Drawing.Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.Size = new System.Drawing.Size(1291, 28);
            Tabs.TabIndex = 0;
            Tabs.Text = "menuStrip1";
            // 
            // employeeTab
            // 
            employeeTab.Image = (System.Drawing.Image)resources.GetObject("employeeTab.Image");
            employeeTab.Name = "employeeTab";
            employeeTab.Size = new System.Drawing.Size(125, 24);
            employeeTab.Text = "Сотрудники";
            employeeTab.Click += employeeTab_Click;
            // 
            // materialTab
            // 
            materialTab.Image = (System.Drawing.Image)resources.GetObject("materialTab.Image");
            materialTab.Name = "materialTab";
            materialTab.Size = new System.Drawing.Size(123, 24);
            materialTab.Text = "Материалы";
            materialTab.Click += materialTab_Click;
            // 
            // printingHouseTab
            // 
            printingHouseTab.Image = (System.Drawing.Image)resources.GetObject("printingHouseTab.Image");
            printingHouseTab.Name = "printingHouseTab";
            printingHouseTab.Size = new System.Drawing.Size(129, 24);
            printingHouseTab.Text = "Типографии";
            printingHouseTab.Click += printingHouseTab_Click;
            // 
            // customersTab
            // 
            customersTab.Image = (System.Drawing.Image)resources.GetObject("customersTab.Image");
            customersTab.Name = "customersTab";
            customersTab.Size = new System.Drawing.Size(114, 24);
            customersTab.Text = "Заказчики";
            customersTab.Click += customersTab_Click;
            // 
            // productTab
            // 
            productTab.Image = (System.Drawing.Image)resources.GetObject("productTab.Image");
            productTab.Name = "productTab";
            productTab.Size = new System.Drawing.Size(188, 24);
            productTab.Text = "Печатная продукция";
            productTab.Click += productTab_Click;
            // 
            // bookingDataGridView
            // 
            bookingDataGridView.AllowUserToAddRows = false;
            bookingDataGridView.AllowUserToDeleteRows = false;
            bookingDataGridView.AllowUserToResizeColumns = false;
            bookingDataGridView.AllowUserToResizeRows = false;
            bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Select });
            bookingDataGridView.Location = new System.Drawing.Point(12, 47);
            bookingDataGridView.Name = "bookingDataGridView";
            bookingDataGridView.RowHeadersVisible = false;
            bookingDataGridView.RowHeadersWidth = 51;
            bookingDataGridView.RowTemplate.Height = 50;
            bookingDataGridView.Size = new System.Drawing.Size(1267, 308);
            bookingDataGridView.TabIndex = 1;
            bookingDataGridView.CellContentClick += bookingDataGridView_CellContentClick;
            bookingDataGridView.ColumnStateChanged += bookingDataGridView_ColumnStateChanged;
            // 
            // Select
            // 
            Select.HeaderText = "Выбрать";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Width = 125;
            // 
            // inputDataButton
            // 
            inputDataButton.Location = new System.Drawing.Point(6, 66);
            inputDataButton.Name = "inputDataButton";
            inputDataButton.Size = new System.Drawing.Size(207, 53);
            inputDataButton.TabIndex = 2;
            inputDataButton.Text = "Сформировать заказ";
            inputDataButton.UseVisualStyleBackColor = true;
            inputDataButton.Click += inputDataButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resetSearchButton);
            groupBox1.Controls.Add(toDataLabel);
            groupBox1.Controls.Add(fromDataLabel);
            groupBox1.Controls.Add(toDateTimePicker);
            groupBox1.Controls.Add(fromDateTimePicker);
            groupBox1.Controls.Add(dateComboBox);
            groupBox1.Controls.Add(dateLabel);
            groupBox1.Controls.Add(searchDateButton);
            groupBox1.Controls.Add(searchNumbersButton);
            groupBox1.Controls.Add(generateReportButton);
            groupBox1.Controls.Add(fromTextBox);
            groupBox1.Controls.Add(toLabel);
            groupBox1.Controls.Add(toTextBox);
            groupBox1.Controls.Add(fromLabel);
            groupBox1.Controls.Add(numberComboBox);
            groupBox1.Controls.Add(intLabel);
            groupBox1.Controls.Add(stringTextBox);
            groupBox1.Controls.Add(stringDataLabel);
            groupBox1.Controls.Add(stringComboBox);
            groupBox1.Controls.Add(stringColumnLabel);
            groupBox1.Controls.Add(changeLabel);
            groupBox1.Controls.Add(completeBookingButton);
            groupBox1.Controls.Add(resetSelectRowsButton);
            groupBox1.Controls.Add(selectAllRowsButton);
            groupBox1.Controls.Add(changeButton);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(resetAddOrChangeButton);
            groupBox1.Controls.Add(selectForChangeButton);
            groupBox1.Controls.Add(addLabel);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(inputDataButton);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new System.Drawing.Point(12, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1267, 226);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Работа с данными";
            // 
            // resetSearchButton
            // 
            resetSearchButton.Location = new System.Drawing.Point(1086, 66);
            resetSearchButton.Name = "resetSearchButton";
            resetSearchButton.Size = new System.Drawing.Size(175, 136);
            resetSearchButton.TabIndex = 33;
            resetSearchButton.Text = "Сброс поиска";
            resetSearchButton.UseVisualStyleBackColor = true;
            resetSearchButton.Visible = false;
            resetSearchButton.Click += resetSearchButton_Click;
            // 
            // toDataLabel
            // 
            toDataLabel.AutoSize = true;
            toDataLabel.Location = new System.Drawing.Point(768, 182);
            toDataLabel.Name = "toDataLabel";
            toDataLabel.Size = new System.Drawing.Size(29, 20);
            toDataLabel.TabIndex = 32;
            toDataLabel.Text = "По";
            toDataLabel.Visible = false;
            // 
            // fromDataLabel
            // 
            fromDataLabel.AutoSize = true;
            fromDataLabel.Location = new System.Drawing.Point(771, 151);
            fromDataLabel.Name = "fromDataLabel";
            fromDataLabel.Size = new System.Drawing.Size(18, 20);
            fromDataLabel.TabIndex = 31;
            fromDataLabel.Text = "С";
            fromDataLabel.Visible = false;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Location = new System.Drawing.Point(803, 178);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new System.Drawing.Size(225, 27);
            toDateTimePicker.TabIndex = 30;
            toDateTimePicker.Visible = false;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new System.Drawing.Point(803, 147);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new System.Drawing.Size(225, 27);
            fromDateTimePicker.TabIndex = 29;
            fromDateTimePicker.Visible = false;
            // 
            // dateComboBox
            // 
            dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dateComboBox.FormattingEnabled = true;
            dateComboBox.Location = new System.Drawing.Point(764, 89);
            dateComboBox.Name = "dateComboBox";
            dateComboBox.Size = new System.Drawing.Size(264, 28);
            dateComboBox.TabIndex = 28;
            dateComboBox.Visible = false;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(822, 66);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(148, 20);
            dateLabel.TabIndex = 27;
            dateLabel.Text = "Столбец для поиска";
            dateLabel.Visible = false;
            // 
            // searchDateButton
            // 
            searchDateButton.Location = new System.Drawing.Point(607, 151);
            searchDateButton.Name = "searchDateButton";
            searchDateButton.Size = new System.Drawing.Size(146, 51);
            searchDateButton.TabIndex = 26;
            searchDateButton.Text = "Поиск по дате";
            searchDateButton.UseVisualStyleBackColor = true;
            searchDateButton.Visible = false;
            searchDateButton.Click += searchDateButton_Click;
            // 
            // searchNumbersButton
            // 
            searchNumbersButton.Location = new System.Drawing.Point(607, 64);
            searchNumbersButton.Name = "searchNumbersButton";
            searchNumbersButton.Size = new System.Drawing.Size(146, 53);
            searchNumbersButton.TabIndex = 25;
            searchNumbersButton.Text = "Поиск числовых данных";
            searchNumbersButton.UseVisualStyleBackColor = true;
            searchNumbersButton.Visible = false;
            searchNumbersButton.Click += searchNumbersButton_Click;
            // 
            // generateReportButton
            // 
            generateReportButton.Location = new System.Drawing.Point(1086, 151);
            generateReportButton.Name = "generateReportButton";
            generateReportButton.Size = new System.Drawing.Size(175, 51);
            generateReportButton.TabIndex = 24;
            generateReportButton.Text = "Сформировать отчёт";
            generateReportButton.UseVisualStyleBackColor = true;
            generateReportButton.Click += generateReportButton_Click;
            // 
            // fromTextBox
            // 
            fromTextBox.Location = new System.Drawing.Point(330, 175);
            fromTextBox.MaxLength = 8;
            fromTextBox.Name = "fromTextBox";
            fromTextBox.Size = new System.Drawing.Size(125, 27);
            fromTextBox.TabIndex = 23;
            fromTextBox.Visible = false;
            fromTextBox.KeyPress += fromTextBox_KeyPress;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new System.Drawing.Point(515, 154);
            toLabel.Name = "toLabel";
            toLabel.Size = new System.Drawing.Size(28, 20);
            toLabel.TabIndex = 22;
            toLabel.Text = "До";
            toLabel.Visible = false;
            // 
            // toTextBox
            // 
            toTextBox.Location = new System.Drawing.Point(469, 175);
            toTextBox.MaxLength = 8;
            toTextBox.Name = "toTextBox";
            toTextBox.Size = new System.Drawing.Size(125, 27);
            toTextBox.TabIndex = 21;
            toTextBox.Visible = false;
            toTextBox.KeyPress += fromTextBox_KeyPress;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new System.Drawing.Point(377, 154);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new System.Drawing.Size(26, 20);
            fromLabel.TabIndex = 20;
            fromLabel.Text = "От";
            fromLabel.Visible = false;
            // 
            // numberComboBox
            // 
            numberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            numberComboBox.FormattingEnabled = true;
            numberComboBox.Location = new System.Drawing.Point(330, 89);
            numberComboBox.Name = "numberComboBox";
            numberComboBox.Size = new System.Drawing.Size(264, 28);
            numberComboBox.TabIndex = 19;
            numberComboBox.Visible = false;
            // 
            // intLabel
            // 
            intLabel.AutoSize = true;
            intLabel.Location = new System.Drawing.Point(392, 66);
            intLabel.Name = "intLabel";
            intLabel.Size = new System.Drawing.Size(148, 20);
            intLabel.TabIndex = 18;
            intLabel.Text = "Столбец для поиска";
            intLabel.Visible = false;
            // 
            // stringTextBox
            // 
            stringTextBox.Location = new System.Drawing.Point(6, 175);
            stringTextBox.Name = "stringTextBox";
            stringTextBox.Size = new System.Drawing.Size(264, 27);
            stringTextBox.TabIndex = 17;
            stringTextBox.Visible = false;
            stringTextBox.TextChanged += stringTextBox_TextChanged;
            // 
            // stringDataLabel
            // 
            stringDataLabel.AutoSize = true;
            stringDataLabel.Location = new System.Drawing.Point(43, 152);
            stringDataLabel.Name = "stringDataLabel";
            stringDataLabel.Size = new System.Drawing.Size(194, 20);
            stringDataLabel.TabIndex = 16;
            stringDataLabel.Text = "Данные для поиска заказа";
            stringDataLabel.Visible = false;
            // 
            // stringComboBox
            // 
            stringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            stringComboBox.FormattingEnabled = true;
            stringComboBox.Location = new System.Drawing.Point(6, 89);
            stringComboBox.Name = "stringComboBox";
            stringComboBox.Size = new System.Drawing.Size(264, 28);
            stringComboBox.TabIndex = 15;
            stringComboBox.Visible = false;
            // 
            // stringColumnLabel
            // 
            stringColumnLabel.AutoSize = true;
            stringColumnLabel.Location = new System.Drawing.Point(68, 66);
            stringColumnLabel.Name = "stringColumnLabel";
            stringColumnLabel.Size = new System.Drawing.Size(148, 20);
            stringColumnLabel.TabIndex = 14;
            stringColumnLabel.Text = "Столбец для поиска";
            stringColumnLabel.Visible = false;
            // 
            // changeLabel
            // 
            changeLabel.AutoSize = true;
            changeLabel.Location = new System.Drawing.Point(546, 129);
            changeLabel.Name = "changeLabel";
            changeLabel.Size = new System.Drawing.Size(0, 20);
            changeLabel.TabIndex = 13;
            // 
            // completeBookingButton
            // 
            completeBookingButton.Location = new System.Drawing.Point(1086, 66);
            completeBookingButton.Name = "completeBookingButton";
            completeBookingButton.Size = new System.Drawing.Size(175, 53);
            completeBookingButton.TabIndex = 12;
            completeBookingButton.Text = "Выполнить заказ";
            completeBookingButton.UseVisualStyleBackColor = true;
            completeBookingButton.Click += completeBookingButton_Click;
            // 
            // resetSelectRowsButton
            // 
            resetSelectRowsButton.Location = new System.Drawing.Point(816, 152);
            resetSelectRowsButton.Name = "resetSelectRowsButton";
            resetSelectRowsButton.Size = new System.Drawing.Size(207, 53);
            resetSelectRowsButton.TabIndex = 11;
            resetSelectRowsButton.Text = "Отменить выбор строк";
            resetSelectRowsButton.UseVisualStyleBackColor = true;
            resetSelectRowsButton.Click += resetSelectRowsButton_Click;
            // 
            // selectAllRowsButton
            // 
            selectAllRowsButton.Location = new System.Drawing.Point(816, 66);
            selectAllRowsButton.Name = "selectAllRowsButton";
            selectAllRowsButton.Size = new System.Drawing.Size(207, 53);
            selectAllRowsButton.TabIndex = 10;
            selectAllRowsButton.Text = "Выбрать всё";
            selectAllRowsButton.UseVisualStyleBackColor = true;
            selectAllRowsButton.Click += selectAllRowsButton_Click;
            // 
            // changeButton
            // 
            changeButton.Enabled = false;
            changeButton.Location = new System.Drawing.Point(546, 152);
            changeButton.Name = "changeButton";
            changeButton.Size = new System.Drawing.Size(207, 53);
            changeButton.TabIndex = 9;
            changeButton.Text = "Изменить данные о заказе";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(546, 66);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(207, 53);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить заказ";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // resetAddOrChangeButton
            // 
            resetAddOrChangeButton.Location = new System.Drawing.Point(276, 152);
            resetAddOrChangeButton.Name = "resetAddOrChangeButton";
            resetAddOrChangeButton.Size = new System.Drawing.Size(207, 53);
            resetAddOrChangeButton.TabIndex = 7;
            resetAddOrChangeButton.Text = "Отменить добавление/ изменение";
            resetAddOrChangeButton.UseVisualStyleBackColor = true;
            resetAddOrChangeButton.Click += resetAddOrChangeButton_Click;
            // 
            // selectForChangeButton
            // 
            selectForChangeButton.Location = new System.Drawing.Point(276, 66);
            selectForChangeButton.Name = "selectForChangeButton";
            selectForChangeButton.Size = new System.Drawing.Size(207, 53);
            selectForChangeButton.TabIndex = 6;
            selectForChangeButton.Text = "Выбрать для изменения";
            selectForChangeButton.UseVisualStyleBackColor = true;
            selectForChangeButton.Click += selectForChangeButton_Click;
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Location = new System.Drawing.Point(6, 129);
            addLabel.Name = "addLabel";
            addLabel.Size = new System.Drawing.Size(0, 20);
            addLabel.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(6, 152);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(207, 53);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить заказ";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { processingTab, searchTab });
            menuStrip1.Location = new System.Drawing.Point(3, 23);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1261, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // processingTab
            // 
            processingTab.Image = (System.Drawing.Image)resources.GetObject("processingTab.Image");
            processingTab.Name = "processingTab";
            processingTab.Size = new System.Drawing.Size(119, 24);
            processingTab.Text = "Обработка";
            processingTab.Click += processingTab_Click;
            // 
            // searchTab
            // 
            searchTab.Image = (System.Drawing.Image)resources.GetObject("searchTab.Image");
            searchTab.Name = "searchTab";
            searchTab.Size = new System.Drawing.Size(86, 24);
            searchTab.Text = "Поиск";
            searchTab.Click += searchTab_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1291, 613);
            Controls.Add(groupBox1);
            Controls.Add(bookingDataGridView);
            Controls.Add(Tabs);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Tabs;
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Информационная система издательства";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            Tabs.ResumeLayout(false);
            Tabs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookingDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip Tabs;
        private System.Windows.Forms.ToolStripMenuItem employeeTab;
        private System.Windows.Forms.ToolStripMenuItem materialTab;
        private System.Windows.Forms.ToolStripMenuItem printingHouseTab;
        private System.Windows.Forms.ToolStripMenuItem customersTab;
        private System.Windows.Forms.ToolStripMenuItem productTab;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.Button inputDataButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processingTab;
        private System.Windows.Forms.ToolStripMenuItem searchTab;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Button selectForChangeButton;
        private System.Windows.Forms.Button resetAddOrChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button completeBookingButton;
        private System.Windows.Forms.Button resetSelectRowsButton;
        private System.Windows.Forms.Button selectAllRowsButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label stringColumnLabel;
        private System.Windows.Forms.ComboBox stringComboBox;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label stringDataLabel;
        private System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button searchDateButton;
        private System.Windows.Forms.Button searchNumbersButton;
        private System.Windows.Forms.Label toDataLabel;
        private System.Windows.Forms.Label fromDataLabel;
        private System.Windows.Forms.Button resetSearchButton;
    }
}

