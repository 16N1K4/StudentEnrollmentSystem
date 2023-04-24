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
                new Section { ID = 1, SectionCode = "MAD", Day = "Monday", StartTime = "7:00 AM", EndTime = "8:30 AM", FullSchedule = "Monday, 7:00 AM-8:30 AM"},
                new Section { ID = 2, SectionCode = "MDG", Day = "Monday", StartTime = "8:30 AM", EndTime = "10:00 AM", FullSchedule = "Monday, 8:30 AM-10:00 AM" },
                new Section { ID = 3, SectionCode = "MGJ", Day = "Monday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Monday, 10:00 AM-11:30 AM" },
                new Section { ID = 4, SectionCode = "MJM", Day = "Monday", StartTime = "11:30 AM", EndTime = "1:00 PM", FullSchedule = "Monday, 11:30 AM-1:00 PM" },
                new Section { ID = 5, SectionCode = "MMP", Day = "Monday", StartTime = "1:00 PM", EndTime = "2:30 PM", FullSchedule = "Monday, 1:00 PM-2:30 PM" },
                new Section { ID = 6, SectionCode = "MPS", Day = "Monday", StartTime = "2:30 PM", EndTime = "4:00 PM", FullSchedule = "Monday, 2:30 PM-4:00 PM" },
                new Section { ID = 7, SectionCode = "MSV", Day = "Monday", StartTime = "4:00 PM", EndTime = "5:30 PM", FullSchedule = "Monday, 4:00 PM-5:30 PM" },
                new Section { ID = 8, SectionCode = "MVY", Day = "Monday", StartTime = "5:30 PM", EndTime = "7:00 PM", FullSchedule = "Monday, 5:30 PM-7:00 PM" }
                );

            // Tuesday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 9, SectionCode = "TAD", Day = "Tuesday", StartTime = "7:00 AM", EndTime = "8:30 AM", FullSchedule = "Tuesday, 7:00 AM-8:30 AM" },
                new Section { ID = 10, SectionCode = "TDG", Day = "Tuesday", StartTime = "8:30 AM", EndTime = "10:00 AM", FullSchedule = "Tuesday, 8:30 AM-10:00 AM" },
                new Section { ID = 11, SectionCode = "TGJ", Day = "Tuesday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Tuesday, 10:00 AM-11:30 AM" },
                new Section { ID = 12, SectionCode = "TJM", Day = "Tuesday", StartTime = "11:30 AM", EndTime = "1:00 PM", FullSchedule = "Tuesday, 11:30 AM-1:00 PM" },
                new Section { ID = 13, SectionCode = "TMP", Day = "Tuesday", StartTime = "1:00 PM", EndTime = "2:30 PM", FullSchedule = "Tuesday, 1:00 PM-2:30 PM" },
                new Section { ID = 14, SectionCode = "TPS", Day = "Tuesday", StartTime = "2:30 PM", EndTime = "4:00 PM", FullSchedule = "Tuesday, 2:30 PM-4:00 PM" },
                new Section { ID = 15, SectionCode = "TSV", Day = "Tuesday", StartTime = "4:00 PM", EndTime = "5:30 PM", FullSchedule = "Tuesday, 4:00 PM-5:30 PM" },
                new Section { ID = 16, SectionCode = "TVY", Day = "Tuesday", StartTime = "5:30 PM", EndTime = "7:00 PM", FullSchedule = "Tuesday, 5:30 PM-7:00 PM" }
                );

            // Wednesday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 17, SectionCode = "WAD", Day = "Wednesday", StartTime = "7:00 AM", EndTime = "8:30 AM", FullSchedule = "Wednesday, 7:00 AM-8:30 AM" },
                new Section { ID = 18, SectionCode = "WDG", Day = "Wednesday", StartTime = "8:30 AM", EndTime = "10:00 AM", FullSchedule = "Wednesday, 8:30 AM-10:00 AM" },
                new Section { ID = 19, SectionCode = "WGJ", Day = "Wednesday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Wednesday, 10:00 AM-11:30 AM" },
                new Section { ID = 20, SectionCode = "WJM", Day = "Wednesday", StartTime = "11:30 AM", EndTime = "1:00 PM", FullSchedule = "Wednesday, 11:30 AM-1:00 PM" },
                new Section { ID = 21, SectionCode = "WMP", Day = "Wednesday", StartTime = "1:00 PM", EndTime = "2:30 PM", FullSchedule = "Wednesday, 1:00 PM-2:30 PM" },
                new Section { ID = 22, SectionCode = "WPS", Day = "Wednesday", StartTime = "2:30 PM", EndTime = "4:00 PM", FullSchedule = "Wednesday, 2:30 PM-4:00 PM" },
                new Section { ID = 23, SectionCode = "WSV", Day = "Wednesday", StartTime = "4:00 PM", EndTime = "5:30 PM", FullSchedule = "Wednesday, 4:00 PM-5:30 PM" },
                new Section { ID = 24, SectionCode = "WVY", Day = "Wednesday", StartTime = "5:30 PM", EndTime = "7:00 PM", FullSchedule = "Wednesday, 5:30 PM-7:00 PM" }
                );

            // Thursday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 25, SectionCode = "HAD", Day = "Thursday", StartTime = "7:00 AM", EndTime = "8:30 AM", FullSchedule = "Thursday, 7:00 AM-8:30 AM" },
                new Section { ID = 26, SectionCode = "HDG", Day = "Thursday", StartTime = "8:30 AM", EndTime = "10:00 AM", FullSchedule = "Thursday, 8:30 AM-10:00 AM" },
                new Section { ID = 27, SectionCode = "HGJ", Day = "Thursday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Thursday, 10:00 AM-11:30 AM" },
                new Section { ID = 28, SectionCode = "HJM", Day = "Thursday", StartTime = "11:30 AM", EndTime = "1:00 PM", FullSchedule = "Thursday, 11:30 AM-1:00 PM" },
                new Section { ID = 29, SectionCode = "HMP", Day = "Thursday", StartTime = "1:00 PM", EndTime = "2:30 PM", FullSchedule = "Thursday, 1:00 PM-2:30 PM" },
                new Section { ID = 30, SectionCode = "HPS", Day = "Thursday", StartTime = "2:30 PM", EndTime = "4:00 PM", FullSchedule = "Thursday, 2:30 PM-4:00 PM" },
                new Section { ID = 31, SectionCode = "HSV", Day = "Thursday", StartTime = "4:00 PM", EndTime = "5:30 PM", FullSchedule = "Thursday, 4:00 PM-5:30 PM" },
                new Section { ID = 32, SectionCode = "HVY", Day = "Thursday", StartTime = "5:30 PM", EndTime = "7:00 PM", FullSchedule = "Thursday, 5:30 PM-7:00 PM" }
                );

            // Friday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 33, SectionCode = "FAD", Day = "Friday", StartTime = "7:00 AM", EndTime = "8:30 AM", FullSchedule = "Friday, 7:00 AM-8:30 AM" },
                new Section { ID = 34, SectionCode = "FDG", Day = "Friday", StartTime = "8:30 AM", EndTime = "10:00 AM", FullSchedule = "Friday, 8:30 AM-10:00 AM" },
                new Section { ID = 35, SectionCode = "FGJ", Day = "Friday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Friday, 10:00 AM-11:30 AM" },
                new Section { ID = 36, SectionCode = "FJM", Day = "Friday", StartTime = "11:30 AM", EndTime = "1:00 PM", FullSchedule = "Friday, 11:30 AM-1:00 PM" },
                new Section { ID = 37, SectionCode = "FMP", Day = "Friday", StartTime = "1:00 PM", EndTime = "2:30 PM", FullSchedule = "Friday, 1:00 PM-2:30 PM" },
                new Section { ID = 38, SectionCode = "FPS", Day = "Friday", StartTime = "2:30 PM", EndTime = "4:00 PM", FullSchedule = "Friday, 2:30 PM-4:00 PM" },
                new Section { ID = 39, SectionCode = "FSV", Day = "Friday", StartTime = "4:00 PM", EndTime = "5:30 PM", FullSchedule = "Friday, 4:00 PM-5:30 PM" },
                new Section { ID = 40, SectionCode = "FVY", Day = "Friday", StartTime = "5:30 PM", EndTime = "7:00 PM", FullSchedule = "Friday, 5:30 PM-7:00 PM" }
                );

            // Saturday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 41, SectionCode = "SAD", Day = "Saturday", StartTime = "7:00 AM", EndTime = "8:30 AM", FullSchedule = "Saturday, 7:00 AM-8:30 AM" },
                new Section { ID = 42, SectionCode = "SDG", Day = "Saturday", StartTime = "8:30 AM", EndTime = "10:00 AM", FullSchedule = "Saturday, 8:30 AM-10:00 AM" },
                new Section { ID = 43, SectionCode = "SGJ", Day = "Saturday", StartTime = "10:00 AM", EndTime = "11:30 AM", FullSchedule = "Saturday, 10:00 AM-11:30 AM" },
                new Section { ID = 44, SectionCode = "SJM", Day = "Saturday", StartTime = "11:30 AM", EndTime = "1:00 PM", FullSchedule = "Saturday, 11:30 AM-1:00 PM" },
                new Section { ID = 45, SectionCode = "SMP", Day = "Saturday", StartTime = "1:00 PM", EndTime = "2:30 PM", FullSchedule = "Saturday, 1:00 PM-2:30 PM" },
                new Section { ID = 46, SectionCode = "SPS", Day = "Saturday", StartTime = "2:30 PM", EndTime = "4:00 PM", FullSchedule = "Saturday, 2:30 PM-4:00 PM" },
                new Section { ID = 47, SectionCode = "SSV", Day = "Saturday", StartTime = "4:00 PM", EndTime = "5:30 PM", FullSchedule = "Saturday, 4:00 PM-5:30 PM" },
                new Section { ID = 48, SectionCode = "SVY", Day = "Saturday", StartTime = "5:30 PM", EndTime = "7:00 PM", FullSchedule = "Saturday, 5:30 PM-7:00 PM" }
                );
        }
    }
}