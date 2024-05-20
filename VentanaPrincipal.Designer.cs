namespace PryMendozaIntegrador
{
    partial class VentanaPrincipal
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
            menuStrip = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            seleccioneToolStripMenuItem = new ToolStripMenuItem();
            localQuenakenToolStripMenuItem = new ToolStripMenuItem();
            localOnasToolStripMenuItem = new ToolStripMenuItem();
            localTobasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, seleccioneToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(740, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarToolStripMenuItem, toolStripMenuItem1 });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(161, 22);
            cerrarToolStripMenuItem.Text = "Cerrar programa";
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(158, 6);
            // 
            // seleccioneToolStripMenuItem
            // 
            seleccioneToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localQuenakenToolStripMenuItem, localOnasToolStripMenuItem, localTobasToolStripMenuItem, toolStripMenuItem2 });
            seleccioneToolStripMenuItem.Name = "seleccioneToolStripMenuItem";
            seleccioneToolStripMenuItem.Size = new Size(106, 20);
            seleccioneToolStripMenuItem.Text = "Seleccione Local";
            seleccioneToolStripMenuItem.Click += seleccioneToolStripMenuItem_Click;
            // 
            // localQuenakenToolStripMenuItem
            // 
            localQuenakenToolStripMenuItem.Name = "localQuenakenToolStripMenuItem";
            localQuenakenToolStripMenuItem.Size = new Size(168, 22);
            localQuenakenToolStripMenuItem.Text = "Local Quenaken...";
            localQuenakenToolStripMenuItem.Click += localQuenakenToolStripMenuItem_Click;
            // 
            // localOnasToolStripMenuItem
            // 
            localOnasToolStripMenuItem.Name = "localOnasToolStripMenuItem";
            localOnasToolStripMenuItem.Size = new Size(168, 22);
            localOnasToolStripMenuItem.Text = "Local Onas...";
            localOnasToolStripMenuItem.Click += localOnasToolStripMenuItem_Click;
            // 
            // localTobasToolStripMenuItem
            // 
            localTobasToolStripMenuItem.Name = "localTobasToolStripMenuItem";
            localTobasToolStripMenuItem.Size = new Size(168, 22);
            localTobasToolStripMenuItem.Text = "Local tobas...";
            localTobasToolStripMenuItem.Click += localTobasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(165, 6);
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(740, 384);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "VentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trabajo Pràctico Integrador Final";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem seleccioneToolStripMenuItem;
        private ToolStripMenuItem localQuenakenToolStripMenuItem;
        private ToolStripMenuItem localOnasToolStripMenuItem;
        private ToolStripMenuItem localTobasToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
    }
}
