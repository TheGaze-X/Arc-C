using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D5D RID: 27997
	[Token(Token = "0x2006D5D")]
	public class ActivityAssetMap : Singleton<ActivityAssetMap>, IHotfixable
	{
		// Token: 0x06027E72 RID: 163442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E72")]
		[Address(RVA = "0x2334910", Offset = "0x2333510", VA = "0x182334910")]
		private ActivityAssetMap()
		{
		}

		// Token: 0x06027E73 RID: 163443 RVA: 0x000CFDF8 File Offset: 0x000CDFF8
		[Token(Token = "0x6027E73")]
		[Address(RVA = "0x2334510", Offset = "0x2333110", VA = "0x182334510")]
		private bool _Load()
		{
			return default(bool);
		}

		// Token: 0x06027E74 RID: 163444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E74")]
		[Address(RVA = "0x23344A0", Offset = "0x23330A0", VA = "0x1823344A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027E75 RID: 163445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E75")]
		[Address(RVA = "0x2334050", Offset = "0x2332C50", VA = "0x182334050")]
		public void ForceReload()
		{
		}

		// Token: 0x06027E76 RID: 163446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E76")]
		[Address(RVA = "0x23340F0", Offset = "0x2332CF0", VA = "0x1823340F0")]
		public string GetAssetResPath(string aspect, string assetId)
		{
			return null;
		}

		// Token: 0x06027E77 RID: 163447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E77")]
		[Address(RVA = "0x2334260", Offset = "0x2332E60", VA = "0x182334260")]
		public void LoadAssetResPaths(string aspect, Dictionary<string, string> resPaths)
		{
		}

		// Token: 0x040388F9 RID: 231673
		[Token(Token = "0x40388F9")]
		[FieldOffset(Offset = "0x10")]
		private ActivityAssetMap.InternalData m_data;

		// Token: 0x040388FA RID: 231674
		[Token(Token = "0x40388FA")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isLoaded;

		// Token: 0x040388FB RID: 231675
		[Token(Token = "0x40388FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040388FC RID: 231676
		[Token(Token = "0x40388FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Load;

		// Token: 0x040388FD RID: 231677
		[Token(Token = "0x40388FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040388FE RID: 231678
		[Token(Token = "0x40388FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceReload;

		// Token: 0x040388FF RID: 231679
		[Token(Token = "0x40388FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetAssetResPath;

		// Token: 0x04038900 RID: 231680
		[Token(Token = "0x4038900")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadAssetResPaths;

		// Token: 0x02006D5E RID: 27998
		[Token(Token = "0x2006D5E")]
		private class InternalData
		{
			// Token: 0x06027E78 RID: 163448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E78")]
			[Address(RVA = "0x2341700", Offset = "0x2340300", VA = "0x182341700")]
			public InternalData()
			{
			}

			// Token: 0x04038901 RID: 231681
			[Token(Token = "0x4038901")]
			[FieldOffset(Offset = "0x10")]
			public bool isTrimed;

			// Token: 0x04038902 RID: 231682
			[Token(Token = "0x4038902")]
			[FieldOffset(Offset = "0x14")]
			public int code;

			// Token: 0x04038903 RID: 231683
			[Token(Token = "0x4038903")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, Dictionary<string, ActivityAssetMap.InternalData.AssetInfo>> aspects;

			// Token: 0x02006D5F RID: 27999
			[Token(Token = "0x2006D5F")]
			public class AssetInfo
			{
				// Token: 0x06027E79 RID: 163449 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6027E79")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AssetInfo()
				{
				}

				// Token: 0x04038904 RID: 231684
				[Token(Token = "0x4038904")]
				[FieldOffset(Offset = "0x10")]
				public string resPath;

				// Token: 0x04038905 RID: 231685
				[Token(Token = "0x4038905")]
				[FieldOffset(Offset = "0x18")]
				public string activity;
			}
		}
	}
}
