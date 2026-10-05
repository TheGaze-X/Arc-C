using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.Serialization;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[ExcludeFromPreset]
	[Serializable]
	public class FontAsset : TextAsset
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public Font sourceFontFile
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x59976F0", Offset = "0x59962F0", VA = "0x1859976F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			internal set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public AtlasPopulationMode atlasPopulationMode
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x59F2270", Offset = "0x59F0E70", VA = "0x1859F2270")]
			get
			{
				return AtlasPopulationMode.Static;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public FaceInfo faceInfo
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x59F23E0", Offset = "0x59F0FE0", VA = "0x1859F23E0")]
			get
			{
				return default(FaceInfo);
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x5892600", Offset = "0x5891200", VA = "0x185892600")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		internal int familyNameHashCode
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x59F2430", Offset = "0x59F1030", VA = "0x1859F2430")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x789460", Offset = "0x788060", VA = "0x180789460")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		internal int styleNameHashCode
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x59F2550", Offset = "0x59F1150", VA = "0x1859F2550")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x32FC4C0", Offset = "0x32FB0C0", VA = "0x1832FC4C0")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public FontWeightPair[] fontWeightTable
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x5997710", Offset = "0x5996310", VA = "0x185997710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x22F8A60", Offset = "0x22F7660", VA = "0x1822F8A60")]
			internal set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public List<Glyph> glyphTable
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x5997720", Offset = "0x5996320", VA = "0x185997720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
			internal set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000008")]
		public Dictionary<uint, Glyph> glyphLookupTable
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x59F24D0", Offset = "0x59F10D0", VA = "0x1859F24D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public List<Character> characterTable
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x59976B0", Offset = "0x59962B0", VA = "0x1859976B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xF0A890", Offset = "0xF09490", VA = "0x180F0A890")]
			internal set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000A")]
		public Dictionary<uint, Character> characterLookupTable
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x59F2390", Offset = "0x59F0F90", VA = "0x1859F2390")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700000B")]
		public Texture2D atlasTexture
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x59F22A0", Offset = "0x59F0EA0", VA = "0x1859F22A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public Texture2D[] atlasTextures
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x59F2350", Offset = "0x59F0F50", VA = "0x1859F2350")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x4D6CBB0", Offset = "0x4D6B7B0", VA = "0x184D6CBB0")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x1700000D")]
		public int atlasTextureCount
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x59F2290", Offset = "0x59F0E90", VA = "0x1859F2290")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public bool isMultiAtlasTexturesEnabled
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x59F2510", Offset = "0x59F1110", VA = "0x1859F2510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x59F2640", Offset = "0x59F1240", VA = "0x1859F2640")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002118 File Offset: 0x00000318
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		internal bool clearDynamicDataOnBuild
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x59F23D0", Offset = "0x59F0FD0", VA = "0x1859F23D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x4A34B80", Offset = "0x4A33780", VA = "0x184A34B80")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public int atlasWidth
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x59F2360", Offset = "0x59F0F60", VA = "0x1859F2360")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x59F25D0", Offset = "0x59F11D0", VA = "0x1859F25D0")]
			internal set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public int atlasHeight
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x59F2250", Offset = "0x59F0E50", VA = "0x1859F2250")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x58E28E0", Offset = "0x58E14E0", VA = "0x1858E28E0")]
			internal set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public int atlasPadding
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x59F2260", Offset = "0x59F0E60", VA = "0x1859F2260")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x59F25B0", Offset = "0x59F11B0", VA = "0x1859F25B0")]
			internal set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public GlyphRenderMode atlasRenderMode
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x59F2280", Offset = "0x59F0E80", VA = "0x1859F2280")]
			get
			{
				return (GlyphRenderMode)0;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x59F25C0", Offset = "0x59F11C0", VA = "0x1859F25C0")]
			internal set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		internal List<GlyphRect> usedGlyphRects
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x59F25A0", Offset = "0x59F11A0", VA = "0x1859F25A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x22F8A40", Offset = "0x22F7640", VA = "0x1822F8A40")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		internal List<GlyphRect> freeGlyphRects
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x59F24C0", Offset = "0x59F10C0", VA = "0x1859F24C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x22F8A30", Offset = "0x22F7630", VA = "0x1822F8A30")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public FontFeatureTable fontFeatureTable
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x59F24B0", Offset = "0x59F10B0", VA = "0x1859F24B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x4FAD760", Offset = "0x4FAC360", VA = "0x184FAD760")]
			internal set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public List<FontAsset> fallbackFontAssetTable
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x59F2420", Offset = "0x59F1020", VA = "0x1859F2420")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x1692BB0", Offset = "0x16917B0", VA = "0x181692BB0")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x59F2470", Offset = "0x59F1070", VA = "0x1859F2470")]
			get
			{
				return default(FontAssetCreationEditorSettings);
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x59F2600", Offset = "0x59F1200", VA = "0x1859F2600")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public float regularStyleWeight
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x59F2540", Offset = "0x59F1140", VA = "0x1859F2540")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x59F2670", Offset = "0x59F1270", VA = "0x1859F2670")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public float regularStyleSpacing
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x59F2530", Offset = "0x59F1130", VA = "0x1859F2530")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x59F2660", Offset = "0x59F1260", VA = "0x1859F2660")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public float boldStyleWeight
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x59F2380", Offset = "0x59F0F80", VA = "0x1859F2380")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x59F25F0", Offset = "0x59F11F0", VA = "0x1859F25F0")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public float boldStyleSpacing
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x59F2370", Offset = "0x59F0F70", VA = "0x1859F2370")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x59F25E0", Offset = "0x59F11E0", VA = "0x1859F25E0")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public byte italicStyleSlant
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x59F2520", Offset = "0x59F1120", VA = "0x1859F2520")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x59F2650", Offset = "0x59F1250", VA = "0x1859F2650")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public byte tabMultiple
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x59F2590", Offset = "0x59F1190", VA = "0x1859F2590")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x59F2680", Offset = "0x59F1280", VA = "0x1859F2680")]
			set
			{
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x59EA890", Offset = "0x59E9490", VA = "0x1859EA890")]
		public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x59EA6D0", Offset = "0x59E92D0", VA = "0x1859EA6D0")]
		private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.DynamicOS, bool enableMultiAtlasSupport = true)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x59EA810", Offset = "0x59E9410", VA = "0x1859EA810")]
		public static FontAsset CreateFontAsset(Font font)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x59EAC40", Offset = "0x59E9840", VA = "0x1859EAC40")]
		public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59EAE40", Offset = "0x59E9A40", VA = "0x1859EAE40")]
		private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x59EA140", Offset = "0x59E8D40", VA = "0x1859EA140")]
		private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Awake()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x59EC870", Offset = "0x59EB470", VA = "0x1859EC870")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x59EC990", Offset = "0x59EB590", VA = "0x1859EC990")]
		public void ReadFontAssetDefinition()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x59EC260", Offset = "0x59EAE60", VA = "0x1859EC260")]
		internal void InitializeDictionaryLookupTables()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x59EC290", Offset = "0x59EAE90", VA = "0x1859EC290")]
		internal void InitializeGlyphLookupDictionary()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x59EC070", Offset = "0x59EAC70", VA = "0x1859EC070")]
		internal void InitializeCharacterLookupDictionary()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x59EC530", Offset = "0x59EB130", VA = "0x1859EC530")]
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x59E9990", Offset = "0x59E8590", VA = "0x1859E9990")]
		internal void AddSynthesizedCharactersAndFaceMetrics()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x59E9660", Offset = "0x59E8260", VA = "0x1859E9660")]
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x59E95F0", Offset = "0x59E81F0", VA = "0x1859E95F0")]
		internal void AddCharacterToLookupCache(uint unicode, Character character)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x59EC790", Offset = "0x59EB390", VA = "0x1859EC790")]
		private FontEngineError LoadFontFace()
		{
			return FontEngineError.Success;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x59ED5A0", Offset = "0x59EC1A0", VA = "0x1859ED5A0")]
		internal void SortCharacterTable()
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x59ED750", Offset = "0x59EC350", VA = "0x1859ED750")]
		internal void SortGlyphTable()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x59ED720", Offset = "0x59EC320", VA = "0x1859ED720")]
		internal void SortFontFeatureTable()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x59ED2B0", Offset = "0x59EBEB0", VA = "0x1859ED2B0")]
		internal void SortAllTables()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x59EB5E0", Offset = "0x59EA1E0", VA = "0x1859EB5E0")]
		public bool HasCharacter(int character)
		{
			return default(bool);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x59EB640", Offset = "0x59EA240", VA = "0x1859EB640")]
		public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default(bool);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x59EB390", Offset = "0x59E9F90", VA = "0x1859EB390")]
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default(bool);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x59EBF00", Offset = "0x59EAB00", VA = "0x1859EBF00")]
		public bool HasCharacters(string text, out List<char> missingCharacters)
		{
			return default(bool);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x59EBA70", Offset = "0x59EA670", VA = "0x1859EBA70")]
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default(bool);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x59EB9C0", Offset = "0x59EA5C0", VA = "0x1859EB9C0")]
		public bool HasCharacters(string text)
		{
			return default(bool);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x59EB1C0", Offset = "0x59E9DC0", VA = "0x1859EB1C0")]
		public static string GetCharacters(FontAsset fontAsset)
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x59EB0F0", Offset = "0x59E9CF0", VA = "0x1859EB0F0")]
		public static int[] GetCharactersArray(FontAsset fontAsset)
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x59EB2B0", Offset = "0x59E9EB0", VA = "0x1859EB2B0")]
		internal uint GetGlyphIndex(uint unicode)
		{
			return 0U;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x59ECEF0", Offset = "0x59EBAF0", VA = "0x1859ECEF0")]
		internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x59F1240", Offset = "0x59EFE40", VA = "0x1859F1240")]
		internal static void UpdateFontFeaturesForFontAssetsInQueue()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x59ECE00", Offset = "0x59EBA00", VA = "0x1859ECE00")]
		internal static void RegisterAtlasTextureForApply(Texture2D texture)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x59F0BE0", Offset = "0x59EF7E0", VA = "0x1859F0BE0")]
		internal static void UpdateAtlasTexturesInQueue()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x59F0F20", Offset = "0x59EFB20", VA = "0x1859F0F20")]
		internal static void UpdateFontAssetInUpdateQueue()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x59EE6B0", Offset = "0x59ED2B0", VA = "0x1859EE6B0")]
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x59EE6E0", Offset = "0x59ED2E0", VA = "0x1859EE6E0")]
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x59EE680", Offset = "0x59ED280", VA = "0x1859EE680")]
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x59EF300", Offset = "0x59EDF00", VA = "0x1859EF300")]
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x59ED8D0", Offset = "0x59EC4D0", VA = "0x1859ED8D0")]
		internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x59F0350", Offset = "0x59EEF50", VA = "0x1859F0350")]
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = false)
		{
			return default(bool);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void TryAddGlyphsToAtlasTextures()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x59EFF00", Offset = "0x59EEB00", VA = "0x1859EFF00")]
		private bool TryAddGlyphsToNewAtlasTexture()
		{
			return default(bool);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x59ECFF0", Offset = "0x59EBBF0", VA = "0x1859ECFF0")]
		private void SetupNewAtlasTexture()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x59F0A10", Offset = "0x59EF610", VA = "0x1859F0A10")]
		internal void UpdateAtlasTexture()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x59F1760", Offset = "0x59F0360", VA = "0x1859F1760")]
		internal void UpdateGlyphAdjustmentRecords()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x59F13C0", Offset = "0x59EFFC0", VA = "0x1859F13C0")]
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x59E9E80", Offset = "0x59E8A80", VA = "0x1859E9E80")]
		public void ClearFontAssetData(bool setAtlasSizeToZero = false)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x59E9E50", Offset = "0x59E8A50", VA = "0x1859E9E50")]
		internal void ClearFontAssetDataInternal()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x59F0D60", Offset = "0x59EF960", VA = "0x1859F0D60")]
		internal void UpdateFontAssetData()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x59E9F20", Offset = "0x59E8B20", VA = "0x1859E9F20")]
		internal void ClearFontAssetTables()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x59E9BF0", Offset = "0x59E87F0", VA = "0x1859E9BF0")]
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x59EB010", Offset = "0x59E9C10", VA = "0x1859EB010")]
		private void DestroyAtlasTextures()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x59F1E80", Offset = "0x59F0A80", VA = "0x1859F1E80")]
		public FontAsset()
		{
		}

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal string m_SourceFontFileGUID;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Font m_SourceFontFile;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AtlasPopulationMode m_AtlasPopulationMode;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		internal bool InternalDynamicOS;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		internal FaceInfo m_FaceInfo;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xB0")]
		private int m_FamilyNameHashCode;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xB4")]
		private int m_StyleNameHashCode;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private FontWeightPair[] m_FontWeightTable;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		internal List<Glyph> m_GlyphTable;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xC8")]
		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		internal List<Character> m_CharacterTable;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0xD8")]
		internal Dictionary<uint, Character> m_CharacterLookupDictionary;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0xE0")]
		internal Texture2D m_AtlasTexture;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		internal Texture2D[] m_AtlasTextures;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		internal int m_AtlasTextureIndex;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool m_IsMultiAtlasTexturesEnabled;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xF5")]
		[SerializeField]
		private bool m_ClearDynamicDataOnBuild;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		internal int m_AtlasWidth;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		internal int m_AtlasHeight;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		internal int m_AtlasPadding;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		internal GlyphRenderMode m_AtlasRenderMode;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<GlyphRect> m_UsedGlyphRects;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private List<GlyphRect> m_FreeGlyphRects;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		internal FontFeatureTable m_FontFeatureTable;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		internal List<FontAsset> m_FallbackFontAssetTable;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x178")]
		[FormerlySerializedAs("normalStyle")]
		[SerializeField]
		internal float m_RegularStyleWeight;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x17C")]
		[FormerlySerializedAs("normalSpacingOffset")]
		[SerializeField]
		internal float m_RegularStyleSpacing;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[FormerlySerializedAs("boldStyle")]
		internal float m_BoldStyleWeight;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		[FormerlySerializedAs("boldSpacing")]
		internal float m_BoldStyleSpacing;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[FormerlySerializedAs("italicStyle")]
		internal byte m_ItalicStyleSlant;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x189")]
		[SerializeField]
		[FormerlySerializedAs("tabSize")]
		internal byte m_TabMultiple;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18A")]
		internal bool IsFontAssetLookupTablesDirty;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker k_ReadFontAssetDefinitionMarker;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_AddSynthesizedCharactersMarker;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_TryAddCharacterMarker;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_TryAddCharactersMarker;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_ClearFontAssetDataMarker;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker k_UpdateFontAssetDataMarker;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x38")]
		private static string s_DefaultMaterialSuffix;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x40")]
		private static HashSet<int> k_SearchedFontAssetLookup;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x48")]
		private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x50")]
		private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x58")]
		private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x60")]
		private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x190")]
		private List<Glyph> m_GlyphsToRender;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x198")]
		private List<Glyph> m_GlyphsRendered;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x1A0")]
		private List<uint> m_GlyphIndexList;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x1A8")]
		private List<uint> m_GlyphIndexListNewlyAdded;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x1B0")]
		internal List<uint> m_GlyphsToAdd;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x1B8")]
		internal HashSet<uint> m_GlyphsToAddLookup;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x1C0")]
		internal List<Character> m_CharactersToAdd;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x1C8")]
		internal HashSet<uint> m_CharactersToAddLookup;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x1D0")]
		internal List<uint> s_MissingCharacterList;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x1D8")]
		internal HashSet<uint> m_MissingUnicodesFromFontFile;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x68")]
		internal static uint[] k_GlyphIndexArray;
	}
}
