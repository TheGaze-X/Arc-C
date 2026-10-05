using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006439 RID: 25657
	[Token(Token = "0x2006439")]
	public class AutoChessBattlePlayerLastBattleResult : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024ED2 RID: 151250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED2")]
		[Address(RVA = "0x1FC5C30", Offset = "0x1FC4830", VA = "0x181FC5C30", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024ED3 RID: 151251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED3")]
		[Address(RVA = "0x1FC5CE0", Offset = "0x1FC48E0", VA = "0x181FC5CE0")]
		public AutoChessBattlePlayerLastBattleResult()
		{
		}

		// Token: 0x04033A76 RID: 211574
		[Token(Token = "0x4033A76")]
		[FieldOffset(Offset = "0x10")]
		public int uidIndex;

		// Token: 0x04033A77 RID: 211575
		[Token(Token = "0x4033A77")]
		[FieldOffset(Offset = "0x14")]
		public int hpCost;

		// Token: 0x04033A78 RID: 211576
		[Token(Token = "0x4033A78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A79 RID: 211577
		[Token(Token = "0x4033A79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
