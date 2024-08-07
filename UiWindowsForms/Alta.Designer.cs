namespace UiWindowsForms
{
    partial class Alta
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
            btnAceptar=new Button();
            btnCancelar=new Button();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            txtDireccion=new TextBox();
            txtNumTel=new TextBox();
            txtCarac=new TextBox();
            txtApellido=new TextBox();
            txtNombre=new TextBox();
            label6=new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location=new Point(314, 234);
            btnAceptar.Name="btnAceptar";
            btnAceptar.Size=new Size(94, 29);
            btnAceptar.TabIndex=0;
            btnAceptar.Text="Aceptar";
            btnAceptar.UseVisualStyleBackColor=true;
            btnAceptar.Click+=btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(214, 234);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(94, 29);
            btnCancelar.TabIndex=1;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(10, 66);
            label1.Name="label1";
            label1.Size=new Size(64, 20);
            label1.TabIndex=2;
            label1.Text="Nombre";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(12, 191);
            label2.Name="label2";
            label2.Size=new Size(72, 20);
            label2.TabIndex=3;
            label2.Text="Dirección";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(12, 161);
            label3.Name="label3";
            label3.Size=new Size(144, 20);
            label3.TabIndex=4;
            label3.Text="Número de teléfono";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(10, 130);
            label4.Name="label4";
            label4.Size=new Size(98, 20);
            label4.TabIndex=5;
            label4.Text="Característica";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(10, 98);
            label5.Name="label5";
            label5.Size=new Size(66, 20);
            label5.TabIndex=6;
            label5.Text="Apellido";
            // 
            // txtDireccion
            // 
            txtDireccion.Location=new Point(90, 188);
            txtDireccion.Name="txtDireccion";
            txtDireccion.Size=new Size(315, 27);
            txtDireccion.TabIndex=9;
            // 
            // txtNumTel
            // 
            txtNumTel.Location=new Point(162, 158);
            txtNumTel.Name="txtNumTel";
            txtNumTel.Size=new Size(243, 27);
            txtNumTel.TabIndex=10;
            // 
            // txtCarac
            // 
            txtCarac.Location=new Point(114, 127);
            txtCarac.Name="txtCarac";
            txtCarac.Size=new Size(294, 27);
            txtCarac.TabIndex=11;
            // 
            // txtApellido
            // 
            txtApellido.Location=new Point(80, 95);
            txtApellido.Name="txtApellido";
            txtApellido.Size=new Size(325, 27);
            txtApellido.TabIndex=12;
            // 
            // txtNombre
            // 
            txtNombre.Location=new Point(80, 63);
            txtNombre.Name="txtNombre";
            txtNombre.Size=new Size(328, 27);
            txtNombre.TabIndex=13;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(12, 9);
            label6.Name="label6";
            label6.Size=new Size(396, 37);
            label6.TabIndex=14;
            label6.Text="AÑADIR UN NUEVO CONTACTO";
            label6.Click+=label6_Click;
            // 
            // Alta
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(417, 294);
            Controls.Add(label6);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtCarac);
            Controls.Add(txtNumTel);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name="Alta";
            Text="Alta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDireccion;
        private TextBox txtNumTel;
        private TextBox txtCarac;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label6;
    }
}