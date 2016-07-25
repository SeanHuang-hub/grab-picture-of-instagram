namespace CSharp_grab_picture_of_instagram
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.websiteBox = new System.Windows.Forms.TextBox();
            this.grabButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.folderPathBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // websiteBox
            // 
            this.websiteBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.websiteBox.Location = new System.Drawing.Point(25, 46);
            this.websiteBox.Name = "websiteBox";
            this.websiteBox.Size = new System.Drawing.Size(565, 27);
            this.websiteBox.TabIndex = 0;
            // 
            // grabButton
            // 
            this.grabButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grabButton.Location = new System.Drawing.Point(596, 46);
            this.grabButton.Name = "grabButton";
            this.grabButton.Size = new System.Drawing.Size(88, 27);
            this.grabButton.TabIndex = 1;
            this.grabButton.Text = "Grab";
            this.grabButton.UseVisualStyleBackColor = true;
            this.grabButton.Click += new System.EventHandler(this.grabButton_Click);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(25, 208);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(659, 224);
            this.logBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log";
            // 
            // folderButton
            // 
            this.folderButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.folderButton.Location = new System.Drawing.Point(596, 125);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(88, 27);
            this.folderButton.TabIndex = 5;
            this.folderButton.Text = "Choose";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Folder path";
            // 
            // folderPathBox
            // 
            this.folderPathBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.folderPathBox.Location = new System.Drawing.Point(25, 127);
            this.folderPathBox.Name = "folderPathBox";
            this.folderPathBox.ReadOnly = true;
            this.folderPathBox.Size = new System.Drawing.Size(565, 27);
            this.folderPathBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 516);
            this.Controls.Add(this.folderPathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.grabButton);
            this.Controls.Add(this.websiteBox);
            this.Name = "Form1";
            this.Text = "Grab Picture of Instagram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox websiteBox;
        private System.Windows.Forms.Button grabButton;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox folderPathBox;
    }
}

