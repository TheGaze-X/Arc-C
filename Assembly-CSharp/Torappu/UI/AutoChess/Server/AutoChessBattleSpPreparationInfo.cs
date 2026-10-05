using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006421 RID: 25633
	[Token(Token = "0x2006421")]
	public class AutoChessBattleSpPreparationInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024E9F RID: 151199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E9F")]
		[Address(RVA = "0x1FB4070", Offset = "0x1FB2C70", VA = "0x181FB4070", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EA0 RID: 151200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA0")]
		[Address(RVA = "0x1FB41C0", Offset = "0x1FB2DC0", VA = "0x181FB41C0")]
		public AutoChessBattleSpPreparationInfo()
		{
		}

		// Token: 0x040339E7 RID: 211431
		[Token(Token = "0x40339E7")]
		[FieldOffset(Offset = "0x10")]
		public List<AutoChessBattleSpPrepareSlot> options;

		// Token: 0x040339E8 RID: 211432
		[Token(Token = "0x40339E8")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessBattleSpPreparePlayer> playersQueue;

		// Token: 0x040339E9 RID: 211433
		[Token(Token = "0x40339E9")]
		[FieldOffset(Offset = "0x20")]
		public string spId;

		// Token: 0x040339EA RID: 211434
		[Token(Token = "0x40339EA")]
		[FieldOffset(Offset = "0x28")]
		public long finTs;

		// Token: 0x040339EB RID: 211435
		[Token(Token = "0x40339EB")]
		[FieldOffset(Offset = "0x30")]
		public int currQueueIndex;

		// Token: 0x040339EC RID: 211436
		[Token(Token = "0x40339EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339ED RID: 211437
		[Token(Token = "0x40339ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
