using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Loesung
{
  public partial class Form1 : Form
  {

    public Form1()
    {
      InitializeComponent();
      
    }

    private void heightDescriptionLabel_Click(object sender, EventArgs e)
    {

    }

    private void calculateButton_Click(object sender, EventArgs e)
    {
      if (!double.TryParse(weightTextbox.Text, out double weight)
        || weight <= 0 || weight >500 || double.IsNaN(weight))
      {
        MessageBox.Show("Bitte gültiges Gewicht eingeben!");
        return;
      }
      if (!double.TryParse(heightTextbox.Text, out double height)
        || height <= 0 || height > 3 || double.IsNaN(height))
      {
        MessageBox.Show("Bitte gültige Grösse eingeben!");
        return;
      }

      bmiResultLabel.Text = (weight / (height * height)).ToString("F2");

    }

  }

}
