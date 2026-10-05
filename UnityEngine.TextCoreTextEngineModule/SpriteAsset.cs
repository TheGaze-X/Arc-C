using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[HelpURL("https://docs.unity3d.com/2021.3/Documentation/Manual/UIE-sprite.html")]
	[ExcludeFromPreset]
	public class SpriteAsset : TextAsset
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public FaceInfo faceInfo
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x59F6C40", Offset = "0x59F5840", VA = "0x1859F6C40")]
			get
			{
				return default(FaceInfo);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x58CDF10", Offset = "0x58CCB10", VA = "0x1858CDF10")]
			internal set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public Texture spriteSheet
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x5997640", Offset = "0x5996240", VA = "0x185997640")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
			internal set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public List<SpriteCharacter> spriteCharacterTable
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x59F6CC0", Offset = "0x59F58C0", VA = "0x1859F6CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
			internal set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x59F6C80", Offset = "0x59F5880", VA = "0x1859F6C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x22F8A60", Offset = "0x22F7660", VA = "0x1822F8A60")]
			internal set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public List<SpriteGlyph> spriteGlyphTable
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x5997720", Offset = "0x5996320", VA = "0x185997720")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
			internal set
			{
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Awake()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x59F6600", Offset = "0x59F5200", VA = "0x1859F6600")]
		public void UpdateLookupTables()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x59F53F0", Offset = "0x59F3FF0", VA = "0x1859F53F0")]
		public int GetSpriteIndexFromHashcode(int hashCode)
		{
			return 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x59F54C0", Offset = "0x59F40C0", VA = "0x1859F54C0")]
		public int GetSpriteIndexFromUnicode(uint unicode)
		{
			return 0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x59F5480", Offset = "0x59F4080", VA = "0x1859F5480")]
		public int GetSpriteIndexFromName(string name)
		{
			return 0;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x59F5E40", Offset = "0x59F4A40", VA = "0x1859F5E40")]
		public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x59F5C00", Offset = "0x59F4800", VA = "0x1859F5C00")]
		private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x59F5D90", Offset = "0x59F4990", VA = "0x1859F5D90")]
		private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x59F57B0", Offset = "0x59F43B0", VA = "0x1859F57B0")]
		public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, [Optional] TextSettings textSettings)
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x59F5560", Offset = "0x59F4160", VA = "0x1859F5560")]
		private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x59F5700", Offset = "0x59F4300", VA = "0x1859F5700")]
		private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x59F6480", Offset = "0x59F5080", VA = "0x1859F6480")]
		public void SortGlyphTable()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x59F6020", Offset = "0x59F4C20", VA = "0x1859F6020")]
		internal void SortCharacterTable()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x59F61A0", Offset = "0x59F4DA0", VA = "0x1859F61A0")]
		internal void SortGlyphAndCharacterTables()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x59F6B60", Offset = "0x59F5760", VA = "0x1859F6B60")]
		public SpriteAsset()
		{
		}

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Dictionary<int, int> m_NameLookup;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal Dictionary<uint, int> m_GlyphIndexLookup;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal FaceInfo m_FaceInfo;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[FormerlySerializedAs("spriteSheet")]
		internal Texture m_SpriteAtlasTexture;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<SpriteCharacter> m_SpriteCharacterTable;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<SpriteGlyph> m_SpriteGlyphTable;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		public List<SpriteAsset> fallbackSpriteAssets;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal bool m_IsSpriteAssetLookupTablesDirty;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<int> k_searchedSpriteAssets;
	}
}
