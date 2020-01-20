namespace DigitalWatermarkingUser
{
    partial class Form1
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
            this.btn_Embed_main = new System.Windows.Forms.Button();
            this.btn_Extract_main = new System.Windows.Forms.Button();
            this.btn_Compare_main = new System.Windows.Forms.Button();
            this.panel_Embed = new System.Windows.Forms.Panel();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_restart_Embed = new System.Windows.Forms.Button();
            this.lbl_loadInit_Embed = new System.Windows.Forms.Label();
            this.btn_Embed = new System.Windows.Forms.Button();
            this.btn_Save_Embed = new System.Windows.Forms.Button();
            this.btn_OptimalSizeWM_Embed = new System.Windows.Forms.Button();
            this.btn_KnowSizeWM_Embed = new System.Windows.Forms.Button();
            this.btn_LoadWM_Embed = new System.Windows.Forms.Button();
            this.btn_LoadInit_Embed = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.txt_Status_Embed = new System.Windows.Forms.TextBox();
            this.panel_Extract = new System.Windows.Forms.Panel();
            this.btn_restart_Extract = new System.Windows.Forms.Button();
            this.btn_save_Extract = new System.Windows.Forms.Button();
            this.btn_exctract = new System.Windows.Forms.Button();
            this.txt_status_Extract = new System.Windows.Forms.TextBox();
            this.btn_loadChanged_Extract = new System.Windows.Forms.Button();
            this.btn_loadInit_Extract = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Menu2 = new System.Windows.Forms.Button();
            this.panel_Compare = new System.Windows.Forms.Panel();
            this.btn_restart_Compare = new System.Windows.Forms.Button();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.txt_Compare = new System.Windows.Forms.TextBox();
            this.btn_loadWM2_Compare = new System.Windows.Forms.Button();
            this.btn_loadWM1_Compare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Menu3 = new System.Windows.Forms.Button();
            this.panel_Embed.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.panel_Extract.SuspendLayout();
            this.panel_Compare.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Embed_main
            // 
            this.btn_Embed_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Embed_main.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Embed_main.Location = new System.Drawing.Point(50, 161);
            this.btn_Embed_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Embed_main.Name = "btn_Embed_main";
            this.btn_Embed_main.Size = new System.Drawing.Size(280, 95);
            this.btn_Embed_main.TabIndex = 1;
            this.btn_Embed_main.Text = "Встроить ЦВЗ в изображение";
            this.btn_Embed_main.UseVisualStyleBackColor = false;
            this.btn_Embed_main.Click += new System.EventHandler(this.btn_Embed_main_Click);
            // 
            // btn_Extract_main
            // 
            this.btn_Extract_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Extract_main.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Extract_main.Location = new System.Drawing.Point(623, 161);
            this.btn_Extract_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Extract_main.Name = "btn_Extract_main";
            this.btn_Extract_main.Size = new System.Drawing.Size(280, 95);
            this.btn_Extract_main.TabIndex = 3;
            this.btn_Extract_main.Text = "Извлечь ЦВЗ из изображения";
            this.btn_Extract_main.UseVisualStyleBackColor = false;
            this.btn_Extract_main.Click += new System.EventHandler(this.btn_Extract_main_Click);
            // 
            // btn_Compare_main
            // 
            this.btn_Compare_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Compare_main.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Compare_main.Location = new System.Drawing.Point(335, 352);
            this.btn_Compare_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Compare_main.Name = "btn_Compare_main";
            this.btn_Compare_main.Size = new System.Drawing.Size(280, 95);
            this.btn_Compare_main.TabIndex = 2;
            this.btn_Compare_main.Text = "Сравнить ЦВЗ";
            this.btn_Compare_main.UseVisualStyleBackColor = false;
            this.btn_Compare_main.Click += new System.EventHandler(this.btn_Compare_main_Click);
            // 
            // panel_Embed
            // 
            this.panel_Embed.BackColor = System.Drawing.Color.Moccasin;
            this.panel_Embed.Controls.Add(this.pnl_Main);
            this.panel_Embed.Controls.Add(this.label1);
            this.panel_Embed.Controls.Add(this.btn_restart_Embed);
            this.panel_Embed.Controls.Add(this.lbl_loadInit_Embed);
            this.panel_Embed.Controls.Add(this.btn_Embed);
            this.panel_Embed.Controls.Add(this.btn_Save_Embed);
            this.panel_Embed.Controls.Add(this.btn_OptimalSizeWM_Embed);
            this.panel_Embed.Controls.Add(this.btn_KnowSizeWM_Embed);
            this.panel_Embed.Controls.Add(this.btn_LoadWM_Embed);
            this.panel_Embed.Controls.Add(this.btn_LoadInit_Embed);
            this.panel_Embed.Controls.Add(this.btn_Menu);
            this.panel_Embed.Controls.Add(this.txt_Status_Embed);
            this.panel_Embed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Embed.Location = new System.Drawing.Point(0, 0);
            this.panel_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Embed.Name = "panel_Embed";
            this.panel_Embed.Size = new System.Drawing.Size(932, 603);
            this.panel_Embed.TabIndex = 5;
            this.panel_Embed.Visible = false;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_Main.Controls.Add(this.btn_Embed_main);
            this.pnl_Main.Controls.Add(this.btn_Extract_main);
            this.pnl_Main.Controls.Add(this.btn_Compare_main);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(932, 603);
            this.pnl_Main.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Встраивание ЦВЗ в изображение";
            // 
            // btn_restart_Embed
            // 
            this.btn_restart_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_restart_Embed.Location = new System.Drawing.Point(678, 460);
            this.btn_restart_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restart_Embed.Name = "btn_restart_Embed";
            this.btn_restart_Embed.Size = new System.Drawing.Size(235, 55);
            this.btn_restart_Embed.TabIndex = 10;
            this.btn_restart_Embed.Text = "Начать заново";
            this.btn_restart_Embed.UseVisualStyleBackColor = false;
            this.btn_restart_Embed.Click += new System.EventHandler(this.btn_restart_Embed_Click);
            // 
            // lbl_loadInit_Embed
            // 
            this.lbl_loadInit_Embed.AutoSize = true;
            this.lbl_loadInit_Embed.Location = new System.Drawing.Point(100, 101);
            this.lbl_loadInit_Embed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_loadInit_Embed.Name = "lbl_loadInit_Embed";
            this.lbl_loadInit_Embed.Size = new System.Drawing.Size(0, 23);
            this.lbl_loadInit_Embed.TabIndex = 9;
            // 
            // btn_Embed
            // 
            this.btn_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Embed.Enabled = false;
            this.btn_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Embed.Location = new System.Drawing.Point(49, 493);
            this.btn_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Embed.Name = "btn_Embed";
            this.btn_Embed.Size = new System.Drawing.Size(238, 94);
            this.btn_Embed.TabIndex = 8;
            this.btn_Embed.Text = "Встроить ЦВЗ в изображение";
            this.btn_Embed.UseVisualStyleBackColor = false;
            this.btn_Embed.Click += new System.EventHandler(this.btn_Embed_Click);
            // 
            // btn_Save_Embed
            // 
            this.btn_Save_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save_Embed.Enabled = false;
            this.btn_Save_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save_Embed.Location = new System.Drawing.Point(350, 493);
            this.btn_Save_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save_Embed.Name = "btn_Save_Embed";
            this.btn_Save_Embed.Size = new System.Drawing.Size(238, 94);
            this.btn_Save_Embed.TabIndex = 7;
            this.btn_Save_Embed.Text = "Сохранить изображение со встроенным ЦВЗ";
            this.btn_Save_Embed.UseVisualStyleBackColor = false;
            this.btn_Save_Embed.Click += new System.EventHandler(this.btn_Save_Embed_Click);
            // 
            // btn_OptimalSizeWM_Embed
            // 
            this.btn_OptimalSizeWM_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_OptimalSizeWM_Embed.Enabled = false;
            this.btn_OptimalSizeWM_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OptimalSizeWM_Embed.Location = new System.Drawing.Point(674, 333);
            this.btn_OptimalSizeWM_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OptimalSizeWM_Embed.Name = "btn_OptimalSizeWM_Embed";
            this.btn_OptimalSizeWM_Embed.Size = new System.Drawing.Size(238, 78);
            this.btn_OptimalSizeWM_Embed.TabIndex = 6;
            this.btn_OptimalSizeWM_Embed.Text = "Узнать оптимальный размер ЦВЗ";
            this.btn_OptimalSizeWM_Embed.UseVisualStyleBackColor = false;
            this.btn_OptimalSizeWM_Embed.Click += new System.EventHandler(this.btn_OptimalSizeWM_Embed_Click);
            // 
            // btn_KnowSizeWM_Embed
            // 
            this.btn_KnowSizeWM_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_KnowSizeWM_Embed.Enabled = false;
            this.btn_KnowSizeWM_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_KnowSizeWM_Embed.Location = new System.Drawing.Point(678, 212);
            this.btn_KnowSizeWM_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KnowSizeWM_Embed.Name = "btn_KnowSizeWM_Embed";
            this.btn_KnowSizeWM_Embed.Size = new System.Drawing.Size(237, 94);
            this.btn_KnowSizeWM_Embed.TabIndex = 5;
            this.btn_KnowSizeWM_Embed.Text = "Узнать максимально возможный размер ЦВЗ";
            this.btn_KnowSizeWM_Embed.UseVisualStyleBackColor = false;
            this.btn_KnowSizeWM_Embed.Click += new System.EventHandler(this.btn_KnowSizeWM_Embed_Click);
            // 
            // btn_LoadWM_Embed
            // 
            this.btn_LoadWM_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_LoadWM_Embed.Enabled = false;
            this.btn_LoadWM_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadWM_Embed.Location = new System.Drawing.Point(350, 101);
            this.btn_LoadWM_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoadWM_Embed.Name = "btn_LoadWM_Embed";
            this.btn_LoadWM_Embed.Size = new System.Drawing.Size(238, 78);
            this.btn_LoadWM_Embed.TabIndex = 3;
            this.btn_LoadWM_Embed.Text = "Загрузить ЦВЗ";
            this.btn_LoadWM_Embed.UseVisualStyleBackColor = false;
            this.btn_LoadWM_Embed.Click += new System.EventHandler(this.btn_LoadWM_Embed_Click);
            // 
            // btn_LoadInit_Embed
            // 
            this.btn_LoadInit_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_LoadInit_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadInit_Embed.Location = new System.Drawing.Point(53, 101);
            this.btn_LoadInit_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoadInit_Embed.Name = "btn_LoadInit_Embed";
            this.btn_LoadInit_Embed.Size = new System.Drawing.Size(238, 78);
            this.btn_LoadInit_Embed.TabIndex = 2;
            this.btn_LoadInit_Embed.Text = "Загрузить изображение";
            this.btn_LoadInit_Embed.UseVisualStyleBackColor = false;
            this.btn_LoadInit_Embed.Click += new System.EventHandler(this.btn_LoadInit_Embed_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Menu.Location = new System.Drawing.Point(674, 532);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(238, 55);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Главное меню";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // txt_Status_Embed
            // 
            this.txt_Status_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Status_Embed.Location = new System.Drawing.Point(53, 212);
            this.txt_Status_Embed.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Status_Embed.Multiline = true;
            this.txt_Status_Embed.Name = "txt_Status_Embed";
            this.txt_Status_Embed.Size = new System.Drawing.Size(572, 235);
            this.txt_Status_Embed.TabIndex = 4;
            // 
            // panel_Extract
            // 
            this.panel_Extract.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel_Extract.Controls.Add(this.btn_restart_Extract);
            this.panel_Extract.Controls.Add(this.btn_save_Extract);
            this.panel_Extract.Controls.Add(this.btn_exctract);
            this.panel_Extract.Controls.Add(this.txt_status_Extract);
            this.panel_Extract.Controls.Add(this.btn_loadChanged_Extract);
            this.panel_Extract.Controls.Add(this.btn_loadInit_Extract);
            this.panel_Extract.Controls.Add(this.label2);
            this.panel_Extract.Controls.Add(this.btn_Menu2);
            this.panel_Extract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Extract.Location = new System.Drawing.Point(0, 0);
            this.panel_Extract.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Extract.Name = "panel_Extract";
            this.panel_Extract.Size = new System.Drawing.Size(932, 603);
            this.panel_Extract.TabIndex = 1;
            this.panel_Extract.Visible = false;
            // 
            // btn_restart_Extract
            // 
            this.btn_restart_Extract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_restart_Extract.Location = new System.Drawing.Point(683, 448);
            this.btn_restart_Extract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restart_Extract.Name = "btn_restart_Extract";
            this.btn_restart_Extract.Size = new System.Drawing.Size(235, 55);
            this.btn_restart_Extract.TabIndex = 11;
            this.btn_restart_Extract.Text = "Начать заново";
            this.btn_restart_Extract.UseVisualStyleBackColor = false;
            this.btn_restart_Extract.Click += new System.EventHandler(this.btn_restart_Extract_Click);
            // 
            // btn_save_Extract
            // 
            this.btn_save_Extract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save_Extract.Enabled = false;
            this.btn_save_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save_Extract.Location = new System.Drawing.Point(321, 484);
            this.btn_save_Extract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save_Extract.Name = "btn_save_Extract";
            this.btn_save_Extract.Size = new System.Drawing.Size(238, 94);
            this.btn_save_Extract.TabIndex = 7;
            this.btn_save_Extract.Text = "Сохранить извлеченный ЦВЗ";
            this.btn_save_Extract.UseVisualStyleBackColor = false;
            this.btn_save_Extract.Click += new System.EventHandler(this.btn_save_Extract_Click);
            // 
            // btn_exctract
            // 
            this.btn_exctract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_exctract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exctract.Enabled = false;
            this.btn_exctract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exctract.Location = new System.Drawing.Point(34, 484);
            this.btn_exctract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exctract.Name = "btn_exctract";
            this.btn_exctract.Size = new System.Drawing.Size(238, 94);
            this.btn_exctract.TabIndex = 6;
            this.btn_exctract.Text = "Извлечь ЦВЗ";
            this.btn_exctract.UseVisualStyleBackColor = false;
            this.btn_exctract.Click += new System.EventHandler(this.btn_exctract_Click);
            // 
            // txt_status_Extract
            // 
            this.txt_status_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_status_Extract.Location = new System.Drawing.Point(34, 212);
            this.txt_status_Extract.Margin = new System.Windows.Forms.Padding(4);
            this.txt_status_Extract.Multiline = true;
            this.txt_status_Extract.Name = "txt_status_Extract";
            this.txt_status_Extract.Size = new System.Drawing.Size(566, 236);
            this.txt_status_Extract.TabIndex = 5;
            // 
            // btn_loadChanged_Extract
            // 
            this.btn_loadChanged_Extract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_loadChanged_Extract.Enabled = false;
            this.btn_loadChanged_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadChanged_Extract.Location = new System.Drawing.Point(302, 92);
            this.btn_loadChanged_Extract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loadChanged_Extract.Name = "btn_loadChanged_Extract";
            this.btn_loadChanged_Extract.Size = new System.Drawing.Size(238, 78);
            this.btn_loadChanged_Extract.TabIndex = 3;
            this.btn_loadChanged_Extract.Text = "Загрузить изображение, содержащее ЦВЗ";
            this.btn_loadChanged_Extract.UseVisualStyleBackColor = false;
            this.btn_loadChanged_Extract.Click += new System.EventHandler(this.btn_loadChanged_Extract_Click);
            // 
            // btn_loadInit_Extract
            // 
            this.btn_loadInit_Extract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_loadInit_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadInit_Extract.Location = new System.Drawing.Point(34, 92);
            this.btn_loadInit_Extract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loadInit_Extract.Name = "btn_loadInit_Extract";
            this.btn_loadInit_Extract.Size = new System.Drawing.Size(238, 78);
            this.btn_loadInit_Extract.TabIndex = 2;
            this.btn_loadInit_Extract.Text = "Загрузить исходное изображение";
            this.btn_loadInit_Extract.UseVisualStyleBackColor = false;
            this.btn_loadInit_Extract.Click += new System.EventHandler(this.btn_loadInit_Extract_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(68, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Извлечение ЦВЗ из изображения";
            // 
            // btn_Menu2
            // 
            this.btn_Menu2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Menu2.Location = new System.Drawing.Point(678, 523);
            this.btn_Menu2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Menu2.Name = "btn_Menu2";
            this.btn_Menu2.Size = new System.Drawing.Size(238, 55);
            this.btn_Menu2.TabIndex = 0;
            this.btn_Menu2.Text = "Главное меню";
            this.btn_Menu2.UseVisualStyleBackColor = false;
            this.btn_Menu2.Click += new System.EventHandler(this.btn_Menu2_Click);
            // 
            // panel_Compare
            // 
            this.panel_Compare.BackColor = System.Drawing.Color.MistyRose;
            this.panel_Compare.Controls.Add(this.btn_restart_Compare);
            this.panel_Compare.Controls.Add(this.btn_Compare);
            this.panel_Compare.Controls.Add(this.txt_Compare);
            this.panel_Compare.Controls.Add(this.btn_loadWM2_Compare);
            this.panel_Compare.Controls.Add(this.btn_loadWM1_Compare);
            this.panel_Compare.Controls.Add(this.label3);
            this.panel_Compare.Controls.Add(this.btn_Menu3);
            this.panel_Compare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Compare.Location = new System.Drawing.Point(0, 0);
            this.panel_Compare.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Compare.Name = "panel_Compare";
            this.panel_Compare.Size = new System.Drawing.Size(932, 603);
            this.panel_Compare.TabIndex = 0;
            this.panel_Compare.Visible = false;
            // 
            // btn_restart_Compare
            // 
            this.btn_restart_Compare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_restart_Compare.Location = new System.Drawing.Point(668, 433);
            this.btn_restart_Compare.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restart_Compare.Name = "btn_restart_Compare";
            this.btn_restart_Compare.Size = new System.Drawing.Size(235, 55);
            this.btn_restart_Compare.TabIndex = 11;
            this.btn_restart_Compare.Text = "Начать заново";
            this.btn_restart_Compare.UseVisualStyleBackColor = false;
            this.btn_restart_Compare.Click += new System.EventHandler(this.btn_restart_Compare_Click);
            // 
            // btn_Compare
            // 
            this.btn_Compare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Compare.Enabled = false;
            this.btn_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Compare.Location = new System.Drawing.Point(688, 298);
            this.btn_Compare.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(171, 57);
            this.btn_Compare.TabIndex = 6;
            this.btn_Compare.Text = "Сравнить ЦВЗ";
            this.btn_Compare.UseVisualStyleBackColor = false;
            this.btn_Compare.Click += new System.EventHandler(this.btn_Compare_Click);
            // 
            // txt_Compare
            // 
            this.txt_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Compare.Location = new System.Drawing.Point(49, 228);
            this.txt_Compare.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Compare.Multiline = true;
            this.txt_Compare.Name = "txt_Compare";
            this.txt_Compare.Size = new System.Drawing.Size(566, 236);
            this.txt_Compare.TabIndex = 5;
            // 
            // btn_loadWM2_Compare
            // 
            this.btn_loadWM2_Compare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_loadWM2_Compare.Enabled = false;
            this.btn_loadWM2_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadWM2_Compare.Location = new System.Drawing.Point(338, 126);
            this.btn_loadWM2_Compare.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loadWM2_Compare.Name = "btn_loadWM2_Compare";
            this.btn_loadWM2_Compare.Size = new System.Drawing.Size(238, 78);
            this.btn_loadWM2_Compare.TabIndex = 3;
            this.btn_loadWM2_Compare.Text = "Загрузить второй ЦВЗ";
            this.btn_loadWM2_Compare.UseVisualStyleBackColor = false;
            this.btn_loadWM2_Compare.Click += new System.EventHandler(this.btn_loadWM2_Compare_Click);
            // 
            // btn_loadWM1_Compare
            // 
            this.btn_loadWM1_Compare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_loadWM1_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadWM1_Compare.Location = new System.Drawing.Point(49, 126);
            this.btn_loadWM1_Compare.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loadWM1_Compare.Name = "btn_loadWM1_Compare";
            this.btn_loadWM1_Compare.Size = new System.Drawing.Size(238, 78);
            this.btn_loadWM1_Compare.TabIndex = 2;
            this.btn_loadWM1_Compare.Text = "Загрузить первый ЦВЗ";
            this.btn_loadWM1_Compare.UseVisualStyleBackColor = false;
            this.btn_loadWM1_Compare.Click += new System.EventHandler(this.btn_loadWM1_Compare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сравнение двух ЦВЗ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Menu3
            // 
            this.btn_Menu3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Menu3.Location = new System.Drawing.Point(668, 532);
            this.btn_Menu3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Menu3.Name = "btn_Menu3";
            this.btn_Menu3.Size = new System.Drawing.Size(238, 55);
            this.btn_Menu3.TabIndex = 0;
            this.btn_Menu3.Text = "Главное меню";
            this.btn_Menu3.UseVisualStyleBackColor = false;
            this.btn_Menu3.Click += new System.EventHandler(this.btn_Menu3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.panel_Embed);
            this.Controls.Add(this.panel_Extract);
            this.Controls.Add(this.panel_Compare);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Внедрение ЦВЗ в изображения";
            this.TopMost = true;
            this.panel_Embed.ResumeLayout(false);
            this.panel_Embed.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.panel_Extract.ResumeLayout(false);
            this.panel_Extract.PerformLayout();
            this.panel_Compare.ResumeLayout(false);
            this.panel_Compare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Embed_main;
        private System.Windows.Forms.Button btn_Extract_main;
        private System.Windows.Forms.Button btn_Compare_main;
        private System.Windows.Forms.Panel panel_Embed;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Panel panel_Extract;
        private System.Windows.Forms.Button btn_Menu2;
        private System.Windows.Forms.Panel panel_Compare;
        private System.Windows.Forms.Button btn_Menu3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OptimalSizeWM_Embed;
        private System.Windows.Forms.Button btn_KnowSizeWM_Embed;
        private System.Windows.Forms.TextBox txt_Status_Embed;
        private System.Windows.Forms.Button btn_LoadWM_Embed;
        private System.Windows.Forms.Button btn_LoadInit_Embed;
        private System.Windows.Forms.Button btn_Save_Embed;
        private System.Windows.Forms.Button btn_Embed;
        private System.Windows.Forms.Button btn_save_Extract;
        private System.Windows.Forms.Button btn_exctract;
        private System.Windows.Forms.TextBox txt_status_Extract;
        private System.Windows.Forms.Button btn_loadChanged_Extract;
        private System.Windows.Forms.Button btn_loadInit_Extract;
        private System.Windows.Forms.Button btn_loadWM2_Compare;
        private System.Windows.Forms.Button btn_loadWM1_Compare;
        private System.Windows.Forms.Button btn_Compare;
        private System.Windows.Forms.TextBox txt_Compare;
        private System.Windows.Forms.Label lbl_loadInit_Embed;
        private System.Windows.Forms.Button btn_restart_Embed;
        private System.Windows.Forms.Button btn_restart_Extract;
        private System.Windows.Forms.Button btn_restart_Compare;
        private System.Windows.Forms.Panel pnl_Main;
    }
}

