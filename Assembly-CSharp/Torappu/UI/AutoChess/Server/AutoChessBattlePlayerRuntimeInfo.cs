using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200641A RID: 25626
	[Token(Token = "0x200641A")]
	public class AutoChessBattlePlayerRuntimeInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024E8D RID: 151181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E8D")]
		[Address(RVA = "0x1FB01F0", Offset = "0x1FAEDF0", VA = "0x181FB01F0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024E8E RID: 151182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E8E")]
		[Address(RVA = "0x1FB0320", Offset = "0x1FAEF20", VA = "0x181FB0320")]
		public AutoChessBattlePlayerRuntimeInfo()
		{
		}

		// Token: 0x040339A3 RID: 211363
		[Token(Token = "0x40339A3")]
		[FieldOffset(Offset = "0x10")]
		public int uidIndex;

		// Token: 0x040339A4 RID: 211364
		[Token(Token = "0x40339A4")]
		[FieldOffset(Offset = "0x14")]
		public bool gameFinish;

		// Token: 0x040339A5 RID: 211365
		[Token(Token = "0x40339A5")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessPlayerConnectStateType connectState;

		// Token: 0x040339A6 RID: 211366
		[Token(Token = "0x40339A6")]
		[FieldOffset(Offset = "0x1C")]
		public int shopLv;

		// Token: 0x040339A7 RID: 211367
		[Token(Token = "0x40339A7")]
		[FieldOffset(Offset = "0x20")]
		public int hp;

		// Token: 0x040339A8 RID: 211368
		[Token(Token = "0x40339A8")]
		[FieldOffset(Offset = "0x24")]
		public AutoChessPlayerGameStateType state;

		// Token: 0x040339A9 RID: 211369
		[Token(Token = "0x40339A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339AA RID: 211370
		[Token(Token = "0x40339AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
