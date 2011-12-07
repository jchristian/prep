using System.Collections;

namespace prep.bf
{
    public class SpellChecker
    {
        BitArray filter;

        public SpellChecker(string[] dictionary)
        {
            initialize_bloom_filter(dictionary);
        }

        public bool is_word_in_dictionary(string word) {}

        void initialize_bloom_filter(string[] dictionary)
        {
            filter = new BitArray(250000, false);
        }
    }
}