﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskTopSBS
{
    [Flags]
    public enum WS : ulong
    {
        WS_BORDER = 0x00800000L,
        WS_CAPTION = 0x00C00000L,
        WS_CHILD = 0x40000000L,
        WS_CHILDWINDOW = 0x40000000L,
        WS_CLIPCHILDREN = 0x02000000L,
        WS_CLIPSIBLINGS = 0x04000000L,
        WS_DISABLED = 0x08000000L,
        WS_DLGFRAME = 0x00400000L,

        WS_GROUP =
        0x00020000L,

        WS_HSCROLL =
        0x00100000L,

        WS_ICONIC =
        0x20000000L,

        WS_MAXIMIZE =
        0x01000000L,

        WS_MAXIMIZEBOX =
        0x00010000L,

        WS_MINIMIZE =
        0x20000000L,

        WS_MINIMIZEBOX =
        0x00020000L,

        WS_OVERLAPPED =
        0x00000000L,


        WS_POPUP =
        0x80000000L,


        WS_SIZEBOX =
        0x00040000L,

        WS_SYSMENU =
        0x00080000L,

        WS_TABSTOP =
        0x00010000L,

        WS_THICKFRAME =
        0x00040000L,

        WS_TILED =
        0x00000000L,


        WS_VISIBLE =
        0x10000000L,

        WS_VSCROLL =
        0x00200000L,

    }

    [Flags]
    public enum WSEX : ulong
    {
        WS_EX_ACCEPTFILES =
        0x00000010L,

        WS_EX_APPWINDOW =
        0x00040000L,

        WS_EX_CLIENTEDGE =
        0x00000200L,

        WS_EX_COMPOSITED =
        0x02000000L,

        WS_EX_CONTEXTHELP =
        0x00000400L,

        WS_EX_CONTROLPARENT =
        0x00010000L,

        WS_EX_DLGMODALFRAME =
        0x00000001L,

        WS_EX_LAYERED =
        0x00080000,

        WS_EX_LAYOUTRTL =
        0x00400000L,

        WS_EX_LEFT =
        0x00000000L,

        WS_EX_LEFTSCROLLBAR =
        0x00004000L,

        WS_EX_LTRREADING =
        0x00000000L,

        WS_EX_MDICHILD =
        0x00000040L,

        WS_EX_NOACTIVATE =
        0x08000000L,

        WS_EX_NOINHERITLAYOUT =
        0x00100000L,

        WS_EX_NOPARENTNOTIFY =
        0x00000004L,

        WS_EX_NOREDIRECTIONBITMAP =
        0x00200000L,

        WS_EX_RIGHT =
        0x00001000L,

        WS_EX_RIGHTSCROLLBAR =
        0x00000000L,

        WS_EX_RTLREADING =
        0x00002000L,

        WS_EX_STATICEDGE =
        0x00020000L,

        WS_EX_TOOLWINDOW =
        0x00000080L,

        WS_EX_TOPMOST =
        0x00000008L,

        WS_EX_TRANSPARENT =
        0x00000020L,

        WS_EX_WINDOWEDGE =
        0x00000100L,
    }


}
