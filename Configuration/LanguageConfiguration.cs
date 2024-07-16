using Lucky.WebAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lucky.WebAPI.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
                new Language { Name = "English" },
                new Language { Name = "Spanish" },
                new Language { Name = "Mandarin Chinese" },
                new Language { Name = "Hindi" },
                new Language { Name = "Arabic" },
                new Language { Name = "Bengali" },
                new Language { Name = "Russian" },
                new Language { Name = "Portuguese" },
                new Language { Name = "Japanese" },
                new Language { Name = "German" },
                new Language { Name = "French" },
                new Language { Name = "Italian" },
                new Language { Name = "Korean" },
                new Language { Name = "Turkish" },
                new Language { Name = "Dutch" },
                new Language { Name = "Polish" },
                new Language { Name = "Swedish" },
                new Language { Name = "Indonesian" },
                new Language { Name = "Greek" },
                new Language { Name = "Danish" },
                new Language { Name = "Norwegian" },
                new Language { Name = "Finnish" },
                new Language { Name = "Czech" },
                new Language { Name = "Thai" },
                new Language { Name = "Hebrew" },
                new Language { Name = "Romanian" },
                new Language { Name = "Hungarian" },
                new Language { Name = "Vietnamese" },
                new Language { Name = "Malay" },
                new Language { Name = "Slovak" },
                new Language { Name = "Bulgarian" },
                new Language { Name = "Lithuanian" },
                new Language { Name = "Slovenian" },
                new Language { Name = "Latvian" },
                new Language { Name = "Croatian" },
                new Language { Name = "Estonian" },
                new Language { Name = "Serbian" },
                new Language { Name = "Albanian" },
                new Language { Name = "Macedonian" },
                new Language { Name = "Ukrainian" },
                new Language { Name = "Georgian" },
                new Language { Name = "Armenian" },
                new Language { Name = "Persian" },
                new Language { Name = "Swahili" },
                new Language { Name = "Tagalog" },
                new Language { Name = "Hausa" },
                new Language { Name = "Bengali" },
                new Language { Name = "Gujarati" },
                new Language { Name = "Punjabi" },
                new Language { Name = "Telugu" },
                new Language { Name = "Tamil" },
                new Language { Name = "Kannada" },
                new Language { Name = "Malayalam" },
                new Language { Name = "Marathi" },
                new Language { Name = "Urdu" }
                );
        }
    }
}
