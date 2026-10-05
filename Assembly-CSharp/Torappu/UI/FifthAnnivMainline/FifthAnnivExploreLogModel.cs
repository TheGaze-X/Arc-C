using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E9D RID: 20125
	[Token(Token = "0x2004E9D")]
	public class FifthAnnivExploreLogModel : IHotfixable
	{
		// Token: 0x0601E05A RID: 122970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E05A")]
		[Address(RVA = "0x17BDFD0", Offset = "0x17BCBD0", VA = "0x1817BDFD0")]
		public void LoadData(FifthAnnivExploreEventPlanModel currPlanModel, FifthAnnivService.ExploreSelectEventOptionResponse response)
		{
		}

		// Token: 0x0601E05B RID: 122971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E05B")]
		[Address(RVA = "0x17BE390", Offset = "0x17BCF90", VA = "0x1817BE390")]
		public FifthAnnivExploreLogModel()
		{
		}

		// Token: 0x04027EAD RID: 163501
		[Token(Token = "0x4027EAD")]
		[FieldOffset(Offset = "0x10")]
		public int seqNum;

		// Token: 0x04027EAE RID: 163502
		[Token(Token = "0x4027EAE")]
		[FieldOffset(Offset = "0x18")]
		public string eventTitle;

		// Token: 0x04027EAF RID: 163503
		[Token(Token = "0x4027EAF")]
		[FieldOffset(Offset = "0x20")]
		public string eventTypeDesc;

		// Token: 0x04027EB0 RID: 163504
		[Token(Token = "0x4027EB0")]
		[FieldOffset(Offset = "0x28")]
		public string eventDesc;

		// Token: 0x04027EB1 RID: 163505
		[Token(Token = "0x4027EB1")]
		[FieldOffset(Offset = "0x30")]
		public string choiceTitle;

		// Token: 0x04027EB2 RID: 163506
		[Token(Token = "0x4027EB2")]
		[FieldOffset(Offset = "0x38")]
		public string choiceDesc;

		// Token: 0x04027EB3 RID: 163507
		[Token(Token = "0x4027EB3")]
		[FieldOffset(Offset = "0x40")]
		public bool isSuccess;

		// Token: 0x04027EB4 RID: 163508
		[Token(Token = "0x4027EB4")]
		[FieldOffset(Offset = "0x48")]
		public string resDesc;

		// Token: 0x04027EB5 RID: 163509
		[Token(Token = "0x4027EB5")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, int> deltaValues;

		// Token: 0x04027EB6 RID: 163510
		[Token(Token = "0x4027EB6")]
		[FieldOffset(Offset = "0x58")]
		public string eventIconId;

		// Token: 0x04027EB7 RID: 163511
		[Token(Token = "0x4027EB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027EB8 RID: 163512
		[Token(Token = "0x4027EB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
