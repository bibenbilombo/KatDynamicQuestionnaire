using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KataQuestionnaireDynamic.Models
{
    public class FormularModel
    {
        [Key]
        public int Id { get; set; }
        public List<QuestionModel> Questions { get; set; }
    }
}
