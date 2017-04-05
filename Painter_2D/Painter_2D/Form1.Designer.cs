namespace Painter_2D
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
            this.CoordinatsLable = new System.Windows.Forms.Label();
            this.BezierRadio = new System.Windows.Forms.RadioButton();
            this.PolygonRadio = new System.Windows.Forms.RadioButton();
            this.CircleRadio = new System.Windows.Forms.RadioButton();
            this.LineRadio = new System.Windows.Forms.RadioButton();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brushSize = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.brushSize);
            this.panel1.Controls.Add(this.CoordinatsLable);
            this.panel1.Controls.Add(this.BezierRadio);
            this.panel1.Controls.Add(this.PolygonRadio);
            this.panel1.Controls.Add(this.CircleRadio);
            this.panel1.Controls.Add(this.LineRadio);
            this.panel1.Controls.Add(this.ColorPanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 448);
            this.panel1.TabIndex = 0;
            // 
            // CoordinatsLable
            // 
            this.CoordinatsLable.AutoSize = true;
            this.CoordinatsLable.Location = new System.Drawing.Point(108, 424);
            this.CoordinatsLable.Name = "CoordinatsLable";
            this.CoordinatsLable.Size = new System.Drawing.Size(35, 13);
            this.CoordinatsLable.TabIndex = 7;
            this.CoordinatsLable.Text = "label1";
            // 
            // BezierRadio
            // 
            this.BezierRadio.AutoSize = true;
            this.BezierRadio.Location = new System.Drawing.Point(34, 166);
            this.BezierRadio.Name = "BezierRadio";
            this.BezierRadio.Size = new System.Drawing.Size(92, 17);
            this.BezierRadio.TabIndex = 6;
            this.BezierRadio.TabStop = true;
            this.BezierRadio.Text = "Bezier curves ";
            this.BezierRadio.UseVisualStyleBackColor = true;
            // 
            // PolygonRadio
            // 
            this.PolygonRadio.AutoSize = true;
            this.PolygonRadio.Location = new System.Drawing.Point(34, 143);
            this.PolygonRadio.Name = "PolygonRadio";
            this.PolygonRadio.Size = new System.Drawing.Size(63, 17);
            this.PolygonRadio.TabIndex = 5;
            this.PolygonRadio.TabStop = true;
            this.PolygonRadio.Text = "Polygon";
            this.PolygonRadio.UseVisualStyleBackColor = true;
            // 
            // CircleRadio
            // 
            this.CircleRadio.AutoSize = true;
            this.CircleRadio.Location = new System.Drawing.Point(34, 120);
            this.CircleRadio.Name = "CircleRadio";
            this.CircleRadio.Size = new System.Drawing.Size(51, 17);
            this.CircleRadio.TabIndex = 4;
            this.CircleRadio.TabStop = true;
            this.CircleRadio.Text = "Circle";
            this.CircleRadio.UseVisualStyleBackColor = true;
            // 
            // LineRadio
            // 
            this.LineRadio.AutoSize = true;
            this.LineRadio.Location = new System.Drawing.Point(34, 97);
            this.LineRadio.Name = "LineRadio";
            this.LineRadio.Size = new System.Drawing.Size(45, 17);
            this.LineRadio.TabIndex = 3;
            this.LineRadio.TabStop = true;
            this.LineRadio.Text = "Line";
            this.LineRadio.UseVisualStyleBackColor = true;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.ColorPanel.Location = new System.Drawing.Point(10, 11);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(176, 23);
            this.ColorPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chose Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChoseColor);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(201, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 448);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // brushSize
            // 
            this.brushSize.Location = new System.Drawing.Point(34, 230);
            this.brushSize.Name = "brushSize";
            this.brushSize.Size = new System.Drawing.Size(37, 20);
            this.brushSize.TabIndex = 8;
            this.brushSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brushSize.ValueChanged += new System.EventHandler(this.GetBrushSize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Painter  2D";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.RadioButton BezierRadio;
        private System.Windows.Forms.RadioButton PolygonRadio;
        private System.Windows.Forms.RadioButton CircleRadio;
        private System.Windows.Forms.RadioButton LineRadio;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CoordinatsLable;
        private System.Windows.Forms.NumericUpDown brushSize;
    }
}

