using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048CC RID: 18636
	[Token(Token = "0x20048CC")]
	public class MiniActTrialItemModel : IHotfixable
	{
		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x0601C1C7 RID: 115143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042BC")]
		public List<MiniActTrialRewardItemModel> rewardList
		{
			[Token(Token = "0x601C1C7")]
			[Address(RVA = "0x15983E0", Offset = "0x1596FE0", VA = "0x1815983E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x0601C1C8 RID: 115144 RVA: 0x000A73B8 File Offset: 0x000A55B8
		[Token(Token = "0x170042BD")]
		public int totalRewardCount
		{
			[Token(Token = "0x601C1C8")]
			[Address(RVA = "0x1598500", Offset = "0x1597100", VA = "0x181598500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x0601C1C9 RID: 115145 RVA: 0x000A73D0 File Offset: 0x000A55D0
		[Token(Token = "0x170042BE")]
		public int collectRewardCount
		{
			[Token(Token = "0x601C1C9")]
			[Address(RVA = "0x1598320", Offset = "0x1596F20", VA = "0x181598320")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x0601C1CA RID: 115146 RVA: 0x000A73E8 File Offset: 0x000A55E8
		[Token(Token = "0x170042BF")]
		public int storyTotalCount
		{
			[Token(Token = "0x601C1CA")]
			[Address(RVA = "0x1598440", Offset = "0x1597040", VA = "0x181598440")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x0601C1CB RID: 115147 RVA: 0x000A7400 File Offset: 0x000A5600
		[Token(Token = "0x170042C0")]
		public int storyUnlockCount
		{
			[Token(Token = "0x601C1CB")]
			[Address(RVA = "0x15984A0", Offset = "0x15970A0", VA = "0x1815984A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x0601C1CC RID: 115148 RVA: 0x000A7418 File Offset: 0x000A5618
		[Token(Token = "0x170042C1")]
		public bool canCollect
		{
			[Token(Token = "0x601C1CC")]
			[Address(RVA = "0x15982C0", Offset = "0x1596EC0", VA = "0x1815982C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x0601C1CD RID: 115149 RVA: 0x000A7430 File Offset: 0x000A5630
		[Token(Token = "0x170042C2")]
		public bool isCompleted
		{
			[Token(Token = "0x601C1CD")]
			[Address(RVA = "0x1598380", Offset = "0x1596F80", VA = "0x181598380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x0601C1CE RID: 115150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042C3")]
		public string actId
		{
			[Token(Token = "0x601C1CE")]
			[Address(RVA = "0x1598260", Offset = "0x1596E60", VA = "0x181598260")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x0601C1CF RID: 115151 RVA: 0x000A7448 File Offset: 0x000A5648
		[Token(Token = "0x170042C4")]
		public MiniActTrialItemModel.TrialStatus trialStatus
		{
			[Token(Token = "0x601C1CF")]
			[Address(RVA = "0x1598650", Offset = "0x1597250", VA = "0x181598650")]
			get
			{
				return MiniActTrialItemModel.TrialStatus.NONE;
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x0601C1D0 RID: 115152 RVA: 0x000A7460 File Offset: 0x000A5660
		[Token(Token = "0x170042C5")]
		public TimeSpan trialCountDown
		{
			[Token(Token = "0x601C1D0")]
			[Address(RVA = "0x1598570", Offset = "0x1597170", VA = "0x181598570")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x0601C1D1 RID: 115153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C1D1")]
		[Address(RVA = "0x1597820", Offset = "0x1596420", VA = "0x181597820")]
		public List<string> GetAllCollectable()
		{
			return null;
		}

		// Token: 0x0601C1D2 RID: 115154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1D2")]
		[Address(RVA = "0x15979E0", Offset = "0x15965E0", VA = "0x1815979E0")]
		public void LoadData(string storyId, MiniActTrialData.MiniActTrialSingleData trialData)
		{
		}

		// Token: 0x0601C1D3 RID: 115155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1D3")]
		[Address(RVA = "0x1598050", Offset = "0x1596C50", VA = "0x181598050")]
		private void _UpdateTrialStatus(MiniActTrialData.MiniActTrialSingleData trialData)
		{
		}

		// Token: 0x0601C1D4 RID: 115156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1D4")]
		[Address(RVA = "0x15981B0", Offset = "0x1596DB0", VA = "0x1815981B0")]
		public MiniActTrialItemModel()
		{
		}

		// Token: 0x04024C05 RID: 150533
		[Token(Token = "0x4024C05")]
		[FieldOffset(Offset = "0x10")]
		private MiniActTrialItemModel.TrialStatus m_trialStatus;

		// Token: 0x04024C06 RID: 150534
		[Token(Token = "0x4024C06")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x04024C07 RID: 150535
		[Token(Token = "0x4024C07")]
		[FieldOffset(Offset = "0x20")]
		private MiniActTrialData.MiniActTrialSingleData m_trialData;

		// Token: 0x04024C08 RID: 150536
		[Token(Token = "0x4024C08")]
		[FieldOffset(Offset = "0x28")]
		private List<MiniActTrialRewardItemModel> m_rewardList;

		// Token: 0x04024C09 RID: 150537
		[Token(Token = "0x4024C09")]
		[FieldOffset(Offset = "0x30")]
		private int m_trialCollectCount;

		// Token: 0x04024C0A RID: 150538
		[Token(Token = "0x4024C0A")]
		[FieldOffset(Offset = "0x34")]
		private int m_storyTotalCount;

		// Token: 0x04024C0B RID: 150539
		[Token(Token = "0x4024C0B")]
		[FieldOffset(Offset = "0x38")]
		private int m_storyUnlockCount;

		// Token: 0x04024C0C RID: 150540
		[Token(Token = "0x4024C0C")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_canCollect;

		// Token: 0x04024C0D RID: 150541
		[Token(Token = "0x4024C0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rewardList;

		// Token: 0x04024C0E RID: 150542
		[Token(Token = "0x4024C0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalRewardCount;

		// Token: 0x04024C0F RID: 150543
		[Token(Token = "0x4024C0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_collectRewardCount;

		// Token: 0x04024C10 RID: 150544
		[Token(Token = "0x4024C10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_storyTotalCount;

		// Token: 0x04024C11 RID: 150545
		[Token(Token = "0x4024C11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_storyUnlockCount;

		// Token: 0x04024C12 RID: 150546
		[Token(Token = "0x4024C12")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_canCollect;

		// Token: 0x04024C13 RID: 150547
		[Token(Token = "0x4024C13")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isCompleted;

		// Token: 0x04024C14 RID: 150548
		[Token(Token = "0x4024C14")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04024C15 RID: 150549
		[Token(Token = "0x4024C15")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_trialStatus;

		// Token: 0x04024C16 RID: 150550
		[Token(Token = "0x4024C16")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_trialCountDown;

		// Token: 0x04024C17 RID: 150551
		[Token(Token = "0x4024C17")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetAllCollectable;

		// Token: 0x04024C18 RID: 150552
		[Token(Token = "0x4024C18")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024C19 RID: 150553
		[Token(Token = "0x4024C19")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateTrialStatus;

		// Token: 0x04024C1A RID: 150554
		[Token(Token = "0x4024C1A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048CD RID: 18637
		[Token(Token = "0x20048CD")]
		public enum TrialStatus
		{
			// Token: 0x04024C1C RID: 150556
			[Token(Token = "0x4024C1C")]
			NONE,
			// Token: 0x04024C1D RID: 150557
			[Token(Token = "0x4024C1D")]
			LOCKED,
			// Token: 0x04024C1E RID: 150558
			[Token(Token = "0x4024C1E")]
			COMMING,
			// Token: 0x04024C1F RID: 150559
			[Token(Token = "0x4024C1F")]
			OPEN
		}
	}
}
