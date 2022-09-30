namespace CRUDequipo
{
    partial class AltaForm
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
            this.lblNext = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.txtNombreDirector = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPosiciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCamiseta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloCamiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(26, 21);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(133, 20);
            this.lblNext.TabIndex = 0;
            this.lblNext.Text = "Proximo Equipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Director Tecnico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre Equipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Persona";
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJugador,
            this.colIDJugador,
            this.colPosicion,
            this.cloCamiseta,
            this.colAcciones});
            this.dgvEquipo.Location = new System.Drawing.Point(30, 246);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            this.dgvEquipo.Size = new System.Drawing.Size(553, 150);
            this.dgvEquipo.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(401, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(409, 453);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(508, 453);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // cboPersonas
            // 
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.Location = new System.Drawing.Point(115, 124);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(264, 21);
            this.cboPersonas.TabIndex = 13;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(115, 53);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(264, 20);
            this.txtNombreEquipo.TabIndex = 14;
            // 
            // txtNombreDirector
            // 
            this.txtNombreDirector.Location = new System.Drawing.Point(115, 88);
            this.txtNombreDirector.Name = "txtNombreDirector";
            this.txtNombreDirector.Size = new System.Drawing.Size(264, 20);
            this.txtNombreDirector.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(482, 411);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad de jugadores";
            // 
            // cboPosiciones
            // 
            this.cboPosiciones.FormattingEnabled = true;
            this.cboPosiciones.Location = new System.Drawing.Point(115, 161);
            this.cboPosiciones.Name = "cboPosiciones";
            this.cboPosiciones.Size = new System.Drawing.Size(264, 21);
            this.cboPosiciones.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Posicion";
            // 
            // txtCamiseta
            // 
            this.txtCamiseta.Location = new System.Drawing.Point(189, 206);
            this.txtCamiseta.Name = "txtCamiseta";
            this.txtCamiseta.Size = new System.Drawing.Size(190, 20);
            this.txtCamiseta.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Camiseta";
            // 
            // idJugador
            // 
            this.idJugador.HeaderText = "id";
            this.idJugador.Name = "idJugador";
            this.idJugador.Visible = false;
            // 
            // colIDJugador
            // 
            this.colIDJugador.HeaderText = "Jugador";
            this.colIDJugador.Name = "colIDJugador";
            this.colIDJugador.Width = 200;
            // 
            // colPosicion
            // 
            this.colPosicion.HeaderText = "Posicion";
            this.colPosicion.Name = "colPosicion";
            // 
            // cloCamiseta
            // 
            this.cloCamiseta.HeaderText = "Camiseta";
            this.cloCamiseta.Name = "cloCamiseta";
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.Text = "Eliminar";
            this.colAcciones.UseColumnTextForButtonValue = true;
            // 
            // AltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCamiseta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPosiciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNombreDirector);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.cboPersonas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvEquipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNext);
            this.Name = "AltaForm";
            this.Text = "AltaForm";
            this.Load += new System.EventHandler(this.AltaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtNombreDirector;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPosiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCamiseta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloCamiseta;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}

