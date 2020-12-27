using System;
using SkiaSharp;

namespace _2020_12_24_Black_Jack
{
    public class card
    {
        private int value { get; set; }
        private string name { get; set; }
        private string suit { get; set; }
        private SKBitmap front { get; set; }
        private SKBitmap back { get; set; }
        private bool is_face_up { get; set; }

        public card()
        {
            value = 0;
            name = "Undefined";
            suit = "Unknown Suit";
            front = new SKBitmap();
            back = new SKBitmap();
            is_face_up = false;
        }

        public card(string suit, string name, int value, string front_image, string back_image)
        {
            this.value = value;
            this.name = name;
            this.suit = suit;

            try
            {
                front = SKBitmap.Decode(@front_image);
                Console.WriteLine(front.GetType());
            }
            catch(System.Exception)
            {
                System.Windows.Forms.MessageBox.Show("Missing Data:" + front_image);
            }

            try
            {
                back = SKBitmap.Decode(@back_image);
                Console.WriteLine(back.GetType());
            }
            catch(System.Exception)
            {
                System.Windows.Forms.MessageBox.Show("Missing Data:" + front_image);
            }

            is_face_up = false;
        }

        public SKBitmap get_image()
        {
            if(is_face_up == true)
            {
                return front;
            }

            return back;
        }

        public void flip()
        {
            is_face_up = true;
        }

        public int compare(card comparere)
        {
            switch (comparere.value)
            {
                case 1: return check(comparere.value);
                case 2: return check(comparere.value);
                case 3: return check(comparere.value);
                case 4: return check(comparere.value);
                case 5: return check(comparere.value);
                case 6: return check(comparere.value);
                case 7: return check(comparere.value);
                case 8: return check(comparere.value);
                case 9: return check(comparere.value);
                case 10: return check(comparere.value);
                case 11: return check(comparere.value);
                case 12: return check(comparere.value);
                case 13: return check(comparere.value);
                case 14: return check(comparere.value);
                case 15: return check(comparere.value);
                default: return 0;
            }
        }

        public int check(int value)
        {
            if(this.value > value)
            {
                return 0;
            }
            else if(this.value < value)
            {
                return 1;
            }
            
            return 0;
        }
    }
}