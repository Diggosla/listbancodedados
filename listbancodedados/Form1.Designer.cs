namespace listbancodedados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "PC",
            "12",
            "R$5.000"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.bntadd = new System.Windows.Forms.Button();
            this.bntobt = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.bntremover = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_produto,
            this.col_quantidade,
            this.col_preco});
            this.listView1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(42, 43);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(639, 245);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "INSIRA SEUS DADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntadd
            // 
            this.bntadd.BackColor = System.Drawing.Color.Transparent;
            this.bntadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntadd.Location = new System.Drawing.Point(108, 378);
            this.bntadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bntadd.Name = "bntadd";
            this.bntadd.Size = new System.Drawing.Size(119, 23);
            this.bntadd.TabIndex = 2;
            this.bntadd.Text = "ADICIONAR";
            this.bntadd.UseVisualStyleBackColor = false;
            this.bntadd.Click += new System.EventHandler(this.bntadd_Click);
            // 
            // bntobt
            // 
            this.bntobt.BackColor = System.Drawing.Color.Transparent;
            this.bntobt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntobt.Location = new System.Drawing.Point(489, 378);
            this.bntobt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bntobt.Name = "bntobt";
            this.bntobt.Size = new System.Drawing.Size(119, 23);
            this.bntobt.TabIndex = 2;
            this.bntobt.Text = "OBETER";
            this.bntobt.UseVisualStyleBackColor = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(42, 319);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(116, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(201, 319);
            this.txtproduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(116, 20);
            this.txtproduto.TabIndex = 4;
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(391, 319);
            this.txtquantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(116, 20);
            this.txtquantidade.TabIndex = 5;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(565, 319);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(116, 20);
            this.txtpreco.TabIndex = 6;
            // 
            // bntremover
            // 
            this.bntremover.BackColor = System.Drawing.Color.Transparent;
            this.bntremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntremover.Location = new System.Drawing.Point(301, 378);
            this.bntremover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bntremover.Name = "bntremover";
            this.bntremover.Size = new System.Drawing.Size(119, 23);
            this.bntremover.TabIndex = 2;
            this.bntremover.Text = "REMOVER";
            this.bntremover.UseVisualStyleBackColor = false;
            this.bntremover.Click += new System.EventHandler(this.bntremover_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PRODUTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "QUANTIDADE\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PREÇO";
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 100;
            // 
            // col_produto
            // 
            this.col_produto.Text = "PRODUTO";
            this.col_produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_produto.Width = 162;
            // 
            // col_quantidade
            // 
            this.col_quantidade.Text = "QUANTIDADE";
            this.col_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_quantidade.Width = 187;
            // 
            // col_preco
            // 
            this.col_preco.Text = "PREÇO";
            this.col_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_preco.Width = 197;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 436);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.bntobt);
            this.Controls.Add(this.bntremover);
            this.Controls.Add(this.bntadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "DADOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntadd;
        private System.Windows.Forms.Button bntobt;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Button bntremover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_quantidade;
        private System.Windows.Forms.ColumnHeader col_preco;
    }
}

