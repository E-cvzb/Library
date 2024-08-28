using Library;

List<Book> books = new List<Book>();// book sınıfının lisete oluşturma 
books.Add(new Book { AuthorId=1 , BookId=10,Title="Bırak"});
books.Add(new Book { AuthorId = 2, BookId = 11, Title = "Etkili İnsanların 7 Alışkanlığı" });
books.Add(new Book { AuthorId = 2, BookId = 12, Title = "8. Alışkanlık Bütünlüğe  Doğru" });
books.Add(new Book { AuthorId = 3, BookId = 13, Title = "Bir Ömür Nasıl Yaşanır" });
books.Add(new Book { AuthorId = 3, BookId = 14, Title = "Avrupa ve Biz" });
books.Add(new Book { AuthorId = 3, BookId = 15, Title = "Yakın Tarihim Gerçeleri" });
books.Add(new Book { AuthorId = 1, BookId = 16, Title = "Küçük İşler Büyük Özdürlükler" });
books.Add(new Book { AuthorId = 2, BookId = 17, Title = "İnsan Gerçeği Nasıl Kurar" });





List<Author> authorList = new List<Author>();//author sınıfına liste oluşturma
authorList.Add(new Author { AuthorId = 1, Name = "Mert BAŞARAN" });
authorList.Add(new Author { AuthorId = 2,Name="Stephen COVEY"});
authorList.Add(new Author { AuthorId = 3, Name = "İlber ORTAYLI" });

var authorJoınBook = books.Join(authorList,// author ve book listelerinin birleştirlmesi
                                authorList=>authorList.AuthorId,//ortak olan değişkenlerin lamda ile birleştirlmesi
                                books=>books.AuthorId,
                                (books,authorList)=> new// birleştirilen  verilerin yeni liste oluşturulması 
                                {
                                    booktitle=books.Title,
                                    authorname=authorList.Name,
                                }
                                );

foreach(var x in authorJoınBook)//yeni listenin okunması 
{
    Console.WriteLine("Yazar :" +x.authorname+ " Kitap Adı:" + x.booktitle);
}