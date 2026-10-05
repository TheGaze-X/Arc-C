using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[ExcludeFromPreset]
	[Serializable]
	public class TMP_FontAsset : TMP_Asset
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		public string version
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			internal set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		public Font sourceFontFile
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			internal set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		public AtlasPopulationMode atlasPopulationMode
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return AtlasPopulationMode.Static;
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public FaceInfo faceInfo
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x55DBE50", Offset = "0x55DAA50", VA = "0x1855DBE50")]
			get
			{
				return default(FaceInfo);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x5892600", Offset = "0x5891200", VA = "0x185892600")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public List<Glyph> glyphTable
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
			internal set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000052")]
		public Dictionary<uint, Glyph> glyphLookupTable
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x5892540", Offset = "0x5891140", VA = "0x185892540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public List<TMP_Character> characterTable
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
			internal set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000054")]
		public Dictionary<uint, TMP_Character> characterLookupTable
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x58924B0", Offset = "0x58910B0", VA = "0x1858924B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000055")]
		public Texture2D atlasTexture
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x58923F0", Offset = "0x5890FF0", VA = "0x1858923F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public Texture2D[] atlasTextures
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x4D6CA00", Offset = "0x4D6B600", VA = "0x184D6CA00")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x17000057")]
		public int atlasTextureCount
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x58923E0", Offset = "0x5890FE0", VA = "0x1858923E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public bool isMultiAtlasTexturesEnabled
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x762350", Offset = "0x760F50", VA = "0x180762350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x5892650", Offset = "0x5891250", VA = "0x185892650")]
			set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		internal bool clearDynamicDataOnBuild
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x762340", Offset = "0x760F40", VA = "0x180762340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x58925B0", Offset = "0x58911B0", VA = "0x1858925B0")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		internal List<GlyphRect> usedGlyphRects
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x4D6CBB0", Offset = "0x4D6B7B0", VA = "0x184D6CBB0")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		internal List<GlyphRect> freeGlyphRects
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x4D6C780", Offset = "0x4D6B380", VA = "0x184D6C780")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x4D6CFE0", Offset = "0x4D6BBE0", VA = "0x184D6CFE0")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005C")]
		[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
		public FaceInfo_Legacy fontInfo
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public int atlasWidth
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x58924A0", Offset = "0x58910A0", VA = "0x1858924A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x58925A0", Offset = "0x58911A0", VA = "0x1858925A0")]
			internal set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000029A0 File Offset: 0x00000BA0
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public int atlasHeight
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x53B40C0", Offset = "0x53B2CC0", VA = "0x1853B40C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x5892580", Offset = "0x5891180", VA = "0x185892580")]
			internal set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000029B8 File Offset: 0x00000BB8
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		public int atlasPadding
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x58923D0", Offset = "0x5890FD0", VA = "0x1858923D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x5892590", Offset = "0x5891190", VA = "0x185892590")]
			internal set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public GlyphRenderMode atlasRenderMode
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x4E843D0", Offset = "0x4E82FD0", VA = "0x184E843D0")]
			get
			{
				return (GlyphRenderMode)0;
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x4E84960", Offset = "0x4E83560", VA = "0x184E84960")]
			internal set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public TMP_FontFeatureTable fontFeatureTable
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
			internal set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public List<TMP_FontAsset> fallbackFontAssetTable
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x55FB9F0", Offset = "0x55FA5F0", VA = "0x1855FB9F0")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000029E8 File Offset: 0x00000BE8
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public FontAssetCreationSettings creationSettings
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x58924F0", Offset = "0x58910F0", VA = "0x1858924F0")]
			get
			{
				return default(FontAssetCreationSettings);
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x58925C0", Offset = "0x58911C0", VA = "0x1858925C0")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public TMP_FontWeightPair[] fontWeightTable
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			internal set
			{
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x588A120", Offset = "0x5888D20", VA = "0x18588A120")]
		public static TMP_FontAsset CreateFontAsset(Font font)
		{
			return null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x588A1A0", Offset = "0x5888DA0", VA = "0x18588A1A0")]
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			return null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x5889960", Offset = "0x5888560", VA = "0x185889960")]
		private void Awake()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x588C290", Offset = "0x588AE90", VA = "0x18588C290")]
		public void ReadFontAssetDefinition()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x588BDF0", Offset = "0x588A9F0", VA = "0x18588BDF0")]
		internal void InitializeDictionaryLookupTables()
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x588BE20", Offset = "0x588AA20", VA = "0x18588BE20")]
		internal void InitializeGlyphLookupDictionary()
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x588BB80", Offset = "0x588A780", VA = "0x18588BB80")]
		internal void InitializeCharacterLookupDictionary()
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x588C0C0", Offset = "0x588ACC0", VA = "0x18588C0C0")]
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x58895E0", Offset = "0x58881E0", VA = "0x1858895E0")]
		internal void AddSynthesizedCharactersAndFaceMetrics()
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x58892B0", Offset = "0x5887EB0", VA = "0x1858892B0")]
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x5889200", Offset = "0x5887E00", VA = "0x185889200")]
		internal void AddCharacterToLookupCache(uint unicode, TMP_Character character)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x588CCA0", Offset = "0x588B8A0", VA = "0x18588CCA0")]
		internal void SortCharacterTable()
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x588CE50", Offset = "0x588BA50", VA = "0x18588CE50")]
		internal void SortGlyphTable()
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x588CE20", Offset = "0x588BA20", VA = "0x18588CE20")]
		internal void SortFontFeatureTable()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x588C9B0", Offset = "0x588B5B0", VA = "0x18588C9B0")]
		internal void SortAllTables()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x588AD00", Offset = "0x5889900", VA = "0x18588AD00")]
		public bool HasCharacter(int character)
		{
			return default(bool);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x588AD60", Offset = "0x5889960", VA = "0x18588AD60")]
		public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default(bool);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x588AAC0", Offset = "0x58896C0", VA = "0x18588AAC0")]
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default(bool);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x588B2E0", Offset = "0x5889EE0", VA = "0x18588B2E0")]
		public bool HasCharacters(string text, out List<char> missingCharacters)
		{
			return default(bool);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x588B450", Offset = "0x588A050", VA = "0x18588B450")]
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x588BAD0", Offset = "0x588A6D0", VA = "0x18588BAD0")]
		public bool HasCharacters(string text)
		{
			return default(bool);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x588A8C0", Offset = "0x58894C0", VA = "0x18588A8C0")]
		public static string GetCharacters(TMP_FontAsset fontAsset)
		{
			return null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x588A7F0", Offset = "0x58893F0", VA = "0x18588A7F0")]
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset)
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x588A9B0", Offset = "0x58895B0", VA = "0x18588A9B0")]
		internal uint GetGlyphIndex(uint unicode)
		{
			return 0U;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x588C5F0", Offset = "0x588B1F0", VA = "0x18588C5F0")]
		internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x58901F0", Offset = "0x588EDF0", VA = "0x1858901F0")]
		internal static void UpdateFontFeaturesForFontAssetsInQueue()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x588C4F0", Offset = "0x588B0F0", VA = "0x18588C4F0")]
		internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x588FF30", Offset = "0x588EB30", VA = "0x18588FF30")]
		internal static void UpdateAtlasTexturesForFontAssetsInQueue()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x588F210", Offset = "0x588DE10", VA = "0x18588F210")]
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x588DA70", Offset = "0x588C670", VA = "0x18588DA70")]
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x588E630", Offset = "0x588D230", VA = "0x18588E630")]
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x588E660", Offset = "0x588D260", VA = "0x18588E660")]
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x588CFD0", Offset = "0x588BBD0", VA = "0x18588CFD0")]
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character)
		{
			return default(bool);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x588F690", Offset = "0x588E290", VA = "0x18588F690")]
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character)
		{
			return default(bool);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void TryAddGlyphsToAtlasTextures()
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x588F240", Offset = "0x588DE40", VA = "0x18588F240")]
		private bool TryAddGlyphsToNewAtlasTexture()
		{
			return default(bool);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x588C6F0", Offset = "0x588B2F0", VA = "0x18588C6F0")]
		private void SetupNewAtlasTexture()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x588FD60", Offset = "0x588E960", VA = "0x18588FD60")]
		internal void UpdateAtlasTexture()
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x5890370", Offset = "0x588EF70", VA = "0x185890370")]
		internal void UpdateGlyphAdjustmentRecords()
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x58906A0", Offset = "0x588F2A0", VA = "0x1858906A0")]
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x5889EA0", Offset = "0x5888AA0", VA = "0x185889EA0")]
		public void ClearFontAssetData(bool setAtlasSizeToZero = false)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x5889E70", Offset = "0x5888A70", VA = "0x185889E70")]
		internal void ClearFontAssetDataInternal()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x58900A0", Offset = "0x588ECA0", VA = "0x1858900A0")]
		internal void UpdateFontAssetData()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x5889EE0", Offset = "0x5888AE0", VA = "0x185889EE0")]
		internal void ClearFontAssetTables()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x58899E0", Offset = "0x58885E0", VA = "0x1858899E0")]
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x58909C0", Offset = "0x588F5C0", VA = "0x1858909C0")]
		internal void UpgradeFontAsset()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x58917B0", Offset = "0x58903B0", VA = "0x1858917B0")]
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x5891F00", Offset = "0x5890B00", VA = "0x185891F00")]
		public TMP_FontAsset()
		{
		}

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_Version;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal string m_SourceFontFileGUID;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Font m_SourceFontFile;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AtlasPopulationMode m_AtlasPopulationMode;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		internal FaceInfo m_FaceInfo;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		internal List<Glyph> m_GlyphTable;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xB8")]
		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		internal List<TMP_Character> m_CharacterTable;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xC8")]
		internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xD0")]
		internal Texture2D m_AtlasTexture;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		internal Texture2D[] m_AtlasTextures;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		internal int m_AtlasTextureIndex;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private bool m_IsMultiAtlasTexturesEnabled;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0xE5")]
		[SerializeField]
		private bool m_ClearDynamicDataOnBuild;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private List<GlyphRect> m_UsedGlyphRects;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private List<GlyphRect> m_FreeGlyphRects;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private FaceInfo_Legacy m_fontInfo;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		public Texture2D atlas;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		internal int m_AtlasWidth;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		internal int m_AtlasHeight;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		internal int m_AtlasPadding;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		internal GlyphRenderMode m_AtlasRenderMode;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		internal List<TMP_Glyph> m_glyphInfoList;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[FormerlySerializedAs("m_kerningInfo")]
		internal KerningTable m_KerningTable;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		internal TMP_FontFeatureTable m_FontFeatureTable;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<TMP_FontAsset> fallbackFontAssets;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		internal List<TMP_FontAsset> m_FallbackFontAssetTable;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		internal FontAssetCreationSettings m_CreationSettings;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private TMP_FontWeightPair[] m_FontWeightTable;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private TMP_FontWeightPair[] fontWeights;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x1A8")]
		public float normalStyle;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x1AC")]
		public float normalSpacingOffset;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x1B0")]
		public float boldStyle;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x1B4")]
		public float boldSpacing;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x1B8")]
		public byte italicStyle;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x1B9")]
		public byte tabSize;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x1BA")]
		internal bool IsFontAssetLookupTablesDirty;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker k_ReadFontAssetDefinitionMarker;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_AddSynthesizedCharactersMarker;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_TryAddCharacterMarker;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_TryAddCharactersMarker;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_ClearFontAssetDataMarker;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker k_UpdateFontAssetDataMarker;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x38")]
		private static string s_DefaultMaterialSuffix;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x1C0")]
		internal HashSet<int> FallbackSearchQueryLookup;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x40")]
		private static HashSet<int> k_SearchedFontAssetLookup;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x48")]
		private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x50")]
		private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x58")]
		private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x60")]
		private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x1C8")]
		private List<Glyph> m_GlyphsToRender;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x1D0")]
		private List<Glyph> m_GlyphsRendered;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x1D8")]
		private List<uint> m_GlyphIndexList;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x1E0")]
		private List<uint> m_GlyphIndexListNewlyAdded;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x1E8")]
		internal List<uint> m_GlyphsToAdd;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x1F0")]
		internal HashSet<uint> m_GlyphsToAddLookup;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x1F8")]
		internal List<TMP_Character> m_CharactersToAdd;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x200")]
		internal HashSet<uint> m_CharactersToAddLookup;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x208")]
		internal List<uint> s_MissingCharacterList;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x210")]
		internal HashSet<uint> m_MissingUnicodesFromFontFile;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x68")]
		internal static uint[] k_GlyphIndexArray;
	}
}
