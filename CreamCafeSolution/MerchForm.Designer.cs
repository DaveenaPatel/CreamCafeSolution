namespace CreamCafeSolution
{
    partial class MerchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MerchForm));
            this.backButton = new System.Windows.Forms.Button();
            this.merchLabel = new System.Windows.Forms.Label();
            this.merchDataGridView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.merchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.BackColor = System.Drawing.Color.Cornsilk;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // merchLabel
            // 
            resources.ApplyResources(this.merchLabel, "merchLabel");
            this.merchLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.merchLabel.Name = "merchLabel";
            // 
            // merchDataGridView
            // 
            resources.ApplyResources(this.merchDataGridView, "merchDataGridView");
            this.merchDataGridView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.merchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.merchDataGridView.Name = "merchDataGridView";
            this.merchDataGridView.RowTemplate.Height = 24;
            // 
            // removeButton
            // 
            resources.ApplyResources(this.removeButton, "removeButton");
            this.removeButton.BackColor = System.Drawing.Color.Cornsilk;
            this.removeButton.Name = "removeButton";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            resources.ApplyResources(this.editButton, "editButton");
            this.editButton.BackColor = System.Drawing.Color.Cornsilk;
            this.editButton.Name = "editButton";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.BackColor = System.Drawing.Color.Cornsilk;
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            // quantityTextBox
            // 
            resources.ApplyResources(this.quantityTextBox, "quantityTextBox");
            this.quantityTextBox.Name = "quantityTextBox";
            // 
            // quantityLabel
            // 
            resources.ApplyResources(this.quantityLabel, "quantityLabel");
            this.quantityLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.quantityLabel.Name = "quantityLabel";
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
            // MerchForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.merchDataGridView);
            this.Controls.Add(this.merchLabel);
            this.Controls.Add(this.backButton);
            this.Name = "MerchForm";
            ((System.ComponentModel.ISupportInitialize)(this.merchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label merchLabel;
        private System.Windows.Forms.DataGridView merchDataGridView;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}