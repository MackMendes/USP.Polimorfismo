using System;

namespace USP.Domain.Entities
{
    public class Cachorro : Base.Animal
    {
        public override string Alimentar()
        {
            return "Com ossos e rações.";
        }

        public override string Brincar()
        {
            return "Com bolinha junto com o meu dono.";
        }
    }
}
