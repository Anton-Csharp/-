using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace магазин_тех
{
    public partial class Form3 : Form
    {
        UserControl1[] UserControl1;
        
        public Form3()
        {
            InitializeComponent();
            UserControl1= new UserControl1[4];
            UserControl1[0] = new UserControl1(this) { Nameitem = "Poco X7 Pro", Priceitem = "1100", Imageitem = Properties.Resources.i };
            UserControl1[1] = new UserControl1(this) { Nameitem = "Redmi 9C NFC", Priceitem = "9000", Imageitem = Properties.Resources.i__1_  };
            UserControl1[2] = new UserControl1(this) { Nameitem = "Iphone 11", Priceitem = "800", Imageitem = Properties.Resources.i__2__1  };
            UserControl1[3] = new UserControl1(this) { Nameitem = "Vivo X200 pro", Priceitem = "3299", Imageitem = Properties.Resources.i__3_  };
            UserControl1[4] = new UserControl1(this) { Nameitem = "Sony Erikson", Priceitem = "300", Imageitem = Properties.Resources.i__4_  };
        }

    }
}
