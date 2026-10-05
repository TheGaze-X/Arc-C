using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061C4 RID: 25028
	[Token(Token = "0x20061C4")]
	public class BossRushStageModel : IHotfixable
	{
		// Token: 0x060241E9 RID: 147945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241E9")]
		[Address(RVA = "0x1EE2C20", Offset = "0x1EE1820", VA = "0x181EE2C20")]
		public BossRushStageModel()
		{
		}

		// Token: 0x04032361 RID: 205665
		[Token(Token = "0x4032361")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04032362 RID: 205666
		[Token(Token = "0x4032362")]
		[FieldOffset(Offset = "0x18")]
		public ActivityBossRushData.BossRushStageType type;

		// Token: 0x04032363 RID: 205667
		[Token(Token = "0x4032363")]
		[FieldOffset(Offset = "0x20")]
		public StageViewModel stageViewModel;

		// Token: 0x04032364 RID: 205668
		[Token(Token = "0x4032364")]
		[FieldOffset(Offset = "0x28")]
		public string unlockText;

		// Token: 0x04032365 RID: 205669
		[Token(Token = "0x4032365")]
		[FieldOffset(Offset = "0x30")]
		public List<string> teamIdList;

		// Token: 0x04032366 RID: 205670
		[Token(Token = "0x4032366")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
