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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboJugador = new System.Windows.Forms.ComboBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.txtNombreDirector = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(24, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Director Tecnico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre Equipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Jugador";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJugador,
            this.colIDJugador,
            this.colPosicion,
            this.colAcciones});
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(331, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(286, 386);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(385, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // cboJugador
            // 
            this.cboJugador.FormattingEnabled = true;
            this.cboJugador.Location = new System.Drawing.Point(116, 65);
            this.cboJugador.Name = "cboJugador";
            this.cboJugador.Size = new System.Drawing.Size(186, 21);
            this.cboJugador.TabIndex = 13;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(116, 97);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(186, 20);
            this.txtNombreEquipo.TabIndex = 14;
            // 
            // txtNombreDirector
            // 
            this.txtNombreDirector.Location = new System.Drawing.Point(116, 133);
            this.txtNombreDirector.Name = "txtNombreDirector";
            this.txtNombreDirector.Size = new System.Drawing.Size(186, 20);
            this.txtNombreDirector.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(359, 344);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad de jugadores";
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
            this.ClientSize = new System.Drawing.Size(492, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNombreDirector);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.cboJugador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNext);
            this.Name = "AltaForm";
            this.Text = "AltaForm";
            this.Load += new System.EventHandler(this.AltaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboJugador;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtNombreDirector;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosicion;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}

