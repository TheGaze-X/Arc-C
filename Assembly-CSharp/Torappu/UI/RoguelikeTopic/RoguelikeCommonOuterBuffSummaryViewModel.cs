using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200451B RID: 17691
	[Token(Token = "0x200451B")]
	public class RoguelikeCommonOuterBuffSummaryViewModel : IHotfixable
	{
		// Token: 0x0601AFA5 RID: 110501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFA5")]
		[Address(RVA = "0x1422E30", Offset = "0x1421A30", VA = "0x181422E30")]
		public void LoadData(string topic, RoguelikeCommonDevelopmentData developmentData)
		{
		}

		// Token: 0x0601AFA6 RID: 110502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFA6")]
		[Address(RVA = "0x1423C20", Offset = "0x1422820", VA = "0x181423C20")]
		public RoguelikeCommonOuterBuffSummaryViewModel()
		{
		}

		// Token: 0x04022A3F RID: 141887
		[Token(Token = "0x4022A3F")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04022A40 RID: 141888
		[Token(Token = "0x4022A40")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeCommonOuterBuffSummaryMergedItemModel> mergedItems;

		// Token: 0x04022A41 RID: 141889
		[Token(Token = "0x4022A41")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeCommonOuterBuffSummaryRawTextGroupItemModel> rawTextGroup;

		// Token: 0x04022A42 RID: 141890
		[Token(Token = "0x4022A42")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikeCommonOuterBuffSummaryDifficultyItemModel> difficultyItems;

		// Token: 0x04022A43 RID: 141891
		[Token(Token = "0x4022A43")]
		[FieldOffset(Offset = "0x30")]
		public int buffCount;

		// Token: 0x04022A44 RID: 141892
		[Token(Token = "0x4022A44")]
		[FieldOffset(Offset = "0x34")]
		public int unlockCount;

		// Token: 0x04022A45 RID: 141893
		[Token(Token = "0x4022A45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022A46 RID: 141894
		[Token(Token = "0x4022A46")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
