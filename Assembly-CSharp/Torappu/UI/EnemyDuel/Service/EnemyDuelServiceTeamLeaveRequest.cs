using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005072 RID: 20594
	[Token(Token = "0x2005072")]
	public class EnemyDuelServiceTeamLeaveRequest : EnemyDuelServiceTeamRequest
	{
		// Token: 0x17004745 RID: 18245
		// (get) Token: 0x0601E854 RID: 125012 RVA: 0x000AEAE0 File Offset: 0x000ACCE0
		[Token(Token = "0x17004745")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E854")]
			[Address(RVA = "0x18482A0", Offset = "0x1846EA0", VA = "0x1818482A0", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E855 RID: 125013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E855")]
		[Address(RVA = "0x1848240", Offset = "0x1846E40", VA = "0x181848240")]
		public EnemyDuelServiceTeamLeaveRequest()
		{
		}

		// Token: 0x04028E0C RID: 167436
		[Token(Token = "0x4028E0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E0D RID: 167437
		[Token(Token = "0x4028E0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
