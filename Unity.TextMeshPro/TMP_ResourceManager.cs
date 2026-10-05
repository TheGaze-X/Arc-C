using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public class TMP_ResourceManager
	{
		// Token: 0x060003BF RID: 959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x58CA720", Offset = "0x58C9320", VA = "0x1858CA720")]
		internal static TMP_Settings GetTextSettings()
		{
			return null;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x58CA600", Offset = "0x58C9200", VA = "0x1858CA600")]
		public static void AddFontAsset(TMP_FontAsset fontAsset)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x58CA960", Offset = "0x58C9560", VA = "0x1858CA960")]
		public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset)
		{
			return default(bool);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x58CA840", Offset = "0x58C9440", VA = "0x1858CA840")]
		internal static void RebuildFontAssetCache(int instanceID)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TMP_ResourceManager()
		{
		}

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_ResourceManager s_instance;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x8")]
		private static TMP_Settings s_TextSettings;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<TMP_FontAsset> s_FontAssetReferences;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup;
	}
}
