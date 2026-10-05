using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200376F RID: 14191
	[Token(Token = "0x200376F")]
	public class AutoPackSpriteHub : ScriptableObject, ISpriteHub
	{
		// Token: 0x06016889 RID: 92297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016889")]
		[Address(RVA = "0xEEFDD0", Offset = "0xEEE9D0", VA = "0x180EEFDD0")]
		private void _InitMapIfNot()
		{
		}

		// Token: 0x0601688A RID: 92298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601688A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void CheckReferences()
		{
		}

		// Token: 0x0601688B RID: 92299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601688B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Bake()
		{
		}

		// Token: 0x0601688C RID: 92300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601688C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void SilentBake(bool saveAssets)
		{
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0601688D RID: 92301 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601688E RID: 92302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035FB")]
		public string PackingTag
		{
			[Token(Token = "0x601688D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x601688E")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x0601688F RID: 92303 RVA: 0x00091830 File Offset: 0x0008FA30
		[Token(Token = "0x601688F")]
		[Address(RVA = "0xEEF840", Offset = "0xEEE440", VA = "0x180EEF840")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06016890 RID: 92304 RVA: 0x00091848 File Offset: 0x0008FA48
		[Token(Token = "0x6016890")]
		[Address(RVA = "0xEEFBD0", Offset = "0xEEE7D0", VA = "0x180EEFBD0")]
		public bool TryGetValue(string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x06016891 RID: 92305 RVA: 0x00091860 File Offset: 0x0008FA60
		[Token(Token = "0x6016891")]
		[Address(RVA = "0xEEFC80", Offset = "0xEEE880", VA = "0x180EEFC80")]
		public bool TryLoadSprite(string id, ILoadAsset assetLoader, out Sprite result)
		{
			return default(bool);
		}

		// Token: 0x06016892 RID: 92306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016892")]
		[Address(RVA = "0xEEF8C0", Offset = "0xEEE4C0", VA = "0x180EEF8C0")]
		public static string GetSpritePathFromHub(string spriteId, string hubPath, ILoadAsset loader, bool bMustInHub = true)
		{
			return null;
		}

		// Token: 0x06016893 RID: 92307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016893")]
		[Address(RVA = "0xEEFB30", Offset = "0xEEE730", VA = "0x180EEFB30")]
		public static Sprite LoadSpriteFromHub(string spriteId, string hubPath, ILoadAsset loader, bool bMustInHub = true)
		{
			return null;
		}

		// Token: 0x06016894 RID: 92308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016894")]
		[Address(RVA = "0xEF0090", Offset = "0xEEEC90", VA = "0x180EF0090")]
		public AutoPackSpriteHub()
		{
		}

		// Token: 0x0401B24F RID: 111183
		[Token(Token = "0x401B24F")]
		private const int DEFAULT_MAX_FILE_SIZE = 1048576;

		// Token: 0x0401B250 RID: 111184
		[Token(Token = "0x401B250")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _rootPackingTag;

		// Token: 0x0401B251 RID: 111185
		[Token(Token = "0x401B251")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _cntPerAtlas;

		// Token: 0x0401B252 RID: 111186
		[Token(Token = "0x401B252")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private AutoPackSpriteHub.PicSize _standardPicSize;

		// Token: 0x0401B253 RID: 111187
		[Token(Token = "0x401B253")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<AutoPackSpriteHub.PicSize> _extraPicSize;

		// Token: 0x0401B254 RID: 111188
		[Token(Token = "0x401B254")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AutoPackSpriteHub.CompressType _compressType;

		// Token: 0x0401B255 RID: 111189
		[Token(Token = "0x401B255")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private AutoPackSpriteHub.AtlasSize _atlasSize;

		// Token: 0x0401B256 RID: 111190
		[Token(Token = "0x401B256")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AutoPackSpriteHub.MeshType _meshType;

		// Token: 0x0401B257 RID: 111191
		[Token(Token = "0x401B257")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _useCntPerAtlas;

		// Token: 0x0401B258 RID: 111192
		[Token(Token = "0x401B258")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _maxFileSize;

		// Token: 0x0401B259 RID: 111193
		[Token(Token = "0x401B259")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Tooltip("Apply to sprite max import size")]
		private AutoPackSpriteHub.TexSize _maxTextureSize;

		// Token: 0x0401B25A RID: 111194
		[Token(Token = "0x401B25A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("The simple version of config.")]
		private string _extraTagRegex;

		// Token: 0x0401B25B RID: 111195
		[Token(Token = "0x401B25B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AutoPackSpriteHub.ExtractTagConfig _extractTagConfig;

		// Token: 0x0401B25C RID: 111196
		[Token(Token = "0x401B25C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private string _atlasOutputPath;

		// Token: 0x0401B25D RID: 111197
		[Token(Token = "0x401B25D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("FullName of a class inherited from ScripableConfig")]
		private string _configName;

		// Token: 0x0401B25E RID: 111198
		[Token(Token = "0x401B25E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<string> _keys;

		// Token: 0x0401B25F RID: 111199
		[Token(Token = "0x401B25F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<string> _values;

		// Token: 0x0401B260 RID: 111200
		[Token(Token = "0x401B260")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, string> m_map;

		// Token: 0x02003770 RID: 14192
		[Token(Token = "0x2003770")]
		public struct AtlasSettings
		{
			// Token: 0x0401B261 RID: 111201
			[Token(Token = "0x401B261")]
			[FieldOffset(Offset = "0x0")]
			public string assetPath;

			// Token: 0x0401B262 RID: 111202
			[Token(Token = "0x401B262")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;

			// Token: 0x0401B263 RID: 111203
			[Token(Token = "0x401B263")]
			[FieldOffset(Offset = "0x10")]
			public int maxSize;
		}

		// Token: 0x02003771 RID: 14193
		[Token(Token = "0x2003771")]
		public enum CompressType
		{
			// Token: 0x0401B265 RID: 111205
			[Token(Token = "0x401B265")]
			DEFAULT_ASTC_5X5 = 10,
			// Token: 0x0401B266 RID: 111206
			[Token(Token = "0x401B266")]
			OPAQUE_ASTC_8X8,
			// Token: 0x0401B267 RID: 111207
			[Token(Token = "0x401B267")]
			LOW_ASTC_6X6,
			// Token: 0x0401B268 RID: 111208
			[Token(Token = "0x401B268")]
			OPAQUE_ASTC_6X6,
			// Token: 0x0401B269 RID: 111209
			[Token(Token = "0x401B269")]
			AUTO_ALPHA_5X5_OPAQUE_8X8 = 4,
			// Token: 0x0401B26A RID: 111210
			[Token(Token = "0x401B26A")]
			X_OBSOLETE_ASTC_5X5_1 = 0,
			// Token: 0x0401B26B RID: 111211
			[Token(Token = "0x401B26B")]
			X_OBSOLETE_ASTC_5X5_2,
			// Token: 0x0401B26C RID: 111212
			[Token(Token = "0x401B26C")]
			X_OBSOLETE_ASTC_5X5_3,
			// Token: 0x0401B26D RID: 111213
			[Token(Token = "0x401B26D")]
			X_OBSOLETE_ASTC_OPAQUE_8X8,
			// Token: 0x0401B26E RID: 111214
			[Token(Token = "0x401B26E")]
			X_OBSOLETE_ASTC_5X5_4 = 20
		}

		// Token: 0x02003772 RID: 14194
		[Token(Token = "0x2003772")]
		public enum AtlasSize
		{
			// Token: 0x0401B270 RID: 111216
			[Token(Token = "0x401B270")]
			DEFAULT_2048,
			// Token: 0x0401B271 RID: 111217
			[Token(Token = "0x401B271")]
			MEDIUM_1024,
			// Token: 0x0401B272 RID: 111218
			[Token(Token = "0x401B272")]
			SMALL_512
		}

		// Token: 0x02003773 RID: 14195
		[Token(Token = "0x2003773")]
		public enum MeshType
		{
			// Token: 0x0401B274 RID: 111220
			[Token(Token = "0x401B274")]
			DONT_CHANGE,
			// Token: 0x0401B275 RID: 111221
			[Token(Token = "0x401B275")]
			FULL_RECT,
			// Token: 0x0401B276 RID: 111222
			[Token(Token = "0x401B276")]
			TIGHT
		}

		// Token: 0x02003774 RID: 14196
		[Token(Token = "0x2003774")]
		public enum TexSize
		{
			// Token: 0x0401B278 RID: 111224
			[Token(Token = "0x401B278")]
			NONE,
			// Token: 0x0401B279 RID: 111225
			[Token(Token = "0x401B279")]
			MEDIUM_1024,
			// Token: 0x0401B27A RID: 111226
			[Token(Token = "0x401B27A")]
			LARGE_2048,
			// Token: 0x0401B27B RID: 111227
			[Token(Token = "0x401B27B")]
			HUGE_4096
		}

		// Token: 0x02003775 RID: 14197
		[Token(Token = "0x2003775")]
		[Serializable]
		public struct PicSize
		{
			// Token: 0x06016895 RID: 92309 RVA: 0x00091878 File Offset: 0x0008FA78
			[Token(Token = "0x6016895")]
			[Address(RVA = "0xE05AC0", Offset = "0xE046C0", VA = "0x180E05AC0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x06016896 RID: 92310 RVA: 0x00091890 File Offset: 0x0008FA90
			[Token(Token = "0x6016896")]
			[Address(RVA = "0xEFADA0", Offset = "0xEF99A0", VA = "0x180EFADA0")]
			public long GetMagnitudeSquared()
			{
				return 0L;
			}

			// Token: 0x06016897 RID: 92311 RVA: 0x000918A8 File Offset: 0x0008FAA8
			[Token(Token = "0x6016897")]
			[Address(RVA = "0xE05AD0", Offset = "0xE046D0", VA = "0x180E05AD0")]
			public bool Validate(Rect rect)
			{
				return default(bool);
			}

			// Token: 0x06016898 RID: 92312 RVA: 0x000918C0 File Offset: 0x0008FAC0
			[Token(Token = "0x6016898")]
			[Address(RVA = "0xEFADB0", Offset = "0xEF99B0", VA = "0x180EFADB0")]
			public bool Validate(int x, int y)
			{
				return default(bool);
			}

			// Token: 0x0401B27C RID: 111228
			[Token(Token = "0x401B27C")]
			[FieldOffset(Offset = "0x0")]
			public int width;

			// Token: 0x0401B27D RID: 111229
			[Token(Token = "0x401B27D")]
			[FieldOffset(Offset = "0x4")]
			public int height;
		}

		// Token: 0x02003776 RID: 14198
		[Token(Token = "0x2003776")]
		[Serializable]
		private struct ExtractTagConfig
		{
			// Token: 0x06016899 RID: 92313 RVA: 0x000918D8 File Offset: 0x0008FAD8
			[Token(Token = "0x6016899")]
			[Address(RVA = "0xEF8090", Offset = "0xEF6C90", VA = "0x180EF8090")]
			public bool CheckIfEmpty()
			{
				return default(bool);
			}

			// Token: 0x0601689A RID: 92314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601689A")]
			[Address(RVA = "0xEF81F0", Offset = "0xEF6DF0", VA = "0x180EF81F0")]
			public string ExtractTag(string assetPath)
			{
				return null;
			}

			// Token: 0x0401B27E RID: 111230
			[Token(Token = "0x401B27E")]
			[FieldOffset(Offset = "0x0")]
			public List<AutoPackSpriteHub.ExtractTagConfig.Rule> rules;

			// Token: 0x02003777 RID: 14199
			[Token(Token = "0x2003777")]
			[Serializable]
			public class Rule
			{
				// Token: 0x0601689B RID: 92315 RVA: 0x000918F0 File Offset: 0x0008FAF0
				[Token(Token = "0x601689B")]
				[Address(RVA = "0xEFBC40", Offset = "0xEFA840", VA = "0x180EFBC40")]
				public bool IsEmpty()
				{
					return default(bool);
				}

				// Token: 0x0601689C RID: 92316 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601689C")]
				[Address(RVA = "0xEFB980", Offset = "0xEFA580", VA = "0x180EFB980")]
				public string ExtractTag(string assetPath)
				{
					return null;
				}

				// Token: 0x0601689D RID: 92317 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601689D")]
				[Address(RVA = "0xEFBC70", Offset = "0xEFA870", VA = "0x180EFBC70")]
				public Rule()
				{
				}

				// Token: 0x0401B27F RID: 111231
				[Token(Token = "0x401B27F")]
				[FieldOffset(Offset = "0x10")]
				public string regex;

				// Token: 0x0401B280 RID: 111232
				[Token(Token = "0x401B280")]
				[FieldOffset(Offset = "0x18")]
				public string pattern;

				// Token: 0x0401B281 RID: 111233
				[Token(Token = "0x401B281")]
				[FieldOffset(Offset = "0x20")]
				[NonSerialized]
				private Regex m_regex;
			}
		}
	}
}
