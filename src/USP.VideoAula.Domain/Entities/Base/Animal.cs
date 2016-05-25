namespace USP.VideoAula.Domain.Entities.Base
{
    public abstract class Animal
    {
        public virtual string Alimentar()
        {
            return "Com comida";
        }

        public virtual string Brincar()
        {
            return "Com meu brinquedo";
        }

        public virtual string Brincar(string comMais)
        {
            return $"{ this.Brincar() } { comMais }";
        }
    }
}
