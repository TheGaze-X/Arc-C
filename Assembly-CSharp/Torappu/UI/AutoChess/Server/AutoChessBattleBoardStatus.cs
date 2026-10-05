using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200643B RID: 25659
	[Token(Token = "0x200643B")]
	public class AutoChessBattleBoardStatus : IStreamDeserialize, IStreamSerialize, IHotfixable
	{
		// Token: 0x06024ED6 RID: 151254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED6")]
		[Address(RVA = "0x1FC4CA0", Offset = "0x1FC38A0", VA = "0x181FC4CA0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024ED7 RID: 151255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED7")]
		[Address(RVA = "0x1FC4DB0", Offset = "0x1FC39B0", VA = "0x181FC4DB0", Slot = "5")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x06024ED8 RID: 151256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED8")]
		[Address(RVA = "0x1FC4E90", Offset = "0x1FC3A90", VA = "0x181FC4E90")]
		public AutoChessBattleBoardStatus()
		{
		}

		// Token: 0x04033A80 RID: 211584
		[Token(Token = "0x4033A80")]
		[FieldOffset(Offset = "0x10")]
		public int uidIndex;

		// Token: 0x04033A81 RID: 211585
		[Token(Token = "0x4033A81")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessBattleChessPosUnitInfo> positions;

		// Token: 0x04033A82 RID: 211586
		[Token(Token = "0x4033A82")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessBattleChessBondInfo> updatedBonds;

		// Token: 0x04033A83 RID: 211587
		[Token(Token = "0x4033A83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A84 RID: 211588
		[Token(Token = "0x4033A84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04033A85 RID: 211589
		[Token(Token = "0x4033A85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
