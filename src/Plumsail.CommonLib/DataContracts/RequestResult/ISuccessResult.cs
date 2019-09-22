namespace Plumsail.CommonLib.DataContracts.RequestResult
{
    interface ISuccessResult<T> : IRequestResult
    {
        T Result { get; }
    }
}
