using System.Collections.Generic;
using System.Linq;

namespace prep.bf
{
  public class HashFactory : ICreateHashes
  {
    IEnumerable<ICreateAHash> hash_creators;

    public HashFactory(IEnumerable<ICreateAHash> hash_creators)
    {
      this.hash_creators = hash_creators;
    }

    public IEnumerable<int> get_hashes_for(string word)
    {
      return hash_creators.Select(x => x.create_for(word));
    }
  }
}