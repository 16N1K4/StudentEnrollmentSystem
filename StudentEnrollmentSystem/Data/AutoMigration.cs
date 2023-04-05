using Microsoft.EntityFrameworkCore;

namespace StudentEnrollmentSystem.Data
{
    public static class AutoMigration
    {
        public static void AutoMigrate(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<SESContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
