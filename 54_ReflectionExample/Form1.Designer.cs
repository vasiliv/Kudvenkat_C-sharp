
namespace _54_ReflectionExample
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
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnDiscoverTypeInformation = new System.Windows.Forms.Button();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lstConstructors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(65, 25);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(100, 20);
            this.txtTypeName.TabIndex = 0;
            // 
            // btnDiscoverTypeInformation
            // 
            this.btnDiscoverTypeInformation.Location = new System.Drawing.Point(642, 25);
            this.btnDiscoverTypeInformation.Name = "btnDiscoverTypeInformation";
            this.btnDiscoverTypeInformation.Size = new System.Drawing.Size(75, 23);
            this.btnDiscoverTypeInformation.TabIndex = 1;
            this.btnDiscoverTypeInformation.Text = "Discover";
            this.btnDiscoverTypeInformation.UseVisualStyleBackColor = true;
            this.btnDiscoverTypeInformation.Click += new System.EventHandler(this.btnDiscoverTypeInformation_Click);
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.Location = new System.Drawing.Point(65, 66);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(179, 277);
            this.lstMethods.TabIndex = 2;
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.Location = new System.Drawing.Point(291, 66);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(199, 277);
            this.lstProperties.TabIndex = 3;
            // 
            // lstConstructors
            // 
            this.lstConstructors.FormattingEnabled = true;
            this.lstConstructors.Location = new System.Drawing.Point(521, 66);
            this.lstConstructors.Name = "lstConstructors";
            this.lstConstructors.Size = new System.Drawing.Size(196, 277);
            this.lstConstructors.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstConstructors);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstMethods);
            this.Controls.Add(this.btnDiscoverTypeInformation);
            this.Controls.Add(this.txtTypeName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnDiscoverTypeInformation;
        private System.Windows.Forms.ListBox lstMethods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.ListBox lstConstructors;
    }
}

