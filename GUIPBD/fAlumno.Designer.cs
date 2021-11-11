
namespace GUIPBD
{
    partial class fAlumno
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
            System.Windows.Forms.Label idAlumnoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label noControlLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlumno));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBDDataSet = new GUIPBD.PBDDataSet();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.noControlTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idAlumnoTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.alumnoTableAdapter = new GUIPBD.PBDDataSetTableAdapters.AlumnoTableAdapter();
            this.tableAdapterManager = new GUIPBD.PBDDataSetTableAdapters.TableAdapterManager();
            this.alumnoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alumnoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReporte = new System.Windows.Forms.Button();
            idAlumnoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            noControlLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingNavigator)).BeginInit();
            this.alumnoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idAlumnoLabel
            // 
            idAlumnoLabel.AutoSize = true;
            idAlumnoLabel.Location = new System.Drawing.Point(35, 15);
            idAlumnoLabel.Name = "idAlumnoLabel";
            idAlumnoLabel.Size = new System.Drawing.Size(56, 13);
            idAlumnoLabel.TabIndex = 2;
            idAlumnoLabel.Text = "id Alumno:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(43, 41);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(10, 67);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(78, 13);
            primerApellidoLabel.TabIndex = 6;
            primerApellidoLabel.Text = "primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(-3, 93);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(91, 13);
            segundoApellidoLabel.TabIndex = 8;
            segundoApellidoLabel.Text = "segundo Apellido:";
            // 
            // noControlLabel
            // 
            noControlLabel.AutoSize = true;
            noControlLabel.Location = new System.Drawing.Point(33, 119);
            noControlLabel.Name = "noControlLabel";
            noControlLabel.Size = new System.Drawing.Size(58, 13);
            noControlLabel.TabIndex = 10;
            noControlLabel.Text = "no Control:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(412, 41);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "email:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(398, 67);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "telefono:";
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
            this.pnlTop.Size = new System.Drawing.Size(851, 93);
            this.pnlTop.TabIndex = 1;
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
            this.pnlButtom.Controls.Add(telefonoLabel);
            this.pnlButtom.Controls.Add(this.telefonoTextBox);
            this.pnlButtom.Controls.Add(emailLabel);
            this.pnlButtom.Controls.Add(this.emailTextBox);
            this.pnlButtom.Controls.Add(noControlLabel);
            this.pnlButtom.Controls.Add(this.noControlTextBox);
            this.pnlButtom.Controls.Add(segundoApellidoLabel);
            this.pnlButtom.Controls.Add(this.segundoApellidoTextBox);
            this.pnlButtom.Controls.Add(primerApellidoLabel);
            this.pnlButtom.Controls.Add(this.primerApellidoTextBox);
            this.pnlButtom.Controls.Add(nombreLabel);
            this.pnlButtom.Controls.Add(this.nombreTextBox);
            this.pnlButtom.Controls.Add(idAlumnoLabel);
            this.pnlButtom.Controls.Add(this.idAlumnoTextBox);
            this.pnlButtom.Controls.Add(this.btnCancelar);
            this.pnlButtom.Controls.Add(this.btnSave);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 263);
            this.pnlButtom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(851, 151);
            this.pnlButtom.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(452, 64);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(181, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.pBDDataSet;
            // 
            // pBDDataSet
            // 
            this.pBDDataSet.DataSetName = "PBDDataSet";
            this.pBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(452, 38);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(365, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // noControlTextBox
            // 
            this.noControlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "noControl", true));
            this.noControlTextBox.Location = new System.Drawing.Point(97, 116);
            this.noControlTextBox.Name = "noControlTextBox";
            this.noControlTextBox.Size = new System.Drawing.Size(296, 20);
            this.noControlTextBox.TabIndex = 11;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "segundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(97, 90);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(296, 20);
            this.segundoApellidoTextBox.TabIndex = 9;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "primerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(97, 64);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(296, 20);
            this.primerApellidoTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(97, 38);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(296, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // idAlumnoTextBox
            // 
            this.idAlumnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "idAlumno", true));
            this.idAlumnoTextBox.Enabled = false;
            this.idAlumnoTextBox.Location = new System.Drawing.Point(97, 12);
            this.idAlumnoTextBox.Name = "idAlumnoTextBox";
            this.idAlumnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idAlumnoTextBox.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::GUIPBD.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(753, 63);
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
            this.btnSave.Location = new System.Drawing.Point(685, 64);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 60);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEmpresaTableAdapter = null;
            this.tableAdapterManager.AlumnoTableAdapter = this.alumnoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUIPBD.PBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.vAlumnoEmpresaTableAdapter = null;
            // 
            // alumnoBindingNavigator
            // 
            this.alumnoBindingNavigator.AddNewItem = null;
            this.alumnoBindingNavigator.BindingSource = this.alumnoBindingSource;
            this.alumnoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alumnoBindingNavigator.DeleteItem = null;
            this.alumnoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.alumnoBindingNavigator.Location = new System.Drawing.Point(0, 93);
            this.alumnoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alumnoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alumnoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alumnoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alumnoBindingNavigator.Name = "alumnoBindingNavigator";
            this.alumnoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alumnoBindingNavigator.Size = new System.Drawing.Size(851, 25);
            this.alumnoBindingNavigator.TabIndex = 3;
            this.alumnoBindingNavigator.Text = "bindingNavigator1";
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
            // alumnoDataGridView
            // 
            this.alumnoDataGridView.AllowUserToAddRows = false;
            this.alumnoDataGridView.AllowUserToDeleteRows = false;
            this.alumnoDataGridView.AllowUserToOrderColumns = true;
            this.alumnoDataGridView.AutoGenerateColumns = false;
            this.alumnoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.alumnoDataGridView.DataSource = this.alumnoBindingSource;
            this.alumnoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alumnoDataGridView.Location = new System.Drawing.Point(0, 118);
            this.alumnoDataGridView.Name = "alumnoDataGridView";
            this.alumnoDataGridView.ReadOnly = true;
            this.alumnoDataGridView.Size = new System.Drawing.Size(851, 145);
            this.alumnoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAlumno";
            this.dataGridViewTextBoxColumn1.HeaderText = "idAlumno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "primerApellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "primerApellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "segundoApellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "segundoApellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "noControl";
            this.dataGridViewTextBoxColumn5.HeaderText = "noControl";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnReporte
            // 
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(234, 19);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(64, 60);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // fAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(851, 414);
            this.Controls.Add(this.alumnoDataGridView);
            this.Controls.Add(this.alumnoBindingNavigator);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.fAlumno_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlButtom.ResumeLayout(false);
            this.pnlButtom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingNavigator)).EndInit();
            this.alumnoBindingNavigator.ResumeLayout(false);
            this.alumnoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PBDDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private PBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alumnoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView alumnoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idAlumnoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox noControlTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnReporte;
    }
}