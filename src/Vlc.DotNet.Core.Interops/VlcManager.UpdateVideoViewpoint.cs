using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public int UpdateVideoViewpoint(VlcMediaPlayerInstance mediaPlayerInstance, VideoViewpointStructure userViewpoint, bool absolute)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");

            IntPtr viewpointPtr = GetInteropDelegate<NewVideoViewpoint>().Invoke();

#if NET20 || NET35 || NET40 || NET45
            Marshal.StructureToPtr(userViewpoint, viewpointPtr, false);
#else
            Marshal.StructureToPtr<VideoViewpointStructure>(userViewpoint, viewpointPtr, false);
#endif

            int success = GetInteropDelegate<UpdateViewpoint>().Invoke(mediaPlayerInstance, viewpointPtr, absolute);
            Free(viewpointPtr);

            return success;
        }
    }
}