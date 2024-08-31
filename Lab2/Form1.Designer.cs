
namespace Lab2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bChangeBack = new System.Windows.Forms.Button();
            this.bRandomFun = new System.Windows.Forms.Button();
            this.bChooseColor = new System.Windows.Forms.Button();
            this.lFunColor = new System.Windows.Forms.Label();
            this.PanelF = new System.Windows.Forms.Panel();
            this.lScale = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.PanelF.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.bSave);
            this.groupBox1.Controls.Add(this.bChangeBack);
            this.groupBox1.Controls.Add(this.bRandomFun);
            this.groupBox1.Controls.Add(this.bChooseColor);
            this.groupBox1.Controls.Add(this.lFunColor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(692, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(13, 324);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(204, 35);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bChangeBack
            // 
            this.bChangeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bChangeBack.Location = new System.Drawing.Point(15, 276);
            this.bChangeBack.Name = "bChangeBack";
            this.bChangeBack.Size = new System.Drawing.Size(204, 35);
            this.bChangeBack.TabIndex = 7;
            this.bChangeBack.Text = "Настроить фон";
            this.bChangeBack.UseVisualStyleBackColor = true;
            this.bChangeBack.Click += new System.EventHandler(this.bChangeBack_Click);
            // 
            // bRandomFun
            // 
            this.bRandomFun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bRandomFun.Location = new System.Drawing.Point(13, 228);
            this.bRandomFun.Name = "bRandomFun";
            this.bRandomFun.Size = new System.Drawing.Size(204, 35);
            this.bRandomFun.TabIndex = 4;
            this.bRandomFun.Text = "Случайная функция";
            this.bRandomFun.UseVisualStyleBackColor = true;
            this.bRandomFun.Click += new System.EventHandler(this.bRandomFun_Click);
            // 
            // bChooseColor
            // 
            this.bChooseColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bChooseColor.Location = new System.Drawing.Point(13, 180);
            this.bChooseColor.Name = "bChooseColor";
            this.bChooseColor.Size = new System.Drawing.Size(177, 35);
            this.bChooseColor.TabIndex = 3;
            this.bChooseColor.Text = "Выбрать цвет графика";
            this.bChooseColor.UseVisualStyleBackColor = true;
            this.bChooseColor.Click += new System.EventHandler(this.bChooseColor_Click);
            // 
            // lFunColor
            // 
            this.lFunColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lFunColor.BackColor = System.Drawing.Color.Black;
            this.lFunColor.ForeColor = System.Drawing.Color.Black;
            this.lFunColor.Location = new System.Drawing.Point(197, 188);
            this.lFunColor.Name = "lFunColor";
            this.lFunColor.Size = new System.Drawing.Size(20, 20);
            this.lFunColor.TabIndex = 0;
            this.lFunColor.Text = "   ";
            // 
            // PanelF
            // 
            this.PanelF.BackColor = System.Drawing.Color.White;
            this.PanelF.Controls.Add(this.lScale);
            this.PanelF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelF.Location = new System.Drawing.Point(0, 0);
            this.PanelF.Name = "PanelF";
            this.PanelF.Size = new System.Drawing.Size(692, 583);
            this.PanelF.TabIndex = 1;
            this.PanelF.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelF_Paint);
            this.PanelF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelF_MouseDown);
            this.PanelF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelF_MouseMove);
            this.PanelF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelF_MouseUp);
            this.PanelF.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PanelF_MouseWheel);
            // 
            // lScale
            // 
            this.lScale.AutoSize = true;
            this.lScale.BackColor = System.Drawing.Color.Transparent;
            this.lScale.Location = new System.Drawing.Point(635, 0);
            this.lScale.Name = "lScale";
            this.lScale.Size = new System.Drawing.Size(0, 17);
            this.lScale.TabIndex = 0;
            this.lScale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 583);
            this.Controls.Add(this.PanelF);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.PanelF.ResumeLayout(false);
            this.PanelF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelF;
        private System.Windows.Forms.Label lFunColor;
        private System.Windows.Forms.Button bChooseColor;
        private System.Windows.Forms.Button bRandomFun;
        private System.Windows.Forms.Button bChangeBack;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lScale;
    }
}

