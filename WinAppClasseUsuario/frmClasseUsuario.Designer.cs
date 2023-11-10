namespace WinAppClasseUsuario
{
    partial class frmClasseUsuario
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.grbProfessor = new System.Windows.Forms.GroupBox();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.txbCargaHoraria = new System.Windows.Forms.TextBox();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.grbAluno = new System.Windows.Forms.GroupBox();
            this.txbNota2 = new System.Windows.Forms.TextBox();
            this.txbNota1 = new System.Windows.Forms.TextBox();
            this.txbTurma = new System.Windows.Forms.TextBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.grbUsuario.SuspendLayout();
            this.grbProfessor.SuspendLayout();
            this.grbAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(228, 268);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(155, 32);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar Usuario";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(this.txbEndereco);
            this.grbUsuario.Controls.Add(this.txbMatricula);
            this.grbUsuario.Controls.Add(this.txbNome);
            this.grbUsuario.Controls.Add(this.lblEndereco);
            this.grbUsuario.Controls.Add(this.lblDataNasc);
            this.grbUsuario.Controls.Add(this.lblMatricula);
            this.grbUsuario.Controls.Add(this.lblNome);
            this.grbUsuario.Controls.Add(this.dtpDataNasc);
            this.grbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsuario.Location = new System.Drawing.Point(12, 24);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Size = new System.Drawing.Size(557, 238);
            this.grbUsuario.TabIndex = 6;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Usuário";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(121, 172);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(430, 29);
            this.txbEndereco.TabIndex = 9;
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(132, 84);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(140, 29);
            this.txbMatricula.TabIndex = 8;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(130, 39);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(421, 29);
            this.txbNome.TabIndex = 7;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(16, 177);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(99, 24);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(16, 129);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(157, 24);
            this.lblDataNasc.TabIndex = 4;
            this.lblDataNasc.Text = "Data Nascimento:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(16, 87);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(90, 24);
            this.lblMatricula.TabIndex = 3;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(179, 124);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(372, 29);
            this.dtpDataNasc.TabIndex = 1;
            // 
            // grbProfessor
            // 
            this.grbProfessor.Controls.Add(this.btnCadastrarProfessor);
            this.grbProfessor.Controls.Add(this.txbCargaHoraria);
            this.grbProfessor.Controls.Add(this.lblCargaHoraria);
            this.grbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProfessor.Location = new System.Drawing.Point(352, 314);
            this.grbProfessor.Name = "grbProfessor";
            this.grbProfessor.Size = new System.Drawing.Size(285, 178);
            this.grbProfessor.TabIndex = 9;
            this.grbProfessor.TabStop = false;
            this.grbProfessor.Text = "Professor";
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(71, 123);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(151, 34);
            this.btnCadastrarProfessor.TabIndex = 2;
            this.btnCadastrarProfessor.Text = "Cadastrar Professor";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = true;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // txbCargaHoraria
            // 
            this.txbCargaHoraria.Location = new System.Drawing.Point(143, 61);
            this.txbCargaHoraria.Name = "txbCargaHoraria";
            this.txbCargaHoraria.Size = new System.Drawing.Size(100, 29);
            this.txbCargaHoraria.TabIndex = 1;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(6, 64);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(131, 24);
            this.lblCargaHoraria.TabIndex = 0;
            this.lblCargaHoraria.Text = "Carga Horária:";
            // 
            // grbAluno
            // 
            this.grbAluno.Controls.Add(this.txbNota2);
            this.grbAluno.Controls.Add(this.txbNota1);
            this.grbAluno.Controls.Add(this.txbTurma);
            this.grbAluno.Controls.Add(this.btnCadastrarAluno);
            this.grbAluno.Controls.Add(this.lblNota2);
            this.grbAluno.Controls.Add(this.lblNota1);
            this.grbAluno.Controls.Add(this.lblTurma);
            this.grbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAluno.Location = new System.Drawing.Point(32, 314);
            this.grbAluno.Name = "grbAluno";
            this.grbAluno.Size = new System.Drawing.Size(277, 178);
            this.grbAluno.TabIndex = 8;
            this.grbAluno.TabStop = false;
            this.grbAluno.Text = "Aluno";
            // 
            // txbNota2
            // 
            this.txbNota2.Location = new System.Drawing.Point(94, 99);
            this.txbNota2.Name = "txbNota2";
            this.txbNota2.Size = new System.Drawing.Size(100, 29);
            this.txbNota2.TabIndex = 5;
            // 
            // txbNota1
            // 
            this.txbNota1.Location = new System.Drawing.Point(94, 64);
            this.txbNota1.Name = "txbNota1";
            this.txbNota1.Size = new System.Drawing.Size(100, 29);
            this.txbNota1.TabIndex = 4;
            // 
            // txbTurma
            // 
            this.txbTurma.Location = new System.Drawing.Point(94, 28);
            this.txbTurma.Name = "txbTurma";
            this.txbTurma.Size = new System.Drawing.Size(100, 29);
            this.txbTurma.TabIndex = 3;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(76, 138);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(118, 34);
            this.btnCadastrarAluno.TabIndex = 1;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(19, 102);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(69, 24);
            this.lblNota2.TabIndex = 2;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(19, 69);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(69, 24);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "Nota 1:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(18, 33);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(70, 24);
            this.lblTurma.TabIndex = 0;
            this.lblTurma.Text = "Turma:";
            // 
            // frmClasseUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 591);
            this.Controls.Add(this.grbProfessor);
            this.Controls.Add(this.grbAluno);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.grbUsuario);
            this.Name = "frmClasseUsuario";
            this.Text = "Cadastro Usuário";
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            this.grbProfessor.ResumeLayout(false);
            this.grbProfessor.PerformLayout();
            this.grbAluno.ResumeLayout(false);
            this.grbAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbUsuario;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.GroupBox grbProfessor;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.TextBox txbCargaHoraria;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.GroupBox grbAluno;
        private System.Windows.Forms.TextBox txbNota2;
        private System.Windows.Forms.TextBox txbNota1;
        private System.Windows.Forms.TextBox txbTurma;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblTurma;
    }
}

