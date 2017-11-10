namespace RomanCalculator
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
    protected override void Dispose (bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose ();
      }
      base.Dispose (disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ()
    {
      this.textBoxInput = new System.Windows.Forms.TextBox();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonSubtract = new System.Windows.Forms.Button();
      this.buttonMultiply = new System.Windows.Forms.Button();
      this.buttonDivide = new System.Windows.Forms.Button();
      this.buttonEvaluate = new System.Windows.Forms.Button();
      this.labelLHS = new System.Windows.Forms.Label();
      this.labelOperator = new System.Windows.Forms.Label();
      this.labelRHS = new System.Windows.Forms.Label();
      this.labelEquals = new System.Windows.Forms.Label();
      this.labelAnswer = new System.Windows.Forms.Label();
      this.buttonDel = new System.Windows.Forms.Button();
      this.buttonI = new System.Windows.Forms.Button();
      this.buttonV = new System.Windows.Forms.Button();
      this.buttonX = new System.Windows.Forms.Button();
      this.buttonL = new System.Windows.Forms.Button();
      this.buttonM = new System.Windows.Forms.Button();
      this.buttonD = new System.Windows.Forms.Button();
      this.buttonC = new System.Windows.Forms.Button();
      this.buttonClearAll = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxInput
      // 
      this.textBoxInput.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxInput.Location = new System.Drawing.Point(12, 12);
      this.textBoxInput.Name = "textBoxInput";
      this.textBoxInput.ReadOnly = true;
      this.textBoxInput.Size = new System.Drawing.Size(368, 34);
      this.textBoxInput.TabIndex = 0;
      this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
      // 
      // buttonAdd
      // 
      this.buttonAdd.BackColor = System.Drawing.Color.PaleGreen;
      this.buttonAdd.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonAdd.Location = new System.Drawing.Point(34, 183);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(43, 42);
      this.buttonAdd.TabIndex = 1;
      this.buttonAdd.Text = "+";
      this.buttonAdd.UseVisualStyleBackColor = false;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // buttonSubtract
      // 
      this.buttonSubtract.BackColor = System.Drawing.Color.PaleGreen;
      this.buttonSubtract.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonSubtract.Location = new System.Drawing.Point(93, 183);
      this.buttonSubtract.Name = "buttonSubtract";
      this.buttonSubtract.Size = new System.Drawing.Size(43, 42);
      this.buttonSubtract.TabIndex = 2;
      this.buttonSubtract.Text = "‒";
      this.buttonSubtract.UseVisualStyleBackColor = false;
      this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
      // 
      // buttonMultiply
      // 
      this.buttonMultiply.BackColor = System.Drawing.Color.PaleGreen;
      this.buttonMultiply.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonMultiply.Location = new System.Drawing.Point(152, 183);
      this.buttonMultiply.Name = "buttonMultiply";
      this.buttonMultiply.Size = new System.Drawing.Size(43, 42);
      this.buttonMultiply.TabIndex = 3;
      this.buttonMultiply.Text = "×";
      this.buttonMultiply.UseVisualStyleBackColor = false;
      this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
      // 
      // buttonDivide
      // 
      this.buttonDivide.BackColor = System.Drawing.Color.PaleGreen;
      this.buttonDivide.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDivide.Location = new System.Drawing.Point(211, 183);
      this.buttonDivide.Name = "buttonDivide";
      this.buttonDivide.Size = new System.Drawing.Size(43, 42);
      this.buttonDivide.TabIndex = 4;
      this.buttonDivide.Text = "÷";
      this.buttonDivide.UseVisualStyleBackColor = false;
      this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
      // 
      // buttonEvaluate
      // 
      this.buttonEvaluate.BackColor = System.Drawing.Color.LightSalmon;
      this.buttonEvaluate.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonEvaluate.Location = new System.Drawing.Point(291, 183);
      this.buttonEvaluate.Name = "buttonEvaluate";
      this.buttonEvaluate.Size = new System.Drawing.Size(64, 42);
      this.buttonEvaluate.TabIndex = 5;
      this.buttonEvaluate.Text = "=";
      this.buttonEvaluate.UseVisualStyleBackColor = false;
      this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
      // 
      // labelLHS
      // 
      this.labelLHS.AutoSize = true;
      this.labelLHS.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelLHS.Location = new System.Drawing.Point(7, 241);
      this.labelLHS.Name = "labelLHS";
      this.labelLHS.Size = new System.Drawing.Size(96, 27);
      this.labelLHS.TabIndex = 6;
      this.labelLHS.Text = "label1";
      // 
      // labelOperator
      // 
      this.labelOperator.AutoSize = true;
      this.labelOperator.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelOperator.Location = new System.Drawing.Point(7, 268);
      this.labelOperator.Name = "labelOperator";
      this.labelOperator.Size = new System.Drawing.Size(96, 27);
      this.labelOperator.TabIndex = 7;
      this.labelOperator.Text = "label2";
      // 
      // labelRHS
      // 
      this.labelRHS.AutoSize = true;
      this.labelRHS.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelRHS.Location = new System.Drawing.Point(7, 295);
      this.labelRHS.Name = "labelRHS";
      this.labelRHS.Size = new System.Drawing.Size(96, 27);
      this.labelRHS.TabIndex = 8;
      this.labelRHS.Text = "label3";
      // 
      // labelEquals
      // 
      this.labelEquals.AutoSize = true;
      this.labelEquals.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEquals.Location = new System.Drawing.Point(7, 322);
      this.labelEquals.Name = "labelEquals";
      this.labelEquals.Size = new System.Drawing.Size(96, 27);
      this.labelEquals.TabIndex = 9;
      this.labelEquals.Text = "label4";
      // 
      // labelAnswer
      // 
      this.labelAnswer.AutoSize = true;
      this.labelAnswer.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelAnswer.Location = new System.Drawing.Point(7, 349);
      this.labelAnswer.Name = "labelAnswer";
      this.labelAnswer.Size = new System.Drawing.Size(96, 27);
      this.labelAnswer.TabIndex = 10;
      this.labelAnswer.Text = "label5";
      // 
      // buttonDel
      // 
      this.buttonDel.BackColor = System.Drawing.Color.LightSalmon;
      this.buttonDel.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDel.Location = new System.Drawing.Point(291, 63);
      this.buttonDel.Name = "buttonDel";
      this.buttonDel.Size = new System.Drawing.Size(64, 42);
      this.buttonDel.TabIndex = 11;
      this.buttonDel.Text = "<";
      this.buttonDel.UseVisualStyleBackColor = false;
      this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
      // 
      // buttonI
      // 
      this.buttonI.BackColor = System.Drawing.Color.Lavender;
      this.buttonI.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonI.Location = new System.Drawing.Point(34, 63);
      this.buttonI.Name = "buttonI";
      this.buttonI.Size = new System.Drawing.Size(43, 42);
      this.buttonI.TabIndex = 12;
      this.buttonI.Text = "I";
      this.buttonI.UseVisualStyleBackColor = false;
      this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
      // 
      // buttonV
      // 
      this.buttonV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
      this.buttonV.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonV.Location = new System.Drawing.Point(93, 63);
      this.buttonV.Name = "buttonV";
      this.buttonV.Size = new System.Drawing.Size(43, 42);
      this.buttonV.TabIndex = 13;
      this.buttonV.Text = "V";
      this.buttonV.UseVisualStyleBackColor = false;
      this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
      // 
      // buttonX
      // 
      this.buttonX.BackColor = System.Drawing.Color.Lavender;
      this.buttonX.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonX.Location = new System.Drawing.Point(152, 63);
      this.buttonX.Name = "buttonX";
      this.buttonX.Size = new System.Drawing.Size(43, 42);
      this.buttonX.TabIndex = 14;
      this.buttonX.Text = "X";
      this.buttonX.UseVisualStyleBackColor = false;
      this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
      // 
      // buttonL
      // 
      this.buttonL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
      this.buttonL.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonL.Location = new System.Drawing.Point(211, 63);
      this.buttonL.Name = "buttonL";
      this.buttonL.Size = new System.Drawing.Size(43, 42);
      this.buttonL.TabIndex = 15;
      this.buttonL.Text = "L";
      this.buttonL.UseVisualStyleBackColor = false;
      this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
      // 
      // buttonM
      // 
      this.buttonM.BackColor = System.Drawing.Color.Lavender;
      this.buttonM.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonM.Location = new System.Drawing.Point(152, 123);
      this.buttonM.Name = "buttonM";
      this.buttonM.Size = new System.Drawing.Size(43, 42);
      this.buttonM.TabIndex = 18;
      this.buttonM.Text = "M";
      this.buttonM.UseVisualStyleBackColor = false;
      this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
      // 
      // buttonD
      // 
      this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
      this.buttonD.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonD.Location = new System.Drawing.Point(93, 123);
      this.buttonD.Name = "buttonD";
      this.buttonD.Size = new System.Drawing.Size(43, 42);
      this.buttonD.TabIndex = 17;
      this.buttonD.Text = "D";
      this.buttonD.UseVisualStyleBackColor = false;
      this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
      // 
      // buttonC
      // 
      this.buttonC.BackColor = System.Drawing.Color.Lavender;
      this.buttonC.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonC.Location = new System.Drawing.Point(34, 123);
      this.buttonC.Name = "buttonC";
      this.buttonC.Size = new System.Drawing.Size(43, 42);
      this.buttonC.TabIndex = 16;
      this.buttonC.Text = "C";
      this.buttonC.UseVisualStyleBackColor = false;
      this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
      // 
      // buttonClearAll
      // 
      this.buttonClearAll.BackColor = System.Drawing.Color.LightSalmon;
      this.buttonClearAll.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonClearAll.Location = new System.Drawing.Point(291, 123);
      this.buttonClearAll.Name = "buttonClearAll";
      this.buttonClearAll.Size = new System.Drawing.Size(64, 42);
      this.buttonClearAll.TabIndex = 19;
      this.buttonClearAll.Text = "CA";
      this.buttonClearAll.UseVisualStyleBackColor = false;
      this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(392, 392);
      this.Controls.Add(this.buttonClearAll);
      this.Controls.Add(this.buttonM);
      this.Controls.Add(this.buttonD);
      this.Controls.Add(this.buttonC);
      this.Controls.Add(this.buttonL);
      this.Controls.Add(this.buttonX);
      this.Controls.Add(this.buttonV);
      this.Controls.Add(this.buttonI);
      this.Controls.Add(this.buttonDel);
      this.Controls.Add(this.labelAnswer);
      this.Controls.Add(this.labelEquals);
      this.Controls.Add(this.labelRHS);
      this.Controls.Add(this.labelOperator);
      this.Controls.Add(this.labelLHS);
      this.Controls.Add(this.buttonEvaluate);
      this.Controls.Add(this.buttonDivide);
      this.Controls.Add(this.buttonMultiply);
      this.Controls.Add(this.buttonSubtract);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.textBoxInput);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxInput;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonSubtract;
    private System.Windows.Forms.Button buttonMultiply;
    private System.Windows.Forms.Button buttonDivide;
    private System.Windows.Forms.Button buttonEvaluate;
    private System.Windows.Forms.Label labelLHS;
    private System.Windows.Forms.Label labelOperator;
    private System.Windows.Forms.Label labelRHS;
    private System.Windows.Forms.Label labelEquals;
    private System.Windows.Forms.Label labelAnswer;
    private System.Windows.Forms.Button buttonDel;
    private System.Windows.Forms.Button buttonI;
    private System.Windows.Forms.Button buttonV;
    private System.Windows.Forms.Button buttonX;
    private System.Windows.Forms.Button buttonL;
    private System.Windows.Forms.Button buttonM;
    private System.Windows.Forms.Button buttonD;
    private System.Windows.Forms.Button buttonC;
    private System.Windows.Forms.Button buttonClearAll;
  }
}

