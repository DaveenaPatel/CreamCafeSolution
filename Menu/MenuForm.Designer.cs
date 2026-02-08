namespace Menu
{
    partial class menuForm
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
            this.employeeButton = new System.Windows.Forms.Button();
            this.financeButton = new System.Windows.Forms.Button();
            this.ingredienceButton = new System.Windows.Forms.Button();
            this.merchButton = new System.Windows.Forms.Button();
            this.recipesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeButton
            // 
            this.employeeButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F);
            this.employeeButton.Location = new System.Drawing.Point(145, 218);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(209, 76);
            this.employeeButton.TabIndex = 0;
            this.employeeButton.Text = "Employee";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // financeButton
            // 
            this.financeButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F);
            this.financeButton.Location = new System.Drawing.Point(440, 218);
            this.financeButton.Name = "financeButton";
            this.financeButton.Size = new System.Drawing.Size(209, 76);
            this.financeButton.TabIndex = 1;
            this.financeButton.Text = "Finance";
            this.financeButton.UseVisualStyleBackColor = true;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // ingredienceButton
            // 
            this.ingredienceButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F);
            this.ingredienceButton.Location = new System.Drawing.Point(451, 392);
            this.ingredienceButton.Name = "ingredienceButton";
            this.ingredienceButton.Size = new System.Drawing.Size(209, 76);
            this.ingredienceButton.TabIndex = 2;
            this.ingredienceButton.Text = "Ingredients";
            this.ingredienceButton.UseVisualStyleBackColor = true;
            this.ingredienceButton.Click += new System.EventHandler(this.ingredienceButton_Click);
            // 
            // merchButton
            // 
            this.merchButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F);
            this.merchButton.Location = new System.Drawing.Point(727, 218);
            this.merchButton.Name = "merchButton";
            this.merchButton.Size = new System.Drawing.Size(209, 76);
            this.merchButton.TabIndex = 3;
            this.merchButton.Text = "Merch";
            this.merchButton.UseVisualStyleBackColor = true;
            this.merchButton.Click += new System.EventHandler(this.merchButton_Click);
            // 
            // recipesButton
            // 
            this.recipesButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F);
            this.recipesButton.Location = new System.Drawing.Point(145, 392);
            this.recipesButton.Name = "recipesButton";
            this.recipesButton.Size = new System.Drawing.Size(209, 76);
            this.recipesButton.TabIndex = 4;
            this.recipesButton.Text = "Recipes";
            this.recipesButton.UseVisualStyleBackColor = true;
            this.recipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 19.8F);
            this.exitButton.Location = new System.Drawing.Point(739, 392);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(214, 76);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1098, 686);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.recipesButton);
            this.Controls.Add(this.merchButton);
            this.Controls.Add(this.ingredienceButton);
            this.Controls.Add(this.financeButton);
            this.Controls.Add(this.employeeButton);
            this.Name = "menuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button financeButton;
        private System.Windows.Forms.Button ingredienceButton;
        private System.Windows.Forms.Button merchButton;
        private System.Windows.Forms.Button recipesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

