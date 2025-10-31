namespace ecuaciones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtA = new TextBox();
			txtC = new TextBox();
			txtB = new TextBox();
			resolverEcuacion = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.Location = new Point(25, 41);
			label1.Name = "label1";
			label1.Size = new Size(25, 21);
			label1.TabIndex = 0;
			label1.Text = "A:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.Location = new Point(24, 71);
			label2.Name = "label2";
			label2.Size = new Size(24, 21);
			label2.TabIndex = 1;
			label2.Text = "B:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.Location = new Point(23, 101);
			label3.Name = "label3";
			label3.Size = new Size(24, 21);
			label3.TabIndex = 2;
			label3.Text = "C:";
			// 
			// txtA
			// 
			txtA.Location = new Point(48, 42);
			txtA.Name = "txtA";
			txtA.Size = new Size(111, 23);
			txtA.TabIndex = 0;
			// 
			// txtC
			// 
			txtC.Location = new Point(48, 102);
			txtC.Name = "txtC";
			txtC.Size = new Size(111, 23);
			txtC.TabIndex = 3;
			// 
			// txtB
			// 
			txtB.Location = new Point(48, 72);
			txtB.Name = "txtB";
			txtB.Size = new Size(111, 23);
			txtB.TabIndex = 1;
			// 
			// resolverEcuacion
			// 
			resolverEcuacion.AutoEllipsis = true;
			resolverEcuacion.BackColor = Color.White;
			resolverEcuacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			resolverEcuacion.Location = new Point(202, 41);
			resolverEcuacion.Name = "resolverEcuacion";
			resolverEcuacion.Size = new Size(120, 53);
			resolverEcuacion.TabIndex = 4;
			resolverEcuacion.Text = "Resolver";
			resolverEcuacion.UseVisualStyleBackColor = false;
			resolverEcuacion.Click += resolverEcuacion_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(356, 153);
			Controls.Add(resolverEcuacion);
			Controls.Add(txtB);
			Controls.Add(txtC);
			Controls.Add(txtA);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Ecuaciones Cuadráticas";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtA;
		private TextBox txtC;
		private TextBox txtB;
		private Button resolverEcuacion;
	}
}
