using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200507E RID: 20606
	[Token(Token = "0x200507E")]
	public class EnemyDuelServiceBattleFinalSettleRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x17004751 RID: 18257
		// (get) Token: 0x0601E878 RID: 125048 RVA: 0x000AEC00 File Offset: 0x000ACE00
		[Token(Token = "0x17004751")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E878")]
			[Address(RVA = "0x1840200", Offset = "0x183EE00", VA = "0x181840200", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E879 RID: 125049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E879")]
		[Address(RVA = "0x18401A0", Offset = "0x183EDA0", VA = "0x1818401A0")]
		public EnemyDuelServiceBattleFinalSettleRequest()
		{
		}

		// Token: 0x04028E36 RID: 167478
		[Token(Token = "0x4028E36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E37 RID: 167479
		[Token(Token = "0x4028E37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
