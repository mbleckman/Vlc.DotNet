using System;
using System.Runtime.InteropServices;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Update the video viewpoint
    /// </summary>
    [LibVlcFunction("libvlc_video_update_viewpoint")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int UpdateViewpoint(IntPtr mediaPlayerInstance, IntPtr viewpoint, bool absolute);
}

