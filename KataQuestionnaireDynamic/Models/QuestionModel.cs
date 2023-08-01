using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KataQuestionnaireDynamic.Models
{
    //public enum QuestionType
    //{
    //    Input_Text,
    //    Checkbox,
    //    Select_List
    //}
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Type { get; set; } 
        public List<OptionModel> Options { get; set; }

    }
}
