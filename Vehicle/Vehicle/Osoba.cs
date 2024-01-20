using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Osoba
    {
        private IInstrument? _instrument;

        public string Imie { get; set; }

        public void UstawInstrument(IInstrument instrument)
        {
            _instrument = instrument;
        }

        public void Graj()
        {
            if (_instrument == null)
            {
                Console.WriteLine("Brak instrumentu do grania");
                return;
            }
            _instrument.Graj();
        }
    }
}
