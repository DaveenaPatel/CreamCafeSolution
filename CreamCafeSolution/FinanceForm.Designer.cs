namespace CreamCafeSolution
{
    partial class FinanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceForm));
            this.financeLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.grossProfitButton = new System.Windows.Forms.Button();
            this.netProfitbutton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.revenueTextBox = new System.Windows.Forms.TextBox();
            this.revenueLabel = new System.Windows.Forms.Label();
            this.costOfGoodslabel = new System.Windows.Forms.Label();
            this.costOfGoodsTextBox = new System.Windows.Forms.TextBox();
            this.operatingExpensesLabel = new System.Windows.Forms.Label();
            this.operatingExpensesTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // financeLabel
            // 
            resources.ApplyResources(this.financeLabel, "financeLabel");
            this.financeLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.financeLabel.Name = "financeLabel";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.BackColor = System.Drawing.Color.Cornsilk;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // grossProfitButton
            // 
            resources.ApplyResources(this.grossProfitButton, "grossProfitButton");
            this.grossProfitButton.BackColor = System.Drawing.Color.Cornsilk;
            this.grossProfitButton.Name = "grossProfitButton";
            this.grossProfitButton.UseVisualStyleBackColor = false;
            this.grossProfitButton.Click += new System.EventHandler(this.grossProfitButton_Click);
            // 
            // netProfitbutton
            // 
            resources.ApplyResources(this.netProfitbutton, "netProfitbutton");
            this.netProfitbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.netProfitbutton.Name = "netProfitbutton";
            this.netProfitbutton.UseVisualStyleBackColor = false;
            this.netProfitbutton.Click += new System.EventHandler(this.netProfitbutton_Click);
            // 
            // totalCostLabel
            // 
            resources.ApplyResources(this.totalCostLabel, "totalCostLabel");
            this.totalCostLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.totalCostLabel.Name = "totalCostLabel";
            // 
            // totalCostTextBox
            // 
            resources.ApplyResources(this.totalCostTextBox, "totalCostTextBox");
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            // 
            // revenueTextBox
            // 
            resources.ApplyResources(this.revenueTextBox, "revenueTextBox");
            this.revenueTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.revenueTextBox.Name = "revenueTextBox";
            // 
            // revenueLabel
            // 
            resources.ApplyResources(this.revenueLabel, "revenueLabel");
            this.revenueLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.revenueLabel.Name = "revenueLabel";
            // 
            // costOfGoodslabel
            // 
            resources.ApplyResources(this.costOfGoodslabel, "costOfGoodslabel");
            this.costOfGoodslabel.BackColor = System.Drawing.Color.Cornsilk;
            this.costOfGoodslabel.Name = "costOfGoodslabel";
            // 
            // costOfGoodsTextBox
            // 
            resources.ApplyResources(this.costOfGoodsTextBox, "costOfGoodsTextBox");
            this.costOfGoodsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.costOfGoodsTextBox.Name = "costOfGoodsTextBox";
            // 
            // operatingExpensesLabel
            // 
            resources.ApplyResources(this.operatingExpensesLabel, "operatingExpensesLabel");
            this.operatingExpensesLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.operatingExpensesLabel.Name = "operatingExpensesLabel";
            // 
            // operatingExpensesTextBox
            // 
            resources.ApplyResources(this.operatingExpensesTextBox, "operatingExpensesTextBox");
            this.operatingExpensesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.operatingExpensesTextBox.Name = "operatingExpensesTextBox";
            // 
            // resultTextBox
            // 
            resources.ApplyResources(this.resultTextBox, "resultTextBox");
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FinanceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.operatingExpensesTextBox);
            this.Controls.Add(this.operatingExpensesLabel);
            this.Controls.Add(this.costOfGoodsTextBox);
            this.Controls.Add(this.costOfGoodslabel);
            this.Controls.Add(this.revenueLabel);
            this.Controls.Add(this.revenueTextBox);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.netProfitbutton);
            this.Controls.Add(this.grossProfitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.financeLabel);
            this.Name = "FinanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label financeLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button grossProfitButton;
        private System.Windows.Forms.Button netProfitbutton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.TextBox revenueTextBox;
        private System.Windows.Forms.Label revenueLabel;
        private System.Windows.Forms.Label costOfGoodslabel;
        private System.Windows.Forms.TextBox costOfGoodsTextBox;
        private System.Windows.Forms.Label operatingExpensesLabel;
        private System.Windows.Forms.TextBox operatingExpensesTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button button1;
    }
}