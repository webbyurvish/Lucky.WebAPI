namespace Lucky.WebAPI.ExceptionHandler
{
    public abstract class BadRequestException : Exception
    {
        public BadRequestException(string message)
            : base(message)
        {
            
        }
    }
}
