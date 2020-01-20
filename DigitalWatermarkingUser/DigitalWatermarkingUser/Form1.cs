using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalWatermarking;
using System.IO;
using System.Diagnostics;

namespace DigitalWatermarkingUser
{
    public partial class Form1 : Form
    {
        private DoubleImage initial_Embed;
        private Watermark watermark_Embed;
        private DoubleImage changed_Embed;

        private DoubleImage initial_Extract;
        private DoubleImage changed_Extract;
        private DoubleImage watermark_Extract;

        private Watermark watermark1_Compare;
        private Watermark watermark2_Compare;
        private JRKimAlgorithm algorithm;
        private int sizeWatermark;

        public Form1()
        {
            InitializeComponent();
            algorithm = new JRKimAlgorithm();
            sizeWatermark = 100;
            pnl_Main.Show();

        }

        #region Form actions
        private void btn_Embed_main_Click(object sender, EventArgs e)
        {
            panel_Embed.Visible = true;
            pnl_Main.Visible = false;
        }

        private void btn_Extract_main_Click(object sender, EventArgs e)
        {
            panel_Extract.Visible = true;
            pnl_Main.Visible = false;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            panel_Embed.Visible = false;
            pnl_Main.Visible = true;

        }

        private void btn_Menu2_Click(object sender, EventArgs e)
        {
            panel_Extract.Visible = false;
            pnl_Main.Visible = true;
        }

        private void btn_Menu3_Click(object sender, EventArgs e)
        {
            panel_Compare.Visible = false;
            pnl_Main.Visible = true;
        }

        private void btn_Compare_main_Click(object sender, EventArgs e)
        {
            panel_Compare.Visible = true;
            pnl_Main.Visible = false;
        }
#endregion

        #region Embed 
        private void btn_LoadInit_Embed_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = openFileDialog1.FileName;
            using (Bitmap imageBitmap = new Bitmap(filename))
            {
                initial_Embed = new DoubleImage(imageBitmap);
            }
            btn_LoadWM_Embed.Enabled = true;
            btn_KnowSizeWM_Embed.Enabled = true;
            btn_OptimalSizeWM_Embed.Enabled = true;
            txt_Status_Embed.Text = "Изображение загружено. Вы можете проверить максимальный и оптимальный размеры ЦВЗ.";
        }

        private void btn_LoadWM_Embed_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            using (Bitmap imageBitmap = new Bitmap(filename))
            {
                DoubleImage dImage = new DoubleImage(imageBitmap);
                watermark_Embed = new Watermark(dImage);
            }
            btn_Embed.Enabled = true;
            txt_Status_Embed.Text = "ЦВЗ загружен.";
        }

        private void btn_Embed_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                changed_Embed = algorithm.KIMembed(initial_Embed, watermark_Embed);
                timer.Stop();
                TimeSpan secs = timer.Elapsed;
                string time = string.Format("{0} секунд", secs.TotalSeconds);
                txt_Status_Embed.Text = "ЦВЗ был успешно встроен. На это потребовалось " + time + ". Сохраните полученное изображение для его просмотра.";
                btn_Save_Embed.Enabled = true;
            }
            catch (Exception ex)
            {
                txt_Status_Embed.Text = ex.Message;
            }

        }


        private void btn_Save_Embed_Click(object sender, EventArgs e)
        {
            Bitmap bitResult = changed_Embed.ToBitmap(1, 0);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            string path = Path.GetFullPath(saveFileDialog1.FileName);
            bitResult.Save(filename);
            txt_Status_Embed.Text = "Файл сохранен. Вы можете его посмотреть по адресу " + path + ".";
        }

        private void btn_KnowSizeWM_Embed_Click(object sender, EventArgs e)
        {
            int maxLength = algorithm.GetMaxWatermarkLength(initial_Embed);
            int sideLength = Utils.MaxSquaredNumber(maxLength);
            txt_Status_Embed.Text = String.Format("Максимально возможный размер ЦВЗ {0}x{0} пикселей.", sideLength);
        }

        private void btn_OptimalSizeWM_Embed_Click(object sender, EventArgs e)
        {
            int maxLength = algorithm.GetOptimalWatermarkLength(initial_Embed);
            int sideLength = Utils.MaxSquaredNumber(maxLength);
            txt_Status_Embed.Text = String.Format("Оптимальный размер ЦВЗ {0}x{0} пикселей.", sideLength);
        }
        #endregion

        #region Extract
        private void btn_loadInit_Extract_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            using (Bitmap imageBitmap = new Bitmap(filename))
            {
                initial_Extract = new DoubleImage(imageBitmap);
            }
            btn_loadChanged_Extract.Enabled = true;
            txt_status_Extract.Text = "Исходное изображение загружено. Теперь загрузите изображение, содержащее ЦВЗ.";
        }

        private void btn_loadChanged_Extract_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter ="jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            using (Bitmap imageBitmap = new Bitmap(filename))
            {
                changed_Extract = new DoubleImage(imageBitmap);
            }
            btn_exctract.Enabled = true;
            txt_status_Extract.Text = "Изображение, содержащее ЦВЗ, загружено. Теперь вы можете извлечь ЦВЗ.";
        }

        private void btn_exctract_Click(object sender, EventArgs e)
        {
            try
            {
                watermark_Extract = algorithm.KIMextract(initial_Extract, changed_Extract, sizeWatermark, sizeWatermark);
                txt_status_Extract.Text = "ЦВЗ был успешно извлечен. Для просмотра его необходимо сохранить.";
                btn_save_Extract.Enabled = true;
            }
            catch (Exception ex)
            {
                txt_status_Extract.Text = ex.Message;
            }
        }
        private void btn_save_Extract_Click(object sender, EventArgs e)
        {
            Bitmap bitResult = watermark_Extract.ToBitmap(1, 0);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            string path = Path.GetFullPath(saveFileDialog1.FileName);
            bitResult.Save(filename);
            txt_status_Extract.Text = "ЦВЗ сохранен. Вы можете его посмотреть по адресу " + path + ".";
        }
        #endregion



        private void btn_loadWM1_Compare_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            using (Bitmap imageBitmap = new Bitmap(filename))
            {
                DoubleImage dImage = new DoubleImage(imageBitmap);
                watermark1_Compare = new Watermark(dImage);
            }
            btn_loadWM2_Compare.Enabled = true;
            txt_Compare.Text = "Первый ЦВЗ загружен.";
        }

        private void btn_loadWM2_Compare_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            using (Bitmap imageBitmap = new Bitmap(filename))
            {
                DoubleImage dImage = new DoubleImage(imageBitmap);
                watermark2_Compare = new Watermark(dImage);
            }
            btn_Compare.Enabled = true;
            txt_Compare.Text = "Второй ЦВЗ загружен.";
        }

        private void btn_Compare_Click(object sender, EventArgs e)
        {
            //добавить код из нотпада на домашнем ноуте
        }

        private void btn_restart_Embed_Click(object sender, EventArgs e)
        {
            btn_Embed.Enabled = false;
            btn_KnowSizeWM_Embed.Enabled = false;
            btn_LoadWM_Embed.Enabled = false;
            btn_OptimalSizeWM_Embed.Enabled = false;
            btn_Save_Embed.Enabled = false;
            txt_Status_Embed.Text = "";
        }

        private void btn_restart_Extract_Click(object sender, EventArgs e)
        {
            btn_loadChanged_Extract.Enabled = false;
            btn_exctract.Enabled = false;
        }

        private void btn_restart_Compare_Click(object sender, EventArgs e)
        {

        }


    }
}
