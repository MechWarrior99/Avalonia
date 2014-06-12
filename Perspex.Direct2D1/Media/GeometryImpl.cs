﻿// -----------------------------------------------------------------------
// <copyright file="GeometryImpl.cs" company="Steven Kirk">
// Copyright 2014 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Perspex.Direct2D1.Media
{
    using System;
    using Perspex.Media;
    using SharpDX.Direct2D1;
    using Splat;

    public abstract class GeometryImpl : IGeometryImpl
    {
        public abstract Rect Bounds
        {
            get;
        }

        public SharpDX.Direct2D1.Geometry Geometry
        {
            get;
            protected set;
        }
    }
}
