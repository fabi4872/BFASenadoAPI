namespace BFASenado.Services
{
    public interface IMessageService
    {
        string GetBalanceError();
        string GetHashErrorFormatoIncorrecto();
        string GetHashErrorNotFound();
        string GetHashError();
        string GetHashExists();
        string PostHashError();
        string GetHashesError();
        string GetBaseDatosError();
        string PostBaseDatosError();
    }
}
