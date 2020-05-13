namespace IceCreamKiosk.Helpers
{
    //helper to centralized the error handling
    public interface IError
    {
        void FireError(string error);
        void CancelError();
    }
}
