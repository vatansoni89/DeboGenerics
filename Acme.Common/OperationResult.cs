namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult
    {
        public OperationResult()
        {
        }

        public OperationResult(bool result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public bool Result { get; set; } ////<<===Can we make this datatype as variable??
        public string Message { get; set; }
    }

    public class OperationResultDecimal 
    {
        public OperationResultDecimal()
        {
        }

        public OperationResultDecimal(decimal result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public decimal Result { get; set; } ////<<===Can we make this datatype as variable??
        public string Message { get; set; }
    }
}
