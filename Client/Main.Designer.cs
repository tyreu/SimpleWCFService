namespace Client
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNumberTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.secondNumberTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.CalcButton = new Telerik.WinControls.UI.RadButton();
            this.ResultLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(12, 12);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(55, 20);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(75, 12);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(55, 20);
            this.secondNumberTextBox.TabIndex = 1;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(136, 12);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(52, 20);
            this.CalcButton.TabIndex = 2;
            this.CalcButton.Text = "Calc sum";
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = false;
            this.ResultLabel.BorderVisible = true;
            this.ResultLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 38);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(176, 23);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Result:";
            this.ResultLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 69);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox firstNumberTextBox;
        private Telerik.WinControls.UI.RadTextBoxControl secondNumberTextBox;
        private Telerik.WinControls.UI.RadButton CalcButton;
        private Telerik.WinControls.UI.RadLabel ResultLabel;
    }
}

