using KataQuestionnaireDynamic.Models;
using Microsoft.EntityFrameworkCore;

namespace KataQuestionnaireDynamic.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<FormularModel> Questionnaires { get; set; }
        public DbSet<OptionModel> Options { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //QuestionModel q1 = new QuestionModel() { Id = 1, Question = "J'aime les fraises ?", Type = "Checkbox" };
        //    //QuestionModel q2 = new QuestionModel() { Id = 2, Question = "Je sais nager ?", Type = "Checkbox" };
        //    ////new QuestionModel { Id = 5, Question = "Quelle est la couleur du cheval blanc d'Henri IV ?", Type = "InputText" },
        //    ////new QuestionModel { Id = 6, Question = "Quel est mon langage préféré ?", Type = "Select_List" }

        //    List<QuestionModel> listeDeQuestion = new List<QuestionModel>() { q1, q2 };

        //    modelBuilder.Entity<FormularModel>().HasData(
        //       new FormularModel() { Id = 1, Questions = listeDeQuestion }

        //   );

        //    modelBuilder.Entity<QuestionModel>().HasData(
        //         q1,
        //         q2
        //   );


        //}

    }
}
