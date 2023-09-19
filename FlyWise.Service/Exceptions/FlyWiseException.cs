namespace FlyWise.Service.Exceptions;
public class FlyWiseException : Exception
{
    public int Code { get; set; }
    public FlyWiseException(int code, string message)
        : base(message)
    {
        this.Code = code;
    }
}
