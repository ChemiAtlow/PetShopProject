﻿namespace PetShopProject.Data
{
    public static class PrePopulateHelper
    {
        /// <summary>
        /// Seeded Categories
        /// </summary>
        public static object[] Categories = new object[] {
            new { CategoryId = 1, Name = "חתולים"},
            new { CategoryId = 2, Name = "כלבים"},
            new { CategoryId = 3, Name = "ציפורים"},
            new { CategoryId = 4, Name = "דגים"},
        };
        /// <summary>
        /// Seeded Animals.
        /// </summary>
        public static object[] Animals = new object[] {
            new { AnimalId = 1, CategoryId = 1, Age = 2.4, Name = "חתול פרסי", PictureName="1_persian.jpg", Description = "מוצאו של החתול הפרסי, או כפי שנקרא בזמנו, פשוט \"חתול ארוך שיער\", הוא בפרס ובארצות אסיה התיכונה. בספרות המקצועית הוזכר ה\"פרסי\" בפעם הראשונה ב-1876 בשם \"החתול האסיאתי\", אך כבר כ-300 שנה לפני כן, במאה השש עשרה, נראו חתולים אלה באירופה, בתחילה באיטליה וצרפת. לשם הגיעו על ידי דיפלומטים שביקרו בפרס וסביבתה, התלהבו ושלחו אותם לארצותיהם באירופה. בתקופה זו מוכרים חתולים ארוכי פרווה נוספים - חתולי האנגורה. מוצאם בטורקיה, והם אבות אבותיהם של החתולים מגזע ה-Turkish Angora. גם חתולים אלה הגיעו לארצות אירופה ובעיקר לאנגליה."},
            new { AnimalId = 2, CategoryId = 1, Age = 3.1, Name = "חתול בנגלי", PictureName="2_bangali.jpg", Description = "החתול הבנגלי הוא גזע חדש יחסית. הגזע פותח להיות בעל אופי חברותי ויחד עם זאת להציג מראה של חתול פראי. אין להתבלבל עם טיגריס בנגלי שמו של החתול הבנגלי נגזר משם אבותיו חתול נמרי בנגלי (Prionailurus bengalensis). תחילתו של הגזע הייתה בשנת 1963 כאשר חוקר אמריקאי ערך מחקר בנושא לוקמיה של חתולים והרביע חתולי בר עם חתולי בית. משום שהרבעה זו היא עירוב בין שני מיני בעלי חיים שונים, הצאצאים של הדור הראשון היו לרוב עקרים. את הדור הראשון והשני מרביעים בדרך כלל עם חתול בית או חתולי בנגל אחרים. החתול נחשב חתול מהגזע הבנגלי כשהוא לפחות במרחק דור רביעי מחתול הבר האסיאתי." },
            new { AnimalId = 3, CategoryId = 1, Age = 6.1, Name = "חתול סיאמי", PictureName="3_siami.jpg", Description = "החתול הסיאמי הגיע מהמזרח הרחוק, שם גידלו וטיפחו אותו במקדשים הבודהיסטיים. חתולים אלו נחשבו כקדושים ואף האמינו כי הם גלגול של נשמות אדם. בתחילת המאה ה-20 הוא הובא לאנגליה, שם גידלו את הגזע בבתי גידול מיוחדים." },
            new { AnimalId = 4, CategoryId = 1, Age = 1.6, Name = "חתול ספינקס", PictureName="4_sphinx.jpg", Description = "גופו של חתול הספינקס הוא בינוני ושרירי. יש לו זנב דק וארוך, ראש בגודל בינוני אוזניים גדולות ועיניים מלוכסנות. סימן ההיכר הבולט ביותר של גזע זה הוא היעדר הפרווה. עורו רך מאוד ועקב המחסור בפרווה, הוא רגיש מאוד לשינויי טמפרטורה ולכן זקוק לטיפוח אינטנסיבי." },
            new { AnimalId = 5, CategoryId = 2, Age = 7.2, Name = "בולדוג אנגלי", PictureName="5_buldog.jpg", Description = "במקור טופח הבולדוג במאה ה-17 באנגליה ללוחמת שוורים, מימי הביניים, במשך כ-600 שנה, הבולדוג שימש לגירוי וללחימה בשוורים. הייתה סברה, שגירוי השוורים לפני השחיטה תגרום לריכוך בשרם. לצורך כך היו משסים כלב בפר כבול או מותש. נוהג זה הפך ל\"ספורט\" פופולרי, שמשך קהל רב. מבנהו של הבולדוג, שפותח מגזע המסטיף, הפך אותו מתאים במיוחד לתפקיד: קצר רגליים, פראי, ובעל לסתות חזקות. פניו הקצרות הועילו גם כן, והוא יכול היה לנשוך את אפו של השור ברגע שזה הוריד את ראשו כדי לנגוח בכלב. הבולדוג לא היה מרפה גם כאשר השור היה מרים אותו לאוויר, ולעיתים גם היה נפצע בצורה קשה. בשנת 1835 הוצאה ההתגרות בפרים אל מחוץ לחוק. מאז נעלם כושר הלחימה של הבולדוג, והודגשו מבנה גופו ופניו המכווצים." },
            new { AnimalId = 6, CategoryId = 2, Age = 3.6, Name = "פודל", PictureName="6_pudel.jpg", Description = "הפודל נחשב לכלב השני האינטליגנטי ביותר, כשאת המקום הראשון תופס הבורדר קולי. בעוד שהבורדר קולי פעיל מאוד, הפודל שקט ורגוע בבית, אך אקטיבי ונמרץ בחוץ. הפודל חברותי ומסתדר היטב הן עם אנשים והן עם כלבים אחרים. פודלים מהסוגים הגדולים נחשבים לכלבי שמירה וציד טובים." },
            new { AnimalId = 7, CategoryId = 2, Age = 2.0, Name = "פאג", PictureName="7_pug.jpg", Description = "פאג (באנגלית: Pug) הוא כלב בעל פרצוף פחוס וגוף קטן. הפאג מוגדר ככלב לוויה. המילה \"פאג\" מגיעה כנראה מן המילה האנגלית Pugg, במובן של חיבה, שפירושה \"קופיף\" או \"שדון קטן\". שמות נוספים לכלב הפאג הם מופס, פוגו, קארלי, בולדוג הולנדי ומיני-מסטיף. לעיתים מתארים את הכלב כ\"הרבה במעט\" (מלטינית multum in parvo) מה שבא לתאר את אופיו המקסים לעומת גודלו הקטן.\nלכלבי הפאג מבנה גוף קטן יחסית, עיניים גדולות ובולטות וזנבם מסולסל. פרוותו קצרה וצבעה שחור או חום בהיר עם פנים שחורות. רבים מהם סובלים מבעיות נשימה בגלל המבנה הפחוס של פניהם, בעיות עור בשל הקפלים בעורם ובפרוותם ומנשירה במהלך כל עונות השנה. הפאג הוא כלב ידידותי ומלא שמחה ואופיו נוח וידידותי למבוגרים ולילדים כאחד." },
            new { AnimalId = 8, CategoryId = 2, Age = 1.2, Name = "האסקי סיבירי", PictureName="8_haski.jpg", Description = "ההאסקים הסיביריים ידועים באופיים החברותי. הם שלווים, אוהבים ומסורים לבעלים. הם זן חכם ביותר ובעלי כושר הבנה מפותח ואינטליגנציה רגשית גבוהה. הם חברותיים מגיל צעיר ומתיידדים במיוחד עם ילדים, כך שהם כלבי משפחה אידיאליים. הם חיים מטבעם בלהקות ורגילים לעבודת צוות, ולכן מחשיבים את עצמם כחלק מהמשפחה." },
            new { AnimalId = 9, CategoryId = 3, Age = 2.9, Name = "יען", PictureName="9_yaen.jpg", Description = "יען הוא סוג של עופות לא מעופפים ובו שני מינים. שני עופות אלה הם העופות הגדולים ביותר בעולם כיום: יען מצוי המגיע לגובה 2.6 מטר ולמשקל 130 ק\"ג ויען סומלי הקטן מעט ומגיע לאורך 200-240 ס\"מ ולמשקל 90-130 ק\"ג. בנוסף הם המהירים מכל העופות היבשתיים ובעלי הביצים הכבדות ביותר." },
            new { AnimalId = 10, CategoryId = 3, Age = 6.1, Name = "יונה", PictureName="10_dove.jpg", Description = "פירוש מקור השם המדעי של היונה (Columba) הוא \"שחייה\". כך מתאר המחזאי היווני אריסטופאנס את היונה כשהיא נראית כ'שוחה' באוויר, ומכאן נלקח באופן מטאפורי השם האנגלי 'dove' שפירושו בגרמנית - 'צלילה'." },
            new { AnimalId = 11, CategoryId = 3, Age = 3.1, Name = "קקדו לבן", PictureName="11_kakado.jpg", Description = "קקדו לבן הוא מין של תוכי ממשפחת הקקדואיים, שנחשב לאחד התוכיים בעלי האינטליגנציה הגבוהה ביותר. הקקדו מכונה לעיתים \"אמברלה\" (מאנגלית: Umbrella, מטרייה) משום שכאשר הוא חש שמחה או פחד נפרשת מראשו מעיין כרבולת הדומה בצורתה למטרייה. קקדו לבן אנדמי לאיי מאלוקו הצפוניים, ותוחלת חייו הממוצעת היא 40 שנה." },
            new { AnimalId = 12, CategoryId = 3, Age = 2.8, Name = "דררת קרמר", PictureName="12_kremer.jpg", Description = "לדררת קרמר יש גוף קטן. צבעה ירוק בהיר וזנבה ארוך, עם מדרגות. אורכה הממוצע הוא 41 סנטימטרים, מתוכם 23 סנטימטרים אורך זנבה. אורך כנפיה 15–17.5 סנטימטרים, ומוטת הכנפיים היא 34–39 סנטימטרים. חלקו העליון של מקורה אדום והתחתון שחור. לזכר הבוגר צווארון שחור בין הסנטר לצדי הצוואר. בעורף הוא נעשה ורוד בהיר. לצעירים יש נוצות זהבהבות, המקורים אדומים והזנב ארוך." },
            new { AnimalId = 13, CategoryId = 4, Age = 1.5, Name = "דג זהב", PictureName="13_gold.jpg", Description = "דג זהב או קָרַס זָהָב (שם מדעי: Carassius auratus) הוא דג ממשפחת הקרפיוניים (Cyprinidae), החי במים מתוקים. דג זה בוית למספר זנים ונפוץ כחיית מחמד באקווריומים ודג נוי בבריכות נוי.\nמקורו של דג הזהב שנוי במחלוקת בקרב הקהילה המדעית. התאוריה המקובלת כיום היא שדג הזהב הוא מוטציה גנטית של קרס מצוי (Carassius carassius). התאוריה נסמכת על העובדה כי לשני הדגים אותו מספר כרומוזומים, 100, בעוד שבשאר בני משפחת הקרפיוניים מספר הכרומוזומים הוא 50 בלבד.\nתאוריה נוספת רואה את מקור דג הזהב בקרפיון Carassius auratus gibelio." },
            new { AnimalId = 14, CategoryId = 4, Age = 2.3, Name = "ציקליד אפריקאי", PictureName="14_afrika.jpg", Description = "אמנוניים (בלעז: ציקלידים; שם מדעי: Cichlidae) היא משפחת דגים מסדרת הדקראים. משפחת האמנוניים גדולה ומגוונת, ומהווה חלק נכבד מסדרת הדקראים. קיימים לפחות 1,300 מינים שונים המתוארים באופן מדעי, ולאור זאת משפחת האמנוניים היא אחת ממערכת בעלי החוליות הגדולות ביותר. מספר רב של מינים חדשים מתגלה מדי שנה, ומינים רבים נשארים ללא תיאור. לכן מספר המינים הממשי לא ברור, והערכת מספרם נעה בין 1,300 ל-3,000 מינים." },
            new { AnimalId = 15, CategoryId = 4, Age = 2.9, Name = "דיסקוס", PictureName="15_diskus.png", Description = "דִּיסְקוּס (שם מדעי: Symphysodon) הוא שם של סוג ממשפחת האמנוניים הכולל שלושה מיני דגים, שמוצאם ממקווי מים מתוקים באגן האמזונאס. דגי הדיסקוס נפוצים מאוד כדגי נוי ונחשבים ליפים ויוקרתיים ביותר. הם מגודלים במספר מדינות ביבשת אסיה." },
            new { AnimalId = 16, CategoryId = 4, Age = 5.2, Name = "אלטום", PictureName="16_altom.jpg", Description = "מדובר בדג ממשפחת האמנוניים -Cichlidae, שמתאפיינים במבנה גוף דמוי דקר. דגים ממשפחה זו לרוב ניחנים באינטיליגנציה גבוהה ולעומת רוב בדגים שומרים על צאצאיהם בתקופת ההתפתחות. למשפחה תפוצה כלל עולמית באיזורים טרופיים וסובטרופיים, ובמקרים מסויימים מדובר במשפחת הדגים הדומיננטית באותו מקווה מים. משפחת האמנוניים, או בשמם העממי ציקלידים, כוללת לפחות 1650 זנים ידועים מה שהופך אותה לאחת ממשפחות החולייתנים הגדולות ביותר, ומהווה את משפחת הדגים הפופולארית ביותר בין דגי האקווריום." }
        };
        /// <summary>
        /// Seeded Comments.
        /// </summary>
        public static object[] Comments = new object[]
        {
            new { CommentId = 1, AnimalId = 1, CommentText = "נראה כמו וולדמורט של החתולים 🤔"},
            new { CommentId = 2, AnimalId = 2, CommentText = "נמר מיניאטורי! 😍"},
            new { CommentId = 30, AnimalId = 2, CommentText = "מזכיר לי חבר ילדות שלי!"},
            new { CommentId = 3, AnimalId = 3, CommentText = "אין על Grumpy Cat 😾"},
            new { CommentId = 4, AnimalId = 4, CommentText = "💩"},
            new { CommentId = 5, AnimalId = 4, CommentText = "מה זה הדבר הזה 😰"},
            new { CommentId = 6, AnimalId = 5, CommentText = "ורנון דרסלי בגרסה הכלבית! 🐶"},
            new { CommentId = 7, AnimalId = 5, CommentText = "אוי, האושר בעיניים!"},
            new { CommentId = 8, AnimalId = 6, CommentText = "שלום, יש לי פודלית ננסית והיא לפעמים עושה פיפי על המיטות כאשר אנחנו לא בבית, בנוסף היא עושה את צרכיה בלילה. איך אפשר למנוע ממנה לעשות זאת?"},
            new { CommentId = 9, AnimalId = 6, CommentText = "לפודל שלנו יש הפרשה חומה מהעין האם זאת דלקת?"},
            new { CommentId = 10, AnimalId = 7, CommentText = "האם אפשר לאלף אותו שלא יעשה את צרכיו בבית? 💩"},
            new { CommentId = 11, AnimalId = 7, CommentText = " אם משאירים אותו לכמה שעות הוא עושה רעשים?"},
            new { CommentId = 12, AnimalId = 7, CommentText = "האם הוא נוחר בשנתו?"},
            new { CommentId = 13, AnimalId = 8, CommentText = "יש לי גור בן 4 שבועות מסוג האסקי סיבירי צבע העניים שלו כחול ים. אני חושב שהוא עיוור. איך אוכל לברר זאת?"},
            new { CommentId = 14, AnimalId = 8, CommentText = "היי, אני רוצה כלב ואמא שלי מוכנה רק כלב בלי נשירת שיער כמו פודל או יורקשייר... אבל אני רוצה האסקי סיבירי, יש לו נשירה?"},
            new { CommentId = 15, AnimalId = 8, CommentText = "יש לי כלב האסקי סיבירי בין חודש ושבוע ורציתי לדעת אם אני כבר יכול להתחיל ללמד אותו לא לעשות את הצרכים בבית ואיך?"},
            new { CommentId = 16, AnimalId = 8, CommentText = "ישש לי כלב מסוג האסקי סיבירי והוא מיילל כל הזמן. כדאי להביא עוד כלב לבית מסוג זה?"},
            new { CommentId = 17, AnimalId = 9, CommentText = "חיה נוראית. לא כיף לי איתה!"},
            new { CommentId = 18, AnimalId = 10, CommentText = "בלי ספק חיה נוראי.\nהלשלשת שלה זו מכה שאין לה מענה!"},
            new { CommentId = 19, AnimalId = 10, CommentText = "אל תתקרבו לחיה הזו! היא תנכר לכם במוח כל היום!"},
            new { CommentId = 20, AnimalId = 11, CommentText = "אמרת כאב ראש אמרת קקדו לבן."},
            new { CommentId = 21, AnimalId = 12, CommentText = "לפחות צבעים יפים יש לה 🤷🏼‍♂️"},
            new { CommentId = 22, AnimalId = 13, CommentText = "תכל'ס אין על דגי זהב..."},
            new { CommentId = 26, AnimalId = 13, CommentText = "אפשר לאכול דגי זהב בתור סושי?"},
            new { CommentId = 23, AnimalId = 14, CommentText = "לא הבנתי מה אפריקאי בציקליד הזה!"},
            new { CommentId = 24, AnimalId = 15, CommentText = "ואוו! חיה מרהיבה!"},
            new { CommentId = 27, AnimalId = 15, CommentText = "ללא ספק מהדגים היפים שראיתי!"},
            new { CommentId = 28, AnimalId = 15, CommentText = "מטורף לגמרי!"},
            new { CommentId = 25, AnimalId = 16, CommentText = "איזה מין שם זה אלטום?"},
            new { CommentId = 29, AnimalId = 16, CommentText = "לא מועיל, אבל גם לא מזיק..."},
        };
    }
}