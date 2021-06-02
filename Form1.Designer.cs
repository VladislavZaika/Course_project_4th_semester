
namespace GDI
{
    partial class Building
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Graf1 = new System.Windows.Forms.TextBox();
            this.textBox_Graf2 = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1-ый граф";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
           // this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(867, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2-ой граф";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Graf1
            // 
            this.textBox_Graf1.Location = new System.Drawing.Point(138, 591);
            this.textBox_Graf1.Name = "textBox_Graf1";
            this.textBox_Graf1.ReadOnly = true;
            this.textBox_Graf1.Size = new System.Drawing.Size(231, 20);
            this.textBox_Graf1.TabIndex = 3;
            //this.textBox_Graf1.TextChanged += new System.EventHandler(this.textBox_Graf1_TextChanged);
            // 
            // textBox_Graf2
            // 
            this.textBox_Graf2.Location = new System.Drawing.Point(1172, 591);
            this.textBox_Graf2.Name = "textBox_Graf2";
            this.textBox_Graf2.ReadOnly = true;
            this.textBox_Graf2.Size = new System.Drawing.Size(231, 20);
            this.textBox_Graf2.TabIndex = 4;
            //this.textBox_Graf2.TextChanged += new System.EventHandler(this.textBox_Graf2_TextChanged);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(708, 629);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(231, 20);
            this.textBox_result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 661);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_Graf2);
            this.Controls.Add(this.textBox_Graf1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1665, 700);
            this.Name = "Form1";
            this.Text = "Построение графов";
            this.Load += new System.EventHandler(this.Building_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Graf1;
        private System.Windows.Forms.TextBox textBox_Graf2;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

