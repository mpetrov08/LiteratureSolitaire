using LiteratureSolitaire.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Seed
{
    internal class SeedData
    {
        public Author DimitarTalev { get; set; }

        public Author AlekoKonstantinov { get; set; }

        public Author StanislavStratiev { get; set; }

        public Author IvanVazov { get; set; }

        public Author NikolaVaptsarov { get; set; }

        public Author YordanRadichkov { get; set; }

        public Author HristoBotev { get; set; }

        public Author ElinPelin { get; set; }

        public Author HristoSmirnenski { get; set; }

        public Author EmilianStanev { get; set; }

        public Author PeyoYavorov { get; set; }

        public Author PenchoSlaveykov { get; set; }

        public Author DimichoDebelyanov { get; set; }

        public Author HristoFotev { get; set; }

        public Author PetyaDubarova { get; set; }

        public Author AtanasDalchev { get; set; }

        public Author YordanYovkov { get; set; }

        public Author ViktorPaskov { get; set; }

        public Author ElisavetaBagryana { get; set; }

        public Author BorisHristov { get; set; }

        public Genre Novel { get; set; }

        public Genre Feuilleton { get; set; }

        public Genre SatiricalComedy { get; set; }

        public Genre Ode { get; set; }

        public Genre Poem { get; set; }

        public Genre ShortStory { get; set; }

        public Genre Satire { get; set; }

        public Genre ShortNovel { get; set; }

        public Genre PantheisticPoem { get; set; }

        public Genre EpicPoem { get; set; }

        public Genre LyricalMiniature { get; set; }

        public Genre Elegy { get; set; }

        public LiteraryDirection Realism { get; set; }

        public LiteraryDirection Romanticism { get; set; }

        public LiteraryDirection MagicalRealism { get; set; }

        public LiteraryDirection SocialRealism { get; set; }

        public LiteraryDirection Individualism { get; set; }

        public LiteraryDirection Symbolism { get; set; }

        public LiteraryDirection Diabolism { get; set; }

        public LiteraryDirection Existentialism { get; set; }

        public LiteraryDirection Modernism { get; set; }

        public Work TheIronCandlestick { get; set; }

        public Work BayGanyoTheJournalist { get; set; }

        public Work BalkanSyndrome { get; set; }

        public Work SaintPaisius { get; set; }

        public Work History { get; set; }

        public Work NoahsArk { get; set; }

        public Work TheStruggle { get; set; }

        public Work Andreshko { get; set; }

        public Work ATaleOfTheStairway { get; set; }

        public Work ToMyFirstLove { get; set; }

        public Work TheNewCemetryNearSlivnitsa { get; set; }

        public Work ThePeachThief { get; set; }

        public Work AtRilaMonastery { get; set; }

        public Work Hailstorm { get; set; }

        public Work TheLakeSleeps { get; set; }

        public Work IWantToRememberYouJustLikeThis { get; set; }

        public Work HowBeatifulYouAre { get; set; }

        public Work Deadication { get; set; }

        public Work SapsovaMound { get; set; }

        public Work Prayer { get; set; }

        public Work Faith { get; set; }

        public Work TheWindMill { get; set; }

        public Work TheSongOfTheWheels { get; set; }

        public Work BalladForGeorgHenig { get; set; }

        public Work TwoSouls { get; set; }

        public Work Descendant { get; set; }

        public Work HonestCross { get; set; }

        public SeedData()
        {
            SeedAuthors();
            SeedGenres();
            SeedLiteraryDirections();
            SeedWorks();
        }

        private void SeedAuthors()
        {
            DimitarTalev = new Author
            {
                Id = 1,
                Name = "Димитър Талев"
            };

            AlekoKonstantinov = new Author
            {
                Id = 2,
                Name = "Алеко Константинов"
            };

            StanislavStratiev = new Author
            {
                Id = 3,
                Name = "Станислав Стратиев"
            };

            IvanVazov = new Author
            {
                Id = 4,
                Name = "Иван Вазов"
            };

            NikolaVaptsarov = new Author
            {
                Id = 5,
                Name = "Никола Вапцаров"
            };

            YordanRadichkov = new Author
            {
                Id = 6,
                Name = "Йордан Радичков"
            };

            HristoBotev = new Author
            {
                Id = 7,
                Name = "Христо Ботев"
            };

            ElinPelin = new Author
            {
                Id = 8,
                Name = "Елин Пелин"
            };

            HristoSmirnenski = new Author
            {
                Id = 9,
                Name = "Христо Смирненски"
            };

            EmilianStanev = new Author
            {
                Id = 10,
                Name = "Емилиян Станев"
            };

            PeyoYavorov = new Author
            {
                Id = 11,
                Name = "Пейо Яворов"
            };

            PenchoSlaveykov = new Author
            {
                Id = 12,
                Name = "Пенчо Славейков"
            };

            DimichoDebelyanov = new Author
            {
                Id = 13,
                Name = "Димчо Дебелянов"
            };

            HristoFotev = new Author
            {
                Id = 14,
                Name = "Христо Фотев"
            };

            PetyaDubarova = new Author
            {
                Id = 15,
                Name = "Петя Дубарова"
            };

            AtanasDalchev = new Author
            {
                Id = 16,
                Name = "Атанас Далчев"
            };

            YordanYovkov = new Author
            {
                Id = 17,
                Name = "Йордан Йовков"
            };

            ViktorPaskov = new Author
            {
                Id = 18,
                Name = "Виктор Пасков"
            };

            ElisavetaBagryana = new Author
            {
                Id = 19,
                Name = "Елисавета Багряна"
            };

            BorisHristov = new Author
            {
                Id = 20,
                Name = "Борис Христов"
            };
        }

        private void SeedGenres()
        {
            Novel = new Genre 
            { 
                Id = 1,
                Name = "Роман" 
            };

            Feuilleton = new Genre
            {
                Id = 2,
                Name = "Фейлетон"
            };

            SatiricalComedy = new Genre
            {
                Id = 3,
                Name = "Сатирична комедия на абсурда"
            };

            Ode = new Genre
            {
                Id = 4,
                Name = "Ода"
            };

            Poem = new Genre
            {
                Id = 5,
                Name = "Стихотворение"
            };

            ShortStory = new Genre
            {
                Id = 6,
                Name = "Разказ"
            };

            Satire = new Genre
            {
                Id = 7,
                Name = "Сатира, Алегория"
            };

            ShortNovel = new Genre
            {
                Id = 8,
                Name = "Повест"
            };

            PantheisticPoem = new Genre
            {
                Id = 9,
                Name = "Пантеистичнo стихотворение"
            };

            EpicPoem = new Genre
            {
                Id = 10,
                Name = "Поема"
            };

            LyricalMiniature = new Genre
            {
                Id = 11,
                Name = "Лирическа миниатюра"
            };

            Elegy = new Genre
            {
                Id = 12,
                Name = "Елегия"
            };
        }

        private void SeedLiteraryDirections()
        {
            Realism = new LiteraryDirection
            {
                Id = 1,
                Name = "Реализъм"
            };

            Romanticism = new LiteraryDirection
            {
                Id = 2,
                Name = "Романтизъм"
            };

            MagicalRealism = new LiteraryDirection
            {
                Id = 3,
                Name = "Магически реализъм"
            };

            SocialRealism = new LiteraryDirection
            {
                Id = 4,
                Name = "Социален реализъм"
            };

            Individualism = new LiteraryDirection
            {
                Id = 5,
                Name = "Индивидуализъм"
            };

            Symbolism = new LiteraryDirection
            {
                Id = 6,
                Name = "Символизъм"
            };

            Diabolism = new LiteraryDirection
            {
                Id = 7,
                Name = "Диаболизъм"
            };

            Existentialism = new LiteraryDirection
            {
                Id = 8,
                Name = "Екзистенциализъм"
            };

            Modernism = new LiteraryDirection
            {
                Id = 9,
                Name = "Модернизъм"
            };
        }

        private void SeedWorks()
        {
            TheIronCandlestick = new Work
            {
                Id = 1,
                Title = "\"Железният светилник\"",
                AuthorId = DimitarTalev.Id,
                Characters = "Стоян Глаушев, Султана, Лазар, Катерина, Рафе Клинче, " +
                "Климент Бенков, Божана, Стойка Нунева, Аврам Немтур",
                GenreId = Novel.Id,
                LiteraryDirectionId = Realism.Id
            };

            BayGanyoTheJournalist = new Work
            {
                Id = 2,
                Title = "\"Бай Ганьо журналист\"",
                AuthorId = AlekoKonstantinov.Id,
                Characters = "Бай Ганьо, Гочоолу, Дочоолу, Данко Харсъзина, " +
                "Гуньо Адвокатина/Гуньо Келеперчиков",
                GenreId = Feuilleton.Id,
                LiteraryDirectionId = Realism.Id
            };

            BalkanSyndrome = new Work
            {
                Id = 3,
                Title = "\"Балкански синдром\"",
                AuthorId = StanislavStratiev.Id,
                Characters = "Бяла Врана, Жена с проблем, Жена символ, Директор на театър, " +
                "бай Цончо, Йовчо, Цончето, Печо, баба Кера, Извънземното, Георги",
                GenreId = SatiricalComedy.Id,
                LiteraryDirectionId = Realism.Id
            };

            SaintPaisius = new Work
            {
                Id = 4,
                Title = "\"Паисий\"",
                AuthorId = IvanVazov.Id,
                Characters = "Паисий, лирически говорител",
                GenreId = Ode.Id,
                LiteraryDirectionId = Romanticism.Id
            };

            History = new Work
            {
                Id = 5,
                Title = "\"История\"",
                AuthorId = NikolaVaptsarov.Id,
                Characters = "Лирически говорител, историята",
                GenreId = Poem.Id,
                LiteraryDirectionId = Realism.Id
            };

            NoahsArk = new Work
            {
                Id = 6,
                Title = "\"Ноев ковчег\"",
                AuthorId = YordanRadichkov.Id,
                Characters = "хлебарките, космическият удваник, трите врани, каракачанката, " +
                "въшкарчето, глиганът, Апостола, папунякът, щъркелът, лисицата, Емилиян Станев, " +
                "Григор Вачков, Методи Андонов",
                GenreId = Novel.Id,
                LiteraryDirectionId = MagicalRealism.Id
            };

            TheStruggle = new Work
            {
                Id = 7,
                Title = "\"Борба\"",
                AuthorId = HristoBotev.Id,
                Characters = "Соломон, лирически говорител",
                GenreId = Poem.Id,
                LiteraryDirectionId = Realism.Id
            };

            Andreshko = new Work
            {
                Id = 8,
                Title = "\"Андрешко\"",
                AuthorId = ElinPelin.Id,
                Characters = "Андрешко, съдия-изпълнител, повествователят",
                GenreId = ShortStory.Id,
                LiteraryDirectionId = SocialRealism.Id
            };

            ATaleOfTheStairway = new Work
            {
                Id = 9,
                Title = "\"Приказка за стълбата\"",
                AuthorId = HristoSmirnenski.Id,
                Characters = "Дяволът, плебеят",
                GenreId = Satire.Id,
                LiteraryDirectionId = Realism.Id
            };

            ToMyFirstLove = new Work
            {
                Id = 10,
                Title = "\"До моето първо либе\"",
                AuthorId = HristoBotev.Id,
                Characters = "Лирически герой/Аз, либето",
                GenreId = Poem.Id,
                LiteraryDirectionId = Romanticism.Id
            };

            TheNewCemetryNearSlivnitsa = new Work
            {
                Id = 11,
                Title = "\"Новото гробище над Сливница\"",
                AuthorId = IvanVazov.Id,
                Characters = "Лирически говорител, загиналите воини, България",
                GenreId = Poem.Id,
                LiteraryDirectionId = Realism.Id
            };

            ThePeachThief = new Work
            {
                Id = 12,
                Title = "\"Крадецът на праскови\"",
                AuthorId = EmilianStanev.Id,
                Characters = "Иво Обретенович, Елисавета, Никола Козичката, полковникът",
                GenreId = ShortNovel.Id,
                LiteraryDirectionId = Realism.Id
            };

            AtRilaMonastery = new Work
            {
                Id = 13,
                Title = "\"При Рилския манастир\"",
                AuthorId = IvanVazov.Id,
                Characters = "лирически Аз, природата",
                GenreId = PantheisticPoem.Id,
                LiteraryDirectionId = Realism.Id
            };

            Hailstorm = new Work
            {
                Id = 14,
                Title = "\"Градушка\"",
                AuthorId = PeyoYavorov.Id,
                Characters = "лирически говорител, Ваньо селянчето",
                GenreId = EpicPoem.Id,
                LiteraryDirectionId = Symbolism.Id
            };

            TheLakeSleeps = new Work
            {
                Id = 15,
                Title = "\"Спи езерото\"",
                AuthorId = PenchoSlaveykov.Id,
                Characters = "лирически говорител, белостволите буки",
                GenreId = LyricalMiniature.Id,
                LiteraryDirectionId = Individualism.Id
            };

            IWantToRememberYouJustLikeThis = new Work
            {
                Id = 16,
                Title = "\"Аз искам да те помня така\"",
                AuthorId = DimichoDebelyanov.Id,
                Characters = "лирически Аз/влюбеният мъж, обречената жена",
                GenreId = Elegy.Id,
                LiteraryDirectionId = Symbolism.Id
            };

            HowBeatifulYouAre = new Work
            {
                Id = 17,
                Title = "\"Колко си хубава!\"",
                AuthorId = HristoFotev.Id,
                Characters = "лирически Аз/влюбеният мъж, обичаната жена",
                GenreId = Poem.Id,
                LiteraryDirectionId = Realism.Id
            };

            Deadication = new Work
            {
                Id = 18,
                Title = "\"Посвещение\"",
                AuthorId = PetyaDubarova.Id,
                Characters = "влюбената девойка/лирическият говорител, обичаният",
                GenreId = Poem.Id,
                LiteraryDirectionId = Realism.Id
            };

            SapsovaMound = new Work
            {
                Id = 19,
                Title = "\"Спасова могила\"",
                AuthorId = ElinPelin.Id,
                Characters = "Монката, дядо Захари",
                GenreId = ShortStory.Id,
                LiteraryDirectionId = SocialRealism.Id
            };

            Prayer = new Work
            {
                Id = 20,
                Title = "\"Молитва\"",
                AuthorId = AtanasDalchev.Id,
                Characters = "лирическият Аз, Господ",
                GenreId = Poem.Id,
                LiteraryDirectionId = Diabolism.Id
            };

            Faith = new Work
            {
                Id = 21,
                Title = "\"Вяра\"",
                AuthorId = NikolaVaptsarov.Id,
                Characters = "лирическият Аз, Животът",
                GenreId = Poem.Id,
                LiteraryDirectionId = Existentialism.Id
            };

            TheWindMill = new Work
            {
                Id = 22,
                Title = "\"Ветрената мелница\"",
                AuthorId = ElinPelin.Id,
                Characters = "Лазар Дъбака, дядо Корчан, Христина",
                GenreId = ShortStory.Id,
                LiteraryDirectionId = SocialRealism.Id
            };

            TheSongOfTheWheels = new Work
            {
                Id = 23,
                Title = "\"Песента на колелетата\"",
                AuthorId = YordanYovkov.Id,
                Characters = "Сали Яшар, Джапар, Шакире",
                GenreId = ShortStory.Id,
                LiteraryDirectionId = Realism.Id
            };

            BalladForGeorgHenig = new Work
            {
                Id = 24,
                Title = "\"Баладa за Георг Хених\"",
                AuthorId = ViktorPaskov.Id,
                Characters = "Виктор Георг/дядо Георги, Божения, Марсен, Франета, Ванда",
                GenreId = ShortNovel.Id,
                LiteraryDirectionId = Modernism.Id
            };

            TwoSouls = new Work
            {
                Id = 25,
                Title = "\"Две души\"",
                AuthorId = PeyoYavorov.Id,
                Characters = "лирическият Аз",
                GenreId = Poem.Id,
                LiteraryDirectionId = Symbolism.Id
            };

            Descendant = new Work
            {
                Id = 26,
                Title = "\"Потомка\"",
                AuthorId = ElisavetaBagryana.Id,
                Characters = "потомката - лирическият Аз",
                GenreId = Poem.Id,
                LiteraryDirectionId = Symbolism.Id
            };

            HonestCross = new Work
            {
                Id = 27,
                Title = "\"Честен кръст\"",
                AuthorId = BorisHristov.Id,
                Characters = "лирическият говорител/Аз",
                GenreId = EpicPoem.Id,
                LiteraryDirectionId = Existentialism.Id
            };
        }
    }
}
