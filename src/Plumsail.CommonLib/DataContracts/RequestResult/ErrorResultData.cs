namespace Plumsail.CommonLib.DataContracts.RequestResult
{
    public class ErrorResultData : IErrorResultData
    {
        //  public BSErrorResultData(string message, string errorCode)

        public ErrorResultData(string message, string errorCode = null)
        {
            Message = message;
            Code = errorCode;
        }

        public string Code { get; }

        public string Message { get; }
    }
}
