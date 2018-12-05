namespace Core.Entities
{
    public class ResultType
    {
        public Environment Environment { get; }

        public SearchCriteria searchCriteria { get; }

        public ResultType(Environment environment, SearchCriteria searchCriteria)
        {
            this.Environment = environment;
            this.searchCriteria = searchCriteria;
        }
    }
}
