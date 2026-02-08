namespace CreamCafeSolution
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.recipesButton = new System.Windows.Forms.Button();
            this.merchButton = new System.Windows.Forms.Button();
            this.ingredienceButton = new System.Windows.Forms.Button();
            this.financeButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.Cornsilk;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // recipesButton
            // 
            resources.ApplyResources(this.recipesButton, "recipesButton");
            this.recipesButton.BackColor = System.Drawing.Color.Cornsilk;
            this.recipesButton.Name = "recipesButton";
            this.recipesButton.UseVisualStyleBackColor = false;
            this.recipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // merchButton
            // 
            resources.ApplyResources(this.merchButton, "merchButton");
            this.merchButton.BackColor = System.Drawing.Color.Cornsilk;
            this.merchButton.Name = "merchButton";
            this.merchButton.UseVisualStyleBackColor = false;
            this.merchButton.Click += new System.EventHandler(this.merchButton_Click);
            // 
            // ingredienceButton
            // 
            resources.ApplyResources(this.ingredienceButton, "ingredienceButton");
            this.ingredienceButton.BackColor = System.Drawing.Color.Cornsilk;
            this.ingredienceButton.Name = "ingredienceButton";
            this.ingredienceButton.UseVisualStyleBackColor = false;
            this.ingredienceButton.Click += new System.EventHandler(this.ingredienceButton_Click);
            // 
            // financeButton
            // 
            resources.ApplyResources(this.financeButton, "financeButton");
            this.financeButton.BackColor = System.Drawing.Color.Cornsilk;
            this.financeButton.Name = "financeButton";
            this.financeButton.UseVisualStyleBackColor = false;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // employeeButton
            // 
            resources.ApplyResources(this.employeeButton, "employeeButton");
            this.employeeButton.BackColor = System.Drawing.Color.Cornsilk;
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // MenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.recipesButton);
            this.Controls.Add(this.merchButton);
            this.Controls.Add(this.ingredienceButton);
            this.Controls.Add(this.financeButton);
            this.Controls.Add(this.employeeButton);
            this.Name = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button recipesButton;
        private System.Windows.Forms.Button merchButton;
        private System.Windows.Forms.Button ingredienceButton;
        private System.Windows.Forms.Button financeButton;
        private System.Windows.Forms.Button employeeButton;
    }
}