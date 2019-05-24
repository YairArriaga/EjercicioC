namespace Ejercicio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Importarbtn = new System.Windows.Forms.Button();
            this.dgvexcel = new System.Windows.Forms.DataGridView();
            this.chartxls = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.labelmax = new System.Windows.Forms.Label();
            this.labelmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxrota = new System.Windows.Forms.TextBox();
            this.labelclima = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartxls)).BeginInit();
            this.SuspendLayout();
            // 
            // Importarbtn
            // 
            this.Importarbtn.Location = new System.Drawing.Point(73, 298);
            this.Importarbtn.Name = "Importarbtn";
            this.Importarbtn.Size = new System.Drawing.Size(75, 23);
            this.Importarbtn.TabIndex = 0;
            this.Importarbtn.Text = "Importar";
            this.Importarbtn.UseVisualStyleBackColor = true;
            this.Importarbtn.Click += new System.EventHandler(this.Importarbtn_Click);
            // 
            // dgvexcel
            // 
            this.dgvexcel.AllowUserToAddRows = false;
            this.dgvexcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexcel.Location = new System.Drawing.Point(12, 28);
            this.dgvexcel.Name = "dgvexcel";
            this.dgvexcel.Size = new System.Drawing.Size(543, 255);
            this.dgvexcel.TabIndex = 1;
            this.dgvexcel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexcel_CellClick);
            // 
            // chartxls
            // 
            chartArea2.Name = "ChartArea1";
            this.chartxls.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartxls.Legends.Add(legend2);
            this.chartxls.Location = new System.Drawing.Point(599, 28);
            this.chartxls.Name = "chartxls";
            this.chartxls.Size = new System.Drawing.Size(442, 252);
            this.chartxls.TabIndex = 2;
            this.chartxls.Text = "chart1";
            //this.chartxls.Click += new System.EventHandler(this.chartxls_Click);
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Location = new System.Drawing.Point(565, 335);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(35, 13);
            this.labelPromedio.TabIndex = 3;
            this.labelPromedio.Text = "label1";
            //this.labelPromedio.Click += new System.EventHandler(this.labelPromedio_Click);
            // 
            // labelmax
            // 
            this.labelmax.AutoSize = true;
            this.labelmax.Location = new System.Drawing.Point(565, 298);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(35, 13);
            this.labelmax.TabIndex = 4;
            this.labelmax.Text = "label2";
            // 
            // labelmin
            // 
            this.labelmin.AutoSize = true;
            this.labelmin.Location = new System.Drawing.Point(565, 317);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(35, 13);
            this.labelmin.TabIndex = 5;
            this.labelmin.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero de Rotaciones";
            // 
            // textBoxrota
            // 
            this.textBoxrota.Location = new System.Drawing.Point(317, 310);
            this.textBoxrota.Name = "textBoxrota";
            this.textBoxrota.Size = new System.Drawing.Size(100, 20);
            this.textBoxrota.TabIndex = 7;
            this.textBoxrota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxrota_KeyPress);
            // 
            // labelclima
            // 
            this.labelclima.AutoSize = true;
            this.labelclima.Location = new System.Drawing.Point(12, 9);
            this.labelclima.Name = "labelclima";
            this.labelclima.Size = new System.Drawing.Size(35, 13);
            this.labelclima.TabIndex = 8;
            this.labelclima.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 337);
            this.Controls.Add(this.labelclima);
            this.Controls.Add(this.textBoxrota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelmin);
            this.Controls.Add(this.labelmax);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.chartxls);
            this.Controls.Add(this.dgvexcel);
            this.Controls.Add(this.Importarbtn);
            this.Name = "Form1";
            this.Text = "Ejercicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartxls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Importarbtn;
        private System.Windows.Forms.DataGridView dgvexcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartxls;
        private System.Windows.Forms.Label labelPromedio;
        private System.Windows.Forms.Label labelmax;
        private System.Windows.Forms.Label labelmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxrota;
        private System.Windows.Forms.Label labelclima;
    }
}

