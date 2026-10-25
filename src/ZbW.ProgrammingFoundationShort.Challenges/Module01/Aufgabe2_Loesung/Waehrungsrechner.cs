using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Loesung
{
  public partial class Waehrungsrechner : Form
  {
    public Waehrungsrechner()
    {
      InitializeComponent();
    }
    private const decimal chfToEurRate = 1.05m;
    private void chfToEurButton_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(valueTextbox.Text, out decimal value)
        || value <= 0 || value > 1000000)
      {
        MessageBox.Show("Bitte einen gültigen Betrag eingeben (min. 1, max. 1'000'000)",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      decimal endResult = value / chfToEurRate;
      resultLabel.Text = $"{valueTextbox.Text} CHF ist {endResult:F2}" + " EUR";
    }

    private void eurToChfButton_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(valueTextbox.Text, out decimal value)
        || value <= 0 || value > 1000000)
      {
        MessageBox.Show("Bitte einen gültigen Betrag eingeben (min. 1, max. 1'000'000)",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      decimal endResult = value * chfToEurRate;
      resultLabel.Text = $"{valueTextbox.Text} EUR ist {endResult:F2}" + " CHF";
    }

    private void Waehrungsrechner_Load(object sender, EventArgs e)
    {

    }
  }
}
