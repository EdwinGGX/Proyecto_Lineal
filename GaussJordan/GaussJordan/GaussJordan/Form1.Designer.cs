namespace GaussJordan
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnResolver = new System.Windows.Forms.Button();
            this.rchTeOperaciones = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpMatriz = new System.Windows.Forms.TableLayoutPanel();
            this.m23 = new System.Windows.Forms.TextBox();
            this.m13 = new System.Windows.Forms.TextBox();
            this.m03 = new System.Windows.Forms.TextBox();
            this.m22 = new System.Windows.Forms.TextBox();
            this.m21 = new System.Windows.Forms.TextBox();
            this.m20 = new System.Windows.Forms.TextBox();
            this.m12 = new System.Windows.Forms.TextBox();
            this.m11 = new System.Windows.Forms.TextBox();
            this.m10 = new System.Windows.Forms.TextBox();
            this.m02 = new System.Windows.Forms.TextBox();
            this.m01 = new System.Windows.Forms.TextBox();
            this.m00 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpMatriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.Color.PaleGreen;
            this.btnResolver.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.Location = new System.Drawing.Point(110, 433);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(289, 53);
            this.btnResolver.TabIndex = 6;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // rchTeOperaciones
            // 
            this.rchTeOperaciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTeOperaciones.Location = new System.Drawing.Point(657, 69);
            this.rchTeOperaciones.Name = "rchTeOperaciones";
            this.rchTeOperaciones.Size = new System.Drawing.Size(324, 467);
            this.rchTeOperaciones.TabIndex = 3;
            this.rchTeOperaciones.Text = "By: Edwin Escobar y Jonatan Ventura\n\nProceso:\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, -16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 85);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datos de la matriz";
            // 
            // tlpMatriz
            // 
            this.tlpMatriz.BackColor = System.Drawing.Color.Transparent;
            this.tlpMatriz.ColumnCount = 5;
            this.tlpMatriz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMatriz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMatriz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMatriz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMatriz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMatriz.Controls.Add(this.m23, 4, 2);
            this.tlpMatriz.Controls.Add(this.m13, 4, 1);
            this.tlpMatriz.Controls.Add(this.m03, 4, 0);
            this.tlpMatriz.Controls.Add(this.m22, 2, 2);
            this.tlpMatriz.Controls.Add(this.label1, 3, 0);
            this.tlpMatriz.Controls.Add(this.m21, 1, 2);
            this.tlpMatriz.Controls.Add(this.m20, 0, 2);
            this.tlpMatriz.Controls.Add(this.m12, 2, 1);
            this.tlpMatriz.Controls.Add(this.m11, 1, 1);
            this.tlpMatriz.Controls.Add(this.m10, 0, 1);
            this.tlpMatriz.Controls.Add(this.m02, 2, 0);
            this.tlpMatriz.Controls.Add(this.m01, 1, 0);
            this.tlpMatriz.Controls.Add(this.m00, 0, 0);
            this.tlpMatriz.Controls.Add(this.label2, 3, 1);
            this.tlpMatriz.Controls.Add(this.label3, 3, 2);
            this.tlpMatriz.Location = new System.Drawing.Point(13, 69);
            this.tlpMatriz.Name = "tlpMatriz";
            this.tlpMatriz.RowCount = 3;
            this.tlpMatriz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMatriz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMatriz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMatriz.Size = new System.Drawing.Size(497, 328);
            this.tlpMatriz.TabIndex = 4;
            // 
            // m23
            // 
            this.m23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m23.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m23.Location = new System.Drawing.Point(380, 221);
            this.m23.Name = "m23";
            this.m23.Size = new System.Drawing.Size(114, 80);
            this.m23.TabIndex = 11;
            this.m23.Text = "X";
            this.m23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m13
            // 
            this.m13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m13.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m13.Location = new System.Drawing.Point(380, 112);
            this.m13.Name = "m13";
            this.m13.Size = new System.Drawing.Size(114, 80);
            this.m13.TabIndex = 7;
            this.m13.Text = "X";
            this.m13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m03
            // 
            this.m03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m03.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m03.Location = new System.Drawing.Point(380, 3);
            this.m03.Name = "m03";
            this.m03.Size = new System.Drawing.Size(114, 80);
            this.m03.TabIndex = 3;
            this.m03.Text = "X";
            this.m03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m22
            // 
            this.m22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m22.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m22.Location = new System.Drawing.Point(241, 221);
            this.m22.Name = "m22";
            this.m22.Size = new System.Drawing.Size(113, 80);
            this.m22.TabIndex = 10;
            this.m22.Text = "X";
            this.m22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m21
            // 
            this.m21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m21.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m21.Location = new System.Drawing.Point(122, 221);
            this.m21.Name = "m21";
            this.m21.Size = new System.Drawing.Size(113, 80);
            this.m21.TabIndex = 9;
            this.m21.Text = "X";
            this.m21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m20
            // 
            this.m20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m20.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m20.Location = new System.Drawing.Point(3, 221);
            this.m20.Name = "m20";
            this.m20.Size = new System.Drawing.Size(113, 80);
            this.m20.TabIndex = 8;
            this.m20.Text = "X";
            this.m20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m12
            // 
            this.m12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m12.Location = new System.Drawing.Point(241, 112);
            this.m12.Name = "m12";
            this.m12.Size = new System.Drawing.Size(113, 80);
            this.m12.TabIndex = 6;
            this.m12.Text = "X";
            this.m12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m11
            // 
            this.m11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m11.Location = new System.Drawing.Point(122, 112);
            this.m11.Name = "m11";
            this.m11.Size = new System.Drawing.Size(113, 80);
            this.m11.TabIndex = 5;
            this.m11.Text = "X";
            this.m11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m10
            // 
            this.m10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m10.Location = new System.Drawing.Point(3, 112);
            this.m10.Name = "m10";
            this.m10.Size = new System.Drawing.Size(113, 80);
            this.m10.TabIndex = 4;
            this.m10.Text = "X";
            this.m10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m02
            // 
            this.m02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m02.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m02.Location = new System.Drawing.Point(241, 3);
            this.m02.Name = "m02";
            this.m02.Size = new System.Drawing.Size(113, 80);
            this.m02.TabIndex = 2;
            this.m02.Text = "X";
            this.m02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m01
            // 
            this.m01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m01.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m01.Location = new System.Drawing.Point(122, 3);
            this.m01.Name = "m01";
            this.m01.Size = new System.Drawing.Size(113, 80);
            this.m01.TabIndex = 1;
            this.m01.Text = "X";
            this.m01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m00
            // 
            this.m00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m00.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m00.Location = new System.Drawing.Point(3, 3);
            this.m00.Name = "m00";
            this.m00.Size = new System.Drawing.Size(113, 80);
            this.m00.TabIndex = 0;
            this.m00.Text = "X";
            this.m00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 567);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.rchTeOperaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tlpMatriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlpMatriz.ResumeLayout(false);
            this.tlpMatriz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.RichTextBox rchTeOperaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tlpMatriz;
        private System.Windows.Forms.TextBox m23;
        private System.Windows.Forms.TextBox m13;
        private System.Windows.Forms.TextBox m03;
        private System.Windows.Forms.TextBox m22;
        private System.Windows.Forms.TextBox m21;
        private System.Windows.Forms.TextBox m20;
        private System.Windows.Forms.TextBox m12;
        private System.Windows.Forms.TextBox m11;
        private System.Windows.Forms.TextBox m10;
        private System.Windows.Forms.TextBox m02;
        private System.Windows.Forms.TextBox m01;
        private System.Windows.Forms.TextBox m00;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

