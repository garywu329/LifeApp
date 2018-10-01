namespace LifeApp
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.Lat_Label = new System.Windows.Forms.Label();
            this.Long_Label = new System.Windows.Forms.Label();
            this.Close_Event_button = new System.Windows.Forms.Button();
            this.Add_Event_Button = new System.Windows.Forms.Button();
            this.Latitude = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.Description_Text_Box = new System.Windows.Forms.TextBox();
            this.EventID_Label = new System.Windows.Forms.Label();
            this.EventID = new System.Windows.Forms.Label();
            this.datetimestamp_label = new System.Windows.Forms.Label();
            this.datestamp = new System.Windows.Forms.DateTimePicker();
            this.timestamp = new System.Windows.Forms.DateTimePicker();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Picture_filepath = new System.Windows.Forms.TextBox();
            this.Picture_filepath_label = new System.Windows.Forms.Label();
            this.Video = new AxWMPLib.AxWindowsMediaPlayer();
            this.Video_filepath_label = new System.Windows.Forms.Label();
            this.Video_filepath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).BeginInit();
            this.SuspendLayout();
            // 
            // Lat_Label
            // 
            this.Lat_Label.AutoSize = true;
            this.Lat_Label.Location = new System.Drawing.Point(98, 3);
            this.Lat_Label.Name = "Lat_Label";
            this.Lat_Label.Size = new System.Drawing.Size(45, 13);
            this.Lat_Label.TabIndex = 0;
            this.Lat_Label.Text = "Latitude";
            this.Lat_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Long_Label
            // 
            this.Long_Label.AutoSize = true;
            this.Long_Label.Location = new System.Drawing.Point(98, 16);
            this.Long_Label.Name = "Long_Label";
            this.Long_Label.Size = new System.Drawing.Size(54, 13);
            this.Long_Label.TabIndex = 1;
            this.Long_Label.Text = "Longitude";
            this.Long_Label.Click += new System.EventHandler(this.Long_Label_Click);
            // 
            // Close_Event_button
            // 
            this.Close_Event_button.Location = new System.Drawing.Point(146, 521);
            this.Close_Event_button.Name = "Close_Event_button";
            this.Close_Event_button.Size = new System.Drawing.Size(75, 23);
            this.Close_Event_button.TabIndex = 2;
            this.Close_Event_button.Text = "Close Event";
            this.Close_Event_button.UseVisualStyleBackColor = true;
            this.Close_Event_button.Click += new System.EventHandler(this.Close_Event_button_Click);
            // 
            // Add_Event_Button
            // 
            this.Add_Event_Button.Location = new System.Drawing.Point(17, 521);
            this.Add_Event_Button.Name = "Add_Event_Button";
            this.Add_Event_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Event_Button.TabIndex = 3;
            this.Add_Event_Button.Text = "Add Event";
            this.Add_Event_Button.UseVisualStyleBackColor = true;
            this.Add_Event_Button.Click += new System.EventHandler(this.Add_Event_Button_Click);
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(158, 3);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(22, 13);
            this.Latitude.TabIndex = 4;
            this.Latitude.Text = "Lat";
            this.Latitude.Click += new System.EventHandler(this.Latitude_Click);
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.Location = new System.Drawing.Point(158, 16);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(25, 13);
            this.Longitude.TabIndex = 5;
            this.Longitude.Text = "Lng";
            this.Longitude.Click += new System.EventHandler(this.Longitude_Click);
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(9, 28);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(60, 13);
            this.Description_label.TabIndex = 6;
            this.Description_label.Text = "Description";
            // 
            // Description_Text_Box
            // 
            this.Description_Text_Box.Location = new System.Drawing.Point(12, 44);
            this.Description_Text_Box.Name = "Description_Text_Box";
            this.Description_Text_Box.Size = new System.Drawing.Size(209, 20);
            this.Description_Text_Box.TabIndex = 7;
            this.Description_Text_Box.TextChanged += new System.EventHandler(this.Description_Text_Box_TextChanged);
            // 
            // EventID_Label
            // 
            this.EventID_Label.AutoSize = true;
            this.EventID_Label.Location = new System.Drawing.Point(15, 3);
            this.EventID_Label.Name = "EventID_Label";
            this.EventID_Label.Size = new System.Drawing.Size(46, 13);
            this.EventID_Label.TabIndex = 8;
            this.EventID_Label.Text = "EventID";
            // 
            // EventID
            // 
            this.EventID.AutoSize = true;
            this.EventID.Location = new System.Drawing.Point(67, 3);
            this.EventID.Name = "EventID";
            this.EventID.Size = new System.Drawing.Size(18, 13);
            this.EventID.TabIndex = 9;
            this.EventID.Text = "ID";
            this.EventID.Click += new System.EventHandler(this.EventID_Click);
            // 
            // datetimestamp_label
            // 
            this.datetimestamp_label.AutoSize = true;
            this.datetimestamp_label.Location = new System.Drawing.Point(9, 67);
            this.datetimestamp_label.Name = "datetimestamp_label";
            this.datetimestamp_label.Size = new System.Drawing.Size(85, 13);
            this.datetimestamp_label.TabIndex = 10;
            this.datetimestamp_label.Text = "Date/time stamp";
            // 
            // datestamp
            // 
            this.datestamp.Location = new System.Drawing.Point(12, 83);
            this.datestamp.Name = "datestamp";
            this.datestamp.Size = new System.Drawing.Size(209, 20);
            this.datestamp.TabIndex = 12;
            this.datestamp.ValueChanged += new System.EventHandler(this.datestamp_ValueChanged);
            // 
            // timestamp
            // 
            this.timestamp.Location = new System.Drawing.Point(12, 109);
            this.timestamp.Name = "timestamp";
            this.timestamp.Size = new System.Drawing.Size(209, 20);
            this.timestamp.TabIndex = 13;
            this.timestamp.ValueChanged += new System.EventHandler(this.timestamp_ValueChanged);
            // 
            // Picture
            // 
            this.Picture.Image = global::LifeApp.Properties.Resources.Placeholder;
            this.Picture.Location = new System.Drawing.Point(12, 182);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(209, 91);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 14;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // Picture_filepath
            // 
            this.Picture_filepath.Location = new System.Drawing.Point(12, 156);
            this.Picture_filepath.Name = "Picture_filepath";
            this.Picture_filepath.Size = new System.Drawing.Size(209, 20);
            this.Picture_filepath.TabIndex = 15;
            this.Picture_filepath.TextChanged += new System.EventHandler(this.Picture_filepath_TextChanged);
            // 
            // Picture_filepath_label
            // 
            this.Picture_filepath_label.AutoSize = true;
            this.Picture_filepath_label.Location = new System.Drawing.Point(9, 132);
            this.Picture_filepath_label.Name = "Picture_filepath_label";
            this.Picture_filepath_label.Size = new System.Drawing.Size(80, 13);
            this.Picture_filepath_label.TabIndex = 16;
            this.Picture_filepath_label.Text = "Picture Filepath";
            this.Picture_filepath_label.Click += new System.EventHandler(this.Picture_filepath_label_Click_1);
            // 
            // Video
            // 
            this.Video.Enabled = true;
            this.Video.Location = new System.Drawing.Point(12, 319);
            this.Video.Name = "Video";
            this.Video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Video.OcxState")));
            this.Video.Size = new System.Drawing.Size(209, 183);
            this.Video.TabIndex = 17;
            this.Video.Enter += new System.EventHandler(this.Video_Enter);
            // 
            // Video_filepath_label
            // 
            this.Video_filepath_label.AutoSize = true;
            this.Video_filepath_label.Location = new System.Drawing.Point(12, 276);
            this.Video_filepath_label.Name = "Video_filepath_label";
            this.Video_filepath_label.Size = new System.Drawing.Size(74, 13);
            this.Video_filepath_label.TabIndex = 18;
            this.Video_filepath_label.Text = "Video Filepath";
            // 
            // Video_filepath
            // 
            this.Video_filepath.Location = new System.Drawing.Point(13, 293);
            this.Video_filepath.Name = "Video_filepath";
            this.Video_filepath.Size = new System.Drawing.Size(208, 20);
            this.Video_filepath.TabIndex = 19;
            this.Video_filepath.TextChanged += new System.EventHandler(this.Video_filepath_TextChanged);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 556);
            this.Controls.Add(this.Video_filepath);
            this.Controls.Add(this.Video_filepath_label);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.Picture_filepath_label);
            this.Controls.Add(this.Picture_filepath);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.timestamp);
            this.Controls.Add(this.datestamp);
            this.Controls.Add(this.datetimestamp_label);
            this.Controls.Add(this.EventID);
            this.Controls.Add(this.EventID_Label);
            this.Controls.Add(this.Description_Text_Box);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.Add_Event_Button);
            this.Controls.Add(this.Close_Event_button);
            this.Controls.Add(this.Long_Label);
            this.Controls.Add(this.Lat_Label);
            this.Name = "AddForm";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.InformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lat_Label;
        private System.Windows.Forms.Label Long_Label;
        private System.Windows.Forms.Button Close_Event_button;
        private System.Windows.Forms.Button Add_Event_Button;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.TextBox Description_Text_Box;
        private System.Windows.Forms.Label EventID_Label;
        private System.Windows.Forms.Label EventID;
        private System.Windows.Forms.Label datetimestamp_label;
        private System.Windows.Forms.DateTimePicker datestamp;
        private System.Windows.Forms.DateTimePicker timestamp;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox Picture_filepath;
        private System.Windows.Forms.Label Picture_filepath_label;
        private AxWMPLib.AxWindowsMediaPlayer Video;
        private System.Windows.Forms.Label Video_filepath_label;
        private System.Windows.Forms.TextBox Video_filepath;
    }
}