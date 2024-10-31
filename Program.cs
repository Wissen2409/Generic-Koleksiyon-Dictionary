
// Dictionary koleksiyonu, generic bir koleksiyondur!!

// List koleksiyondan farklı, key ve value alıyor olmasıdır!!!

// Dictionary koleksiyonu, key değeri benzersiz olmalıdır!!!

// İlk tanımlama

Dictionary<int, string> liste = new Dictionary<int, string>();

// eleman ekleyelim 
liste.Add(1, "Ahmet");
liste.Add(2, "Elif");
liste.Add(3, "Veli");
liste.Add(4, "Melek");


// ikinci koleksiyonumuzu tanımlayalım

Dictionary<int, Ogrenci> ogrenciler = new Dictionary<int, Ogrenci>();

Ogrenci o = new Ogrenci();
o.Id = 1;
o.Name = "Banu";

ogrenciler.Add(1, o);

// istenilirse, direk new ile nesne oluşturulabilir!!

ogrenciler.Add(2, new Ogrenci()
{

    Id = 2,
    Name = "Faruk"
});


// Generic Key Value koleksiyonu içerisinde foreach ile dönelim!!!

// Generic key value koleksiyonu içerisinde dönmek için, KeyValuePair isimli tipi kullanmanız gerekmektedir!!
foreach(KeyValuePair<int,Ogrenci> item in ogrenciler){

    Console.WriteLine("Id: {0}",item.Key);
    Console.WriteLine("Öğrenci No : {0}",item.Value.Id);
    Console.WriteLine("Öğrenci Ad  : {0}",item.Value.Name);

}


