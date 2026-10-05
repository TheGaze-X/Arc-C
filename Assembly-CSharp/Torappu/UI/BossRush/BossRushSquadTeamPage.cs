using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200617D RID: 24957
	[Token(Token = "0x200617D")]
	public class BossRushSquadTeamPage : StateEnginePage
	{
		// Token: 0x06024013 RID: 147475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024013")]
		[Address(RVA = "0x1EABE00", Offset = "0x1EAAA00", VA = "0x181EABE00")]
		public BossRushSquadTeamPage()
		{
		}

		// Token: 0x0403204C RID: 204876
		[Token(Token = "0x403204C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200617E RID: 24958
		[Token(Token = "0x200617E")]
		public struct Params
		{
			// Token: 0x0403204D RID: 204877
			[Token(Token = "0x403204D")]
			[FieldOffset(Offset = "0x0")]
			public string activityId;

			// Token: 0x0403204E RID: 204878
			[Token(Token = "0x403204E")]
			[FieldOffset(Offset = "0x8")]
			public string stageGroupId;

			// Token: 0x0403204F RID: 204879
			[Token(Token = "0x403204F")]
			[FieldOffset(Offset = "0x10")]
			public StageId stageId;

			// Token: 0x04032050 RID: 204880
			[Token(Token = "0x4032050")]
			[FieldOffset(Offset = "0x28")]
			public string teamId;
		}
	}
}
