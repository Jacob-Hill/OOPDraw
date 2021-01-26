namespace OOPDraw
{
    partial class OOPDraw
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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.LineWidth = new System.Windows.Forms.ComboBox();
            this.LineWidthLabel = new System.Windows.Forms.Label();
            this.LineColourLabel = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.ComboBox();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.Shape = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.Window;
            this.Canvas.Location = new System.Drawing.Point(252, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1841, 972);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // LineWidth
            // 
            this.LineWidth.BackColor = System.Drawing.SystemColors.Window;
            this.LineWidth.FormattingEnabled = true;
            this.LineWidth.Items.AddRange(new object[] {
            "Thin",
            "Medium",
            "Thick"});
            this.LineWidth.Location = new System.Drawing.Point(12, 29);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(121, 21);
            this.LineWidth.TabIndex = 1;
            this.LineWidth.SelectedIndexChanged += new System.EventHandler(this.LineWidth_SelectedIndexChanged);
            // 
            // LineWidthLabel
            // 
            this.LineWidthLabel.AutoSize = true;
            this.LineWidthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LineWidthLabel.Location = new System.Drawing.Point(13, 13);
            this.LineWidthLabel.Name = "LineWidthLabel";
            this.LineWidthLabel.Size = new System.Drawing.Size(58, 13);
            this.LineWidthLabel.TabIndex = 2;
            this.LineWidthLabel.Text = "Line Width";
            // 
            // LineColourLabel
            // 
            this.LineColourLabel.AutoSize = true;
            this.LineColourLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LineColourLabel.Location = new System.Drawing.Point(13, 67);
            this.LineColourLabel.Name = "LineColourLabel";
            this.LineColourLabel.Size = new System.Drawing.Size(60, 13);
            this.LineColourLabel.TabIndex = 4;
            this.LineColourLabel.Text = "Line Colour";
            // 
            // Colour
            // 
            this.Colour.FormattingEnabled = true;
            this.Colour.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Black"});
            this.Colour.Location = new System.Drawing.Point(12, 84);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(121, 21);
            this.Colour.TabIndex = 5;
            this.Colour.SelectedIndexChanged += new System.EventHandler(this.LineColour_SelectedIndexChanged);
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.AutoSize = true;
            this.ShapeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShapeLabel.Location = new System.Drawing.Point(13, 129);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(38, 13);
            this.ShapeLabel.TabIndex = 6;
            this.ShapeLabel.Text = "Shape";
            // 
            // Shape
            // 
            this.Shape.FormattingEnabled = true;
            this.Shape.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Ellipse",
            "Circle"});
            this.Shape.Location = new System.Drawing.Point(12, 146);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(121, 21);
            this.Shape.TabIndex = 7;
            // 
            // OOPDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(2105, 996);
            this.Controls.Add(this.Shape);
            this.Controls.Add(this.ShapeLabel);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.LineColourLabel);
            this.Controls.Add(this.LineWidthLabel);
            this.Controls.Add(this.LineWidth);
            this.Controls.Add(this.Canvas);
            this.Name = "OOPDraw";
            this.Text = "OOPDraw";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.ComboBox LineWidth;
        private System.Windows.Forms.Label LineWidthLabel;
        private System.Windows.Forms.Label LineColourLabel;
        private System.Windows.Forms.ComboBox Colour;
        private System.Windows.Forms.Label ShapeLabel;
        private System.Windows.Forms.ComboBox Shape;
    }
}

