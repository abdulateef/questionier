using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZenithPensionsQuestionier.Models;

namespace ZenithPensionsQuestionier.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<AnswersTable> Answers { get; set; }

        public DbSet<QuestionAnswerCount> QuestionAnswerCount { get; set; }
    }
}
