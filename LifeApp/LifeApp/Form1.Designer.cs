namespace LifeApp
{
    partial class Form1
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
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.popup_panel = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_retrieve = new System.Windows.Forms.Button();
            this.popup_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemmory = 5;
            this.Map.Location = new System.Drawing.Point(-4, 3);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 100;
            this.Map.MinZoom = 5;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(1040, 558);
            this.Map.TabIndex = 0;
            this.Map.Zoom = 5D;
            this.Map.Load += new System.EventHandler(this.Map_Load);
            this.Map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Map_MouseClick);
            // 
            // popup_panel
            // 
            this.popup_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.popup_panel.Controls.Add(this.button_retrieve);
            this.popup_panel.Controls.Add(this.button_add);
            this.popup_panel.Location = new System.Drawing.Point(595, 289);
            this.popup_panel.Name = "popup_panel";
            this.popup_panel.Size = new System.Drawing.Size(88, 42);
            this.popup_panel.TabIndex = 1;
            this.popup_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.popup_panel_Paint);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(0, 0);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(87, 23);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Add Event";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.add_button_Click);
            // 
            // button_retrieve
            // 
            this.button_retrieve.Location = new System.Drawing.Point(0, 20);
            this.button_retrieve.Name = "button_retrieve";
            this.button_retrieve.Size = new System.Drawing.Size(87, 23);
            this.button_retrieve.TabIndex = 1;
            this.button_retrieve.Text = "Retrieve Event";
            this.button_retrieve.UseVisualStyleBackColor = true;
            this.button_retrieve.Click += new System.EventHandler(this.retrieve_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 558);
            this.Controls.Add(this.popup_panel);
            this.Controls.Add(this.Map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.popup_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.Panel popup_panel;
        private System.Windows.Forms.Button button_retrieve;
        private System.Windows.Forms.Button button_add;
    }
}

