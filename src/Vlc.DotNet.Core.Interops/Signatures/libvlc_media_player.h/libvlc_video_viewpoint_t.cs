using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VideoViewpointStructure
    {
        public float Yaw;
        public float Pitch;
        public float Roll;
        public float FieldOfView;
    }
}