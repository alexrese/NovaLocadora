
namespace NovaLocadora
{
    partial class FormLocadora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgLocadora = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocadora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLocadora
            // 
            this.dgLocadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocadora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colCategoria,
            this.colDescricao,
            this.colAno});
            this.dgLocadora.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgLocadora.Location = new System.Drawing.Point(12, 142);
            this.dgLocadora.Name = "dgLocadora";
            this.dgLocadora.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgLocadora.Size = new System.Drawing.Size(764, 302);
            this.dgLocadora.TabIndex = 0;
            this.dgLocadora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLocadora_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(137, 18);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(245, 27);
            this.tbNome.TabIndex = 2;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoria.Location = new System.Drawing.Point(95, 58);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(151, 27);
            this.tbCategoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(95, 100);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(675, 27);
            this.tbDescricao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // tbAno
            // 
            this.tbAno.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAno.Location = new System.Drawing.Point(295, 58);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(87, 27);
            this.tbAno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ano";
            // 
            // btLimpar
            // 
            this.btLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLimpar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpar.Location = new System.Drawing.Point(398, 21);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(87, 64);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btInserir
            // 
            this.btInserir.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInserir.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(491, 21);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(87, 64);
            this.btInserir.TabIndex = 10;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(33, 18);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(41, 27);
            this.tbID.TabIndex = 12;
            // 
            // btnAlterar
            // 
            this.btnAlterar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(584, 21);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 64);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(677, 21);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(87, 64);
            this.btnDeletar.TabIndex = 14;
            this.btnDeletar.Text = "Remover";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // colID
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 20F);
            this.colID.DefaultCellStyle = dataGridViewCellStyle6;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // colNome
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNome.DefaultCellStyle = dataGridViewCellStyle7;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Width = 150;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategoria.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            // 
            // colDescricao
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescricao.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 350;
            // 
            // colAno
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAno.DefaultCellStyle = dataGridViewCellStyle10;
            this.colAno.HeaderText = "Ano";
            this.colAno.Name = "colAno";
            this.colAno.Width = 50;
            // 
            // FormLocadora
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 456);
            this.Controls.Add(this.dgLocadora);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Name = "FormLocadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora";
            this.Load += new System.EventHandler(this.FormLocadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLocadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
    }
}

