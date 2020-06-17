using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    class BelediyeyeBildirObserver : IObserver
    {
        public void IhbarBildirimi(Ihbar ihbar)
        {
            MessageBox.Show(String.Format("[{3}] {0} ilinin {1} ilçesinde sosyal mesafenin korunmadığına dair ihbar geldi! " +
                "\n\n Açık adres: {2} ", 
                ihbar.Sehir, ihbar.Ilce, ihbar.AcikAdres, ihbar.IhbarTarihi), 
                "BELEDIYE BILDIRIMI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
