namespace USP.VideoAula.Domain.Entities
{
    public class Gato : Base.Animal
    {
        public override string Alimentar()
        {
            return "Com peixe e Whiskas!";
        }

        public override string Brincar()
        {
            return "Com novelo de lã";
        }

        public override string Brincar(string comMais)
        {
            return $"Com novelo de lã {comMais}";
        }
    }
}
