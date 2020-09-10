﻿using Android.Content;
using APath = Android.Graphics.Path;

namespace System.Maui.Controls.Primitives
{
    public class NativeEllipse : NativeShape
    {
        public NativeEllipse(Context context) : base(context)
        {
            UpdateShape();
        }

        void UpdateShape()
        {
            var path = new APath();
            path.AddCircle(0, 0, 1, APath.Direction.Cw);
            UpdateShape(path);
        }
    }
}