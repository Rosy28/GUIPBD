
namespace GUIPBD
{
    partial class fAlumnoEmpresa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idAlumnoEmpresaLabel;
            System.Windows.Forms.Label anioInicioLabel;
            System.Windows.Forms.Label anioFinLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlumnoEmpresa));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.anioFinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vAlumnoEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBDDataSet = new GUIPBD.PBDDataSet();
            this.anioInicioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.idAlumnoEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.vAlumnoEmpresaTableAdapter = new GUIPBD.PBDDataSetTableAdapters.vAlumnoEmpresaTableAdapter();
            this.tableAdapterManager = new GUIPBD.PBDDataSetTableAdapters.TableAdapterManager();
            this.vAlumnoEmpresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vAlumnoEmpresaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vAlumnoEmpresaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoTableAdapter = new GUIPBD.PBDDataSetTableAdapters.AlumnoTableAdapter();
            this.alumnoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new GUIPBD.PBDDataSetTableAdapters.EmpresaTableAdapter();
            this.alumnoEmpresaTableAdapter = new GUIPBD.PBDDataSetTableAdapters.AlumnoEmpresaTableAdapter();
            this.btnReporte = new System.Windows.Forms.Button();
            idAlumnoEmpresaLabel = new System.Windows.Forms.Label();
            anioInicioLabel = new System.Windows.Forms.Label();
            anioFinLabel = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioFinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioInicioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingNavigator)).BeginInit();
            this.vAlumnoEmpresaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idAlumnoEmpresaLabel
            // 
            idAlumnoEmpresaLabel.AutoSize = true;
            idAlumnoEmpresaLabel.Enabled = false;
            idAlumnoEmpresaLabel.Location = new System.Drawing.Point(28, 24);
            idAlumnoEmpresaLabel.Name = "idAlumnoEmpresaLabel";
            idAlumnoEmpresaLabel.Size = new System.Drawing.Size(100, 13);
            idAlumnoEmpresaLabel.TabIndex = 2;
            idAlumnoEmpresaLabel.Text = "id Alumno Empresa:";
            // 
            // anioInicioLabel
            // 
            anioInicioLabel.AutoSize = true;
            anioInicioLabel.Location = new System.Drawing.Point(326, 26);
            anioInicioLabel.Name = "anioInicioLabel";
            anioInicioLabel.Size = new System.Drawing.Size(58, 13);
            anioInicioLabel.TabIndex = 8;
            anioInicioLabel.Text = "anio Inicio:";
            // 
            // anioFinLabel
            // 
            anioFinLabel.AutoSize = true;
            anioFinLabel.Location = new System.Drawing.Point(337, 73);
            anioFinLabel.Name = "anioFinLabel";
            anioFinLabel.Size = new System.Drawing.Size(47, 13);
            anioFinLabel.TabIndex = 10;
            anioFinLabel.Text = "anio Fin:";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnReporte);
            this.pnlTop.Controls.Add(this.btnDelete);
            this.pnlTop.Controls.Add(this.btnUpdate);
            this.pnlTop.Controls.Add(this.btnInsert);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(809, 93);
            this.pnlTop.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::GUIPBD.Properties.Resources.Borrar;
            this.btnDelete.Location = new System.Drawing.Point(166, 19);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 60);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::GUIPBD.Properties.Resources.Editar;
            this.btnUpdate.Location = new System.Drawing.Point(97, 19);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 60);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::GUIPBD.Properties.Resources.Insertar;
            this.btnInsert.Location = new System.Drawing.Point(28, 19);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(64, 60);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pnlButtom
            // 
            this.pnlButtom.Controls.Add(anioFinLabel);
            this.pnlButtom.Controls.Add(this.anioFinNumericUpDown);
            this.pnlButtom.Controls.Add(anioInicioLabel);
            this.pnlButtom.Controls.Add(this.anioInicioNumericUpDown);
            this.pnlButtom.Controls.Add(this.cboEmpresa);
            this.pnlButtom.Controls.Add(this.label2);
            this.pnlButtom.Controls.Add(this.cboAlumno);
            this.pnlButtom.Controls.Add(this.label1);
            this.pnlButtom.Controls.Add(idAlumnoEmpresaLabel);
            this.pnlButtom.Controls.Add(this.idAlumnoEmpresaTextBox);
            this.pnlButtom.Controls.Add(this.btnCancelar);
            this.pnlButtom.Controls.Add(this.btnSave);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 299);
            this.pnlButtom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(809, 134);
            this.pnlButtom.TabIndex = 3;
            // 
            // anioFinNumericUpDown
            // 
            this.anioFinNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vAlumnoEmpresaBindingSource, "anioFin", true));
            this.anioFinNumericUpDown.Location = new System.Drawing.Point(390, 73);
            this.anioFinNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.anioFinNumericUpDown.Name = "anioFinNumericUpDown";
            this.anioFinNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.anioFinNumericUpDown.TabIndex = 11;
            // 
            // vAlumnoEmpresaBindingSource
            // 
            this.vAlumnoEmpresaBindingSource.DataMember = "vAlumnoEmpresa";
            this.vAlumnoEmpresaBindingSource.DataSource = this.pBDDataSet;
            // 
            // pBDDataSet
            // 
            this.pBDDataSet.DataSetName = "PBDDataSet";
            this.pBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anioInicioNumericUpDown
            // 
            this.anioInicioNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vAlumnoEmpresaBindingSource, "anioInicio", true));
            this.anioInicioNumericUpDown.Location = new System.Drawing.Point(390, 26);
            this.anioInicioNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.anioInicioNumericUpDown.Name = "anioInicioNumericUpDown";
            this.anioInicioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.anioInicioNumericUpDown.TabIndex = 9;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DataSource = this.empresaBindingSource;
            this.cboEmpresa.DisplayMember = "razonSocial";
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(158, 90);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cboEmpresa.TabIndex = 7;
            this.cboEmpresa.ValueMember = "idEmpresa";
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.pBDDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione una empresa";
            // 
            // cboAlumno
            // 
            this.cboAlumno.DataSource = this.alumnoBindingSource;
            this.cboAlumno.DisplayMember = "nombre";
            this.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Location = new System.Drawing.Point(158, 55);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(121, 21);
            this.cboAlumno.TabIndex = 5;
            this.cboAlumno.ValueMember = "idAlumno";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.pBDDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione un alumno";
            // 
            // idAlumnoEmpresaTextBox
            // 
            this.idAlumnoEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vAlumnoEmpresaBindingSource, "idAlumnoEmpresa", true));
            this.idAlumnoEmpresaTextBox.Enabled = false;
            this.idAlumnoEmpresaTextBox.Location = new System.Drawing.Point(158, 21);
            this.idAlumnoEmpresaTextBox.Name = "idAlumnoEmpresaTextBox";
            this.idAlumnoEmpresaTextBox.Size = new System.Drawing.Size(121, 20);
            this.idAlumnoEmpresaTextBox.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::GUIPBD.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(728, 51);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 60);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::GUIPBD.Properties.Resources.Guardar;
            this.btnSave.Location = new System.Drawing.Point(660, 52);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 60);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // vAlumnoEmpresaTableAdapter
            // 
            this.vAlumnoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEmpresaTableAdapter = null;
            this.tableAdapterManager.AlumnoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUIPBD.PBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.vAlumnoEmpresaTableAdapter = null;
            // 
            // vAlumnoEmpresaBindingNavigator
            // 
            this.vAlumnoEmpresaBindingNavigator.AddNewItem = null;
            this.vAlumnoEmpresaBindingNavigator.BindingSource = this.vAlumnoEmpresaBindingSource;
            this.vAlumnoEmpresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vAlumnoEmpresaBindingNavigator.DeleteItem = null;
            this.vAlumnoEmpresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.vAlumnoEmpresaBindingNavigatorSaveItem});
            this.vAlumnoEmpresaBindingNavigator.Location = new System.Drawing.Point(0, 93);
            this.vAlumnoEmpresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vAlumnoEmpresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vAlumnoEmpresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vAlumnoEmpresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vAlumnoEmpresaBindingNavigator.Name = "vAlumnoEmpresaBindingNavigator";
            this.vAlumnoEmpresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vAlumnoEmpresaBindingNavigator.Size = new System.Drawing.Size(809, 25);
            this.vAlumnoEmpresaBindingNavigator.TabIndex = 4;
            this.vAlumnoEmpresaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vAlumnoEmpresaBindingNavigatorSaveItem
            // 
            this.vAlumnoEmpresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vAlumnoEmpresaBindingNavigatorSaveItem.Enabled = false;
            this.vAlumnoEmpresaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vAlumnoEmpresaBindingNavigatorSaveItem.Image")));
            this.vAlumnoEmpresaBindingNavigatorSaveItem.Name = "vAlumnoEmpresaBindingNavigatorSaveItem";
            this.vAlumnoEmpresaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vAlumnoEmpresaBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // vAlumnoEmpresaDataGridView
            // 
            this.vAlumnoEmpresaDataGridView.AllowUserToAddRows = false;
            this.vAlumnoEmpresaDataGridView.AllowUserToDeleteRows = false;
            this.vAlumnoEmpresaDataGridView.AllowUserToOrderColumns = true;
            this.vAlumnoEmpresaDataGridView.AutoGenerateColumns = false;
            this.vAlumnoEmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vAlumnoEmpresaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idAlumno,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.idEmpresa,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.vAlumnoEmpresaDataGridView.DataSource = this.vAlumnoEmpresaBindingSource;
            this.vAlumnoEmpresaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vAlumnoEmpresaDataGridView.Location = new System.Drawing.Point(0, 118);
            this.vAlumnoEmpresaDataGridView.Name = "vAlumnoEmpresaDataGridView";
            this.vAlumnoEmpresaDataGridView.ReadOnly = true;
            this.vAlumnoEmpresaDataGridView.Size = new System.Drawing.Size(809, 181);
            this.vAlumnoEmpresaDataGridView.TabIndex = 4;
            this.vAlumnoEmpresaDataGridView.SelectionChanged += new System.EventHandler(this.vAlumnoEmpresaDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAlumnoEmpresa";
            this.dataGridViewTextBoxColumn1.HeaderText = "idAlumnoEmpresa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "idAlumno";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "primerApellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "primerApellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "segundoApellido";
            this.dataGridViewTextBoxColumn5.HeaderText = "segundoApellido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "noControl";
            this.dataGridViewTextBoxColumn6.HeaderText = "noControl";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // idEmpresa
            // 
            this.idEmpresa.DataPropertyName = "idEmpresa";
            this.idEmpresa.HeaderText = "idEmpresa";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.ReadOnly = true;
            this.idEmpresa.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "razonSocial";
            this.dataGridViewTextBoxColumn8.HeaderText = "razonSocial";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "anioInicio";
            this.dataGridViewTextBoxColumn9.HeaderText = "anioInicio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "anioFin";
            this.dataGridViewTextBoxColumn10.HeaderText = "anioFin";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // alumnoBindingSource1
            // 
            this.alumnoBindingSource1.DataMember = "Alumno";
            this.alumnoBindingSource1.DataSource = this.pBDDataSet;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // alumnoEmpresaTableAdapter
            // 
            this.alumnoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(234, 19);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(64, 60);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // fAlumnoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 433);
            this.Controls.Add(this.vAlumnoEmpresaDataGridView);
            this.Controls.Add(this.vAlumnoEmpresaBindingNavigator);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAlumnoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno - Empresa";
            this.Load += new System.EventHandler(this.fAlumnoEmpresa_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlButtom.ResumeLayout(false);
            this.pnlButtom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioFinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioInicioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingNavigator)).EndInit();
            this.vAlumnoEmpresaBindingNavigator.ResumeLayout(false);
            this.vAlumnoEmpresaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSave;
        private PBDDataSet pBDDataSet;
        private System.Windows.Forms.BindingSource vAlumnoEmpresaBindingSource;
        private PBDDataSetTableAdapters.vAlumnoEmpresaTableAdapter vAlumnoEmpresaTableAdapter;
        private PBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vAlumnoEmpresaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vAlumnoEmpresaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vAlumnoEmpresaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox idAlumnoEmpresaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PBDDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.BindingSource alumnoBindingSource1;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private PBDDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private PBDDataSetTableAdapters.AlumnoEmpresaTableAdapter alumnoEmpresaTableAdapter;
        private System.Windows.Forms.NumericUpDown anioFinNumericUpDown;
        private System.Windows.Forms.NumericUpDown anioInicioNumericUpDown;
        private System.Windows.Forms.Button btnReporte;
    }
}