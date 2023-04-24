using Microsoft.EntityFrameworkCore;
using StudentEnrollmentSystem.Models;

namespace StudentEnrollmentSystem.Data
{
    public static class SeedSections
    {
        public static void SeedSectionCodes(this ModelBuilder builder)
        {
            // Monday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 1, SectionCode = "MAD", Day = "Monday", StartTime = "07:00 AM", EndTime = "08:30 AM", FullSchedule = "Monday, 07:00 AM-08:30 AM"},
                new Section { ID = 2, SectionCode = "MDG", Day = "Monday", StartTime = "08:30 AM", EndTime = "10:00 AM", FullSchedule = "Monday, 08:30 AM-10:00 AM" },
                new Section { ID = 3, SectionCode = "MGJ", Day = "Monday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Monday, 10:00 AM-11:30 AM" },
                new Section { ID = 4, SectionCode = "MJM", Day = "Monday", StartTime = "11:30 AM", EndTime = "01:00 PM", FullSchedule = "Monday, 11:30 AM-01:00 PM" },
                new Section { ID = 5, SectionCode = "MMP", Day = "Monday", StartTime = "01:00 PM", EndTime = "02:30 PM", FullSchedule = "Monday, 01:00 PM-02:30 PM" },
                new Section { ID = 6, SectionCode = "MPS", Day = "Monday", StartTime = "02:30 PM", EndTime = "04:00 PM", FullSchedule = "Monday, 02:30 PM-04:00 PM" },
                new Section { ID = 7, SectionCode = "MSV", Day = "Monday", StartTime = "04:00 PM", EndTime = "05:30 PM", FullSchedule = "Monday, 04:00 PM-05:30 PM" },
                new Section { ID = 8, SectionCode = "MVY", Day = "Monday", StartTime = "05:30 PM", EndTime = "07:00 PM", FullSchedule = "Monday, 05:30 PM-07:00 PM" }
                );

            // Tuesday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 9, SectionCode = "TAD", Day = "Tuesday", StartTime = "07:00 AM", EndTime = "08:30 AM", FullSchedule = "Tuesday, 07:00 AM-08:30 AM" },
                new Section { ID = 10, SectionCode = "TDG", Day = "Tuesday", StartTime = "08:30 AM", EndTime = "10:00 AM", FullSchedule = "Tuesday, 08:30 AM-10:00 AM" },
                new Section { ID = 11, SectionCode = "TGJ", Day = "Tuesday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Tuesday, 10:00 AM-11:30 AM" },
                new Section { ID = 12, SectionCode = "TJM", Day = "Tuesday", StartTime = "11:30 AM", EndTime = "01:00 PM", FullSchedule = "Tuesday, 11:30 AM-01:00 PM" },
                new Section { ID = 13, SectionCode = "TMP", Day = "Tuesday", StartTime = "01:00 PM", EndTime = "02:30 PM", FullSchedule = "Tuesday, 01:00 PM-02:30 PM" },
                new Section { ID = 14, SectionCode = "TPS", Day = "Tuesday", StartTime = "02:30 PM", EndTime = "04:00 PM", FullSchedule = "Tuesday, 02:30 PM-04:00 PM" },
                new Section { ID = 15, SectionCode = "TSV", Day = "Tuesday", StartTime = "04:00 PM", EndTime = "05:30 PM", FullSchedule = "Tuesday, 04:00 PM-05:30 PM" },
                new Section { ID = 16, SectionCode = "TVY", Day = "Tuesday", StartTime = "05:30 PM", EndTime = "07:00 PM", FullSchedule = "Tuesday, 05:30 PM-07:00 PM" }
                );

