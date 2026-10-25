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
      SuspendLayout();
      // 
      // LblZahl1
      // 
      LblZahl1.AutoSize = true;
      LblZahl1.Location = new Point(12, 20);
      LblZahl1.Name = "LblZahl1";
      LblZahl1.Size = new Size(42, 15);
      LblZahl1.TabIndex = 7;
      LblZahl1.Text = "Zahl 1:";
      // 
      // TxtZahl1
      // 
      TxtZahl1.Location = new Point(80, 17);
      TxtZahl1.Name = "TxtZahl1";
      TxtZahl1.Size = new Size(80, 23);
      TxtZahl1.TabIndex = 8;
      // 
      // LblZahl2
      // 
      LblZahl2.AutoSize = true;
      LblZahl2.Location = new Point(12, 52);
      LblZahl2.Name = "LblZahl2";
      LblZahl2.Size = new Size(42, 15);
      LblZahl2.TabIndex = 9;
      LblZahl2.Text = "Zahl 2:";
      // 
      // TxtZahl2
      // 
      TxtZahl2.Location = new Point(80, 49);
      TxtZahl2.Name = "TxtZahl2";
      TxtZahl2.Size = new Size(80, 23);
      TxtZahl2.TabIndex = 10;
      // 
      // LblZahl3
      // 
      LblZahl3.AutoSize = true;
      LblZahl3.Location = new Point(12, 84);
      LblZahl3.Name = "LblZahl3";
      LblZahl3.Size = new Size(42, 15);
      LblZahl3.TabIndex = 11;
      LblZahl3.Text = "Zahl 3:";
      // 
      // TxtZahl3
      // 
      TxtZahl3.Location = new Point(80, 81);
      TxtZahl3.Name = "TxtZahl3";
      TxtZahl3.Size = new Size(80, 23);
      TxtZahl3.TabIndex = 12;
      // 
      // CmdAnalysieren
      // 
      CmdAnalysieren.Location = new Point(80, 117);
      CmdAnalysieren.Name = "CmdAnalysieren";
      CmdAnalysieren.Size = new Size(130, 28);
      CmdAnalysieren.TabIndex = 13;
      CmdAnalysieren.Text = "Analysieren";
      CmdAnalysieren.Click += CmdAnalysieren_Click;
      // 
      // ZahlenAnalyse
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(251, 332);
      Controls.Add(LblZahl1);
      Controls.Add(TxtZahl1);
      Controls.Add(LblZahl2);
      Controls.Add(TxtZahl2);
      Controls.Add(LblZahl3);
      Controls.Add(TxtZahl3);
      Controls.Add(CmdAnalysieren);
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
  }
}