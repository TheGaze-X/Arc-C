using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006434 RID: 25652
	[Token(Token = "0x2006434")]
	public class AutoChessBattlePlayerDeploymentInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EC7 RID: 151239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC7")]
		[Address(RVA = "0x1FC5A30", Offset = "0x1FC4630", VA = "0x181FC5A30", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EC8 RID: 151240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC8")]
		[Address(RVA = "0x1FC5BD0", Offset = "0x1FC47D0", VA = "0x181FC5BD0")]
		public AutoChessBattlePlayerDeploymentInfo()
		{
		}

		// Token: 0x04033A55 RID: 211541
		[Token(Token = "0x4033A55")]
		[FieldOffset(Offset = "0x10")]
		public int uidIndex;

		// Token: 0x04033A56 RID: 211542
		[Token(Token = "0x4033A56")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessBattleCharChess> charChess;

		// Token: 0x04033A57 RID: 211543
		[Token(Token = "0x4033A57")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessBattleEquipOrTrapChess> equipChess;

		// Token: 0x04033A58 RID: 211544
		[Token(Token = "0x4033A58")]
		[FieldOffset(Offset = "0x28")]
		public List<AutoChessBattleEquipOrTrapChess> trapChess;

		// Token: 0x04033A59 RID: 211545
		[Token(Token = "0x4033A59")]
		[FieldOffset(Offset = "0x30")]
		public List<AutoChessBattleChessPosUnitInfo> positions;

		// Token: 0x04033A5A RID: 211546
		[Token(Token = "0x4033A5A")]
		[FieldOffset(Offset = "0x38")]
		public List<AutoChessBattleChessBondInfo> bonds;

		// Token: 0x04033A5B RID: 211547
		[Token(Token = "0x4033A5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A5C RID: 211548
		[Token(Token = "0x4033A5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
