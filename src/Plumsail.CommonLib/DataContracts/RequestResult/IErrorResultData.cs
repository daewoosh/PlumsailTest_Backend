using Newtonsoft.Json;

namespace Plumsail.CommonLib.DataContracts.RequestResult
{
    public interface IErrorResultData
    {
        [JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)]
        string Code { get; }
        string Message { get; }
    }
}
