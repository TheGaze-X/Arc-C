using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[CreateAssetMenu(menuName = "Torappu/Options/GlobalOptions")]
	public class GlobalOptions : SingletonScriptableObject<GlobalOptions>
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		public string funcVersion
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x54E3E40", Offset = "0x54E2A40", VA = "0x1854E3E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public string udtVersion
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000011")]
		public string auditVersionCode
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x17000012")]
		public bool enablePCFullResourceMode
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x54E3DA0", Offset = "0x54E29A0", VA = "0x1854E3DA0")]
		public GlobalOptions()
		{
		}

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string devVersion;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string dynamicConfigPath;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("If the package's bundle version goes cross the value specified by this field, HotUpdateViewController will delete all cached files including PlayerPrefs and HotUpdateList")]
		public string crossThisBundleVersionToDeleteAllCachedFiles;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public TextAsset cryptoPubKey;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public TextAsset backupStringMap;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Version used for GameUpdateSDK. Must be like 55.0.0")]
		private string _udtVersion;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _auditVersionCode;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Whether PC uses its full-resource behavior. Disable to fall back to mobile-like resource handling.")]
		private bool _enablePCFullResourceMode;
	}
}
