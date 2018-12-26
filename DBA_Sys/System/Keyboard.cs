using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DBA_Sys
{
    public class Keyboard
    {

        const int PauseBetweenStrokes = 50;
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        const int KEY_DOWN_EVENT = 0x0001; //Key down flag
        const int KEY_UP_EVENT = 0x0002; //Key up flag

        public static void HoldKey(byte key, int duration)
        {
            keybd_event(key, 0, KEY_DOWN_EVENT, 0);
            System.Threading.Thread.Sleep(duration);
            keybd_event(key, 0, KEY_UP_EVENT, 0);
        }

        public static void WithKey(byte key1, byte key2, int duration)
        {
            keybd_event(key1, 0, KEY_DOWN_EVENT, 0);
            keybd_event(key2, 0, KEY_DOWN_EVENT, 0);
            System.Threading.Thread.Sleep(duration);
            keybd_event(key2, 0, KEY_UP_EVENT, 0);
            keybd_event(key1, 0, KEY_UP_EVENT, 0);
        }
    }
}

///////////////////////Virtual Key Codes///////////////////////

//VK_LBUTTON - Left Mouse Button
//VK_RBUTTON - Right Mouse Button

//VK_TAB - TAB Key
//VK_RETRUN - ENTER Key
//Left SHIFT - 0xA0
//Left Ctrl - 0xA2
//VK_MENU - ALT Key
//VK_ESCAPE - ESC Key
//VK_SPACE - Space Bar
//VK_PRIOR - PAGE UP Key
//VK_END - END Key
//INSERT - 0x2D
//VK_DELETE - DEL Key


//0x31 - 1
//0x32 - 2
//0x33 - 3
//0x34 - 4
//0x35 - 5
//0x36 - 6
//0x37 - 7
//0x38 - 8
//0x39 - 9
//0x30 - 0

//0x41 - A Key
//0x42 - B Key
//0x43 - C Key
//0x44 - D key
//0x45 - E key
//0x46 - F key
//0x47 - G key
//0x48 - H key
//0x49 - I key
//0x4A - J key
//0x4B - K key
//0x4C - L key
//0x4D - M key
//0x4E - N key
//0x4F - O key
//0x50 - P key
//0x51 - Q key
//0x52 - R key
//0x53 - S key
//0x54 - T key
//0x55 - U key
//0x56 - V key
//0x57 - W key
//0x58 - X key
//0x59 - Y key
//0x5A - Z key

/////////////////////////////////////////////////////////////
