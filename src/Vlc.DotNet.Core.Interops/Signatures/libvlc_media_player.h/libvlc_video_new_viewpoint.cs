using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get new video viewpoint
    /// </summary>
    [LibVlcFunction("libvlc_video_new_viewpoint")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr NewVideoViewpoint();
}
