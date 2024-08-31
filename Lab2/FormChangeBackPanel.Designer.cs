
namespace Lab2
{
    partial class FormChangeBackPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.CheckNet = new System.Windows.Forms.CheckBox();
            this.SizeNet = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckPeriodNet = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SizePeriodNet = new System.Windows.Forms.TrackBar();
            this.NumPeriodNet = new System.Windows.Forms.NumericUpDown();
            this.bChooseColorNet = new System.Windows.Forms.Button();
            this.lNetColor = new System.Windows.Forms.Label();
            this.bСhooseBackColor = new System.Windows.Forms.Button();
            this.lBackColor = new System.Windows.Forms.Label();
            this.CheckGradient = new System.Windows.Forms.CheckBox();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizePeriodNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPeriodNet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(159, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройка фона ";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // CheckNet
            // 
            this.CheckNet.AutoSize = true;
            this.CheckNet.Location = new System.Drawing.Point(12, 114);
            this.CheckNet.Name = "CheckNet";
            this.CheckNet.Size = new System.Drawing.Size(69, 21);
            this.CheckNet.TabIndex = 1;
            this.CheckNet.Text = "Сетка";
            this.CheckNet.UseVisualStyleBackColor = true;
            this.CheckNet.CheckedChanged += new System.EventHandler(this.CheckNet_CheckedChanged);
            // 
            // SizeNet
            // 
            this.SizeNet.Location = new System.Drawing.Point(376, 95);
            this.SizeNet.Minimum = 1;
            this.SizeNet.Name = "SizeNet";
            this.SizeNet.Size = new System.Drawing.Size(149, 56);
            this.SizeNet.TabIndex = 2;
            this.SizeNet.Value = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(236, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Толщина линий сетки";
            // 
            // CheckPeriodNet
            // 
            this.CheckPeriodNet.AutoSize = true;
            this.CheckPeriodNet.Location = new System.Drawing.Point(12, 170);
            this.CheckPeriodNet.Name = "CheckPeriodNet";
            this.CheckPeriodNet.Size = new System.Drawing.Size(187, 21);
            this.CheckPeriodNet.TabIndex = 4;
            this.CheckPeriodNet.Text = "Вспомогательная сетка";
            this.CheckPeriodNet.UseVisualStyleBackColor = true;
            this.CheckPeriodNet.CheckedChanged += new System.EventHandler(this.CheckPeriodNet_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Период вспомогательных линий";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(236, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "Толщина вспомогательгых линий сетки";
            // 
            // SizePeriodNet
            // 
            this.SizePeriodNet.Location = new System.Drawing.Point(376, 212);
            this.SizePeriodNet.Minimum = 1;
            this.SizePeriodNet.Name = "SizePeriodNet";
            this.SizePeriodNet.Size = new System.Drawing.Size(149, 56);
            this.SizePeriodNet.TabIndex = 7;
            this.SizePeriodNet.Value = 1;
            // 
            // NumPeriodNet
            // 
            this.NumPeriodNet.Location = new System.Drawing.Point(462, 169);
            this.NumPeriodNet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPeriodNet.Name = "NumPeriodNet";
            this.NumPeriodNet.Size = new System.Drawing.Size(63, 22);
            this.NumPeriodNet.TabIndex = 9;
            this.NumPeriodNet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bChooseColorNet
            // 
            this.bChooseColorNet.Location = new System.Drawing.Point(12, 290);
            this.bChooseColorNet.Name = "bChooseColorNet";
            this.bChooseColorNet.Size = new System.Drawing.Size(187, 23);
            this.bChooseColorNet.TabIndex = 10;
            this.bChooseColorNet.Text = "Поменять цвет сетки";
            this.bChooseColorNet.UseVisualStyleBackColor = true;
            this.bChooseColorNet.Click += new System.EventHandler(this.bChooseColorNet_Click);
            // 
            // lNetColor
            // 
            this.lNetColor.BackColor = System.Drawing.Color.Black;
            this.lNetColor.Location = new System.Drawing.Point(236, 290);
            this.lNetColor.Name = "lNetColor";
            this.lNetColor.Size = new System.Drawing.Size(57, 23);
            this.lNetColor.TabIndex = 11;
            // 
            // bСhooseBackColor
            // 
            this.bСhooseBackColor.Location = new System.Drawing.Point(12, 334);
            this.bСhooseBackColor.Name = "bСhooseBackColor";
            this.bСhooseBackColor.Size = new System.Drawing.Size(187, 23);
            this.bСhooseBackColor.TabIndex = 12;
            this.bСhooseBackColor.Text = "Выбрать цвет фона";
            this.bСhooseBackColor.UseVisualStyleBackColor = true;
            this.bСhooseBackColor.Click += new System.EventHandler(this.bСhooseBackColor_Click);
            // 
            // lBackColor
            // 
            this.lBackColor.BackColor = System.Drawing.Color.White;
            this.lBackColor.Location = new System.Drawing.Point(236, 334);
            this.lBackColor.Name = "lBackColor";
            this.lBackColor.Size = new System.Drawing.Size(57, 23);
            this.lBackColor.TabIndex = 13;
            // 
            // CheckGradient
            // 
            this.CheckGradient.AutoSize = true;
            this.CheckGradient.Location = new System.Drawing.Point(12, 380);
            this.CheckGradient.Name = "CheckGradient";
            this.CheckGradient.Size = new System.Drawing.Size(132, 21);
            this.CheckGradient.TabIndex = 14;
            this.CheckGradient.Text = "Градиент фона";
            this.CheckGradient.UseVisualStyleBackColor = true;
            this.CheckGradient.CheckedChanged += new System.EventHandler(this.CheckGradient_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(239, 379);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(129, 21);
            this.radioButtonBlue.TabIndex = 15;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Синия палитра";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(376, 379);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(144, 21);
            this.radioButtonRed.TabIndex = 16;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Красная палитра";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(311, 430);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(88, 32);
            this.bOK.TabIndex = 17;
            this.bOK.Text = "Принять";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancle
            // 
            this.bCancle.Location = new System.Drawing.Point(430, 430);
            this.bCancle.Name = "bCancle";
            this.bCancle.Size = new System.Drawing.Size(90, 32);
            this.bCancle.TabIndex = 18;
            this.bCancle.Text = "Отменить";
            this.bCancle.UseVisualStyleBackColor = true;
            this.bCancle.Click += new System.EventHandler(this.bCancle_Click);
            // 
            // FormChangeBackPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 474);
            this.Controls.Add(this.bCancle);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.radioButtonBlue);
            this.Controls.Add(this.CheckGradient);
            this.Controls.Add(this.lBackColor);
            this.Controls.Add(this.bСhooseBackColor);
            this.Controls.Add(this.lNetColor);
            this.Controls.Add(this.bChooseColorNet);
            this.Controls.Add(this.NumPeriodNet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SizePeriodNet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckPeriodNet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeNet);
            this.Controls.Add(this.CheckNet);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeBackPanel";
            this.Text = "FormChangeBackPanel";
            ((System.ComponentModel.ISupportInitialize)(this.SizeNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizePeriodNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPeriodNet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckNet;
        private System.Windows.Forms.TrackBar SizeNet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckPeriodNet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar SizePeriodNet;
        private System.Windows.Forms.NumericUpDown NumPeriodNet;
        private System.Windows.Forms.Button bChooseColorNet;
        private System.Windows.Forms.Label lNetColor;
        private System.Windows.Forms.Button bСhooseBackColor;
        private System.Windows.Forms.Label lBackColor;
        private System.Windows.Forms.CheckBox CheckGradient;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancle;
    }
}