using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E26 RID: 15910
	[Token(Token = "0x2003E26")]
	public abstract class SquadHomeStartBattleServicePlugin<TConfig, TReq, TRes> : SquadHomeStartBattleServicePluginBase where TConfig : SquadCustomStartBattleServiceConfig<TReq, TRes> where TReq : DefaultStartBattleRequest, new() where TRes : DefaultStartBattleResponse
	{
		// Token: 0x06018BC3 RID: 101315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BC3")]
		public override IStartBattleServiceConfig CreateStartBattleServiceConfig()
		{
			return null;
		}

		// Token: 0x06018BC4 RID: 101316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BC4")]
		public override void SetParams(SquadHomeStartBattleServicePluginBase.Param param)
		{
		}

		// Token: 0x06018BC5 RID: 101317
		[Token(Token = "0x6018BC5")]
		public abstract TConfig DoCreateStartBattleServiceConfig(SquadHomeStartBattleServicePluginBase.Param param);

		// Token: 0x06018BC6 RID: 101318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BC6")]
		protected SquadHomeStartBattleServicePlugin()
		{
		}

		// Token: 0x0401E639 RID: 124473
		[Token(Token = "0x401E639")]
		[FieldOffset(Offset = "0x0")]
		private SquadHomeStartBattleServicePluginBase.Param m_param;

		// Token: 0x0401E63A RID: 124474
		[Token(Token = "0x401E63A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateStartBattleServiceConfig;

		// Token: 0x0401E63B RID: 124475
		[Token(Token = "0x401E63B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetParams;

		// Token: 0x0401E63C RID: 124476
		[Token(Token = "0x401E63C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
