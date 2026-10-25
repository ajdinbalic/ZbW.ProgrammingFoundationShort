namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Loesung
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
      titleLabel = new Label();
      weightTitleLabel = new Label();
      heightTitleLabel = new Label();
      calculateButton = new Button();
      weightTextbox = new TextBox();
      heightTextbox = new TextBox();
      bmiResultLabel = new Label();
      SuspendLayout();
      // 
      // titleLabel
      // 
      titleLabel.AutoSize = true;
      titleLabel.Font = new Font("Segoe UI", 16F);
      titleLabel.Location = new Point(321, 35);
      titleLabel.Name = "titleLabel";
      titleLabel.Size = new Size(136, 30);
      titleLabel.TabIndex = 0;
      titleLabel.Text = "BMI Rechner";
      // 
      // weightTitleLabel
      // 
      weightTitleLabel.AutoSize = true;
      weightTitleLabel.Location = new Point(356, 110);
      weightTitleLabel.Name = "weightTitleLabel";
      weightTitleLabel.Size = new Size(50, 15);
      weightTitleLabel.TabIndex = 1;
      weightTitleLabel.Text = "Gewicht";
      // 
      // heightTitleLabel
      // 
      heightTitleLabel.AutoSize = true;
      heightTitleLabel.Location = new Point(356, 264);
      heightTitleLabel.Name = "heightTitleLabel";
      heightTitleLabel.Size = new Size(69, 15);
      heightTitleLabel.TabIndex = 3;
      heightTitleLabel.Text = "Grösse in m";
      // 
      // calculateButton
      // 
      calculateButton.Font = new Font("Segoe UI", 12F);
      calculateButton.Location = new Point(321, 396);
      calculateButton.Name = "calculateButton";
      calculateButton.Size = new Size(167, 42);
      calculateButton.TabIndex = 5;
      calculateButton.Text = "Berechnen";
      calculateButton.UseVisualStyleBackColor = true;
      calculateButton.Click += calculateButton_Click;
      // 
      // weightTextbox
      // 
      weightTextbox.Location = new Point(336, 138);
      weightTextbox.Name = "weightTextbox";
      weightTextbox.Size = new Size(100, 23);
      weightTextbox.TabIndex = 6;
      // 
      // heightTextbox
      // 
      heightTextbox.Location = new Point(336, 282);
      heightTextbox.Name = "heightTextbox";
      heightTextbox.Size = new Size(100, 23);
      heightTextbox.TabIndex = 7;
      // 
      // bmiResultLabel
      // 
      bmiResultLabel.AutoSize = true;
      bmiResultLabel.Location = new Point(58, 337);
      bmiResultLabel.Name = "bmiResultLabel";
      bmiResultLabel.Size = new Size(38, 15);
      bmiResultLabel.TabIndex = 8;
      bmiResultLabel.Text = "label1";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(bmiResultLabel);
      Controls.Add(heightTextbox);
      Controls.Add(weightTextbox);
      Controls.Add(calculateButton);
      Controls.Add(heightTitleLabel);
      Controls.Add(weightTitleLabel);
      Controls.Add(titleLabel);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label titleLabel;
    private Label weightTitleLabel;
    private Label label3;
    private Label heightTitleLabel;
    private Label label5;
    private Button calculateButton;
    private TextBox weightTextbox;
    private TextBox heightTextbox;
    private Label bmiResultLabel;
  }
}
