using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Modificar_Menu
{
    public partial class Frm_Modificar_Menus : Form
    {

        #region Variables

        #region Variables Staticas

        static int cod_periodo = 0;
        static int cod_tipo_menu = 0;
        static int cod_dia = 0;
        static int cod_tipo_comida = 0;
        static int cod_distribucion = 0;
        static int cod_alimento = 0;
        static string fecha_sistema = "";
        static string fecha_registrar = "";
        static string fecha_inicio = "";
        static string fecha_termino = "";
        static string mes_termino = "";

        //  variables  guardar menu 

        static int cod_menu = 0;
        static int cod_menu_det = 0;
        static int cod_menu_reg_det = 0;
        static int cod_menu_ped_ali = 0;
        #endregion

        #region Datatables
        DataTable dt_fechas = new DataTable();
        DataTable dt_fecha_sistema = new DataTable();
        DataTable dt_menu = new DataTable();
        DataTable dt_menu2 = new DataTable();
        DataTable dt_tipo_menu = new DataTable();
        DataTable dt_dia = new DataTable();
        DataTable dt_tipo_comida = new DataTable();
        DataTable dt_distribucion = new DataTable();
        DataTable dt_alimento = new DataTable();
        DataTable dt_alimento_agregar = new DataTable();

        #endregion

        #region Datos Conexion

        ConectarFalp CnnFalp;
        Configuration Config;
        string User = string.Empty;
        string[] Conexion = { "", "", "" };
        string PCK = "PCK_NUT001I";
        string PCK1 = "PCK_NUT001M";

        #endregion

        #endregion
        public Frm_Modificar_Menus()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Menus_Load(object sender, EventArgs e)
        {
            conectar();
            Cargar_dt_fechas();
            Extraer_fecha_sistema();
            bloquear();
        }


        #region Cargar


        #region Cargar Conexion

        void conectar()
        {

            if (!(CnnFalp != null))
            {

                ExeConfigurationFileMap FileMap = new ExeConfigurationFileMap();
                FileMap.ExeConfigFilename = Application.StartupPath + @"\..\WF.config";
                Config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);

                CnnFalp = new ConectarFalp(Config.AppSettings.Settings["dbServer"].Value,//ConfigurationManager.AppSettings["dbServer"],
                                           Config.AppSettings.Settings["dbUser"].Value,//ConfigurationManager.AppSettings["dbUser"],
                                           Config.AppSettings.Settings["dbPass"].Value,//ConfigurationManager.AppSettings["dbPass"],
                                           ConectarFalp.TipoBase.Oracle);

                if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir(); // abre la conexion

                Conexion[0] = Config.AppSettings.Settings["dbServer"].Value;
                Conexion[2] = Config.AppSettings.Settings["dbUser"].Value;
                Conexion[1] = Config.AppSettings.Settings["dbPass"].Value;
            }



            // this.Text = this.Text + " [Versión: " + Application.ProductVersion + "] [Conectado: " + Conexion[0] + "]";
            //User = ValidaMenu.LeeUsuarioMenu();
            User = "SICI";
            LblUsuario.Text = "Usuario: " + User;
            //LblUsuario.Text = "Usuario: " + User;
        }

        #endregion

        #region Cargar Grilla

        #region Listar Grilla

        protected void Cargar_grilla_menu()
        {

            DateTime fecha = DateTime.Now.Date;
            fecha_registrar = SumarDiaDeLaSemana(cod_tipo_menu.ToString(), cod_dia.ToString(), Convert.ToDateTime(fecha_inicio));
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            dt_menu.Clear();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK1 + ".P_CARGAR_RESULTADO_MENU");
            CnnFalp.ParametroBD("PIN_COD_TIPO_MENU", cod_tipo_menu, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_COD_DIA", cod_dia, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_COD_TIPO_COMIDA", cod_tipo_comida, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_FECHA", fecha_registrar, DbType.String, ParameterDirection.Input);
            dt_menu.Load(CnnFalp.ExecuteReader());
            dt_menu2 = dt_menu;
            if (dt_menu.Rows.Count > 0)
            {
                grilla_menu.AutoGenerateColumns = false;
                grilla_menu.DataSource = new DataView(dt_menu, "VIGENCIA ='S'", "", DataViewRowState.CurrentRows);
                agrupar_celdas_menu();
                ocultar_grilla_menu2();
                // agregarimagen();
            }
            else
            {

            }

            CnnFalp.Cerrar();

        }

        #endregion

        #region Agrupar

        protected void agrupar_celdas_menu()
        {
            int var_cod_tipo_comida = 0;
            int var_cod_distribucion = 0;
            foreach (DataGridViewRow miRow in grilla_menu.Rows)
            {
                if (Convert.ToInt32(miRow.Cells["CODTIPOCOMIDA"].Value) != var_cod_tipo_comida)
                {

                }
                else
                {

                    miRow.Cells["NOMTIPOCOMIDA"].Value = "";

                }
                var_cod_tipo_comida = Convert.ToInt32(miRow.Cells["CODTIPOCOMIDA"].Value.ToString());
            }

            foreach (DataGridViewRow miRow1 in grilla_menu.Rows)
            {
                if (Convert.ToInt32(miRow1.Cells["CODDISTRIBUCION"].Value) != var_cod_distribucion)
                {

                }
                else
                {
                    miRow1.Cells["NOMDISTRIBUCION"].Value = "";
                }
                var_cod_distribucion = Convert.ToInt32(miRow1.Cells["CODDISTRIBUCION"].Value.ToString());
            }

        }


        #endregion

        #region Agregar Imagen


        protected void agregarimagen()
        {
            foreach (DataGridViewRow row in grilla_menu.Rows)
            {
               string ve = Convert.ToString(row.Cells["V"].Value);
                DataGridViewImageCell Imagen = row.Cells["Vigencia"] as DataGridViewImageCell;

                if (ve == "True")
                {
                    Imagen.Value = (System.Drawing.Image)Modificar_Menu.Properties.Resources.Check;
                }
                else
                {
                    Imagen.Value = (System.Drawing.Image)Modificar_Menu.Properties.Resources.Delete;
                }
            }
        }

        #endregion

        #region Ocultar Columnas


        void ocultar_grilla_menu2()
        {
            grilla_menu.AutoResizeColumns();
            grilla_menu.Columns["CODTIPO_MENU"].Visible = false;
            grilla_menu.Columns["CODDIA"].Visible = false;
            grilla_menu.Columns["CODTIPOCOMIDA"].Visible = false;
            grilla_menu.Columns["CODDISTRIBUCION"].Visible = false;
            grilla_menu.Columns["CODALIMENTO"].Visible = false;
            grilla_menu.Columns["NOMDIA"].Visible = false;
            grilla_menu.Columns["VIGENCIA"].Visible = false;
            grilla_menu.Columns["VIGENCIA_DISTRIBUCION"].Visible = false;
            //grilla_menu.Columns["ELIMINAR"].Visible = false;
        }


        #endregion

        #region Ordenar Columnas

        #endregion

        #region Pintar Grilla
     

        private void grilla_menu_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        
           
       

        }
        #endregion

        #region Pintar Extraer grilla

         private void grilla_menu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         string tipo_comida = "";
            string distribucion = "";
            int cod_menu_det = 0;
            int cod_menu_reg = 0;
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    DialogResult opc = MessageBox.Show("Estimado usuario, Esta seguro de Eliminar este Alimento", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opc == DialogResult.Yes)
                    {
                        int cod_tipo = Convert.ToInt32(grilla_menu.Rows[e.RowIndex].Cells["CODTIPOCOMIDA"].Value.ToString());
                        int cod_dis = Convert.ToInt32(grilla_menu.Rows[e.RowIndex].Cells["CODDISTRIBUCION"].Value.ToString());
                        int cod_ali = Convert.ToInt32(grilla_menu.Rows[e.RowIndex].Cells["CODALIMENTO"].Value.ToString());
                        cod_menu_det = Convert.ToInt32(grilla_menu.Rows[e.RowIndex].Cells["CODMENUDET"].Value.ToString());
                        cod_menu_reg = Convert.ToInt32(grilla_menu.Rows[e.RowIndex].Cells["CODMENUREGDET"].Value.ToString());
                        cod_menu_ped_ali = Convert.ToInt32(grilla_menu.Rows[e.RowIndex].Cells["CODMENUPEDALI"].Value.ToString());
                        foreach (DataRow fila in dt_menu2.Select(" COD_TIPO_COMIDA= '" + cod_tipo + "' and  NOM_TIPO_COMIDA <> ' '  "))
                        {
                            tipo_comida = fila["NOM_TIPO_COMIDA"].ToString();
                        }

                        foreach (DataRow fila in dt_menu2.Select(" COD_DISTRIBUCION= '" + cod_dis + "' and  NOM_DISTRIBUCION <> ''  "))
                        {
                            distribucion = fila["NOM_DISTRIBUCION"].ToString();
                        }

                        if (cod_menu_ped_ali == 0)
                        {
                            foreach (DataRow fila in dt_menu.Select(" COD_DISTRIBUCION= '" + cod_dis + "' and  COD_ALIMENTO= '" + cod_ali + "' "))
                            {
                                grilla_menu.Rows.RemoveAt(grilla_menu.CurrentRow.Index);
                                dt_menu.AcceptChanges();
                            }
                          


                            foreach (DataRow fila in dt_menu.Select(" COD_TIPO_COMIDA= '" + cod_tipo + "'"))
                            {

                                fila["NOM_TIPO_COMIDA"] = txttipo_comida.Text.ToUpper();
                                dt_menu.AcceptChanges();
                            }
                            foreach (DataRow fila in dt_menu.Select(" COD_DISTRIBUCION= '" + cod_dis + "'"))
                            {

                                fila["NOM_DISTRIBUCION"] = distribucion;
                                dt_menu.AcceptChanges();
                            }
                    


                            MessageBox.Show("Estimado usuario, El Alimento  sea  Eliminado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            foreach (DataRow fila in dt_menu.Select(" COD_TIPO_COMIDA= '" + cod_tipo + "' AND  COD_DISTRIBUCION= '" + cod_dis + "' AND  COD_ALIMENTO= '" + cod_ali + "'"))
                            {

                                if (fila["VIGENCIA"].ToString() == "S")
                                {
                                    fila["VIGENCIA"] = "N";
                                }
                                else
                                {
                                    fila["VIGENCIA"] = "S";
                                }
                                
                            }
                            dt_menu.AcceptChanges();

                            foreach (DataRow fila in dt_menu.Select(" COD_TIPO_COMIDA= '" + cod_tipo + "'"))
                            {
                                fila["NOM_TIPO_COMIDA"] = txttipo_comida.Text.ToUpper();
                                dt_menu.AcceptChanges();
                            }
                            foreach (DataRow fila in dt_menu.Select(" COD_DISTRIBUCION= '" + cod_dis + "'"))
                            {

                                fila["NOM_DISTRIBUCION"] = distribucion;
                                dt_menu.AcceptChanges();
                            }

                            MessageBox.Show("Estimado usuario, El Alimento no se puede Eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            limpiar_alimento();
            grilla_menu.DataSource = new DataView(dt_menu, "VIGENCIA ='S'", "COD_DISTRIBUCION", DataViewRowState.CurrentRows);
            agrupar_celdas_menu();

        
        }



        #endregion

        #endregion


        #endregion

        #region Botones

        private void btn_guardar_Click(object sender, EventArgs e)
        {
              int cont = 0;
            int cod_id = 0;
            int cod_reg = 0;
            int cod_d = 0;
            int cod_d2 = 0;
            int cod_a = 0;
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            try
            {

                DialogResult opc = MessageBox.Show("Estimado usuario, Desea Guardar La información Ingresada?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opc == DialogResult.Yes)
                {

                    if (dt_menu.Rows.Count > 0)
                    {

                        CnnFalp.IniciarTransaccion();


                        foreach (DataRow fila in dt_menu.Select("", "COD_DISTRIBUCION"))
                        {
                            
                          cod_id= Convert.ToInt32(fila["COD_MENU_PED_ALI"].ToString());
                          cod_reg = Convert.ToInt32(fila["COD_MENU_REG_DET"].ToString());  
                          cod_menu = Convert.ToInt32(fila["COD_MENU"].ToString());
                          cod_d = Convert.ToInt32(fila["COD_DISTRIBUCION"].ToString());
                          cod_a = Convert.ToInt32(fila["COD_ALIMENTO"].ToString());

                          if (cod_id == 0)
                          {
                             // Guardar_Menu();
                              Guardar_Menu_Reg_Det(cod_d,cod_a,cod_id,cod_reg, cod_d2);
                              cod_d2 = cod_d;
                          }

                          else
                          {
                              Modificar_Menu_dia(cod_id);
                              Modificar_Menu_Distribucion();
                          }
                     
                        }

                     

                        CnnFalp.ConfirmarTransaccion();
                        CnnFalp.Cerrar();

                        if (cod_menu_ped_ali > 1)
                        {
                            MessageBox.Show("Estimado usuario, El Menú sea Insertado Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Estimado usuario, Error el Menú  no  sea Insertado Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        limpiar_alimento();
                        limpiar_menu();
                        bloquear();
                        dt_menu.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Estimado usuario, El menú del dia no se encuentra  con información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                txttipo_menu.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CnnFalp.ReversarTransaccion();

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_menu();
            limpiar_alimento();
            btn_distribucion.Enabled = false;
            txtdistribucion.Enabled = false;
            dt_menu.Clear();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (Validar_Campos_1())
            {
                DialogResult opc = MessageBox.Show("Estimado usuario, Esta seguro de la Configuración ingresada ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opc == DialogResult.Yes)
                {
                    Cargar_grilla_menu();
                    btn_confirmar.Enabled = true;
                    txtdistribucion.Focus();
                    //   Guardar_Menu();
                    bloquear_menu();
                    txtdistribucion.Enabled = true;
                    btn_distribucion.Enabled = true;
                    btn_agregar.Enabled = false;
                    Crear_Tbl_Alimentos();
                    grilla_menu.Enabled = true;
                    btn_guardar.Enabled = true;
                }
                else
                {
                    limpiar_menu();
                }
                btn_confirmar.Enabled = false;
                txtdistribucion.Focus();
            }
        }

        private void btn_menu_limpiar_Click(object sender, EventArgs e)
        {
               limpiar_menu();
               dt_menu.Clear();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
               if (Validar_Campos_2())
            {

                Guardar_alimento();
                btn_guardar.Enabled = true;
                txtalimento.Text = "";
                cod_alimento = 0;
                txtdistribucion.Text = "";
                cod_distribucion = 0;
                txtdistribucion.Focus();
                dt_alimento_agregar.Clear();
                limpiar_alimento();

            }
        }

        private void btn_limpiar_alimento_Click(object sender, EventArgs e)
        {
             limpiar_alimento();
        }

        private void btn_tipo_menu_Click(object sender, EventArgs e)
        {
              txttipo_menu.Text = "";
              Cargar_tipo_menu();

              if (cod_tipo_menu == 0)
              {
                  txtdia.Enabled = false;
                  txttipo_menu.Focus();
                  Cargar_tipo_menu();

              }
              else
              {
                  txtdia.Enabled = true;
                  btn_dia.Enabled = true;
                  txtdia.Focus();
              }
        }

        private void btn_dia_Click(object sender, EventArgs e)
        {
             txtdia.Text = "";
             Cargar_dia();

             if (cod_dia == 0)
             {
                 txttipo_comida.Enabled = false;
                 txtdia.Focus();
                 Cargar_dia();
             }
             else
             {
                 txttipo_comida.Enabled = true;
                 btn_tipo_comida.Enabled = true;
                 txttipo_comida.Focus();
             }
        }

        private void btn_tipo_comida_Click(object sender, EventArgs e)
        {
               txttipo_comida.Text = "";
               Cargar_tipo_comida();

               if (cod_tipo_comida == 0)
               {
                   btn_confirmar.Enabled = false;
                   txttipo_comida.Focus();
                  
               }
               else
               {                 
                   btn_confirmar.Enabled = true;
                   btn_confirmar.Focus();
               }
        }

        private void btn_distribucion_Click(object sender, EventArgs e)
        {
            txtdistribucion.Text = "";
            Cargar_tipo_distribucion();


            if (cod_distribucion == 0)
            {
                txtalimento.Enabled = false;
                txtdistribucion.Focus();
               
            }
            else
            {

                txtalimento.Enabled = true;
                btn_alimentos.Enabled = true;
                txtalimento.Focus();
            }
        }

        private void btn_alimentos_Click(object sender, EventArgs e)
        {
            txtalimento.Text = "";
            Cargar_alimento();

            if (cod_alimento == 0)
            {
                btn_agregar.Enabled = false;
                txtalimento.Focus();
                Cargar_alimento();
            }
            else
            {

                btn_agregar.Enabled = true;
                btn_agregar.Focus();
            }
    
        }

        #endregion

        #region Metodos

        #region Limpiar

        protected void limpiar_menu()
        {
            txttipo_menu.Text = "";
            cod_tipo_menu = 0;
            txtdia.Text = "";
            cod_dia = 0;
            txttipo_comida.Text = "";
            cod_tipo_comida = 0;
            btn_confirmar.Enabled = false;
            txttipo_menu.Enabled = true;
            btn_tipo_menu.Enabled = true;
            btn_dia.Enabled = false;
            txtdia.Enabled = false;
            btn_tipo_comida.Enabled = false;
            txttipo_comida.Enabled = false;
            txttipo_menu.Focus();
        }

        protected void limpiar_alimento()
        {
            txtdistribucion.Text = "";
            cod_distribucion = 0;
            txtalimento.Text = "";
            cod_alimento = 0;
            btn_agregar.Enabled = false;
            txtdistribucion.Enabled = true;
            btn_distribucion.Enabled = true;
            txtalimento.Enabled = false;
            btn_alimentos.Enabled = false;
        }


        #endregion

        #region Cargar Tipo menu

        protected void Cargar_tipo_menu()
        {
            Cargar_datos_tipo_menu(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_tipo_menu = Convert.ToInt32(Ayuda.Fields(0));
                txttipo_menu.Text = Ayuda.Fields(1);
            }
            else
            {
                if(cod_tipo_menu==0)
                {
                    txttipo_menu.Text = "";
                }
            }


        }

        void Cargar_datos_tipo_menu(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar Tipo de Menú";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_TIPO_MENU";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txttipo_menu.Text.ToUpper(), DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }

        #endregion

        #region Cargar Dia

        protected void Cargar_dia()
        {
            Cargar_datos_dia(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_dia = Convert.ToInt32(Ayuda.Fields(0));
                txtdia.Text = Ayuda.Fields(1);
            }
            else
            {
                if (cod_dia == 0)
                {
                    txtdia.Text = "";
                }
            }

        }

        void Cargar_datos_dia(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar el Día del Menú";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_DIA";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txtdia.Text, DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }


        #endregion

        #region Cargar tipo Comida

        protected void Cargar_tipo_comida()
        {
            Cargar_datos_tipo_comida(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_tipo_comida = Convert.ToInt32(Ayuda.Fields(0));
                txttipo_comida.Text = Ayuda.Fields(1);
            }
            else
            {
                if (cod_tipo_comida == 0)
                {
                    txttipo_comida.Text = "";
                }
            }

            Cargar_grilla_menu();

            if (dt_menu.Rows.Count == 0)
            {
                MessageBox.Show("Estimado usuario, El menú no se encuentra registrado, para este Día", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar_menu();
                dt_menu.Clear();
                limpiar_menu();

            }
            else
            {
                btn_confirmar.Enabled = true;
                btn_confirmar.Focus();
            }

        }

        void Cargar_datos_tipo_comida(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar Tipo de Comida";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_TIPO_COMIDA";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txttipo_comida.Text.ToUpper(), DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }


        #endregion

        #region Cargar Distribucion

        protected void Cargar_tipo_distribucion()
        {
            Cargar_datos_tipo_distribucion(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_distribucion = Convert.ToInt32(Ayuda.Fields(0));
                txtdistribucion.Text = Ayuda.Fields(1);
            }
            else
            {
                if (cod_distribucion == 0)
                {
                    txtdistribucion.Text = "";
                }
            }


        }

        void Cargar_datos_tipo_distribucion(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar Tipo de Distribución";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_DISTRIBUCION_MENU";
            Ayuda.Generar_ParametroBD("PIN_CODIGO", cod_tipo_comida, DbType.Int32, ParameterDirection.Input);
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txtdistribucion.Text, DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }


        #endregion

        #region Cargar Alimento

        protected void Cargar_alimento()
        {
            Cargar_datos_alimento(ref Ayuda);

            int cont = 0;
            while (!Ayuda.EOF())
            {
                cont++;
                if (cont == 1)
                {
                    cod_alimento = Convert.ToInt32(Ayuda.Fields(0));
                    txtalimento.Text = Ayuda.Fields(1);
                    agregar_alimentos(cod_alimento, txtalimento.Text.ToUpper());
                }

                else
                {
                    cod_alimento = Convert.ToInt32(Ayuda.Fields(0));
                    txtalimento.Text = Ayuda.Fields(1);
                    agregar_alimentos(cod_alimento, txtalimento.Text.ToUpper());

                }

                Ayuda.MoveNext();
            }

             
                if (cod_alimento == 0)
                {
                    txtalimento.Text = "";
                }
            
        }

        void Cargar_datos_alimento(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.Multi_Seleccion = true;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar Alimento";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_ALIMENTO";
            Ayuda.Generar_ParametroBD("PIN_CODIGO", cod_distribucion, DbType.Int32, ParameterDirection.Input);
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txtalimento.Text, DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }


        #endregion

        #region Sumar dias semana

        public string SumarDiaDeLaSemana(string semana, string dia, DateTime fecha)
        {
            string fec = "";
            if (semana == "1" && dia == "1" || semana == "2" && dia == "1") { return fec = fecha.AddDays(0).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
            else
            {
                if (semana == "1" && dia == "2" || semana == "2" && dia == "2") { return fec = fecha.AddDays(1).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                else
                {
                    if (semana == "1" && dia == "3" || semana == "2" && dia == "3") { return fec = fecha.AddDays(2).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                    else
                    {
                        if (semana == "1" && dia == "4" || semana == "2" && dia == "4") { return fec = fecha.AddDays(3).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                        else
                        {
                            if (semana == "1" && dia == "5" || semana == "2" && dia == "5") { return fec = fecha.AddDays(4).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                            else
                            {
                                if (semana == "1" && dia == "6" || semana == "2" && dia == "6") { return fec = fecha.AddDays(5).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                else
                                {
                                    if (semana == "1" && dia == "7" || semana == "2" && dia == "7") { return fec = fecha.AddDays(6).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                    else
                                    {
                                        if (semana == "2" && dia == "1" || semana == "2" && dia == "8") { return fec = fecha.AddDays(7).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                        else
                                        {
                                            if (semana == "2" && dia == "2" || semana == "2" && dia == "9") { return fec = fecha.AddDays(8).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                            else
                                            {
                                                if (semana == "2" && dia == "3" || semana == "2" && dia == "10") { return fec = fecha.AddDays(9).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                                else
                                                {
                                                    if (semana == "2" && dia == "4" || semana == "2" && dia == "11") { return fec = fecha.AddDays(10).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                                    else
                                                    {
                                                        if (semana == "2" && dia == "5" || semana == "2" && dia == "12") { return fec = fecha.AddDays(11).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                                        else
                                                        {
                                                            if (semana == "2" && dia == "6" || semana == "2" && dia == "13") { return fec = fecha.AddDays(12).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                                            else
                                                            {
                                                                if (semana == "2" && dia == "7" || semana == "2" && dia == "14") { return fec = fecha.AddDays(13).ToString("dd-MM-yyyy"); fecha_termino = fecha.AddDays(10).ToString("dd-MM-yyyy"); }
                                                                else
                                                                {
                                                                    return fec = fecha.AddDays(0).ToString("dd-MM-yyyy");
                                                                }

                                                            }

                                                        }

                                                    }

                                                }

                                            }

                                        }

                                    }

                                }

                            }

                        }
                    }
                }

            }
        }
        #endregion

        #region Guardar Menu

        protected void Guardar_Menu_Reg_Det(int cod_d, int cod_a, int  cod_id,int cod_reg , int cod_d2)
        {
            int cod = 0;
            int cod1 = 0;
            int cod_ali = 0;
            int cont = 0;
          

           
                if (cod_reg == 0)
                {

                    if (cod_d != cod_d2)
                    {
                        if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
                        CnnFalp.CrearCommand(CommandType.StoredProcedure, "PCK_NUT001I.P_REGISTRAR_MENU_REG_DET");

                        CnnFalp.ParametroBD("PIN_COD_MENU_DET", cod_menu_det, DbType.Int64, ParameterDirection.Input);
                        CnnFalp.ParametroBD("PIN_DESTRIBUCION_COM", cod_d, DbType.Int64, ParameterDirection.Input);
                        CnnFalp.ParametroBD("PIN_USUARIO", User.ToUpper().Trim(), DbType.String, ParameterDirection.Input);
                        CnnFalp.ParametroBD("PIN_FECHA", fecha_registrar, DbType.String, ParameterDirection.Input);
                        CnnFalp.ParametroBD("POUT_MENU_REG_DET", 0, DbType.Int64, ParameterDirection.Output);

                        int registro = CnnFalp.ExecuteNonQuery();


                        cod_menu_reg_det = Convert.ToInt32(CnnFalp.ParamValue("POUT_MENU_REG_DET").ToString());

                    }
                    
                    Guardar_Menu_Ped_Det(cod_menu_reg_det, cod_a);

                }
            
                else
                {
                    cod_menu_reg_det = cod_reg;
                    CnnFalp.CrearCommand(CommandType.StoredProcedure, "PCK_NUT001I.P_REGISTRAR_MENU_PED_ALI");

                    CnnFalp.ParametroBD("PIN_COD_MENU_REG_DET", cod_menu_reg_det, DbType.Int64, ParameterDirection.Input);
                    CnnFalp.ParametroBD("PIN_COD_ALIMENTOS", cod_a, DbType.Int64, ParameterDirection.Input);
                    CnnFalp.ParametroBD("PIN_CANTIDAD", 1, DbType.Int64, ParameterDirection.Input);
                    CnnFalp.ParametroBD("PIN_USUARIO", User.ToUpper().Trim(), DbType.String, ParameterDirection.Input);
                    CnnFalp.ParametroBD("POUT_MENU_PED_ALI", 0, DbType.Int64, ParameterDirection.Output);

                    int registro = CnnFalp.ExecuteNonQuery();
                    cod_menu_ped_ali = Convert.ToInt32(CnnFalp.ParamValue("POUT_MENU_PED_ALI").ToString());

                }
       
         
        }



        protected void Guardar_Menu_Ped_Det(int cod_menu_reg_det, int cod_ali)
        {
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            int registro = 0;
            int codigo = 0;
            int cod = 0;


            CnnFalp.CrearCommand(CommandType.StoredProcedure, "PCK_NUT001I.P_REGISTRAR_MENU_PED_ALI");

            CnnFalp.ParametroBD("PIN_COD_MENU_REG_DET", cod_menu_reg_det, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_COD_ALIMENTOS", cod_ali, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_CANTIDAD", 1, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_USUARIO", User.ToUpper().Trim(), DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("POUT_MENU_PED_ALI", 0, DbType.Int64, ParameterDirection.Output);

            registro = CnnFalp.ExecuteNonQuery();
            cod_menu_ped_ali = Convert.ToInt32(CnnFalp.ParamValue("POUT_MENU_PED_ALI").ToString());


        }

        #endregion

        #region Guardar Alimento

        private void Crear_Tbl_Alimentos()
        {
            dt_alimento_agregar.Columns.Clear();

            dt_alimento_agregar.Columns.Add("cod_alimento", typeof(int));
            dt_alimento_agregar.Columns.Add("nom_alimento", typeof(string));
            dt_alimento_agregar.Columns.Add("cod_distribucion2", typeof(int));

        }


        protected void Guardar_alimento()
        {
            Extraer_codigo();

            string codigo = "";
            int cont = 0;
            int cod_dis = 0;
            int id_dis = 0;
            foreach (DataRow fila in dt_alimento_agregar.Rows)
            {

                codigo = fila["COD_ALIMENTO"].ToString();
                cod_dis = Convert.ToInt32(fila["COD_DISTRIBUCION2"].ToString());

                if (codigo != "")
                {
                    foreach (DataRow fila3 in dt_menu.Select(" COD_MENU_DET <> 0"))
                    {
                        cod_menu_det = Convert.ToInt32(fila3["COD_MENU_DET"].ToString().Trim());
                    }

                    foreach (DataRow fila4 in dt_menu.Select(" COD_DISTRIBUCION= '" + Convert.ToInt32(cod_dis) + "' "))
                    {
                        id_dis = Convert.ToInt32(fila4["COD_MENU_REG_DET"].ToString().Trim());
                    }

                    foreach (DataRow fila2 in dt_menu.Select(" COD_ALIMENTO= '" + Convert.ToInt32(codigo) + "'"))
                    {
                        cont++;
                        id_dis = Convert.ToInt32(fila2["COD_MENU_REG_DET"].ToString().Trim());
                    }

                    if (cont == 0)
                    {
                        DataRow Fila = dt_menu.NewRow();
                        Fila["COD_MENU"] = cod_menu;
                        Fila["COD_TIPO_MENU"] = cod_tipo_menu;
                        Fila["COD_DIA"] = cod_dia;
                        Fila["COD_TIPO_COMIDA"] = cod_tipo_comida;
                        Fila["COD_DISTRIBUCION"] = cod_distribucion;
                        Fila["COD_ALIMENTO"] = fila["COD_ALIMENTO"].ToString();
                        Fila["NOM_TIPO_COMIDA"] = Validar_nom_tipo();
                        Fila["NOM_DISTRIBUCION"] = Validar_nom_dist();
                        Fila["NOM_ALIMENTO"] = fila["NOM_ALIMENTO"].ToString();
                        Fila["COD_MENU_DET"] = cod_menu_det;
                        Fila["COD_MENU_REG_DET"] = id_dis;
                        Fila["VIGENCIA"] = "S";
                        Fila["COD_MENU_PED_ALI"] = 0;
                        dt_menu.Rows.Add(Fila);
                        dt_menu2 = dt_menu;
                        grilla_menu.AutoGenerateColumns = false;
                        dt_menu.DefaultView.Sort = "COD_DISTRIBUCION";
                        grilla_menu.DataSource = new DataView(dt_menu, "VIGENCIA ='S'", "COD_DISTRIBUCION", DataViewRowState.CurrentRows);

                        agrupar_celdas_menu();
                    }
                    else
                    {
                        foreach (DataRow fila1 in dt_menu.Select(" COD_TIPO_COMIDA= '" + cod_tipo_comida + "' AND  COD_DISTRIBUCION= '" + cod_distribucion + "' AND  COD_ALIMENTO= '" + codigo + "'"))
                        {
                            fila1["NOM_TIPO_COMIDA"] = Validar_nom_tipo();
                            fila1["NOM_DISTRIBUCION"]=Validar_nom_dist();
                            if (fila1["VIGENCIA"].ToString() == "N")
                            {
                                fila1["VIGENCIA"] = "S";
                            }
                            else
                            {
                                MessageBox.Show("Estimado usuario, El alimento se registro correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtalimento.Text = "";
                                cod_alimento = 0;
                            }

                        }
                        dt_menu.AcceptChanges();

                    }
                }
            }

        }

        protected string Validar_nom_tipo()
        {
            string valor="";

        
            foreach (DataRow fila3 in dt_menu.Select(" NOM_TIPO_COMIDA <> null" ))
             {
                 valor = fila3["NOM_TIPO_COMIDA"].ToString();
             }

            return valor;
        }

        protected string Validar_nom_dist()
        {
            string valor = "";

            foreach (DataRow fila3 in dt_menu.Select(" NOM_DISTRIBUCION <> null  and COD_DISTRIBUCION=' "+ cod_distribucion +" '"))
            {
                valor = fila3["NOM_DISTRIBUCION"].ToString();
            }

            return valor;
        }

        protected void agregar_alimentos(int cod, string nom)
        {
            // Crear_Tbl_Alimentos();
            if (cod > 0 && nom != "")
            {
                DataRow Fila = dt_alimento_agregar.NewRow();
                Fila["COD_ALIMENTO"] = cod;
                Fila["NOM_ALIMENTO"] = nom.ToUpper();
                Fila["COD_DISTRIBUCION2"] = cod_distribucion;

                dt_alimento_agregar.Rows.Add(Fila);

                dt_alimento_agregar.AcceptChanges();
            }

        }

        protected void Extraer_codigo()
        {
            int cont = 0;
            foreach (DataRow fila2 in dt_menu.Select(" COD_TIPO_COMIDA= '" + cod_tipo_comida + "' and  COD_DISTRIBUCION= '" + cod_distribucion + "'"))
            {
                if (cont == 0)
                {
                    cod_menu = Convert.ToInt32(fila2["COD_MENU"].ToString());
                    cod_menu_det = Convert.ToInt32(fila2["COD_MENU_DET"].ToString());
                    cod_menu_reg_det = Convert.ToInt32(fila2["COD_MENU_REG_DET"].ToString());
                }
                cont++;
            }
        }

        #endregion

        #region Modificar Alimento

        protected void Modificar_Menu_dia(int cod)
        {
            int v_ali = 0;
            int v_dis = 0;
            int v_id_ali = 0;
            string v_vig = "";
            foreach (DataRow miRow in dt_menu.Select("COD_MENU_PED_ALI = '" + cod + "'"))
            {
                if (dt_menu.Rows.Count > 0)
                {

                    v_ali = Convert.ToInt32(miRow["COD_ALIMENTO"].ToString());
                    v_dis = Convert.ToInt32(miRow["COD_DISTRIBUCION"].ToString().Trim());
                    v_vig = miRow["VIGENCIA"].ToString();
                    v_id_ali = Convert.ToInt32(miRow["COD_MENU_PED_ALI"].ToString().Trim());

                    CnnFalp.CrearCommand(CommandType.StoredProcedure, "PCK_NUT001M.P_MODIFICAR_MENU_ALIMENTO");
                    CnnFalp.ParametroBD("PIN_ALIMENTO_ID", v_id_ali, DbType.Int64, ParameterDirection.Input);
                    CnnFalp.ParametroBD("PIN_COD_ALIMENTO", v_ali, DbType.Int64, ParameterDirection.Input);
                    CnnFalp.ParametroBD("PIN_USUARIO", User.ToUpper().Trim(), DbType.String, ParameterDirection.Input);

                    CnnFalp.ParametroBD("PIN_VIGENCIA", v_vig.ToUpper().Trim(), DbType.String, ParameterDirection.Input);


                    int registro = CnnFalp.ExecuteNonQuery();


                }
            }
        }

        protected void Modificar_Menu_Distribucion()
        {
            string vig = "";
            int cod = 0;
            int id_d = 0;
            foreach (DataRow miRow in dt_menu.Rows)
            {
                cod = Convert.ToInt32(miRow["COD_DISTRIBUCION"].ToString());
                id_d = Convert.ToInt32(miRow["COD_MENU_REG_DET"].ToString());
                vig = Verificar_Distribucion(cod, id_d);
            }


        }

        protected string Verificar_Distribucion(int cod, int id)
        {
            string v = "";
            int cont = 0;
            foreach (DataRow miRow in dt_menu.Select("COD_DISTRIBUCION = '" + cod + "'"))
            {
                if (miRow["VIGENCIA"].ToString() == "S")
                {
                    cont++;
                }

            }

            if (cont == 0)
            {
                v = "N";
                Modificar(cod, v, id);
            }
            else
            {
                v = "S";
                Modificar(cod, v, id);
            }

            return v;

        }

        protected void Modificar(int cod, string vigencia, int id)
        {
            CnnFalp.CrearCommand(CommandType.StoredProcedure, "PCK_NUT001M.P_MODIFICAR_MENU_DISTRIBUCION");
            CnnFalp.ParametroBD("PIN_DISTRIBUCION_ID", id, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_COD_DISTRIBUCION", cod, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_USUARIO", User.ToUpper().Trim(), DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_VIGENCIA", vigencia.ToUpper().Trim(), DbType.String, ParameterDirection.Input);
          
            int registro = CnnFalp.ExecuteNonQuery();

        }


        #endregion

        #region Cargar fechas

        protected void Cargar_dt_fechas()
        {


            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".P_CARGAR_CONFIG_FECHAS");
            dt_fechas.Load(CnnFalp.ExecuteReader());

            CnnFalp.Cerrar();

            foreach (DataRow miRow in dt_fechas.Rows)
            {
                fecha_inicio = miRow["FECHA_INICIO"].ToString();
                mes_termino = miRow["MES_TERMINO"].ToString();

            }

        }

        void Extraer_fecha_sistema()
        {

            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

            CnnFalp.CrearCommand(CommandType.StoredProcedure, "PCK_NUT001I.P_EXTRAER_FECHA_SISTEMA");

            dt_fecha_sistema.Load(CnnFalp.ExecuteReader());


            foreach (DataRow miRow in dt_fecha_sistema.Rows)
            {
                fecha_sistema = miRow["FECHA"].ToString();
            }


        }

        #endregion


        protected void bloquear()
        {
            btn_confirmar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_agregar.Enabled = false;

            // sector menu
            txtdia.Enabled = false;
            btn_dia.Enabled = false;
            txttipo_comida.Enabled = false;
            btn_tipo_comida.Enabled = false;

            //  sector alimentos
            txtdistribucion.Enabled = false;
            txtalimento.Enabled = false;
            btn_distribucion.Enabled = false;
            btn_alimentos.Enabled = false;
            grilla_menu.Enabled = false;

        }

        protected void bloquear_menu()
        {


            // sector menu
            txttipo_menu.Enabled = false;
            btn_tipo_menu.Enabled = false;
            txtdia.Enabled = false;
            btn_dia.Enabled = false;
            txttipo_comida.Enabled = false;
            btn_tipo_comida.Enabled = false;
            txttipo_menu.Focus();
        }

        #endregion

        #region Validaciones

        protected Boolean Validar_Campos_1()
        {
            Boolean var = false;

            if (txttipo_menu.Text == "" && cod_tipo_menu == 0)
            {
                MessageBox.Show("Estimado usuario, El Campo Tipo Menú se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttipo_menu.Focus();
            }
            else
            {
                if (txtdia.Text == "" && cod_dia == 0)
                {
                    MessageBox.Show("Estimado usuario, El Campo Dia se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdia.Focus();
                }
                else
                {
                    if (txttipo_comida.Text == "" && cod_tipo_comida == 0)
                    {
                        MessageBox.Show("Estimado usuario, El Campo Tipo Comida se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtdia.Focus();
                    }
                    else
                    {

                        int cont = 0;
                        foreach (DataRow miRow in dt_menu.Select("COD_TIPO_MENU = '" + cod_tipo_menu + "' and  COD_DIA= '" + cod_dia + "'  and  COD_TIPO_COMIDA = '" + cod_tipo_comida + "'"))
                        {
                            cont++;
                        }

                        if (cont == 0)
                        {

                            var = true;
                            MessageBox.Show("Estimado usuario, El Menú Configurado no esta Registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            var = true;

                            txtdistribucion.Text = "";
                            cod_distribucion = 0;
                            txtdistribucion.Focus();
                        }
                    }

                }
            }

            return var;
        }

        protected Boolean Validar_Campos_2()
        {
            Boolean var = false;

            if (txtdistribucion.Text == "" && cod_distribucion == 0)
            {
                MessageBox.Show("Estimado usuario, El Campo Distribución se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdistribucion.Focus();
            }
            else
            {
                if (txtalimento.Text == "" && cod_alimento == 0)
                {
                    MessageBox.Show("Estimado usuario, El Campo Alimento se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdia.Focus();
                }
                else
                {

                    int cont = 0;
                    foreach (DataRow miRow in dt_menu.Select("COD_ALIMENTO = '" + cod_alimento + "'"))
                    {
                        cont++;
                    }

                    if (cont == 0)
                    {

                        var = true;
                    }
                    else
                    {

                        foreach (DataRow fila1 in dt_menu.Select(" COD_TIPO_COMIDA= '" + cod_tipo_comida + "' AND  COD_DISTRIBUCION= '" + cod_distribucion + "' AND  COD_ALIMENTO= '" + cod_alimento + "'"))
                        {

                            if (fila1["VIGENCIA"].ToString() == "N")
                            {

                                var = true;

                            }
                            else
                            {
                                MessageBox.Show("Estimado usuario, El Alimento Ingresado  ya se encuentra Registrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtalimento.Text = "";
                                cod_alimento = 0;
                                var = false;
                            }

                        }
                        dt_menu.AcceptChanges();

                        /* MessageBox.Show("Estimado usuario, El Alimento ya se encuentra ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         var = false;
                         txtalimento.Text = "";
                         cod_alimento = 0;
                         txtalimento.Focus();*/
                    }

                }
            }

            return var;
        }



        private void txttipo_menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {

                e.Handled = true;

                return;
            }
            else
            {
                Cargar_tipo_menu();
                if (e.KeyChar == (char)13)
                {
                   
                    if (cod_tipo_menu == 0)
                    {
                        txtdia.Enabled = false;
                        txttipo_menu.Focus();

                    }
                    else
                    {

                        txtdia.Enabled = true;
                        btn_dia.Enabled = true;
                        txtdia.Focus();
                    }


                }
            }
        }

        private void txtdia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {

                e.Handled = true;

                return;
            }
            else
            {
                Cargar_dia();
                if (e.KeyChar == (char)13)
                {

                    if (cod_dia == 0)
                    {
                        txttipo_comida.Enabled = false;
                        txtdia.Focus();
                       
                    }
                    else
                    {

                        txttipo_comida.Enabled = true;
                        btn_tipo_comida.Enabled = true;
                        txttipo_comida.Focus();
                    }


                }
            }
        }

        private void txttipo_comida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {

                e.Handled = true;

                return;
            }
            else
            {
                Cargar_tipo_comida();
                if (e.KeyChar == (char)13)
                {

                    if (cod_tipo_comida == 0)
                    {
                        btn_confirmar.Enabled = false;
                        txttipo_comida.Focus();
                    
                    }
                    else
                    {

                        btn_confirmar.Enabled = true;
                    }



                }
            }
        }

        private void txtdistribucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {

                e.Handled = true;

                return;
            }
            else
            {
                Cargar_tipo_distribucion();
                if (e.KeyChar == (char)13)
                {

                    if (cod_distribucion == 0)
                    {
                        txtalimento.Enabled = false;
                        txtdistribucion.Focus();

                    }
                    else
                    {

                        txtalimento.Enabled = true;
                        btn_alimentos.Enabled = true;
                        txtalimento.Focus();
                    }


                }
            }
        }

        private void txtalimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {

                e.Handled = true;

                return;
            }
            else
            {
              //  Cargar_alimento();
                if (e.KeyChar == (char)13)
                {
                    Cargar_alimento();
                    if (cod_alimento == 0)
                    {
                        btn_agregar.Enabled = false;
                        txtalimento.Focus();

                    
                    }
                    else
                    {

                        btn_agregar.Enabled = true;
                        btn_agregar.Focus();
                    }

                }
            }
     
        }



        private void CambiarBlanco_TextLeave(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.White;

        }

        private void CambiarColor_TextEnter(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.FromArgb(255, 224, 192);
        }
     

        #endregion


     
    }
}
