namespace PryMendozaIntegrador
{
    partial class FrmLocalQuenaken
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
            cmbArea = new ComboBox();
            grp = new GroupBox();
            cmdFila = new ComboBox();
            lblReservaDeFilas = new Label();
            num = new NumericUpDown();
            label2 = new Label();
            BtnGuardarReserva = new Button();
            groupBox1 = new GroupBox();
            txtNumero = new TextBox();
            txtEmail = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 23);
            label1.Name = "label1";
            label1.Size = new Size(210, 21);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el area deseada:";
            // 
            // cmbArea
            // 
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "Azul", "Verde " });
            cmbArea.Location = new Point(73, 53);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(177, 28);
            cmbArea.TabIndex = 1;
            // 
            // grp
            // 
            grp.BackColor = SystemColors.ActiveCaption;
            grp.Controls.Add(cmdFila);
            grp.Controls.Add(lblReservaDeFilas);
            grp.Controls.Add(num);
            grp.Controls.Add(label2);
            grp.Controls.Add(cmbArea);
            grp.Controls.Add(label1);
            grp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp.Location = new Point(12, 33);
            grp.Name = "grp";
            grp.Size = new Size(332, 209);
            grp.TabIndex = 2;
            grp.TabStop = false;
            grp.Text = "Reserva su ubicacìon";
            // 
            // cmdFila
            // 
            cmdFila.FormattingEnabled = true;
            cmdFila.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmdFila.Location = new Point(73, 104);
            cmdFila.Name = "cmdFila";
            cmdFila.Size = new Size(177, 28);
            cmdFila.TabIndex = 7;
            // 
            // lblReservaDeFilas
            // 
            lblReservaDeFilas.AutoSize = true;
            lblReservaDeFilas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservaDeFilas.Location = new Point(56, 80);
            lblReservaDeFilas.Name = "lblReservaDeFilas";
            lblReservaDeFilas.Size = new Size(204, 21);
            lblReservaDeFilas.TabIndex = 6;
            lblReservaDeFilas.Text = "Seleccione la fila deseada: ";
            // 
            // num
            // 
            num.Location = new Point(73, 159);
            num.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num.Name = "num";
            num.Size = new Size(177, 27);
            num.TabIndex = 5;
            num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 135);
            label2.Name = "label2";
            label2.Size = new Size(317, 21);
            label2.TabIndex = 4;
            label2.Text = "Seleccione cantidad de asientos deseados";
            // 
            // BtnGuardarReserva
            // 
            BtnGuardarReserva.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGuardarReserva.Location = new Point(189, 257);
            BtnGuardarReserva.Name = "BtnGuardarReserva";
            BtnGuardarReserva.Size = new Size(317, 27);
            BtnGuardarReserva.TabIndex = 3;
            BtnGuardarReserva.Text = "Reservar ubicacion!";
            BtnGuardarReserva.UseVisualStyleBackColor = true;
            BtnGuardarReserva.Click += BtnGuardarReserva_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(368, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 209);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos personales";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(160, 165);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(135, 27);
            txtNumero.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(135, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(160, 99);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(135, 27);
            txtDni.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(160, 66);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(135, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(135, 27);
            txtNombre.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 172);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 4;
            label7.Text = "Numero Telefonico:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 135);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 3;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 102);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 2;
            label5.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 73);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 1;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 36);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // FrmLocalQuenaken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(712, 296);
            Controls.Add(groupBox1);
            Controls.Add(grp);
            Controls.Add(BtnGuardarReserva);
            Name = "FrmLocalQuenaken";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Quenaken";
            grp.ResumeLayout(false);
            grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cmbArea;
        private GroupBox grp;
        private Button BtnGuardarReserva;
        private NumericUpDown num;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtNumero;
        private TextBox txtEmail;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmdFila;
        private Label lblReservaDeFilas;
    }
}