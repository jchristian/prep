using System.Collections.Generic;

namespace prep.bf
{
  public class SpellChecker
  {
    ICheckIfIContainHashes bloom_filter;
    ICreateHashes hash_factory;

    public SpellChecker(ICheckIfIContainHashes bloom_filter, ICreateHashes hash_factory)
    {
      this.bloom_filter = bloom_filter;
      this.hash_factory = hash_factory;
    }

    public bool is_valid_word(string word)
    {
      return bloom_filter.contains(hash_factory.get_hashes_for(word));
    }
  }

  public interface ICheckIfIContainHashes
  {
    bool contains(IEnumerable<int> hashes);
  }

  public interface ICreateHashes
  {
    IEnumerable<int> get_hashes_for(string word);
  }
}