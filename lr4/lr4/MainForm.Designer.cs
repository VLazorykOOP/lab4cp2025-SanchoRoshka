// Designer для MainForm (Варіант 11 - Альтернативне розміщення)
namespace AlcoholSalesApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.dateTimePickerExp = new System.Windows.Forms.DateTimePicker();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.lblType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // ----------- Grid style layout -----------
            int labelX = 30, inputX = 150, rowHeight = 30;
            int leftColY = 20, rightColY = 20;

            // Перша колонка зліва
            this.lblType.Text = "Вид:";
            this.lblType.Location = new System.Drawing.Point(labelX, leftColY);
            this.txtType.Location = new System.Drawing.Point(inputX, leftColY);
            this.txtType.Size = new System.Drawing.Size(160, 20);
            leftColY += rowHeight;

            this.lblBrand.Text = "Марка:";
            this.lblBrand.Location = new System.Drawing.Point(labelX, leftColY);
            this.txtBrand.Location = new System.Drawing.Point(inputX, leftColY);
            this.txtBrand.Size = new System.Drawing.Size(160, 20);
            leftColY += rowHeight;

            this.lblManufacturer.Text = "Виробник:";
            this.lblManufacturer.Location = new System.Drawing.Point(labelX, leftColY);
            this.txtManufacturer.Location = new System.Drawing.Point(inputX, leftColY);
            this.txtManufacturer.Size = new System.Drawing.Size(160, 20);
            leftColY += rowHeight;

            // Друга колонка справа
            int col2XLabel = 360, col2XInput = 480;

            this.lblExp.Text = "Придатний до:";
            this.lblExp.Location = new System.Drawing.Point(col2XLabel, rightColY);
            this.dateTimePickerExp.Location = new System.Drawing.Point(col2XInput, rightColY);
            this.dateTimePickerExp.Size = new System.Drawing.Size(160, 20);
            rightColY += rowHeight;

            this.lblSupplier.Text = "Постачальник:";
            this.lblSupplier.Location = new System.Drawing.Point(col2XLabel, rightColY);
            this.txtSupplier.Location = new System.Drawing.Point(col2XInput, rightColY);
            this.txtSupplier.Size = new System.Drawing.Size(160, 20);
            rightColY += rowHeight;

            this.lblPrice.Text = "Ціна (грн):";
            this.lblPrice.Location = new System.Drawing.Point(col2XLabel, rightColY);
            this.txtPrice.Location = new System.Drawing.Point(col2XInput, rightColY);
            this.txtPrice.Size = new System.Drawing.Size(160, 20);
            rightColY += rowHeight + 10;

            // ----------- Пошук і кнопки -----------
            this.lblSearch.Text = "Пошук (марка / постачальник):";
            this.lblSearch.Location = new System.Drawing.Point(30, 160);
            this.txtSearch.Location = new System.Drawing.Point(260, 160);
            this.txtSearch.Size = new System.Drawing.Size(200, 20);

            this.btnSearch.Text = "🔍";
            this.btnSearch.Location = new System.Drawing.Point(470, 158);
            this.btnSearch.Size = new System.Drawing.Size(40, 25);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnAdd.Text = "➕ Додати";
            this.btnAdd.Location = new System.Drawing.Point(520, 158);
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "✏️ Редагувати";
            this.btnUpdate.Location = new System.Drawing.Point(630, 158);
            this.btnUpdate.Size = new System.Drawing.Size(110, 25);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // ----------- DataGrid -----------
            this.dataGridView1.Location = new System.Drawing.Point(30, 200);
            this.dataGridView1.Size = new System.Drawing.Size(710, 250);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            // ----------- Form Settings -----------
            this.ClientSize = new System.Drawing.Size(780, 470);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                txtType, txtBrand, txtManufacturer, dateTimePickerExp, txtSupplier,
                txtPrice, txtSearch, btnAdd, btnUpdate, btnSearch, dataGridView1,
                lblType, lblBrand, lblManufacturer, lblExp, lblSupplier, lblPrice, lblSearch
            });

            this.Text = "Продаж слабоалкогольних напоїв - Облік";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.DateTimePicker dateTimePickerExp;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSearch;
    }
}