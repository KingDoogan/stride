﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering.Voxels
{
    public static partial class Voxel2x2x2MipmapKeys
    {
        public static readonly ValueParameterKey<Vector3> ReadOffset = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<Vector3> WriteOffset = ParameterKeys.NewValue<Vector3>();
        public static readonly ObjectParameterKey<Texture> ReadTex = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> WriteTex = ParameterKeys.NewObject<Texture>();
    }
}