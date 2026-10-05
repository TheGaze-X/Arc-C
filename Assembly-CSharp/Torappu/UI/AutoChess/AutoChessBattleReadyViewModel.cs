using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.Server;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062A8 RID: 25256
	[Token(Token = "0x20062A8")]
	public class AutoChessBattleReadyViewModel : IHotfixable
	{
		// Token: 0x0602467F RID: 149119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602467F")]
		[Address(RVA = "0x1F37E10", Offset = "0x1F36A10", VA = "0x181F37E10")]
		public void LoadData(bool isSingle, List<MsgAutoChessPlayerStatus> playerStatus)
		{
		}

		// Token: 0x06024680 RID: 149120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024680")]
		[Address(RVA = "0x1F38010", Offset = "0x1F36C10", VA = "0x181F38010")]
		public AutoChessBattleReadyViewModel()
		{
		}

		// Token: 0x04032A9A RID: 207514
		[Token(Token = "0x4032A9A")]
		[FieldOffset(Offset = "0x10")]
		public bool isSingleMode;

		// Token: 0x04032A9B RID: 207515
		[Token(Token = "0x4032A9B")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessBattleReadyPlayerModel> playerList;

		// Token: 0x04032A9C RID: 207516
		[Token(Token = "0x4032A9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032A9D RID: 207517
		[Token(Token = "0x4032A9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
