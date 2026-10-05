using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002085 RID: 8325
	[Token(Token = "0x2002085")]
	public class EnemyHandbookCondTriggerHolder : PlayerTrackTriggerHolder<EnemyHandbookCondTrigger>
	{
		// Token: 0x0600CD42 RID: 52546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD42")]
		[Address(RVA = "0x34FE6E0", Offset = "0x34FD2E0", VA = "0x1834FE6E0", Slot = "9")]
		protected override IList<string> CreatePlayerDataPathList()
		{
			return null;
		}

		// Token: 0x0600CD43 RID: 52547 RVA: 0x00049FB0 File Offset: 0x000481B0
		[Token(Token = "0x600CD43")]
		[Address(RVA = "0x34FE5B0", Offset = "0x34FD1B0", VA = "0x1834FE5B0", Slot = "10")]
		protected override bool CheckIfToTrigger(EnemyHandbookCondTrigger trigger, PlayerDataModel prevData, PlayerDataModel curData)
		{
			return default(bool);
		}

		// Token: 0x0600CD44 RID: 52548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD44")]
		[Address(RVA = "0x34FE7F0", Offset = "0x34FD3F0", VA = "0x1834FE7F0")]
		public EnemyHandbookCondTriggerHolder()
		{
		}

		// Token: 0x0400D88D RID: 55437
		[Token(Token = "0x400D88D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreatePlayerDataPathList;

		// Token: 0x0400D88E RID: 55438
		[Token(Token = "0x400D88E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfToTrigger;

		// Token: 0x0400D88F RID: 55439
		[Token(Token = "0x400D88F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
