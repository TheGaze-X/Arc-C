using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006418 RID: 25624
	[Token(Token = "0x2006418")]
	public struct AutoChessBattleAllStateSyncData : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024E8A RID: 151178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E8A")]
		[Address(RVA = "0x1FAEF60", Offset = "0x1FADB60", VA = "0x181FAEF60", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04033992 RID: 211346
		[Token(Token = "0x4033992")]
		[FieldOffset(Offset = "0x0")]
		public string modeId;

		// Token: 0x04033993 RID: 211347
		[Token(Token = "0x4033993")]
		[FieldOffset(Offset = "0x8")]
		public string stageId;

		// Token: 0x04033994 RID: 211348
		[Token(Token = "0x4033994")]
		[FieldOffset(Offset = "0x10")]
		public string bossId;

		// Token: 0x04033995 RID: 211349
		[Token(Token = "0x4033995")]
		[FieldOffset(Offset = "0x18")]
		public string hiddenBossId;

		// Token: 0x04033996 RID: 211350
		[Token(Token = "0x4033996")]
		[FieldOffset(Offset = "0x20")]
		public int stageSeed;

		// Token: 0x04033997 RID: 211351
		[Token(Token = "0x4033997")]
		[FieldOffset(Offset = "0x24")]
		public int uidIndex;

		// Token: 0x04033998 RID: 211352
		[Token(Token = "0x4033998")]
		[FieldOffset(Offset = "0x28")]
		public List<string> bannedBonds;

		// Token: 0x04033999 RID: 211353
		[Token(Token = "0x4033999")]
		[FieldOffset(Offset = "0x30")]
		public List<AutoChessBattlePlayerStaticInfo> staticPlayers;

		// Token: 0x0403399A RID: 211354
		[Token(Token = "0x403399A")]
		[FieldOffset(Offset = "0x38")]
		public AutoChessBattleSceneStatus sceneDetail;

		// Token: 0x0403399B RID: 211355
		[Token(Token = "0x403399B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;
	}
}
