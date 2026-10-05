using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006429 RID: 25641
	[Token(Token = "0x2006429")]
	public class AutoChessBattleChessBondInfo : IStreamDeserialize, IStreamSerialize, IHotfixable
	{
		// Token: 0x06024EB0 RID: 151216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB0")]
		[Address(RVA = "0x1FAF510", Offset = "0x1FAE110", VA = "0x181FAF510", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EB1 RID: 151217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB1")]
		[Address(RVA = "0x1FAF5F0", Offset = "0x1FAE1F0", VA = "0x181FAF5F0", Slot = "5")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x06024EB2 RID: 151218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB2")]
		[Address(RVA = "0x1FAF6D0", Offset = "0x1FAE2D0", VA = "0x181FAF6D0")]
		public AutoChessBattleChessBondInfo()
		{
		}

		// Token: 0x04033A23 RID: 211491
		[Token(Token = "0x4033A23")]
		[FieldOffset(Offset = "0x10")]
		public int bondIdentifier;

		// Token: 0x04033A24 RID: 211492
		[Token(Token = "0x4033A24")]
		[FieldOffset(Offset = "0x14")]
		public int stackCnt;

		// Token: 0x04033A25 RID: 211493
		[Token(Token = "0x4033A25")]
		[FieldOffset(Offset = "0x18")]
		public int charCnt;

		// Token: 0x04033A26 RID: 211494
		[Token(Token = "0x4033A26")]
		[FieldOffset(Offset = "0x1C")]
		public bool isActive;

		// Token: 0x04033A27 RID: 211495
		[Token(Token = "0x4033A27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A28 RID: 211496
		[Token(Token = "0x4033A28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04033A29 RID: 211497
		[Token(Token = "0x4033A29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
