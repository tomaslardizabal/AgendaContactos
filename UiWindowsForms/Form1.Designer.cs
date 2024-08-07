namespace UiWindowsForms
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
            label1=new Label();
            txtBuscar=new TextBox();
            label2=new Label();
            btnAlta=new Button();
            btnEliminar=new Button();
            dgvContactos=new DataGridView();
            btnActualizar=new Button();
            btnModificar=new Button();
            btnBuscar=new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(316, 37);
            label1.TabIndex=0;
            label1.Text="AGENDA DE CONTACTOS";
            // 
            // txtBuscar
            // 
            txtBuscar.Location=new Point(663, 20);
            txtBuscar.Name="txtBuscar";
            txtBuscar.Size=new Size(125, 27);
            txtBuscar.TabIndex=1;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(519, 23);
            label2.Name="label2";
            label2.Size=new Size(138, 20);
            label2.TabIndex=2;
            label2.Text="Buscar por nombre:";
            // 
            // btnAlta
            // 
            btnAlta.Location=new Point(597, 406);
            btnAlta.Name="btnAlta";
            btnAlta.Size=new Size(191, 32);
            btnAlta.TabIndex=3;
            btnAlta.Text="Añadir contacto nuevo";
            btnAlta.UseVisualStyleBackColor=true;
            btnAlta.Click+=btnAlta_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location=new Point(400, 406);
            btnEliminar.Name="btnEliminar";
            btnEliminar.Size=new Size(191, 32);
            btnEliminar.TabIndex=4;
            btnEliminar.Text="Eliminar contacto";
            btnEliminar.UseVisualStyleBackColor=true;
            btnEliminar.Click+=btnEliminar_Click;
            // 
            // dgvContactos
            // 
            dgvContactos.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location=new Point(12, 103);
            dgvContactos.Name="dgvContactos";
            dgvContactos.RowHeadersWidth=51;
            dgvContactos.RowTemplate.Height=29;
            dgvContactos.Size=new Size(776, 297);
            dgvContactos.TabIndex=5;
            // 
            // btnActualizar
            // 
            btnActualizar.Location=new Point(12, 68);
            btnActualizar.Name="btnActualizar";
            btnActualizar.Size=new Size(94, 29);
            btnActualizar.TabIndex=6;
            btnActualizar.Text="Actualizar";
            btnActualizar.UseVisualStyleBackColor=true;
            btnActualizar.Click+=btnActualizar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location=new Point(203, 406);
            btnModificar.Name="btnModificar";
            btnModificar.Size=new Size(191, 32);
            btnModificar.TabIndex=7;
            btnModificar.Text="Modificar contacto";
            btnModificar.UseVisualStyleBackColor=true;
            btnModificar.Click+=btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location=new Point(694, 53);
            btnBuscar.Name="btnBuscar";
            btnBuscar.Size=new Size(94, 29);
            btnBuscar.TabIndex=8;
            btnBuscar.Text="Buscar";
            btnBuscar.UseVisualStyleBackColor=true;
            btnBuscar.Click+=btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvContactos);
            Controls.Add(btnEliminar);
            Controls.Add(btnAlta);
            Controls.Add(label2);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Name="Form1";
            Text="Agenda de contactos";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private Label label2;
        private Button btnAlta;
        private Button btnEliminar;
        private DataGridView dgvContactos;
        private Button btnActualizar;
        private Button btnModificar;
        private Button btnBuscar;
    }
}