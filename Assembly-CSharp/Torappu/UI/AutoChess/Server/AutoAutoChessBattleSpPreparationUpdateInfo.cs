using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006422 RID: 25634
	[Token(Token = "0x2006422")]
	public class AutoAutoChessBattleSpPreparationUpdateInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EA1 RID: 151201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA1")]
		[Address(RVA = "0x1FAEE10", Offset = "0x1FADA10", VA = "0x181FAEE10", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EA2 RID: 151202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA2")]
		[Address(RVA = "0x1FAEF00", Offset = "0x1FADB00", VA = "0x181FAEF00")]
		public AutoAutoChessBattleSpPreparationUpdateInfo()
		{
		}

		// Token: 0x040339EE RID: 211438
		[Token(Token = "0x40339EE")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessBattleSpPreparePlayer playerChoice;

		// Token: 0x040339EF RID: 211439
		[Token(Token = "0x40339EF")]
		[FieldOffset(Offset = "0x18")]
		public long finTs;

		// Token: 0x040339F0 RID: 211440
		[Token(Token = "0x40339F0")]
		[FieldOffset(Offset = "0x20")]
		public int currQueueIndex;

		// Token: 0x040339F1 RID: 211441
		[Token(Token = "0x40339F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339F2 RID: 211442
		[Token(Token = "0x40339F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
