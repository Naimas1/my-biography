using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter streamwriter = new StreamWriter(@"D:\index.html"))
        {
            streamwriter.WriteLine("<!DOCTYPE html>");
            streamwriter.WriteLine("<html lang=\"uk\">");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine("  <meta charset=\"UTF-8\">");
            streamwriter.WriteLine("  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            streamwriter.WriteLine("  <title>Сторінка про мене</title>");
            streamwriter.WriteLine("  <link rel=\"stylesheet\" href=\"style.css\">");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");
            streamwriter.WriteLine("  <div class=\"container\">");
            streamwriter.WriteLine("    <h1>Привіт! Я - Рябчук Денис</h1>");
            streamwriter.WriteLine("    <img src=\"images"photo_5285151541029880218_y.jpg"\" alt=\"Моє фото\" class=\"profile-photo\">");
            streamwriter.WriteLine("    <p> [21 год,рабораю и учусь в айти академии Шаг]. Захоплююсь [Изучением иностранных языков]..</p>");
            streamwriter.WriteLine("    <p>Зв'язатися зі мною можна за допомогою email [ saint.naim@gmail.com].</p>");
            streamwriter.WriteLine("  </div>");
            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
        }
    }
}
