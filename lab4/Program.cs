using System;
using System.IO;

namespace lab4
{
    /// <summary>
    /// Класс для решения задачи.</summary>
    /// <remarks>
    ///Предположим, нам требуется написать приложение, в котором поддерживается возможность работы со стандартными веб-сервисами Google, Yandex и Baidu 
    ///(карты, поисковая система, почта и т.д.). Напишите часть программы, которая позволяет работать с веб-сервисами компании,выбираемой пользователем.
    ///Программа должна состоять из трёх классов-контроллеров для веб-сервисов компаний (Google, Yandex и Baidu) и класса, в который данные сервисы встраиваются.
    ///Реализовывать реальную работу с сервисами не требуется, достаточно выводить на консоль сообщение, в котором будет указано, какой метод какой класса был вызван.
    ///На вход программе подаётся строка с названием компании и список команд (работа с веб-сервисами). Минимальное количество веб-сервисов у классов Google, Yandex и Baidu: 10.
    ///Для решения задачи потребуется применение шаблона "Внедрение зависимости".

    ///Данные берутся из файла input.txt, сначала указывается имя сервиса, затем список команд, разделитель - пробел.
    ///Пример корректного ввода: 
    ///Yandex Maps Translator Mail 
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Интерфейс Service с методами будущих сервисов
        /// </summary>
        interface Service {
            void Maps();
            void Translator();
            void Mail();
            void Disk();
            void Calendar();
            void Taxi();
            void Music();
            void Weather();
            void News();
            void Images();
        }
        /// <summary>
        /// Класс Yandex
        /// </summary>
        class Yandex : Service {
            public void Maps()
            {
                Console.WriteLine("Yandex Maps");
            }
            public void Translator()
            {
                Console.WriteLine("Yandex Translator");
            }
            public void Mail()
            {
                Console.WriteLine("Yandex Mail");
            }
            public void Disk()
            {
                Console.WriteLine("Yandex Disk");
            }
            public void Calendar()
            {
                Console.WriteLine("Yandex Calendar");
            }
            public void Music()
            {
                Console.WriteLine("Yandex Music");
            }
            public void Taxi()
            {
                Console.WriteLine("Yandex Taxi");
            }
            public void Weather()
            {
                Console.WriteLine("Yandex Weather");
            }
            public void News()
            {
                Console.WriteLine("Yandex News");
            }
            public void Images()
            {
                Console.WriteLine("Yandex Images");
            }
            //public void Schedule()
            //{
            //    Console.WriteLine("Yandex Schedule");
            //}
        }

        /// <summary>
        /// Класс Google
        /// </summary>
        class Google : Service {
            public void Maps()
            {
                Console.WriteLine("Google Maps");
            }
            public void Translator()
            {
                Console.WriteLine("Google Translator");
            }
            public void Mail()
            {
                Console.WriteLine("Google Mail");
            }
            public void Disk()
            {
                Console.WriteLine("Google Disk");
            }
            public void Calendar()
            {
                Console.WriteLine("Google Calendar");
            }
            public void Music()
            {
                Console.WriteLine("Google Music");
            }
            public void Taxi()
            {
                Console.WriteLine("Google Taxi");
            }
            public void Weather()
            {
                Console.WriteLine("Google Weather");
            }
            public void News()
            {
                Console.WriteLine("Google News");
            }
            public void Images()
            {
                Console.WriteLine("Google Images");
            }

            //public void Contacts()
            //{
            //    Console.WriteLine("Google Contacts");
            //}
            //public void Forms()
            //{
            //    Console.WriteLine("Google Forms");
            //}
            //public void Notes()
            //{
            //    Console.WriteLine("Google Notes");
            //}
            //public void Analytics()
            //{
            //    Console.WriteLine("Google Analytics");
            //}
        }

        /// <summary>
        /// Класс Baidu
        /// </summary>
        class Baidu : Service {
            public void Maps()
            {
                Console.WriteLine("Baidu Maps");
            }
            public void Translator()
            {
                Console.WriteLine("Baidu Translator");
            }
            public void Mail()
            {
                Console.WriteLine("Baidu Mail");
            }
            public void Disk()
            {
                Console.WriteLine("Baidu Disk");
            }
            public void Calendar()
            {
                Console.WriteLine("Baidu Calendar");
            }
            public void Music()
            {
                Console.WriteLine("Baidu Music");
            }
            public void Taxi()
            {
                Console.WriteLine("Baidu Taxi");
            }
            public void Weather()
            {
                Console.WriteLine("Baidu Weather");
            }
            public void News()
            {
                Console.WriteLine("Baidu News");
            }
            public void Images()
            {
                Console.WriteLine("Baidu Images");
            }
            //public void Documents()
            //{
            //    Console.WriteLine("Baidu Documents");
            //}
            //public void Video()
            //{
            //    Console.WriteLine("Baidu Video");
            //}
        }

        /// <summary>
        /// Класс Client, зависит от Service
        /// </summary>
        class Client {
            Service serv;
            public Client(Service s) {
                serv = s;
            }
            public void GetServ(string serviceName) {
                switch (serviceName){
                    case "Maps":
                         serv.Maps();
                        break;
                    case "Translator":
                         serv.Translator();
                        break;
                    case "Mail":
                         serv.Mail();
                        break;
                    case "Disk":
                         serv.Disk();
                        break;
                    case "Calendar":
                         serv.Calendar();
                        break;

                    case "Taxi":
                         serv.Taxi();
                        break;
                    case "Music":
                        serv.Music();
                        break;
                    case "Weather":
                        serv.Weather();
                        break;
                    case "News":
                        serv.News();
                        break;
                    case "Images":
                        serv.Images();
                        break;

                    default:
                        throw new ArgumentException("Неверный сервис");
                }

            }

        }

        /// <summary>
        /// Точка входа для приложения.
        /// </summary>
        /// <remarks>
        /// Читает входной файл и, в зависимости от названия компании, выводит результат попытки вызвать сервис.
        /// </remarks>
        static void Main(string[] args)
        {
            //Yandex serv = new Yandex();
            ////y.Video();
            //Client c1 = new Client(serv);
            /////string res= c.getServ("Mps");
            //string Name = "Video";
            //try
            //{
            //    c1.GetServ(Name);
            //}
            //catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}


            string stInp = "";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt");
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        stInp += line;
                    }
                    if (stInp == "")
                    {
                        throw new ArgumentException("Вы ничего не ввели.");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(@"Файл input.txt не удалось найти");
                Console.ReadKey();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }

            string[] elements = stInp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Service s;

            try
            {
                switch (elements[0].ToLower())
                {
                    case "yandex":
                        s = new Yandex();
                        break;
                    case "google":
                        s = new Google();
                        break;
                    case "baidu":
                        s = new Baidu();
                        break;
                    default:
                        throw new ArgumentException("Неверная компания");
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }

            Client c = new Client(s);
            string NameOfService;
            try
            {
                for (int i = 1; i < elements.Length; i++)
                {
                    NameOfService = elements[i];
                    c.GetServ(NameOfService);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }


            Console.ReadKey();
        }
    }
}
