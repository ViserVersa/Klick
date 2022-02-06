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
            ((System.ComponentModel.ISupportInitialize)(this.txt_LOOP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(73, 199);
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
            this.txt_X.Location = new System.Drawing.Point(32, 105);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(75, 20);
            this.txt_X.TabIndex = 3;
            this.txt_X.Text = "300";
            this.txt_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(113, 105);
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
            this.label1.Location = new System.Drawing.Point(174, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(29, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // txt_LOOP
            // 
            this.txt_LOOP.Location = new System.Drawing.Point(73, 157);
            this.txt_LOOP.Name = "txt_LOOP";
            this.txt_LOOP.Size = new System.Drawing.Size(75, 20);
            this.txt_LOOP.TabIndex = 10;
            this.txt_LOOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_LOOP.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txt_Y_OLD
            // 
            this.txt_Y_OLD.Location = new System.Drawing.Point(113, 79);
            this.txt_Y_OLD.Name = "txt_Y_OLD";
            this.txt_Y_OLD.ReadOnly = true;
            this.txt_Y_OLD.Size = new System.Drawing.Size(75, 20);
            this.txt_Y_OLD.TabIndex = 14;
            this.txt_Y_OLD.Text = "300";
            this.txt_Y_OLD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_X_OLD
            // 
            this.txt_X_OLD.Location = new System.Drawing.Point(32, 79);
            this.txt_X_OLD.Name = "txt_X_OLD";
            this.txt_X_OLD.ReadOnly = true;
            this.txt_X_OLD.Size = new System.Drawing.Size(75, 20);
            this.txt_X_OLD.TabIndex = 13;
            this.txt_X_OLD.Text = "300";
            this.txt_X_OLD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Ymove
            // 
            this.txt_Ymove.Location = new System.Drawing.Point(113, 131);
            this.txt_Ymove.Name = "txt_Ymove";
            this.txt_Ymove.Size = new System.Drawing.Size(49, 20);
            this.txt_Ymove.TabIndex = 12;
            this.txt_Ymove.Text = "35";
            this.txt_Ymove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Xmove
            // 
            this.txt_Xmove.Location = new System.Drawing.Point(58, 131);
            this.txt_Xmove.Name = "txt_Xmove";
            this.txt_Xmove.Size = new System.Drawing.Size(49, 20);
            this.txt_Xmove.TabIndex = 11;
            this.txt_Xmove.Text = "35";
            this.txt_Xmove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Klick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 559);
            this.Controls.Add(this.txt_Y_OLD);
            this.Controls.Add(this.txt_X_OLD);
            this.Controls.Add(this.txt_Ymove);
            this.Controls.Add(this.txt_Xmove);
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
            ((System.ComponentModel.ISupportInitialize)(this.txt_LOOP)).EndInit();
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
    }
}

