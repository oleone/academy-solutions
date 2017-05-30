﻿namespace AcademySolution
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menus = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniProcurarAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.trainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfoUser = new MetroFramework.Controls.MetroLabel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new MetroFramework.Controls.MetroLabel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.Menus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Menus
            // 
            this.Menus.BackColor = System.Drawing.Color.White;
            this.Menus.GripMargin = new System.Windows.Forms.Padding(0);
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.Menus.Location = new System.Drawing.Point(10, 30);
            this.Menus.Name = "Menus";
            this.Menus.Padding = new System.Windows.Forms.Padding(0);
            this.Menus.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menus.Size = new System.Drawing.Size(978, 24);
            this.Menus.TabIndex = 1;
            this.Menus.Text = "mnsMenuPrincipal";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddNew,
            this.addNewFichaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.cadastrosToolStripMenuItem.Text = "Adicionar";
            // 
            // smiAddNew
            // 
            this.smiAddNew.Name = "smiAddNew";
            this.smiAddNew.Size = new System.Drawing.Size(200, 22);
            this.smiAddNew.Text = "Adicionar Novo Usuário";
            this.smiAddNew.Click += new System.EventHandler(this.smiAddNew_Click);
            // 
            // addNewFichaToolStripMenuItem
            // 
            this.addNewFichaToolStripMenuItem.Name = "addNewFichaToolStripMenuItem";
            this.addNewFichaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addNewFichaToolStripMenuItem.Text = "Adicionar Nova Ficha";
            this.addNewFichaToolStripMenuItem.Click += new System.EventHandler(this.addNewFichaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichasToolStripMenuItem,
            this.mniProcurarAlunos,
            this.trainersToolStripMenuItem,
            this.listarAlunosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.consultaToolStripMenuItem.Text = "Procurar";
            // 
            // fichasToolStripMenuItem
            // 
            this.fichasToolStripMenuItem.Name = "fichasToolStripMenuItem";
            this.fichasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fichasToolStripMenuItem.Text = "Fichas";
            this.fichasToolStripMenuItem.Click += new System.EventHandler(this.fichasToolStripMenuItem_Click);
            // 
            // mniProcurarAlunos
            // 
            this.mniProcurarAlunos.Name = "mniProcurarAlunos";
            this.mniProcurarAlunos.Size = new System.Drawing.Size(142, 22);
            this.mniProcurarAlunos.Text = "Alunos";
            this.mniProcurarAlunos.Click += new System.EventHandler(this.mniProcurarAlunos_Click);
            // 
            // trainersToolStripMenuItem
            // 
            this.trainersToolStripMenuItem.Name = "trainersToolStripMenuItem";
            this.trainersToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.trainersToolStripMenuItem.Text = "Trainers";
            this.trainersToolStripMenuItem.Click += new System.EventHandler(this.trainersToolStripMenuItem_Click);
            // 
            // listarAlunosToolStripMenuItem
            // 
            this.listarAlunosToolStripMenuItem.Name = "listarAlunosToolStripMenuItem";
            this.listarAlunosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.listarAlunosToolStripMenuItem.Text = "Listar Alunos";
            this.listarAlunosToolStripMenuItem.Click += new System.EventHandler(this.listarAlunosToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.profileToolStripMenuItem.Text = "Perfil";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirFichaToolStripMenuItem,
            this.excluirAlunoToolStripMenuItem,
            this.excluirTrainerToolStripMenuItem});
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // excluirFichaToolStripMenuItem
            // 
            this.excluirFichaToolStripMenuItem.Name = "excluirFichaToolStripMenuItem";
            this.excluirFichaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.excluirFichaToolStripMenuItem.Text = "Excluir Ficha";
            this.excluirFichaToolStripMenuItem.Click += new System.EventHandler(this.excluirFichaToolStripMenuItem_Click);
            // 
            // excluirAlunoToolStripMenuItem
            // 
            this.excluirAlunoToolStripMenuItem.Name = "excluirAlunoToolStripMenuItem";
            this.excluirAlunoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.excluirAlunoToolStripMenuItem.Text = "Excluir Aluno";
            this.excluirAlunoToolStripMenuItem.Click += new System.EventHandler(this.excluirAlunoToolStripMenuItem_Click);
            // 
            // excluirTrainerToolStripMenuItem
            // 
            this.excluirTrainerToolStripMenuItem.Name = "excluirTrainerToolStripMenuItem";
            this.excluirTrainerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.excluirTrainerToolStripMenuItem.Text = "Excluir Trainer";
            this.excluirTrainerToolStripMenuItem.Click += new System.EventHandler(this.excluirTrainerToolStripMenuItem_Click);
            // 
            // lblInfoUser
            // 
            this.lblInfoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoUser.AutoSize = true;
            this.lblInfoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfoUser.Location = new System.Drawing.Point(786, 30);
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(68, 19);
            this.lblInfoUser.TabIndex = 3;
            this.lblInfoUser.Text = "Username";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(10, 5);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(23, 22);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 5;
            this.pcbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(39, 5);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(181, 19);
            this.lblLogo.TabIndex = 6;
            this.lblLogo.Text = "ACADEMY SOLUTION - PRO";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(-1, 57);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1001, 694);
            this.metroGrid1.TabIndex = 7;
            // 
            // pcbImagem
            // 
            this.pcbImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagem.Image")));
            this.pcbImagem.Location = new System.Drawing.Point(-1, 57);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(1001, 505);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagem.TabIndex = 8;
            this.pcbImagem.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 558);
            this.Controls.Add(this.pcbImagem);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lblInfoUser);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.Menus);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menus;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "ACADEMY SOLUTION - FREE";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menus;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiAddNew;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblInfoUser;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFichaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcbLogo;
        private MetroFramework.Controls.MetroLabel lblLogo;
        private System.Windows.Forms.ToolStripMenuItem fichasToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem mniProcurarAlunos;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainersToolStripMenuItem;
    }
}