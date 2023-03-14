using JhipsterOauth.Crosscutting.Constants;

namespace JhipsterOauth.Crosscutting.Exceptions;

public class InternalServerErrorException : BaseException
{
    public InternalServerErrorException(string message) : base(ErrorConstants.DefaultType, message)
    {
    }
}
