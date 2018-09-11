namespace Modificar_Menu
{
    partial class Frm_Modificar_Menus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Menus));
            this.grilla_menu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_alimento = new System.Windows.Forms.Button();
            this.btn_alimentos = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.btn_distribucion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdistribucion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_menu_limpiar = new System.Windows.Forms.Button();
            this.btn_tipo_comida = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dia = new System.Windows.Forms.Button();
            this.txttipo_comida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.btn_tipo_menu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttipo_menu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Ayuda = new AyudaSpreadNet.AyudaSprNet();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.CODMENU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPO_MENU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODMENUDET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPOCOMIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODMENUREGDET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODDISTRIBUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODMENUPEDALI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODALIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMSEMANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMTIPOCOMIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMDISTRIBUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMALIMENTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIGENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIGENCIA_DISTRIBUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_menu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grilla_menu
            // 
            this.grilla_menu.AllowUserToAddRows = false;
            this.grilla_menu.AllowUserToDeleteRows = false;
            this.grilla_menu.AllowUserToResizeColumns = false;
            this.grilla_menu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ELIMINAR,
            this.CODMENU,
            this.CODTIPO_MENU,
            this.CODDIA,
            this.CODMENUDET,
            this.CODTIPOCOMIDA,
            this.CODMENUREGDET,
            this.CODDISTRIBUCION,
            this.CODMENUPEDALI,
            this.CODALIMENTO,
            this.NOMSEMANA,
            this.NOMDIA,
            this.NOMTIPOCOMIDA,
            this.NOMDISTRIBUCION,
            this.NOMALIMENTOS,
            this.VIGENCIA,
            this.VIGENCIA_DISTRIBUCION});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_menu.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla_menu.Location = new System.Drawing.Point(5, 271);
            this.grilla_menu.Name = "grilla_menu";
            this.grilla_menu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_menu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grilla_menu.RowHeadersVisible = false;
            this.grilla_menu.Size = new System.Drawing.Size(824, 176);
            this.grilla_menu.TabIndex = 221;
            this.grilla_menu.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_menu_CellContentDoubleClick);
            this.grilla_menu.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grilla_menu_CellPainting);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btn_limpiar_alimento);
            this.groupBox2.Controls.Add(this.btn_alimentos);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtalimento);
            this.groupBox2.Controls.Add(this.btn_distribucion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtdistribucion);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(5, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 84);
            this.groupBox2.TabIndex = 220;
            this.groupBox2.TabStop = false;
            // 
            // btn_limpiar_alimento
            // 
            this.btn_limpiar_alimento.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar_alimento.Image")));
            this.btn_limpiar_alimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar_alimento.Location = new System.Drawing.Point(742, 40);
            this.btn_limpiar_alimento.Name = "btn_limpiar_alimento";
            this.btn_limpiar_alimento.Size = new System.Drawing.Size(72, 33);
            this.btn_limpiar_alimento.TabIndex = 204;
            this.btn_limpiar_alimento.Text = "Limpiar";
            this.btn_limpiar_alimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar_alimento.UseVisualStyleBackColor = true;
            this.btn_limpiar_alimento.Click += new System.EventHandler(this.btn_limpiar_alimento_Click);
            // 
            // btn_alimentos
            // 
            this.btn_alimentos.Image = ((System.Drawing.Image)(resources.GetObject("btn_alimentos.Image")));
            this.btn_alimentos.Location = new System.Drawing.Point(620, 44);
            this.btn_alimentos.Name = "btn_alimentos";
            this.btn_alimentos.Size = new System.Drawing.Size(27, 23);
            this.btn_alimentos.TabIndex = 191;
            this.btn_alimentos.UseVisualStyleBackColor = true;
            this.btn_alimentos.Click += new System.EventHandler(this.btn_alimentos_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::Modificar_Menu.Properties.Resources.add;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(666, 40);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(73, 33);
            this.btn_agregar.TabIndex = 203;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 190;
            this.label4.Text = "Alimento";
            // 
            // txtalimento
            // 
            this.txtalimento.BackColor = System.Drawing.Color.White;
            this.txtalimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtalimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtalimento.Location = new System.Drawing.Point(362, 47);
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(252, 20);
            this.txtalimento.TabIndex = 189;
            this.txtalimento.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtalimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtalimento_KeyPress);
            this.txtalimento.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // btn_distribucion
            // 
            this.btn_distribucion.Image = ((System.Drawing.Image)(resources.GetObject("btn_distribucion.Image")));
            this.btn_distribucion.Location = new System.Drawing.Point(244, 45);
            this.btn_distribucion.Name = "btn_distribucion";
            this.btn_distribucion.Size = new System.Drawing.Size(27, 23);
            this.btn_distribucion.TabIndex = 183;
            this.btn_distribucion.UseVisualStyleBackColor = true;
            this.btn_distribucion.Click += new System.EventHandler(this.btn_distribucion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Distribución";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(0, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(824, 25);
            this.label11.TabIndex = 79;
            this.label11.Text = "Detalle de  Alimento";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdistribucion
            // 
            this.txtdistribucion.BackColor = System.Drawing.Color.White;
            this.txtdistribucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdistribucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdistribucion.Location = new System.Drawing.Point(78, 47);
            this.txtdistribucion.Name = "txtdistribucion";
            this.txtdistribucion.ReadOnly = true;
            this.txtdistribucion.Size = new System.Drawing.Size(160, 20);
            this.txtdistribucion.TabIndex = 3;
            this.txtdistribucion.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtdistribucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdistribucion_KeyPress);
            this.txtdistribucion.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_menu_limpiar);
            this.groupBox1.Controls.Add(this.btn_tipo_comida);
            this.groupBox1.Controls.Add(this.btn_confirmar);
            this.groupBox1.Controls.Add(this.txtobservacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_dia);
            this.groupBox1.Controls.Add(this.txttipo_comida);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdia);
            this.groupBox1.Controls.Add(this.btn_tipo_menu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttipo_menu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(5, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 114);
            this.groupBox1.TabIndex = 219;
            this.groupBox1.TabStop = false;
            // 
            // btn_menu_limpiar
            // 
            this.btn_menu_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_limpiar.Image")));
            this.btn_menu_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_limpiar.Location = new System.Drawing.Point(743, 40);
            this.btn_menu_limpiar.Name = "btn_menu_limpiar";
            this.btn_menu_limpiar.Size = new System.Drawing.Size(72, 33);
            this.btn_menu_limpiar.TabIndex = 202;
            this.btn_menu_limpiar.Text = "Limpiar";
            this.btn_menu_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu_limpiar.UseVisualStyleBackColor = true;
            this.btn_menu_limpiar.Click += new System.EventHandler(this.btn_menu_limpiar_Click);
            // 
            // btn_tipo_comida
            // 
            this.btn_tipo_comida.Image = ((System.Drawing.Image)(resources.GetObject("btn_tipo_comida.Image")));
            this.btn_tipo_comida.Location = new System.Drawing.Point(244, 67);
            this.btn_tipo_comida.Name = "btn_tipo_comida";
            this.btn_tipo_comida.Size = new System.Drawing.Size(27, 23);
            this.btn_tipo_comida.TabIndex = 200;
            this.btn_tipo_comida.UseVisualStyleBackColor = true;
            this.btn_tipo_comida.Click += new System.EventHandler(this.btn_tipo_comida_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Image = global::Modificar_Menu.Properties.Resources.Check;
            this.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmar.Location = new System.Drawing.Point(667, 40);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(73, 33);
            this.btn_confirmar.TabIndex = 197;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txtobservacion
            // 
            this.txtobservacion.BackColor = System.Drawing.Color.White;
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobservacion.Location = new System.Drawing.Point(362, 69);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(252, 36);
            this.txtobservacion.TabIndex = 194;
            this.txtobservacion.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtobservacion.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 199;
            this.label3.Text = "Tipo Comida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 193;
            this.label2.Text = "Observación";
            // 
            // btn_dia
            // 
            this.btn_dia.Image = ((System.Drawing.Image)(resources.GetObject("btn_dia.Image")));
            this.btn_dia.Location = new System.Drawing.Point(587, 40);
            this.btn_dia.Name = "btn_dia";
            this.btn_dia.Size = new System.Drawing.Size(27, 23);
            this.btn_dia.TabIndex = 191;
            this.btn_dia.UseVisualStyleBackColor = true;
            this.btn_dia.Click += new System.EventHandler(this.btn_dia_Click);
            // 
            // txttipo_comida
            // 
            this.txttipo_comida.BackColor = System.Drawing.Color.White;
            this.txttipo_comida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipo_comida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttipo_comida.Location = new System.Drawing.Point(78, 69);
            this.txttipo_comida.Name = "txttipo_comida";
            this.txttipo_comida.Size = new System.Drawing.Size(160, 20);
            this.txttipo_comida.TabIndex = 198;
            this.txttipo_comida.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txttipo_comida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipo_comida_KeyPress);
            this.txttipo_comida.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 190;
            this.label1.Text = "Dias";
            // 
            // txtdia
            // 
            this.txtdia.BackColor = System.Drawing.Color.White;
            this.txtdia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdia.Location = new System.Drawing.Point(362, 41);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(219, 20);
            this.txtdia.TabIndex = 189;
            this.txtdia.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtdia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdia_KeyPress);
            this.txtdia.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // btn_tipo_menu
            // 
            this.btn_tipo_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_tipo_menu.Image")));
            this.btn_tipo_menu.Location = new System.Drawing.Point(244, 39);
            this.btn_tipo_menu.Name = "btn_tipo_menu";
            this.btn_tipo_menu.Size = new System.Drawing.Size(27, 23);
            this.btn_tipo_menu.TabIndex = 183;
            this.btn_tipo_menu.UseVisualStyleBackColor = true;
            this.btn_tipo_menu.Click += new System.EventHandler(this.btn_tipo_menu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo Menú";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(812, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "Configuración de Menú";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttipo_menu
            // 
            this.txttipo_menu.BackColor = System.Drawing.Color.White;
            this.txttipo_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipo_menu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttipo_menu.Location = new System.Drawing.Point(78, 42);
            this.txttipo_menu.Name = "txttipo_menu";
            this.txttipo_menu.Size = new System.Drawing.Size(160, 20);
            this.txttipo_menu.TabIndex = 3;
            this.txttipo_menu.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txttipo_menu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipo_menu_KeyPress);
            this.txttipo_menu.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.Silver;
            this.LblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(8, 3);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(131, 25);
            this.LblUsuario.TabIndex = 218;
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Modificar_Menu.Properties.Resources.save;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(270, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(104, 47);
            this.btn_guardar.TabIndex = 216;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(380, 3);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(98, 47);
            this.btn_limpiar.TabIndex = 217;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(5, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(824, 25);
            this.label13.TabIndex = 222;
            this.label13.Text = "Listado";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ayuda
            // 
            this.Ayuda.AnchoColumnas = null;
            this.Ayuda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Ayuda.Location = new System.Drawing.Point(545, -16);
            this.Ayuda.Multi_Seleccion = false;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Nombre_BD_Datos = null;
            this.Ayuda.NombreColumnas = null;
            this.Ayuda.Package = null;
            this.Ayuda.Pass = null;
            this.Ayuda.Procedimiento = null;
            this.Ayuda.Size = new System.Drawing.Size(58, 66);
            this.Ayuda.TabIndex = 223;
            this.Ayuda.TipoBase = 0;
            this.Ayuda.TituloConsulta = null;
            this.Ayuda.User = null;
            this.Ayuda.UseWaitCursor = true;
            this.Ayuda.Visible = false;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "E";
            this.ELIMINAR.Image = global::Modificar_Menu.Properties.Resources.Delete;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            this.ELIMINAR.ToolTipText = "Presionar Doble Click, para Eliminar";
            this.ELIMINAR.Width = 30;
            // 
            // CODMENU
            // 
            this.CODMENU.DataPropertyName = "COD_MENU";
            this.CODMENU.HeaderText = "COD MENU";
            this.CODMENU.Name = "CODMENU";
            this.CODMENU.ReadOnly = true;
            this.CODMENU.Visible = false;
            this.CODMENU.Width = 30;
            // 
            // CODTIPO_MENU
            // 
            this.CODTIPO_MENU.DataPropertyName = "COD_TIPO_MENU";
            this.CODTIPO_MENU.HeaderText = "COD TIPO MENU";
            this.CODTIPO_MENU.Name = "CODTIPO_MENU";
            this.CODTIPO_MENU.ReadOnly = true;
            this.CODTIPO_MENU.Visible = false;
            // 
            // CODDIA
            // 
            this.CODDIA.DataPropertyName = "COD_DIA";
            this.CODDIA.HeaderText = "COD DIA";
            this.CODDIA.Name = "CODDIA";
            this.CODDIA.ReadOnly = true;
            this.CODDIA.Visible = false;
            // 
            // CODMENUDET
            // 
            this.CODMENUDET.DataPropertyName = "COD_MENU_DET";
            this.CODMENUDET.HeaderText = "COD MENU DET";
            this.CODMENUDET.Name = "CODMENUDET";
            this.CODMENUDET.ReadOnly = true;
            this.CODMENUDET.Visible = false;
            // 
            // CODTIPOCOMIDA
            // 
            this.CODTIPOCOMIDA.DataPropertyName = "COD_TIPO_COMIDA";
            this.CODTIPOCOMIDA.HeaderText = "COD TIPO COMIDA";
            this.CODTIPOCOMIDA.Name = "CODTIPOCOMIDA";
            this.CODTIPOCOMIDA.ReadOnly = true;
            this.CODTIPOCOMIDA.Visible = false;
            // 
            // CODMENUREGDET
            // 
            this.CODMENUREGDET.DataPropertyName = "COD_MENU_REG_DET";
            this.CODMENUREGDET.HeaderText = "COD MENU REG DET";
            this.CODMENUREGDET.Name = "CODMENUREGDET";
            this.CODMENUREGDET.ReadOnly = true;
            this.CODMENUREGDET.Visible = false;
            // 
            // CODDISTRIBUCION
            // 
            this.CODDISTRIBUCION.DataPropertyName = "COD_DISTRIBUCION";
            this.CODDISTRIBUCION.HeaderText = "COD DISTRIBUCION";
            this.CODDISTRIBUCION.Name = "CODDISTRIBUCION";
            this.CODDISTRIBUCION.ReadOnly = true;
            this.CODDISTRIBUCION.Visible = false;
            // 
            // CODMENUPEDALI
            // 
            this.CODMENUPEDALI.DataPropertyName = "COD_MENU_PED_ALI";
            this.CODMENUPEDALI.HeaderText = "COD MENU PED ALI";
            this.CODMENUPEDALI.Name = "CODMENUPEDALI";
            this.CODMENUPEDALI.ReadOnly = true;
            this.CODMENUPEDALI.Visible = false;
            // 
            // CODALIMENTO
            // 
            this.CODALIMENTO.DataPropertyName = "COD_ALIMENTO";
            this.CODALIMENTO.HeaderText = "COD ALIMENTO";
            this.CODALIMENTO.Name = "CODALIMENTO";
            this.CODALIMENTO.ReadOnly = true;
            this.CODALIMENTO.Visible = false;
            // 
            // NOMSEMANA
            // 
            this.NOMSEMANA.DataPropertyName = "NOM_SEMANA";
            this.NOMSEMANA.HeaderText = "NOM SEMANA";
            this.NOMSEMANA.Name = "NOMSEMANA";
            this.NOMSEMANA.ReadOnly = true;
            this.NOMSEMANA.Visible = false;
            // 
            // NOMDIA
            // 
            this.NOMDIA.DataPropertyName = "NOM_DIA";
            this.NOMDIA.HeaderText = "NOM DIA";
            this.NOMDIA.Name = "NOMDIA";
            this.NOMDIA.ReadOnly = true;
            this.NOMDIA.Visible = false;
            // 
            // NOMTIPOCOMIDA
            // 
            this.NOMTIPOCOMIDA.DataPropertyName = "NOM_TIPO_COMIDA";
            this.NOMTIPOCOMIDA.HeaderText = "Tipo Comida";
            this.NOMTIPOCOMIDA.MinimumWidth = 150;
            this.NOMTIPOCOMIDA.Name = "NOMTIPOCOMIDA";
            this.NOMTIPOCOMIDA.ReadOnly = true;
            this.NOMTIPOCOMIDA.Width = 150;
            // 
            // NOMDISTRIBUCION
            // 
            this.NOMDISTRIBUCION.DataPropertyName = "NOM_DISTRIBUCION";
            this.NOMDISTRIBUCION.HeaderText = "Distribución Comida";
            this.NOMDISTRIBUCION.MinimumWidth = 150;
            this.NOMDISTRIBUCION.Name = "NOMDISTRIBUCION";
            this.NOMDISTRIBUCION.ReadOnly = true;
            this.NOMDISTRIBUCION.Width = 150;
            // 
            // NOMALIMENTOS
            // 
            this.NOMALIMENTOS.DataPropertyName = "NOM_ALIMENTO";
            this.NOMALIMENTOS.HeaderText = "Alimento";
            this.NOMALIMENTOS.MinimumWidth = 200;
            this.NOMALIMENTOS.Name = "NOMALIMENTOS";
            this.NOMALIMENTOS.ReadOnly = true;
            this.NOMALIMENTOS.Width = 400;
            // 
            // VIGENCIA
            // 
            this.VIGENCIA.DataPropertyName = "VIGENCIA";
            this.VIGENCIA.HeaderText = "VIGENCIA";
            this.VIGENCIA.Name = "VIGENCIA";
            this.VIGENCIA.ReadOnly = true;
            // 
            // VIGENCIA_DISTRIBUCION
            // 
            this.VIGENCIA_DISTRIBUCION.DataPropertyName = "VIGENCIA_DISTRIBUCION";
            this.VIGENCIA_DISTRIBUCION.HeaderText = "VIGENCIA_DISTRIBUCION";
            this.VIGENCIA_DISTRIBUCION.Name = "VIGENCIA_DISTRIBUCION";
            this.VIGENCIA_DISTRIBUCION.ReadOnly = true;
            // 
            // Frm_Modificar_Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 460);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grilla_menu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Menus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Modificar_Menus";
            this.Load += new System.EventHandler(this.Frm_Modificar_Menus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_menu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_menu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar_alimento;
        private System.Windows.Forms.Button btn_alimentos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtalimento;
        private System.Windows.Forms.Button btn_distribucion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdistribucion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_menu_limpiar;
        private System.Windows.Forms.Button btn_tipo_comida;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_dia;
        private System.Windows.Forms.TextBox txttipo_comida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.Button btn_tipo_menu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttipo_menu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label13;
        private AyudaSpreadNet.AyudaSprNet Ayuda;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODMENU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPO_MENU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODMENUDET;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPOCOMIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODMENUREGDET;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODDISTRIBUCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODMENUPEDALI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODALIMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMSEMANA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMTIPOCOMIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMDISTRIBUCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMALIMENTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIGENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIGENCIA_DISTRIBUCION;
    }
}