namespace SistemaEvaluacionDesempeno
{
    partial class HourlyRas2
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlyRas2));
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup7 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup8 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup9 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup10 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup11 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup12 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule6 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector1 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule7 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector2 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule8 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule9 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector3 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule10 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector4 = new Telerik.Reporting.Drawing.DescendantSelector();
            this.UsuarioEvaluado = new Telerik.Reporting.SqlDataSource();
            this.sql_ds_PerformanceDefinitions = new Telerik.Reporting.SqlDataSource();
            this.PlantillaEvaluacion = new Telerik.Reporting.SqlDataSource();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.Titulo = new Telerik.Reporting.TextBox();
            this.imgFromex = new Telerik.Reporting.PictureBox();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.txtNomEmp = new Telerik.Reporting.TextBox();
            this.txtPuesto = new Telerik.Reporting.TextBox();
            this.txtPeriodo = new Telerik.Reporting.TextBox();
            this.txtPrdo = new Telerik.Reporting.TextBox();
            this.txtGerente = new Telerik.Reporting.TextBox();
            this.txtProposito = new Telerik.Reporting.TextBox();
            this.txtNombreEmp = new Telerik.Reporting.TextBox();
            this.txtDescripcionPuesto = new Telerik.Reporting.TextBox();
            this.txtJefe = new Telerik.Reporting.TextBox();
            this.tblDescripcion = new Telerik.Reporting.Table();
            this.txtCalificacionYNombre = new Telerik.Reporting.TextBox();
            this.txtDescripcion = new Telerik.Reporting.TextBox();
            this.txtDefCalRend = new Telerik.Reporting.TextBox();
            this.list1 = new Telerik.Reporting.List();
            this.panel1 = new Telerik.Reporting.Panel();
            this.htmlTextBox1 = new Telerik.Reporting.HtmlTextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.table1 = new Telerik.Reporting.Table();
            this.htmlTextBox2 = new Telerik.Reporting.HtmlTextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.htmltxtCalif = new Telerik.Reporting.HtmlTextBox();
            this.htmlTextBox4 = new Telerik.Reporting.HtmlTextBox();
            this.htmlTextBox5 = new Telerik.Reporting.HtmlTextBox();
            this.htmlTextBox3 = new Telerik.Reporting.HtmlTextBox();
            this.txtRevision = new Telerik.Reporting.HtmlTextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // UsuarioEvaluado
            // 
            this.UsuarioEvaluado.CalculatedFields.AddRange(new Telerik.Reporting.CalculatedField[] {
            new Telerik.Reporting.CalculatedField("Date", typeof(System.DateTime), "= Today()")});
            this.UsuarioEvaluado.ConnectionString = "data source=MXNL-WS02\\PRODUCTION;initial catalog=Evaluacion;user id=RasLabel;pass" +
    "word=Etiquetas;multipleactiveresultsets=True;application name=EntityFramework&qu" +
    "ot;";
            this.UsuarioEvaluado.Name = "UsuarioEvaluado";
            this.UsuarioEvaluado.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@NumEmp", System.Data.DbType.Int32, "= Parameters.NumEmp.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@idEva", System.Data.DbType.Int32, "= Parameters.idEvaluacion.Value")});
            this.UsuarioEvaluado.ProviderName = "System.Data.SqlClient";
            this.UsuarioEvaluado.SelectCommand = "dbo.sp_CargarDatosReporte2";
            this.UsuarioEvaluado.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // sql_ds_PerformanceDefinitions
            // 
            this.sql_ds_PerformanceDefinitions.ConnectionString = "data source=MXNL-WS02\\PRODUCTION;initial catalog=Evaluacion;user id=RasLabel;pass" +
    "word=Etiquetas;multipleactiveresultsets=True;application name=EntityFramework&qu" +
    "ot;";
            this.sql_ds_PerformanceDefinitions.Name = "sql_ds_PerformanceDefinitions";
            this.sql_ds_PerformanceDefinitions.ProviderName = "System.Data.SqlClient";
            this.sql_ds_PerformanceDefinitions.SelectCommand = "SELECT NumeroCalificacion, Nombre, PalabraClave, Descripcion  FROM CALIFICACIONDE" +
    "RENDIMIENTO\r\nWHERE NumeroCalificacion <> 0";
            // 
            // PlantillaEvaluacion
            // 
            this.PlantillaEvaluacion.ConnectionString = "data source=MXNL-WS02\\PRODUCTION;initial catalog=Evaluacion;user id=RasLabel;pass" +
    "word=Etiquetas;multipleactiveresultsets=True;application name=EntityFramework&qu" +
    "ot;";
            this.PlantillaEvaluacion.Name = "PlantillaEvaluacion";
            this.PlantillaEvaluacion.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@NumEmp", System.Data.DbType.Int32, "= Parameters.NumEmp.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@idEva", System.Data.DbType.Int32, "= Parameters.idEvaluacion.Value")});
            this.PlantillaEvaluacion.ProviderName = "System.Data.SqlClient";
            this.PlantillaEvaluacion.SelectCommand = "dbo.sp_CargarReporte2";
            this.PlantillaEvaluacion.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0236221551895142D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.Titulo,
            this.imgFromex});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            this.pageHeaderSection1.Style.BorderColor.Bottom = System.Drawing.Color.White;
            this.pageHeaderSection1.Style.BorderColor.Left = System.Drawing.Color.White;
            this.pageHeaderSection1.Style.BorderColor.Right = System.Drawing.Color.White;
            this.pageHeaderSection1.Style.BorderColor.Top = System.Drawing.Color.White;
            this.pageHeaderSection1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.pageHeaderSection1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.pageHeaderSection1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.pageHeaderSection1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.pageHeaderSection1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.pageHeaderSection1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.pageHeaderSection1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.pageHeaderSection1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            // 
            // Titulo
            // 
            this.Titulo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2205114364624023D), Telerik.Reporting.Drawing.Unit.Inch(0.11811017990112305D));
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.3975977897644043D), Telerik.Reporting.Drawing.Unit.Inch(0.78740143775939941D));
            this.Titulo.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.Titulo.Style.Color = System.Drawing.Color.White;
            this.Titulo.Style.Font.Bold = true;
            this.Titulo.Style.Font.Name = "Segoe UI";
            this.Titulo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            this.Titulo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.Titulo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.Titulo.Value = "Revisión Anual de Desempeño \r\nHourly -Personal Técnico";
            // 
            // imgFromex
            // 
            this.imgFromex.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.11811017990112305D));
            this.imgFromex.Name = "imgFromex";
            this.imgFromex.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.220393180847168D), Telerik.Reporting.Drawing.Unit.Inch(0.787401556968689D));
            this.imgFromex.Style.BackgroundImage.ImageData = ((System.Drawing.Image)(resources.GetObject("imgFromex.Style.BackgroundImage.ImageData")));
            this.imgFromex.Style.BackgroundImage.MimeType = "image/png";
            this.imgFromex.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            // 
            // detailSection1
            // 
            this.detailSection1.Bindings.Add(new Telerik.Reporting.Binding("Height", "=\"1in\""));
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(5.5511808395385742D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtNomEmp,
            this.txtPuesto,
            this.txtPeriodo,
            this.txtPrdo,
            this.txtGerente,
            this.txtProposito,
            this.txtNombreEmp,
            this.txtDescripcionPuesto,
            this.txtJefe,
            this.tblDescripcion,
            this.list1,
            this.table1,
            this.htmltxtCalif,
            this.htmlTextBox4,
            this.htmlTextBox5,
            this.htmlTextBox3,
            this.txtRevision,
            this.textBox15,
            this.textBox7,
            this.textBox5,
            this.textBox9,
            this.textBox11,
            this.textBox12,
            this.textBox13,
            this.textBox18,
            this.textBox17});
            this.detailSection1.Name = "detailSection1";
            this.detailSection1.Style.BorderColor.Bottom = System.Drawing.Color.White;
            this.detailSection1.Style.BorderColor.Left = System.Drawing.Color.White;
            this.detailSection1.Style.BorderColor.Right = System.Drawing.Color.White;
            this.detailSection1.Style.BorderColor.Top = System.Drawing.Color.White;
            this.detailSection1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detailSection1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detailSection1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detailSection1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detailSection1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.detailSection1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.detailSection1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.detailSection1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4567722082138062D), Telerik.Reporting.Drawing.Unit.Inch(0.11811001598834992D));
            this.txtNomEmp.Style.Font.Bold = false;
            this.txtNomEmp.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtNomEmp.Value = "Nombre del empleado";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0944881439208984D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.66929131746292114D), Telerik.Reporting.Drawing.Unit.Inch(0.11811002343893051D));
            this.txtPuesto.Style.Font.Bold = false;
            this.txtPuesto.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtPuesto.Value = "Puesto";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4568510055541992D), Telerik.Reporting.Drawing.Unit.Inch(0.11830711364746094D));
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8896052837371826D), Telerik.Reporting.Drawing.Unit.Inch(0.1181890144944191D));
            this.txtPeriodo.Style.Font.Bold = true;
            this.txtPeriodo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtPeriodo.Value = "FY18";
            // 
            // txtPrdo
            // 
            this.txtPrdo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.11814943701028824D));
            this.txtPrdo.Name = "txtPrdo";
            this.txtPrdo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4567722082138062D), Telerik.Reporting.Drawing.Unit.Inch(0.1181890144944191D));
            this.txtPrdo.Style.Font.Bold = false;
            this.txtPrdo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtPrdo.Value = "Periodo De Revisión";
            // 
            // txtGerente
            // 
            this.txtGerente.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.3465354442596436D), Telerik.Reporting.Drawing.Unit.Inch(0.11807060241699219D));
            this.txtGerente.Name = "txtGerente";
            this.txtGerente.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4172440767288208D), Telerik.Reporting.Drawing.Unit.Inch(0.11826785653829575D));
            this.txtGerente.Style.Font.Bold = false;
            this.txtGerente.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtGerente.Value = "Supervisor/Gerente";
            // 
            // txtProposito
            // 
            this.txtProposito.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.35480308532714844D));
            this.txtProposito.Name = "txtProposito";
            this.txtProposito.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.618070125579834D), Telerik.Reporting.Drawing.Unit.Inch(0.35433030128479004D));
            this.txtProposito.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.txtProposito.Value = resources.GetString("txtProposito.Value");
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4568510055541992D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6376371383666992D), Telerik.Reporting.Drawing.Unit.Inch(0.11803118139505386D));
            this.txtNombreEmp.Style.Font.Bold = true;
            this.txtNombreEmp.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtNombreEmp.Value = "= Fields.Nombre";
            // 
            // txtDescripcionPuesto
            // 
            this.txtDescripcionPuesto.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7638583183288574D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtDescripcionPuesto.Name = "txtDescripcionPuesto";
            this.txtDescripcionPuesto.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8542511463165283D), Telerik.Reporting.Drawing.Unit.Inch(0.11814943701028824D));
            this.txtDescripcionPuesto.Style.Font.Bold = true;
            this.txtDescripcionPuesto.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtDescripcionPuesto.Value = "= Fields.Descripcion";
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7638583183288574D), Telerik.Reporting.Drawing.Unit.Inch(0.11822827905416489D));
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8542511463165283D), Telerik.Reporting.Drawing.Unit.Inch(0.11811017990112305D));
            this.txtJefe.Style.Font.Bold = true;
            this.txtJefe.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtJefe.Value = "= Fields.JEFE";
            // 
            // tblDescripcion
            // 
            this.tblDescripcion.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.9510948657989502D)));
            this.tblDescripcion.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(5.6669325828552246D)));
            this.tblDescripcion.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.1041666567325592D)));
            this.tblDescripcion.Body.SetCellContent(0, 0, this.txtCalificacionYNombre);
            this.tblDescripcion.Body.SetCellContent(0, 1, this.txtDescripcion);
            tableGroup2.Name = "group4";
            tableGroup3.Name = "group3";
            tableGroup1.ChildGroups.Add(tableGroup2);
            tableGroup1.ChildGroups.Add(tableGroup3);
            tableGroup1.Name = "expr4";
            tableGroup1.ReportItem = this.txtDefCalRend;
            this.tblDescripcion.ColumnGroups.Add(tableGroup1);
            this.tblDescripcion.DataSource = this.sql_ds_PerformanceDefinitions;
            this.tblDescripcion.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtCalificacionYNombre,
            this.txtDescripcion,
            this.txtDefCalRend});
            this.tblDescripcion.KeepTogether = false;
            this.tblDescripcion.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.78740161657333374D));
            this.tblDescripcion.Name = "tblDescripcion";
            tableGroup4.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup4.Name = "detail";
            this.tblDescripcion.RowGroups.Add(tableGroup4);
            this.tblDescripcion.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6180276870727539D), Telerik.Reporting.Drawing.Unit.Inch(0.20833331346511841D));
            this.tblDescripcion.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.tblDescripcion.StyleName = "Corporate.TableNormal";
            // 
            // txtCalificacionYNombre
            // 
            this.txtCalificacionYNombre.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtCalificacionYNombre.Name = "txtCalificacionYNombre";
            this.txtCalificacionYNombre.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9510948657989502D), Telerik.Reporting.Drawing.Unit.Inch(0.1041666716337204D));
            this.txtCalificacionYNombre.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.txtCalificacionYNombre.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5D);
            this.txtCalificacionYNombre.StyleName = "Corporate.TableBody";
            this.txtCalificacionYNombre.Value = "= Fields.Nombre + \" =\" + Fields.NumeroCalificacion  + \" ( \" + Fields.PalabraClave" +
    " + \" )\"";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6669325828552246D), Telerik.Reporting.Drawing.Unit.Inch(0.1041666716337204D));
            this.txtDescripcion.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtDescripcion.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(5D);
            this.txtDescripcion.StyleName = "Corporate.TableBody";
            this.txtDescripcion.Value = "= Fields.Descripcion";
            // 
            // txtDefCalRend
            // 
            this.txtDefCalRend.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtDefCalRend.Name = "txtDefCalRend";
            this.txtDefCalRend.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6180276870727539D), Telerik.Reporting.Drawing.Unit.Inch(0.1041666641831398D));
            this.txtDefCalRend.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.txtDefCalRend.StyleName = "Corporate.TableHeader";
            this.txtDefCalRend.Value = "Definiciones de las calificaciones de rendimiento";
            // 
            // list1
            // 
            this.list1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(6.24153995513916D)));
            this.list1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.94788974523544312D)));
            this.list1.Body.SetCellContent(0, 0, this.panel1);
            tableGroup5.Name = "ColumnGroup";
            this.list1.ColumnGroups.Add(tableGroup5);
            this.list1.DataSource = this.PlantillaEvaluacion;
            this.list1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel1,
            this.textBox1});
            this.list1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(1.059984564781189D));
            this.list1.Name = "list1";
            this.list1.NoDataMessage = "= Parameters.NumEmp.Value";
            tableGroup7.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup7.Name = "DetailGroup";
            tableGroup6.ChildGroups.Add(tableGroup7);
            tableGroup6.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.TipoDeCompetencia"));
            tableGroup6.Name = "tipoDeCompetencia";
            tableGroup6.ReportItem = this.textBox1;
            tableGroup6.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.OrdenReporte", Telerik.Reporting.SortDirection.Asc));
            this.list1.RowGroups.Add(tableGroup6);
            this.list1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6180686950683594D), Telerik.Reporting.Drawing.Unit.Inch(0.94788974523544312D));
            // 
            // panel1
            // 
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.htmlTextBox1});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.24153995513916D), Telerik.Reporting.Drawing.Unit.Inch(0.94788974523544312D));
            // 
            // htmlTextBox1
            // 
            this.htmlTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.htmlTextBox1.Name = "htmlTextBox1";
            this.htmlTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.2414989471435547D), Telerik.Reporting.Drawing.Unit.Inch(0.94788926839828491D));
            this.htmlTextBox1.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.htmlTextBox1.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.htmlTextBox1.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.htmlTextBox1.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.htmlTextBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.htmlTextBox1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.htmlTextBox1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.htmlTextBox1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.htmlTextBox1.Value = resources.GetString("htmlTextBox1.Value");
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3765290975570679D), Telerik.Reporting.Drawing.Unit.Inch(0.94788974523544312D));
            this.textBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.textBox1.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox1.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox1.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox1.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox1.Style.Color = System.Drawing.Color.White;
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            this.textBox1.StyleName = "";
            this.textBox1.Value = "= Fields.TipoDeCompetencia";
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.5131227970123291D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.5131227970123291D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.5131227970123291D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.58007144927978516D)));
            this.table1.Body.SetCellContent(0, 0, this.htmlTextBox2, 1, 3);
            tableGroup9.Name = "group6";
            tableGroup10.Name = "tableGroup1";
            tableGroup11.Name = "tableGroup2";
            tableGroup8.ChildGroups.Add(tableGroup9);
            tableGroup8.ChildGroups.Add(tableGroup10);
            tableGroup8.ChildGroups.Add(tableGroup11);
            tableGroup8.Name = "tableGroup";
            tableGroup8.ReportItem = this.textBox4;
            this.table1.ColumnGroups.Add(tableGroup8);
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.htmlTextBox2,
            this.textBox4});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0787789449095726D), Telerik.Reporting.Drawing.Unit.Inch(2.1885936260223389D));
            this.table1.Name = "table1";
            tableGroup12.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup12.Name = "detailTableGroup";
            this.table1.RowGroups.Add(tableGroup12);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.5393681526184082D), Telerik.Reporting.Drawing.Unit.Inch(0.69592916965484619D));
            // 
            // htmlTextBox2
            // 
            this.htmlTextBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.htmlTextBox2.Name = "htmlTextBox2";
            this.htmlTextBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.53936767578125D), Telerik.Reporting.Drawing.Unit.Inch(0.58007144927978516D));
            this.htmlTextBox2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.htmlTextBox2.StyleName = "";
            this.htmlTextBox2.Value = "&nbsp;";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.5393681526184082D), Telerik.Reporting.Drawing.Unit.Inch(0.11585770547389984D));
            this.textBox4.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.textBox4.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox4.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox4.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox4.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox4.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox4.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox4.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox4.Style.Color = System.Drawing.Color.White;
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox4.Value = "Comentarios del Empleado:";
            // 
            // htmltxtCalif
            // 
            this.htmltxtCalif.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4409475326538086D), Telerik.Reporting.Drawing.Unit.Inch(2.007953405380249D));
            this.htmltxtCalif.Name = "htmltxtCalif";
            this.htmltxtCalif.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.271611213684082D), Telerik.Reporting.Drawing.Unit.Inch(0.13068220019340515D));
            this.htmltxtCalif.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.htmltxtCalif.Value = resources.GetString("htmltxtCalif.Value");
            // 
            // htmlTextBox4
            // 
            this.htmlTextBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4568904638290405D), Telerik.Reporting.Drawing.Unit.Inch(0.23657496273517609D));
            this.htmlTextBox4.Name = "htmlTextBox4";
            this.htmlTextBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8896055221557617D), Telerik.Reporting.Drawing.Unit.Inch(0.1179916113615036D));
            this.htmlTextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.htmlTextBox4.Value = "<strong>{Fields.No_Emp}</strong>";
            // 
            // htmlTextBox5
            // 
            this.htmlTextBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.76389741897583D), Telerik.Reporting.Drawing.Unit.Inch(0.23673264682292938D));
            this.htmlTextBox5.Name = "htmlTextBox5";
            this.htmlTextBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8542098999023438D), Telerik.Reporting.Drawing.Unit.Inch(0.11799144744873047D));
            this.htmlTextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.htmlTextBox5.Value = "<strong>{Fields.TipoEvaluacion}</strong>";
            // 
            // htmlTextBox3
            // 
            this.htmlTextBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.23657496273517609D));
            this.htmlTextBox3.Name = "htmlTextBox3";
            this.htmlTextBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4567722082138062D), Telerik.Reporting.Drawing.Unit.Inch(0.11799144744873047D));
            this.htmlTextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.htmlTextBox3.Value = "Numero del Empleado";
            // 
            // txtRevision
            // 
            this.txtRevision.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.3465747833251953D), Telerik.Reporting.Drawing.Unit.Inch(0.23673264682292938D));
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4172439575195313D), Telerik.Reporting.Drawing.Unit.Inch(0.11799146234989166D));
            this.txtRevision.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.txtRevision.Value = "Tipo de Revisión";
            // 
            // textBox15
            // 
            this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.098468460142612457D), Telerik.Reporting.Drawing.Unit.Inch(3.0122785568237305D));
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.5393271446228027D), Telerik.Reporting.Drawing.Unit.Inch(0.14736515283584595D));
            this.textBox15.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(160)))));
            this.textBox15.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox15.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox15.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox15.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox15.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox15.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox15.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox15.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox15.Style.Color = System.Drawing.Color.White;
            this.textBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox15.Value = "Al firmar este formulario, el empleado reconoce que esta evaluación ha sido revis" +
    "ada por su supervisor y el. ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.098509445786476135D), Telerik.Reporting.Drawing.Unit.Inch(3.1889762878417969D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7281596660614014D), Telerik.Reporting.Drawing.Unit.Inch(0.46224933862686157D));
            this.textBox7.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox7.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox7.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox7.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox7.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox7.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox7.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox7.Value = "RECURSOS HUMANOS:\r\n{Fields.EvaluadorRH}";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0984683558344841D), Telerik.Reporting.Drawing.Unit.Inch(3.6614172458648682D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7479290962219238D), Telerik.Reporting.Drawing.Unit.Inch(0.46224933862686157D));
            this.textBox5.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox5.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox5.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox5.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox5.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox5.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox5.Value = "GERENTE DE AREA:\r\n{Fields.NombreGerente}";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.098468780517578125D), Telerik.Reporting.Drawing.Unit.Inch(4.1338582038879395D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7479290962219238D), Telerik.Reporting.Drawing.Unit.Inch(0.46224933862686157D));
            this.textBox9.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox9.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox9.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox9.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox9.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox9.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox9.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox9.Value = "SUPERVISOR/JEFE: \r\n{Fields.JEFE}";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8464763164520264D), Telerik.Reporting.Drawing.Unit.Inch(3.1889762878417969D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7913191318511963D), Telerik.Reporting.Drawing.Unit.Inch(0.46224933862686157D));
            this.textBox11.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox11.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox11.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox11.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox11.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox11.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox11.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox11.Value = "Fecha:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8464763164520264D), Telerik.Reporting.Drawing.Unit.Inch(3.6614172458648682D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7913188934326172D), Telerik.Reporting.Drawing.Unit.Inch(0.46224933862686157D));
            this.textBox12.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox12.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox12.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox12.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox12.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox12.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox12.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox12.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox12.Value = "Fecha:";
            // 
            // textBox13
            // 
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8464763164520264D), Telerik.Reporting.Drawing.Unit.Inch(4.1338582038879395D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7913188934326172D), Telerik.Reporting.Drawing.Unit.Inch(0.46224933862686157D));
            this.textBox13.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox13.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox13.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox13.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox13.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox13.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox13.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox13.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox13.Value = "Fecha:";
            // 
            // textBox18
            // 
            this.textBox18.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.098509468138217926D), Telerik.Reporting.Drawing.Unit.Inch(4.60629940032959D));
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7479290962219238D), Telerik.Reporting.Drawing.Unit.Inch(0.46224933862686157D));
            this.textBox18.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox18.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox18.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox18.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox18.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox18.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox18.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox18.Value = "EMPLEADO:\r\n{Fields.Nombre}";
            // 
            // textBox17
            // 
            this.textBox17.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8464763164520264D), Telerik.Reporting.Drawing.Unit.Inch(4.60629940032959D));
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7913188934326172D), Telerik.Reporting.Drawing.Unit.Inch(0.46224933862686157D));
            this.textBox17.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox17.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox17.Style.BorderColor.Right = System.Drawing.Color.Black;
            this.textBox17.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox17.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox17.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox17.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox17.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox17.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox17.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.textBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.textBox17.Value = "Fecha:";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.55118244886398315D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox6,
            this.textBox8});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.749998092651367D), Telerik.Reporting.Drawing.Unit.Cm(0.10000035166740418D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.5999975204467773D), Telerik.Reporting.Drawing.Unit.Cm(0.77016854286193848D));
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox6.Value = "Pagina {PageNumber} de {PageCount}";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.039370220154523849D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.110196590423584D), Telerik.Reporting.Drawing.Unit.Inch(0.30321693420410156D));
            this.textBox8.Value = "FRO-234-1- Rev – A - 17-1-2018";
            // 
            // HourlyRas2
            // 
            this.DataSource = this.UsuarioEvaluado;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detailSection1,
            this.pageFooterSection1});
            this.Name = "Reporte Hourly";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "NumEmp";
            reportParameter1.Text = "Numero de empleado";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter1.Value = "";
            reportParameter1.Visible = true;
            reportParameter2.Name = "idEvaluacion";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter2.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.Style.BorderColor.Bottom = System.Drawing.Color.White;
            this.Style.BorderColor.Left = System.Drawing.Color.White;
            this.Style.BorderColor.Right = System.Drawing.Color.White;
            this.Style.BorderColor.Top = System.Drawing.Color.White;
            this.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1D);
            this.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1D);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule2.Style.Font.Name = "Segoe UI";
            styleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("h2")});
            styleRule3.Style.Font.Name = "Segoe UI";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Description")});
            styleRule4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            styleRule4.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule4.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(3D);
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.Table), "Solstice.TableNormal")});
            styleRule5.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule5.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(29)))), ((int)(((byte)(20)))));
            styleRule5.Style.Font.Name = "Gill Sans MT";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Solstice.TableBody")});
            styleRule6.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector1});
            styleRule6.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(29)))), ((int)(((byte)(20)))));
            styleRule6.Style.Font.Name = "Gill Sans MT";
            styleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Solstice.TableHeader")});
            styleRule7.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector2});
            styleRule7.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(39)))), ((int)(((byte)(28)))));
            styleRule7.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule7.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            styleRule7.Style.Font.Name = "Gill Sans MT";
            styleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule8.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.Table), "Corporate.TableNormal")});
            styleRule8.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule8.Style.Color = System.Drawing.Color.Black;
            styleRule8.Style.Font.Name = "Tahoma";
            styleRule8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Corporate.TableBody")});
            styleRule9.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector3});
            styleRule9.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule9.Style.Font.Name = "Tahoma";
            styleRule9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Corporate.TableHeader")});
            styleRule10.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector4});
            styleRule10.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule10.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule10.Style.Color = System.Drawing.Color.White;
            styleRule10.Style.Font.Name = "Tahoma";
            styleRule10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5,
            styleRule6,
            styleRule7,
            styleRule8,
            styleRule9,
            styleRule10});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(7.7125978469848633D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource UsuarioEvaluado;
        private Telerik.Reporting.SqlDataSource sql_ds_PerformanceDefinitions;
        private Telerik.Reporting.SqlDataSource PlantillaEvaluacion;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.TextBox Titulo;
        private Telerik.Reporting.PictureBox imgFromex;
        private Telerik.Reporting.DetailSection detailSection1;
        private Telerik.Reporting.TextBox txtNomEmp;
        private Telerik.Reporting.TextBox txtPuesto;
        private Telerik.Reporting.TextBox txtPeriodo;
        private Telerik.Reporting.TextBox txtPrdo;
        private Telerik.Reporting.TextBox txtGerente;
        private Telerik.Reporting.TextBox txtProposito;
        private Telerik.Reporting.TextBox txtNombreEmp;
        private Telerik.Reporting.TextBox txtDescripcionPuesto;
        private Telerik.Reporting.TextBox txtJefe;
        private Telerik.Reporting.Table tblDescripcion;
        private Telerik.Reporting.TextBox txtCalificacionYNombre;
        private Telerik.Reporting.TextBox txtDescripcion;
        private Telerik.Reporting.TextBox txtDefCalRend;
        private Telerik.Reporting.List list1;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.HtmlTextBox htmlTextBox1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.Table table1;
        private Telerik.Reporting.HtmlTextBox htmlTextBox2;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.HtmlTextBox htmltxtCalif;
        private Telerik.Reporting.HtmlTextBox htmlTextBox4;
        private Telerik.Reporting.HtmlTextBox htmlTextBox5;
        private Telerik.Reporting.HtmlTextBox htmlTextBox3;
        private Telerik.Reporting.HtmlTextBox txtRevision;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox8;
    }
}