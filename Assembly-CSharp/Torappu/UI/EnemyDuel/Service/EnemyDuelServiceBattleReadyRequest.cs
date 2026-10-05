using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005078 RID: 20600
	[Token(Token = "0x2005078")]
	public class EnemyDuelServiceBattleReadyRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x1700474B RID: 18251
		// (get) Token: 0x0601E866 RID: 125030 RVA: 0x000AEB70 File Offset: 0x000ACD70
		[Token(Token = "0x1700474B")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E866")]
			[Address(RVA = "0x1843100", Offset = "0x1841D00", VA = "0x181843100", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E867 RID: 125031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E867")]
		[Address(RVA = "0x18430A0", Offset = "0x1841CA0", VA = "0x1818430A0")]
		public EnemyDuelServiceBattleReadyRequest()
		{
		}

		// Token: 0x04028E1E RID: 167454
		[Token(Token = "0x4028E1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E1F RID: 167455
		[Token(Token = "0x4028E1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
