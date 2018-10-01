namespace LifeApp
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.EventID_label = new System.Windows.Forms.Label();
            this.EventID = new System.Windows.Forms.Label();
            this.Lat_Label = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.Label();
            this.Long_Label = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.datestamp = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Video = new AxWMPLib.AxWindowsMediaPlayer();
            this.CloseEvent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).BeginInit();
            this.SuspendLayout();
            // 
            // EventID_label
            // 
            this.EventID_label.AutoSize = true;
            this.EventID_label.Location = new System.Drawing.Point(12, 10);
            this.EventID_label.Name = "EventID_label";
            this.EventID_label.Size = new System.Drawing.Size(46, 13);
            this.EventID_label.TabIndex = 0;
            this.EventID_label.Text = "EventID";
            // 
            // EventID
            // 
            this.EventID.AutoSize = true;
            this.EventID.Location = new System.Drawing.Point(64, 10);
            this.EventID.Name = "EventID";
            this.EventID.Size = new System.Drawing.Size(18, 13);
            this.EventID.TabIndex = 1;
            this.EventID.Text = "ID";
            // 
            // Lat_Label
            // 
            this.Lat_Label.AutoSize = true;
            this.Lat_Label.Location = new System.Drawing.Point(106, 10);
            this.Lat_Label.Name = "Lat_Label";
            this.Lat_Label.Size = new System.Drawing.Size(45, 13);
            this.Lat_Label.TabIndex = 2;
            this.Lat_Label.Text = "Latitude";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(169, 10);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(22, 13);
            this.Latitude.TabIndex = 5;
            this.Latitude.Text = "Lat";
            this.Latitude.Click += new System.EventHandler(this.Latitude_Click);
            // 
            // Long_Label
            // 
            this.Long_Label.AutoSize = true;
            this.Long_Label.Location = new System.Drawing.Point(106, 23);
            this.Long_Label.Name = "Long_Label";
            this.Long_Label.Size = new System.Drawing.Size(54, 13);
            this.Long_Label.TabIndex = 6;
            this.Long_Label.Text = "Longitude";
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.Location = new System.Drawing.Point(169, 23);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(25, 13);
            this.Longitude.TabIndex = 7;
            this.Longitude.Text = "Lng";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(12, 93);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(60, 13);
            this.Description_label.TabIndex = 8;
            this.Description_label.Text = "Description";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(12, 109);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(198, 64);
            this.Description.TabIndex = 9;
            this.Description.Text = "";
            // 
            // datestamp
            // 
            this.datestamp.Location = new System.Drawing.Point(12, 65);
            this.datestamp.Name = "datestamp";
            this.datestamp.Size = new System.Drawing.Size(198, 20);
            this.datestamp.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Picture
            // 
            this.Picture.Image = global::LifeApp.Properties.Resources.Placeholder;
            this.Picture.Location = new System.Drawing.Point(12, 179);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(198, 109);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 15;
            this.Picture.TabStop = false;
            // 
            // Video
            // 
            this.Video.Enabled = true;
            this.Video.Location = new System.Drawing.Point(12, 294);
            this.Video.Name = "Video";
            this.Video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Video.OcxState")));
            this.Video.Size = new System.Drawing.Size(198, 183);
            this.Video.TabIndex = 18;
            // 
            // CloseEvent
            // 
            this.CloseEvent.Location = new System.Drawing.Point(135, 501);
            this.CloseEvent.Name = "CloseEvent";
            this.CloseEvent.Size = new System.Drawing.Size(75, 23);
            this.CloseEvent.TabIndex = 19;
            this.CloseEvent.Text = "Close";
            this.CloseEvent.UseVisualStyleBackColor = true;
            this.CloseEvent.Click += new System.EventHandler(this.CloseEvent_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 526);
            this.Controls.Add(this.CloseEvent);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datestamp);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.Long_Label);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.Lat_Label);
            this.Controls.Add(this.EventID);
            this.Controls.Add(this.EventID_label);
            this.Name = "EventForm";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventID_label;
        private System.Windows.Forms.Label EventID;
        private System.Windows.Forms.Label Lat_Label;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label Long_Label;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.DateTimePicker datestamp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox Picture;
        private AxWMPLib.AxWindowsMediaPlayer Video;
        private System.Windows.Forms.Button CloseEvent;
    }
}