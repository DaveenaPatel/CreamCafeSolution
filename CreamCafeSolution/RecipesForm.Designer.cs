namespace CreamCafeSolution
{
    partial class RecipesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipesForm));
            this.printButton = new System.Windows.Forms.Button();
            this.RecipesLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ingredientTextBox = new System.Windows.Forms.TextBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.expectedProfitLabel = new System.Windows.Forms.Label();
            this.expectedProfitTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // printButton
            // 
            resources.ApplyResources(this.printButton, "printButton");
            this.printButton.BackColor = System.Drawing.Color.Cornsilk;
            this.printButton.Name = "printButton";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // RecipesLabel
            // 
            resources.ApplyResources(this.RecipesLabel, "RecipesLabel");
            this.RecipesLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.RecipesLabel.Name = "RecipesLabel";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.BackColor = System.Drawing.Color.Cornsilk;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // idTextBox
            // 
            resources.ApplyResources(this.idTextBox, "idTextBox");
            this.idTextBox.Name = "idTextBox";
            // 
            // idLabel
            // 
            resources.ApplyResources(this.idLabel, "idLabel");
            this.idLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.idLabel.Name = "idLabel";
            // 
            // costTextBox
            // 
            resources.ApplyResources(this.costTextBox, "costTextBox");
            this.costTextBox.Name = "costTextBox";
            // 
            // costLabel
            // 
            resources.ApplyResources(this.costLabel, "costLabel");
            this.costLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.costLabel.Name = "costLabel";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.nameLabel.Name = "nameLabel";
            // 
            // ingredientTextBox
            // 
            resources.ApplyResources(this.ingredientTextBox, "ingredientTextBox");
            this.ingredientTextBox.Name = "ingredientTextBox";
            // 
            // ingredientsLabel
            // 
            resources.ApplyResources(this.ingredientsLabel, "ingredientsLabel");
            this.ingredientsLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.ingredientsLabel.Name = "ingredientsLabel";
            // 
            // expectedProfitLabel
            // 
            resources.ApplyResources(this.expectedProfitLabel, "expectedProfitLabel");
            this.expectedProfitLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.expectedProfitLabel.Name = "expectedProfitLabel";
            // 
            // expectedProfitTextBox
            // 
            resources.ApplyResources(this.expectedProfitTextBox, "expectedProfitTextBox");
            this.expectedProfitTextBox.Name = "expectedProfitTextBox";
            // 
            // RecipesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.ingredientTextBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.expectedProfitTextBox);
            this.Controls.Add(this.expectedProfitLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.RecipesLabel);
            this.Name = "RecipesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label RecipesLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox ingredientTextBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label expectedProfitLabel;
        private System.Windows.Forms.TextBox expectedProfitTextBox;
    }
}