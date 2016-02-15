namespace ModellingSystem
{
    partial class mainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Количество выполненных заявок");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Суммарное время обслуживания");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Среднее время обработки заявки");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Коэффициент загрузки системы");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Число вытолкнутых заявок");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Количество запросов на выделение каналов");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Общая сумма величин запросов на выделение каналов");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Средняя величина запроса");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Среднее число занятых каналов");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Количество заявок поставленных в очередь");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Количество всех заявок прошедших через очередь");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Количество заявок с нулевым ожиданием");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Суммарное время ожидания");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Среднее время ожидания");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Среднеквадратичное отклонение время ожидания");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Средняя длина очереди");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Максимальная длина очереди");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Количество заявок получивших отказ");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Общее число выполненных запросов");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Суммарное время обслуживания");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Среднее время занятости");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Процент использования системы");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Количество заявок поставленных в очередь");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Количество заявок прошедших через очередь");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Количество заявок с нулевым ожиданием");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Суммарное время ожидания");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("Среднее время ожидания");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("Количество отказов");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lvDistribution = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateDistribution = new System.Windows.Forms.Button();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbModa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.cmbDistributionType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvQueue = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbQueueSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCreateQueue = new System.Windows.Forms.Button();
            this.cmbQueueType = new System.Windows.Forms.ComboBox();
            this.tbQueueName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvDevice = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbDeviceChannelCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDeviceQueueName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateDevice = new System.Windows.Forms.Button();
            this.cmbDeviceDistribution = new System.Windows.Forms.ComboBox();
            this.tbDeviceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbClosedSystem = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbRequestNumber = new System.Windows.Forms.TextBox();
            this.tbWorkTime = new System.Windows.Forms.TextBox();
            this.cmbGeneratorDistribution = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lvDeviceStatistic = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvQueueStatistic = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCommonStatistic = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 629);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.splitContainer3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 309);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Распределения";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 16);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lvDistribution);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnCreateDistribution);
            this.splitContainer3.Panel2.Controls.Add(this.tbD);
            this.splitContainer3.Panel2.Controls.Add(this.tbM);
            this.splitContainer3.Panel2.Controls.Add(this.label15);
            this.splitContainer3.Panel2.Controls.Add(this.label14);
            this.splitContainer3.Panel2.Controls.Add(this.tbModa);
            this.splitContainer3.Panel2.Controls.Add(this.label13);
            this.splitContainer3.Panel2.Controls.Add(this.label10);
            this.splitContainer3.Panel2.Controls.Add(this.tbB);
            this.splitContainer3.Panel2.Controls.Add(this.label11);
            this.splitContainer3.Panel2.Controls.Add(this.tbA);
            this.splitContainer3.Panel2.Controls.Add(this.cmbDistributionType);
            this.splitContainer3.Panel2.Controls.Add(this.label12);
            this.splitContainer3.Size = new System.Drawing.Size(423, 290);
            this.splitContainer3.SplitterDistance = 261;
            this.splitContainer3.TabIndex = 1;
            // 
            // lvDistribution
            // 
            this.lvDistribution.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDistribution.FullRowSelect = true;
            this.lvDistribution.GridLines = true;
            this.lvDistribution.Location = new System.Drawing.Point(0, 0);
            this.lvDistribution.Name = "lvDistribution";
            this.lvDistribution.Size = new System.Drawing.Size(261, 290);
            this.lvDistribution.TabIndex = 0;
            this.lvDistribution.UseCompatibleStateImageBehavior = false;
            this.lvDistribution.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "№";
            this.columnHeader6.Width = 30;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Тип";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "П1";
            this.columnHeader8.Width = 40;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "П2";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "П3";
            this.columnHeader10.Width = 40;
            // 
            // btnCreateDistribution
            // 
            this.btnCreateDistribution.Location = new System.Drawing.Point(8, 221);
            this.btnCreateDistribution.Name = "btnCreateDistribution";
            this.btnCreateDistribution.Size = new System.Drawing.Size(140, 23);
            this.btnCreateDistribution.TabIndex = 23;
            this.btnCreateDistribution.Text = "Создать распределение";
            this.btnCreateDistribution.UseVisualStyleBackColor = true;
            this.btnCreateDistribution.Click += new System.EventHandler(this.btnCreateDistribution_Click);
            // 
            // tbD
            // 
            this.tbD.Enabled = false;
            this.tbD.Location = new System.Drawing.Point(8, 185);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(140, 20);
            this.tbD.TabIndex = 22;
            this.tbD.Text = "0";
            // 
            // tbM
            // 
            this.tbM.Enabled = false;
            this.tbM.Location = new System.Drawing.Point(8, 146);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(140, 20);
            this.tbM.TabIndex = 21;
            this.tbM.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Мат. ожидание:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Мода:";
            // 
            // tbModa
            // 
            this.tbModa.Enabled = false;
            this.tbModa.Location = new System.Drawing.Point(8, 107);
            this.tbModa.Name = "tbModa";
            this.tbModa.Size = new System.Drawing.Size(140, 20);
            this.tbModa.TabIndex = 18;
            this.tbModa.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Дисперсия:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "<->";
            // 
            // tbB
            // 
            this.tbB.Enabled = false;
            this.tbB.Location = new System.Drawing.Point(92, 68);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(56, 20);
            this.tbB.TabIndex = 15;
            this.tbB.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Интервал:";
            // 
            // tbA
            // 
            this.tbA.Enabled = false;
            this.tbA.Location = new System.Drawing.Point(8, 68);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(56, 20);
            this.tbA.TabIndex = 13;
            this.tbA.Text = "0";
            // 
            // cmbDistributionType
            // 
            this.cmbDistributionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistributionType.FormattingEnabled = true;
            this.cmbDistributionType.Items.AddRange(new object[] {
            "Равномерное",
            "Нормальное",
            "Экспоненциальное",
            "Треугольное"});
            this.cmbDistributionType.Location = new System.Drawing.Point(8, 28);
            this.cmbDistributionType.Name = "cmbDistributionType";
            this.cmbDistributionType.Size = new System.Drawing.Size(140, 21);
            this.cmbDistributionType.TabIndex = 3;
            this.cmbDistributionType.SelectedIndexChanged += new System.EventHandler(this.cmbDistributionType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Тип распределения:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 308);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Очереди";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvQueue);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbQueueSize);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreateQueue);
            this.splitContainer1.Panel2.Controls.Add(this.cmbQueueType);
            this.splitContainer1.Panel2.Controls.Add(this.tbQueueName);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(423, 289);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 1;
            // 
            // lvQueue
            // 
            this.lvQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader11});
            this.lvQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvQueue.FullRowSelect = true;
            this.lvQueue.GridLines = true;
            this.lvQueue.Location = new System.Drawing.Point(0, 0);
            this.lvQueue.Name = "lvQueue";
            this.lvQueue.Size = new System.Drawing.Size(261, 289);
            this.lvQueue.TabIndex = 0;
            this.lvQueue.UseCompatibleStateImageBehavior = false;
            this.lvQueue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Имя";
            this.columnHeader0.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Тип";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Размер";
            // 
            // tbQueueSize
            // 
            this.tbQueueSize.Location = new System.Drawing.Point(8, 108);
            this.tbQueueSize.Name = "tbQueueSize";
            this.tbQueueSize.Size = new System.Drawing.Size(137, 20);
            this.tbQueueSize.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Размер очереди:";
            // 
            // btnCreateQueue
            // 
            this.btnCreateQueue.Location = new System.Drawing.Point(8, 144);
            this.btnCreateQueue.Name = "btnCreateQueue";
            this.btnCreateQueue.Size = new System.Drawing.Size(137, 23);
            this.btnCreateQueue.TabIndex = 4;
            this.btnCreateQueue.Text = "Создать очередь";
            this.btnCreateQueue.UseVisualStyleBackColor = true;
            this.btnCreateQueue.Click += new System.EventHandler(this.btnCreateQueue_Click);
            // 
            // cmbQueueType
            // 
            this.cmbQueueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueueType.FormattingEnabled = true;
            this.cmbQueueType.Items.AddRange(new object[] {
            "LIFO",
            "FIFO",
            "PRIORITET"});
            this.cmbQueueType.Location = new System.Drawing.Point(8, 67);
            this.cmbQueueType.Name = "cmbQueueType";
            this.cmbQueueType.Size = new System.Drawing.Size(137, 21);
            this.cmbQueueType.TabIndex = 3;
            // 
            // tbQueueName
            // 
            this.tbQueueName.Location = new System.Drawing.Point(8, 28);
            this.tbQueueName.Name = "tbQueueName";
            this.tbQueueName.Size = new System.Drawing.Size(137, 20);
            this.tbQueueName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(438, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 308);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Устройства";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvDevice);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbDeviceChannelCount);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.cmbDeviceQueueName);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.btnCreateDevice);
            this.splitContainer2.Panel2.Controls.Add(this.cmbDeviceDistribution);
            this.splitContainer2.Panel2.Controls.Add(this.tbDeviceName);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Size = new System.Drawing.Size(423, 289);
            this.splitContainer2.SplitterDistance = 261;
            this.splitContainer2.TabIndex = 1;
            // 
            // lvDevice
            // 
            this.lvDevice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDevice.FullRowSelect = true;
            this.lvDevice.GridLines = true;
            this.lvDevice.Location = new System.Drawing.Point(0, 0);
            this.lvDevice.Name = "lvDevice";
            this.lvDevice.Size = new System.Drawing.Size(261, 289);
            this.lvDevice.TabIndex = 0;
            this.lvDevice.UseCompatibleStateImageBehavior = false;
            this.lvDevice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Очередь";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Распределение";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Каналы";
            this.columnHeader5.Width = 55;
            // 
            // tbDeviceChannelCount
            // 
            this.tbDeviceChannelCount.Location = new System.Drawing.Point(8, 147);
            this.tbDeviceChannelCount.Name = "tbDeviceChannelCount";
            this.tbDeviceChannelCount.Size = new System.Drawing.Size(140, 20);
            this.tbDeviceChannelCount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Количество каналов:";
            // 
            // cmbDeviceQueueName
            // 
            this.cmbDeviceQueueName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceQueueName.FormattingEnabled = true;
            this.cmbDeviceQueueName.Location = new System.Drawing.Point(8, 107);
            this.cmbDeviceQueueName.Name = "cmbDeviceQueueName";
            this.cmbDeviceQueueName.Size = new System.Drawing.Size(140, 21);
            this.cmbDeviceQueueName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Имя очереди:";
            // 
            // btnCreateDevice
            // 
            this.btnCreateDevice.Location = new System.Drawing.Point(8, 182);
            this.btnCreateDevice.Name = "btnCreateDevice";
            this.btnCreateDevice.Size = new System.Drawing.Size(140, 23);
            this.btnCreateDevice.TabIndex = 4;
            this.btnCreateDevice.Text = "Создать устройство";
            this.btnCreateDevice.UseVisualStyleBackColor = true;
            this.btnCreateDevice.Click += new System.EventHandler(this.btnCreateDevice_Click);
            // 
            // cmbDeviceDistribution
            // 
            this.cmbDeviceDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceDistribution.FormattingEnabled = true;
            this.cmbDeviceDistribution.Location = new System.Drawing.Point(8, 67);
            this.cmbDeviceDistribution.Name = "cmbDeviceDistribution";
            this.cmbDeviceDistribution.Size = new System.Drawing.Size(140, 21);
            this.cmbDeviceDistribution.TabIndex = 3;
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Location = new System.Drawing.Point(8, 28);
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(140, 20);
            this.tbDeviceName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Распределение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Имя:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbClosedSystem);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.tbRequestNumber);
            this.groupBox4.Controls.Add(this.tbWorkTime);
            this.groupBox4.Controls.Add(this.cmbGeneratorDistribution);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(438, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(429, 309);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Начальные условия";
            // 
            // chbClosedSystem
            // 
            this.chbClosedSystem.AutoSize = true;
            this.chbClosedSystem.Location = new System.Drawing.Point(276, 107);
            this.chbClosedSystem.Name = "chbClosedSystem";
            this.chbClosedSystem.Size = new System.Drawing.Size(127, 17);
            this.chbClosedSystem.TabIndex = 9;
            this.chbClosedSystem.Text = "Замкнутая система";
            this.chbClosedSystem.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(276, 280);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Запустить";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbRequestNumber
            // 
            this.tbRequestNumber.Location = new System.Drawing.Point(276, 78);
            this.tbRequestNumber.Name = "tbRequestNumber";
            this.tbRequestNumber.Size = new System.Drawing.Size(140, 20);
            this.tbRequestNumber.TabIndex = 6;
            this.tbRequestNumber.Text = "100";
            // 
            // tbWorkTime
            // 
            this.tbWorkTime.Location = new System.Drawing.Point(276, 25);
            this.tbWorkTime.Name = "tbWorkTime";
            this.tbWorkTime.Size = new System.Drawing.Size(140, 20);
            this.tbWorkTime.TabIndex = 5;
            this.tbWorkTime.Text = "1000";
            // 
            // cmbGeneratorDistribution
            // 
            this.cmbGeneratorDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneratorDistribution.FormattingEnabled = true;
            this.cmbGeneratorDistribution.Location = new System.Drawing.Point(276, 51);
            this.cmbGeneratorDistribution.Name = "cmbGeneratorDistribution";
            this.cmbGeneratorDistribution.Size = new System.Drawing.Size(140, 21);
            this.cmbGeneratorDistribution.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Количество заявок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Распределение появления:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Время работы:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журнал";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 20;
            this.lbLog.Location = new System.Drawing.Point(3, 3);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(870, 629);
            this.lbLog.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Статистика";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(870, 629);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.lvDeviceStatistic);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(862, 603);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Устройства";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.lvQueueStatistic);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(862, 603);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Очереди";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.lvCommonStatistic);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(862, 603);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Общая";
            // 
            // lvDeviceStatistic
            // 
            this.lvDeviceStatistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.lvDeviceStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvDeviceStatistic.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lvDeviceStatistic.Location = new System.Drawing.Point(3, 3);
            this.lvDeviceStatistic.Name = "lvDeviceStatistic";
            this.lvDeviceStatistic.Size = new System.Drawing.Size(856, 300);
            this.lvDeviceStatistic.TabIndex = 0;
            this.lvDeviceStatistic.UseCompatibleStateImageBehavior = false;
            this.lvDeviceStatistic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Параметр";
            this.columnHeader12.Width = 300;
            // 
            // lvQueueStatistic
            // 
            this.lvQueueStatistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13});
            this.lvQueueStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvQueueStatistic.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.lvQueueStatistic.Location = new System.Drawing.Point(3, 3);
            this.lvQueueStatistic.Name = "lvQueueStatistic";
            this.lvQueueStatistic.Size = new System.Drawing.Size(856, 300);
            this.lvQueueStatistic.TabIndex = 1;
            this.lvQueueStatistic.UseCompatibleStateImageBehavior = false;
            this.lvQueueStatistic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Параметр";
            this.columnHeader13.Width = 300;
            // 
            // lvCommonStatistic
            // 
            this.lvCommonStatistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15});
            this.lvCommonStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvCommonStatistic.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28});
            this.lvCommonStatistic.Location = new System.Drawing.Point(3, 3);
            this.lvCommonStatistic.Name = "lvCommonStatistic";
            this.lvCommonStatistic.Size = new System.Drawing.Size(856, 300);
            this.lvCommonStatistic.TabIndex = 2;
            this.lvCommonStatistic.UseCompatibleStateImageBehavior = false;
            this.lvCommonStatistic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Параметр";
            this.columnHeader14.Width = 300;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Значение";
            this.columnHeader15.Width = 300;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система моделирования";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvQueue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbQueueType;
        private System.Windows.Forms.TextBox tbQueueName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateQueue;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvDevice;
        private System.Windows.Forms.Button btnCreateDevice;
        private System.Windows.Forms.ComboBox cmbDeviceDistribution;
        private System.Windows.Forms.TextBox tbDeviceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDeviceChannelCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDeviceQueueName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGeneratorDistribution;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListView lvDistribution;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cmbDistributionType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbWorkTime;
        private System.Windows.Forms.TextBox tbRequestNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbModa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCreateDistribution;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TextBox tbQueueSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.CheckBox chbClosedSystem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListView lvDeviceStatistic;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView lvQueueStatistic;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView lvCommonStatistic;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}

