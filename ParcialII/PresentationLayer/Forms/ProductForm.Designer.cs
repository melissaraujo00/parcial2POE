namespace PresentationLayer.Forms
{
    partial class ProductForm
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
            components = new System.ComponentModel.Container();
            titleProductLabel = new Label();
            nameProductLabel = new Label();
            nameProductTextBox = new TextBox();
            nameProductError = new Label();
            stockProductError = new Label();
            stockTextBox = new TextBox();
            stockLabel = new Label();
            priceProductError = new Label();
            priceProductTextBox = new TextBox();
            priceProductLabel = new Label();
            categoryProductError = new Label();
            categoryProductLabel = new Label();
            categoryProductComboBox = new ComboBox();
            listProdutDataGridView = new DataGridView();
            saveProductButton = new Button();
            updateProductButton = new Button();
            deleteProductButton = new Button();
            viewCategoryButton = new Button();
            validationError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)listProdutDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validationError).BeginInit();
            SuspendLayout();
            // 
            // titleProductLabel
            // 
            titleProductLabel.AutoSize = true;
            titleProductLabel.Location = new Point(568, 50);
            titleProductLabel.Name = "titleProductLabel";
            titleProductLabel.Size = new Size(158, 25);
            titleProductLabel.TabIndex = 0;
            titleProductLabel.Text = "Lista de Productos";
            // 
            // nameProductLabel
            // 
            nameProductLabel.AutoSize = true;
            nameProductLabel.Location = new Point(55, 153);
            nameProductLabel.Name = "nameProductLabel";
            nameProductLabel.Size = new Size(194, 25);
            nameProductLabel.TabIndex = 1;
            nameProductLabel.Text = "Nombre del Producto: ";
            // 
            // nameProductTextBox
            // 
            nameProductTextBox.Location = new Point(55, 198);
            nameProductTextBox.Name = "nameProductTextBox";
            nameProductTextBox.Size = new Size(386, 31);
            nameProductTextBox.TabIndex = 2;
            // 
            // nameProductError
            // 
            nameProductError.AutoSize = true;
            nameProductError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            nameProductError.ForeColor = Color.Red;
            nameProductError.Location = new Point(55, 232);
            nameProductError.Name = "nameProductError";
            nameProductError.Size = new Size(0, 25);
            nameProductError.TabIndex = 3;
            // 
            // stockProductError
            // 
            stockProductError.AutoSize = true;
            stockProductError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            stockProductError.ForeColor = Color.Red;
            stockProductError.Location = new Point(55, 345);
            stockProductError.Name = "stockProductError";
            stockProductError.Size = new Size(0, 25);
            stockProductError.TabIndex = 6;
            // 
            // stockTextBox
            // 
            stockTextBox.Location = new Point(55, 311);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(386, 31);
            stockTextBox.TabIndex = 5;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new Point(55, 273);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new Size(297, 25);
            stockLabel.TabIndex = 4;
            stockLabel.Text = "Cantidad de Producto en inventario:";
            // 
            // priceProductError
            // 
            priceProductError.AutoSize = true;
            priceProductError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            priceProductError.ForeColor = Color.Red;
            priceProductError.Location = new Point(57, 462);
            priceProductError.Name = "priceProductError";
            priceProductError.Size = new Size(0, 25);
            priceProductError.TabIndex = 9;
            // 
            // priceProductTextBox
            // 
            priceProductTextBox.Location = new Point(57, 428);
            priceProductTextBox.Name = "priceProductTextBox";
            priceProductTextBox.Size = new Size(384, 31);
            priceProductTextBox.TabIndex = 8;
            // 
            // priceProductLabel
            // 
            priceProductLabel.AutoSize = true;
            priceProductLabel.Location = new Point(57, 387);
            priceProductLabel.Name = "priceProductLabel";
            priceProductLabel.Size = new Size(176, 25);
            priceProductLabel.TabIndex = 7;
            priceProductLabel.Text = "Precio del Producto: ";
            // 
            // categoryProductError
            // 
            categoryProductError.AutoSize = true;
            categoryProductError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            categoryProductError.ForeColor = Color.Red;
            categoryProductError.Location = new Point(59, 598);
            categoryProductError.Name = "categoryProductError";
            categoryProductError.Size = new Size(0, 25);
            categoryProductError.TabIndex = 12;
            // 
            // categoryProductLabel
            // 
            categoryProductLabel.AutoSize = true;
            categoryProductLabel.Location = new Point(59, 510);
            categoryProductLabel.Name = "categoryProductLabel";
            categoryProductLabel.Size = new Size(199, 25);
            categoryProductLabel.TabIndex = 10;
            categoryProductLabel.Text = "Categoria del Producto:";
            // 
            // categoryProductComboBox
            // 
            categoryProductComboBox.FormattingEnabled = true;
            categoryProductComboBox.Location = new Point(59, 551);
            categoryProductComboBox.Name = "categoryProductComboBox";
            categoryProductComboBox.Size = new Size(382, 33);
            categoryProductComboBox.TabIndex = 13;
            // 
            // listProdutDataGridView
            // 
            listProdutDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listProdutDataGridView.Location = new Point(552, 153);
            listProdutDataGridView.Name = "listProdutDataGridView";
            listProdutDataGridView.RowHeadersWidth = 62;
            listProdutDataGridView.Size = new Size(893, 504);
            listProdutDataGridView.TabIndex = 14;
            // 
            // saveProductButton
            // 
            saveProductButton.Location = new Point(55, 667);
            saveProductButton.Name = "saveProductButton";
            saveProductButton.Size = new Size(112, 34);
            saveProductButton.TabIndex = 15;
            saveProductButton.Text = "Guardar";
            saveProductButton.UseVisualStyleBackColor = true;
            saveProductButton.Click += saveProductButton_Click;
            // 
            // updateProductButton
            // 
            updateProductButton.Location = new Point(208, 667);
            updateProductButton.Name = "updateProductButton";
            updateProductButton.Size = new Size(112, 34);
            updateProductButton.TabIndex = 16;
            updateProductButton.Text = "Editar";
            updateProductButton.UseVisualStyleBackColor = true;
            updateProductButton.Click += updateProductButton_Click;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(367, 667);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(112, 34);
            deleteProductButton.TabIndex = 17;
            deleteProductButton.Text = "Eliminar";
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += deleteProductButton_Click;
            // 
            // viewCategoryButton
            // 
            viewCategoryButton.Location = new Point(41, 750);
            viewCategoryButton.Name = "viewCategoryButton";
            viewCategoryButton.Size = new Size(460, 34);
            viewCategoryButton.TabIndex = 18;
            viewCategoryButton.Text = "ver Categorias";
            viewCategoryButton.UseVisualStyleBackColor = true;
            viewCategoryButton.Click += viewCategoryButton_Click;
            // 
            // validationError
            // 
            validationError.ContainerControl = this;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 828);
            Controls.Add(viewCategoryButton);
            Controls.Add(deleteProductButton);
            Controls.Add(updateProductButton);
            Controls.Add(saveProductButton);
            Controls.Add(listProdutDataGridView);
            Controls.Add(categoryProductComboBox);
            Controls.Add(categoryProductError);
            Controls.Add(categoryProductLabel);
            Controls.Add(priceProductError);
            Controls.Add(priceProductTextBox);
            Controls.Add(priceProductLabel);
            Controls.Add(stockProductError);
            Controls.Add(stockTextBox);
            Controls.Add(stockLabel);
            Controls.Add(nameProductError);
            Controls.Add(nameProductTextBox);
            Controls.Add(nameProductLabel);
            Controls.Add(titleProductLabel);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)listProdutDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)validationError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleProductLabel;
        private Label nameProductLabel;
        private TextBox nameProductTextBox;
        private Label nameProductError;
        private Label stockProductError;
        private TextBox stockTextBox;
        private Label stockLabel;
        private Label priceProductError;
        private TextBox priceProductTextBox;
        private Label priceProductLabel;
        private Label categoryProductError;
        private Label categoryProductLabel;
        private ComboBox categoryProductComboBox;
        private DataGridView listProdutDataGridView;
        private Button saveProductButton;
        private Button updateProductButton;
        private Button deleteProductButton;
        private Button viewCategoryButton;
        private ErrorProvider validationError;
    }
}