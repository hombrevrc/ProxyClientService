namespace ProxyClientx
{
  partial class ProxyClient
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
      this.tbValue1 = new System.Windows.Forms.TextBox();
      this.tbValue2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnPlus = new System.Windows.Forms.Button();
      this.btnSubtract = new System.Windows.Forms.Button();
      this.btnMultiply = new System.Windows.Forms.Button();
      this.btnDivide = new System.Windows.Forms.Button();
      this.btnCalc = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.lblOperation = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblresult = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbValue1
      // 
      this.tbValue1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbValue1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbValue1.Location = new System.Drawing.Point(76, 19);
      this.tbValue1.MaxLength = 5;
      this.tbValue1.Name = "tbValue1";
      this.tbValue1.Size = new System.Drawing.Size(100, 29);
      this.tbValue1.TabIndex = 0;
      this.tbValue1.TextChanged += new System.EventHandler(this.tbValue1_TextChanged);
      // 
      // tbValue2
      // 
      this.tbValue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbValue2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbValue2.Location = new System.Drawing.Point(76, 74);
      this.tbValue2.MaxLength = 5;
      this.tbValue2.Name = "tbValue2";
      this.tbValue2.Size = new System.Drawing.Size(100, 29);
      this.tbValue2.TabIndex = 1;
      this.tbValue2.TextChanged += new System.EventHandler(this.tbValue2_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 21);
      this.label1.TabIndex = 2;
      this.label1.Text = "Value1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 21);
      this.label2.TabIndex = 3;
      this.label2.Text = "Value2";
      // 
      // btnPlus
      // 
      this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPlus.Location = new System.Drawing.Point(16, 19);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(75, 32);
      this.btnPlus.TabIndex = 4;
      this.btnPlus.Text = "+";
      this.btnPlus.UseVisualStyleBackColor = true;
      this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
      // 
      // btnSubtract
      // 
      this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSubtract.Location = new System.Drawing.Point(97, 19);
      this.btnSubtract.Name = "btnSubtract";
      this.btnSubtract.Size = new System.Drawing.Size(75, 32);
      this.btnSubtract.TabIndex = 5;
      this.btnSubtract.Text = "-";
      this.btnSubtract.UseVisualStyleBackColor = true;
      this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
      // 
      // btnMultiply
      // 
      this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMultiply.Location = new System.Drawing.Point(17, 57);
      this.btnMultiply.Name = "btnMultiply";
      this.btnMultiply.Size = new System.Drawing.Size(75, 32);
      this.btnMultiply.TabIndex = 6;
      this.btnMultiply.Text = "*";
      this.btnMultiply.UseVisualStyleBackColor = true;
      this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
      // 
      // btnDivide
      // 
      this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDivide.Location = new System.Drawing.Point(98, 57);
      this.btnDivide.Name = "btnDivide";
      this.btnDivide.Size = new System.Drawing.Size(75, 32);
      this.btnDivide.TabIndex = 7;
      this.btnDivide.Text = "/";
      this.btnDivide.UseVisualStyleBackColor = true;
      this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
      // 
      // btnCalc
      // 
      this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCalc.Location = new System.Drawing.Point(17, 95);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(75, 32);
      this.btnCalc.TabIndex = 8;
      this.btnCalc.Text = "Calc";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.Location = new System.Drawing.Point(178, 413);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 32);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(7, 30);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 21);
      this.label3.TabIndex = 10;
      this.label3.Text = "Operation";
      // 
      // lblOperation
      // 
      this.lblOperation.AutoSize = true;
      this.lblOperation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOperation.Location = new System.Drawing.Point(110, 30);
      this.lblOperation.Name = "lblOperation";
      this.lblOperation.Size = new System.Drawing.Size(80, 21);
      this.lblOperation.TabIndex = 11;
      this.lblOperation.Text = "Operation";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(34, 62);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 21);
      this.label5.TabIndex = 12;
      this.label5.Text = "Result";
      // 
      // lblresult
      // 
      this.lblresult.AutoSize = true;
      this.lblresult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblresult.Location = new System.Drawing.Point(110, 62);
      this.lblresult.Name = "lblresult";
      this.lblresult.Size = new System.Drawing.Size(53, 21);
      this.lblresult.TabIndex = 13;
      this.lblresult.Text = "Result";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lblresult);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.lblOperation);
      this.groupBox1.Location = new System.Drawing.Point(12, 287);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(241, 111);
      this.groupBox1.TabIndex = 14;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Output";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.tbValue1);
      this.groupBox2.Controls.Add(this.tbValue2);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Location = new System.Drawing.Point(12, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(241, 120);
      this.groupBox2.TabIndex = 14;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Input";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.btnPlus);
      this.groupBox3.Controls.Add(this.btnSubtract);
      this.groupBox3.Controls.Add(this.btnMultiply);
      this.groupBox3.Controls.Add(this.btnDivide);
      this.groupBox3.Controls.Add(this.btnCalc);
      this.groupBox3.Location = new System.Drawing.Point(12, 129);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(241, 152);
      this.groupBox3.TabIndex = 14;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Operation";
      // 
      // ProxyClient
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(271, 477);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnExit);
      this.Name = "ProxyClient";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Proxy Client";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProxyClient_FormClosing);
      this.Load += new System.EventHandler(this.ProxyClient_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox tbValue1;
    private System.Windows.Forms.TextBox tbValue2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.Button btnSubtract;
    private System.Windows.Forms.Button btnMultiply;
    private System.Windows.Forms.Button btnDivide;
    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblOperation;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblresult;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
  }
}

