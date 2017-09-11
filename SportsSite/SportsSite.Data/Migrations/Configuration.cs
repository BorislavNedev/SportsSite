namespace SportsSite.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<SportsSiteDbContext>
    {
        private UserManager<User> userManager;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SportsSiteDbContext context)
        {
            this.userManager = new UserManager<User>(new UserStore<User>(context));
            this.SeedRoles(context);
            this.SeedAdmin(context);
            this.SeedArticlesAndCategories(context);
        }

        private void SeedRoles(SportsSiteDbContext context)
        {
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole("Admin"));
            context.SaveChanges();
        }

        private void SeedAdmin(SportsSiteDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var adminUser = new User
            {
                Email = "admin@mysite.com",
                UserName = "Administrator"
            };

            this.userManager.Create(adminUser, "admin123456");

            this.userManager.AddToRole(adminUser.Id, "Admin");
        }

        private void SeedArticlesAndCategories(SportsSiteDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            Category football = new Category
            {
                Name = "Football"
            };
            context.Categories.Add(football);

            Category basketball = new Category
            {
                Name = "Basketball"
            };
            context.Categories.Add(basketball);

            Category volleyball = new Category
            {
                Name = "Volleyball"
            };
            context.Categories.Add(volleyball);

            Category tennis = new Category
            {
                Name = "Tennis"
            };
            context.Categories.Add(tennis);

            Category athletics = new Category
            {
                Name = "Athletics"
            };
            context.Categories.Add(athletics);

            Category fightSports = new Category
            {
                Name = "Fight Sports"
            };
            context.Categories.Add(fightSports);

            Category winterSports = new Category
            {
                Name = "Winter Sports"
            };
            context.Categories.Add(winterSports);

            Category motorSports = new Category
            {
                Name = "Motor Sports"
            };
            context.Categories.Add(motorSports);

            Category other = new Category
            {
                Name = "Other"
            };
            context.Categories.Add(other);

            Article psgWonHisMetzTournamentConvincingly = new Article
            {
                Category = football,
                Title = "��� ������� ���������� ����������� �� �� ����",
                Date = DateTime.Now.AddHours(-1),
                Content = "���� ��� ������ ���������� ������������� �� ����� � ���� 1. ��������� �������� �� ���� ����� ������� �������� �� �� ���� � 5:1. \n ������� ����� �� ������� ������� ������ ���������� ������ �����, ���������� ���� ���������. ��� ������ ������� ������, � �� ������ �� ��������� ������ � ����� �����. ���� �������� �� �������� ���� ������� �� ��������, ��� ������ �� ���������� ��������� � 31 - ��� ������.������ ����������� ����������� ������ ����� ������ � ������ ������� ������ ��� ��������� �� ����������.���������� ������ ������������ � ��������� ��������� ���� ����� ��� �� �������� �� ����������.����������� �����,���� ���� ������ �� - �����,���� ���������� ��������.������ ������ ���� �� ���� ���� ���� ����� ��������� �� ���,���� ����� ����� ��� ��������� ����� �� ������� ������.������� ����� �� ������� ��������� ����� � ����� ������� ��������� �� '���� ���� ���������'.������� ���� ������ �� ������ � ������ �����.������ ������ ������� ������ ��� ������� ����� ��� ���� � � ������ �� ��������� �� ����� �� - ���� ������.���� ��� ����� ����������� ���������� � �� ���� �� ����� ����������� �����.������� �� '���� ���� ���������' ������ �� �� ������ � �� ���� �����,��� � 56 - ��� ������,��� �������� 1:1, �������� ����� �� �� ������� ��������� ����� ���-����� �� ������� �� ����������.������������ ���������� ������� � �� 1:4. ����� � �� ������ ���������� � ���� �� �����, ������� ������ �� �� ������� �� ��������� ������ ����� ��������� � ����. �������� 1:5 ��� ������ ����� �����, ����� � ������� �� ������ �� ������ ���� ������ ����� �� ���� �������������.",
                ImageUrl = "https://webnews.bg/uploads/images/24/1524/311524/768x432.jpg?_=1504903201"
            };
            context.Articles.Add(psgWonHisMetzTournamentConvincingly);

            Article inEnglandTheyCompareMorataToTorres = new Article
            {
                Category = football,
                Title = "� ������ ��������� ������ � �����",
                Date = DateTime.Now.AddHours(-2),
                Content = "� ������ ���� ��������� �� ��������� ������ ������ � ���� ������������ ���������, ����� �� '�������� �����'. ����� ������ �� �������� �����.��������� � �������, �� ����� ����������� ���������� ��������� ��������� ��� ������� �� ������ �����. ����������, �� ����� ������ ����� � 2:1.���� ���� �� �������,��������� �� ������ �� ������ �� ������ � ������� ������� � ���,� ������ �� ���� ����� � �� ����� �������� ���� ���,������ �� ����� �� '������'.",
                ImageUrl = "https://webnews.bg/uploads/images/01/1601/311601/768x432.jpg?_=1504974575"
            };
            context.Articles.Add(inEnglandTheyCompareMorataToTorres);

            Article tottenhamBeatEvertonThreeZero = new Article
            {
                Category = football,
                Title = "������ ������ ������� � 3:0",
                Date = DateTime.Now.AddHours(-3),
                Content = "������� �� ������ ������ ����� ������ �� ������� � ��� �� ��������� ���� �� ������� ����. � ����� �� ������� �� �������� ���� ����, ����� �������� ��� ����, � �������� ������� ������ ��� ���� ��������� �� ������������ ������ � 3:0.���� ����� �������� �� ������ � 28-��� ������, � ����� ����� ���� �� ������� ��������� ������� �����. � 46-��� ������ ���� ����� ����� �� ����� � ������ ����� ��� ����� �� ���� ���.",
                ImageUrl = "https://webnews.bg/uploads/images/00/1600/311600/768x432.jpg?_=1504973432"
            };
            context.Articles.Add(tottenhamBeatEvertonThreeZero);

            Article leoMessiWithtwentysevenHatricsInPrimeraDivision = new Article
            {
                Category = football,
                Title = "��� ���� � 27 �������� � ������� ��������",
                Date = DateTime.Now.AddHours(-4),
                Content = "������ ���� �� ���������� ��� �� ��������� ������� �� ���������� ���������� � ������� �������� ���� �������� ���������� ����� � ��������.����� � ��������,������� ������ ��� ��������� �� �������� �������� ��� ����������� ������ � 5:0.���� ������������� ��������� ���� ��� 27 �������� �� �������� �� � �� ���� � �������� ���� � 5 �� ��������� �������, ����� � ����� ��� ������� �������� �� ���� ���������.��� ������� � ��������� �� ������� (������)����� ���� � 22, ������� ��� � ����������� ���� ���������� �� ����(������) ������� �� �������.",
                ImageUrl = "https://webnews.bg/uploads/images/13/8813/308813/768x432.jpg?_=1503386197"
            };
            context.Articles.Add(leoMessiWithtwentysevenHatricsInPrimeraDivision);

            Article rafaelNadalandKevinAndersonWillBeArguingForThetitleInNewYork = new Article
            {
                Category = tennis,
                Title = "������ ����� � ����� �������� �� ������ �� ������� � �� ����",
                Date = DateTime.Now.AddHours(-4),
                Content = "������ ����� ������ ������������ ��� ����� ���� ������ ��� ����� � �� ������� �� ������ �� US Open. �������� ����� ������ �� ������ � 3:1 ( 4-6 6-0 6-3 6-2).��� ����� ������ ����� � ����� �� 3 - 2 � ������ ���,���� ����� ������ � 1:0.��� ������ ����� ����� ����������� ������ ���-�����, �� ����� � �������� � �� ���� ������� ������� �� �����������.�� ���� �� ������� ���������� �������� �� ������ ������� ������� �� ���� �������� � � ������ �� ����� �� ������� � �� ����.����� �������� ��� �� � ����� ��������.��������������� ������� ���������� ����� ����� �������-����� � 3:1(4 - 6 7 - 5 6 - 3 6 - 4).��������� ���� �� ����� ������ ���, �� ���������� ��� ���� �� ��������, ����� �� ����� �� ������ �� ����� �� ������ �� ������� ����.",
                ImageUrl = "https://webnews.bg/uploads/images/98/0498/310498/768x432.jpg?_=1504254700"
            };
            context.Articles.Add(rafaelNadalandKevinAndersonWillBeArguingForThetitleInNewYork);

            Article chinaWithThirdvictoryAtTheWorldVolleyballTournamentInJapan = new Article
            {
                Category = volleyball,
                Title = "����� � ����� ������ �� ��������� ���������� ������ � ������",
                Date = DateTime.Now.AddHours(-5),
                Content = "����� ������ ������������ ��������� ����� ���� ������������ �� ������� �� ������ �� �������� �������� �� �������� ��� ������.������������ ��������� �������� ���� ����� � 3:0 (25-14, 25-4, 25-12). ��������� �� ������ ���� �� ������� �� ������ �� ���� �������� �� ������ �� ����, ����� ������� ���� � 9 �����. ��������� ���� 3 ������ � 8 �����. ������ �� ������������ �� ��� ����� � ����� ���� � � ������ � ������.���������� ��������� �� ��� �� �������� ��� ����� � 3:2(23 - 25, 25 - 21, 19 - 25, 25 - 21, 15 - 9) � �������� ������� �� ������� ����� � ���� 2 ������ � 5 �����.�� ���� ���� ������ �� ����� � �� ������� �� ���� ���� ����� ������ �� ������������ ��.��������� ��������� ���������� ������ 27 �����, � ������� ������������ ������ �������� 25 �����.�� ��������� �� �������� �������� ��� ����� ������ �� ������.���������� �� ������ ���� �������� �������. �� �� �������� ��� ����������� �� ���������� ���� ��� �������� � 3:2(25 - 18, 25 - 27, 25 - 15, 16 - 25, 15 - 6).",
                ImageUrl = "https://webnews.bg/uploads/images/75/1475/311475/768x432.jpg?_=1504878908"
            };
            context.Articles.Add(chinaWithThirdvictoryAtTheWorldVolleyballTournamentInJapan);

            Article spainBeatHungaryOnEuroBasket = new Article
            {
                Category = basketball,
                Title = "������� ����� ������� �� ����������",
                Date = DateTime.Now.AddHours(-5),
                Content = "������� ���������� ��� ������ �� ���������� 2017. ��������������� �� ������ �������� ��������� � ����� �� ��� �� ����� C, ���� ���� ������� ������� � 87:74.\n��������� ��������� �� ������ �������� �� ������� ������ � � ����  �� ��������� ������ ��. \n ������� ����� �� �� ������� �� ������� � �������� �� ���������� �������,������� � ������������� ���������� �� ��� �����.�������� �� ������� ����� � ���������,���� ���� ������ ���������� �� ������������� �� ���������� ����������.����� �������� 20 ����� � ���� ���� � ���� ��� 1111,���� ������� �� ������� ������� ������ ������� �������� ���� ������,����� � � 1104. \n ��� ����� �� ��� - ���������� �� ������ ��� ������ 20 �����,���� ��� ������ � 8 �����.�� 15 ����� �������� ������ �������� � ������� ����������,� � 10 �� ������ ���� �����.",
                ImageUrl = "https://webnews.bg/uploads/images/84/1384/311384/768x432.jpg?_=1504803667"
            };
            context.Articles.Add(spainBeatHungaryOnEuroBasket);

            Article formulaOneHasasNewLeaderVettelIsTheTopOfMonza = new Article
            {
                Category = motorSports ,
                Title = "������� 1 ��� ��� �����, ��������� ����� ����� ����� �� �����",
                Date = DateTime.Now.AddHours(-6),
                Content = "���� �������� ������� ������������ �� �������� ������� �� ������ ��� ������� 1. \n ���������� ������� �������� ���������� �� ���������� ����� �� ������������ ����� '�����',���� � ������� �� ����� �� ������ �� ����� ��� ���������� ���������,����������� �� ���� ���������� ����� ��������� �����. \n ����� � ������ ������� ������� �����, � ����� ��� ��� ������� ���������� ���� �������� �������, �������� �� ��� ����� ��� �� �������. \n ��������� ��������� � ���� 4 ������� ����������� �� ���� ������ ���������� ���� ������ �������.���� ������� � ���-����������� ��������������� ����������� ���������� �� ���������� �� ������� �������� �� �� ����� ���� �� ������.",
                ImageUrl = "https://webnews.bg/uploads/images/45/0745/310745/768x432.jpg?_=1504446184"
            };
            context.Articles.Add(formulaOneHasasNewLeaderVettelIsTheTopOfMonza);

            Article kubratPulevSendsAnAchievementToMohamedAliInHistory = new Article
            {
                Category = fightSports ,
                Title = "������ ����� ����� ���������� �� ������� ��� � ���������",
                Date = DateTime.Now.AddMinutes(-30),
                Content = "������ ������ � ������ ����� ����� �� ������� ������������� ������ � �������� ������� ��, ���������� ����������� ��������.������ �� �� ������ �� 28 �������� � ������ �� ���������� ����� ��� 80 ������ �������.\n ��� '������������ �������' ������������ ������� ���������� ��, ������������ �� 63 315 �������, ����� �� ����������� �� ����������� ���-������ ����� ���� ������ � ������� ��� �� 15 ��������� 1978 ������, ���� �� �� ������ �� ����� 3 � ���������. \n �� ����� �� ������� � ��������� ����� ������ � ������, �� ����� ���� ��������� ��� 80 000 ��������.��-����� ���� � ����������������� �� ������ � �������. �������� �� ����� ������� �� ������ �������� ��� ������� (12 ���������).",
                ImageUrl = "https://webnews.bg/uploads/images/38/1038/291038/768x432.jpg?_=1493414306"
            };
            context.Articles.Add(kubratPulevSendsAnAchievementToMohamedAliInHistory);

            Article theresaJohahugWithIncreasedPunishmentMissesTheOlympics = new Article
            {
                Category = winterSports ,
                Title = "������ ������ � ��������� ���������, �������� �����������",
                Date = DateTime.Now.AddDays(-1),
                Content = "������������� �������� ��������� � ���-�������� ������ ������ ���� �� ������� �� ������� ��������� � �������. ���� ����� ���� ���� ��������� �� ������������� ���������� ��� � ������, � ����� ����������� �� ���������� �� �������� �� ��������� ���� ��������� �� 18 ������. \n ���� 2016-� ������ ���� ������� �� ���������� �� ������������ ���������. ������ �� �� ������� � ���������� �� ������������� ����. �� ������ �� ���������� ������ ������������� ���������� �� ������ ��������� ���� 13 ������ � �� ���� �� ������ ����� ������� 2018. �������������� ��� ��������� ���������� ���� ���� � ������ � ������ �������� �� ������� �� ������� �� �������������� ����� �� ����������.\n ���� ������ �� ���� �� �� ��������� ������ ���� 18-�� ����� 2018-�, ����� ��������, �� �� �������� ����� ������� ����� �����. \n ����� ��� 1 ������, 1 �������� � 1 ������� ����� �� ���������� ����. �� ���������� �� ��������� ������ ��� ��������� 7 ������, 1 �������� � 3 �������� ������. �� ���� �������� �� ������� '������� �� �������'. ����� �� �������� '�������' � ���� ���������� � ������ ��� ������.",
                ImageUrl = "https://webnews.bg/uploads/images/40/2140/282140/768x432.jpg?_=1488894179"
            };
            context.Articles.Add(theresaJohahugWithIncreasedPunishmentMissesTheOlympics);

            Article usainBoltWithTornMuscleWillRecoverForlongTime = new Article
            {
                Category = athletics ,
                Title = "����� ���� � �������� ������, �� �� ������������ �����",
                Date = DateTime.Now.AddHours(-7),
                Content = "������������ ��������� �� ���������� ��������� ����� ���� �� ������ �� �� ������������ ���-����� ��� ������.������������ ���� ���������� � �� ����� ����������.��������� ������ ������ ����� ������ � ��������� �� ����� � �������� ��������� �������� �� �������. \n ���� �������� ���������� �� ������� �����. ��� ������ ������������� - ���� �, ������ � ���������� ����� ������������ ���������� �������. ��������� �� ������� �� ����� �� ���������� ���������� ���� �� ����� �� �������� ������ ������������ ��. ��������� �� �� ����������. ���� �� ������� � �� �� �������,��������� ����.",
                ImageUrl = "https://webnews.bg/uploads/images/43/6943/306943/768x432.jpg?_=1501977691"
            };
            context.Articles.Add(usainBoltWithTornMuscleWillRecoverForlongTime);
        }

    }
}
