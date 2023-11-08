namespace CalcQuadrado.View
{
    partial class FormularioCalcQuadrado
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
            label1 = new Label();
            label2 = new Label();
            txt_calcular = new TextBox();
            btn_calcular = new Button();
            txt_resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(261, 48);
            label1.Name = "label1";
            label1.Size = new Size(329, 32);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Calculo Quadrado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 114);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite o Valor";
            // 
            // txt_calcular
            // 
            txt_calcular.Location = new Point(202, 111);
            txt_calcular.Name = "txt_calcular";
            txt_calcular.Size = new Size(100, 23);
            txt_calcular.TabIndex = 2;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(119, 187);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(445, 23);
            btn_calcular.TabIndex = 3;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_resultado
            // 
            txt_resultado.BackColor = Color.Red;
            txt_resultado.Location = new Point(247, 254);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(305, 132);
            txt_resultado.TabIndex = 4;
            txt_resultado.Text = "Quadrado";
            txt_resultado.Click += Quadrado_Click;
            // 
            // FormularioCalcQuadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_resultado);
            Controls.Add(btn_calcular);
            Controls.Add(txt_calcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioCalcQuadrado";
            Text = "FormularioCalcQuadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_calcular;
        private Button btn_calcular;
        private Label txt_resultado;
    }
}