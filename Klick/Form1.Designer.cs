namespace Klick
{
    partial class Klick
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LOOP = new System.Windows.Forms.NumericUpDown();
            this.txt_Y_OLD = new System.Windows.Forms.TextBox();
            this.txt_X_OLD = new System.Windows.Forms.TextBox();
            this.txt_Ymove = new System.Windows.Forms.TextBox();
            this.txt_Xmove = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtDataGridView = new System.Windows.Forms.DataGridView();
            this.txt_SearchLoop = new System.Windows.Forms.NumericUpDown();
            this.btn_Square = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LOOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SearchLoop)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(73, 114);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Update
            // 
            this.lbl_Update.AutoSize = true;
            this.lbl_Update.Location = new System.Drawing.Point(655, 401);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Size = new System.Drawing.Size(0, 13);
            this.lbl_Update.TabIndex = 1;
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(32, 36);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(75, 20);
            this.txt_X.TabIndex = 3;
            this.txt_X.Text = "600";
            this.txt_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(113, 36);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(75, 20);
            this.txt_Y.TabIndex = 4;
            this.txt_Y.Text = "300";
            this.txt_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(174, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // txt_LOOP
            // 
            this.txt_LOOP.Location = new System.Drawing.Point(73, 88);
            this.txt_LOOP.Name = "txt_LOOP";
            this.txt_LOOP.Size = new System.Drawing.Size(75, 20);
            this.txt_LOOP.TabIndex = 10;
            this.txt_LOOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_LOOP.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txt_Y_OLD
            // 
            this.txt_Y_OLD.Location = new System.Drawing.Point(113, 10);
            this.txt_Y_OLD.Name = "txt_Y_OLD";
            this.txt_Y_OLD.ReadOnly = true;
            this.txt_Y_OLD.Size = new System.Drawing.Size(75, 20);
            this.txt_Y_OLD.TabIndex = 14;
            this.txt_Y_OLD.Text = "300";
            this.txt_Y_OLD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_X_OLD
            // 
            this.txt_X_OLD.Location = new System.Drawing.Point(32, 10);
            this.txt_X_OLD.Name = "txt_X_OLD";
            this.txt_X_OLD.ReadOnly = true;
            this.txt_X_OLD.Size = new System.Drawing.Size(75, 20);
            this.txt_X_OLD.TabIndex = 13;
            this.txt_X_OLD.Text = "300";
            this.txt_X_OLD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Ymove
            // 
            this.txt_Ymove.Location = new System.Drawing.Point(113, 62);
            this.txt_Ymove.Name = "txt_Ymove";
            this.txt_Ymove.Size = new System.Drawing.Size(49, 20);
            this.txt_Ymove.TabIndex = 12;
            this.txt_Ymove.Text = "0";
            this.txt_Ymove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Xmove
            // 
            this.txt_Xmove.Location = new System.Drawing.Point(58, 62);
            this.txt_Xmove.Name = "txt_Xmove";
            this.txt_Xmove.Size = new System.Drawing.Size(49, 20);
            this.txt_Xmove.TabIndex = 11;
            this.txt_Xmove.Text = "0";
            this.txt_Xmove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(73, 524);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtDataGridView
            // 
            this.dtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDataGridView.Location = new System.Drawing.Point(12, 143);
            this.dtDataGridView.Name = "dtDataGridView";
            this.dtDataGridView.Size = new System.Drawing.Size(239, 375);
            this.dtDataGridView.TabIndex = 16;
            // 
            // txt_SearchLoop
            // 
            this.txt_SearchLoop.Location = new System.Drawing.Point(154, 524);
            this.txt_SearchLoop.Name = "txt_SearchLoop";
            this.txt_SearchLoop.Size = new System.Drawing.Size(40, 20);
            this.txt_SearchLoop.TabIndex = 10;
            this.txt_SearchLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SearchLoop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_Square
            // 
            this.btn_Square.Location = new System.Drawing.Point(1091, 10);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(75, 23);
            this.btn_Square.TabIndex = 17;
            this.btn_Square.Text = "Square";
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // Klick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 552);
            this.Controls.Add(this.btn_Square);
            this.Controls.Add(this.dtDataGridView);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Y_OLD);
            this.Controls.Add(this.txt_X_OLD);
            this.Controls.Add(this.txt_Ymove);
            this.Controls.Add(this.txt_Xmove);
            this.Controls.Add(this.txt_SearchLoop);
            this.Controls.Add(this.txt_LOOP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.lbl_Update);
            this.Controls.Add(this.btn_Update);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Klick";
            this.Text = "Klick";
            this.Load += new System.EventHandler(this.Klick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_LOOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SearchLoop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_LOOP;
        private System.Windows.Forms.TextBox txt_Y_OLD;
        private System.Windows.Forms.TextBox txt_X_OLD;
        private System.Windows.Forms.TextBox txt_Ymove;
        private System.Windows.Forms.TextBox txt_Xmove;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dtDataGridView;
        private System.Windows.Forms.NumericUpDown txt_SearchLoop;
        private System.Windows.Forms.Button btn_Square;
    }
}

