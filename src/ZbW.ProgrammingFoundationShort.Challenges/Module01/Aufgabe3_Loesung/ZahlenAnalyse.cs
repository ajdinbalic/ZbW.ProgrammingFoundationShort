using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe3_Loesung
{
  public partial class ZahlenAnalyse : Form
  {
    public ZahlenAnalyse()
    {
      InitializeComponent();
    }

    private void CmdAnalysieren_Click(object sender, EventArgs e)
    {
      if (!int.TryParse(TxtZahl1.Text, out int zahl1)
        || !int.TryParse(TxtZahl2.Text, out int zahl2)
        || !int.TryParse(TxtZahl3.Text, out int zahl3))
      {
        MessageBox.Show("FALSCH");
        return;
      }
      // Summe aller Zahlen und Durchschnitt
      long sumTotal = (long)zahl1 + zahl2 + zahl3;
      double averageNumber = sumTotal / 3;

      // Grösste Zahl
      int biggestNumber = zahl1;
      if (zahl2 > biggestNumber)
      {
        biggestNumber = zahl2;
      }
      if (zahl3 > biggestNumber)
      {
        biggestNumber = zahl3;
      }

      // Kleinste Zahl
      int smallestNumber = zahl1;
      if (zahl2 < smallestNumber)
      {
        smallestNumber = zahl2;
      }
      if (zahl3 < smallestNumber)
      {
        smallestNumber = zahl3;
      }

      // Gerade oder Ungerade Zahl
      string straightOrNot;
      if (sumTotal % 2 == 0)
        {
        straightOrNot = "gerade";
      }
      else
      {
        straightOrNot = "ungerade";
      }
      LblSum.Text = $"Summe: {sumTotal}";
      LblAverage.Text = $"Durchschnitt: {averageNumber:F2}";
      LblBiggest.Text = $"Grösste Zahl: {biggestNumber}";
      LblSmallest.Text = $"Kleinste Zahl: {smallestNumber}";
      
    }
  }
}
