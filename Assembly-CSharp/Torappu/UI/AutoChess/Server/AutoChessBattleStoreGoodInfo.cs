using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006425 RID: 25637
	[Token(Token = "0x2006425")]
	public class AutoChessBattleStoreGoodInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EA7 RID: 151207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA7")]
		[Address(RVA = "0x1FB4670", Offset = "0x1FB3270", VA = "0x181FB4670", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EA8 RID: 151208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA8")]
		[Address(RVA = "0x1FB4760", Offset = "0x1FB3360", VA = "0x181FB4760")]
		public AutoChessBattleStoreGoodInfo()
		{
		}

		// Token: 0x04033A0D RID: 211469
		[Token(Token = "0x4033A0D")]
		[FieldOffset(Offset = "0x10")]
		public int chessIdentifier;

		// Token: 0x04033A0E RID: 211470
		[Token(Token = "0x4033A0E")]
		[FieldOffset(Offset = "0x14")]
		public int slotId;

		// Token: 0x04033A0F RID: 211471
		[Token(Token = "0x4033A0F")]
		[FieldOffset(Offset = "0x18")]
		public int price;

		// Token: 0x04033A10 RID: 211472
		[Token(Token = "0x4033A10")]
		[FieldOffset(Offset = "0x1C")]
		public bool isFrozen;

		// Token: 0x04033A11 RID: 211473
		[Token(Token = "0x4033A11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A12 RID: 211474
		[Token(Token = "0x4033A12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
