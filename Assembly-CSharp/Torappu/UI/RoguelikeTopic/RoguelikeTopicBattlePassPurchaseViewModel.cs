using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004569 RID: 17769
	[Token(Token = "0x2004569")]
	public class RoguelikeTopicBattlePassPurchaseViewModel : IHotfixable
	{
		// Token: 0x0601B123 RID: 110883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B123")]
		[Address(RVA = "0x1432CE0", Offset = "0x14318E0", VA = "0x181432CE0")]
		public void SelectGrandPrizeOnInit(string selectedGrandPrizeId)
		{
		}

		// Token: 0x0601B124 RID: 110884 RVA: 0x000A42B0 File Offset: 0x000A24B0
		[Token(Token = "0x601B124")]
		[Address(RVA = "0x1432970", Offset = "0x1431570", VA = "0x181432970")]
		public int GetIndexByBpLevel(int level)
		{
			return 0;
		}

		// Token: 0x0601B125 RID: 110885 RVA: 0x000A42C8 File Offset: 0x000A24C8
		[Token(Token = "0x601B125")]
		[Address(RVA = "0x1432590", Offset = "0x1431190", VA = "0x181432590")]
		public bool GetBpLevelByIndex(int index, out int level)
		{
			return default(bool);
		}

		// Token: 0x0601B126 RID: 110886 RVA: 0x000A42E0 File Offset: 0x000A24E0
		[Token(Token = "0x601B126")]
		[Address(RVA = "0x1432BB0", Offset = "0x14317B0", VA = "0x181432BB0")]
		public bool GetSelectedLevel(out int level)
		{
			return default(bool);
		}

		// Token: 0x0601B127 RID: 110887 RVA: 0x000A42F8 File Offset: 0x000A24F8
		[Token(Token = "0x601B127")]
		[Address(RVA = "0x1432B00", Offset = "0x1431700", VA = "0x181432B00")]
		public int GetMaxLevel()
		{
			return 0;
		}

		// Token: 0x0601B128 RID: 110888 RVA: 0x000A4310 File Offset: 0x000A2510
		[Token(Token = "0x601B128")]
		[Address(RVA = "0x1432670", Offset = "0x1431270", VA = "0x181432670")]
		public bool GetGrandPrizeFocusRange(out int minIndex, out int maxIndex)
		{
			return default(bool);
		}

		// Token: 0x0601B129 RID: 110889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B129")]
		[Address(RVA = "0x14320C0", Offset = "0x1430CC0", VA = "0x1814320C0")]
		public void GenerateOverviewPrizeList(out ListDict<int, UIItemViewModel> grandPrizeList, out ListDict<string, UIItemViewModel> normalPrizeList)
		{
		}

		// Token: 0x0601B12A RID: 110890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B12A")]
		[Address(RVA = "0x1432DC0", Offset = "0x14319C0", VA = "0x181432DC0")]
		public RoguelikeTopicBattlePassPurchaseViewModel()
		{
		}

		// Token: 0x04022CBD RID: 142525
		[Token(Token = "0x4022CBD")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeTopicBPObjViewModel> purchasableBpObjList;

		// Token: 0x04022CBE RID: 142526
		[Token(Token = "0x4022CBE")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, RoguelikeTopicBPPrizeViewModel> grandPrizeList;

		// Token: 0x04022CBF RID: 142527
		[Token(Token = "0x4022CBF")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicBP curBpData;

		// Token: 0x04022CC0 RID: 142528
		[Token(Token = "0x4022CC0")]
		[FieldOffset(Offset = "0x28")]
		public int curBpPoint;

		// Token: 0x04022CC1 RID: 142529
		[Token(Token = "0x4022CC1")]
		[FieldOffset(Offset = "0x30")]
		public string topicId;

		// Token: 0x04022CC2 RID: 142530
		[Token(Token = "0x4022CC2")]
		[FieldOffset(Offset = "0x38")]
		public long widgetId;

		// Token: 0x04022CC3 RID: 142531
		[Token(Token = "0x4022CC3")]
		[FieldOffset(Offset = "0x40")]
		public long dragId;

		// Token: 0x04022CC4 RID: 142532
		[Token(Token = "0x4022CC4")]
		[FieldOffset(Offset = "0x48")]
		public bool wheelScrolling;

		// Token: 0x04022CC5 RID: 142533
		[Token(Token = "0x4022CC5")]
		[FieldOffset(Offset = "0x4C")]
		public int selectedIndex;

		// Token: 0x04022CC6 RID: 142534
		[Token(Token = "0x4022CC6")]
		[FieldOffset(Offset = "0x50")]
		public RoguelikeTopicBattlePassPurchaseViewModel.IndexUpdateStrategy indexUpdateStrategy;

		// Token: 0x04022CC7 RID: 142535
		[Token(Token = "0x4022CC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SelectGrandPrizeOnInit;

		// Token: 0x04022CC8 RID: 142536
		[Token(Token = "0x4022CC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetIndexByBpLevel;

		// Token: 0x04022CC9 RID: 142537
		[Token(Token = "0x4022CC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBpLevelByIndex;

		// Token: 0x04022CCA RID: 142538
		[Token(Token = "0x4022CCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedLevel;

		// Token: 0x04022CCB RID: 142539
		[Token(Token = "0x4022CCB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMaxLevel;

		// Token: 0x04022CCC RID: 142540
		[Token(Token = "0x4022CCC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetGrandPrizeFocusRange;

		// Token: 0x04022CCD RID: 142541
		[Token(Token = "0x4022CCD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenerateOverviewPrizeList;

		// Token: 0x04022CCE RID: 142542
		[Token(Token = "0x4022CCE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200456A RID: 17770
		[Token(Token = "0x200456A")]
		public enum IndexUpdateStrategy
		{
			// Token: 0x04022CD0 RID: 142544
			[Token(Token = "0x4022CD0")]
			LIST_SPECIFICATION,
			// Token: 0x04022CD1 RID: 142545
			[Token(Token = "0x4022CD1")]
			WHEEL_PICKER_MOVEMENT
		}
	}
}
