using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049C5 RID: 18885
	[Token(Token = "0x20049C5")]
	public class LongTermCheckInGroupViewModel : IHotfixable
	{
		// Token: 0x0601C71C RID: 116508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C71C")]
		[Address(RVA = "0x15E4160", Offset = "0x15E2D60", VA = "0x1815E4160")]
		public void LoadData(LongTermCheckInGroupData data)
		{
		}

		// Token: 0x0601C71D RID: 116509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C71D")]
		[Address(RVA = "0x15E48B0", Offset = "0x15E34B0", VA = "0x1815E48B0")]
		private LongTermCheckInProgressViewModel _LoadLevelData(PlayerDataModel playerData, int target)
		{
			return null;
		}

		// Token: 0x0601C71E RID: 116510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C71E")]
		[Address(RVA = "0x15E4740", Offset = "0x15E3340", VA = "0x1815E4740")]
		private LongTermCheckInProgressViewModel _LoadCheckInDayData(PlayerDataModel playerData, int target)
		{
			return null;
		}

		// Token: 0x0601C71F RID: 116511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C71F")]
		[Address(RVA = "0x15E4600", Offset = "0x15E3200", VA = "0x1815E4600")]
		private string _GetProgressText(int value, int target)
		{
			return null;
		}

		// Token: 0x0601C720 RID: 116512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C720")]
		[Address(RVA = "0x15E4A20", Offset = "0x15E3620", VA = "0x1815E4A20")]
		public LongTermCheckInGroupViewModel()
		{
		}

		// Token: 0x0402545D RID: 152669
		[Token(Token = "0x402545D")]
		[FieldOffset(Offset = "0x10")]
		public LongTermCheckInGroupStatus status;

		// Token: 0x0402545E RID: 152670
		[Token(Token = "0x402545E")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x0402545F RID: 152671
		[Token(Token = "0x402545F")]
		[FieldOffset(Offset = "0x20")]
		public string nickName;

		// Token: 0x04025460 RID: 152672
		[Token(Token = "0x4025460")]
		[FieldOffset(Offset = "0x28")]
		public string titleImgId;

		// Token: 0x04025461 RID: 152673
		[Token(Token = "0x4025461")]
		[FieldOffset(Offset = "0x30")]
		public string rewardImgId;

		// Token: 0x04025462 RID: 152674
		[Token(Token = "0x4025462")]
		[FieldOffset(Offset = "0x38")]
		public string bottomDesc;

		// Token: 0x04025463 RID: 152675
		[Token(Token = "0x4025463")]
		[FieldOffset(Offset = "0x40")]
		public string desc;

		// Token: 0x04025464 RID: 152676
		[Token(Token = "0x4025464")]
		[FieldOffset(Offset = "0x48")]
		public List<ItemBundle> rewardList;

		// Token: 0x04025465 RID: 152677
		[Token(Token = "0x4025465")]
		[FieldOffset(Offset = "0x50")]
		public List<LongTermCheckInProgressViewModel> progressList;

		// Token: 0x04025466 RID: 152678
		[Token(Token = "0x4025466")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025467 RID: 152679
		[Token(Token = "0x4025467")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadLevelData;

		// Token: 0x04025468 RID: 152680
		[Token(Token = "0x4025468")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadCheckInDayData;

		// Token: 0x04025469 RID: 152681
		[Token(Token = "0x4025469")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetProgressText;

		// Token: 0x0402546A RID: 152682
		[Token(Token = "0x402546A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
