namespace Plumsail.CommonLib.DataContracts.RequestResult
{
    public class SuccessResult<T> : ISuccessResult<T>
    {
        public SuccessResult(T data)
        {
            Status = ResultStatus.Success.ToString().ToLower();
            Result = data;
        }

        public T Result { get; }

        public string Status { get; }
    }
}
