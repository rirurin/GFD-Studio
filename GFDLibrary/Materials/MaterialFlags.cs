﻿namespace GFDLibrary.Materials
{
    public enum METAPHOR_MaterialFlags0 : uint
    {
        FLAG0_HDR = 0x00000001,
        FLAG0_IMMEDIATE = 0x00000002,
        FLAG0_INFINITE = 0x00000004,
        FLAG0_LIGHT0_DIRECTION = 0x00000010,
        FLAG0_LIGHT0_POINT = 0x00000020,
        FLAG0_LIGHT0_SPOT = 0x00000040,
        FLAG0_LIGHT1_DIRECTION = 0x00000080,
        FLAG0_LIGHT1_POINT = 0x00000100,
        FLAG0_LIGHT1_SPOT = 0x00000200,
        FLAG0_LIGHT2_DIRECTION = 0x00000400,
        FLAG0_LIGHT2_POINT = 0x00000800,
        FLAG0_LIGHT2_SPOT = 0x00001000,
        FLAG0_COLOR_OP_ADD = 0x00002000,
        FLAG0_CONSTANTCOLOR = 0x00008000,
        FLAG0_TEXCOORD0IN = 0x00010000,
        FLAG0_TEXCOORD1IN = 0x00020000,
        FLAG0_TEXCOORD2IN = 0x00040000,
        FLAG0_TEXCOORD0OUT = 0x00080000,
        FLAG0_TEXCOORD1OUT = 0x00100000,
        FLAG0_TEXCOORD2OUT = 0x00200000,
        FLAG0_EDGE_REMOVAL_LIGHT_YAXIS = 0x00800000,
        FLAG0_COLOR_OP_LERP = 0x01000000,
        FLAG0_GRAYSCALE = 0x02000000,
        FLAG0_ALPHAKILL = 0x04000000,
        FLAG0_OUTLINE_ATTENUATION_INVALID = 0x08000000,
        FLAG0_TEMPERARE = 0x10000000,
        FLAG0_DEFERRED = 0x20000000,
        FLAG0_OUTLINE = 0x40000000,
        FLAG0_SRGB = 0x80000000,
    }
    public enum METAPHOR_MaterialFlags1 : uint
    {
        FLAG1_MATERIAL_SHADOW = 0x00000001,
        FLAG1_MATERIAL_AMBDIFF = 0x00000002,
        FLAG1_MATERIAL_EMISSIVE = 0x00000004,
        FLAG1_MATERIAL_MULTIPLE_MOD = 0x00000008,
        FLAG1_MATERIAL_SPECULAR = 0x00000010,
        FLAG1_MATERIAL_FOG = 0x00000020,
        FLAG1_MATERIAL_REFLECTION = 0x00000040,
        FLAG1_MATERIAL_REFLECTION_LERP = 0x00000080,
        FLAG1_MATERIAL_VERTEXCOLOR = 0x00000100,
        FLAG1_MATERIAL_TRANSPARENCY = 0x00000200,
        FLAG1_MATERIAL_HEIGHTFOG = 0x00000400,
        FLAG1_MATERIAL_LIGHT = 0x00000800,
        FLAG1_MATERIAL_UV0TRANSFORM = 0x00001000,
        FLAG1_MATERIAL_UV1TRANSFORM = 0x00002000,
        FLAG1_MATERIAL_UV2TRANSFORM = 0x00004000,
        FLAG1_MATERIAL_OCCLUSION = 0x00008000,
        FLAG1_EDGE_REFERENCE_LIGHTALPHA = 0x00010000,
        FLAG1_LIGHTMAP_MODULATE2 = 0x00020000,
        FLAG1_MATERIAL_REFLECTION_ADD = 0x00040000,
        FLAG1_EDGE_REFERENCE_LIGHTCOLOR = 0x00080000,
        FLAG1_TEXTURE1 = 0x00400000,
        FLAG1_TEXTURE2 = 0x00800000,
        FLAG1_TEXTURE3 = 0x01000000,
        FLAG1_TEXTURE4 = 0x02000000,
        FLAG1_TEXTURE5 = 0x04000000,
        FLAG1_TEXTURE6 = 0x08000000,
        FLAG1_TEXTURE7 = 0x10000000,
        FLAG1_TEXTURE8 = 0x20000000,
        FLAG1_TEXTURE9 = 0x40000000,
        FLAG1_TEXTURE10 = 0x80000000,
    }
    public enum METAPHOR_MaterialFlags2 : uint
    {
        FLAG2_HDR_TONEMAP = 0x00000001,
        FLAG2_HDR_STAR = 0x00000002,
        FLAG2_LIGHTMAP_MODULATE = 0x00000004,
        FLAG2_ATEST_NEVER = 0x00000008,
        FLAG2_ATEST_EQUAL = 0x00000010,
        FLAG2_ATEST_NOTEQUAL = 0x00000020,
        FLAG2_ATEST_LESS_LEQUAL = 0x00000040,
        FLAG2_ATEST_GREATER_GEQUAL = 0x00000080,
        FLAG2_GAMMA = 0x00000100,
        FLAG2_MATERIAL_MULTIPLE_SEMI = 0x00000200,
        FLAG2_MATERIAL_MULTIPLE_ADD = 0x00000400,
        FLAG2_MATERIAL_MULTIPLE_SUB = 0x00000800,
        FLAG2_MATERIAL_MODULATE_FOG = 0x00001000,
        FLAG2_EDGE_REFERENCE_NORMALMAP = 0x00002000,
        FLAG2_SPECULAR_NORMALMAPALPHA = 0x00004000,
        FLAG2_REFLECTION_CASTER = 0x00008000,
        FLAG2_WATER_REFLECTION = 0x00010000,
        FLAG2_WATER_REFRACTION = 0x00020000,
        FLAG2_WATER_FRESNEL = 0x00040000,
        FLAG2_EDGE_BACKLIGHT = 0x00080000,
        FLAG2_EDGE_SEMITRANS = 0x00100000,
        FLAG2_TOON_REFERENCE_NORMALMAP = 0x00200000,
        FLAG2_TOON_REMOVAL_LIGHT_YAXIS = 0x00400000,
        FLAG2_EDGE_CAVERNMAP = 0x00800000,
        FLAG2_MULTITEXTURE_AS_MASK = 0x01000000,
        FLAG2_PUNCHTHROUGH = 0x02000000,
        FLAG2_EDGE_REFERENCE_NORMALALPHA = 0x04000000,
        FLAG2_EDGE_REFERENCE_DIFFUSEALPHA = 0x08000000,
        FLAG2_SKY = 0x10000000,
        FLAG2_BLEND_CLEARCOLOR = 0x20000000,
        FLAG2_SOFT_PARTICLE = 0x40000000,
        FLAG2_APPLY_PBR_LIGHT = 0x80000000,
    }
}
