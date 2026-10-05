using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E23 RID: 15907
	[Token(Token = "0x2003E23")]
	public abstract class SquadCustomStartBattleServiceConfig<TReq, TRes> : StartBattleServiceConfig<TReq, TRes> where TReq : DefaultStartBattleRequest, new() where TRes : DefaultStartBattleResponse
	{
		// Token: 0x06018BBC RID: 101308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BBC")]
		public SquadCustomStartBattleServiceConfig(SquadHomeStartBattleServicePluginBase.Param param)
		{
		}

		// Token: 0x06018BBD RID: 101309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BBD")]
		protected sealed override TReq ParseRequest()
		{
			return null;
		}

		// Token: 0x06018BBE RID: 101310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BBE")]
		protected virtual void OnParseRequest(TReq request)
		{
		}

		// Token: 0x0401E629 RID: 124457
		[Token(Token = "0x401E629")]
		[FieldOffset(Offset = "0x0")]
		private SquadHomeStartBattleServicePluginBase.Param m_param;

		// Token: 0x0401E62A RID: 124458
		[Token(Token = "0x401E62A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401E62B RID: 124459
		[Token(Token = "0x401E62B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ParseRequest;

		// Token: 0x0401E62C RID: 124460
		[Token(Token = "0x401E62C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnParseRequest;
	}
}
