using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Observer
{
    class Ihbarlar
    {
        public List<Ihbar>  IhbarList { get; set; }
        public int IhbarSayisi { get; set; }
        private Timer timer = new Timer(TimeSpan.FromSeconds(1).TotalMilliseconds);
        private List<IObserver> observerListesi;

        public Ihbarlar()
        {
            timer.Elapsed += timer_Elapsed;
            IhbarList = new List<Ihbar>();
            observerListesi = new List<IObserver>();
            IhbarSayisi = IhbarList.Count;
            timer.Start(); 
        }

        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(IhbarList.Count>IhbarSayisi) // Uzak sunucudan yeni bir ihbar geldi mi?
            {
                IhbarSayisi = IhbarList.Count;
                YerelYetkililereHaberVer();
            }
        }

        public void YeniYerelYetkiliEkle(IObserver observer)
        {
            observerListesi.Add(observer);
        }

        public void YerelYetkiliKaldir(IObserver observer)
        {
            observerListesi.Remove(observer);
        }

        public void YerelYetkililereHaberVer()
        {

            foreach (var item in observerListesi)
            {
                item.IhbarBildirimi(IhbarList[IhbarList.Count - 1]);
            }
        }

        


    }
}
