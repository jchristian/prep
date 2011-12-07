using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using prep.bf;

namespace prep.specs
{
    [Subject(typeof(SpellChecker))]
    public class SpellCheckerSpecs
    {
        public abstract class concern : Observes<SpellChecker>
        { };

        public abstract class when_determining_if_a_word_is_in_the_dictionary : concern
        {
            Establish c = () =>
            {
                word_in_dictionary = "test";
            };

            Because b = () => actual = sut.is_word_in_dictionary(word_in_dictionary);

            It should_return_true = () => actual.ShouldBeTrue();

            static string word_in_dictionary;
            static bool actual;
        }
    }
}