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

         
            words = new string[] { "праздник","подарок","звезда","фейерверк","открытка","олень","ёлка","украшение","мороз","приключение","снеговик","снежинка","зима","метель","щука","безделье","смех","солнце","чайник","съезд","пряник","плюшка","новогодний проект","эволюция"};

          //  words = new string[] { "новогодний проэкт"};

            lives_image = new PictureBox[] { pictureBox11, pictureBox10, pictureBox9, pictureBox8, pictureBox7, pictureBox6, pictureBox5,pictureBox4, pictureBox3};
            current_word = "";
            show_text = "";
            lives = lives_image.Length;
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;

            start_game(richTextBox1, lives_image);
        }
        static void start_game(RichTextBox wordArea)
        {
            Random random = new Random();
            int index_word = random.Next(0, words.Length);
            current_word = words[index_word];
            count_success = 0;
            lives = lives_image.Length;
            show_text = get_show_text(current_word);
            wordArea.Text = show_text;
            centering_text(wordArea);
         
        }
        static void start_game(RichTextBox wordArea,PictureBox[] lives_image)
        {
            start_game(wordArea);
            var bmp = new Bitmap(Properties.Resources.sinyaya_zvezda_534x346);
            for (int i = 0; i < lives_image.Length; i++)
            {

                lives_image[i].SizeMode = PictureBoxSizeMode.Zoom;
                lives_image[i].Image = bmp;
            }
        }
        public static string get_show_text(string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    result += "  ";
                    count_spaces++;
                }
                else
                {
                    result += "* ";
                }

            }
            return result;
        }
        public static void centering_text(RichTextBox word_area)
        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
        }
        public static bool is_contains(string word, char symbol)
        {



                /*Console.WriteLine("введи букву");
                bool check = false;
                char chelleng = Convert.ToChar(Console.ReadLine());*/
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == symbol)
                    {
                        return true;
                    }

                }
            return false;
                
            
        }
        public static string get_new_show_text(string word, char symbol, string old_show_text)
        {
            string result = "";
            for(int i = 0; i < old_show_text.Length;i += 2)
            {
                if(word[i/2] == symbol)
                {
                    result += symbol + " ";
                    count_success++;
                }
                else
                {
                    result += old_show_text[i] + " ";
                }
            }
            return result;
        }
        static void button_symbol_click(RichTextBox wordArea, char symbol,Button cur_button, Button startButton)
        {
            bool check = is_contains(current_word, symbol);
            if (check)
            {
                show_text = get_new_show_text(current_word, symbol, show_text);
                wordArea.Text = show_text;
                centering_text(wordArea);
            }
            else
            {
                lives--;
                lives_image[lives].Image = null;
            }
            cur_button.Enabled = false;
            if (lives== 0)
            {
                using(game_over lf = new game_over())
                {
                    lf.ShowDialog();
                }
                startButton.PerformClick();
            }else if((count_success + count_spaces) == current_word.Length)
            {
                using (finish f = new finish())
                {
                    f.ShowDialog();
                }
                startButton.PerformClick();
            }
            /*for (int j = 0; j < 7; j++)
            {

                Console.WriteLine("введи букву");
                bool check = false;
                char chelleng = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < lit.Length; i++)
                {
                    if (chelleng == lit[i])
                    {
                        check = true;
                    }

                }
                if (check == true)
                {
                    j--;
                }

           */
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            start_game(richTextBox1, lives_image);
            Button[] buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33 };
            for(int i = 0;i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
            }

        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'а', button1, button34);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'б', button2, button34);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'в', button3, button34);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'г', button4, button34);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'д', button5, button34);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'е', button6, button34);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ё', button7, button34);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ж', button8, button34);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'з', button9, button34);
        }
        

        private void Button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'и', button10, button34);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'й', button11, button34);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'к', button12, button34);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'л', button13, button34);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'м', button14, button34);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'н', button15, button34);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'о', button16, button34);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'п', button17, button34);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'р', button18, button34);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'с', button19, button34);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'т', button20, button34);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'у', button21, button34);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ф', button22, button34);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'х', button23, button34);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ц', button24, button34);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ч', button25, button34);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ш', button26, button34);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'щ', button27, button34);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ъ', button28, button34);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ы', button29, button34);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ь', button30, button34);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'э', button31, button34);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ю', button32, button34);
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'я', button33, button34);
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
