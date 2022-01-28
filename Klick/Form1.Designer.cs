namespace Klick
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.rbtn_Repeat = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(577, 368);
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
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(658, 368);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(613, 342);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(83, 20);
            this.txt_X.TabIndex = 3;
            this.txt_X.Text = "-500";
            this.txt_X.TextChanged += new System.EventHandler(this.txt_X_TextChanged);
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(613, 316);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(83, 20);
            this.txt_Y.TabIndex = 4;
            this.txt_Y.Text = "300";
            // 
            // rbtn_Repeat
            // 
            this.rbtn_Repeat.AutoSize = true;
            this.rbtn_Repeat.Location = new System.Drawing.Point(577, 397);
            this.rbtn_Repeat.Name = "rbtn_Repeat";
            this.rbtn_Repeat.Size = new System.Drawing.Size(60, 17);
            this.rbtn_Repeat.TabIndex = 5;
            this.rbtn_Repeat.TabStop = true;
            this.rbtn_Repeat.Text = "Repeat";
            this.rbtn_Repeat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn_Repeat);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Update);
            this.Controls.Add(this.btn_Update);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.RadioButton rbtn_Repeat;
    }
}

