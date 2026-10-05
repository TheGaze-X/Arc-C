using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005070 RID: 20592
	[Token(Token = "0x2005070")]
	public abstract class EnemyDuelServiceBattleRequest : EnemyDuelServiceRequest
	{
		// Token: 0x17004744 RID: 18244
		// (get) Token: 0x0601E852 RID: 125010 RVA: 0x000AEAC8 File Offset: 0x000ACCC8
		[Token(Token = "0x17004744")]
		public override EnemyDuelServiceRequestTarget target
		{
			[Token(Token = "0x601E852")]
			[Address(RVA = "0x1843200", Offset = "0x1841E00", VA = "0x181843200", Slot = "6")]
			get
			{
				return EnemyDuelServiceRequestTarget.TEAM;
			}
		}

		// Token: 0x0601E853 RID: 125011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E853")]
		[Address(RVA = "0x1843160", Offset = "0x1841D60", VA = "0x181843160")]
		protected EnemyDuelServiceBattleRequest()
		{
		}

		// Token: 0x04028DF9 RID: 167417
		[Token(Token = "0x4028DF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04028DFA RID: 167418
		[Token(Token = "0x4028DFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
