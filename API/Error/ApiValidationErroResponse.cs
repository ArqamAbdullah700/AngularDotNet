namespace API.Error
{
    public class ApiValidationErroResponce : ApiResponce
    {
        public ApiValidationErroResponce() : base(400)
        {
        }

        public IEnumerable<string> Error { get; set; }
    }
}