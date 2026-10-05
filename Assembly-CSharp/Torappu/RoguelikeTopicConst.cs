using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011D7 RID: 4567
	[Token(Token = "0x20011D7")]
	public class RoguelikeTopicConst
	{
		// Token: 0x06006FBB RID: 28603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FBB")]
		[Address(RVA = "0x2112CF0", Offset = "0x21118F0", VA = "0x182112CF0")]
		public RoguelikeTopicConst()
		{
		}

		// Token: 0x040061D4 RID: 25044
		[Token(Token = "0x40061D4")]
		[FieldOffset(Offset = "0x10")]
		public int milestoneTokenRatio;

		// Token: 0x040061D5 RID: 25045
		[Token(Token = "0x40061D5")]
		[FieldOffset(Offset = "0x14")]
		public float outerBuffTokenRatio;

		// Token: 0x040061D6 RID: 25046
		[Token(Token = "0x40061D6")]
		[FieldOffset(Offset = "0x18")]
		public int relicTokenRatio;

		// Token: 0x040061D7 RID: 25047
		[Token(Token = "0x40061D7")]
		[FieldOffset(Offset = "0x20")]
		public string rogueSystemUnlockStage;

		// Token: 0x040061D8 RID: 25048
		[Token(Token = "0x40061D8")]
		[FieldOffset(Offset = "0x28")]
		public int ordiModeReOpenCoolDown;

		// Token: 0x040061D9 RID: 25049
		[Token(Token = "0x40061D9")]
		[FieldOffset(Offset = "0x2C")]
		public int monthModeReOpenCoolDown;

		// Token: 0x040061DA RID: 25050
		[Token(Token = "0x40061DA")]
		[FieldOffset(Offset = "0x30")]
		public int monthlyTaskUncompletedTime;

		// Token: 0x040061DB RID: 25051
		[Token(Token = "0x40061DB")]
		[FieldOffset(Offset = "0x34")]
		public int monthlyTaskManualRefreshLimit;

		// Token: 0x040061DC RID: 25052
		[Token(Token = "0x40061DC")]
		[FieldOffset(Offset = "0x38")]
		public int monthlyTeamUncompletedTime;

		// Token: 0x040061DD RID: 25053
		[Token(Token = "0x40061DD")]
		[FieldOffset(Offset = "0x40")]
		public long bpPurchaseSystemUnlockTime;

		// Token: 0x040061DE RID: 25054
		[Token(Token = "0x40061DE")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, RoguelikeTopicConst.PredefinedChar> predefinedChars;

		// Token: 0x020011D8 RID: 4568
		[Token(Token = "0x20011D8")]
		public class PredefinedChar
		{
			// Token: 0x06006FBC RID: 28604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006FBC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PredefinedChar()
			{
			}

			// Token: 0x040061DF RID: 25055
			[Token(Token = "0x40061DF")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x040061E0 RID: 25056
			[Token(Token = "0x40061E0")]
			[FieldOffset(Offset = "0x18")]
			public bool canBeFree;

			// Token: 0x040061E1 RID: 25057
			[Token(Token = "0x40061E1")]
			[FieldOffset(Offset = "0x20")]
			public string uniEquipId;

			// Token: 0x040061E2 RID: 25058
			[Token(Token = "0x40061E2")]
			[FieldOffset(Offset = "0x28")]
			public RoguelikeCharState recruitType;
		}
	}
}
