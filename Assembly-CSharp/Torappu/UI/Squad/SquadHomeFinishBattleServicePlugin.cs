using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E2A RID: 15914
	[Token(Token = "0x2003E2A")]
	public abstract class SquadHomeFinishBattleServicePlugin<TConfig, TReq, TRes> : SquadHomeFinishBattleServicePluginBase where TConfig : SquadCustomFinishBattleServiceConfig<TReq, TRes> where TReq : DefaultFinishBattleRequest, new() where TRes : DefaultFinishBattleResponse, new()
	{
		// Token: 0x06018BCC RID: 101324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BCC")]
		public override IFinishBattleServiceConfig CreateFinishBattleServiceConfig()
		{
			return null;
		}

		// Token: 0x06018BCD RID: 101325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BCD")]
		public override void SetParams(SquadHomeFinishBattleServicePluginBase.Param param)
		{
		}

		// Token: 0x06018BCE RID: 101326
		[Token(Token = "0x6018BCE")]
		public abstract TConfig DoCreateFinishBattleServiceConfig(SquadHomeFinishBattleServicePluginBase.Param param);

		// Token: 0x06018BCF RID: 101327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BCF")]
		protected SquadHomeFinishBattleServicePlugin()
		{
		}

		// Token: 0x0401E63F RID: 124479
		[Token(Token = "0x401E63F")]
		[FieldOffset(Offset = "0x0")]
		private SquadHomeFinishBattleServicePluginBase.Param m_param;

		// Token: 0x0401E640 RID: 124480
		[Token(Token = "0x401E640")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateFinishBattleServiceConfig;

		// Token: 0x0401E641 RID: 124481
		[Token(Token = "0x401E641")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetParams;

		// Token: 0x0401E642 RID: 124482
		[Token(Token = "0x401E642")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
