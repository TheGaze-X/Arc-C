using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[ExcludeFromPreset]
	[ExcludeFromObjectFactory]
	[Serializable]
	public class TextSettings : ScriptableObject
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public string version
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			internal set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public FontAsset defaultFontAsset
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public string defaultFontAssetPath
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public List<FontAsset> fallbackFontAssets
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public bool matchMaterialPreset
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public int missingCharacterUnicode
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public bool clearDynamicDataOnBuild
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public SpriteAsset defaultSpriteAsset
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public string defaultSpriteAssetPath
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public List<SpriteAsset> fallbackSpriteAssets
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public uint missingSpriteCharacterUnicode
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x4D1D360", Offset = "0x4D1BF60", VA = "0x184D1D360")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public TextStyleSheet defaultStyleSheet
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public string styleSheetsResourcePath
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		public string defaultColorGradientPresetsPath
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public UnicodeLineBreakingRules lineBreakingRules
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x59FFB60", Offset = "0x59FE760", VA = "0x1859FFB60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public bool displayWarnings
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x906A30", Offset = "0x905630", VA = "0x180906A30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x906A90", Offset = "0x905690", VA = "0x180906A90")]
			set
			{
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x59FF7E0", Offset = "0x59FE3E0", VA = "0x1859FF7E0")]
		protected void InitializeFontReferenceLookup()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x59FF440", Offset = "0x59FE040", VA = "0x1859FF440")]
		protected FontAsset GetCachedFontAssetInternal(Font font)
		{
			return null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x59FFA30", Offset = "0x59FE630", VA = "0x1859FFA30")]
		public TextSettings()
		{
		}

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string m_Version;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("m_defaultFontAsset")]
		[SerializeField]
		protected FontAsset m_DefaultFontAsset;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("m_defaultFontAssetPath")]
		[SerializeField]
		protected string m_DefaultFontAssetPath;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("m_fallbackFontAssets")]
		protected List<FontAsset> m_FallbackFontAssets;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("m_matchMaterialPreset")]
		[SerializeField]
		protected bool m_MatchMaterialPreset;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[FormerlySerializedAs("m_missingGlyphCharacter")]
		protected int m_MissingCharacterUnicode;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected bool m_ClearDynamicDataOnBuild;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("m_defaultSpriteAsset")]
		protected SpriteAsset m_DefaultSpriteAsset;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("m_defaultSpriteAssetPath")]
		[SerializeField]
		protected string m_DefaultSpriteAssetPath;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected List<SpriteAsset> m_FallbackSpriteAssets;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected uint m_MissingSpriteCharacterUnicode;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("m_defaultStyleSheet")]
		[SerializeField]
		protected TextStyleSheet m_DefaultStyleSheet;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected string m_StyleSheetsResourcePath;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
		[SerializeField]
		protected string m_DefaultColorGradientPresetsPath;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("m_warningsDisabled")]
		[SerializeField]
		protected bool m_DisplayWarnings;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x90")]
		internal Dictionary<int, FontAsset> m_FontLookup;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x98")]
		private List<TextSettings.FontReferenceMap> m_FontReferences;

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		[Serializable]
		private struct FontReferenceMap
		{
			// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
			public FontReferenceMap(Font font, FontAsset fontAsset)
			{
			}

			// Token: 0x040002D3 RID: 723
			[Token(Token = "0x40002D3")]
			[FieldOffset(Offset = "0x0")]
			public Font font;

			// Token: 0x040002D4 RID: 724
			[Token(Token = "0x40002D4")]
			[FieldOffset(Offset = "0x8")]
			public FontAsset fontAsset;
		}
	}
}
