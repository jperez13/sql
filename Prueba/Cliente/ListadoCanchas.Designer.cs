namespace Prueba
{
    partial class ListadoCanchas
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
            this.GListadoCanchas = new System.Windows.Forms.DataGridView();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSet1 = new Prueba.DataSet1();
            this.cANCHABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cANCHATableAdapter = new Prueba.DataSet1TableAdapters.CANCHATableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCancha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GListadoCanchas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANCHABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GListadoCanchas
            // 
            this.GListadoCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GListadoCanchas.Location = new System.Drawing.Point(31, 15);
            this.GListadoCanchas.Margin = new System.Windows.Forms.Padding(4);
            this.GListadoCanchas.Name = "GListadoCanchas";
            this.GListadoCanchas.Size = new System.Drawing.Size(936, 258);
            this.GListadoCanchas.TabIndex = 0;
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.Location = new System.Drawing.Point(54, 494);
            this.btnAgregarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(145, 28);
            this.btnAgregarReserva.TabIndex = 1;
            this.btnAgregarReserva.Text = "Agregar Reserva";
            this.btnAgregarReserva.UseVisualStyleBackColor = true;
            this.btnAgregarReserva.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(237, 330);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 2;
            this.lblID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(200, 304);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(160, 22);
            this.txtHora.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CustomFormat = "dd-MM-yyyy";
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(200, 351);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(160, 22);
            this.DtpFecha.TabIndex = 10;
            this.DtpFecha.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cancha";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cANCHABindingSource
            // 
            this.cANCHABindingSource.DataMember = "CANCHA";
            this.cANCHABindingSource.DataSource = this.dataSet1;
            // 
            // cANCHATableAdapter
            // 
            this.cANCHATableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 438);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Monto Cancha";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(200, 435);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(160, 22);
            this.txtMonto.TabIndex = 14;
            // 
            // txtCancha
            // 
            this.txtCancha.Enabled = false;
            this.txtCancha.Location = new System.Drawing.Point(200, 394);
            this.txtCancha.Margin = new System.Windows.Forms.Padding(4);
            this.txtCancha.Name = "txtCancha";
            this.txtCancha.Size = new System.Drawing.Size(160, 22);
            this.txtCancha.TabIndex = 15;
            // 
            // ListadoCanchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 601);
            this.Controls.Add(this.txtCancha);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAgregarReserva);
            this.Controls.Add(this.GListadoCanchas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListadoCanchas";
            this.Text = "ListadoCanchas";
            this.Load += new System.EventHandler(this.ListadoCanchas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GListadoCanchas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANCHABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GListadoCanchas;
        private System.Windows.Forms.Button btnAgregarReserva;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cANCHABindingSource;
        private DataSet1TableAdapters.CANCHATableAdapter cANCHATableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCancha;
    }
}