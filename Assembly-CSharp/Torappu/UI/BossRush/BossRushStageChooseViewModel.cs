using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061B1 RID: 25009
	[Token(Token = "0x20061B1")]
	public class BossRushStageChooseViewModel : IHotfixable
	{
		// Token: 0x06024171 RID: 147825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024171")]
		[Address(RVA = "0x1EC48F0", Offset = "0x1EC34F0", VA = "0x181EC48F0")]
		public void LoadData(string actId, bool showEnterAnim)
		{
		}

		// Token: 0x06024172 RID: 147826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024172")]
		[Address(RVA = "0x1EC4EA0", Offset = "0x1EC3AA0", VA = "0x181EC4EA0")]
		public BossRushStageChooseViewModel()
		{
		}

		// Token: 0x04032278 RID: 205432
		[Token(Token = "0x4032278")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, BossRushStageChooseItemModel> stageList;

		// Token: 0x04032279 RID: 205433
		[Token(Token = "0x4032279")]
		[FieldOffset(Offset = "0x18")]
		public string detailStageGroupId;

		// Token: 0x0403227A RID: 205434
		[Token(Token = "0x403227A")]
		[FieldOffset(Offset = "0x20")]
		public int completeStageCount;

		// Token: 0x0403227B RID: 205435
		[Token(Token = "0x403227B")]
		[FieldOffset(Offset = "0x24")]
		public int normalStageCount;

		// Token: 0x0403227C RID: 205436
		[Token(Token = "0x403227C")]
		[FieldOffset(Offset = "0x28")]
		public bool showEnterAnim;

		// Token: 0x0403227D RID: 205437
		[Token(Token = "0x403227D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403227E RID: 205438
		[Token(Token = "0x403227E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
