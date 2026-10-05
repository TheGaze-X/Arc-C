using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006065 RID: 24677
	[Token(Token = "0x2006065")]
	public class CarvingCardListViewModel : IHotfixable
	{
		// Token: 0x06023AD0 RID: 146128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AD0")]
		[Address(RVA = "0x1E41860", Offset = "0x1E40460", VA = "0x181E41860")]
		public void UpdateData(string actId, bool noNeedReloadCard)
		{
		}

		// Token: 0x06023AD1 RID: 146129 RVA: 0x000C1860 File Offset: 0x000BFA60
		[Token(Token = "0x6023AD1")]
		[Address(RVA = "0x1E41430", Offset = "0x1E40030", VA = "0x181E41430")]
		public bool SelectCard(string cardId)
		{
			return default(bool);
		}

		// Token: 0x06023AD2 RID: 146130 RVA: 0x000C1878 File Offset: 0x000BFA78
		[Token(Token = "0x6023AD2")]
		[Address(RVA = "0x1E40960", Offset = "0x1E3F560", VA = "0x181E40960")]
		public bool ClearSelect()
		{
			return default(bool);
		}

		// Token: 0x06023AD3 RID: 146131 RVA: 0x000C1890 File Offset: 0x000BFA90
		[Token(Token = "0x6023AD3")]
		[Address(RVA = "0x1E40FB0", Offset = "0x1E3FBB0", VA = "0x181E40FB0")]
		public bool DragOutCard(string cardId, CarvingCardPosition position)
		{
			return default(bool);
		}

		// Token: 0x06023AD4 RID: 146132 RVA: 0x000C18A8 File Offset: 0x000BFAA8
		[Token(Token = "0x6023AD4")]
		[Address(RVA = "0x1E40A00", Offset = "0x1E3F600", VA = "0x181E40A00")]
		public bool DragCancelToHandCard(string cardId)
		{
			return default(bool);
		}

		// Token: 0x06023AD5 RID: 146133 RVA: 0x000C18C0 File Offset: 0x000BFAC0
		[Token(Token = "0x6023AD5")]
		[Address(RVA = "0x1E40CE0", Offset = "0x1E3F8E0", VA = "0x181E40CE0")]
		public bool DragCancelToSlotCard(string cardId, int slotIdx)
		{
			return default(bool);
		}

		// Token: 0x06023AD6 RID: 146134 RVA: 0x000C18D8 File Offset: 0x000BFAD8
		[Token(Token = "0x6023AD6")]
		[Address(RVA = "0x1E40790", Offset = "0x1E3F390", VA = "0x181E40790")]
		public bool AddSelectedHandToSlot()
		{
			return default(bool);
		}

		// Token: 0x06023AD7 RID: 146135 RVA: 0x000C18F0 File Offset: 0x000BFAF0
		[Token(Token = "0x6023AD7")]
		[Address(RVA = "0x1E41740", Offset = "0x1E40340", VA = "0x181E41740")]
		public bool SetTokenHoveringSlot(string cardId, int slotIdx)
		{
			return default(bool);
		}

		// Token: 0x06023AD8 RID: 146136 RVA: 0x000C1908 File Offset: 0x000BFB08
		[Token(Token = "0x6023AD8")]
		[Address(RVA = "0x1E41360", Offset = "0x1E3FF60", VA = "0x181E41360")]
		public bool OnTokenMovedIntoSlot(string cardId)
		{
			return default(bool);
		}

		// Token: 0x06023AD9 RID: 146137 RVA: 0x000C1920 File Offset: 0x000BFB20
		[Token(Token = "0x6023AD9")]
		[Address(RVA = "0x1E41620", Offset = "0x1E40220", VA = "0x181E41620")]
		public bool SetTokenHoveringInHandArea(string cardId, bool inHandArea)
		{
			return default(bool);
		}

		// Token: 0x06023ADA RID: 146138 RVA: 0x000C1938 File Offset: 0x000BFB38
		[Token(Token = "0x6023ADA")]
		[Address(RVA = "0x1E412E0", Offset = "0x1E3FEE0", VA = "0x181E412E0")]
		public bool HasEmptySlot()
		{
			return default(bool);
		}

		// Token: 0x06023ADB RID: 146139 RVA: 0x000C1950 File Offset: 0x000BFB50
		[Token(Token = "0x6023ADB")]
		[Address(RVA = "0x1E41250", Offset = "0x1E3FE50", VA = "0x181E41250")]
		public bool HasEmptySlotBefore(int slotIdx)
		{
			return default(bool);
		}

		// Token: 0x06023ADC RID: 146140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023ADC")]
		[Address(RVA = "0x1E41190", Offset = "0x1E3FD90", VA = "0x181E41190")]
		public CarvingMainCardViewModel GetSelectedCardViewModel()
		{
			return null;
		}

		// Token: 0x06023ADD RID: 146141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ADD")]
		[Address(RVA = "0x1E41D60", Offset = "0x1E40960", VA = "0x181E41D60")]
		public CarvingCardListViewModel()
		{
		}

		// Token: 0x04031701 RID: 202497
		[Token(Token = "0x4031701")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, CarvingMainCardViewModel> cardList;

		// Token: 0x04031702 RID: 202498
		[Token(Token = "0x4031702")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, CarvingMainCardViewModel> slotCardList;

		// Token: 0x04031703 RID: 202499
		[Token(Token = "0x4031703")]
		[FieldOffset(Offset = "0x20")]
		public CarvingCardSelectStatus selectedCardStatus;

		// Token: 0x04031704 RID: 202500
		[Token(Token = "0x4031704")]
		[FieldOffset(Offset = "0x30")]
		public CarvingCardTokenStatus tokenStatus;

		// Token: 0x04031705 RID: 202501
		[Token(Token = "0x4031705")]
		[FieldOffset(Offset = "0x48")]
		public int activeSlotCount;

		// Token: 0x04031706 RID: 202502
		[Token(Token = "0x4031706")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04031707 RID: 202503
		[Token(Token = "0x4031707")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectCard;

		// Token: 0x04031708 RID: 202504
		[Token(Token = "0x4031708")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearSelect;

		// Token: 0x04031709 RID: 202505
		[Token(Token = "0x4031709")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DragOutCard;

		// Token: 0x0403170A RID: 202506
		[Token(Token = "0x403170A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DragCancelToHandCard;

		// Token: 0x0403170B RID: 202507
		[Token(Token = "0x403170B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DragCancelToSlotCard;

		// Token: 0x0403170C RID: 202508
		[Token(Token = "0x403170C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddSelectedHandToSlot;

		// Token: 0x0403170D RID: 202509
		[Token(Token = "0x403170D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetTokenHoveringSlot;

		// Token: 0x0403170E RID: 202510
		[Token(Token = "0x403170E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTokenMovedIntoSlot;

		// Token: 0x0403170F RID: 202511
		[Token(Token = "0x403170F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetTokenHoveringInHandArea;

		// Token: 0x04031710 RID: 202512
		[Token(Token = "0x4031710")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HasEmptySlot;

		// Token: 0x04031711 RID: 202513
		[Token(Token = "0x4031711")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HasEmptySlotBefore;

		// Token: 0x04031712 RID: 202514
		[Token(Token = "0x4031712")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetSelectedCardViewModel;

		// Token: 0x04031713 RID: 202515
		[Token(Token = "0x4031713")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
