using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Resources;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Cosmos.Core;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using SideralOS;


namespace SideralOS
{
    public class Imagens
    {
    
       

        //.bmp
        [ManifestResourceStream(ResourceName = "SideralOS.Resources.SideralOSOficial.bmp")]
        public static byte[] SideralLogo;

        [ManifestResourceStream(ResourceName = "SideralOS.Resources.QRsite")]
        public static byte[] QRsite;

        [ManifestResourceStream(ResourceName = "SideralOS.Resources.QRgithub.bmp")]
        public static byte[] QRgithub;


        //wallpaper = new Bitmap(wallpaperbyte);
        //canvas.DrawImage(wallpaper, 0, 0);

        public void DrawString(Canvas canvas, string str, Pen pen, Pen BG, int x, int y, Cosmos.System.Graphics.Fonts.Font font)
        {
            canvas.DrawFilledRectangle(BG, new Cosmos.System.Graphics.Point(x, y), x + (str.Length * 4), 16);
            canvas.DrawString(str, font, pen, x, y);
        }

        public void INIT()
        {

            Canvas canvas = FullScreenCanvas.GetFullScreenCanvas();
            Bitmap Sideral = new Bitmap(SideralLogo);
            Bitmap Site = new Bitmap(QRsite);
            Bitmap GitHub = new Bitmap(QRgithub);
            

        }

        

    }
}