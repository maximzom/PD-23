using System;

namespace Classes
{
    class Task1
    {
        static void Main()
        {

            Book outputBook = new Book("1984", "Джордж Орвелл", "Громадяни повиннi думати правильно: «Вiйна – це мир, свобода – це рабство, незнання – це сила, 2+2=5» i т. д.");
            outputBook.Show();

            Console.WriteLine(" ");

            outputBook.ShowAuthorOfBook("Рей Бредберi");
            outputBook.ShowContentOfBook("Нещодавно закiнчилася атомна вiйна, але патрульнi бомбардувальники продовжують лiтати над мiстом. Уряд вирiшив, що людей треба приборкати: вони не повиннi багато думати, а лише працювати i веселитися.");

            outputBook.Show();

            Console.ReadKey();
        }
    }
}