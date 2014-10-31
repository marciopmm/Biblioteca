namespace Biblioteca
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.Label emprestadoLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label nomeLabel;
            this.livroBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.livroBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.livroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Biblioteca.Database1DataSet();
            this.livroTableAdapter1 = new Biblioteca.Database1DataSetTableAdapters.LivroTableAdapter();
            this.tableAdapterManager1 = new Biblioteca.Database1DataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.emprestadoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.editoraTextBox1 = new System.Windows.Forms.TextBox();
            this.autorTextBox1 = new System.Windows.Forms.TextBox();
            this.nomeTextBox1 = new System.Windows.Forms.TextBox();
            emprestadoLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1BindingNavigator)).BeginInit();
            this.livroBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // livroBindingSource1BindingNavigator
            // 
            this.livroBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.livroBindingSource1BindingNavigator.BindingSource = this.livroBindingSource1;
            this.livroBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.livroBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.livroBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.livroBindingSource1BindingNavigatorSaveItem});
            this.livroBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.livroBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.livroBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.livroBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.livroBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.livroBindingSource1BindingNavigator.Name = "livroBindingSource1BindingNavigator";
            this.livroBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.livroBindingSource1BindingNavigator.Size = new System.Drawing.Size(385, 25);
            this.livroBindingSource1BindingNavigator.TabIndex = 1;
            this.livroBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // livroBindingSource1BindingNavigatorSaveItem
            // 
            this.livroBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.livroBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("livroBindingSource1BindingNavigatorSaveItem.Image")));
            this.livroBindingSource1BindingNavigatorSaveItem.Name = "livroBindingSource1BindingNavigatorSaveItem";
            this.livroBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.livroBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.livroBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.livroBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // livroBindingSource1
            // 
            this.livroBindingSource1.DataMember = "Livro";
            this.livroBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroTableAdapter1
            // 
            this.livroTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LivroTableAdapter = this.livroTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Biblioteca.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(385, 335);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // emprestadoLabel
            // 
            emprestadoLabel.AutoSize = true;
            emprestadoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            emprestadoLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emprestadoLabel.Location = new System.Drawing.Point(32, 305);
            emprestadoLabel.Name = "emprestadoLabel";
            emprestadoLabel.Size = new System.Drawing.Size(79, 15);
            emprestadoLabel.TabIndex = 32;
            emprestadoLabel.Text = "Emprestado:";
            // 
            // emprestadoCheckBox1
            // 
            this.emprestadoCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.livroBindingSource1, "Emprestado", true));
            this.emprestadoCheckBox1.Location = new System.Drawing.Point(12, 307);
            this.emprestadoCheckBox1.Name = "emprestadoCheckBox1";
            this.emprestadoCheckBox1.Size = new System.Drawing.Size(14, 13);
            this.emprestadoCheckBox1.TabIndex = 33;
            this.emprestadoCheckBox1.UseVisualStyleBackColor = true;
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            editoraLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editoraLabel.Location = new System.Drawing.Point(12, 274);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(50, 15);
            editoraLabel.TabIndex = 30;
            editoraLabel.Text = "Editora:";
            // 
            // editoraTextBox1
            // 
            this.editoraTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.editoraTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource1, "Editora", true));
            this.editoraTextBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editoraTextBox1.Location = new System.Drawing.Point(68, 272);
            this.editoraTextBox1.Name = "editoraTextBox1";
            this.editoraTextBox1.Size = new System.Drawing.Size(181, 20);
            this.editoraTextBox1.TabIndex = 31;
            this.editoraTextBox1.TextChanged += new System.EventHandler(this.editoraTextBox1_TextChanged);
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            autorLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(15, 241);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(41, 15);
            autorLabel.TabIndex = 28;
            autorLabel.Text = "Autor:";
            // 
            // autorTextBox1
            // 
            this.autorTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.autorTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource1, "Autor", true));
            this.autorTextBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.autorTextBox1.Location = new System.Drawing.Point(68, 239);
            this.autorTextBox1.Name = "autorTextBox1";
            this.autorTextBox1.Size = new System.Drawing.Size(181, 20);
            this.autorTextBox1.TabIndex = 29;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            nomeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(12, 215);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(43, 15);
            nomeLabel.TabIndex = 26;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.nomeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource1, "Nome", true));
            this.nomeTextBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nomeTextBox1.Location = new System.Drawing.Point(68, 213);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.Size = new System.Drawing.Size(135, 20);
            this.nomeTextBox1.TabIndex = 27;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(385, 353);
            this.Controls.Add(emprestadoLabel);
            this.Controls.Add(this.emprestadoCheckBox1);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox1);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.livroBindingSource1BindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1BindingNavigator)).EndInit();
            this.livroBindingSource1BindingNavigator.ResumeLayout(false);
            this.livroBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private Database1DataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator livroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton livroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox iDLivroTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.CheckBox emprestadoCheckBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource livroBindingSource1;
        private Database1DataSetTableAdapters.LivroTableAdapter livroTableAdapter1;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator livroBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton livroBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox emprestadoCheckBox1;
        private System.Windows.Forms.TextBox editoraTextBox1;
        private System.Windows.Forms.TextBox autorTextBox1;
        private System.Windows.Forms.TextBox nomeTextBox1;
    }
}

