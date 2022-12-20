// See https://aka.ms/new-console-template for more information



List<string> sehirler = new List<string>();
sehirler.Add("samsun");
sehirler.Add("samsun");
sehirler.Add("samsun");
sehirler.Add("samsun");
sehirler.Add("samsun");
sehirler.Add("samsun");

Console.WriteLine(sehirler.Count);


MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
sehirler2.Add("İstanbul");
Console.WriteLine(sehirler2.Count);



class MyList<T>
{
    T[] _array;
    T[] _tempArray;


    public MyList() //yeni listeyi tanımlayan blok
    {
        _array = new T[0]; 
    }


    public void Add(T item)  // burada ilk önce geçici bir array oluşturduk ve o önceden eklenenleri tutacak, her yeni eklenecek eleman için kontanjan
                             // açılması gerekir ve new oluşturduk. For döngüsü de son eklenen elemandan öncekiler sırasıyla yerleriini almasını sağlar.
                             //yeni elemanı eklemek için de son satırdaki kodu yazıyoruz.
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i]; 
        }

        _array[_array.Length - 1] = item; 
    }
    


   private int _count; // kaç elemanlı olduğunu gösteren blok 

   public int Count
   {
       get { return _array.Length; }
        
   }

}
