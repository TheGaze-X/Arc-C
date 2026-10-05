using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x0200700E RID: 28686
	[Token(Token = "0x200700E")]
	public class ActMultiV3StageListViewModel : IHotfixable
	{
		// Token: 0x06028B86 RID: 166790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B86")]
		[Address(RVA = "0x24134E0", Offset = "0x24120E0", VA = "0x1824134E0")]
		public void LoadData(string actId, ActMultiV3StageListViewModel.LoadParam loadParam)
		{
		}

		// Token: 0x06028B87 RID: 166791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B87")]
		[Address(RVA = "0x24141A0", Offset = "0x2412DA0", VA = "0x1824141A0")]
		public void SetSelectedTab(int diff)
		{
		}

		// Token: 0x06028B88 RID: 166792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B88")]
		[Address(RVA = "0x2413430", Offset = "0x2412030", VA = "0x182413430")]
		public ActMultiV3StageItemViewModel GetStageViewModel(string stageId)
		{
			return null;
		}

		// Token: 0x06028B89 RID: 166793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B89")]
		[Address(RVA = "0x2413170", Offset = "0x2411D70", VA = "0x182413170")]
		public void GetCurrDiffStageIdList(List<string> stageList, ref int normalStageCount)
		{
		}

		// Token: 0x06028B8A RID: 166794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B8A")]
		[Address(RVA = "0x2413FD0", Offset = "0x2412BD0", VA = "0x182413FD0")]
		public void ReloadTrackpointStatus()
		{
		}

		// Token: 0x06028B8B RID: 166795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B8B")]
		[Address(RVA = "0x2414240", Offset = "0x2412E40", VA = "0x182414240")]
		public ActMultiV3StageListViewModel()
		{
		}

		// Token: 0x0403A0DE RID: 237790
		[Token(Token = "0x403A0DE")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403A0DF RID: 237791
		[Token(Token = "0x403A0DF")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3StageListViewModel.ViewMode viewMode;

		// Token: 0x0403A0E0 RID: 237792
		[Token(Token = "0x403A0E0")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, ActMultiV3StageDiffGroupViewModel> stageDiffGroups;

		// Token: 0x0403A0E1 RID: 237793
		[Token(Token = "0x403A0E1")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ActMultiV3StageItemViewModel> stages;

		// Token: 0x0403A0E2 RID: 237794
		[Token(Token = "0x403A0E2")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, int> modeStarCount;

		// Token: 0x0403A0E3 RID: 237795
		[Token(Token = "0x403A0E3")]
		[FieldOffset(Offset = "0x38")]
		public ActMultiV3MapDiffType selectedDiffType;

		// Token: 0x0403A0E4 RID: 237796
		[Token(Token = "0x403A0E4")]
		[FieldOffset(Offset = "0x40")]
		public string selectedStageId;

		// Token: 0x0403A0E5 RID: 237797
		[Token(Token = "0x403A0E5")]
		[FieldOffset(Offset = "0x48")]
		public int initSeqNum;

		// Token: 0x0403A0E6 RID: 237798
		[Token(Token = "0x403A0E6")]
		[FieldOffset(Offset = "0x50")]
		public string stageTimeLockToast;

		// Token: 0x0403A0E7 RID: 237799
		[Token(Token = "0x403A0E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A0E8 RID: 237800
		[Token(Token = "0x403A0E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedTab;

		// Token: 0x0403A0E9 RID: 237801
		[Token(Token = "0x403A0E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetStageViewModel;

		// Token: 0x0403A0EA RID: 237802
		[Token(Token = "0x403A0EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurrDiffStageIdList;

		// Token: 0x0403A0EB RID: 237803
		[Token(Token = "0x403A0EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ReloadTrackpointStatus;

		// Token: 0x0403A0EC RID: 237804
		[Token(Token = "0x403A0EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200700F RID: 28687
		[Token(Token = "0x200700F")]
		public enum ViewMode
		{
			// Token: 0x0403A0EE RID: 237806
			[Token(Token = "0x403A0EE")]
			NONE,
			// Token: 0x0403A0EF RID: 237807
			[Token(Token = "0x403A0EF")]
			MODE_STATE,
			// Token: 0x0403A0F0 RID: 237808
			[Token(Token = "0x403A0F0")]
			MODE_DIALOG
		}

		// Token: 0x02007010 RID: 28688
		[Token(Token = "0x2007010")]
		public struct LoadParam
		{
			// Token: 0x1700601F RID: 24607
			// (get) Token: 0x06028B8C RID: 166796 RVA: 0x000D2C30 File Offset: 0x000D0E30
			[Token(Token = "0x1700601F")]
			public bool hasValidStage
			{
				[Token(Token = "0x6028B8C")]
				[Address(RVA = "0x2419550", Offset = "0x2418150", VA = "0x182419550")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0403A0F1 RID: 237809
			[Token(Token = "0x403A0F1")]
			[FieldOffset(Offset = "0x0")]
			public ActMultiV3StageListViewModel.ViewMode viewMode;

			// Token: 0x0403A0F2 RID: 237810
			[Token(Token = "0x403A0F2")]
			[FieldOffset(Offset = "0x4")]
			public bool isRandom;

			// Token: 0x0403A0F3 RID: 237811
			[Token(Token = "0x403A0F3")]
			[FieldOffset(Offset = "0x8")]
			public string stageId;

			// Token: 0x0403A0F4 RID: 237812
			[Token(Token = "0x403A0F4")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3MapDiffType diffType;

			// Token: 0x0403A0F5 RID: 237813
			[Token(Token = "0x403A0F5")]
			[FieldOffset(Offset = "0x14")]
			public ActMultiV3MapModeType modeType;

			// Token: 0x0403A0F6 RID: 237814
			[Token(Token = "0x403A0F6")]
			[FieldOffset(Offset = "0x18")]
			public bool checkStageValidInRoom;

			// Token: 0x0403A0F7 RID: 237815
			[Token(Token = "0x403A0F7")]
			[FieldOffset(Offset = "0x20")]
			public List<string> validStagesInRoom;
		}
	}
}
