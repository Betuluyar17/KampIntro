using System;

namespace GameProject
{
    //Project Description
    //Requirements

    //   1.	Oyuncuların sisteme kayıt olabileceğim, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. 
    //       Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama 
    //       TcNo, Ad, Soyad, Doğum Yılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir. )
    //   2.	Oyun satışı yapılabilecek satış ortamını simule ediniz. ( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre 
    //       olarak metotta olmasını kastediyorum.)
    //   3.	Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
    //   4.	Satışlarda kampanya entegrasyonunu simule ediniz. 
    //   5.	Ödevinizi Github’a yükleyiniz. Github linki paylaşınız. 

    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1993,
                FirstName = "Betül",
                LastName = "Uyar",
                IdentityNumber = 22222222222
            });

            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.Add(new Order
            {
                Id=1,
                CampaignId = 2,
                OrderName="Dress",
                Price=200,
                Quantity=1
            });
        }
    }
}