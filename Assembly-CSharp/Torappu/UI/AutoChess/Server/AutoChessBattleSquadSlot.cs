using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200641B RID: 25627
	[Token(Token = "0x200641B")]
	public class AutoChessBattleSquadSlot : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024E8F RID: 151183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E8F")]
		[Address(RVA = "0x1FB4470", Offset = "0x1FB3070", VA = "0x181FB4470", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024E90 RID: 151184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E90")]
		[Address(RVA = "0x1FB4610", Offset = "0x1FB3210", VA = "0x181FB4610")]
		public AutoChessBattleSquadSlot()
		{
		}

		// Token: 0x040339AB RID: 211371
		[Token(Token = "0x40339AB")]
		[FieldOffset(Offset = "0x10")]
		public string chessId;

		// Token: 0x040339AC RID: 211372
		[Token(Token = "0x40339AC")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x040339AD RID: 211373
		[Token(Token = "0x40339AD")]
		[FieldOffset(Offset = "0x20")]
		public string cultivateEffectId;

		// Token: 0x040339AE RID: 211374
		[Token(Token = "0x40339AE")]
		[FieldOffset(Offset = "0x28")]
		public string currentEquip;

		// Token: 0x040339AF RID: 211375
		[Token(Token = "0x40339AF")]
		[FieldOffset(Offset = "0x30")]
		public string skinId;

		// Token: 0x040339B0 RID: 211376
		[Token(Token = "0x40339B0")]
		[FieldOffset(Offset = "0x38")]
		public int type;

		// Token: 0x040339B1 RID: 211377
		[Token(Token = "0x40339B1")]
		[FieldOffset(Offset = "0x3C")]
		public int potentialRank;

		// Token: 0x040339B2 RID: 211378
		[Token(Token = "0x40339B2")]
		[FieldOffset(Offset = "0x40")]
		public int skillIndex;

		// Token: 0x040339B3 RID: 211379
		[Token(Token = "0x40339B3")]
		[FieldOffset(Offset = "0x48")]
		public List<string> bondList;

		// Token: 0x040339B4 RID: 211380
		[Token(Token = "0x40339B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339B5 RID: 211381
		[Token(Token = "0x40339B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
