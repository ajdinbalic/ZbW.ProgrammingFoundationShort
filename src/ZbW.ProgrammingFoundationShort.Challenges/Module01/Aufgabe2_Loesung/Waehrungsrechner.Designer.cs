namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Loesung
{
  partial class Waehrungsrechner
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
      chfToEurButton = new Button();
      eurToChfButton = new Button();
      label1 = new Label();
      valueTextbox = new TextBox();
      currentConversionRateLabel = new Label();
      resultLabel = new Label();
      label2 = new Label();
      SuspendLayout();
      // 
      // chfToEurButton
      // 
      chfToEurButton.Location = new Point(118, 116);
      chfToEurButton.Name = "chfToEurButton";
      chfToEurButton.Size = new Size(97, 23);
      chfToEurButton.TabIndex = 0;
      chfToEurButton.Text = "CHF zu EUR";
      chfToEurButton.UseVisualStyleBackColor = true;
      chfToEurButton.Click += chfToEurButton_Click;
      // 
      // eurToChfButton
      // 
      eurToChfButton.Location = new Point(278, 116);
      eurToChfButton.Name = "eurToChfButton";
      eurToChfButton.Size = new Size(97, 23);
      eurToChfButton.TabIndex = 1;
      eurToChfButton.Text = "EUR zu CHF";
      eurToChfButton.UseVisualStyleBackColor = true;
      eurToChfButton.Click += eurToChfButton_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 16F);
      label1.Location = new Point(151, 9);
      label1.Name = "label1";
      label1.Size = new Size(184, 30);
      label1.TabIndex = 2;
      label1.Text = "Währungsrechner";
      // 
      // valueTextbox
      // 
      valueTextbox.Location = new Point(118, 74);
      valueTextbox.Name = "valueTextbox";
      valueTextbox.Size = new Size(257, 23);
      valueTextbox.TabIndex = 3;
      valueTextbox.TextAlign = HorizontalAlignment.Center;
      // 
      // currentConversionRateLabel
      // 
      currentConversionRateLabel.AutoSize = true;
      currentConversionRateLabel.ForeColor = Color.Gray;
      currentConversionRateLabel.Location = new Point(158, 56);
      currentConversionRateLabel.Name = "currentConversionRateLabel";
      currentConversionRateLabel.Size = new Size(177, 15);
      currentConversionRateLabel.TabIndex = 4;
      currentConversionRateLabel.Text = "Währungskurs 1 EUR = 1.05 CHF";
      // 
      // resultLabel
      // 
      resultLabel.AutoSize = true;
      resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      resultLabel.Location = new Point(118, 155);
      resultLabel.Name = "resultLabel";
      resultLabel.Size = new Size(262, 21);
      resultLabel.TabIndex = 5;
      resultLabel.Text = "____________________________________";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label2.Location = new Point(48, 155);
      label2.Name = "label2";
      label2.Size = new Size(64, 21);
      label2.TabIndex = 6;
      label2.Text = "Betrag:";
      // 
      // Waehrungsrechner
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(490, 197);
      Controls.Add(label2);
      Controls.Add(resultLabel);
      Controls.Add(currentConversionRateLabel);
      Controls.Add(valueTextbox);
      Controls.Add(label1);
      Controls.Add(eurToChfButton);
      Controls.Add(chfToEurButton);
      Name = "Waehrungsrechner";
      Text = "Waehrungsrechner";
      Load += Waehrungsrechner_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button chfToEurButton;
    private Button eurToChfButton;
    private Label label1;
    private TextBox valueTextbox;
    private Label currentConversionRateLabel;
    private Label resultLabel;
    private Label label2;
  }
}
