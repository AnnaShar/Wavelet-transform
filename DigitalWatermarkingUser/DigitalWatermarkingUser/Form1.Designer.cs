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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_restart_Embed = new System.Windows.Forms.Button();
            this.btn_Embed = new System.Windows.Forms.Button();
            this.btn_Save_Embed = new System.Windows.Forms.Button();
            this.btn_OptimalSizeWM_Embed = new System.Windows.Forms.Button();
            this.btn_KnowSizeWM_Embed = new System.Windows.Forms.Button();
            this.btn_LoadWM_Embed = new System.Windows.Forms.Button();
            this.btn_LoadInit_Embed = new System.Windows.Forms.Button();
            this.txt_Status_Embed = new System.Windows.Forms.TextBox();
            this.btn_restart_Extract = new System.Windows.Forms.Button();
            this.btn_save_Extract = new System.Windows.Forms.Button();
            this.btn_exctract = new System.Windows.Forms.Button();
            this.txt_status_Extract = new System.Windows.Forms.TextBox();
            this.btn_loadChanged_Extract = new System.Windows.Forms.Button();
            this.btn_loadInit_Extract = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_loadWM1_Compare = new System.Windows.Forms.Button();
            this.btn_loadWM2_Compare = new System.Windows.Forms.Button();
            this.txt_Compare = new System.Windows.Forms.TextBox();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Встраивание ЦВЗ в изображение";
            // 
            // btn_restart_Embed
            // 
            this.btn_restart_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_restart_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_restart_Embed.Location = new System.Drawing.Point(472, 395);
            this.btn_restart_Embed.Name = "btn_restart_Embed";
            this.btn_restart_Embed.Size = new System.Drawing.Size(176, 45);
            this.btn_restart_Embed.TabIndex = 10;
            this.btn_restart_Embed.Text = "Начать заново";
            this.btn_restart_Embed.UseVisualStyleBackColor = false;
            this.btn_restart_Embed.Click += new System.EventHandler(this.btn_restart_Embed_Click);
            // 
            // btn_Embed
            // 
            this.btn_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Embed.Enabled = false;
            this.btn_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Embed.Location = new System.Drawing.Point(38, 364);
            this.btn_Embed.Name = "btn_Embed";
            this.btn_Embed.Size = new System.Drawing.Size(178, 76);
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
            this.btn_Save_Embed.Location = new System.Drawing.Point(253, 364);
            this.btn_Save_Embed.Name = "btn_Save_Embed";
            this.btn_Save_Embed.Size = new System.Drawing.Size(178, 76);
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
            this.btn_OptimalSizeWM_Embed.Location = new System.Drawing.Point(470, 263);
            this.btn_OptimalSizeWM_Embed.Name = "btn_OptimalSizeWM_Embed";
            this.btn_OptimalSizeWM_Embed.Size = new System.Drawing.Size(178, 63);
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
            this.btn_KnowSizeWM_Embed.Location = new System.Drawing.Point(470, 164);
            this.btn_KnowSizeWM_Embed.Name = "btn_KnowSizeWM_Embed";
            this.btn_KnowSizeWM_Embed.Size = new System.Drawing.Size(178, 76);
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
            this.btn_LoadWM_Embed.Location = new System.Drawing.Point(253, 80);
            this.btn_LoadWM_Embed.Name = "btn_LoadWM_Embed";
            this.btn_LoadWM_Embed.Size = new System.Drawing.Size(178, 63);
            this.btn_LoadWM_Embed.TabIndex = 3;
            this.btn_LoadWM_Embed.Text = "Загрузить ЦВЗ";
            this.btn_LoadWM_Embed.UseVisualStyleBackColor = false;
            this.btn_LoadWM_Embed.Click += new System.EventHandler(this.btn_LoadWM_Embed_Click);
            // 
            // btn_LoadInit_Embed
            // 
            this.btn_LoadInit_Embed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_LoadInit_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadInit_Embed.Location = new System.Drawing.Point(38, 80);
            this.btn_LoadInit_Embed.Name = "btn_LoadInit_Embed";
            this.btn_LoadInit_Embed.Size = new System.Drawing.Size(178, 63);
            this.btn_LoadInit_Embed.TabIndex = 2;
            this.btn_LoadInit_Embed.Text = "Загрузить изображение";
            this.btn_LoadInit_Embed.UseVisualStyleBackColor = false;
            this.btn_LoadInit_Embed.Click += new System.EventHandler(this.btn_LoadInit_Embed_Click);
            // 
            // txt_Status_Embed
            // 
            this.txt_Status_Embed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Status_Embed.Location = new System.Drawing.Point(38, 164);
            this.txt_Status_Embed.Multiline = true;
            this.txt_Status_Embed.Name = "txt_Status_Embed";
            this.txt_Status_Embed.Size = new System.Drawing.Size(393, 192);
            this.txt_Status_Embed.TabIndex = 4;
            // 
            // btn_restart_Extract
            // 
            this.btn_restart_Extract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_restart_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_restart_Extract.Location = new System.Drawing.Point(1244, 409);
            this.btn_restart_Extract.Name = "btn_restart_Extract";
            this.btn_restart_Extract.Size = new System.Drawing.Size(176, 45);
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
            this.btn_save_Extract.Location = new System.Drawing.Point(1060, 378);
            this.btn_save_Extract.Name = "btn_save_Extract";
            this.btn_save_Extract.Size = new System.Drawing.Size(178, 76);
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
            this.btn_exctract.Location = new System.Drawing.Point(845, 378);
            this.btn_exctract.Name = "btn_exctract";
            this.btn_exctract.Size = new System.Drawing.Size(178, 76);
            this.btn_exctract.TabIndex = 6;
            this.btn_exctract.Text = "Извлечь ЦВЗ";
            this.btn_exctract.UseVisualStyleBackColor = false;
            this.btn_exctract.Click += new System.EventHandler(this.btn_exctract_Click);
            // 
            // txt_status_Extract
            // 
            this.txt_status_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_status_Extract.Location = new System.Drawing.Point(845, 164);
            this.txt_status_Extract.Multiline = true;
            this.txt_status_Extract.Name = "txt_status_Extract";
            this.txt_status_Extract.Size = new System.Drawing.Size(393, 192);
            this.txt_status_Extract.TabIndex = 5;
            // 
            // btn_loadChanged_Extract
            // 
            this.btn_loadChanged_Extract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_loadChanged_Extract.Enabled = false;
            this.btn_loadChanged_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadChanged_Extract.Location = new System.Drawing.Point(1060, 80);
            this.btn_loadChanged_Extract.Name = "btn_loadChanged_Extract";
            this.btn_loadChanged_Extract.Size = new System.Drawing.Size(178, 63);
            this.btn_loadChanged_Extract.TabIndex = 3;
            this.btn_loadChanged_Extract.Text = "Загрузить изображение, содержащее ЦВЗ";
            this.btn_loadChanged_Extract.UseVisualStyleBackColor = false;
            this.btn_loadChanged_Extract.Click += new System.EventHandler(this.btn_loadChanged_Extract_Click);
            // 
            // btn_loadInit_Extract
            // 
            this.btn_loadInit_Extract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_loadInit_Extract.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadInit_Extract.Location = new System.Drawing.Point(845, 80);
            this.btn_loadInit_Extract.Name = "btn_loadInit_Extract";
            this.btn_loadInit_Extract.Size = new System.Drawing.Size(178, 63);
            this.btn_loadInit_Extract.TabIndex = 2;
            this.btn_loadInit_Extract.Text = "Загрузить исходное изображение";
            this.btn_loadInit_Extract.UseVisualStyleBackColor = false;
            this.btn_loadInit_Extract.Click += new System.EventHandler(this.btn_loadInit_Extract_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(841, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Извлечение ЦВЗ из изображения";
            // 
            // btn_loadWM1_Compare
            // 
            this.btn_loadWM1_Compare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_loadWM1_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadWM1_Compare.Location = new System.Drawing.Point(72, 583);
            this.btn_loadWM1_Compare.Name = "btn_loadWM1_Compare";
            this.btn_loadWM1_Compare.Size = new System.Drawing.Size(178, 63);
            this.btn_loadWM1_Compare.TabIndex = 12;
            this.btn_loadWM1_Compare.Text = "Загрузить 1 ЦВЗ";
            this.btn_loadWM1_Compare.UseVisualStyleBackColor = false;
            this.btn_loadWM1_Compare.Click += new System.EventHandler(this.btn_loadWM1_Compare_Click_1);
            // 
            // btn_loadWM2_Compare
            // 
            this.btn_loadWM2_Compare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_loadWM2_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadWM2_Compare.Location = new System.Drawing.Point(303, 583);
            this.btn_loadWM2_Compare.Name = "btn_loadWM2_Compare";
            this.btn_loadWM2_Compare.Size = new System.Drawing.Size(178, 63);
            this.btn_loadWM2_Compare.TabIndex = 13;
            this.btn_loadWM2_Compare.Text = "Загрузить 2 ЦВЗ";
            this.btn_loadWM2_Compare.UseVisualStyleBackColor = false;
            this.btn_loadWM2_Compare.Click += new System.EventHandler(this.btn_loadWM2_Compare_Click_1);
            // 
            // txt_Compare
            // 
            this.txt_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Compare.Location = new System.Drawing.Point(530, 578);
            this.txt_Compare.Multiline = true;
            this.txt_Compare.Name = "txt_Compare";
            this.txt_Compare.Size = new System.Drawing.Size(422, 68);
            this.txt_Compare.TabIndex = 14;
            // 
            // btn_Compare
            // 
            this.btn_Compare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Compare.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Compare.Location = new System.Drawing.Point(1005, 592);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(176, 45);
            this.btn_Compare.TabIndex = 15;
            this.btn_Compare.Text = "Сравнить ЦВЗ";
            this.btn_Compare.UseVisualStyleBackColor = false;
            this.btn_Compare.Click += new System.EventHandler(this.btn_Compare_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1424, 743);
            this.Controls.Add(this.btn_Compare);
            this.Controls.Add(this.txt_Compare);
            this.Controls.Add(this.btn_loadWM2_Compare);
            this.Controls.Add(this.btn_loadWM1_Compare);
            this.Controls.Add(this.btn_save_Extract);
            this.Controls.Add(this.btn_restart_Extract);
            this.Controls.Add(this.btn_restart_Embed);
            this.Controls.Add(this.btn_exctract);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_status_Extract);
            this.Controls.Add(this.btn_OptimalSizeWM_Embed);
            this.Controls.Add(this.btn_loadChanged_Extract);
            this.Controls.Add(this.btn_Save_Embed);
            this.Controls.Add(this.btn_loadInit_Extract);
            this.Controls.Add(this.btn_KnowSizeWM_Embed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Embed);
            this.Controls.Add(this.btn_LoadInit_Embed);
            this.Controls.Add(this.btn_LoadWM_Embed);
            this.Controls.Add(this.txt_Status_Embed);
            this.Name = "Form1";
            this.Text = "Внедрение ЦВЗ в изображения";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button btn_restart_Embed;
        private System.Windows.Forms.Button btn_restart_Extract;
        private System.Windows.Forms.Button btn_loadWM1_Compare;
        private System.Windows.Forms.Button btn_loadWM2_Compare;
        private System.Windows.Forms.TextBox txt_Compare;
        private System.Windows.Forms.Button btn_Compare;
    }
}

