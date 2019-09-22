namespace Plumsail.CommonLib.DataContracts.RequestResult
{
    public interface IErrorResult : IRequestResult
    {
        IErrorResultData Error { get; }
    }
}
