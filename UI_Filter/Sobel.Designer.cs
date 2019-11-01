namespace UI_Filter
{
    partial class Sobel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobel));
            this.x = new System.Windows.Forms.Label();
            this.sobel_x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.Label();
            this.sobel_y = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.Color.Transparent;
            this.x.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(47, 11);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(14, 14);
            this.x.TabIndex = 27;
            this.x.Text = "x";
            // 
            // sobel_x
            // 
            this.sobel_x.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobel_x.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sobel_x.Location = new System.Drawing.Point(25, 30);
            this.sobel_x.Name = "sobel_x";
            this.sobel_x.Size = new System.Drawing.Size(55, 26);
            this.sobel_x.TabIndex = 28;
            this.sobel_x.Text = "0";
            this.sobel_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sobel_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sobel_x_KeyPress);
            this.sobel_x.Leave += new System.EventHandler(this.sobel_x_Leave);
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.BackColor = System.Drawing.Color.Transparent;
            this.y.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.Location = new System.Drawing.Point(128, 11);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(14, 14);
            this.y.TabIndex = 29;
            this.y.Text = "y";
            // 
            // sobel_y
            // 
            this.sobel_y.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobel_y.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sobel_y.Location = new System.Drawing.Point(105, 30);
            this.sobel_y.Name = "sobel_y";
            this.sobel_y.Size = new System.Drawing.Size(55, 26);
            this.sobel_y.TabIndex = 30;
            this.sobel_y.Text = "1";
            this.sobel_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sobel_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sobel_y_KeyPress);
            this.sobel_y.Leave += new System.EventHandler(this.sobel_y_Leave);
            // 
            // apply
            // 
            this.apply.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.apply.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.Location = new System.Drawing.Point(185, 28);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(58, 31);
            this.apply.TabIndex = 31;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // Sobel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(267, 81);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.sobel_y);
            this.Controls.Add(this.y);
            this.Controls.Add(this.sobel_x);
            this.Controls.Add(this.x);
            this.Name = "Sobel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox sobel_x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.TextBox sobel_y;
        private System.Windows.Forms.Button apply;
    }
}