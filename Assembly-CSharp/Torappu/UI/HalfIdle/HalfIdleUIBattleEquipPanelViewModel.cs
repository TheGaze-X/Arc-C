using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x0200675D RID: 26461
	[Token(Token = "0x200675D")]
	public class HalfIdleUIBattleEquipPanelViewModel : IHotfixable
	{
		// Token: 0x06025F7D RID: 155517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F7D")]
		[Address(RVA = "0x20F3420", Offset = "0x20F2020", VA = "0x1820F3420")]
		private void _UpdateEquipItemViewModelList(List<HalfIdleUIBattleEquipItemViewModel> viewModel, Act1VHalfIdleEquipType slotType, HalfIdleBattleEquipManager.HalfIdleEquipSlot slot, GameModeFactory.HalfIdleGameMode gameMode)
		{
		}

		// Token: 0x06025F7E RID: 155518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F7E")]
		[Address(RVA = "0x20F2CA0", Offset = "0x20F18A0", VA = "0x1820F2CA0")]
		public void UpdateData(HalfIdleEquipPanelParams param, string activityId)
		{
		}

		// Token: 0x06025F7F RID: 155519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F7F")]
		[Address(RVA = "0x20F3630", Offset = "0x20F2230", VA = "0x1820F3630")]
		public HalfIdleUIBattleEquipPanelViewModel()
		{
		}

		// Token: 0x04035693 RID: 218771
		[Token(Token = "0x4035693")]
		[FieldOffset(Offset = "0x10")]
		public bool isInteractable;

		// Token: 0x04035694 RID: 218772
		[Token(Token = "0x4035694")]
		[FieldOffset(Offset = "0x11")]
		public bool isUnfolded;

		// Token: 0x04035695 RID: 218773
		[Token(Token = "0x4035695")]
		[FieldOffset(Offset = "0x14")]
		public Act1VHalfIdleEquipType selectedEquipType;

		// Token: 0x04035696 RID: 218774
		[Token(Token = "0x4035696")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleEquipData currentEquip;

		// Token: 0x04035697 RID: 218775
		[Token(Token = "0x4035697")]
		[FieldOffset(Offset = "0x20")]
		public bool isAutoUpgradeOn;

		// Token: 0x04035698 RID: 218776
		[Token(Token = "0x4035698")]
		[FieldOffset(Offset = "0x28")]
		public string actId;

		// Token: 0x04035699 RID: 218777
		[Token(Token = "0x4035699")]
		[FieldOffset(Offset = "0x30")]
		public List<HalfIdleUIBattleEquipThumbnailViewModel> equipThumbnailViewModelList;

		// Token: 0x0403569A RID: 218778
		[Token(Token = "0x403569A")]
		[FieldOffset(Offset = "0x38")]
		public List<List<HalfIdleUIBattleEquipItemViewModel>> equipItemViewModelList;

		// Token: 0x0403569B RID: 218779
		[Token(Token = "0x403569B")]
		[FieldOffset(Offset = "0x40")]
		public int maxEquipNum;

		// Token: 0x0403569C RID: 218780
		[Token(Token = "0x403569C")]
		[FieldOffset(Offset = "0x44")]
		public int maxEquipSlotNum;

		// Token: 0x0403569D RID: 218781
		[Token(Token = "0x403569D")]
		[FieldOffset(Offset = "0x48")]
		public int currEquipSlotNum;

		// Token: 0x0403569E RID: 218782
		[Token(Token = "0x403569E")]
		[FieldOffset(Offset = "0x50")]
		public List<int> currEquipNum;

		// Token: 0x0403569F RID: 218783
		[Token(Token = "0x403569F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateEquipItemViewModelList;

		// Token: 0x040356A0 RID: 218784
		[Token(Token = "0x40356A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040356A1 RID: 218785
		[Token(Token = "0x40356A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
