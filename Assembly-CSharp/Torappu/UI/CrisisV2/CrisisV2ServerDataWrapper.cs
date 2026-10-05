using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005906 RID: 22790
	[Token(Token = "0x2005906")]
	public class CrisisV2ServerDataWrapper : IHotfixable
	{
		// Token: 0x06021362 RID: 136034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021362")]
		[Address(RVA = "0x1B92720", Offset = "0x1B91320", VA = "0x181B92720")]
		public CrisisV2ServerDataWrapper()
		{
		}

		// Token: 0x0402D3CD RID: 185293
		[Token(Token = "0x402D3CD")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2CacheServerData cacheServerData;

		// Token: 0x0402D3CE RID: 185294
		[Token(Token = "0x402D3CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
