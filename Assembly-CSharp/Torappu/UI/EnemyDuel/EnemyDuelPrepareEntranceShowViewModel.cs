using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200502F RID: 20527
	[Token(Token = "0x200502F")]
	public class EnemyDuelPrepareEntranceShowViewModel : IHotfixable
	{
		// Token: 0x0601E723 RID: 124707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E723")]
		[Address(RVA = "0x1825C40", Offset = "0x1824840", VA = "0x181825C40")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601E724 RID: 124708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E724")]
		[Address(RVA = "0x1825FE0", Offset = "0x1824BE0", VA = "0x181825FE0")]
		public EnemyDuelPrepareEntranceShowViewModel()
		{
		}

		// Token: 0x04028BF5 RID: 166901
		[Token(Token = "0x4028BF5")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04028BF6 RID: 166902
		[Token(Token = "0x4028BF6")]
		[FieldOffset(Offset = "0x18")]
		public int maxPlayerCnt;

		// Token: 0x04028BF7 RID: 166903
		[Token(Token = "0x4028BF7")]
		[FieldOffset(Offset = "0x1C")]
		public EnemyDuelModeType modeType;

		// Token: 0x04028BF8 RID: 166904
		[Token(Token = "0x4028BF8")]
		[FieldOffset(Offset = "0x20")]
		public List<EnemyDuelPrepareEntranceShowPlayerViewModel> playerViewModels;

		// Token: 0x04028BF9 RID: 166905
		[Token(Token = "0x4028BF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028BFA RID: 166906
		[Token(Token = "0x4028BFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
