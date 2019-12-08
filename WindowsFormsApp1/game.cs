using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class game : Form
    {
        static string[] words;
        static string current_word;
        static string show_text;
        static int count_success = 0;
        static int count_spaces = 0;
        static int lives;
        static PictureBox[] lives_image;
        public/*слова*/ game()
        {
            InitializeComponent();

            worlds = new string[] { "праздник","подарок","звезда","фейерверк","открытка","олень","ёлка","украшение","мороз","приключение","снеговик","снежинка","зима","метель"};
            lives_image = new PictureBox[] { pictureBox11, pictureBox10, pictureBox9, pictureBox8, pictureBox7, pictureBox6, pictureBox5,pictureBox4, pictureBox3, pictureBox1 };
            current_world = "";
            show_text = "";
            lives = 9;
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
        }
        static void start_game(RichTextBox wordArea)
        {

        }
        static void start_game(RichTextBox wordArea,PictureBox lives_image)
        {

        }
        public static string get_show_text(string word)
        {

        }
        static void centering_text(RichTextBox word_area)
        {

        }
        public static bool is_contains(string word, char symbol)
        {

        }
        public static string get_new_show_text(string word, char symbol, string old_show_text)
        {

        }
        static void button_symbol_click(RichTextBox wordArea, char symbol,Button cur_button, Button startButton)
        {

        }
        private void PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button35_Click(object sender, EventArgs e)
        {

        }
    }
}
