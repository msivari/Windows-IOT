using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayDriver.SSD1306
{
    public static class DisplayManager
    {
        public static Display Display { get; private set; }

        public async static Task Init()
        {
            Display = new SSD1306.Display();
            await Display.Init(true);
        }

        public static void Demo()
        {
            Display.ClearDisplayBuf();
            DrawBody();
        }

        static void DrawBody()
        {
            // Row 0, and image
            Display.WriteImageDisplayBuf(DisplayImages.Connected, 0, 0);
            // Row 1 - 3
            Display.WriteLineDisplayBuf("Hello", 0, 1);
            Display.WriteLineDisplayBuf("World", 0, 2);
        }
    }
}
