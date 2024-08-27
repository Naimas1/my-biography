using CsQuery;
using javax.swing.text.html;
internal partial class Program
{
    private static void Main(string[] args, DocType docType, bool docTypeHTML, HTML hTML)
    {
< !docTypeHTML >
< hTML lang = "uk" >
< head >
    < meta charset = "UTF-8" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < title > Сторінка про мене</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        background - color: #f0f0f0;
            color: #333;
            margin: 0;
    padding: 0;
        }

        .container {
            width: 80 %;
    margin: 50px auto;
        background - color: #fff;
            padding: 20px;
        box - shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
        border - radius: 10px;
        text - align: center;
        }

        h1 {
            color: #007BFF;
        }

        .profile - photo {
        width: 150px;
        height: 150px;
            border - radius: 50 %;
            margin - top: 20px;
        }

        p {
            font-size: 18px;
        line - height: 1.6;
        }

        .social - links {
            margin - top: 20px;
        }

        .social - links a {
            text-decoration: none;
    color: #007BFF;
            margin: 0 10px;
        }

        .social - links a: hover {
            text - decoration: underline;
        }
    </ style >
</ head >
< body >
    < div = "container" >
        < h1 > Привіт! Я - [Ваше Ім'я]</h1>
        <img src="images/my_photo.jpg" alt="Моє фото" = "profile-photo" >
        < p > Я[короткий опис про себе].Захоплююсь[ваші хобі або інтереси].Працюю в сфері[ваша професійна діяльність].</p>
        <p>Зв'язатися зі мною можна за допомогою:</p>
        <div = "social-links" >
            < a href = "mailto:[ваш_email@example.com]" > Email </ a > |
            < a href = "[ваш_профіль_в_соцмережах]" > Соцмережі </ a >
        </ div >
    </ div >
</ body >
</ html >
}
}

classclassclass