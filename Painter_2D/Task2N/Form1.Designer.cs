namespace Task2N
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.axisBox = new System.Windows.Forms.ComboBox();
            this.mirrorRadio = new System.Windows.Forms.RadioButton();
            this.angleNumerical = new System.Windows.Forms.NumericUpDown();
            this.scaleNumeric = new System.Windows.Forms.NumericUpDown();
            this.xyLable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rotationRadio = new System.Windows.Forms.RadioButton();
            this.scalingRadio = new System.Windows.Forms.RadioButton();
            this.cuttingRadio = new System.Windows.Forms.RadioButton();
            this.movingRadio = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.thicknessNumerical = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumerical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessNumerical)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.thicknessNumerical);
            this.panel1.Controls.Add(this.axisBox);
            this.panel1.Controls.Add(this.mirrorRadio);
            this.panel1.Controls.Add(this.angleNumerical);
            this.panel1.Controls.Add(this.scaleNumeric);
            this.panel1.Controls.Add(this.xyLable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rotationRadio);
            this.panel1.Controls.Add(this.scalingRadio);
            this.panel1.Controls.Add(this.cuttingRadio);
            this.panel1.Controls.Add(this.movingRadio);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.loadBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 444);
            this.panel1.TabIndex = 0;
            // 
            // axisBox
            // 
            this.axisBox.FormattingEnabled = true;
            this.axisBox.Location = new System.Drawing.Point(43, 299);
            this.axisBox.Name = "axisBox";
            this.axisBox.Size = new System.Drawing.Size(43, 21);
            this.axisBox.TabIndex = 11;
            this.axisBox.Text = "OX";
            // 
            // mirrorRadio
            // 
            this.mirrorRadio.AutoSize = true;
            this.mirrorRadio.Location = new System.Drawing.Point(43, 198);
            this.mirrorRadio.Name = "mirrorRadio";
            this.mirrorRadio.Size = new System.Drawing.Size(51, 17);
            this.mirrorRadio.TabIndex = 10;
            this.mirrorRadio.TabStop = true;
            this.mirrorRadio.Text = "Mirror";
            this.mirrorRadio.UseVisualStyleBackColor = true;
            // 
            // angleNumerical
            // 
            this.angleNumerical.Location = new System.Drawing.Point(43, 273);
            this.angleNumerical.Name = "angleNumerical";
            this.angleNumerical.Size = new System.Drawing.Size(43, 20);
            this.angleNumerical.TabIndex = 9;
            this.angleNumerical.ValueChanged += new System.EventHandler(this.angleNumerical_ValueChanged);
            // 
            // scaleNumeric
            // 
            this.scaleNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scaleNumeric.Location = new System.Drawing.Point(43, 247);
            this.scaleNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scaleNumeric.Name = "scaleNumeric";
            this.scaleNumeric.Size = new System.Drawing.Size(43, 20);
            this.scaleNumeric.TabIndex = 8;
            this.scaleNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.scaleNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // xyLable
            // 
            this.xyLable.AutoSize = true;
            this.xyLable.Location = new System.Drawing.Point(118, 413);
            this.xyLable.Name = "xyLable";
            this.xyLable.Size = new System.Drawing.Size(35, 13);
            this.xyLable.TabIndex = 7;
            this.xyLable.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(47, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 20);
            this.panel2.TabIndex = 6;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // rotationRadio
            // 
            this.rotationRadio.AutoSize = true;
            this.rotationRadio.Location = new System.Drawing.Point(43, 175);
            this.rotationRadio.Name = "rotationRadio";
            this.rotationRadio.Size = new System.Drawing.Size(65, 17);
            this.rotationRadio.TabIndex = 5;
            this.rotationRadio.TabStop = true;
            this.rotationRadio.Text = "Rotation";
            this.rotationRadio.UseVisualStyleBackColor = true;
            // 
            // scalingRadio
            // 
            this.scalingRadio.AutoSize = true;
            this.scalingRadio.Location = new System.Drawing.Point(43, 152);
            this.scalingRadio.Name = "scalingRadio";
            this.scalingRadio.Size = new System.Drawing.Size(60, 17);
            this.scalingRadio.TabIndex = 4;
            this.scalingRadio.TabStop = true;
            this.scalingRadio.Text = "Scaling";
            this.scalingRadio.UseVisualStyleBackColor = true;
            // 
            // cuttingRadio
            // 
            this.cuttingRadio.AutoSize = true;
            this.cuttingRadio.Location = new System.Drawing.Point(43, 129);
            this.cuttingRadio.Name = "cuttingRadio";
            this.cuttingRadio.Size = new System.Drawing.Size(58, 17);
            this.cuttingRadio.TabIndex = 3;
            this.cuttingRadio.TabStop = true;
            this.cuttingRadio.Text = "Cutting";
            this.cuttingRadio.UseVisualStyleBackColor = true;
            // 
            // movingRadio
            // 
            this.movingRadio.AutoSize = true;
            this.movingRadio.Location = new System.Drawing.Point(43, 106);
            this.movingRadio.Name = "movingRadio";
            this.movingRadio.Size = new System.Drawing.Size(60, 17);
            this.movingRadio.TabIndex = 2;
            this.movingRadio.TabStop = true;
            this.movingRadio.Text = "Moving";
            this.movingRadio.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(43, 66);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(43, 38);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 22);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(417, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(203, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(540, 444);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // thicknessNumerical
            // 
            this.thicknessNumerical.Location = new System.Drawing.Point(43, 326);
            this.thicknessNumerical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessNumerical.Name = "thicknessNumerical";
            this.thicknessNumerical.Size = new System.Drawing.Size(40, 20);
            this.thicknessNumerical.TabIndex = 12;
            this.thicknessNumerical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessNumerical.ValueChanged += new System.EventHandler(this.thicknessNumerical_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Axis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Thickness";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 444);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumerical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessNumerical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rotationRadio;
        private System.Windows.Forms.RadioButton scalingRadio;
        private System.Windows.Forms.RadioButton cuttingRadio;
        private System.Windows.Forms.RadioButton movingRadio;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label xyLable;
        private System.Windows.Forms.NumericUpDown scaleNumeric;
        private System.Windows.Forms.NumericUpDown angleNumerical;
        private System.Windows.Forms.RadioButton mirrorRadio;
        private System.Windows.Forms.ComboBox axisBox;
        private System.Windows.Forms.NumericUpDown thicknessNumerical;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

