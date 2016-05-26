using USP.VideoAula.Domain.Entities.Base;

namespace USP.VideoAula.Domain.Common
{
    public static class AnimalCommon
    {
        public static string AnimalSeAlimentaCom(Animal animal)
        {
            return animal.Alimentar();
        }

        public static string AnimalBrincaCom(Animal animal)
        {
            return animal.Brincar();
        }
    }
}
