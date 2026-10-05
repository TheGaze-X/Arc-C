using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200507A RID: 20602
	[Token(Token = "0x200507A")]
	public class EnemyDuelServiceBattleEndRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x1700474D RID: 18253
		// (get) Token: 0x0601E86A RID: 125034 RVA: 0x000AEBA0 File Offset: 0x000ACDA0
		[Token(Token = "0x1700474D")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E86A")]
			[Address(RVA = "0x1840140", Offset = "0x183ED40", VA = "0x181840140", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E86B RID: 125035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E86B")]
		[Address(RVA = "0x18400E0", Offset = "0x183ECE0", VA = "0x1818400E0")]
		public EnemyDuelServiceBattleEndRequest()
		{
		}

		// Token: 0x04028E22 RID: 167458
		[Token(Token = "0x4028E22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E23 RID: 167459
		[Token(Token = "0x4028E23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
