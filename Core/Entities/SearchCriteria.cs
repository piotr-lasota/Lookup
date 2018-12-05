using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Core.Entities
{
    public class SearchCriteria
    {
        private readonly IList<Regex> regexes;

        public SearchCriteria(IList<Regex> regexes)
        {
            this.regexes = regexes;
        }
    }
}