            // Wednesday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 17, SectionCode = "WAD", Day = "Wednesday", StartTime = "07:00 AM", EndTime = "08:30 AM", FullSchedule = "Wednesday, 07:00 AM-08:30 AM" },
                new Section { ID = 18, SectionCode = "WDG", Day = "Wednesday", StartTime = "08:30 AM", EndTime = "10:00 AM", FullSchedule = "Wednesday, 08:30 AM-10:00 AM" },
                new Section { ID = 19, SectionCode = "WGJ", Day = "Wednesday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Wednesday, 10:00 AM-11:30 AM" },
                new Section { ID = 20, SectionCode = "WJM", Day = "Wednesday", StartTime = "11:30 AM", EndTime = "01:00 PM", FullSchedule = "Wednesday, 11:30 AM-01:00 PM" },
                new Section { ID = 21, SectionCode = "WMP", Day = "Wednesday", StartTime = "01:00 PM", EndTime = "02:30 PM", FullSchedule = "Wednesday, 01:00 PM-02:30 PM" },
                new Section { ID = 22, SectionCode = "WPS", Day = "Wednesday", StartTime = "02:30 PM", EndTime = "04:00 PM", FullSchedule = "Wednesday, 02:30 PM-04:00 PM" },
                new Section { ID = 23, SectionCode = "WSV", Day = "Wednesday", StartTime = "04:00 PM", EndTime = "05:30 PM", FullSchedule = "Wednesday, 04:00 PM-05:30 PM" },
                new Section { ID = 24, SectionCode = "WVY", Day = "Wednesday", StartTime = "05:30 PM", EndTime = "07:00 PM", FullSchedule = "Wednesday, 05:30 PM-07:00 PM" }
                );

            // Thursday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 25, SectionCode = "HAD", Day = "Thursday", StartTime = "07:00 AM", EndTime = "08:30 AM", FullSchedule = "Thursday, 07:00 AM-08:30 AM" },
                new Section { ID = 26, SectionCode = "HDG", Day = "Thursday", StartTime = "08:30 AM", EndTime = "10:00 AM", FullSchedule = "Thursday, 08:30 AM-10:00 AM" },
                new Section { ID = 27, SectionCode = "HGJ", Day = "Thursday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Thursday, 10:00 AM-11:30 AM" },
                new Section { ID = 28, SectionCode = "HJM", Day = "Thursday", StartTime = "11:30 AM", EndTime = "01:00 PM", FullSchedule = "Thursday, 11:30 AM-01:00 PM" },
                new Section { ID = 29, SectionCode = "HMP", Day = "Thursday", StartTime = "01:00 PM", EndTime = "02:30 PM", FullSchedule = "Thursday, 01:00 PM-02:30 PM" },
                new Section { ID = 30, SectionCode = "HPS", Day = "Thursday", StartTime = "02:30 PM", EndTime = "04:00 PM", FullSchedule = "Thursday, 02:30 PM-04:00 PM" },
                new Section { ID = 31, SectionCode = "HSV", Day = "Thursday", StartTime = "04:00 PM", EndTime = "05:30 PM", FullSchedule = "Thursday, 04:00 PM-05:30 PM" },
                new Section { ID = 32, SectionCode = "HVY", Day = "Thursday", StartTime = "05:30 PM", EndTime = "07:00 PM", FullSchedule = "Thursday, 05:30 PM-07:00 PM" }
                );

            // Friday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 33, SectionCode = "FAD", Day = "Friday", StartTime = "07:00 AM", EndTime = "08:30 AM", FullSchedule = "Friday, 07:00 AM-08:30 AM" },
                new Section { ID = 34, SectionCode = "FDG", Day = "Friday", StartTime = "08:30 AM", EndTime = "10:00 AM", FullSchedule = "Friday, 08:30 AM-10:00 AM" },
                new Section { ID = 35, SectionCode = "FGJ", Day = "Friday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Friday, 10:00 AM-11:30 AM" },
                new Section { ID = 36, SectionCode = "FJM", Day = "Friday", StartTime = "11:30 AM", EndTime = "01:00 PM", FullSchedule = "Friday, 11:30 AM-01:00 PM" },
                new Section { ID = 37, SectionCode = "FMP", Day = "Friday", StartTime = "01:00 PM", EndTime = "02:30 PM", FullSchedule = "Friday, 01:00 PM-02:30 PM" },
                new Section { ID = 38, SectionCode = "FPS", Day = "Friday", StartTime = "02:30 PM", EndTime = "04:00 PM", FullSchedule = "Friday, 02:30 PM-04:00 PM" },
                new Section { ID = 39, SectionCode = "FSV", Day = "Friday", StartTime = "04:00 PM", EndTime = "05:30 PM", FullSchedule = "Friday, 04:00 PM-05:30 PM" },
                new Section { ID = 40, SectionCode = "FVY", Day = "Friday", StartTime = "05:30 PM", EndTime = "07:00 PM", FullSchedule = "Friday, 05:30 PM-07:00 PM" }
                );

            // Saturday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 41, SectionCode = "SAD", Day = "Saturday", StartTime = "07:00 AM", EndTime = "08:30 AM", FullSchedule = "Saturday, 07:00 AM-08:30 AM" },
                new Section { ID = 42, SectionCode = "SDG", Day = "Saturday", StartTime = "08:30 AM", EndTime = "10:00 AM", FullSchedule = "Saturday, 08:30 AM-10:00 AM" },
                new Section { ID = 43, SectionCode = "SGJ", Day = "Saturday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Saturday, 10:00 AM-11:30 AM" },
                new Section { ID = 44, SectionCode = "SJM", Day = "Saturday", StartTime = "11:30 AM", EndTime = "01:00 PM", FullSchedule = "Saturday, 11:30 AM-01:00 PM" },
                new Section { ID = 45, SectionCode = "SMP", Day = "Saturday", StartTime = "01:00 PM", EndTime = "02:30 PM", FullSchedule = "Saturday, 01:00 PM-02:30 PM" },
                new Section { ID = 46, SectionCode = "SPS", Day = "Saturday", StartTime = "02:30 PM", EndTime = "04:00 PM", FullSchedule = "Saturday, 02:30 PM-04:00 PM" },
                new Section { ID = 47, SectionCode = "SSV", Day = "Saturday", StartTime = "04:00 PM", EndTime = "05:30 PM", FullSchedule = "Saturday, 04:00 PM-05:30 PM" },
                new Section { ID = 48, SectionCode = "SVY", Day = "Saturday", StartTime = "05:30 PM", EndTime = "07:00 PM", FullSchedule = "Saturday, 05:30 PM-07:00 PM" }
                );
        }
    }
}