namespace USP.VideoAula.Domain.Entities.Base
{
    /// <summary>
    /// Animal é uma SUPER CLASSE. E abstrata para não ser instânciada direto, 
    /// sem ter uma implementação concreta.
    /// </summary>
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
