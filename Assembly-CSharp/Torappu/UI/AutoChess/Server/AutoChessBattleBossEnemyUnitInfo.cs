using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200643A RID: 25658
	[Token(Token = "0x200643A")]
	public class AutoChessBattleBossEnemyUnitInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024ED4 RID: 151252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED4")]
		[Address(RVA = "0x1FC50A0", Offset = "0x1FC3CA0", VA = "0x181FC50A0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024ED5 RID: 151253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED5")]
		[Address(RVA = "0x1FC51A0", Offset = "0x1FC3DA0", VA = "0x181FC51A0")]
		public AutoChessBattleBossEnemyUnitInfo()
		{
		}

		// Token: 0x04033A7A RID: 211578
		[Token(Token = "0x4033A7A")]
		[FieldOffset(Offset = "0x10")]
		public BossPlayerGroup playerGroup;

		// Token: 0x04033A7B RID: 211579
		[Token(Token = "0x4033A7B")]
		[FieldOffset(Offset = "0x18")]
		public string enemyId;

		// Token: 0x04033A7C RID: 211580
		[Token(Token = "0x4033A7C")]
		[FieldOffset(Offset = "0x20")]
		public int actionIndex;

		// Token: 0x04033A7D RID: 211581
		[Token(Token = "0x4033A7D")]
		[FieldOffset(Offset = "0x28")]
		public List<int> instIdList;

		// Token: 0x04033A7E RID: 211582
		[Token(Token = "0x4033A7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A7F RID: 211583
		[Token(Token = "0x4033A7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
