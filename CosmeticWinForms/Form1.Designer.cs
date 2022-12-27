namespace CosmeticWinForms
{
    partial class Form1
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
            this.TextName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBrand = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextPrice = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextAmount = new System.Windows.Forms.RichTextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.SelectItem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(490, 28);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(154, 22);
            this.TextName.TabIndex = 2;
            this.TextName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Брэнд";
            // 
            // TextBrand
            // 
            this.TextBrand.Location = new System.Drawing.Point(490, 85);
            this.TextBrand.Name = "TextBrand";
            this.TextBrand.Size = new System.Drawing.Size(154, 22);
            this.TextBrand.TabIndex = 4;
            this.TextBrand.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена";
            // 
            // TextPrice
            // 
            this.TextPrice.Location = new System.Drawing.Point(490, 142);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(154, 22);
            this.TextPrice.TabIndex = 6;
            this.TextPrice.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество";
            // 
            // TextAmount
            // 
            this.TextAmount.Location = new System.Drawing.Point(490, 202);
            this.TextAmount.Name = "TextAmount";
            this.TextAmount.Size = new System.Drawing.Size(154, 22);
            this.TextAmount.TabIndex = 8;
            this.TextAmount.Text = "";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(490, 253);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(154, 23);
            this.InsertButton.TabIndex = 10;
            this.InsertButton.Text = "INSERT FROM";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(12, 324);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(93, 23);
            this.SelectAllButton.TabIndex = 12;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // SelectItem
            // 
            this.SelectItem.Location = new System.Drawing.Point(111, 324);
            this.SelectItem.Name = "SelectItem";
            this.SelectItem.Size = new System.Drawing.Size(93, 23);
            this.SelectItem.TabIndex = 13;
            this.SelectItem.Text = "Select Помада";
            this.SelectItem.UseVisualStyleBackColor = true;
            this.SelectItem.Click += new System.EventHandler(this.SelectItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 264);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 365);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectItem);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextName);
            this.MaximumSize = new System.Drawing.Size(691, 404);
            this.MinimumSize = new System.Drawing.Size(691, 404);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox TextName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TextBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TextPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TextAmount;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button SelectItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

