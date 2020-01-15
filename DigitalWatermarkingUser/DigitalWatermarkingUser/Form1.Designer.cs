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
            this.btn_Embed = new System.Windows.Forms.Button();
            this.btn_Save_Embed = new System.Windows.Forms.Button();
            this.btn_OptimalSizeWM_Embed = new System.Windows.Forms.Button();
            this.btn_KnowSizeWM_Embed = new System.Windows.Forms.Button();
            this.txt_Status_Embed = new System.Windows.Forms.TextBox();
            this.btn_LoadWM_Embed = new System.Windows.Forms.Button();
            this.btn_LoadInit_Embed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.panel_Extract = new System.Windows.Forms.Panel();
            this.btn_save_Extract = new System.Windows.Forms.Button();
            this.btn_exctract = new System.Windows.Forms.Button();
            this.txt_status_Extract = new System.Windows.Forms.TextBox();
            this.btn_loadChanged_Extract = new System.Windows.Forms.Button();
            this.btn_loadInit_Extract = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Menu2 = new System.Windows.Forms.Button();
            this.panel_Compare = new System.Windows.Forms.Panel();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.txt_Compare = new System.Windows.Forms.TextBox();
            this.btn_loadWM2_Compare = new System.Windows.Forms.Button();
            this.btn_loadWM1_Compare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Menu3 = new System.Windows.Forms.Button();
            this.lbl_loadInit_Embed = new System.Windows.Forms.Label();
            this.btn_restart_Embed = new System.Windows.Forms.Button();
            this.panel_Embed.SuspendLayout();
            this.panel_Extract.SuspendLayout();
            this.panel_Compare.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Embed_main
            // 
            this.btn_Embed_main.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Embed_main.Location = new System.Drawing.Point(80, 212);
            this.btn_Embed_main.Name = "btn_Embed_main";
            this.btn_Embed_main.Size = new System.Drawing.Size(211, 77);
            this.btn_Embed_main.TabIndex = 0;
            this.btn_Embed_main.Text = "Встроить ЦВЗ в изображение";
            this.btn_Embed_main.UseVisualStyleBackColor = true;
            this.btn_Embed_main.Click += new System.EventHandler(this.btn_Embed_main_Click);
            // 
            // btn_Extract_main
            // 
            this.btn_Extract_main.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Extract_main.Location = new System.Drawing.Point(477, 210);
            this.btn_Extract_main.Name = "btn_Extract_main";
            this.btn_Extract_main.Size = new System.Drawing.Size(195, 78);
            this.btn_Extract_main.TabIndex = 3;
            this.btn_Extract_main.Text = "Извлечь ЦВЗ из изображения";
            this.btn_Extract_main.UseVisualStyleBackColor = true;
            this.btn_Extract_main.Click += new System.EventHandler(this.btn_Extract_main_Click);
            // 
            // btn_Compare_main
            // 
            this.btn_Compare_main.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Compare_main.Location = new System.Drawing.Point(282, 321);
            this.btn_Compare_main.Name = "btn_Compare_main";
            this.btn_Compare_main.Size = new System.Drawing.Size(281, 88);
            this.btn_Compare_main.TabIndex = 2;
            this.btn_Compare_main.Text = "Сравнить ЦВЗ";
            this.btn_Compare_main.UseVisualStyleBackColor = true;
            this.btn_Compare_main.Click += new System.EventHandler(this.btn_Compare_main_Click);
            // 
            // panel_Embed
            // 
            this.panel_Embed.BackColor = System.Drawing.Color.MistyRose;
            this.panel_Embed.Controls.Add(this.btn_restart_Embed);
            this.panel_Embed.Controls.Add(this.lbl_loadInit_Embed);
            this.panel_Embed.Controls.Add(this.btn_Embed);
            this.panel_Embed.Controls.Add(this.btn_Save_Embed);
            this.panel_Embed.Controls.Add(this.btn_OptimalSizeWM_Embed);
            this.panel_Embed.Controls.Add(this.btn_KnowSizeWM_Embed);
            this.panel_Embed.Controls.Add(this.txt_Status_Embed);
            this.panel_Embed.Controls.Add(this.btn_LoadWM_Embed);
            this.panel_Embed.Controls.Add(this.btn_LoadInit_Embed);
            this.panel_Embed.Controls.Add(this.label1);
            this.panel_Embed.Controls.Add(this.btn_Menu);
            this.panel_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Embed.Location = new System.Drawing.Point(678, 27);
            this.panel_Embed.Name = "panel_Embed";
            this.panel_Embed.Size = new System.Drawing.Size(700, 533);
            this.panel_Embed.TabIndex = 3;
            this.panel_Embed.Visible = false;
            // 
            // btn_Embed
            // 
            this.btn_Embed.Enabled = false;
            this.btn_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Embed.Location = new System.Drawing.Point(502, 338);
            this.btn_Embed.Name = "btn_Embed";
            this.btn_Embed.Size = new System.Drawing.Size(179, 62);
            this.btn_Embed.TabIndex = 8;
            this.btn_Embed.Text = "Встроить ЦВЗ в изображение";
            this.btn_Embed.UseVisualStyleBackColor = true;
            this.btn_Embed.Click += new System.EventHandler(this.btn_Embed_Click);
            // 
            // btn_Save_Embed
            // 
            this.btn_Save_Embed.Enabled = false;
            this.btn_Save_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save_Embed.Location = new System.Drawing.Point(504, 406);
            this.btn_Save_Embed.Name = "btn_Save_Embed";
            this.btn_Save_Embed.Size = new System.Drawing.Size(179, 76);
            this.btn_Save_Embed.TabIndex = 7;
            this.btn_Save_Embed.Text = "Сохранить изображение со встроенным ЦВЗ";
            this.btn_Save_Embed.UseVisualStyleBackColor = true;
            this.btn_Save_Embed.Click += new System.EventHandler(this.btn_Save_Embed_Click);
            // 
            // btn_OptimalSizeWM_Embed
            // 
            this.btn_OptimalSizeWM_Embed.Enabled = false;
            this.btn_OptimalSizeWM_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OptimalSizeWM_Embed.Location = new System.Drawing.Point(504, 268);
            this.btn_OptimalSizeWM_Embed.Name = "btn_OptimalSizeWM_Embed";
            this.btn_OptimalSizeWM_Embed.Size = new System.Drawing.Size(179, 64);
            this.btn_OptimalSizeWM_Embed.TabIndex = 6;
            this.btn_OptimalSizeWM_Embed.Text = "Узнать оптимальный размер ЦВЗ";
            this.btn_OptimalSizeWM_Embed.UseVisualStyleBackColor = true;
            this.btn_OptimalSizeWM_Embed.Click += new System.EventHandler(this.btn_OptimalSizeWM_Embed_Click);
            // 
            // btn_KnowSizeWM_Embed
            // 
            this.btn_KnowSizeWM_Embed.Enabled = false;
            this.btn_KnowSizeWM_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_KnowSizeWM_Embed.Location = new System.Drawing.Point(504, 186);
            this.btn_KnowSizeWM_Embed.Name = "btn_KnowSizeWM_Embed";
            this.btn_KnowSizeWM_Embed.Size = new System.Drawing.Size(178, 76);
            this.btn_KnowSizeWM_Embed.TabIndex = 5;
            this.btn_KnowSizeWM_Embed.Text = "Узнать максимально возможный размер ЦВЗ";
            this.btn_KnowSizeWM_Embed.UseVisualStyleBackColor = true;
            this.btn_KnowSizeWM_Embed.Click += new System.EventHandler(this.btn_KnowSizeWM_Embed_Click);
            // 
            // txt_Status_Embed
            // 
            this.txt_Status_Embed.Enabled = false;
            this.txt_Status_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Status_Embed.Location = new System.Drawing.Point(48, 388);
            this.txt_Status_Embed.Multiline = true;
            this.txt_Status_Embed.Name = "txt_Status_Embed";
            this.txt_Status_Embed.Size = new System.Drawing.Size(430, 45);
            this.txt_Status_Embed.TabIndex = 4;
            // 
            // btn_LoadWM_Embed
            // 
            this.btn_LoadWM_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadWM_Embed.Location = new System.Drawing.Point(503, 117);
            this.btn_LoadWM_Embed.Name = "btn_LoadWM_Embed";
            this.btn_LoadWM_Embed.Size = new System.Drawing.Size(179, 62);
            this.btn_LoadWM_Embed.TabIndex = 3;
            this.btn_LoadWM_Embed.Text = "Загрузить ЦВЗ";
            this.btn_LoadWM_Embed.UseVisualStyleBackColor = true;
            this.btn_LoadWM_Embed.Click += new System.EventHandler(this.btn_LoadWM_Embed_Click);
            // 
            // btn_LoadInit_Embed
            // 
            this.btn_LoadInit_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadInit_Embed.Location = new System.Drawing.Point(503, 48);
            this.btn_LoadInit_Embed.Name = "btn_LoadInit_Embed";
            this.btn_LoadInit_Embed.Size = new System.Drawing.Size(179, 63);
            this.btn_LoadInit_Embed.TabIndex = 2;
            this.btn_LoadInit_Embed.Text = "Загрузить изображение";
            this.btn_LoadInit_Embed.UseVisualStyleBackColor = true;
            this.btn_LoadInit_Embed.Click += new System.EventHandler(this.btn_LoadInit_Embed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Встраивание ЦВЗ в изображение";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Menu.Location = new System.Drawing.Point(15, 469);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(179, 45);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Главное меню";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // panel_Extract
            // 
            this.panel_Extract.BackColor = System.Drawing.Color.Honeydew;
            this.panel_Extract.Controls.Add(this.btn_save_Extract);
            this.panel_Extract.Controls.Add(this.btn_exctract);
            this.panel_Extract.Controls.Add(this.txt_status_Extract);
            this.panel_Extract.Controls.Add(this.btn_loadChanged_Extract);
            this.panel_Extract.Controls.Add(this.btn_loadInit_Extract);
            this.panel_Extract.Controls.Add(this.label2);
            this.panel_Extract.Controls.Add(this.btn_Menu2);
            this.panel_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Extract.Location = new System.Drawing.Point(36, 506);
            this.panel_Extract.Name = "panel_Extract";
            this.panel_Extract.Size = new System.Drawing.Size(577, 477);
            this.panel_Extract.TabIndex = 1;
            this.panel_Extract.Visible = false;
            // 
            // btn_save_Extract
            // 
            this.btn_save_Extract.Enabled = false;
            this.btn_save_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save_Extract.Location = new System.Drawing.Point(538, 246);
            this.btn_save_Extract.Name = "btn_save_Extract";
            this.btn_save_Extract.Size = new System.Drawing.Size(175, 62);
            this.btn_save_Extract.TabIndex = 7;
            this.btn_save_Extract.Text = "Сохранить извлеченный ЦВЗ";
            this.btn_save_Extract.UseVisualStyleBackColor = true;
            this.btn_save_Extract.Click += new System.EventHandler(this.btn_save_Extract_Click);
            // 
            // btn_exctract
            // 
            this.btn_exctract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_exctract.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_exctract.Enabled = false;
            this.btn_exctract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exctract.Location = new System.Drawing.Point(475, 123);
            this.btn_exctract.Name = "btn_exctract";
            this.btn_exctract.Size = new System.Drawing.Size(109, 77);
            this.btn_exctract.TabIndex = 6;
            this.btn_exctract.Text = "Извлечь ЦВЗ";
            this.btn_exctract.UseVisualStyleBackColor = false;
            this.btn_exctract.Click += new System.EventHandler(this.btn_exctract_Click);
            // 
            // txt_status_Extract
            // 
            this.txt_status_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_status_Extract.Location = new System.Drawing.Point(81, 255);
            this.txt_status_Extract.Multiline = true;
            this.txt_status_Extract.Name = "txt_status_Extract";
            this.txt_status_Extract.Size = new System.Drawing.Size(390, 138);
            this.txt_status_Extract.TabIndex = 5;
            // 
            // btn_loadChanged_Extract
            // 
            this.btn_loadChanged_Extract.Enabled = false;
            this.btn_loadChanged_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadChanged_Extract.Location = new System.Drawing.Point(307, 123);
            this.btn_loadChanged_Extract.Name = "btn_loadChanged_Extract";
            this.btn_loadChanged_Extract.Size = new System.Drawing.Size(125, 78);
            this.btn_loadChanged_Extract.TabIndex = 3;
            this.btn_loadChanged_Extract.Text = "Загрузить изображение, содержащее ЦВЗ";
            this.btn_loadChanged_Extract.UseVisualStyleBackColor = true;
            this.btn_loadChanged_Extract.Click += new System.EventHandler(this.btn_loadChanged_Extract_Click);
            // 
            // btn_loadInit_Extract
            // 
            this.btn_loadInit_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadInit_Extract.Location = new System.Drawing.Point(121, 123);
            this.btn_loadInit_Extract.Name = "btn_loadInit_Extract";
            this.btn_loadInit_Extract.Size = new System.Drawing.Size(142, 78);
            this.btn_loadInit_Extract.TabIndex = 2;
            this.btn_loadInit_Extract.Text = "Загрузить исходное изображение";
            this.btn_loadInit_Extract.UseVisualStyleBackColor = true;
            this.btn_loadInit_Extract.Click += new System.EventHandler(this.btn_loadInit_Extract_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Extract";
            // 
            // btn_Menu2
            // 
            this.btn_Menu2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Menu2.Location = new System.Drawing.Point(533, 344);
            this.btn_Menu2.Name = "btn_Menu2";
            this.btn_Menu2.Size = new System.Drawing.Size(180, 65);
            this.btn_Menu2.TabIndex = 0;
            this.btn_Menu2.Text = "Главное меню";
            this.btn_Menu2.UseVisualStyleBackColor = true;
            this.btn_Menu2.Click += new System.EventHandler(this.btn_Menu2_Click);
            // 
            // panel_Compare
            // 
            this.panel_Compare.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel_Compare.Controls.Add(this.btn_Compare);
            this.panel_Compare.Controls.Add(this.txt_Compare);
            this.panel_Compare.Controls.Add(this.btn_loadWM2_Compare);
            this.panel_Compare.Controls.Add(this.btn_loadWM1_Compare);
            this.panel_Compare.Controls.Add(this.label3);
            this.panel_Compare.Controls.Add(this.btn_Menu3);
            this.panel_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Compare.Location = new System.Drawing.Point(726, 629);
            this.panel_Compare.Name = "panel_Compare";
            this.panel_Compare.Size = new System.Drawing.Size(616, 324);
            this.panel_Compare.TabIndex = 0;
            this.panel_Compare.Visible = false;
            // 
            // btn_Compare
            // 
            this.btn_Compare.Enabled = false;
            this.btn_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Compare.Location = new System.Drawing.Point(475, 149);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(128, 46);
            this.btn_Compare.TabIndex = 6;
            this.btn_Compare.Text = "Сравнить ЦВЗ";
            this.btn_Compare.UseVisualStyleBackColor = true;
            this.btn_Compare.Click += new System.EventHandler(this.btn_Compare_Click);
            // 
            // txt_Compare
            // 
            this.txt_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Compare.Location = new System.Drawing.Point(50, 219);
            this.txt_Compare.Multiline = true;
            this.txt_Compare.Name = "txt_Compare";
            this.txt_Compare.Size = new System.Drawing.Size(390, 138);
            this.txt_Compare.TabIndex = 5;
            // 
            // btn_loadWM2_Compare
            // 
            this.btn_loadWM2_Compare.Enabled = false;
            this.btn_loadWM2_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadWM2_Compare.Location = new System.Drawing.Point(303, 110);
            this.btn_loadWM2_Compare.Name = "btn_loadWM2_Compare";
            this.btn_loadWM2_Compare.Size = new System.Drawing.Size(137, 85);
            this.btn_loadWM2_Compare.TabIndex = 3;
            this.btn_loadWM2_Compare.Text = "Загрузить второй ЦВЗ";
            this.btn_loadWM2_Compare.UseVisualStyleBackColor = true;
            this.btn_loadWM2_Compare.Click += new System.EventHandler(this.btn_loadWM2_Compare_Click);
            // 
            // btn_loadWM1_Compare
            // 
            this.btn_loadWM1_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadWM1_Compare.Location = new System.Drawing.Point(111, 110);
            this.btn_loadWM1_Compare.Name = "btn_loadWM1_Compare";
            this.btn_loadWM1_Compare.Size = new System.Drawing.Size(137, 85);
            this.btn_loadWM1_Compare.TabIndex = 2;
            this.btn_loadWM1_Compare.Text = "Загрузить первый ЦВЗ";
            this.btn_loadWM1_Compare.UseVisualStyleBackColor = true;
            this.btn_loadWM1_Compare.Click += new System.EventHandler(this.btn_loadWM1_Compare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Compare";
            // 
            // btn_Menu3
            // 
            this.btn_Menu3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Menu3.Location = new System.Drawing.Point(475, 282);
            this.btn_Menu3.Name = "btn_Menu3";
            this.btn_Menu3.Size = new System.Drawing.Size(158, 75);
            this.btn_Menu3.TabIndex = 0;
            this.btn_Menu3.Text = "Главное меню";
            this.btn_Menu3.UseVisualStyleBackColor = true;
            this.btn_Menu3.Click += new System.EventHandler(this.btn_Menu3_Click);
            // 
            // lbl_loadInit_Embed
            // 
            this.lbl_loadInit_Embed.AutoSize = true;
            this.lbl_loadInit_Embed.Location = new System.Drawing.Point(75, 82);
            this.lbl_loadInit_Embed.Name = "lbl_loadInit_Embed";
            this.lbl_loadInit_Embed.Size = new System.Drawing.Size(0, 18);
            this.lbl_loadInit_Embed.TabIndex = 9;
            // 
            // btn_restart_Embed
            // 
            this.btn_restart_Embed.Location = new System.Drawing.Point(248, 469);
            this.btn_restart_Embed.Name = "btn_restart_Embed";
            this.btn_restart_Embed.Size = new System.Drawing.Size(144, 45);
            this.btn_restart_Embed.TabIndex = 10;
            this.btn_restart_Embed.Text = "Начать заново";
            this.btn_restart_Embed.UseVisualStyleBackColor = true;
            this.btn_restart_Embed.Click += new System.EventHandler(this.btn_restart_Embed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 1052);
            this.Controls.Add(this.panel_Extract);
            this.Controls.Add(this.btn_Extract_main);
            this.Controls.Add(this.btn_Compare_main);
            this.Controls.Add(this.btn_Embed_main);
            this.Controls.Add(this.panel_Compare);
            this.Controls.Add(this.panel_Embed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Embed.ResumeLayout(false);
            this.panel_Embed.PerformLayout();
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
    }
}

