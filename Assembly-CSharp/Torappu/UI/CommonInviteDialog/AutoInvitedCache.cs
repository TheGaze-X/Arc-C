using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BBF RID: 23487
	[Token(Token = "0x2005BBF")]
	public class AutoInvitedCache : SingletonLoginScoped<AutoInvitedCache>
	{
		// Token: 0x060220FC RID: 139516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60220FC")]
		[Address(RVA = "0x1C856C0", Offset = "0x1C842C0", VA = "0x181C856C0")]
		public Dictionary<string, long> RequestCache(string funcId)
		{
			return null;
		}

		// Token: 0x060220FD RID: 139517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220FD")]
		[Address(RVA = "0x1C85890", Offset = "0x1C84490", VA = "0x181C85890")]
		private AutoInvitedCache()
		{
		}

		// Token: 0x0402EB6A RID: 191338
		[Token(Token = "0x402EB6A")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Dictionary<string, long>> m_store;

		// Token: 0x0402EB6B RID: 191339
		[Token(Token = "0x402EB6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RequestCache;

		// Token: 0x0402EB6C RID: 191340
		[Token(Token = "0x402EB6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
