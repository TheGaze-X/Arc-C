using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002084 RID: 8324
	[Token(Token = "0x2002084")]
	public class EnemyHandbookCondTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD40 RID: 52544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD40")]
		[Address(RVA = "0x34FE860", Offset = "0x34FD460", VA = "0x1834FE860", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD41 RID: 52545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD41")]
		[Address(RVA = "0x34FE8C0", Offset = "0x34FD4C0", VA = "0x1834FE8C0")]
		public EnemyHandbookCondTrigger()
		{
		}

		// Token: 0x0400D88A RID: 55434
		[Token(Token = "0x400D88A")]
		[FieldOffset(Offset = "0x20")]
		public string enemyId;

		// Token: 0x0400D88B RID: 55435
		[Token(Token = "0x400D88B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D88C RID: 55436
		[Token(Token = "0x400D88C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
