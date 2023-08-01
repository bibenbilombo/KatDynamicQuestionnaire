using System.ComponentModel.DataAnnotations;

namespace KataQuestionnaireDynamic.Models
{
    public class OptionModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
