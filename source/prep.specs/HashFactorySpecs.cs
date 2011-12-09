using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using prep.bf;

namespace prep.specs
{
  public class HashFactorySpecs
  {
    public abstract class concern : Observes<ICreateHashes,HashFactory>
    {
    }

    [Subject(typeof(HashFactory))]
    public class getting_the_hashes_for_a_word : concern
    {
      Establish c = () =>
      {
        var hash_creator = fake.an<ICreateAHash>();
        depends.on<IEnumerable<ICreateAHash>>(new[] { hash_creator });

        hash_creator.setup(x => x.create_for(word)).Return(hash);
      };

      Because of = () =>
        the_generated_hashes = sut.get_hashes_for(word);

      It should_return_the_set_of_hashes_created_by_the_hash_generators = () =>
        the_generated_hashes.ShouldContainOnly(new[] {hash});

      static IEnumerable<int> the_generated_hashes;
      static int hash;
      static string word;
    }
  }
}