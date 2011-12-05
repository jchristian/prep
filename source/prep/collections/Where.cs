using System;
using prep.utility;

namespace prep.collections
{
  public class Where<ItemToMatch>
  {
    public static CriteriaFactory<ItemToMatch, PropertyType> has_a<PropertyType>(Func<ItemToMatch, PropertyType> accessor)
    {
        return new CriteriaFactory<ItemToMatch, PropertyType>(accessor);
    }
  }

    public class CriteriaFactory<ItemToMatch, PropertyType>
    {
        private readonly Func<ItemToMatch, PropertyType> _accessor;

        public CriteriaFactory(Func<ItemToMatch, PropertyType> accessor)
        {
            _accessor = accessor;
        }

        public IMatchAn<ItemToMatch> equal_to(PropertyType value)
        {
            return new AnonymousMatch<ItemToMatch>(movie => _accessor(movie).Equals(value));
        }
    }
}