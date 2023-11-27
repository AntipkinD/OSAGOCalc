namespace OSAGOCalc
{
    partial class OSAGOCalc
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
            this.BT = new System.Windows.Forms.ComboBox();
            this.KT = new System.Windows.Forms.ComboBox();
            this.KBM = new System.Windows.Forms.ComboBox();
            this.KVS = new System.Windows.Forms.ComboBox();
            this.KO = new System.Windows.Forms.ComboBox();
            this.KM = new System.Windows.Forms.ComboBox();
            this.KS = new System.Windows.Forms.ComboBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Figureout_button = new System.Windows.Forms.Button();
            this.Export_button = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT
            // 
            this.BT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT.FormattingEnabled = true;
            this.BT.Items.AddRange(new object[] {
            "324",
            "451",
            "852",
            "1041",
            "1106",
            "1163",
            "1382",
            "1490",
            "1646",
            "1668",
            "1752",
            "2536",
            "3053",
            "3116",
            "3198",
            "4997",
            "5722",
            "6823",
            "7535",
            "8526",
            "9144",
            "14956",
            "15756"});
            this.BT.Location = new System.Drawing.Point(22, 159);
            this.BT.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(466, 31);
            this.BT.TabIndex = 0;
            this.BT.Text = "Базовый тариф (БТ)";
            // 
            // KT
            // 
            this.KT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KT.FormattingEnabled = true;
            this.KT.Items.AddRange(new object[] {
            "1,17",
            "1",
            "0,91",
            "0,83",
            "0,78",
            "0,74",
            "0,68",
            "0,63",
            "0,57",
            "0,52",
            "0,46"});
            this.KT.Location = new System.Drawing.Point(25, 319);
            this.KT.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.KT.Name = "KT";
            this.KT.Size = new System.Drawing.Size(466, 31);
            this.KT.TabIndex = 1;
            this.KT.Text = "Территориальный коэффициент (КТ)";
            // 
            // KBM
            // 
            this.KBM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KBM.FormattingEnabled = true;
            this.KBM.Items.AddRange(new object[] {
            "0,46",
            "0,52",
            "0,57",
            "0,63",
            "0,68",
            "0,74",
            "0,78",
            "0,83",
            "0,91",
            "1",
            "1,17",
            "1,76",
            "2,25",
            "2,94",
            "3,92"});
            this.KBM.Location = new System.Drawing.Point(25, 481);
            this.KBM.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.KBM.Name = "KBM";
            this.KBM.Size = new System.Drawing.Size(466, 31);
            this.KBM.TabIndex = 2;
            this.KBM.Text = "Коэффициент \"бонус-малус\" (КБМ)";
            // 
            // KVS
            // 
            this.KVS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KVS.FormattingEnabled = true;
            this.KVS.Items.AddRange(new object[] {
            "0,83",
            "0,86",
            "0,88",
            "0,9",
            "0,91",
            "0,92",
            "0,93",
            "0,94",
            "0,95",
            "0,96",
            "0,97",
            "1",
            "1,01",
            "1,02",
            "1,04",
            "1,05",
            "1,07",
            "1,08",
            "1,09",
            "1,1",
            "1,13",
            "1,35",
            "1,36",
            "1,39",
            "1,40",
            "1,43",
            "1,44",
            "1,46",
            "1,47",
            "1,48",
            "1,5",
            "1,54",
            "1,56",
            "1,6",
            "1,62",
            "1,65",
            "1,71",
            "1,72",
            "1,84",
            "1,88",
            "1,92",
            "2,27"});
            this.KVS.Location = new System.Drawing.Point(975, 159);
            this.KVS.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.KVS.Name = "KVS";
            this.KVS.Size = new System.Drawing.Size(466, 31);
            this.KVS.TabIndex = 3;
            this.KVS.Text = "Коэффициент возраста и стажа (КВС)";
            // 
            // KO
            // 
            this.KO.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KO.FormattingEnabled = true;
            this.KO.Items.AddRange(new object[] {
            "1",
            "1,97",
            "2,32"});
            this.KO.Location = new System.Drawing.Point(499, 159);
            this.KO.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.KO.Name = "KO";
            this.KO.Size = new System.Drawing.Size(466, 31);
            this.KO.TabIndex = 4;
            this.KO.Text = "Коэффициент ограничения (КО)";
            // 
            // KM
            // 
            this.KM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KM.FormattingEnabled = true;
            this.KM.Items.AddRange(new object[] {
            "0,6",
            "1",
            "1,1",
            "1,2",
            "1,4",
            "1,6"});
            this.KM.Location = new System.Drawing.Point(975, 319);
            this.KM.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.KM.Name = "KM";
            this.KM.Size = new System.Drawing.Size(466, 31);
            this.KM.TabIndex = 5;
            this.KM.Text = "Коэффициент мощности двигателя (КМ)";
            // 
            // KS
            // 
            this.KS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KS.FormattingEnabled = true;
            this.KS.Items.AddRange(new object[] {
            "0,5",
            "0,6",
            "0,65",
            "0,7",
            "0,8",
            "0,9",
            "0,95",
            "1"});
            this.KS.Location = new System.Drawing.Point(975, 481);
            this.KS.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.KS.Name = "KS";
            this.KS.Size = new System.Drawing.Size(466, 31);
            this.KS.TabIndex = 6;
            this.KS.Text = "Коэффициент сезонности (КС)";
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(499, 547);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(469, 80);
            this.Clear_button.TabIndex = 9;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Figureout_button
            // 
            this.Figureout_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Figureout_button.Location = new System.Drawing.Point(22, 637);
            this.Figureout_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Figureout_button.Name = "Figureout_button";
            this.Figureout_button.Size = new System.Drawing.Size(469, 80);
            this.Figureout_button.TabIndex = 10;
            this.Figureout_button.Text = "Рассчитать стоимость";
            this.Figureout_button.UseVisualStyleBackColor = true;
            this.Figureout_button.Click += new System.EventHandler(this.Figureout_button_Click);
            // 
            // Export_button
            // 
            this.Export_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export_button.Location = new System.Drawing.Point(975, 637);
            this.Export_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(469, 80);
            this.Export_button.TabIndex = 11;
            this.Export_button.Text = "Вывести в файл";
            this.Export_button.UseVisualStyleBackColor = true;
            this.Export_button.Click += new System.EventHandler(this.Export_button_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(502, 372);
            this.result.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(459, 31);
            this.result.TabIndex = 12;
            this.result.Text = "Результат";
            // 
            // OSAGOCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 796);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Export_button);
            this.Controls.Add(this.Figureout_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.KS);
            this.Controls.Add(this.KM);
            this.Controls.Add(this.KO);
            this.Controls.Add(this.KVS);
            this.Controls.Add(this.KBM);
            this.Controls.Add(this.KT);
            this.Controls.Add(this.BT);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "OSAGOCalc";
            this.Text = "Калькулятор ОСАГО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BT;
        private System.Windows.Forms.ComboBox KT;
        private System.Windows.Forms.ComboBox KBM;
        private System.Windows.Forms.ComboBox KVS;
        private System.Windows.Forms.ComboBox KO;
        private System.Windows.Forms.ComboBox KM;
        private System.Windows.Forms.ComboBox KS;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Figureout_button;
        private System.Windows.Forms.Button Export_button;
        private System.Windows.Forms.TextBox result;
    }
}

