using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualMapper {
    class MapViewer : PictureBox {

        public ColorMap[] remaptable { get; protected set; }

        public Bitmap bmp;

        public MapViewer() : base() {

        }

        protected override void OnPaint(PaintEventArgs pe) {

            if(bmp == null) { return; }

            ColorMap[] colorMap = new ColorMap[1];
            colorMap[0] = new ColorMap();
            colorMap[0].OldColor = Color.Red;
            colorMap[0].NewColor = Color.Green;
            ImageAttributes attr = new ImageAttributes();
            attr.SetRemapTable(colorMap);
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            pe.Graphics.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            
        }
    }
}
