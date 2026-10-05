using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006436 RID: 25654
	[Token(Token = "0x2006436")]
	public class AutoChessHelpBattleKillInfo : IStreamSerialize, IHotfixable
	{
		// Token: 0x06024ECC RID: 151244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ECC")]
		[Address(RVA = "0x1FD6420", Offset = "0x1FD5020", VA = "0x181FD6420", Slot = "4")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x06024ECD RID: 151245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ECD")]
		[Address(RVA = "0x1FD6510", Offset = "0x1FD5110", VA = "0x181FD6510")]
		public AutoChessHelpBattleKillInfo()
		{
		}

		// Token: 0x04033A64 RID: 211556
		[Token(Token = "0x4033A64")]
		[FieldOffset(Offset = "0x10")]
		public int killedByPlayer;

		// Token: 0x04033A65 RID: 211557
		[Token(Token = "0x4033A65")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessBattleEscapedEnemyInfo killedEnemyInfo;

		// Token: 0x04033A66 RID: 211558
		[Token(Token = "0x4033A66")]
		[FieldOffset(Offset = "0x20")]
		public int attackerInstId;

		// Token: 0x04033A67 RID: 211559
		[Token(Token = "0x4033A67")]
		[FieldOffset(Offset = "0x24")]
		public AutoChessBattleDamageSrcType damageSrc;

		// Token: 0x04033A68 RID: 211560
		[Token(Token = "0x4033A68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04033A69 RID: 211561
		[Token(Token = "0x4033A69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
