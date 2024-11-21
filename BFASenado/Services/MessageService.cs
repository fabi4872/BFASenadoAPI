namespace BFASenado.Services
{
    public class MessageService : IMessageService
    {
        #region Attributes
        #endregion

        #region Constructor
        #endregion

        #region Methods

        public string GetHashErrorFormatoIncorrecto()
        {
            return "El hash tiene un formato incorrecto";
        }

        public string GetHashErrorNotFound()
        {
            return "El hash no existe";
        }

        public string GetHashError()
        {
            return "Error al obtener el hash";
        }

        public string GetHashExists()
        {
            return "El hash ya existe";
        }

        public string PostHashError()
        {
            return "Error al guardar el hash";
        }

        public string GetHashesError()
        {
            return "Error al obtener los hashes";
        }

        public string GetBaseDatosError()
        {
            return "Error al consultar en Base de Datos";
        }

        public string PostBaseDatosError()
        {
            return "Error al guardar en Base de Datos";
        }

        #endregion
    }
}
