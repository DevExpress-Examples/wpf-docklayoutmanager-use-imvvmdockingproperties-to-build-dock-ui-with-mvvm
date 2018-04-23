using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpf.Docking;
using System.Windows.Media;

namespace WpfApplication
{
    public class PanelViewModel : IMVVMDockingProperties
    {

        public PanelViewModel(Color c)
        {
            _Color = new SolidColorBrush(c);
        }

        string IMVVMDockingProperties.TargetName
        {
            get
            {
                return "DockPanels";
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        // Fields...
        private SolidColorBrush _Color;


        public SolidColorBrush ColorBrush
        {
            get { return _Color; }
            set
            {
                _Color = value;
            }
        }
    }
}
