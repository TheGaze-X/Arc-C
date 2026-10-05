using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200642E RID: 25646
	[Token(Token = "0x200642E")]
	public class AutoChessBattleBossRoundInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EBB RID: 151227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EBB")]
		[Address(RVA = "0x1FAF260", Offset = "0x1FADE60", VA = "0x181FAF260", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EBC RID: 151228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EBC")]
		[Address(RVA = "0x1FAF370", Offset = "0x1FADF70", VA = "0x181FAF370")]
		public AutoChessBattleBossRoundInfo()
		{
		}

		// Token: 0x04033A3B RID: 211515
		[Token(Token = "0x4033A3B")]
		[FieldOffset(Offset = "0x10")]
		public bool isHiddenBoss;

		// Token: 0x04033A3C RID: 211516
		[Token(Token = "0x4033A3C")]
		[FieldOffset(Offset = "0x18")]
		public string bossId;

		// Token: 0x04033A3D RID: 211517
		[Token(Token = "0x4033A3D")]
		[FieldOffset(Offset = "0x20")]
		public int hp;

		// Token: 0x04033A3E RID: 211518
		[Token(Token = "0x4033A3E")]
		[FieldOffset(Offset = "0x28")]
		public List<AutoChessBattleBossBattleGroupInfo> groupInfos;

		// Token: 0x04033A3F RID: 211519
		[Token(Token = "0x4033A3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A40 RID: 211520
		[Token(Token = "0x4033A40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
