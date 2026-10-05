using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public static class TextureFormatUtilities
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x584EB10", Offset = "0x584D710", VA = "0x18584EB10")]
		private static bool IsObsolete(object value)
		{
			return default(bool);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x584E890", Offset = "0x584D490", VA = "0x18584E890")]
		public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
		{
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x584ECF0", Offset = "0x584D8F0", VA = "0x18584ECF0")]
		internal static bool IsSupported(this RenderTextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x584EC60", Offset = "0x584D860", VA = "0x18584EC60")]
		internal static bool IsSupported(this TextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, bool> s_SupportedRenderTextureFormats;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<int, bool> s_SupportedTextureFormats;
	}
}
