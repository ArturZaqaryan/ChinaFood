using System.ComponentModel.DataAnnotations;

namespace ChinaFood.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Name(title)")]
        public virtual string TitleEn { get; set; }
        public virtual string TitleArm { get; set; }
        public virtual string TitleRu { get; set; }

        [Display(Name = "Short description")]
        public virtual string SubtitleEn { get; set; }
        public virtual string SubtitleArm { get; set; }
        public virtual string SubtitleRu { get; set; }

        [Display(Name = "Full description")]
        public virtual string TextEn { get; set; }
        public virtual string TextArm { get; set; }
        public virtual string TextRu { get; set; }

        [Display(Name = "Title image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO metatag Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO metatag Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO metatag Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
