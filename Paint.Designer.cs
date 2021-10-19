namespace PaintToScreen {
    partial class Paint {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this._colorPicker = new System.Windows.Forms.Button();
            this._hold = new System.Windows.Forms.Button();
            this._help = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // _colorPicker
            // 
            this._colorPicker.BackColor = System.Drawing.Color.Transparent;
            this._colorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_colorPicker.BackgroundImage")));
            this._colorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this._colorPicker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._colorPicker.FlatAppearance.BorderSize = 0;
            this._colorPicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._colorPicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._colorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._colorPicker.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._colorPicker.ForeColor = System.Drawing.Color.Transparent;
            this._colorPicker.Location = new System.Drawing.Point(0, 0);
            this._colorPicker.Name = "_colorPicker";
            this._colorPicker.Size = new System.Drawing.Size(60, 90);
            this._colorPicker.TabIndex = 0;
            this._help.SetToolTip(this._colorPicker, "Pick a color");
            this._colorPicker.UseVisualStyleBackColor = false;
            this._colorPicker.Click += new System.EventHandler(this._colorPicker_Click);
            this._colorPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this._colorPicker_KeyDown);
            // 
            // _hold
            // 
            this._hold.BackColor = System.Drawing.Color.White;
            this._hold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_hold.BackgroundImage")));
            this._hold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._hold.Cursor = System.Windows.Forms.Cursors.Hand;
            this._hold.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._hold.FlatAppearance.BorderSize = 0;
            this._hold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._hold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._hold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._hold.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._hold.ForeColor = System.Drawing.Color.White;
            this._hold.Location = new System.Drawing.Point(0, 120);
            this._hold.Name = "_hold";
            this._hold.Size = new System.Drawing.Size(100, 100);
            this._hold.TabIndex = 1;
            this._help.SetToolTip(this._hold, "Hold on");
            this._hold.UseVisualStyleBackColor = false;
            this._hold.Click += new System.EventHandler(this._hold_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(34F, 86F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this._hold);
            this.Controls.Add(this._colorPicker);
            this.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(17, 20, 17, 20);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paint";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Paint_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _colorPicker;
        private System.Windows.Forms.ToolTip _help;
        public System.Windows.Forms.Button _hold;
    }
}

