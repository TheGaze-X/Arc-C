using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200641F RID: 25631
	[Token(Token = "0x200641F")]
	public class AutoChessBattleSpPrepareSlot : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024E9B RID: 151195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E9B")]
		[Address(RVA = "0x1FB4330", Offset = "0x1FB2F30", VA = "0x181FB4330", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024E9C RID: 151196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E9C")]
		[Address(RVA = "0x1FB4410", Offset = "0x1FB3010", VA = "0x181FB4410")]
		public AutoChessBattleSpPrepareSlot()
		{
		}

		// Token: 0x040339DE RID: 211422
		[Token(Token = "0x40339DE")]
		[FieldOffset(Offset = "0x10")]
		public string unitId;

		// Token: 0x040339DF RID: 211423
		[Token(Token = "0x40339DF")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x040339E0 RID: 211424
		[Token(Token = "0x40339E0")]
		[FieldOffset(Offset = "0x1C")]
		public int price;

		// Token: 0x040339E1 RID: 211425
		[Token(Token = "0x40339E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339E2 RID: 211426
		[Token(Token = "0x40339E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
