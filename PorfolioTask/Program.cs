using Newtonsoft.Json.Linq;
using PorfolioTask.Constant;
using PorfolioTask.DataAccessLayer.Conrete;
using PorfolioTask.Entity.Concrete;
using System;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PorfolioTask
{
    internal class Program
    {
        private static UserRepository _userRepository;
        private static PricingRepository _pricingRepository;
        private static PricingDescroptionRepository _pricingDescroptionRepository;
        private static BlogRepoistory _blogRepoistory;
        private static CommentRepoistory _commentRepoistory;
        private static MessageClear _messageClear;
        private static Messages _messages;

        static Program()
        {
            _userRepository = new UserRepository();
            _pricingRepository = new PricingRepository();
            _pricingDescroptionRepository = new PricingDescroptionRepository();
            _blogRepoistory = new BlogRepoistory();
            _commentRepoistory = new CommentRepoistory();
            _messageClear = new MessageClear();
            _messages = new Messages();
        }

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        

            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("1. User\n2. Pricing\n3. Blog\n4. Çıxış");
                int choice;
                choice = ChoiseChecker(4);
                switch (choice)
                {
                    case 1:
                        UserManagment();
                        break;
                    case 2:
                        PricingManagment();
                        break;
                    case 3:
                        BlogManagment();
                        break;
                    case 4:
                        isContinue = false;
                        break;
                }
            }
        }

        private static int ChoiseChecker(int lastindex)
        {

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > lastindex)
            {
                _messageClear.Message(_messages.Choose_Controller);
            }
            return choice;
        }

        #region Blog

        public static void BlogManagment()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("1.Blog Əlavə Et\n2. Blogları Gör\n3.BloglarI İdye Göre gör \n4.Idyə Göre Sil\n5.Yenilə\n6.Çıxış");
                int choice = ChoiseChecker(6);
                switch (choice)
                {
                    case 1:
                        BlogAdd();
                        break;
                    case 2:
                        BlogGet();
                        break;
                    case 3:
                        BlogGetById();
                        break;
                    case 4:
                        //Blogu Sil
                        break;
                    case 5:
                        //Blogu Yenilə
                        break;
                    case 6:
                        isContinue = false;
                        break;
                }
            }
        }
        public static void BlogAdd()
        {
            Console.WriteLine("Title Daxil Et:");
            string title = Console.ReadLine();
            Console.WriteLine("Writer Daxil Et:");
            string writerr = Console.ReadLine();
            Console.WriteLine("Description  Daxil Et:");
            string desc = Console.ReadLine();
            Console.WriteLine("ImageUrl  Daxil Et:");
            string image = Console.ReadLine();

            Blog blog = new Blog()
            {
                Title = title,
                Writer = writerr,
                Description = desc,
                ImageUrl = image
            };
            _blogRepoistory.Add(blog);
            _messageClear.Message("Blog Elave Edildi");
        }
        public static void BlogGet()
        {
            var value = _blogRepoistory.GetAll();
            foreach (var item in value)
            {
                Console.WriteLine($"{item.Title}");
                Console.WriteLine($"{item.Description}");
                var count = _commentRepoistory.Counta(item.Id);
                Console.WriteLine($"👍 {item.Like} - 💬 {count}");
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
        public static void BlogGetById()
        {
            _messageClear.Message("Oxumaq Isdediyin Bloku Idsini Daxil Edin");
            int blogid = int.Parse(Console.ReadLine());
            var value = _blogRepoistory.GetById(blogid);

            Console.WriteLine($"{value.Title}");
            Console.WriteLine($"{value.Description}");
            Console.WriteLine($"{value.Title}");
            Console.WriteLine($"{value.Description}");
            Console.WriteLine("-----------------------------------------------------------");
            var commentcount = _commentRepoistory.Counta(blogid);
            Console.WriteLine($"👍 {value.Like} - 💬 {commentcount}");
            Console.WriteLine("-----------------------------------------------------------");

            int count = 0;
            bool isContinute = true;
            while (isContinute)
            {
                Console.WriteLine("1.Like AT 👍  -  2.Commet AT 💬 - 3.Çıxış ✖️");

                int chhos2 = int.Parse(Console.ReadLine());
                if (chhos2 == 1)
                {
                    if (count == 1)
                    {
                        count = 0;
                        _blogRepoistory.DecreaseLikeCounta(blogid);
                        Console.WriteLine("Beynemniz geri götürlükdü");
                    }
                    else
                    {
                        count = 1;
                        _blogRepoistory.IncreaseLikeCounta(blogid);
                        Console.WriteLine("Beyediniz");
                    }


                }
                else if (chhos2 == 2)
                {

                    Console.WriteLine("Messsage Daxil Et:");
                    string Message = Console.ReadLine();

                    Comment comment = new Comment()
                    {
                        BlogId = blogid,
                        Message = Message,
                    };
                    _commentRepoistory.Add(comment);
                    _blogRepoistory.IncreaseCommentCounta(blogid);
                    Console.WriteLine("Şərhiniz Əlavə Edildi");
                }
                else if (chhos2 == 3)
                {
                    isContinute = false;
                }
            }
        }
        #endregion

        #region Princing
        private static void PricingManagment()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("1. Priceng Add \n2. Priceing Description Ad\n3. My Pricing\n4. İd Ye göre Qiymet Cedveli\n5. Çıxış");
                int choice;
                choice = ChoiseChecker(5);
                switch (choice)
                {
                    case 1:
                        PricingAdd();
                 
                }
                break;
                    case 2:
                        PricingAddDescription();
                        break;
                    case 3:
                        GetAllPricing();
                        break;
                    case 4:
                        GetByPricingChoos();
                        break;
                    case 5:
                        isContinue = false;
                        break;
                }
            }
        }
        private static void GetAllPricing()
        {
            var value = _pricingDescroptionRepository.GetAll();

            string last = null;

            foreach (var item in value)
            {

                if (item.Pricings.Title != last)
                {
                    Console.WriteLine($"{item.Pricings.Title} -  {item.Pricings.Money}$");
                    last = item.Pricings.Title;
                }
                Console.WriteLine($"    {item.Description}");
            }
        }
        private static void GetByPricingChoos()
        {
            var pricevale = _pricingRepository.GetAll();
            foreach (var item in pricevale)
            {
                Console.WriteLine($"{item.Id} - {item.Title} - {item.Money}");
            }
            int chhos = int.Parse(Console.ReadLine());
            var value = _pricingDescroptionRepository.GetByChoos(chhos);

            foreach (var item in value)
            {
                Console.WriteLine($"{item.Description}");
            }
        }
        private static void PricingAddDescription()
        {
            Console.WriteLine("Hansı Pricinge Elave Etmek İsdeyidnizi daxil edin:");
            int priceid = int.Parse(Console.ReadLine());
            Console.WriteLine("Description daxil edin");
            string description = Console.ReadLine();
            PricingDescription description2 = new PricingDescription()
            {
                PricingId = priceid,
                Description = description
            };
            _pricingDescroptionRepository.Add(description2);
            _messageClear.Message("Uğurla Əlavə Edildi");
        }
        private static void PricingAdd()
        {
            Console.WriteLine("Title Daxil Et:");
            string title = Console.ReadLine();
            Console.WriteLine("Pul Daxil Et:");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Icon = Daxil Et:");
            string icon = Console.ReadLine();

            Pricing pricing = new Pricing()
            {
                Title = title,
                Money = money,
                Icon = icon,
            };

            _pricingRepository.Add(pricing);
            _messageClear.Message("Uğurla Əlavə Edildi");
        }

        #endregion

        #region User
        private static void UserManagment()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("1.Istifadecini Göstər\n2.Activ Useleri GÖr\n2. İstifadeci Elavə Et\n3.Istifadeci Sil\n4.Idyə Göre Sil\n5.Yenil\n6.SoftDelete\n7.Çıxış");
                int choice;
                choice = ChoiseChecker(8);
                switch (choice)
                {
                    case 1:
                        UserGet();
                        break;
                    case 2:
                        UserActiveGet();
                        break;
                    case 3:
                        UserAdd();
                        break;
                    case 4:
                        UserDelete();
                        break;
                    case 5:
                        UserDeleteById();
                        break;
                    case 6:
                        UserUpdate();
                        break;
                    case 7:
                        UserSoftDelete();
                        break;
                    case 8:
                        isContinue = false;
                        break;
                }
            }
        }
        private static void UserUpdate()
        {
            Console.WriteLine("Yeniləmək İsdedyiniz İd ni Daxil Edin");
            int updateid = int.Parse(Console.ReadLine());
            Console.WriteLine("Adı Daxil Et:");
            string name = Console.ReadLine();
            Console.WriteLine("Title Daxil Et:");
            string title = Console.ReadLine();
            Console.WriteLine("Şəkil Linkini Daxil Et:");
            string imageurl = Console.ReadLine();
            Console.WriteLine("Description Daxil Et:");
            string description = Console.ReadLine();
            var user = _userRepository.GetById(updateid);

            user.Name = name;
            user.Title = title;
            user.Description = description;
            user.ProfileImageUrl = imageurl;
            user.UpdateTime = DateTime.Now;

            _userRepository.Update(user);
            _messageClear.Message("Istifadəci Uğurla Silindi");
        }
        private static void UserDeleteById()
        {
            Console.WriteLine("Görmek İsdediyinin Hesabın İd sini Daxil Edin");
            int userid = int.Parse(Console.ReadLine());
            _userRepository.GetById(userid);
        }
        private static void UserDelete()
        {
            Console.WriteLine("Silmek Isdediyiniz Hesabın İd sini Daxil Edin");
            int userid = int.Parse(Console.ReadLine());
            _userRepository.Delete(userid);
            _messageClear.Message("Istifadəci Uğurla Silindi");
        }
        private static void UserGet()
        {
            var value = _userRepository.GetAll();
            foreach (var item in value)
            {
                Console.WriteLine($"Adı:{item.Name}\n" +
                  $"Title:{item.Title}\n" +
                  $"AboutUs:{item.Description}");
                Console.WriteLine("--------------------------");
            }
        }
        private static void UserActiveGet()
        {
            var value = _userRepository.GetActiveAll();
            foreach (var item in value)
            {
                Console.WriteLine($"Adı:{item.Name}\n" +
                  $"Title:{item.Title}\n" +
                  $"AboutUs:{item.Description}");
                Console.WriteLine("--------------------------");
            }
        }
        private static void UserAdd()
        {
            Console.WriteLine("Adı Daxil Et:");
            string name = Console.ReadLine();
            Console.WriteLine("Title Daxil Et:");
            string title = Console.ReadLine();
            Console.WriteLine("Şəkil Linkini Daxil Et:");
            string imageurl = Console.ReadLine();
            Console.WriteLine("Description Daxil Et:");
            string description = Console.ReadLine();
            User user = new User()
            {
                Name = name,
                Title = title,
                ProfileImageUrl = imageurl,
                Description = description
            };
            _userRepository.Add(user);
            _messageClear.Message("İstifadəçi Uğurla Əlavə Edildi");
        }

        private static void UserSoftDelete()
        {
            Console.WriteLine("Silmek Isdediyiniz Hesbın İd sini Daxil edin");
            int userid = int.Parse(Console.ReadLine());
            _userRepository.SoftDelete(userid);
            _messageClear.Message("Istifadeci Uğurla Silindi\n" +
                "7 gün Ərzində Geri Qaytara Bilərsiniz Yalan Heç VaXT Qayıtmayacaq");
        }
        #endregion
    }
}
