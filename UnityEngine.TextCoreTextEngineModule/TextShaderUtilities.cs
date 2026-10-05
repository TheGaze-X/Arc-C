using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public static class TextShaderUtilities
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000042")]
		internal static Shader ShaderRef_MobileSDF
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x5A01B00", Offset = "0x5A00700", VA = "0x185A01B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000043")]
		internal static Shader ShaderRef_MobileBitmap
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x5A01940", Offset = "0x5A00540", VA = "0x185A01940")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5A00520", Offset = "0x59FF120", VA = "0x185A00520")]
		internal static void GetShaderPropertyIDs()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x5A01060", Offset = "0x59FFC60", VA = "0x185A01060")]
		private static void UpdateShaderRatios(Material mat)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x5A00EA0", Offset = "0x59FFAA0", VA = "0x185A00EA0")]
		internal static bool IsMaskingEnabled(Material material)
		{
			return default(bool);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x59FFC00", Offset = "0x59FE800", VA = "0x1859FFC00")]
		internal static float GetPadding(Material material, bool enableExtraPadding, bool isBold)
		{
			return 0f;
		}

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x0")]
		public static int ID_MainTex;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x4")]
		public static int ID_FaceTex;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x8")]
		public static int ID_FaceColor;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0xC")]
		public static int ID_FaceDilate;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x10")]
		public static int ID_Shininess;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x14")]
		public static int ID_UnderlayColor;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x18")]
		public static int ID_UnderlayOffsetX;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x1C")]
		public static int ID_UnderlayOffsetY;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x20")]
		public static int ID_UnderlayDilate;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x24")]
		public static int ID_UnderlaySoftness;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x28")]
		public static int ID_WeightNormal;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x2C")]
		public static int ID_WeightBold;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x30")]
		public static int ID_OutlineTex;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x34")]
		public static int ID_OutlineWidth;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x38")]
		public static int ID_OutlineSoftness;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x3C")]
		public static int ID_OutlineColor;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x40")]
		public static int ID_Outline2Color;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x44")]
		public static int ID_Outline2Width;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x48")]
		public static int ID_Padding;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x4C")]
		public static int ID_GradientScale;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x50")]
		public static int ID_ScaleX;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x54")]
		public static int ID_ScaleY;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x58")]
		public static int ID_PerspectiveFilter;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x5C")]
		public static int ID_Sharpness;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x60")]
		public static int ID_TextureWidth;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x64")]
		public static int ID_TextureHeight;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x68")]
		public static int ID_BevelAmount;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x6C")]
		public static int ID_GlowColor;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x70")]
		public static int ID_GlowOffset;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x74")]
		public static int ID_GlowPower;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x78")]
		public static int ID_GlowOuter;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x7C")]
		public static int ID_GlowInner;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x80")]
		public static int ID_LightAngle;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x84")]
		public static int ID_EnvMap;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x88")]
		public static int ID_EnvMatrix;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x8C")]
		public static int ID_EnvMatrixRotation;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x90")]
		public static int ID_MaskCoord;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x94")]
		public static int ID_ClipRect;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x98")]
		public static int ID_MaskSoftnessX;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x9C")]
		public static int ID_MaskSoftnessY;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0xA0")]
		public static int ID_VertexOffsetX;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0xA4")]
		public static int ID_VertexOffsetY;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0xA8")]
		public static int ID_UseClipRect;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0xAC")]
		public static int ID_StencilID;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0xB0")]
		public static int ID_StencilOp;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0xB4")]
		public static int ID_StencilComp;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0xB8")]
		public static int ID_StencilReadMask;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0xBC")]
		public static int ID_StencilWriteMask;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0xC0")]
		public static int ID_ShaderFlags;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0xC4")]
		public static int ID_ScaleRatio_A;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xC8")]
		public static int ID_ScaleRatio_B;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0xCC")]
		public static int ID_ScaleRatio_C;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0xD0")]
		public static string Keyword_Bevel;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0xD8")]
		public static string Keyword_Glow;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0xE0")]
		public static string Keyword_Underlay;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0xE8")]
		public static string Keyword_Ratios;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0xF0")]
		public static string Keyword_MASK_SOFT;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0xF8")]
		public static string Keyword_MASK_HARD;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x100")]
		public static string Keyword_MASK_TEX;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x108")]
		public static string Keyword_Outline;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x110")]
		public static string ShaderTag_ZTestMode;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x118")]
		public static string ShaderTag_CullMode;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x120")]
		private static float m_clamp;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x124")]
		public static bool isInitialized;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x128")]
		private static Shader k_ShaderRef_MobileSDF;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x130")]
		private static Shader k_ShaderRef_MobileBitmap;
	}
}
