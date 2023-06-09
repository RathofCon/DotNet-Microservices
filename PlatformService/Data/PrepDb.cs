namespace PlatformService.Data
{

    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {

            using var serviceScope = app.ApplicationServices.CreateScope();
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("Seeding Data");
                context.Platforms.AddRange(
                        new Platform() { Name = "Dot Net", Publisher = "Microscoft", Cost = "Free" },
                        new Platform() { Name = "SQL Server Express", Publisher = "Microscoft", Cost = "Free" },
                        new Platform() { Name = "Oracle RDMS", Publisher = "Oracle", Cost = "Free" }
                 );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Data is already populated");
            }

        }

    }
}