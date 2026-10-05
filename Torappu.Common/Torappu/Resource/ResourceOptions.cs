using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	[CreateAssetMenu(menuName = "Torappu/Options/ResourceOptions")]
	public class ResourceOptions : SingletonScriptableObject<ResourceOptions>, IResLangProvider
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000100")]
		public string resourcePath
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000101")]
		public string staticResPath
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000102")]
		public string abPath
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00007ACC File Offset: 0x00005CCC
		[Token(Token = "0x17000103")]
		public bool cacheAssetsInResourceManager
		{
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00007AE4 File Offset: 0x00005CE4
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000104")]
		public ResourceOptions.Mode mode
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return ResourceOptions.Mode.DEVELOPMENT_LOCAL;
			}
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00007AFC File Offset: 0x00005CFC
		[Token(Token = "0x17000105")]
		public ResourceOptions.ResLanguage resLang
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "7")]
			get
			{
				return ResourceOptions.ResLanguage.NONE;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00007B14 File Offset: 0x00005D14
		[Token(Token = "0x17000106")]
		public bool hasResLang
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x555AAA0", Offset = "0x55596A0", VA = "0x18555AAA0")]
		public static string GetResLangFolder(ResourceOptions.ResLanguage lang)
		{
			return null;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x555AB40", Offset = "0x5559740", VA = "0x18555AB40")]
		public ResourceOptions()
		{
		}

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ResourceOptions.Mode _mode;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Path of game resources folder which starts with 'Assets/'.")]
		private string _resourcePath;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Path of static shader resources folder which starts with 'Assets/'.")]
		private string _staticResPath;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Path of output assetbundles folder related to streamingPath or dataPath.")]
		private string _abPath;

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Path of GameData files which are related to |_resourcePath|.")]
		private string _gameDataPath;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Whether to restore the origin assetBundleName after building.")]
		private bool _restoreAssetBundleNames;

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		[Tooltip("Whether to cache the assets of AssetBundle in ResourceManager if possible.")]
		private bool _cachedAssetsInResourceManager;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x42")]
		[SerializeField]
		[Tooltip("Whether to delete the ResourceIndex asset after packing.")]
		private bool _deleteResourceIndexAfterPacking;

		// Token: 0x020001DA RID: 474
		[Token(Token = "0x20001DA")]
		public enum Mode
		{
			// Token: 0x04000AB0 RID: 2736
			[Token(Token = "0x4000AB0")]
			DEVELOPMENT_LOCAL,
			// Token: 0x04000AB1 RID: 2737
			[Token(Token = "0x4000AB1")]
			DEVELOPMENT_AB,
			// Token: 0x04000AB2 RID: 2738
			[Token(Token = "0x4000AB2")]
			PRODUCTION
		}

		// Token: 0x020001DB RID: 475
		[Token(Token = "0x20001DB")]
		public enum ResLanguage
		{
			// Token: 0x04000AB4 RID: 2740
			[Token(Token = "0x4000AB4")]
			NONE,
			// Token: 0x04000AB5 RID: 2741
			[Token(Token = "0x4000AB5")]
			CN,
			// Token: 0x04000AB6 RID: 2742
			[Token(Token = "0x4000AB6")]
			JP,
			// Token: 0x04000AB7 RID: 2743
			[Token(Token = "0x4000AB7")]
			KR,
			// Token: 0x04000AB8 RID: 2744
			[Token(Token = "0x4000AB8")]
			EN,
			// Token: 0x04000AB9 RID: 2745
			[Token(Token = "0x4000AB9")]
			TC,
			// Token: 0x04000ABA RID: 2746
			[Token(Token = "0x4000ABA")]
			E_NUM
		}
	}
}
