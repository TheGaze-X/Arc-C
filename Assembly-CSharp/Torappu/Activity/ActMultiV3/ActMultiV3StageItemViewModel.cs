using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007009 RID: 28681
	[Token(Token = "0x2007009")]
	public class ActMultiV3StageItemViewModel : IHotfixable, IComparable<ActMultiV3StageItemViewModel>
	{
		// Token: 0x06028B75 RID: 166773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B75")]
		[Address(RVA = "0x240F510", Offset = "0x240E110", VA = "0x18240F510")]
		public void LoadRandomData(string actId, string modeId, ActMultiV3MapModeType modeType, ActMultiV3MapDiffType diffType, ActMultiV3Data actData)
		{
		}

		// Token: 0x06028B76 RID: 166774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B76")]
		[Address(RVA = "0x240EF80", Offset = "0x240DB80", VA = "0x18240EF80")]
		public void LoadData(string actId, string stageId, ActMultiV3MapData stageData, ActMultiV3Data actData, PlayerActivity.PlayerMultiV3Activity.StageInfo playerStageData, bool validInRoom = true)
		{
		}

		// Token: 0x06028B77 RID: 166775 RVA: 0x000D2BE8 File Offset: 0x000D0DE8
		[Token(Token = "0x6028B77")]
		[Address(RVA = "0x240EE90", Offset = "0x240DA90", VA = "0x18240EE90", Slot = "4")]
		public int CompareTo(ActMultiV3StageItemViewModel other)
		{
			return 0;
		}

		// Token: 0x06028B78 RID: 166776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B78")]
		[Address(RVA = "0x240F8B0", Offset = "0x240E4B0", VA = "0x18240F8B0")]
		public void ReloadTrackpointStatus()
		{
		}

		// Token: 0x06028B79 RID: 166777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B79")]
		[Address(RVA = "0x240F930", Offset = "0x240E530", VA = "0x18240F930")]
		public ActMultiV3StageItemViewModel()
		{
		}

		// Token: 0x0403A0AC RID: 237740
		[Token(Token = "0x403A0AC")]
		public const string RANDOM_STAGE_ID = "__RANDOM_STAGE__{0}";

		// Token: 0x0403A0AD RID: 237741
		[Token(Token = "0x403A0AD")]
		[FieldOffset(Offset = "0x10")]
		public bool isRandom;

		// Token: 0x0403A0AE RID: 237742
		[Token(Token = "0x403A0AE")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403A0AF RID: 237743
		[Token(Token = "0x403A0AF")]
		[FieldOffset(Offset = "0x20")]
		public string stageCode;

		// Token: 0x0403A0B0 RID: 237744
		[Token(Token = "0x403A0B0")]
		[FieldOffset(Offset = "0x28")]
		public int star;

		// Token: 0x0403A0B1 RID: 237745
		[Token(Token = "0x403A0B1")]
		[FieldOffset(Offset = "0x30")]
		public long exScore;

		// Token: 0x0403A0B2 RID: 237746
		[Token(Token = "0x403A0B2")]
		[FieldOffset(Offset = "0x38")]
		public bool isEmptyScore;

		// Token: 0x0403A0B3 RID: 237747
		[Token(Token = "0x403A0B3")]
		[FieldOffset(Offset = "0x3C")]
		public int sortId;

		// Token: 0x0403A0B4 RID: 237748
		[Token(Token = "0x403A0B4")]
		[FieldOffset(Offset = "0x40")]
		public ActMultiV3MapDiffType stageDiffType;

		// Token: 0x0403A0B5 RID: 237749
		[Token(Token = "0x403A0B5")]
		[FieldOffset(Offset = "0x44")]
		public ActMultiV3MapModeType modeType;

		// Token: 0x0403A0B6 RID: 237750
		[Token(Token = "0x403A0B6")]
		[FieldOffset(Offset = "0x48")]
		public string modeName;

		// Token: 0x0403A0B7 RID: 237751
		[Token(Token = "0x403A0B7")]
		[FieldOffset(Offset = "0x50")]
		public int modeSortId;

		// Token: 0x0403A0B8 RID: 237752
		[Token(Token = "0x403A0B8")]
		[FieldOffset(Offset = "0x58")]
		public string modeId;

		// Token: 0x0403A0B9 RID: 237753
		[Token(Token = "0x403A0B9")]
		[FieldOffset(Offset = "0x60")]
		public string actId;

		// Token: 0x0403A0BA RID: 237754
		[Token(Token = "0x403A0BA")]
		[FieldOffset(Offset = "0x68")]
		public string unlockModeId;

		// Token: 0x0403A0BB RID: 237755
		[Token(Token = "0x403A0BB")]
		[FieldOffset(Offset = "0x70")]
		public int unlockModeStarRequirement;

		// Token: 0x0403A0BC RID: 237756
		[Token(Token = "0x403A0BC")]
		[FieldOffset(Offset = "0x78")]
		public long modeOpenTs;

		// Token: 0x0403A0BD RID: 237757
		[Token(Token = "0x403A0BD")]
		[FieldOffset(Offset = "0x80")]
		public long stageOpenTs;

		// Token: 0x0403A0BE RID: 237758
		[Token(Token = "0x403A0BE")]
		[FieldOffset(Offset = "0x88")]
		public string textOpenTime;

		// Token: 0x0403A0BF RID: 237759
		[Token(Token = "0x403A0BF")]
		[FieldOffset(Offset = "0x90")]
		public bool isLockedByMode;

		// Token: 0x0403A0C0 RID: 237760
		[Token(Token = "0x403A0C0")]
		[FieldOffset(Offset = "0x91")]
		public bool isLockedByTime;

		// Token: 0x0403A0C1 RID: 237761
		[Token(Token = "0x403A0C1")]
		[FieldOffset(Offset = "0x92")]
		public bool validInRoom;

		// Token: 0x0403A0C2 RID: 237762
		[Token(Token = "0x403A0C2")]
		[FieldOffset(Offset = "0x98")]
		public string lockedByModeToast;

		// Token: 0x0403A0C3 RID: 237763
		[Token(Token = "0x403A0C3")]
		[FieldOffset(Offset = "0xA0")]
		public bool hasTrackpoint;

		// Token: 0x0403A0C4 RID: 237764
		[Token(Token = "0x403A0C4")]
		[FieldOffset(Offset = "0xA8")]
		public string previewIconId;

		// Token: 0x0403A0C5 RID: 237765
		[Token(Token = "0x403A0C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadRandomData;

		// Token: 0x0403A0C6 RID: 237766
		[Token(Token = "0x403A0C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A0C7 RID: 237767
		[Token(Token = "0x403A0C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403A0C8 RID: 237768
		[Token(Token = "0x403A0C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReloadTrackpointStatus;

		// Token: 0x0403A0C9 RID: 237769
		[Token(Token = "0x403A0C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
