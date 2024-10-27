namespace PresentationLayer.Forms
{
    partial class CategoryForm
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
            titleLabel = new Label();
            nameCategoryLabel = new Label();
            nameCategoryTextBox = new TextBox();
            saveCategoryButton = new Button();
            updateCategoryButton = new Button();
            deleteCategoryButton = new Button();
            categoryDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(459, 47);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(207, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Categorias de Productos";
            // 
            // nameCategoryLabel
            // 
            nameCategoryLabel.AutoSize = true;
            nameCategoryLabel.Location = new Point(37, 158);
            nameCategoryLabel.Name = "nameCategoryLabel";
            nameCategoryLabel.Size = new Size(193, 25);
            nameCategoryLabel.TabIndex = 1;
            nameCategoryLabel.Text = "Nombre de Categoria: ";
            // 
            // nameCategoryTextBox
            // 
            nameCategoryTextBox.Location = new Point(37, 217);
            nameCategoryTextBox.Name = "nameCategoryTextBox";
            nameCategoryTextBox.Size = new Size(481, 31);
            nameCategoryTextBox.TabIndex = 2;
            // 
            // saveCategoryButton
            // 
            saveCategoryButton.Location = new Point(37, 299);
            saveCategoryButton.Name = "saveCategoryButton";
            saveCategoryButton.Size = new Size(112, 34);
            saveCategoryButton.TabIndex = 3;
            saveCategoryButton.Text = "Guardar";
            saveCategoryButton.UseVisualStyleBackColor = true;
            saveCategoryButton.Click += saveCategoryButton_Click;
            // 
            // updateCategoryButton
            // 
            updateCategoryButton.Location = new Point(207, 299);
            updateCategoryButton.Name = "updateCategoryButton";
            updateCategoryButton.Size = new Size(112, 34);
            updateCategoryButton.TabIndex = 4;
            updateCategoryButton.Text = "Editar";
            updateCategoryButton.UseVisualStyleBackColor = true;
            updateCategoryButton.Click += updateCategoryButton_Click;
            // 
            // deleteCategoryButton
            // 
            deleteCategoryButton.Location = new Point(375, 299);
            deleteCategoryButton.Name = "deleteCategoryButton";
            deleteCategoryButton.Size = new Size(112, 34);
            deleteCategoryButton.TabIndex = 5;
            deleteCategoryButton.Text = "Eliminar";
            deleteCategoryButton.UseVisualStyleBackColor = true;
            deleteCategoryButton.Click += deleteCategoryButton_Click;
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGridView.Location = new Point(587, 121);
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.RowHeadersWidth = 62;
            categoryDataGridView.Size = new Size(743, 384);
            categoryDataGridView.TabIndex = 6;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 575);
            Controls.Add(categoryDataGridView);
            Controls.Add(deleteCategoryButton);
            Controls.Add(updateCategoryButton);
            Controls.Add(saveCategoryButton);
            Controls.Add(nameCategoryTextBox);
            Controls.Add(nameCategoryLabel);
            Controls.Add(titleLabel);
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label nameCategoryLabel;
        private TextBox nameCategoryTextBox;
        private Button saveCategoryButton;
        private Button updateCategoryButton;
        private Button deleteCategoryButton;
        private DataGridView categoryDataGridView;
    }
}