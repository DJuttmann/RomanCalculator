using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanCalculator
{
  public partial class Form1: Form
  {
    private enum ProgramState
    {
      TakingLhsInput,
      TakingRhsInput
    }

    private uint InputLhs = 0; // Left hand side input
    private uint InputRhs = 0; // Right hand side input
    private RomanNumerals.Operator Op = RomanNumerals.Operator.Add;
    private ProgramState State = ProgramState.TakingLhsInput;


    // METHODS

    public Form1 ()
    {
      InitializeComponent ();
      ClearEvaluation ();
    }


    // Clear all labels that display the current calculation.
    private void ClearEvaluation ()
    {
      labelLHS.Text = "";
      labelOperator.Text = "";
      labelRHS.Text = "";
      labelEquals.Text = "";
      labelAnswer.Text = "";
    }


    // Add a character at the end of the input string.
    private void AddCharacter (char c)
    {
      StringBuilder str = new StringBuilder (textBoxInput.Text);
      str.Append (c);
      string newInput = str.ToString ();
      if (RomanNumerals.ValidateRomanNumeral (newInput))
        textBoxInput.Text = newInput;
    }


    // Letter/Delete button handlers.
    private void buttonI_Click (object sender, EventArgs e)
    {
      AddCharacter ('I');
    }

    private void buttonV_Click (object sender, EventArgs e)
    {
      AddCharacter ('V');
    }

    private void buttonX_Click (object sender, EventArgs e)
    {
      AddCharacter ('X');
    }

    private void buttonL_Click (object sender, EventArgs e)
    {
      AddCharacter ('L');
    }

    private void buttonC_Click (object sender, EventArgs e)
    {
      AddCharacter ('C');
    }

    private void buttonD_Click (object sender, EventArgs e)
    {
      AddCharacter ('D');
    }

    private void buttonM_Click (object sender, EventArgs e)
    {
      AddCharacter ('M');
    }

    private void buttonDel_Click (object sender, EventArgs e)
    {
      int lenght = textBoxInput.Text.Length;
      if (lenght > 0)
        textBoxInput.Text = textBoxInput.Text.Substring (0, lenght - 1);
    }


    // Store LHS value, update calculator display.
    private void SetLhs ()
    {
      ClearEvaluation ();
      InputLhs = RomanNumerals.RomanToInt (textBoxInput.Text);
      labelLHS.Text = (textBoxInput.Text == "" ? RomanNumerals.RomanZero
                                               : textBoxInput.Text);
      textBoxInput.Text = "";
      State = ProgramState.TakingRhsInput;
    }


    // Store RHS value, update calculator display.
    private void SetRhs ()
    {
      InputRhs = RomanNumerals.RomanToInt (textBoxInput.Text);
      labelRHS.Text = (textBoxInput.Text == "" ? RomanNumerals.RomanZero
                                               : textBoxInput.Text);
      textBoxInput.Text = "";
      State = ProgramState.TakingLhsInput;
    }


    // Operation/Evaluate/Clear button handlers.
    private void buttonAdd_Click (object sender, EventArgs e)
    {
      if (State == ProgramState.TakingLhsInput)
      {
        SetLhs ();
        Op = RomanNumerals.Operator.Add;
        labelOperator.Text = "+";
      }
    }

    private void buttonSubtract_Click (object sender, EventArgs e)
    {
      if (State == ProgramState.TakingLhsInput)
      {
        SetLhs ();
        Op = RomanNumerals.Operator.Subtract;
        labelOperator.Text = "-";
      }
    }

    private void buttonMultiply_Click (object sender, EventArgs e)
    {
      if (State == ProgramState.TakingLhsInput)
      {
        SetLhs ();
        Op = RomanNumerals.Operator.Multiply;
        labelOperator.Text = "*";
      }
    }

    private void buttonDivide_Click (object sender, EventArgs e)
    {
      if (State == ProgramState.TakingLhsInput)
      {
        SetLhs ();
        Op = RomanNumerals.Operator.Divide;
        labelOperator.Text = "/";
      }
    }

    private void buttonEvaluate_Click (object sender, EventArgs e)
    {
      if (State == ProgramState.TakingRhsInput)
      {
        SetRhs ();
        labelEquals.Text = "=";
        labelAnswer.Text = RomanNumerals.Evaluate (InputLhs, InputRhs, Op);
        textBoxInput.Text = "";
        State = ProgramState.TakingLhsInput;
      }
    }

    private void buttonClearAll_Click (object sender, EventArgs e)
    {
      ClearEvaluation ();
      State = ProgramState.TakingLhsInput;
      textBoxInput.Text = "";
    }
  }
}
