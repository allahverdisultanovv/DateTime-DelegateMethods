using DelegateMethods.Models;

//1.Person class-ınız olur.Name, Surname, Age propertyləri olur.
//Program.cs de:
//People List-i yaradırsınız. FindAll methodu ilə aşağıdakı sorğuları yazın :
//a.Adı Kamil(her hansisa bir ad) olan person-u çıxarsın.
//b. Soyadı ov ve ova ilə bitən tələbələri çıxarsın.
//c. Yaşı 20+ olanları çıxarsın

List<Person> people = new List<Person>
{
    new Person{Name="Fernando", Surname="Muslera",Age=38 },
    new Person{Name="Davinson", Surname="Sanchez",Age=28 },
    new Person{Name="Abdulkerim", Surname="Bardakci",Age=30 },
    new Person{Name="Baris Alper", Surname="Yilmaz",Age=24 },
    new Person{Name="Kaan", Surname="Ayhanov",Age=30 },
    new Person{Name="Gabriel", Surname="Sara",Age=25 },
    new Person{Name="Lucas", Surname="Torreira",Age=29 },
    new Person{Name="Dries", Surname="Mertens",Age=38 },
    new Person{Name="Victor", Surname="Osimhen",Age=26 },
    new Person{Name="Mauro", Surname="Icardi",Age=32 },
    new Person{Name="Allahverdi",Surname="Sultanov" ,Age=19 },
    new Person{Name="Fidan", Surname="Orucova",Age=46}
};

Console.WriteLine(people.Find(x => x.Name == "Dries").Name);
people.FindAll(x => x.Surname.Contains("ov")).ForEach(x => Console.WriteLine(x.Name));
Console.WriteLine("+--+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
people.FindAll(x => x.Age > 20).ForEach(x => Console.WriteLine(x.Name));


//2.
//Exam class


// -Subject
// - ExamDuration(nece saat devam edir onu gosterir)
// - StartDate(DateTime ile dinamik teyin olunur)
// - EndDate(DateTime ile dinamik teyin olunur Startin ustune durationu gelirsiz)

//Program.cs:
//exams Listi yaradirsiz.
//Bir nece exam yaradib daxil etdikden sonra console-da asagidaki siyahilari gosterirsiniz
//- son 1 hefte erzinde olan  examlarin siyahisini gosterirsiniz
//- 2 saatdan uzun ceken imtahanlarin siyahisi
//- bashlayib amma bitmemish(hal-hazirda devam eden) imtahanlarin siyahisi

//Siyahilari gosterende asagidaki datalari gosterirsiniz her bir siyahi ucun
// - Subject, Duration


Exam exam1 = new("Math", new DateTime(2024, 10, 15, 15, 30, 00), 3);
Exam exam2 = new("Biology", DateTime.Now, 3.6);
Exam exam3 = new("Programming", new DateTime(2024, 10, 23, 12, 55, 00), 1.5);
Exam exam4 = new("Foreign Language", new DateTime(2024, 11, 10, 13, 00, 00), 2);
Exam exam5 = new("Physics", new DateTime(2024, 10, 28, 11, 55, 00), 1.2);
Exam exam6 = new("Geography", new DateTime(2022, 10, 23, 12, 55, 00), 0.9);
Exam exam7 = new("Chemistry", new DateTime(2024, 11, 10, 12, 30, 00), 3.5);
Exam exam8 = new("Web technologies", new DateTime(2024, 02, 22, 15, 25, 00), 2);
Exam exam9 = new("Alghoritm", new DateTime(2024, 10, 29, 23, 55, 00), 0.5);
List<Exam> exams = new List<Exam>();
exams.Add(exam1);
exams.Add(exam2);
exams.Add(exam3);
exams.Add(exam4);
exams.Add(exam5);
exams.Add(exam6);
exams.Add(exam7);
exams.Add(exam8);
exams.Add(exam9);

Console.WriteLine("Son bir hefte rzinde olan imtahanlar");
exams.FindAll(x => x.StartTime.AddDays(7) >= DateTime.Now && x.StartTime < DateTime.Now).ForEach(x => Console.WriteLine($"{x.Subject}   {x.ExamDuration}"));
Console.WriteLine("Hal hazirda dacam eden imtahanlar");
exams.FindAll(x => x.StartTime < DateTime.Now && x.EndTime > DateTime.Now).ForEach(x => Console.WriteLine($"{x.Subject}   {x.ExamDuration}"));
Console.WriteLine("2 saatdan artiq davam eden imtahanlar");
exams.FindAll(x => x.ExamDuration > 2).ForEach(x => Console.WriteLine($"{x.Subject}    {x.ExamDuration}"));


