using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005075 RID: 20597
	[Token(Token = "0x2005075")]
	public class EnemyDuelServiceTeamStartBattleRequest : EnemyDuelServiceTeamRequest
	{
		// Token: 0x17004748 RID: 18248
		// (get) Token: 0x0601E85E RID: 125022 RVA: 0x000AEB28 File Offset: 0x000ACD28
		[Token(Token = "0x17004748")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E85E")]
			[Address(RVA = "0x18485C0", Offset = "0x18471C0", VA = "0x1818485C0", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E85F RID: 125023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E85F")]
		[Address(RVA = "0x1848560", Offset = "0x1847160", VA = "0x181848560")]
		public EnemyDuelServiceTeamStartBattleRequest()
		{
		}

		// Token: 0x04028E16 RID: 167446
		[Token(Token = "0x4028E16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E17 RID: 167447
		[Token(Token = "0x4028E17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
