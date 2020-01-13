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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Menu2 = new System.Windows.Forms.Button();
            this.panel_Compare = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Menu3 = new System.Windows.Forms.Button();
            this.panel_Embed.SuspendLayout();
            this.panel_Extract.SuspendLayout();
            this.panel_Compare.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Embed_main
            // 
            this.btn_Embed_main.Location = new System.Drawing.Point(80, 212);
            this.btn_Embed_main.Name = "btn_Embed_main";
            this.btn_Embed_main.Size = new System.Drawing.Size(211, 75);
            this.btn_Embed_main.TabIndex = 0;
            this.btn_Embed_main.Text = "Встроить ЦВЗ в изображение";
            this.btn_Embed_main.UseVisualStyleBackColor = true;
            this.btn_Embed_main.Click += new System.EventHandler(this.btn_Embed_main_Click);
            // 
            // btn_Extract_main
            // 
            this.btn_Extract_main.Location = new System.Drawing.Point(550, 212);
            this.btn_Extract_main.Name = "btn_Extract_main";
            this.btn_Extract_main.Size = new System.Drawing.Size(195, 76);
            this.btn_Extract_main.TabIndex = 1;
            this.btn_Extract_main.Text = "Извлечь ЦВЗ из изображения";
            this.btn_Extract_main.UseVisualStyleBackColor = true;
            this.btn_Extract_main.Click += new System.EventHandler(this.btn_Extract_main_Click);
            // 
            // btn_Compare_main
            // 
            this.btn_Compare_main.Location = new System.Drawing.Point(282, 321);
            this.btn_Compare_main.Name = "btn_Compare_main";
            this.btn_Compare_main.Size = new System.Drawing.Size(281, 86);
            this.btn_Compare_main.TabIndex = 2;
            this.btn_Compare_main.Text = "Сравнить ЦВЗ";
            this.btn_Compare_main.UseVisualStyleBackColor = true;
            this.btn_Compare_main.Click += new System.EventHandler(this.btn_Compare_main_Click);
            // 
            // panel_Embed
            // 
            this.panel_Embed.Controls.Add(this.btn_Embed);
            this.panel_Embed.Controls.Add(this.btn_Save_Embed);
            this.panel_Embed.Controls.Add(this.btn_OptimalSizeWM_Embed);
            this.panel_Embed.Controls.Add(this.btn_KnowSizeWM_Embed);
            this.panel_Embed.Controls.Add(this.txt_Status_Embed);
            this.panel_Embed.Controls.Add(this.btn_LoadWM_Embed);
            this.panel_Embed.Controls.Add(this.btn_LoadInit_Embed);
            this.panel_Embed.Controls.Add(this.label1);
            this.panel_Embed.Controls.Add(this.btn_Menu);
            this.panel_Embed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Embed.Location = new System.Drawing.Point(0, 0);
            this.panel_Embed.Name = "panel_Embed";
            this.panel_Embed.Size = new System.Drawing.Size(800, 450);
            this.panel_Embed.TabIndex = 3;
            this.panel_Embed.Visible = false;
            // 
            // btn_Embed
            // 
            this.btn_Embed.Enabled = false;
            this.btn_Embed.Location = new System.Drawing.Point(556, 156);
            this.btn_Embed.Name = "btn_Embed";
            this.btn_Embed.Size = new System.Drawing.Size(178, 46);
            this.btn_Embed.TabIndex = 8;
            this.btn_Embed.Text = "Встроить ЦВЗ в изображение";
            this.btn_Embed.UseVisualStyleBackColor = true;
            this.btn_Embed.Click += new System.EventHandler(this.btn_Embed_Click);
            // 
            // btn_Save_Embed
            // 
            this.btn_Save_Embed.Enabled = false;
            this.btn_Save_Embed.Location = new System.Drawing.Point(477, 58);
            this.btn_Save_Embed.Name = "btn_Save_Embed";
            this.btn_Save_Embed.Size = new System.Drawing.Size(152, 46);
            this.btn_Save_Embed.TabIndex = 7;
            this.btn_Save_Embed.Text = "Сохранить изображение со встроенным ЦВЗ";
            this.btn_Save_Embed.UseVisualStyleBackColor = true;
            this.btn_Save_Embed.Click += new System.EventHandler(this.btn_Save_Embed_Click);
            // 
            // btn_OptimalSizeWM_Embed
            // 
            this.btn_OptimalSizeWM_Embed.Enabled = false;
            this.btn_OptimalSizeWM_Embed.Location = new System.Drawing.Point(334, 149);
            this.btn_OptimalSizeWM_Embed.Name = "btn_OptimalSizeWM_Embed";
            this.btn_OptimalSizeWM_Embed.Size = new System.Drawing.Size(160, 40);
            this.btn_OptimalSizeWM_Embed.TabIndex = 6;
            this.btn_OptimalSizeWM_Embed.Text = "Узнать оптимальный размер ЦВЗ";
            this.btn_OptimalSizeWM_Embed.UseVisualStyleBackColor = true;
            this.btn_OptimalSizeWM_Embed.Click += new System.EventHandler(this.btn_OptimalSizeWM_Embed_Click);
            // 
            // btn_KnowSizeWM_Embed
            // 
            this.btn_KnowSizeWM_Embed.Enabled = false;
            this.btn_KnowSizeWM_Embed.Location = new System.Drawing.Point(119, 149);
            this.btn_KnowSizeWM_Embed.Name = "btn_KnowSizeWM_Embed";
            this.btn_KnowSizeWM_Embed.Size = new System.Drawing.Size(160, 40);
            this.btn_KnowSizeWM_Embed.TabIndex = 5;
            this.btn_KnowSizeWM_Embed.Text = "Узнать максимально возможный размер ЦВЗ";
            this.btn_KnowSizeWM_Embed.UseVisualStyleBackColor = true;
            this.btn_KnowSizeWM_Embed.Click += new System.EventHandler(this.btn_KnowSizeWM_Embed_Click);
            // 
            // txt_Status_Embed
            // 
            this.txt_Status_Embed.Location = new System.Drawing.Point(39, 212);
            this.txt_Status_Embed.Multiline = true;
            this.txt_Status_Embed.Name = "txt_Status_Embed";
            this.txt_Status_Embed.Size = new System.Drawing.Size(390, 136);
            this.txt_Status_Embed.TabIndex = 4;
            // 
            // btn_LoadWM_Embed
            // 
            this.btn_LoadWM_Embed.Location = new System.Drawing.Point(282, 70);
            this.btn_LoadWM_Embed.Name = "btn_LoadWM_Embed";
            this.btn_LoadWM_Embed.Size = new System.Drawing.Size(110, 34);
            this.btn_LoadWM_Embed.TabIndex = 3;
            this.btn_LoadWM_Embed.Text = "Загрузить ЦВЗ";
            this.btn_LoadWM_Embed.UseVisualStyleBackColor = true;
            this.btn_LoadWM_Embed.Click += new System.EventHandler(this.btn_LoadWM_Embed_Click);
            // 
            // btn_LoadInit_Embed
            // 
            this.btn_LoadInit_Embed.Location = new System.Drawing.Point(80, 64);
            this.btn_LoadInit_Embed.Name = "btn_LoadInit_Embed";
            this.btn_LoadInit_Embed.Size = new System.Drawing.Size(115, 46);
            this.btn_LoadInit_Embed.TabIndex = 2;
            this.btn_LoadInit_Embed.Text = "Загрузить изображение";
            this.btn_LoadInit_Embed.UseVisualStyleBackColor = true;
            this.btn_LoadInit_Embed.Click += new System.EventHandler(this.btn_LoadInit_Embed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Embed";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(533, 383);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(179, 43);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Главное меню";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // panel_Extract
            // 
            this.panel_Extract.Controls.Add(this.label2);
            this.panel_Extract.Controls.Add(this.btn_Menu2);
            this.panel_Extract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Extract.Location = new System.Drawing.Point(0, 0);
            this.panel_Extract.Name = "panel_Extract";
            this.panel_Extract.Size = new System.Drawing.Size(800, 450);
            this.panel_Extract.TabIndex = 1;
            this.panel_Extract.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Extract";
            // 
            // btn_Menu2
            // 
            this.btn_Menu2.Location = new System.Drawing.Point(533, 344);
            this.btn_Menu2.Name = "btn_Menu2";
            this.btn_Menu2.Size = new System.Drawing.Size(180, 63);
            this.btn_Menu2.TabIndex = 0;
            this.btn_Menu2.Text = "Главное меню";
            this.btn_Menu2.UseVisualStyleBackColor = true;
            this.btn_Menu2.Click += new System.EventHandler(this.btn_Menu2_Click);
            // 
            // panel_Compare
            // 
            this.panel_Compare.Controls.Add(this.label3);
            this.panel_Compare.Controls.Add(this.btn_Menu3);
            this.panel_Compare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Compare.Location = new System.Drawing.Point(0, 0);
            this.panel_Compare.Name = "panel_Compare";
            this.panel_Compare.Size = new System.Drawing.Size(800, 450);
            this.panel_Compare.TabIndex = 0;
            this.panel_Compare.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Compare";
            // 
            // btn_Menu3
            // 
            this.btn_Menu3.Location = new System.Drawing.Point(523, 321);
            this.btn_Menu3.Name = "btn_Menu3";
            this.btn_Menu3.Size = new System.Drawing.Size(158, 73);
            this.btn_Menu3.TabIndex = 0;
            this.btn_Menu3.Text = "Главное меню";
            this.btn_Menu3.UseVisualStyleBackColor = true;
            this.btn_Menu3.Click += new System.EventHandler(this.btn_Menu3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Embed);
            this.Controls.Add(this.btn_Compare_main);
            this.Controls.Add(this.btn_Extract_main);
            this.Controls.Add(this.btn_Embed_main);
            this.Controls.Add(this.panel_Extract);
            this.Controls.Add(this.panel_Compare);
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
    }
}

