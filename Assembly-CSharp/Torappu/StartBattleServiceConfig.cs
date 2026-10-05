using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02001414 RID: 5140
	[Token(Token = "0x2001414")]
	public abstract class StartBattleServiceConfig<TRequest, TResponse> : IStartBattleServiceConfig, IHotfixable where TResponse : CommonStartBattleResponse
	{
		// Token: 0x060076BD RID: 30397
		[Token(Token = "0x60076BD")]
		protected abstract TRequest ParseRequest();

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060076BE RID: 30398
		[Token(Token = "0x17000E51")]
		protected abstract string serviceCode { [Token(Token = "0x60076BE")] get; }

		// Token: 0x060076BF RID: 30399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BF")]
		public void SendStartBattleService()
		{
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C0")]
		protected StartBattleServiceConfig()
		{
		}

		// Token: 0x04007413 RID: 29715
		[Token(Token = "0x4007413")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SendStartBattleService;

		// Token: 0x04007414 RID: 29716
		[Token(Token = "0x4007414")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
