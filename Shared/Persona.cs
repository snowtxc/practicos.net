namespace Shared
{
    public class Persona
    {
        public Persona() { }
        public string nombre { get; set; } = "Sin Nombre";
        private string documento = "";
        public DateTime fecha_nacimiento;
        public String apellido { get; set; } = "Sin Apellido";
        public string Documento {
            get
            {
                return documento;
            }
            set
            {
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

       

        public override string ToString()
        {
            return "Nombre :" + this.nombre + " " + this.apellido +  ", Documento: " + this.Documento + ", nacimiento: " + this.fecha_nacimiento.Day+"/"+this.fecha_nacimiento.Month+"/"+this.fecha_nacimiento.Year;

        }



    }
}