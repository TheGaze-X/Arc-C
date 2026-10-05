using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006432 RID: 25650
	[Token(Token = "0x2006432")]
	public class AutoChessBattleHelpBattleInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EC3 RID: 151235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC3")]
		[Address(RVA = "0x1FC5700", Offset = "0x1FC4300", VA = "0x181FC5700", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EC4 RID: 151236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC4")]
		[Address(RVA = "0x1FC57E0", Offset = "0x1FC43E0", VA = "0x181FC57E0")]
		public AutoChessBattleHelpBattleInfo()
		{
		}

		// Token: 0x04033A4D RID: 211533
		[Token(Token = "0x4033A4D")]
		[FieldOffset(Offset = "0x10")]
		public List<AutoChessBattleEscapedEnemyInfo> escapedEnemies;

		// Token: 0x04033A4E RID: 211534
		[Token(Token = "0x4033A4E")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessBattleHelpBattlePlayerInfo> players;

		// Token: 0x04033A4F RID: 211535
		[Token(Token = "0x4033A4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A50 RID: 211536
		[Token(Token = "0x4033A50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
