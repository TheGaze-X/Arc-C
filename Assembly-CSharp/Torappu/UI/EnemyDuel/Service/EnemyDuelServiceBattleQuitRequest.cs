using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005079 RID: 20601
	[Token(Token = "0x2005079")]
	public class EnemyDuelServiceBattleQuitRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x1700474C RID: 18252
		// (get) Token: 0x0601E868 RID: 125032 RVA: 0x000AEB88 File Offset: 0x000ACD88
		[Token(Token = "0x1700474C")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E868")]
			[Address(RVA = "0x1843040", Offset = "0x1841C40", VA = "0x181843040", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E869 RID: 125033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E869")]
		[Address(RVA = "0x1842FE0", Offset = "0x1841BE0", VA = "0x181842FE0")]
		public EnemyDuelServiceBattleQuitRequest()
		{
		}

		// Token: 0x04028E20 RID: 167456
		[Token(Token = "0x4028E20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E21 RID: 167457
		[Token(Token = "0x4028E21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
