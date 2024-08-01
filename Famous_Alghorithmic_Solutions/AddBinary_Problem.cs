namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    public class AddBinary_Problem
    {
        public void Test()
        {
            Console.WriteLine(AddBinary("11", "1"));
        }

        public string AddBinary(string a, string b)
        {
            int i = a.Length - 1; // İlk stringin son indeksi
            int j = b.Length - 1; // İkinci stringin son indeksi
            int carry = 0; // Taşıma değeri
            string result = ""; // Toplam sonucu

            // Her iki stringin bitleri taranır ve taşıma durumu göz önünde bulundurulur
            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry; // Taşıma değeri başlangıcı

                // İlk stringin biti toplama işlemine eklenir ve indeks azaltılır
                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }

                // İkinci stringin biti toplama işlemine eklenir ve indeks azaltılır
                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                carry = sum / 2; // Toplama sonucu taşıma durumu hesaplanır
                result = (sum % 2) + result; // Toplam sonucu güncellenir (binary string olarak)
            }

            return result; // Sonuç döndürülür
        }
    }
}
