namespace OutraChance.Models.Seeders
{
    public static class CaracteristicaSeed
    {
        public static Caracteristica[] GetPreconfiguredCaracteristicas()
        {
            return new Caracteristica[]
            {
                new Caracteristica { Id = 1, Nome = "Cor" },
                new Caracteristica { Id = 2, Nome = "Tamanho" },
                new Caracteristica { Id = 3, Nome = "Departamento" },
                new Caracteristica { Id = 4, Nome = "Genero" },
            };
        }
    }
}
