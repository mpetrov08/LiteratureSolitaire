using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExamSessions",
                columns: new[] { "Id", "Session", "Year" },
                values: new object[,]
                {
                    { 1, "May", 2026 },
                    { 2, "May", 2025 }
                });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SpellingNorm" },
                    { 2, "GrammarNorm" },
                    { 3, "PunctuationNorm" },
                    { 4, "ReadingComprehension" },
                    { 5, "LiteratureStudiedWorks" },
                    { 6, "LiteratureUnstudiedWorks" }
                });

            migrationBuilder.InsertData(
                table: "Passages",
                columns: new[] { "Id", "Content", "ExamSessionId", "ImagePath", "Number" },
                values: new object[,]
                {
                    { 1, "Над 80% от младите хора прекарват поне час на ден в платформите за видеосподеляне. Според проучвания клиповете са сред най-гледаните формати, като се предпочитат видеа с продължителност до три минути заради непретенциозното им съдържание и възможността да се гледат „на бегом“. Благодарение на такива видеа младежите се информират, забавляват и вдъхновяват, докато са у дома или в движение. Тези кратки, но същевременно динамични 3 формати са изключително привлекателни – те мигновено предоставят развлечение, като понякога дори изненадват със задълбочеността си. Разнообразието на това, което младите хора гледат, е голямо – комични ситуации, танцови предизвикателства, музикални клипове... Кратките видеа предлагат вихрушка от цветове, звуци, емоции и идеи. В тази динамична среда ключова роля играят инфлуенсърите – харизматичните лидери на дигиталната сцена. Те не просто създават съдържание, а с активната си дейност в платформите за споделяне на видеа изграждат връзка с аудиторията си, вдъхновяват, провокират промяна на нагласите и популяризират нови тенденции. „Ще ти покажа как да успееш!“, „Нека заедно опитаме нещо ново!“ – това не са просто фрази, а мостове към сърцата на милиони млади хора. Несъмнено потреблението на видеосъдържание има и своята тъмна страна. Тъй като клиповете предлагат бързо удовлетворяване на любопитството и лесен достъп до безкрайно разнообразие от съдържание, прекомерното им гледане крие и опасности. Постоянното потапяне в дигиталното пространство създава усещане за свързаност със света и илюзия за динамично взаимодействие с него, като в същото време младите хора започват да пренебрегват физическата активност и директния контакт на живо. Според изследвания прекалено дългото време, прекарано пред екрана, води до понижаване на качеството на съня, до проблеми със зрението и дори до депресивни състояния. Освен това неограниченото гледане на клипове може да създаде зависимост, която в повечето случаи трудно се преодолява. Макар да са наясно с последиците от гледането на видеа, 90% от младите хора не искат да се откъснат от тази дейност, сочи изследване. Този избор не е случаен – за много от младите хора това е начин на живот и те не се нуждаят от „спасяване“, макар често по-възрастните да смятат обратното.", 1, null, 1 },
                    { 2, null, 1, "/images/texts/text2026.png", 2 },
                    { 3, "Спортните занимания са важен фактор за постигане на добро физическо и психическо здраве. Според данните на Световната здравна организация при хората, които спортуват поне 150 минути седмично, има значително по-нисък риск от хронични заболявания и преждевременна смърт. Въпреки това заниманията със спорт имат и своите предизвикателства. Много специалисти предупреждават, че неправилната техника на изпълнение на упражненията, 3 прекомерното натоварване и омаловажаването на възстановителните периоди могат да доведат до сериозни травми. Скорошно изследване сочи, че около 30% от редовно спортуващите получават травми, които са резултат от липсата на загряване преди тренировка. Според експертите по спортна медицина съревнованието с другите спортуващи в залата често подтиква хората да надценяват възможностите си, което увеличава риска от дълготрайни увреждания. Съществуват и някои погрешни схващания около спортуването. Широко разпространено например е мнението, че тичането може да се практикува от всички. Ако човек обаче е с тегло дори и малко над нормата, рискът от травми е много по-голям. При бягане ставите на краката трябва да издържат на натоварване, което се равнява на утроеното собствено тегло. Друго разпространено схващане е, че разходката не е спорт. Данни от изследване обаче свидетелстват, че четири кратки разходки на ден са по-полезни от продължителен джогинг както за кръвообрaщението и работата на сърцето, така и за намаляването на високото кръвно налягане. Доказано е също така, че ако се изминават пеша кратки отсечки от по един километър, проблемите със съня намаляват наполовина. Танцуването пък се оказва, че е едно от най-ефективните и същевременно найполезните за гърба спортни занимания. Гръбначните мускули се стабилизират, а тялото изгаря за час танцуване около 600 килокалории. Редовните занимания с танци намаляват със 76% риска от деменция, сочи изследване. Народните танци например не само укрепват здравето – те съхраняват и културната идентичност чрез връзката с фолклора и обичаите. Някои експерти смятат обаче, че спортуването е само една част от здравословния начин на живот. Според повечето диетолози правилното хранене и качественият сън са не по-малко важни. Физическата активност може да подобри здравето, но без балансиран хранителен режим и без достатъчно почивка усилията може да бъдат напразни.", 2, null, 1 },
                    { 4, null, 2, "/images/texts/text2025.png", 2 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "ExamSessionId", "QuestionTypeId" },
                values: new object[,]
                {
                    { 1, "В кой ред думата е изписана правилно?", 1, 1 },
                    { 2, "В кой ред думата е изписана правилно?", 2, 1 },
                    { 3, "В кое изречение НЕ е допусната граматична грешка?", 1, 2 },
                    { 4, "В кое изречение НЕ е допусната граматична грешка?", 2, 2 },
                    { 5, "В кое изречение НЕ е допусната пунктуационна грешка?", 1, 3 },
                    { 6, "В кое изречение е допусната пунктуационна грешка?", 2, 3 },
                    { 7, "Кое НЕ стимулира младите хора да гледат кратки видеа според Текст 1?", 1, 4 },
                    { 8, "Кое е вярно за спортуването според Текст 1?", 2, 4 },
                    { 9, "Кой проблем е заложен в интерпретацията на темата за творчеството в „Балада за Георг Хених“?", 1, 5 },
                    { 10, "Кой конфликт е заложен в интерпретацията на темата за човека и властта в „Андрешко“?", 2, 5 },
                    { 11, "Коя тема е интерпретирана в откъса от стихотворението „И пак на дъщеря ми“ на Станка Пенчева? \r\nОт всяко свое пътуване \r\nвсе ти носех по нещо – да те зарадвам, \r\nда усетиш дъха на далечините. \r\nКак обичах завръщането, \r\nпрегръдката ни по летища и гари, \r\nразговорите до среднощ... \r\nТози път,\r\n от най-далечното свое пътуване \r\nняма нищичко да ти донеса.\r\n Само – болка и сиротство, \r\nсамо – заглъхващ спомен \r\nза лицето ми, за гласа, \r\nза облака от любов,\r\n с който те обгръщах... \r\nНикога нищо няма да узнаеш \r\nза най-странното мое пътуване.", 1, 6 },
                    { 12, "Коя тема е интерпретирана в откъса от „Дон Кихоте, близко е Ла Манча!“ на Дамян Дамянов? \r\nДон Кихоте, близко е Ла Манча! \r\nОще малко! Там сме! Още ден! \r\nНищо че ни вразумява Санчо \r\nи че Росинант е уморен! \r\nНищо че заплашват като хора \r\nмелници от вятър и стада.\r\n Нищо че от многото умора \r\nвсе ни се привижда зла беда! \r\nНищо че какви не идиоти \r\nтеб и мен наричат „идиот“!\r\n Ще ги надживеем, Дон Кихоте! \r\nАко не със друго – с цял живот! \r\nС цяла вечност, ако не със друго! \r\nС път красив, на рицарства богат! \r\nНа света, ако не съществуват „луди“, \r\nможе въобще да няма свят.", 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "припадък", true, 1 },
                    { 2, "предчуствие", false, 1 },
                    { 3, "поткрепям", false, 1 },
                    { 4, "преодоляни", false, 1 },
                    { 5, "вариянт", false, 2 },
                    { 6, "уредник", true, 2 },
                    { 7, "съвременици", false, 2 },
                    { 8, "потчертавам", false, 2 },
                    { 9, "Още с дебютната си роля младата актриса спечели симпатиите на публиката.", true, 3 },
                    { 10, "Ще поставим на обществено обсъждане още два много сериозни проблеми.", false, 3 },
                    { 11, "Новия роман на писателя може да бъде закупен с отстъпка до края на месеца.", false, 3 },
                    { 12, "Човешкото ухо има способността да разграничава високите и ниски тонове.", false, 3 },
                    { 13, "След премиерата актрисата благодари на своите почитатели.", true, 4 },
                    { 14, "Във фестивала участваха десет танцови състави от цялата страна.", false, 4 },
                    { 15, "Пълният текст на доклада ще публикуваме скоро на нашия сайт.", false, 4 },
                    { 16, "Спектакълът зарадва ценителите на балетното и оперно изкуство.", false, 4 },
                    { 17, "Мусоните са характерни както за части от Азия така и за части от Австралия.", false, 5 },
                    { 18, "Вацлав Хавел, първият президент на Чехия е автор на около двадесет пиеси.", false, 5 },
                    { 19, "Госпожо Иванова поръчаният от Вас продукт е пристигнал в офиса на фирмата.", false, 5 },
                    { 20, "Божурът е символ на успеха, богатството и любовта, както и на благополучието.", true, 5 },
                    { 21, "Цветовата гама от жълти, сини и зелени тонове, се допълва с бяло и виолетово.", true, 6 },
                    { 22, "Януарският сняг направи непроходим единствения път, водещ към малкото село.", false, 6 },
                    { 23, "Уважаеми господин Пантелеев, най-сърдечно Ви поздравяваме с Вашия юбилей!", false, 6 },
                    { 24, "Необходимо е декларацията да се подпише или от бащата, или от майката на ученика.", false, 6 },
                    { 25, "Възможността набързо да се запознаят с нещо забавно и вдъхновяващо.", false, 7 },
                    { 26, "Лесният достъп до различни дигитални платформи за видеосподеляне.", false, 7 },
                    { 27, "Удобството за няколко минути да научат най-важното от учебния материал.", true, 7 },
                    { 28, "Мигновеното развлечение от гледането на разнообразни забавни ситуации.", false, 7 },
                    { 29, "Ако хората спортуват поне по 150 минути седмично, ще живеят по-дълго.", true, 8 },
                    { 30, "За да се излекуват от хронични заболявания, хората трябва да спортуват.", false, 8 },
                    { 31, "Редовно спортуващите е изключено да получат травми, докато тренират.", false, 8 },
                    { 32, "Спортът оказва благотворно влияние единствено върху физическото здраве.", false, 8 },
                    { 33, "за закъснялата слава на майстора", false, 9 },
                    { 34, "за творческата немощ на стария човек", false, 9 },
                    { 35, "за богоборческата дързост на твореца", false, 9 },
                    { 36, "за бездуховността на обществото", true, 9 },
                    { 37, "приятелство – предателство", false, 10 },
                    { 38, "живот – смърт", false, 10 },
                    { 39, "замисъл – реализация", false, 10 },
                    { 40, "състрадание – безразличие", true, 10 },
                    { 41, "за природата", false, 11 },
                    { 42, "за труда и творчеството", false, 11 },
                    { 43, "за живота и смъртта", true, 11 },
                    { 44, "за раздвоението", false, 11 },
                    { 45, "за труда", false, 12 },
                    { 46, "за вярата", true, 12 },
                    { 47, "за смъртта", false, 12 },
                    { 48, "за миналото", false, 12 }
                });

            migrationBuilder.InsertData(
                table: "QuestionPassages",
                columns: new[] { "PassageId", "QuestionId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 2, 7 },
                    { 3, 8 },
                    { 4, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Passages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Passages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExamSessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExamSessions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
