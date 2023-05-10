
namespace Library.Presentation
{
    partial class FormBookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookInfo));
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.gbRating = new System.Windows.Forms.GroupBox();
            this.rbRating5 = new System.Windows.Forms.RadioButton();
            this.rbRating4 = new System.Windows.Forms.RadioButton();
            this.rbRating3 = new System.Windows.Forms.RadioButton();
            this.rbRating2 = new System.Windows.Forms.RadioButton();
            this.rbRating1 = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBanner = new System.Windows.Forms.Label();
            this.btnRemoveFromList = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(160, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "bookName";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(160, 161);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(93, 18);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "authorName";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(160, 201);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(37, 18);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "isbn";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(160, 244);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 18);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "category";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(478, 284);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(147, 35);
            this.btnAddToList.TabIndex = 6;
            this.btnAddToList.Text = "Add the book to my list";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // gbRating
            // 
            this.gbRating.Controls.Add(this.rbRating5);
            this.gbRating.Controls.Add(this.rbRating4);
            this.gbRating.Controls.Add(this.rbRating3);
            this.gbRating.Controls.Add(this.rbRating2);
            this.gbRating.Controls.Add(this.rbRating1);
            this.gbRating.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRating.ForeColor = System.Drawing.Color.White;
            this.gbRating.Location = new System.Drawing.Point(478, 161);
            this.gbRating.Name = "gbRating";
            this.gbRating.Size = new System.Drawing.Size(131, 49);
            this.gbRating.TabIndex = 8;
            this.gbRating.TabStop = false;
            this.gbRating.Text = "Rate the book";
            // 
            // rbRating5
            // 
            this.rbRating5.AutoSize = true;
            this.rbRating5.Location = new System.Drawing.Point(100, 19);
            this.rbRating5.Name = "rbRating5";
            this.rbRating5.Size = new System.Drawing.Size(14, 13);
            this.rbRating5.TabIndex = 4;
            this.rbRating5.TabStop = true;
            this.rbRating5.UseVisualStyleBackColor = true;
            this.rbRating5.CheckedChanged += new System.EventHandler(this.rbRating5_CheckedChanged);
            // 
            // rbRating4
            // 
            this.rbRating4.AutoSize = true;
            this.rbRating4.Location = new System.Drawing.Point(80, 19);
            this.rbRating4.Name = "rbRating4";
            this.rbRating4.Size = new System.Drawing.Size(14, 13);
            this.rbRating4.TabIndex = 3;
            this.rbRating4.TabStop = true;
            this.rbRating4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbRating4.UseVisualStyleBackColor = true;
            this.rbRating4.CheckedChanged += new System.EventHandler(this.rbRating4_CheckedChanged);
            // 
            // rbRating3
            // 
            this.rbRating3.AutoSize = true;
            this.rbRating3.Location = new System.Drawing.Point(60, 19);
            this.rbRating3.Name = "rbRating3";
            this.rbRating3.Size = new System.Drawing.Size(14, 13);
            this.rbRating3.TabIndex = 2;
            this.rbRating3.TabStop = true;
            this.rbRating3.UseVisualStyleBackColor = true;
            this.rbRating3.CheckedChanged += new System.EventHandler(this.rbRating3_CheckedChanged);
            // 
            // rbRating2
            // 
            this.rbRating2.AutoSize = true;
            this.rbRating2.Location = new System.Drawing.Point(40, 19);
            this.rbRating2.Name = "rbRating2";
            this.rbRating2.Size = new System.Drawing.Size(14, 13);
            this.rbRating2.TabIndex = 1;
            this.rbRating2.TabStop = true;
            this.rbRating2.UseVisualStyleBackColor = true;
            this.rbRating2.CheckedChanged += new System.EventHandler(this.rbRating2_CheckedChanged);
            // 
            // rbRating1
            // 
            this.rbRating1.AutoSize = true;
            this.rbRating1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbRating1.Location = new System.Drawing.Point(20, 19);
            this.rbRating1.Name = "rbRating1";
            this.rbRating1.Size = new System.Drawing.Size(14, 13);
            this.rbRating1.TabIndex = 0;
            this.rbRating1.UseVisualStyleBackColor = true;
            this.rbRating1.CheckedChanged += new System.EventHandler(this.rbRating1_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(600, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 23);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBanner.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(241, 9);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(155, 26);
            this.lblBanner.TabIndex = 27;
            this.lblBanner.Text = "Library";
            // 
            // btnRemoveFromList
            // 
            this.btnRemoveFromList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromList.Location = new System.Drawing.Point(478, 278);
            this.btnRemoveFromList.Name = "btnRemoveFromList";
            this.btnRemoveFromList.Size = new System.Drawing.Size(147, 41);
            this.btnRemoveFromList.TabIndex = 28;
            this.btnRemoveFromList.Text = "Remove the book from my list";
            this.btnRemoveFromList.UseVisualStyleBackColor = true;
            this.btnRemoveFromList.Visible = false;
            this.btnRemoveFromList.Click += new System.EventHandler(this.btnRemoveFromList_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(71, 118);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 18);
            this.lbl1.TabIndex = 29;
            this.lbl1.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Category:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 50);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FormBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(637, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnRemoveFromList);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbRating);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBookInfo";
            this.Load += new System.EventHandler(this.FormBookInfo_Load);
            this.gbRating.ResumeLayout(false);
            this.gbRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.GroupBox gbRating;
        private System.Windows.Forms.RadioButton rbRating5;
        private System.Windows.Forms.RadioButton rbRating4;
        private System.Windows.Forms.RadioButton rbRating3;
        private System.Windows.Forms.RadioButton rbRating2;
        private System.Windows.Forms.RadioButton rbRating1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnRemoveFromList;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}