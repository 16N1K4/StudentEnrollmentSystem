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
                new Section { ID = 1, SectionCode = "MAB" },
                new Section { ID = 2, SectionCode = "MBC" },
                new Section { ID = 3, SectionCode = "MCD" },
                new Section { ID = 4, SectionCode = "MDE" },
                new Section { ID = 5, SectionCode = "MEF" },
                new Section { ID = 6, SectionCode = "MFG" },
                new Section { ID = 7, SectionCode = "MGH" },
                new Section { ID = 8, SectionCode = "MHI" },
                new Section { ID = 9, SectionCode = "MIJ" }
                );

            // Tuesday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 10, SectionCode = "TAB" },
                new Section { ID = 11, SectionCode = "TBC" },
                new Section { ID = 12, SectionCode = "TCD" },
                new Section { ID = 13, SectionCode = "TDE" },
                new Section { ID = 14, SectionCode = "TEF" },
                new Section { ID = 15, SectionCode = "TFG" },
                new Section { ID = 16, SectionCode = "TGH" },
                new Section { ID = 17, SectionCode = "THI" },
                new Section { ID = 18, SectionCode = "TIJ" }
                );

            // Wednesday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 19, SectionCode = "WAB" },
                new Section { ID = 20, SectionCode = "WBC" },
                new Section { ID = 21, SectionCode = "WCD" },
                new Section { ID = 22, SectionCode = "WDE" },
                new Section { ID = 23, SectionCode = "WEF" },
                new Section { ID = 24, SectionCode = "WFG" },
                new Section { ID = 25, SectionCode = "WGH" },
                new Section { ID = 26, SectionCode = "WHI" },
                new Section { ID = 27, SectionCode = "WIJ" }
                );

            // Thursday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 28, SectionCode = "HAB" },
                new Section { ID = 29, SectionCode = "HBC" },
                new Section { ID = 30, SectionCode = "HCD" },
                new Section { ID = 31, SectionCode = "HDE" },
                new Section { ID = 32, SectionCode = "HEF" },
                new Section { ID = 33, SectionCode = "HFG" },
                new Section { ID = 34, SectionCode = "HGH" },
                new Section { ID = 35, SectionCode = "HHI" },
                new Section { ID = 36, SectionCode = "HIJ" }
                );

            // Friday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 37, SectionCode = "FAB" },
                new Section { ID = 38, SectionCode = "FBC" },
                new Section { ID = 39, SectionCode = "FCD" },
                new Section { ID = 40, SectionCode = "FDE" },
                new Section { ID = 41, SectionCode = "FEF" },
                new Section { ID = 42, SectionCode = "FFG" },
                new Section { ID = 43, SectionCode = "FGH" },
                new Section { ID = 44, SectionCode = "FHI" },
                new Section { ID = 45, SectionCode = "FIJ" }
                );

            // Saturday schedules
            builder.Entity<Section>().HasData(
                new Section { ID = 46, SectionCode = "SAB" },
                new Section { ID = 47, SectionCode = "SBC" },
                new Section { ID = 48, SectionCode = "SCD" },
                new Section { ID = 49, SectionCode = "SDE" },
                new Section { ID = 50, SectionCode = "SEF" },
                new Section { ID = 51, SectionCode = "SFG" },
                new Section { ID = 52, SectionCode = "SGH" },
                new Section { ID = 53, SectionCode = "SHI" },
                new Section { ID = 54, SectionCode = "SIJ" }
                );
        }
    }
}

/*
    Section Code Legend
    
    First Letter: Day of Week
        M - Monday
        T - Tuesday
        W - Wednesday
        H - Thursday
        F - Friday
        S - Saturday
    
    Second and Third Letter: Start and End Time
        A - 7AM/0700
        B - 8:30AM/0830
        C - 10AM/1000
        D - 11:30AM/1130
        E - 1PM/1300
        F - 2:30PM/1430
        G - 4PM/1600
        H - 5:30PM/1730
        I - 7PM/1900
        J - 8:30PM/2030
 */