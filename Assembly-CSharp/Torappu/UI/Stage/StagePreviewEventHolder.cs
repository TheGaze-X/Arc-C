using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x02006924 RID: 26916
	[Token(Token = "0x2006924")]
	public class StagePreviewEventHolder
	{
		// Token: 0x060268D8 RID: 157912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268D8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StagePreviewEventHolder()
		{
		}

		// Token: 0x040365F3 RID: 222707
		[Token(Token = "0x40365F3")]
		[FieldOffset(Offset = "0x10")]
		public Action startBattle;

		// Token: 0x040365F4 RID: 222708
		[Token(Token = "0x40365F4")]
		[FieldOffset(Offset = "0x18")]
		public Action openEnemy;

		// Token: 0x040365F5 RID: 222709
		[Token(Token = "0x40365F5")]
		[FieldOffset(Offset = "0x20")]
		public Action openCampaginRules;

		// Token: 0x040365F6 RID: 222710
		[Token(Token = "0x40365F6")]
		[FieldOffset(Offset = "0x28")]
		public Action rewardClick;

		// Token: 0x040365F7 RID: 222711
		[Token(Token = "0x40365F7")]
		[FieldOffset(Offset = "0x30")]
		public Action beSpecial;

		// Token: 0x040365F8 RID: 222712
		[Token(Token = "0x40365F8")]
		[FieldOffset(Offset = "0x38")]
		public Action beNormal;

		// Token: 0x040365F9 RID: 222713
		[Token(Token = "0x40365F9")]
		[FieldOffset(Offset = "0x40")]
		public Action onPractise;

		// Token: 0x040365FA RID: 222714
		[Token(Token = "0x40365FA")]
		[FieldOffset(Offset = "0x48")]
		public Action onAutoBattleSwitch;

		// Token: 0x040365FB RID: 222715
		[Token(Token = "0x40365FB")]
		[FieldOffset(Offset = "0x50")]
		public Action onLockedHardBattleClick;

		// Token: 0x040365FC RID: 222716
		[Token(Token = "0x40365FC")]
		[FieldOffset(Offset = "0x58")]
		public Action onReplayStoryOpenClick;

		// Token: 0x040365FD RID: 222717
		[Token(Token = "0x40365FD")]
		[FieldOffset(Offset = "0x60")]
		public Action onOpenDiffGroupRewardDetail;

		// Token: 0x040365FE RID: 222718
		[Token(Token = "0x40365FE")]
		[FieldOffset(Offset = "0x68")]
		public Action onMultipleBattleClick;
	}
}
