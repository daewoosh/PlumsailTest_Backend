using Plumsail.CommonLib.Extensions;

namespace Plumsail.CommonLib.DataContracts.RequestResult
{
    public class ErrorResult : IErrorResult
    {
        public ErrorResult(string errorMessage, string errorCode = null)
        {
            if (!errorMessage.IsNullOrWhiteSpace())
            {
                Error = new ErrorResultData(errorMessage, errorCode);
            }
        }
        public IErrorResultData Error { get; }

        public string Status { get; }
    }
}
