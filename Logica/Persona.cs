namespace Logica
{
    public class Persona
    {
        public string nombre { get; set; } = "Sin Nombre";
        private string documento { get; set; } = "";

        public string Documento
        {
            get { return documento; }

            set {
                if(value.Length == 7)
                {
                    documento = value;

                }
                else
                {
                    throw new Exception("Documento invalido");
                }   
            
            }
        }
        }

    }
}