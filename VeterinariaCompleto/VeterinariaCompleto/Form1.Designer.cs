namespace VeterinariaCompleto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aGREGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPORTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERDATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvIntervencion = new System.Windows.Forms.DataGridView();
            this.lblAnimal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervencion)).BeginInit();
            this.SuspendLayout();
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(40, 13);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(101, 13);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(84, 17);
            this.rbActivos.TabIndex = 1;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Solo Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbActivos_CheckedChanged);
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(191, 13);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(87, 17);
            this.rbInactivo.TabIndex = 2;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Solo Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAnimales.Location = new System.Drawing.Point(40, 47);
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.Size = new System.Drawing.Size(717, 150);
            this.dgvAnimales.TabIndex = 3;
            this.dgvAnimales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimales_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGREGARToolStripMenuItem,
            this.eXPORTARToolStripMenuItem,
            this.vERDATOSToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 92);
            // 
            // aGREGARToolStripMenuItem
            // 
            this.aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            this.aGREGARToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aGREGARToolStripMenuItem.Text = "Modificar Disponibilidad";
            this.aGREGARToolStripMenuItem.Click += new System.EventHandler(this.aGREGARToolStripMenuItem_Click);
            // 
            // eXPORTARToolStripMenuItem
            // 
            this.eXPORTARToolStripMenuItem.Name = "eXPORTARToolStripMenuItem";
            this.eXPORTARToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.eXPORTARToolStripMenuItem.Text = "EXPORTAR";
            this.eXPORTARToolStripMenuItem.Click += new System.EventHandler(this.eXPORTARToolStripMenuItem_Click);
            // 
            // vERDATOSToolStripMenuItem
            // 
            this.vERDATOSToolStripMenuItem.Name = "vERDATOSToolStripMenuItem";
            this.vERDATOSToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.vERDATOSToolStripMenuItem.Text = "VER DATOS";
            this.vERDATOSToolStripMenuItem.Click += new System.EventHandler(this.vERDATOSToolStripMenuItem_Click);
            // 
            // dgvIntervencion
            // 
            this.dgvIntervencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervencion.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvIntervencion.Location = new System.Drawing.Point(40, 260);
            this.dgvIntervencion.Name = "dgvIntervencion";
            this.dgvIntervencion.Size = new System.Drawing.Size(717, 150);
            this.dgvIntervencion.TabIndex = 4;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(40, 227);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(47, 15);
            this.lblAnimal.TabIndex = 5;
            this.lblAnimal.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.dgvIntervencion);
            this.Controls.Add(this.dgvAnimales);
            this.Controls.Add(this.rbInactivo);
            this.Controls.Add(this.rbActivos);
            this.Controls.Add(this.rbTodos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.DataGridView dgvAnimales;
        private System.Windows.Forms.DataGridView dgvIntervencion;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aGREGARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXPORTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERDATOSToolStripMenuItem;
    }
}

