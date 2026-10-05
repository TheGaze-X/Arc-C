using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public static class ShaderUtilities
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000DE")]
		internal static Shader ShaderRef_MobileSDF
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x58C4270", Offset = "0x58C2E70", VA = "0x1858C4270")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000DF")]
		internal static Shader ShaderRef_MobileBitmap
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x58C4150", Offset = "0x58C2D50", VA = "0x1858C4150")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x58C2B60", Offset = "0x58C1760", VA = "0x1858C2B60")]
		public static void GetShaderPropertyIDs()
		{
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x58C3870", Offset = "0x58C2470", VA = "0x1858C3870")]
		public static void UpdateShaderRatios(Material mat)
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x58C1650", Offset = "0x58C0250", VA = "0x1858C1650")]
		public static Vector4 GetFontExtent(Material material)
		{
			return default(Vector4);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x58C36B0", Offset = "0x58C22B0", VA = "0x1858C36B0")]
		public static bool IsMaskingEnabled(Material material)
		{
			return default(bool);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x58C2230", Offset = "0x58C0E30", VA = "0x1858C2230")]
		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold)
		{
			return 0f;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x58C16A0", Offset = "0x58C02A0", VA = "0x1858C16A0")]
		public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold)
		{
			return 0f;
		}

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x0")]
		public static int ID_MainTex;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x4")]
		public static int ID_FaceTex;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x8")]
		public static int ID_FaceColor;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0xC")]
		public static int ID_FaceDilate;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x10")]
		public static int ID_Shininess;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x14")]
		public static int ID_UnderlayColor;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x18")]
		public static int ID_UnderlayOffsetX;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x1C")]
		public static int ID_UnderlayOffsetY;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x20")]
		public static int ID_UnderlayDilate;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x24")]
		public static int ID_UnderlaySoftness;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x28")]
		public static int ID_UnderlayOffset;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x2C")]
		public static int ID_UnderlayIsoPerimeter;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x30")]
		public static int ID_WeightNormal;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x34")]
		public static int ID_WeightBold;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x38")]
		public static int ID_OutlineTex;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x3C")]
		public static int ID_OutlineWidth;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x40")]
		public static int ID_OutlineSoftness;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x44")]
		public static int ID_OutlineColor;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x48")]
		public static int ID_Outline2Color;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x4C")]
		public static int ID_Outline2Width;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x50")]
		public static int ID_Padding;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x54")]
		public static int ID_GradientScale;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x58")]
		public static int ID_ScaleX;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x5C")]
		public static int ID_ScaleY;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x60")]
		public static int ID_PerspectiveFilter;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x64")]
		public static int ID_Sharpness;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x68")]
		public static int ID_TextureWidth;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x6C")]
		public static int ID_TextureHeight;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x70")]
		public static int ID_BevelAmount;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x74")]
		public static int ID_GlowColor;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x78")]
		public static int ID_GlowOffset;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x7C")]
		public static int ID_GlowPower;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x80")]
		public static int ID_GlowOuter;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x84")]
		public static int ID_GlowInner;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x88")]
		public static int ID_LightAngle;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x8C")]
		public static int ID_EnvMap;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x90")]
		public static int ID_EnvMatrix;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x94")]
		public static int ID_EnvMatrixRotation;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x98")]
		public static int ID_MaskCoord;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x9C")]
		public static int ID_ClipRect;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0xA0")]
		public static int ID_MaskSoftnessX;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0xA4")]
		public static int ID_MaskSoftnessY;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0xA8")]
		public static int ID_VertexOffsetX;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0xAC")]
		public static int ID_VertexOffsetY;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0xB0")]
		public static int ID_UseClipRect;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0xB4")]
		public static int ID_StencilID;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0xB8")]
		public static int ID_StencilOp;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0xBC")]
		public static int ID_StencilComp;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0xC0")]
		public static int ID_StencilReadMask;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0xC4")]
		public static int ID_StencilWriteMask;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0xC8")]
		public static int ID_ShaderFlags;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0xCC")]
		public static int ID_ScaleRatio_A;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0xD0")]
		public static int ID_ScaleRatio_B;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0xD4")]
		public static int ID_ScaleRatio_C;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0xD8")]
		public static string Keyword_Bevel;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0xE0")]
		public static string Keyword_Glow;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0xE8")]
		public static string Keyword_Underlay;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0xF0")]
		public static string Keyword_Ratios;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0xF8")]
		public static string Keyword_MASK_SOFT;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x100")]
		public static string Keyword_MASK_HARD;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x108")]
		public static string Keyword_MASK_TEX;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x110")]
		public static string Keyword_Outline;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x118")]
		public static string ShaderTag_ZTestMode;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x120")]
		public static string ShaderTag_CullMode;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x128")]
		private static float m_clamp;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x12C")]
		public static bool isInitialized;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x130")]
		private static Shader k_ShaderRef_MobileSDF;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x138")]
		private static Shader k_ShaderRef_MobileBitmap;
	}
}
