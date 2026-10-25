namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe3_Loesung
{
  partial class ZahlenAnalyse
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
      LblZahl1 = new Label();
      TxtZahl1 = new TextBox();
      LblZahl2 = new Label();
      TxtZahl2 = new TextBox();
      LblZahl3 = new Label();
      TxtZahl3 = new TextBox();
      CmdAnalysieren = new Button();
      LblSum = new Label();
      LblAverage = new Label();
      LblBiggest = new Label();
      LblSmallest = new Label();
      LblStraight = new Label();
      SuspendLayout();
      // 
      // LblZahl1
      // 
      LblZahl1.AutoSize = true;
      LblZahl1.Location = new Point(22, 43);
      LblZahl1.Margin = new Padding(6, 0, 6, 0);
      LblZahl1.Name = "LblZahl1";
      LblZahl1.Size = new Size(85, 32);
      LblZahl1.TabIndex = 7;
      LblZahl1.Text = "Zahl 1:";
      // 
      // TxtZahl1
      // 
      TxtZahl1.Location = new Point(149, 36);
      TxtZahl1.Margin = new Padding(6);
      TxtZahl1.Name = "TxtZahl1";
      TxtZahl1.Size = new Size(145, 39);
      TxtZahl1.TabIndex = 8;
      // 
      // LblZahl2
      // 
      LblZahl2.AutoSize = true;
      LblZahl2.Location = new Point(22, 111);
      LblZahl2.Margin = new Padding(6, 0, 6, 0);
      LblZahl2.Name = "LblZahl2";
      LblZahl2.Size = new Size(85, 32);
      LblZahl2.TabIndex = 9;
      LblZahl2.Text = "Zahl 2:";
      // 
      // TxtZahl2
      // 
      TxtZahl2.Location = new Point(149, 105);
      TxtZahl2.Margin = new Padding(6);
      TxtZahl2.Name = "TxtZahl2";
      TxtZahl2.Size = new Size(145, 39);
      TxtZahl2.TabIndex = 10;
      // 
      // LblZahl3
      // 
      LblZahl3.AutoSize = true;
      LblZahl3.Location = new Point(22, 179);
      LblZahl3.Margin = new Padding(6, 0, 6, 0);
      LblZahl3.Name = "LblZahl3";
      LblZahl3.Size = new Size(85, 32);
      LblZahl3.TabIndex = 11;
      LblZahl3.Text = "Zahl 3:";
      // 
      // TxtZahl3
      // 
      TxtZahl3.Location = new Point(149, 173);
      TxtZahl3.Margin = new Padding(6);
      TxtZahl3.Name = "TxtZahl3";
      TxtZahl3.Size = new Size(145, 39);
      TxtZahl3.TabIndex = 12;
      // 
      // CmdAnalysieren
      // 
      CmdAnalysieren.Location = new Point(149, 250);
      CmdAnalysieren.Margin = new Padding(6);
      CmdAnalysieren.Name = "CmdAnalysieren";
      CmdAnalysieren.Size = new Size(241, 60);
      CmdAnalysieren.TabIndex = 13;
      CmdAnalysieren.Text = "Analysieren";
      CmdAnalysieren.Click += CmdAnalysieren_Click;
      // 
      // LblSum
      // 
      LblSum.AutoSize = true;
      LblSum.Location = new Point(22, 374);
      LblSum.Name = "LblSum";
      LblSum.Size = new Size(108, 32);
      LblSum.TabIndex = 14;
      LblSum.Text = "Summe: ";
      // 
      // LblAverage
      // 
      LblAverage.AutoSize = true;
      LblAverage.Location = new Point(22, 425);
      LblAverage.Name = "LblAverage";
      LblAverage.Size = new Size(161, 32);
      LblAverage.TabIndex = 15;
      LblAverage.Text = "Durchschnitt: ";
      // 
      // LblBiggest
      // 
      LblBiggest.AutoSize = true;
      LblBiggest.Location = new Point(22, 474);
      LblBiggest.Name = "LblBiggest";
      LblBiggest.Size = new Size(158, 32);
      LblBiggest.TabIndex = 16;
      LblBiggest.Text = "Grösste Zahl: ";
      // 
      // LblSmallest
      // 
      LblSmallest.AutoSize = true;
      LblSmallest.Location = new Point(22, 520);
      LblSmallest.Name = "LblSmallest";
      LblSmallest.Size = new Size(163, 32);
      LblSmallest.TabIndex = 17;
      LblSmallest.Text = "Kleinste Zahl: ";
      // 
      // LblStraight
      // 
      LblStraight.AutoSize = true;
      LblStraight.Location = new Point(22, 566);
      LblStraight.Name = "LblStraight";
      LblStraight.Size = new Size(267, 32);
      LblStraight.TabIndex = 18;
      LblStraight.Text = "Gerade oder ungerade: ";
      // 
      // ZahlenAnalyse
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(466, 708);
      Controls.Add(LblStraight);
      Controls.Add(LblSmallest);
      Controls.Add(LblBiggest);
      Controls.Add(LblAverage);
      Controls.Add(LblSum);
      Controls.Add(LblZahl1);
      Controls.Add(TxtZahl1);
      Controls.Add(LblZahl2);
      Controls.Add(TxtZahl2);
      Controls.Add(LblZahl3);
      Controls.Add(TxtZahl3);
      Controls.Add(CmdAnalysieren);
      Margin = new Padding(6);
      Name = "ZahlenAnalyse";
      Text = "ZahlenAnalyse";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LblZahl1;
    private TextBox TxtZahl1;
    private Label LblZahl2;
    private TextBox TxtZahl2;
    private Label LblZahl3;
    private TextBox TxtZahl3;
    private Button CmdAnalysieren;
    private Label LblSum;
    private Label LblAverage;
    private Label LblBiggest;
    private Label LblSmallest;
    private Label LblStraight;
  }
}