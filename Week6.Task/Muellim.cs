using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Task
{
    class Muellim
    {
        DateTime date = DateTime.Now;
        private string vezife;
        public int Id { get; } = new Random().Next(1, 1000);
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Vezife
        {
            get => vezife;
            set => vezife = String.IsNullOrWhiteSpace(value) ? "Teacher" : value;
        }
        public string DogumTarixi { get; set; }
        public string IslediyiYer { get; set; }
        public string IseBaslamaTarixi()
        {
            if (Yashi() == 23)
            {
                string startWork = date.ToString("dd/MM/yyyy");
                return $"Id-{Id}: {Ad} {Soyad} siz artiq {Vezife} vezifesine, {startWork} tarixinden ishe bashladiz.";
            }
            else
                return "Yashiniz uygun gelmir.";
        }
        public int Yashi()
        {
            DateTime dt;
            DateTime.TryParse(DogumTarixi, out dt);
            TimeSpan yashFerqi = date - dt;
            return yashFerqi.Days / 365;
        }
    }
}
