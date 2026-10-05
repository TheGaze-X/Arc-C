using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020006D4 RID: 1748
	[Token(Token = "0x20006D4")]
	public abstract class CrisisStartBattleServiceConfig<TRequest, TResponse> : ICrisisStartBattleServiceConfig, IStartBattleServiceConfig, IHotfixable where TResponse : CommonStartBattleResponse
	{
		// Token: 0x0600631C RID: 25372
		[Token(Token = "0x600631C")]
		protected abstract TRequest ParseRequest();

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x0600631D RID: 25373
		[Token(Token = "0x17000CDB")]
		protected abstract string serviceCode { [Token(Token = "0x600631D")] get; }

		// Token: 0x0600631E RID: 25374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631E")]
		public void SetParams(CrisisBattleStartBaseParams baseParams)
		{
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631F")]
		public void SendStartBattleService()
		{
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006320")]
		protected CrisisStartBattleServiceConfig()
		{
		}

		// Token: 0x04002ECF RID: 11983
		[Token(Token = "0x4002ECF")]
		[FieldOffset(Offset = "0x0")]
		protected CrisisBattleStartBaseParams m_baseParams;

		// Token: 0x04002ED0 RID: 11984
		[Token(Token = "0x4002ED0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetParams;

		// Token: 0x04002ED1 RID: 11985
		[Token(Token = "0x4002ED1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SendStartBattleService;

		// Token: 0x04002ED2 RID: 11986
		[Token(Token = "0x4002ED2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
