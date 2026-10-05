using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004567 RID: 17767
	[Token(Token = "0x2004567")]
	public class RoguelikeTopicBattlePassPurchaseOverviewViewModel : IHotfixable
	{
		// Token: 0x0601B121 RID: 110881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B121")]
		[Address(RVA = "0x1432000", Offset = "0x1430C00", VA = "0x181432000")]
		public RoguelikeTopicBattlePassPurchaseOverviewViewModel()
		{
		}

		// Token: 0x04022CB1 RID: 142513
		[Token(Token = "0x4022CB1")]
		[FieldOffset(Offset = "0x10")]
		public int srcLevel;

		// Token: 0x04022CB2 RID: 142514
		[Token(Token = "0x4022CB2")]
		[FieldOffset(Offset = "0x14")]
		public int dstLevel;

		// Token: 0x04022CB3 RID: 142515
		[Token(Token = "0x4022CB3")]
		[FieldOffset(Offset = "0x18")]
		public int maxLevel;

		// Token: 0x04022CB4 RID: 142516
		[Token(Token = "0x4022CB4")]
		[FieldOffset(Offset = "0x20")]
		public string srcBpId;

		// Token: 0x04022CB5 RID: 142517
		[Token(Token = "0x4022CB5")]
		[FieldOffset(Offset = "0x28")]
		public string dstBpId;

		// Token: 0x04022CB6 RID: 142518
		[Token(Token = "0x4022CB6")]
		[FieldOffset(Offset = "0x30")]
		public string topicId;

		// Token: 0x04022CB7 RID: 142519
		[Token(Token = "0x4022CB7")]
		[FieldOffset(Offset = "0x38")]
		public int curBpPoint;

		// Token: 0x04022CB8 RID: 142520
		[Token(Token = "0x4022CB8")]
		[FieldOffset(Offset = "0x40")]
		public RoguelikeTopicBP curBpData;

		// Token: 0x04022CB9 RID: 142521
		[Token(Token = "0x4022CB9")]
		[FieldOffset(Offset = "0x48")]
		public ListDict<int, UIItemViewModel> grandPrizeList;

		// Token: 0x04022CBA RID: 142522
		[Token(Token = "0x4022CBA")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<string, UIItemViewModel> normalPrizeList;

		// Token: 0x04022CBB RID: 142523
		[Token(Token = "0x4022CBB")]
		[FieldOffset(Offset = "0x58")]
		public bool isInit;

		// Token: 0x04022CBC RID: 142524
		[Token(Token = "0x4022CBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
