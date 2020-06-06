namespace prueba.Vista
{
    partial class Frm_usu
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Matricula:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(267, 146);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(100, 23);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(417, 146);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(100, 23);
            this.btn_Modificar.TabIndex = 36;
            this.btn_Modificar.Text = "Actualizar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(125, 146);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 23);
            this.btn_agregar.TabIndex = 35;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(601, 146);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 23);
            this.btn_limpiar.TabIndex = 34;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(110, 107);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_Direccion.TabIndex = 33;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(110, 81);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 20);
            this.txt_Edad.TabIndex = 32;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(110, 55);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 31;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(110, 29);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 30;
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.AllowUserToDeleteRows = false;
            this.Dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_usuarios.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Location = new System.Drawing.Point(125, 187);
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            this.Dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_usuarios.Size = new System.Drawing.Size(576, 251);
            this.Dgv_usuarios.TabIndex = 42;
            this.Dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuarios_CellContentClick);
            // 
            // Frm_usu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_usuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Id);
            this.Name = "Frm_usu";
            this.Text = "Frm_usu";
            this.Load += new System.EventHandler(this.Frm_usu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button btn_Modificar;
        public System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.Button btn_limpiar;
        public System.Windows.Forms.TextBox txt_Direccion;
        public System.Windows.Forms.TextBox txt_Edad;
        public System.Windows.Forms.TextBox txt_Nombre;
        public System.Windows.Forms.TextBox txt_Id;
        public System.Windows.Forms.DataGridView Dgv_usuarios;
    }
}