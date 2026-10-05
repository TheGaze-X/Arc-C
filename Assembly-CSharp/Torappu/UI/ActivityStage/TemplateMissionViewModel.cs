using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CFB RID: 27899
	[Token(Token = "0x2006CFB")]
	public class TemplateMissionViewModel : IHotfixable
	{
		// Token: 0x06027C69 RID: 162921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C69")]
		[Address(RVA = "0x2300780", Offset = "0x22FF380", VA = "0x182300780")]
		public TemplateMissionViewModel()
		{
		}

		// Token: 0x06027C6A RID: 162922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C6A")]
		[Address(RVA = "0x2300660", Offset = "0x22FF260", VA = "0x182300660")]
		public TemplateMissionViewModel(string actId_, int state_, int target_, int value_, List<MissionDisplayRewards> rewards, MissionData data_, [Optional] DataBundle meta_)
		{
		}

		// Token: 0x17005DFF RID: 24063
		// (get) Token: 0x06027C6B RID: 162923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DFF")]
		public string description
		{
			[Token(Token = "0x6027C6B")]
			[Address(RVA = "0x23007E0", Offset = "0x22FF3E0", VA = "0x1823007E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027C6C RID: 162924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C6C")]
		[Address(RVA = "0x2300000", Offset = "0x22FEC00", VA = "0x182300000")]
		public static BasicActivityItemViewModel ChangeRewardDataType(string actId, MissionDisplayRewards data)
		{
			return null;
		}

		// Token: 0x06027C6D RID: 162925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C6D")]
		[Address(RVA = "0x23002F0", Offset = "0x22FEEF0", VA = "0x1823002F0")]
		public List<BasicActivityItemViewModel> GetRewardPreviewItem()
		{
			return null;
		}

		// Token: 0x06027C6E RID: 162926 RVA: 0x000CF5D0 File Offset: 0x000CD7D0
		[Token(Token = "0x6027C6E")]
		[Address(RVA = "0x2300200", Offset = "0x22FEE00", VA = "0x182300200")]
		public bool CheckIfAbleToFinish()
		{
			return default(bool);
		}

		// Token: 0x06027C6F RID: 162927 RVA: 0x000CF5E8 File Offset: 0x000CD7E8
		[Token(Token = "0x6027C6F")]
		[Address(RVA = "0x2300270", Offset = "0x22FEE70", VA = "0x182300270")]
		public float GetMissionProgress()
		{
			return 0f;
		}

		// Token: 0x0403868A RID: 231050
		[Token(Token = "0x403868A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403868B RID: 231051
		[Token(Token = "0x403868B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string missionText;

		// Token: 0x0403868C RID: 231052
		[Token(Token = "0x403868C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MissionHoldingState state;

		// Token: 0x0403868D RID: 231053
		[Token(Token = "0x403868D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int target;

		// Token: 0x0403868E RID: 231054
		[Token(Token = "0x403868E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int value;

		// Token: 0x0403868F RID: 231055
		[Token(Token = "0x403868F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MissionData data;

		// Token: 0x04038690 RID: 231056
		[Token(Token = "0x4038690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<MissionDisplayRewards> rewardList;

		// Token: 0x04038691 RID: 231057
		[Token(Token = "0x4038691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DataBundle meta;

		// Token: 0x04038692 RID: 231058
		[Token(Token = "0x4038692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04038693 RID: 231059
		[Token(Token = "0x4038693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x04038694 RID: 231060
		[Token(Token = "0x4038694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_description;

		// Token: 0x04038695 RID: 231061
		[Token(Token = "0x4038695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeRewardDataType;

		// Token: 0x04038696 RID: 231062
		[Token(Token = "0x4038696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRewardPreviewItem;

		// Token: 0x04038697 RID: 231063
		[Token(Token = "0x4038697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfAbleToFinish;

		// Token: 0x04038698 RID: 231064
		[Token(Token = "0x4038698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetMissionProgress;
	}
}
