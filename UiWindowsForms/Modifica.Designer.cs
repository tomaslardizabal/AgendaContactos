namespace UiWindowsForms
{
    partial class Modifica
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
            label6=new Label();
            txtNombre=new TextBox();
            txtApellido=new TextBox();
            txtCarac=new TextBox();
            txtNumTel=new TextBox();
            txtDireccion=new TextBox();
            label5=new Label();
            label4=new Label();
            label3=new Label();
            label2=new Label();
            label1=new Label();
            btnCancelar=new Button();
            btnAceptar=new Button();
            label7=new Label();
            txtId=new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(12, 9);
            label6.Name="label6";
            label6.Size=new Size(344, 37);
            label6.TabIndex=27;
            label6.Text="MODIFICAR UN CONTACTO";
            label6.Click+=label6_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location=new Point(80, 86);
            txtNombre.Name="txtNombre";
            txtNombre.Size=new Size(276, 27);
            txtNombre.TabIndex=26;
            // 
            // txtApellido
            // 
            txtApellido.Location=new Point(80, 118);
            txtApellido.Name="txtApellido";
            txtApellido.Size=new Size(276, 27);
            txtApellido.TabIndex=25;
            // 
            // txtCarac
            // 
            txtCarac.Location=new Point(114, 150);
            txtCarac.Name="txtCarac";
            txtCarac.Size=new Size(242, 27);
            txtCarac.TabIndex=24;
            // 
            // txtNumTel
            // 
            txtNumTel.Location=new Point(162, 181);
            txtNumTel.Name="txtNumTel";
            txtNumTel.Size=new Size(194, 27);
            txtNumTel.TabIndex=23;
            // 
            // txtDireccion
            // 
            txtDireccion.Location=new Point(90, 211);
            txtDireccion.Name="txtDireccion";
            txtDireccion.Size=new Size(266, 27);
            txtDireccion.TabIndex=22;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(10, 121);
            label5.Name="label5";
            label5.Size=new Size(66, 20);
            label5.TabIndex=21;
            label5.Text="Apellido";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(10, 153);
            label4.Name="label4";
            label4.Size=new Size(98, 20);
            label4.TabIndex=20;
            label4.Text="Característica";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(12, 184);
            label3.Name="label3";
            label3.Size=new Size(144, 20);
            label3.TabIndex=19;
            label3.Text="Número de teléfono";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(12, 214);
            label2.Name="label2";
            label2.Size=new Size(72, 20);
            label2.TabIndex=18;
            label2.Text="Dirección";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(10, 89);
            label1.Name="label1";
            label1.Size=new Size(64, 20);
            label1.TabIndex=17;
            label1.Text="Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Location=new Point(162, 244);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(94, 29);
            btnCancelar.TabIndex=16;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            btnCancelar.Click+=btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location=new Point(262, 244);
            btnAceptar.Name="btnAceptar";
            btnAceptar.Size=new Size(94, 29);
            btnAceptar.TabIndex=15;
            btnAceptar.Text="Aceptar";
            btnAceptar.UseVisualStyleBackColor=true;
            btnAceptar.Click+=btnAceptar_Click;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(12, 56);
            label7.Name="label7";
            label7.Size=new Size(22, 20);
            label7.TabIndex=28;
            label7.Text="Id";
            // 
            // txtId
            // 
            txtId.Enabled=false;
            txtId.Location=new Point(40, 53);
            txtId.Name="txtId";
            txtId.Size=new Size(316, 27);
            txtId.TabIndex=29;
            // 
            // Modifica
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(366, 310);
            Controls.Add(txtId);
            Controls.Add(label7);
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
            Name="Modifica";
            Text="Modifica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCarac;
        private TextBox txtNumTel;
        private TextBox txtDireccion;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label7;
        private TextBox txtId;
    }
}