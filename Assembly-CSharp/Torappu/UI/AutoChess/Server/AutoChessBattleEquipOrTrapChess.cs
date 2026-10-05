using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006427 RID: 25639
	[Token(Token = "0x2006427")]
	public class AutoChessBattleEquipOrTrapChess : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EAB RID: 151211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EAB")]
		[Address(RVA = "0x1FAFBF0", Offset = "0x1FAE7F0", VA = "0x181FAFBF0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EAC RID: 151212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EAC")]
		[Address(RVA = "0x1FAFCA0", Offset = "0x1FAE8A0", VA = "0x181FAFCA0")]
		public AutoChessBattleEquipOrTrapChess()
		{
		}

		// Token: 0x04033A18 RID: 211480
		[Token(Token = "0x4033A18")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04033A19 RID: 211481
		[Token(Token = "0x4033A19")]
		[FieldOffset(Offset = "0x14")]
		public int chessIdentifier;

		// Token: 0x04033A1A RID: 211482
		[Token(Token = "0x4033A1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A1B RID: 211483
		[Token(Token = "0x4033A1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
