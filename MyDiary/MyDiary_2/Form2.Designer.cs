namespace MyDiary_2
{
    partial class Form2
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
            dgDiary = new DataGridView();
            txtContent = new RichTextBox();
            btnSave = new Button();
            txtPass = new TextBox();
            label2 = new Label();
            btnBack = new Button();
            btnDelete = new Button();
            button1 = new Button();
            txtDate = new TextBox();
            btnFavorite = new Button();
            btnUnfavorite = new Button();
            btnFavoriteView = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDiary).BeginInit();
            SuspendLayout();
            // 
            // dgDiary
            // 
            dgDiary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDiary.Location = new Point(34, 40);
            dgDiary.Margin = new Padding(3, 4, 3, 4);
            dgDiary.Name = "dgDiary";
            dgDiary.ReadOnly = true;
            dgDiary.RowHeadersWidth = 51;
            dgDiary.RowTemplate.Height = 25;
            dgDiary.Size = new Size(438, 600);
            dgDiary.TabIndex = 0;
            dgDiary.CellClick += dgDiary_CellClick;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContent.Location = new Point(602, 103);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(604, 445);
            txtContent.TabIndex = 1;
            txtContent.Text = "";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(1123, 571);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 48);
            btnSave.TabIndex = 5;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPass.Location = new Point(722, 677);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(193, 39);
            txtPass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(602, 681);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(34, 680);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 48);
            btnBack.TabIndex = 5;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(353, 684);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 48);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(981, 571);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 5;
            button1.Text = "Ẩn/Bỏ ẩn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnHide_Click;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDate.Location = new Point(874, 33);
            txtDate.Margin = new Padding(3, 4, 3, 4);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(332, 39);
            txtDate.TabIndex = 2;
            // 
            // btnFavorite
            // 
            btnFavorite.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFavorite.Location = new Point(712, 571);
            btnFavorite.Margin = new Padding(3, 4, 3, 4);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(88, 48);
            btnFavorite.TabIndex = 5;
            btnFavorite.Text = "Thích";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnUnfavorite
            // 
            btnUnfavorite.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnfavorite.Location = new Point(833, 571);
            btnUnfavorite.Margin = new Padding(3, 4, 3, 4);
            btnUnfavorite.Name = "btnUnfavorite";
            btnUnfavorite.Size = new Size(118, 48);
            btnUnfavorite.TabIndex = 5;
            btnUnfavorite.Text = "Bỏ Thích";
            btnUnfavorite.UseVisualStyleBackColor = true;
            btnUnfavorite.Click += btnUnfavorite_Click;
            // 
            // btnFavoriteView
            // 
            btnFavoriteView.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFavoriteView.Location = new Point(1070, 673);
            btnFavoriteView.Margin = new Padding(3, 4, 3, 4);
            btnFavoriteView.Name = "btnFavoriteView";
            btnFavoriteView.Size = new Size(137, 48);
            btnFavoriteView.TabIndex = 5;
            btnFavoriteView.Text = "Xem Thích";
            btnFavoriteView.UseVisualStyleBackColor = true;
            btnFavoriteView.Click += btnFavoriteView_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.Location = new Point(935, 677);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(117, 44);
            btnView.TabIndex = 5;
            btnView.Text = "Xem";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 748);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnFavoriteView);
            Controls.Add(btnView);
            Controls.Add(btnUnfavorite);
            Controls.Add(btnFavorite);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(txtDate);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(txtContent);
            Controls.Add(dgDiary);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgDiary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDiary;
        private RichTextBox txtContent;
        private Button btnSave;
        private TextBox txtPass;
        private Label label2;
        private Button btnBack;
        private Button btnDelete;
        private Button button1;
        private TextBox txtDate;
        private Button btnFavorite;
        private Button btnUnfavorite;
        private Button btnFavoriteView;
        private Button btnView;
    }
}