namespace WFHW13
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.elipse_rbtn = new System.Windows.Forms.RadioButton();
            this.rect_rbtn = new System.Windows.Forms.RadioButton();
            this.pol_rbtn = new System.Windows.Forms.RadioButton();
            this.text_rbtn = new System.Windows.Forms.RadioButton();
            this.line_rbtn = new System.Windows.Forms.RadioButton();
            this.Edit_button = new System.Windows.Forms.Button();
            this.draw_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 333);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(668, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 1;
            // 
            // elipse_rbtn
            // 
            this.elipse_rbtn.AutoSize = true;
            this.elipse_rbtn.Location = new System.Drawing.Point(13, 366);
            this.elipse_rbtn.Name = "elipse_rbtn";
            this.elipse_rbtn.Size = new System.Drawing.Size(53, 17);
            this.elipse_rbtn.TabIndex = 2;
            this.elipse_rbtn.TabStop = true;
            this.elipse_rbtn.Text = "Elipse";
            this.elipse_rbtn.UseVisualStyleBackColor = true;
            // 
            // rect_rbtn
            // 
            this.rect_rbtn.AutoSize = true;
            this.rect_rbtn.Location = new System.Drawing.Point(104, 366);
            this.rect_rbtn.Name = "rect_rbtn";
            this.rect_rbtn.Size = new System.Drawing.Size(74, 17);
            this.rect_rbtn.TabIndex = 3;
            this.rect_rbtn.TabStop = true;
            this.rect_rbtn.Text = "Rectangle";
            this.rect_rbtn.UseVisualStyleBackColor = true;
            // 
            // pol_rbtn
            // 
            this.pol_rbtn.AutoSize = true;
            this.pol_rbtn.Location = new System.Drawing.Point(195, 366);
            this.pol_rbtn.Name = "pol_rbtn";
            this.pol_rbtn.Size = new System.Drawing.Size(63, 17);
            this.pol_rbtn.TabIndex = 4;
            this.pol_rbtn.TabStop = true;
            this.pol_rbtn.Text = "Polygon";
            this.pol_rbtn.UseVisualStyleBackColor = true;
            // 
            // text_rbtn
            // 
            this.text_rbtn.AutoSize = true;
            this.text_rbtn.Location = new System.Drawing.Point(286, 366);
            this.text_rbtn.Name = "text_rbtn";
            this.text_rbtn.Size = new System.Drawing.Size(46, 17);
            this.text_rbtn.TabIndex = 5;
            this.text_rbtn.TabStop = true;
            this.text_rbtn.Text = "Text";
            this.text_rbtn.UseVisualStyleBackColor = true;
            // 
            // line_rbtn
            // 
            this.line_rbtn.AutoSize = true;
            this.line_rbtn.Location = new System.Drawing.Point(377, 366);
            this.line_rbtn.Name = "line_rbtn";
            this.line_rbtn.Size = new System.Drawing.Size(45, 17);
            this.line_rbtn.TabIndex = 6;
            this.line_rbtn.TabStop = true;
            this.line_rbtn.Text = "Line";
            this.line_rbtn.UseVisualStyleBackColor = true;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(668, 204);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(120, 23);
            this.Edit_button.TabIndex = 7;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(668, 233);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(120, 23);
            this.draw_button.TabIndex = 10;
            this.draw_button.Text = "Draw";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(668, 262);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(120, 23);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.line_rbtn);
            this.Controls.Add(this.text_rbtn);
            this.Controls.Add(this.pol_rbtn);
            this.Controls.Add(this.rect_rbtn);
            this.Controls.Add(this.elipse_rbtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton elipse_rbtn;
        private System.Windows.Forms.RadioButton rect_rbtn;
        private System.Windows.Forms.RadioButton pol_rbtn;
        private System.Windows.Forms.RadioButton text_rbtn;
        private System.Windows.Forms.RadioButton line_rbtn;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.Button delete_button;
    }
}

