namespace Lucky.WebAPI.ExceptionHandler
{
    public abstract class NotFoundException : Exception
    {
        public NotFoundException(string message)
            : base(message)
        {
            
        }
    }
}
