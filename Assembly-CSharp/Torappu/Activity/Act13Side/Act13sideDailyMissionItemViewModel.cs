using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A12 RID: 31250
	[Token(Token = "0x2007A12")]
	public class Act13sideDailyMissionItemViewModel : IHotfixable
	{
		// Token: 0x170066A3 RID: 26275
		// (get) Token: 0x0602BCD3 RID: 179411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066A3")]
		public List<ISharedItemModel> rewardList
		{
			[Token(Token = "0x602BCD3")]
			[Address(RVA = "0x27AC6B0", Offset = "0x27AB2B0", VA = "0x1827AC6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066A4 RID: 26276
		// (get) Token: 0x0602BCD4 RID: 179412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066A4")]
		public ISharedItemModel randomRewardItemModel
		{
			[Token(Token = "0x602BCD4")]
			[Address(RVA = "0x27AC620", Offset = "0x27AB220", VA = "0x1827AC620")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066A5 RID: 26277
		// (get) Token: 0x0602BCD5 RID: 179413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066A5")]
		public Act13SideData.PrincipalData principalData
		{
			[Token(Token = "0x602BCD5")]
			[Address(RVA = "0x27AC3B0", Offset = "0x27AAFB0", VA = "0x1827AC3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066A6 RID: 26278
		// (get) Token: 0x0602BCD6 RID: 179414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066A6")]
		public string principalName
		{
			[Token(Token = "0x602BCD6")]
			[Address(RVA = "0x27AC530", Offset = "0x27AB130", VA = "0x1827AC530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066A7 RID: 26279
		// (get) Token: 0x0602BCD7 RID: 179415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066A7")]
		public string principalId
		{
			[Token(Token = "0x602BCD7")]
			[Address(RVA = "0x27AC4C0", Offset = "0x27AB0C0", VA = "0x1827AC4C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066A8 RID: 26280
		// (get) Token: 0x0602BCD8 RID: 179416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066A8")]
		public string principalDialog
		{
			[Token(Token = "0x602BCD8")]
			[Address(RVA = "0x27AC410", Offset = "0x27AB010", VA = "0x1827AC410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066A9 RID: 26281
		// (get) Token: 0x0602BCD9 RID: 179417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066A9")]
		public Act13SideData.OrgData orgData
		{
			[Token(Token = "0x602BCD9")]
			[Address(RVA = "0x27AC290", Offset = "0x27AAE90", VA = "0x1827AC290")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066AA RID: 26282
		// (get) Token: 0x0602BCDA RID: 179418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066AA")]
		public Act13SideData.DailyMissionData dailyMissionData
		{
			[Token(Token = "0x602BCDA")]
			[Address(RVA = "0x27AC230", Offset = "0x27AAE30", VA = "0x1827AC230")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066AB RID: 26283
		// (get) Token: 0x0602BCDB RID: 179419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066AB")]
		public PlayerActivity.PlayerAct13sideActivity.DailyMissionProgress progress
		{
			[Token(Token = "0x602BCDB")]
			[Address(RVA = "0x27AC5C0", Offset = "0x27AB1C0", VA = "0x1827AC5C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066AC RID: 26284
		// (get) Token: 0x0602BCDC RID: 179420 RVA: 0x000DD3D0 File Offset: 0x000DB5D0
		[Token(Token = "0x170066AC")]
		public int prestigeCount
		{
			[Token(Token = "0x602BCDC")]
			[Address(RVA = "0x27AC2F0", Offset = "0x27AAEF0", VA = "0x1827AC2F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602BCDD RID: 179421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCDD")]
		[Address(RVA = "0x27ABD50", Offset = "0x27AA950", VA = "0x1827ABD50")]
		public void LoadData(string actId, PlayerActivity.PlayerAct13sideActivity.DailyMissionData missionPlayerData, [Optional] PlayerActivity.PlayerAct13sideActivity.DailyMissionProgress progressData)
		{
		}

		// Token: 0x0602BCDE RID: 179422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCDE")]
		[Address(RVA = "0x27AC180", Offset = "0x27AAD80", VA = "0x1827AC180")]
		public Act13sideDailyMissionItemViewModel()
		{
		}

		// Token: 0x0403F5FF RID: 259583
		[Token(Token = "0x403F5FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PlayerActivity.PlayerAct13sideActivity.DailyMissionData m_missionPlayerData;

		// Token: 0x0403F600 RID: 259584
		[Token(Token = "0x403F600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayerActivity.PlayerAct13sideActivity.DailyMissionProgress m_progressData;

		// Token: 0x0403F601 RID: 259585
		[Token(Token = "0x403F601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Act13SideData.PrincipalData m_principalData;

		// Token: 0x0403F602 RID: 259586
		[Token(Token = "0x403F602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Act13SideData.DailyMissionData m_dailyMissionData;

		// Token: 0x0403F603 RID: 259587
		[Token(Token = "0x403F603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Act13SideData.OrgData m_orgData;

		// Token: 0x0403F604 RID: 259588
		[Token(Token = "0x403F604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Act13SideData.DailyMissionRewardGroupData m_rewardGroupData;

		// Token: 0x0403F605 RID: 259589
		[Token(Token = "0x403F605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_principalDescIdx;

		// Token: 0x0403F606 RID: 259590
		[Token(Token = "0x403F606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<ISharedItemModel> m_rewardList;

		// Token: 0x0403F607 RID: 259591
		[Token(Token = "0x403F607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rewardList;

		// Token: 0x0403F608 RID: 259592
		[Token(Token = "0x403F608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_randomRewardItemModel;

		// Token: 0x0403F609 RID: 259593
		[Token(Token = "0x403F609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_principalData;

		// Token: 0x0403F60A RID: 259594
		[Token(Token = "0x403F60A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_principalName;

		// Token: 0x0403F60B RID: 259595
		[Token(Token = "0x403F60B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_principalId;

		// Token: 0x0403F60C RID: 259596
		[Token(Token = "0x403F60C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_principalDialog;

		// Token: 0x0403F60D RID: 259597
		[Token(Token = "0x403F60D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_orgData;

		// Token: 0x0403F60E RID: 259598
		[Token(Token = "0x403F60E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_dailyMissionData;

		// Token: 0x0403F60F RID: 259599
		[Token(Token = "0x403F60F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0403F610 RID: 259600
		[Token(Token = "0x403F610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_prestigeCount;

		// Token: 0x0403F611 RID: 259601
		[Token(Token = "0x403F611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F612 RID: 259602
		[Token(Token = "0x403F612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
