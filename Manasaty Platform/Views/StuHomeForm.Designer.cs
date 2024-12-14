namespace Manasaty_Platform.Views
{
    partial class StuHomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuHomeForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chaptersComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.greeting = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.userControlePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.videoPlaybackPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.manasatyPlatformDataSet = new Manasaty_Platform.ManasatyPlatformDataSet();
            this.cHAPTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHAPTERTableAdapter = new Manasaty_Platform.ManasatyPlatformDataSetTableAdapters.CHAPTERTableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.userControlePanel.SuspendLayout();
            this.videoPlaybackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manasatyPlatformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAPTERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Controls.Add(this.chaptersComboBox);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 39);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(252, 738);
            this.guna2Panel1.TabIndex = 4;
            // 
            // chaptersComboBox
            // 
            this.chaptersComboBox.AutoRoundedCorners = true;
            this.chaptersComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.chaptersComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.chaptersComboBox.BorderRadius = 17;
            this.chaptersComboBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.chaptersComboBox.DisabledState.ForeColor = System.Drawing.Color.White;
            this.chaptersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chaptersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chaptersComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.chaptersComboBox.FocusedColor = System.Drawing.Color.Black;
            this.chaptersComboBox.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.chaptersComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.chaptersComboBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(115)))));
            this.chaptersComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chaptersComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.chaptersComboBox.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaptersComboBox.ItemHeight = 30;
            this.chaptersComboBox.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.chaptersComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chaptersComboBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Transparent;
            this.chaptersComboBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaptersComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(115)))));
            this.chaptersComboBox.Location = new System.Drawing.Point(18, 268);
            this.chaptersComboBox.Name = "chaptersComboBox";
            this.chaptersComboBox.ShadowDecoration.BorderRadius = 0;
            this.chaptersComboBox.Size = new System.Drawing.Size(183, 36);
            this.chaptersComboBox.Sorted = true;
            this.chaptersComboBox.TabIndex = 11;
            this.chaptersComboBox.SelectedIndexChanged += new System.EventHandler(this.ChaptersComboBox_SelectedIndexChanged);
            this.chaptersComboBox.SelectionChangeCommitted += new System.EventHandler(this.chaptersComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mansaty Platform";
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.greeting.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.greeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.greeting.Location = new System.Drawing.Point(13, 122);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(101, 15);
            this.greeting.TabIndex = 7;
            this.greeting.Text = "Welcome back , ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.nameLabel.Location = new System.Drawing.Point(13, 148);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(20, 25);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "_";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 30;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2GradientButton1.Checked = true;
            this.guna2GradientButton1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(97)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(97)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(123)))));
            this.guna2GradientButton1.CustomizableEdges.BottomLeft = false;
            this.guna2GradientButton1.CustomizableEdges.TopLeft = false;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(97)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(97)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.HoverState.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.Location = new System.Drawing.Point(-9, 190);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(236, 63);
            this.guna2GradientButton1.TabIndex = 5;
            this.guna2GradientButton1.Text = "My Courses";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(50, 0);
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 1;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.BorderRadius = 30;
            this.guna2PictureBox1.ShadowDecoration.Color = System.Drawing.Color.Brown;
            this.guna2PictureBox1.ShadowDecoration.Depth = 1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(214, 738);
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // userControlePanel
            // 
            this.userControlePanel.BackColor = System.Drawing.SystemColors.Control;
            this.userControlePanel.BorderColor = System.Drawing.Color.Black;
            this.userControlePanel.BorderThickness = 1;
            this.userControlePanel.Controls.Add(this.guna2ControlBox3);
            this.userControlePanel.Controls.Add(this.guna2ControlBox2);
            this.userControlePanel.Controls.Add(this.guna2ControlBox1);
            this.userControlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.userControlePanel.Location = new System.Drawing.Point(0, 0);
            this.userControlePanel.Name = "userControlePanel";
            this.userControlePanel.Size = new System.Drawing.Size(1386, 39);
            this.userControlePanel.TabIndex = 5;
            this.userControlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userControlePanel_Paint);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1275, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(37, 28);
            this.guna2ControlBox3.TabIndex = 5;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1312, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(37, 28);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1349, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(37, 28);
            this.guna2ControlBox1.TabIndex = 3;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click_1);
            // 
            // videoPlaybackPanel
            // 
            this.videoPlaybackPanel.BackColor = System.Drawing.Color.Transparent;
            this.videoPlaybackPanel.BorderColor = System.Drawing.Color.Black;
            this.videoPlaybackPanel.BorderRadius = 12;
            this.videoPlaybackPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.videoPlaybackPanel.BorderThickness = 2;
            this.videoPlaybackPanel.Controls.Add(this.webViewer);
            this.videoPlaybackPanel.CustomBorderColor = System.Drawing.Color.Black;
            this.videoPlaybackPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.videoPlaybackPanel.Location = new System.Drawing.Point(644, 65);
            this.videoPlaybackPanel.Name = "videoPlaybackPanel";
            this.videoPlaybackPanel.Size = new System.Drawing.Size(740, 425);
            this.videoPlaybackPanel.TabIndex = 8;
            this.videoPlaybackPanel.Visible = false;
            this.videoPlaybackPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // webViewer
            // 
            this.webViewer.AllowExternalDrop = true;
            this.webViewer.BackColor = System.Drawing.Color.Black;
            this.webViewer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("webViewer.BackgroundImage")));
            this.webViewer.CreationProperties = null;
            this.webViewer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.webViewer.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.webViewer.ForeColor = System.Drawing.SystemColors.Info;
            this.webViewer.Location = new System.Drawing.Point(10, 10);
            this.webViewer.Name = "webViewer";
            this.webViewer.Size = new System.Drawing.Size(720, 405);
            this.webViewer.TabIndex = 15;
            this.webViewer.ZoomFactor = 1D;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(657, 538);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 24);
            this.descriptionLabel.TabIndex = 12;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(649, 502);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 26);
            this.titleLabel.TabIndex = 13;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.ForeColor = System.Drawing.Color.Black;
            this.durationLabel.Location = new System.Drawing.Point(658, 582);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(0, 19);
            this.durationLabel.TabIndex = 14;
            // 
            // manasatyPlatformDataSet
            // 
            this.manasatyPlatformDataSet.DataSetName = "ManasatyPlatformDataSet";
            this.manasatyPlatformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHAPTERBindingSource
            // 
            this.cHAPTERBindingSource.DataMember = "CHAPTER";
            this.cHAPTERBindingSource.DataSource = this.manasatyPlatformDataSet;
            // 
            // cHAPTERTableAdapter
            // 
            this.cHAPTERTableAdapter.ClearBeforeFill = true;
            // 
            // StuHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 777);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.videoPlaybackPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.userControlePanel);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StuHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StuHomeForm";
            this.Load += new System.EventHandler(this.StuHomeForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.userControlePanel.ResumeLayout(false);
            this.videoPlaybackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manasatyPlatformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAPTERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel userControlePanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2ComboBox chaptersComboBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label durationLabel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewer;
        private ManasatyPlatformDataSet manasatyPlatformDataSet;
        private System.Windows.Forms.BindingSource cHAPTERBindingSource;
        private ManasatyPlatformDataSetTableAdapters.CHAPTERTableAdapter cHAPTERTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel videoPlaybackPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label label2;
    }
}