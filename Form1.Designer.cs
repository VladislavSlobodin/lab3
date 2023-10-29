namespace lab3_2
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
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.RemoveBookButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматСохраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинарныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBookTextBox = new System.Windows.Forms.TextBox();
            this.ButtonPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.SearchPanel);
            this.ButtonPanel.Controls.Add(this.SearchButton);
            this.ButtonPanel.Controls.Add(this.ViewButton);
            this.ButtonPanel.Controls.Add(this.DeletePanel);
            this.ButtonPanel.Controls.Add(this.DeleteButton);
            this.ButtonPanel.Controls.Add(this.AddPanel);
            this.ButtonPanel.Controls.Add(this.AddButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 24);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(200, 458);
            this.ButtonPanel.TabIndex = 0;
            // 
            // ViewButton
            // 
            this.ViewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(0, 302);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(200, 60);
            this.ViewButton.TabIndex = 8;
            this.ViewButton.Text = "Просмотреть";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DeletePanel
            // 
            this.DeletePanel.Controls.Add(this.RemoveBookButton);
            this.DeletePanel.Controls.Add(this.label3);
            this.DeletePanel.Controls.Add(this.BookComboBox);
            this.DeletePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeletePanel.Location = new System.Drawing.Point(0, 238);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(200, 64);
            this.DeletePanel.TabIndex = 7;
            this.DeletePanel.Visible = false;
            // 
            // RemoveBookButton
            // 
            this.RemoveBookButton.Location = new System.Drawing.Point(35, 33);
            this.RemoveBookButton.Name = "RemoveBookButton";
            this.RemoveBookButton.Size = new System.Drawing.Size(130, 23);
            this.RemoveBookButton.TabIndex = 5;
            this.RemoveBookButton.Text = "Удалить книгу";
            this.RemoveBookButton.UseVisualStyleBackColor = true;
            this.RemoveBookButton.Click += new System.EventHandler(this.RemoveBookButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название";
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(66, 6);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(128, 21);
            this.BookComboBox.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(0, 178);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 60);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.DescriptionTextBox);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.AddBookButton);
            this.AddPanel.Controls.Add(this.AuthorTextBox);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Controls.Add(this.NameTextBox);
            this.AddPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddPanel.Location = new System.Drawing.Point(0, 60);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(200, 118);
            this.AddPanel.TabIndex = 5;
            this.AddPanel.Visible = false;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(66, 58);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(128, 20);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Описание";
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(35, 84);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(130, 23);
            this.AddBookButton.TabIndex = 4;
            this.AddBookButton.Text = "Добавить книгу";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(66, 32);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(128, 20);
            this.AuthorTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(66, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(128, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(200, 60);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.dataGridView1);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(200, 24);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(685, 458);
            this.DataPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 458);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.форматСохраненияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // форматСохраненияToolStripMenuItem
            // 
            this.форматСохраненияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бинарныйToolStripMenuItem,
            this.soapToolStripMenuItem});
            this.форматСохраненияToolStripMenuItem.Name = "форматСохраненияToolStripMenuItem";
            this.форматСохраненияToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.форматСохраненияToolStripMenuItem.Text = "Формат сохранения";
            // 
            // бинарныйToolStripMenuItem
            // 
            this.бинарныйToolStripMenuItem.Name = "бинарныйToolStripMenuItem";
            this.бинарныйToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.бинарныйToolStripMenuItem.Text = "Бинарный";
            this.бинарныйToolStripMenuItem.Click += new System.EventHandler(this.бинарныйToolStripMenuItem_Click);
            // 
            // soapToolStripMenuItem
            // 
            this.soapToolStripMenuItem.Name = "soapToolStripMenuItem";
            this.soapToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.soapToolStripMenuItem.Text = "Soap";
            this.soapToolStripMenuItem.Click += new System.EventHandler(this.soapToolStripMenuItem_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(0, 362);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(200, 60);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchBookTextBox);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 422);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(200, 33);
            this.SearchPanel.TabIndex = 10;
            this.SearchPanel.Visible = false;
            // 
            // SearchBookTextBox
            // 
            this.SearchBookTextBox.Location = new System.Drawing.Point(6, 6);
            this.SearchBookTextBox.Name = "SearchBookTextBox";
            this.SearchBookTextBox.Size = new System.Drawing.Size(188, 20);
            this.SearchBookTextBox.TabIndex = 0;
            this.SearchBookTextBox.TextChanged += new System.EventHandler(this.SearchBookTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 482);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Домашняя библиотека";
            this.ButtonPanel.ResumeLayout(false);
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматСохраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soapToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RemoveBookButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchBookTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}

