using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[ExcludeFromPreset]
	public class TMP_SpriteAsset : TMP_Asset
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E2")]
		public string version
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			internal set
			{
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00003768 File Offset: 0x00001968
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E3")]
		public FaceInfo faceInfo
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x58CDE50", Offset = "0x58CCA50", VA = "0x1858CDE50")]
			get
			{
				return default(FaceInfo);
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x58CDF10", Offset = "0x58CCB10", VA = "0x1858CDF10")]
			internal set
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E4")]
		public List<TMP_SpriteCharacter> spriteCharacterTable
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x58CDED0", Offset = "0x58CCAD0", VA = "0x1858CDED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
			internal set
			{
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E5")]
		public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x58CDE90", Offset = "0x58CCA90", VA = "0x1858CDE90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x22F8A60", Offset = "0x22F7660", VA = "0x1822F8A60")]
			internal set
			{
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E6")]
		public List<TMP_SpriteGlyph> spriteGlyphTable
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
			internal set
			{
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x58CBD80", Offset = "0x58CA980", VA = "0x1858CBD80")]
		private void Awake()
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x58CBE00", Offset = "0x58CAA00", VA = "0x1858CBE00")]
		private Material GetDefaultSpriteMaterial()
		{
			return null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x58CD1F0", Offset = "0x58CBDF0", VA = "0x1858CD1F0")]
		public void UpdateLookupTables()
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x58CBEE0", Offset = "0x58CAAE0", VA = "0x1858CBEE0")]
		public int GetSpriteIndexFromHashcode(int hashCode)
		{
			return 0;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x58CC020", Offset = "0x58CAC20", VA = "0x1858CC020")]
		public int GetSpriteIndexFromUnicode(uint unicode)
		{
			return 0;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x58CBF70", Offset = "0x58CAB70", VA = "0x1858CBF70")]
		public int GetSpriteIndexFromName(string name)
		{
			return 0;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x58CC970", Offset = "0x58CB570", VA = "0x1858CC970")]
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x58CC730", Offset = "0x58CB330", VA = "0x1858CC730")]
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x58CC8C0", Offset = "0x58CB4C0", VA = "0x1858CC8C0")]
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x58CC300", Offset = "0x58CAF00", VA = "0x1858CC300")]
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x58CC170", Offset = "0x58CAD70", VA = "0x1858CC170")]
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x58CC0C0", Offset = "0x58CACC0", VA = "0x1858CC0C0")]
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x58CD070", Offset = "0x58CBC70", VA = "0x1858CD070")]
		public void SortGlyphTable()
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x58CCC10", Offset = "0x58CB810", VA = "0x1858CCC10")]
		internal void SortCharacterTable()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x58CCD90", Offset = "0x58CB990", VA = "0x1858CCD90")]
		internal void SortGlyphAndCharacterTables()
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x58CD790", Offset = "0x58CC390", VA = "0x1858CD790")]
		private void UpgradeSpriteAsset()
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x58CDD70", Offset = "0x58CC970", VA = "0x1858CDD70")]
		public TMP_SpriteAsset()
		{
		}

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x30")]
		internal Dictionary<int, int> m_NameLookup;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x38")]
		internal Dictionary<uint, int> m_GlyphIndexLookup;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string m_Version;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal FaceInfo m_FaceInfo;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0xA8")]
		public Texture spriteSheet;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0xB8")]
		internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0xC8")]
		internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0xD0")]
		public List<TMP_Sprite> spriteInfoList;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		public List<TMP_SpriteAsset> fallbackSpriteAssets;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0xE0")]
		internal bool m_IsSpriteAssetLookupTablesDirty;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<int> k_searchedSpriteAssets;
	}
}
