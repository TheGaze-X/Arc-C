using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005076 RID: 20598
	[Token(Token = "0x2005076")]
	public class EnemyDuelServiceTeamContinueRequest : EnemyDuelServiceTeamRequest
	{
		// Token: 0x17004749 RID: 18249
		// (get) Token: 0x0601E860 RID: 125024 RVA: 0x000AEB40 File Offset: 0x000ACD40
		[Token(Token = "0x17004749")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E860")]
			[Address(RVA = "0x1847DF0", Offset = "0x18469F0", VA = "0x181847DF0", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E861 RID: 125025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E861")]
		[Address(RVA = "0x1847D90", Offset = "0x1846990", VA = "0x181847D90")]
		public EnemyDuelServiceTeamContinueRequest()
		{
		}

		// Token: 0x04028E18 RID: 167448
		[Token(Token = "0x4028E18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E19 RID: 167449
		[Token(Token = "0x4028E19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
