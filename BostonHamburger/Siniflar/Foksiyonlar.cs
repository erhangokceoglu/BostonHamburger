using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonHamburger.Siniflar
{
    public static class Foksiyonlar
    {
        public static void Temizle(Control.ControlCollection kontroller)
        {
            foreach (var item in kontroller)
            {
                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                else if (item is TextBox)
                    ((TextBox)item).Clear();
                else if (item is RadioButton)
                    ((RadioButton)item).Checked = default;
                else if(item is NumericUpDown)
                    ((NumericUpDown)item).Value = default;  
                else if( item is Panel)
                {
                    foreach (var item2 in ((Panel)(item)).Controls)
                    {
                        if(item2 is CheckBox)
                        {
                            ((CheckBox)item2).Checked = false;    
                        }
                    }
                }
            }

        }



    }
}
