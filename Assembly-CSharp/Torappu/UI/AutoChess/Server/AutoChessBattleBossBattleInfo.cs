using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006437 RID: 25655
	[Token(Token = "0x2006437")]
	public class AutoChessBattleBossBattleInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024ECE RID: 151246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ECE")]
		[Address(RVA = "0x1FC4EF0", Offset = "0x1FC3AF0", VA = "0x181FC4EF0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024ECF RID: 151247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ECF")]
		[Address(RVA = "0x1FC5040", Offset = "0x1FC3C40", VA = "0x181FC5040")]
		public AutoChessBattleBossBattleInfo()
		{
		}

		// Token: 0x04033A6A RID: 211562
		[Token(Token = "0x4033A6A")]
		[FieldOffset(Offset = "0x10")]
		public BossPlayerGroup group;

		// Token: 0x04033A6B RID: 211563
		[Token(Token = "0x4033A6B")]
		[FieldOffset(Offset = "0x14")]
		public int bossHp;

		// Token: 0x04033A6C RID: 211564
		[Token(Token = "0x4033A6C")]
		[FieldOffset(Offset = "0x18")]
		public int enemyCount;

		// Token: 0x04033A6D RID: 211565
		[Token(Token = "0x4033A6D")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessBattleBossEnemyUnitInfo> enemyGroup;

		// Token: 0x04033A6E RID: 211566
		[Token(Token = "0x4033A6E")]
		[FieldOffset(Offset = "0x28")]
		public List<AutoChessBattlePlayerDeploymentInfo> players;

		// Token: 0x04033A6F RID: 211567
		[Token(Token = "0x4033A6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A70 RID: 211568
		[Token(Token = "0x4033A70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
