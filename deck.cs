using System;
using SkiaSharp;
using System.Collections.Generic;

namespace _2020_12_24_Black_Jack
{
    public class deck
    {
        private List<card> the_deck { get; set; }

        public deck()
        {
            the_deck = new List<card>();
        }

        public deck(string file)
        {
            the_deck = load_file(file);
        }

        public List<card> load_file(string file)
        {
            return data.read_data(file);
        }

        public void add_card(card input_card)
        {
            the_deck.Add(input_card);
        }

        public card deal()
        {
            if (the_deck.Count > 0)
            {
                card temp = the_deck[0];

                the_deck.Remove(temp);
                return temp;
            }

            return null;
        }

        public card peek()
        {
            if (the_deck.Count > 0)
            {
                return the_deck[0];
            }

            return null;
        }

        public card peek(int n)
        {
            if (n < the_deck.Count)
            {
                return the_deck[n];
            }

            return null;
        }

        public int clear()
        {
            int temp = the_deck.Count;
            the_deck = new List<card>();

            return temp;
        }

        public void shuffle()
        {
            for (int i = 0; i < the_deck.Count; i++)
            {
                int temp_number = new Random().Next(the_deck.Count);
                card temp = the_deck[i];
                the_deck[i] = the_deck[temp_number];
                the_deck[temp_number] = temp;
            }
        }

        public void shuffle(deck other)
        {
            foreach (var card in other.the_deck)
            {
                the_deck.Add(card);
                other.the_deck.Remove(card);
            }

            for (int i = 0; i < the_deck.Count; i++)
            {
                int temp_number = new Random().Next(the_deck.Count);
                card temp = the_deck[i];
                the_deck[i] = the_deck[temp_number];
                the_deck[temp_number] = temp;
            }
        }

        public int get_count()
        {
            return the_deck.Count;
        }

        public List<card> get_deck()
        {
            return the_deck;
        }
    }
}