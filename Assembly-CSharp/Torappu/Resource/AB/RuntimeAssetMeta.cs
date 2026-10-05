using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Resource.AB
{
	// Token: 0x0200177A RID: 6010
	[Token(Token = "0x200177A")]
	public class RuntimeAssetMeta
	{
		// Token: 0x060097C2 RID: 38850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097C2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RuntimeAssetMeta()
		{
		}

		// Token: 0x04008DC8 RID: 36296
		[Token(Token = "0x4008DC8")]
		[FieldOffset(Offset = "0x10")]
		private string m_name;

		// Token: 0x04008DC9 RID: 36297
		[Token(Token = "0x4008DC9")]
		[FieldOffset(Offset = "0x18")]
		private string m_path;

		// Token: 0x04008DCA RID: 36298
		[Token(Token = "0x4008DCA")]
		[FieldOffset(Offset = "0x20")]
		private string m_resPath;

		// Token: 0x04008DCB RID: 36299
		[Token(Token = "0x4008DCB")]
		[FieldOffset(Offset = "0x28")]
		private string m_bundleName;

		// Token: 0x0200177B RID: 6011
		[Token(Token = "0x200177B")]
		public class Manager
		{
			// Token: 0x060097C3 RID: 38851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60097C3")]
			[Address(RVA = "0x3128FF0", Offset = "0x3127BF0", VA = "0x183128FF0")]
			public void Reload(ResourceManifest resManifest)
			{
			}

			// Token: 0x060097C4 RID: 38852 RVA: 0x0003AF38 File Offset: 0x00039138
			[Token(Token = "0x60097C4")]
			[Address(RVA = "0x3128E80", Offset = "0x3127A80", VA = "0x183128E80")]
			public BundleHolder.AssetKey GetAssetKey(string resPath)
			{
				return default(BundleHolder.AssetKey);
			}

			// Token: 0x060097C5 RID: 38853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60097C5")]
			[Address(RVA = "0x3129270", Offset = "0x3127E70", VA = "0x183129270")]
			public Manager()
			{
			}

			// Token: 0x04008DCC RID: 36300
			[Token(Token = "0x4008DCC")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, RuntimeAssetMeta> m_metaMap;
		}
	}
}
