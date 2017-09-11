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
                Title = "ПСЖ спечели убедително гостуването си на Метц",
                Date = DateTime.Now.AddHours(-1),
                Content = "Пари Сен Жермен продължава наказателната си акция в Лига 1. Звездната селекция на Унай Емери спечели визитата си на Метц с 5:1. \n Отличен дебют за гостите направи новата придобивка Килиан Мбапе, реализирал едно попадение. Две добави Единсон Кавани, а по веднъж се разписаха Неймар и Лукас Моура. След поредица от пропуски пред вратата на Кавашима, ПСЖ стигна до очакваното попадение в 31 - ата минута.Неймар демонстрира великолепен поглед върху играта и изведе Единсон Кавани зад отбраната на домакините.Уругваецът запази хладнокръвие и елегантно реализира своя шести гол от началото на кампанията.Изненадващо обаче,само шест минути по - късно,Метц възстанови паритета.Матийо Досеви като на шега мина през трима бранители на ПСЖ,след което копна към далечната греда за Еманюел Ривиер.Бившият играч на Нюкасъл изпревари Рабио и глава зарадва публиката на 'Стад Сент Симфориен'.Втората част можеше да донесе и пълния обрат.Алфонс Ареола подходи нелепо към върната топка към него и я подари на наказалия го малко по - рано Ривиер.Този път обаче нападателят разочарова и не успя да уцели опразнената врата.Двубоят на 'Стад Сент Симфориен' можеше да се развие и по друг начин,ако в 56 - ата минута,при резултат 1:1, главният съдия не бе изгонил пресилено Беноа Асу-Екото от състава на домакините.Впоследствие резултатът набъбна и до 1:4. Макар и да получи асистенция с ръка от Мбапе, Единсон Кавани не се посвени да реализира своето второ попадение в мача. Крайното 1:5 пък оформи Лукас Моура, който в малкото си минути на терена също записа името си сред голмайсторите.",
                ImageUrl = "https://webnews.bg/uploads/images/24/1524/311524/768x432.jpg?_=1504903201"
            };
            context.Articles.Add(psgWonHisMetzTournamentConvincingly);

            Article inEnglandTheyCompareMorataToTorres = new Article
            {
                Category = football,
                Title = "В Англия сравняват Мората с Торес",
                Date = DateTime.Now.AddHours(-2),
                Content = "В Англия вече започнаха да сравняват Алваро Мората с друг емблематичен футболист, играл на 'Стамфорд Бридж'. Става въпрос за Фернандо Торес.Причината е начинът, по който нападателят отпразнува победното попадение във вратата на Лестър вчера. Припомняме, че Челси записа успех с 2:1.След като се разписа,испанецът се хлъзна по терена на колене и имитира стрелба с лък,а именно по този начин и Ел Ниньо ликуваше след гол,докато бе играч на 'сините'.",
                ImageUrl = "https://webnews.bg/uploads/images/01/1601/311601/768x432.jpg?_=1504974575"
            };
            context.Articles.Add(inEnglandTheyCompareMorataToTorres);

            Article tottenhamBeatEvertonThreeZero = new Article
            {
                Category = football,
                Title = "Тотнъм победи Евертън с 3:0",
                Date = DateTime.Now.AddHours(-3),
                Content = "Отборът на Тотнъм нанесе тежка загуба на Евертън в мач от четвъртия кръг на Висшата лига. В герой на срещата се превърна Хари Кейн, който отбеляза два гола, а Кристиан Ериксен добави още едно попадение за класическата победа с 3:0.Кейн откри головата си сметка в 28-ата минута, а малко преди края на първото полувреме Ериксен удвой. В 46-ата отново Кейн сложи точка на спора и донесе ценни три точки на своя тим.",
                ImageUrl = "https://webnews.bg/uploads/images/00/1600/311600/768x432.jpg?_=1504973432"
            };
            context.Articles.Add(tottenhamBeatEvertonThreeZero);

            Article leoMessiWithtwentysevenHatricsInPrimeraDivision = new Article
            {
                Category = football,
                Title = "Лео Меси с 27 хеттрика в Примера Дивисион",
                Date = DateTime.Now.AddHours(-4),
                Content = "Лионел Меси се приближава още до Кристиано Роналдо по отбелязани хеттрикове в Примера дивисион след снощното каталунско дерби с Еспаньол.Както е известно,Бълхата наниза три попадения на градския съперник при разгромната победа с 5:0.Така аржентинският магьосник вече има 27 хеттрика на сметката си в Ла Лига и изостава вече с 5 от Кристиано Роналдо, който е лидер във вечната класация по този показател.Зад двамата е легендата на Атлетик (Билбао)Телмо Сара с 22, колкото има и знаменитият бивш голмайстор на Реал(Мадрид) Алфредо ди Стефано.",
                ImageUrl = "https://webnews.bg/uploads/images/13/8813/308813/768x432.jpg?_=1503386197"
            };
            context.Articles.Add(leoMessiWithtwentysevenHatricsInPrimeraDivision);

            Article rafaelNadalandKevinAndersonWillBeArguingForThetitleInNewYork = new Article
            {
                Category = tennis,
                Title = "Рафаел Надал и Кевин Андерсън ще спорят за титлата в Ню Йорк",
                Date = DateTime.Now.AddHours(-4),
                Content = "Рафаел Надал изигра изключителен мач срещу Хуан Мартин дел Потро и се класира за финала на US Open. Матадора сломи Кулата от Тандил с 3:1 ( 4-6 6-0 6-3 6-2).Дел Потро тръгна добре и проби за 3 - 2 в първия сет,след което поведе с 1:0.Във втория обаче Надал демонстрира всичко най-добро, на което е способен и не даде никакви шансове на аржентинеца.До края на срещата испанският тенисист не остави никакви шансове на своя съперник и в неделя ще спори за титлата в Ню Йорк.Негов съперник там ще е Кевин Андерсън.Южноафриканецът спечели полуфинала срещу Пабло Кареньо-Буста с 3:1(4 - 6 7 - 5 6 - 3 6 - 4).Испанецът успя да вземе първия сет, но следващите три бяха за Андерсън, който ще играе на първия си финал на турнир от Големия шлем.",
                ImageUrl = "https://webnews.bg/uploads/images/98/0498/310498/768x432.jpg?_=1504254700"
            };
            context.Articles.Add(rafaelNadalandKevinAndersonWillBeArguingForThetitleInNewYork);

            Article chinaWithThirdvictoryAtTheWorldVolleyballTournamentInJapan = new Article
            {
                Category = volleyball,
                Title = "Китай с трета победа на световния волейболен турнир в Япония",
                Date = DateTime.Now.AddHours(-5),
                Content = "Китай остана единственият непобеден отбор след изиграването на срещите от Купата на големите шампиони по волейбол при дамите.Олимпийските шампионки победиха Южна Корея с 3:0 (25-14, 25-4, 25-12). Треньорът Ан Жиажие дори си позволи да извади от игра голямата си звезда Жу Тинг, която завърши само с 9 точки. Китайките имат 3 победи и 8 точки. Докрая на надпреварата те има срещи с Русия утре и с Япония в неделя.Световните шампионки от САЩ се наложиха над Русия с 3:2(23 - 25, 25 - 21, 19 - 25, 25 - 21, 15 - 9) и запазиха шансове за първото място и имат 2 победи и 5 точки.Те вече имат загуба от Китай и се надяват на поне една чиста загуба на съперничките си.Рускинята Екатерина Косианенко записа 27 точки, а нейната съотборничка Татяна Кошелева 25 точки.За съжаление на Владимир Козюткин две птици пролет не правят.Домакините от Япония също запазиха шансове. Те се наложиха над шампионките от Световното Гран При Бразилия с 3:2(25 - 18, 25 - 27, 25 - 15, 16 - 25, 15 - 6).",
                ImageUrl = "https://webnews.bg/uploads/images/75/1475/311475/768x432.jpg?_=1504878908"
            };
            context.Articles.Add(chinaWithThirdvictoryAtTheWorldVolleyballTournamentInJapan);

            Article spainBeatHungaryOnEuroBasket = new Article
            {
                Category = basketball,
                Title = "Испания разби Унгария на Евробаскет",
                Date = DateTime.Now.AddHours(-5),
                Content = "Испания продължава без грешка на Евробаскет 2017. Баскетболистите на Серджо Скариоло спечелиха и петия си мач от група C, след като разбиха Унгария с 87:74.\nИспанците започнаха да трупат преднина от първата сирена и в края  не изпуснаха аванса си. \n Двубоят обаче ще се запомни не толкова с победата на действащия шампион,колкото с феноменалното постижение на Пау Гасол.Звездата на Испания влезе в историята,след като оглави класацията на реализаторите на Европейски първенства.Гасол отбеляза 20 точки в мача днес и вече има 1111,като измести от първата позиция бившия френски национал Тони Паркър,който е с 1104. \n Пау Гасол бе най - резултатен за успеха със своите 20 точки,като той добави и 8 борби.По 15 точки добавиха Серхио Родригес и Гилермо Ернангомес,а с 10 се отчете Марк Гасол.",
                ImageUrl = "https://webnews.bg/uploads/images/84/1384/311384/768x432.jpg?_=1504803667"
            };
            context.Articles.Add(spainBeatHungaryOnEuroBasket);

            Article formulaOneHasasNewLeaderVettelIsTheTopOfMonza = new Article
            {
                Category = motorSports ,
                Title = "Формула 1 има нов лидер, Себастиан Фетел сдаде върха на Монца",
                Date = DateTime.Now.AddHours(-6),
                Content = "Люис Хамилтън спечели състезанието за Голямата награда на Италия във Формула 1. \n Британецът проведе днешната надпревара по безупречен начин на легендарната писта 'Монца',като с първото си място се изкачи на върха във временното класиране,измествайки от него досегашния лидер Себастиан Фетел. \n Втори в Италия завърши Валтери Ботас, а Фетел все пак отсрами Скудерията пред местната публика, качвайки се под номер три на подиума. \n Себастиан изпревари с цели 4 секунди преследвача си през цялото състезание днес Даниел Рикардо.Така битката в най-популярната високоскоростна автомобилна надпревара ще продължава да вълнува феновете си до самия край на сезона.",
                ImageUrl = "https://webnews.bg/uploads/images/45/0745/310745/768x432.jpg?_=1504446184"
            };
            context.Articles.Add(formulaOneHasasNewLeaderVettelIsTheTopOfMonza);

            Article kubratPulevSendsAnAchievementToMohamedAliInHistory = new Article
            {
                Category = fightSports ,
                Title = "Кубрат Пулев праща постижение на Мохамед Али в историята",
                Date = DateTime.Now.AddMinutes(-30),
                Content = "Антъни Джошуа и Кубрат Пулев могат да съборят забележителен рекорд в сблъсъка помежду си, спекулират британските таблоиди.Очаква се на двубоя на 28 октомври в Кардиф да присъстват малко над 80 хиляди зрители.\n Ако 'Принсипалити стейдиъ' действително изпълни капацитета си, постижението от 63 315 зрители, които са присъствали на легендарния мач-реванш между Леон Спинкс и Мохамед Али на 15 септември 1978 година, може да се свлече до номер 3 в историята. \n На върха за момента е сблъсъкът между Джошуа и Кличко, за който бяха продадени над 80 000 пропуска.По-късно днес е пресконференцията на Джошуа и Кобрата. Билетите ще бъдат пуснати за онлайн продажба във вторник (12 септември).",
                ImageUrl = "https://webnews.bg/uploads/images/38/1038/291038/768x432.jpg?_=1493414306"
            };
            context.Articles.Add(kubratPulevSendsAnAchievementToMohamedAliInHistory);

            Article theresaJohahugWithIncreasedPunishmentMissesTheOlympics = new Article
            {
                Category = winterSports ,
                Title = "Тереза Йохауг с увеличено наказание, пропуска Олимпиадата",
                Date = DateTime.Now.AddDays(-1),
                Content = "Седемкратната световна шампионка в ски-бягането Тереза Йохауг няма да участва на зимната Олимпиада в Пьончан. Това стана факт след решението на Международния арбитражен съд в Лозана, с което наказанието на норвежката за употреба на клостебол беше увеличено на 18 месеца. \n През 2016-а Йохауг беше уличена за употребата на непозволения стимулант. Тогава тя се оправда с употребата на слънцезащитен крем. На базата на смекчаващи вината обстоятелства наложенато на Йохауг наказание беше 13 месеца и то щеше да изтече преди Пьончан 2018. Международната ски федерация протестира пред съда в Лозана и получи корекция за периода на спиране на състезателните права на норвежката.\n Така Йохауг ще може да се състезава отново след 18-ти април 2018-а, което означава, че ще пропусне целия следващ зимен сезон. \n Терез има 1 златен, 1 сребърен и 1 бронзов медал от Олимпийски игри. От шампионати на планетата Йохауг има спечелени 7 златни, 1 сребърен и 3 бронзови медала. Тя беше кръстена от медиите 'Зайчето на Дюрасел'. Както се досещате 'Зайчето' е било захранвано с особен вид гориво.",
                ImageUrl = "https://webnews.bg/uploads/images/40/2140/282140/768x432.jpg?_=1488894179"
            };
            context.Articles.Add(theresaJohahugWithIncreasedPunishmentMissesTheOlympics);

            Article usainBoltWithTornMuscleWillRecoverForlongTime = new Article
            {
                Category = athletics ,
                Title = "Юсейн Болт с разкъсан мускул, ще се възстановява дълго",
                Date = DateTime.Now.AddHours(-7),
                Content = "Прекратилият кариерата си легендарен лекоатлет Юсейн Болт ще трябва да се възстановява най-малко три месеца.Информацията беше потвърдена и от самия състезател.Ямайският гигант получи тежка травма в последния си старт и приключи неуспешно богатата си кариера. \n Имам мускулно разкъсване на задното бедро. Три месеца рехабилитация - това е, написа в социалната мрежа осемкратният олимпийски шампион. Огромното ми желание по време на Световното първенство беше да бягам за последно заради почитателите ми. Благодаря им за подкрепата. Сега ще почивам и ще се лекувам,коментира Болт.",
                ImageUrl = "https://webnews.bg/uploads/images/43/6943/306943/768x432.jpg?_=1501977691"
            };
            context.Articles.Add(usainBoltWithTornMuscleWillRecoverForlongTime);
        }

    }
}
