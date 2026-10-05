using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071B5 RID: 29109
	[Token(Token = "0x20071B5")]
	public class Act6FunZoneMapAchieveRewardItemViewModel : IHotfixable
	{
		// Token: 0x170061C4 RID: 25028
		// (get) Token: 0x060294E3 RID: 169187 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060294E4 RID: 169188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061C4")]
		public string rewardId
		{
			[Token(Token = "0x60294E3")]
			[Address(RVA = "0x24B1E00", Offset = "0x24B0A00", VA = "0x1824B1E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60294E4")]
			[Address(RVA = "0x24B2010", Offset = "0x24B0C10", VA = "0x1824B2010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061C5 RID: 25029
		// (get) Token: 0x060294E5 RID: 169189 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060294E6 RID: 169190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061C5")]
		public Act6FunAchievementRewardData rewardData
		{
			[Token(Token = "0x60294E5")]
			[Address(RVA = "0x24B1DA0", Offset = "0x24B09A0", VA = "0x1824B1DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60294E6")]
			[Address(RVA = "0x24B1F90", Offset = "0x24B0B90", VA = "0x1824B1F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061C6 RID: 25030
		// (get) Token: 0x060294E7 RID: 169191 RVA: 0x000D5468 File Offset: 0x000D3668
		// (set) Token: 0x060294E8 RID: 169192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061C6")]
		public int sortId
		{
			[Token(Token = "0x60294E7")]
			[Address(RVA = "0x24B1EC0", Offset = "0x24B0AC0", VA = "0x1824B1EC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60294E8")]
			[Address(RVA = "0x24B2100", Offset = "0x24B0D00", VA = "0x1824B2100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061C7 RID: 25031
		// (get) Token: 0x060294E9 RID: 169193 RVA: 0x000D5480 File Offset: 0x000D3680
		// (set) Token: 0x060294EA RID: 169194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061C7")]
		public int achievementCount
		{
			[Token(Token = "0x60294E9")]
			[Address(RVA = "0x24B1D40", Offset = "0x24B0940", VA = "0x1824B1D40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60294EA")]
			[Address(RVA = "0x24B1F20", Offset = "0x24B0B20", VA = "0x1824B1F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061C8 RID: 25032
		// (get) Token: 0x060294EB RID: 169195 RVA: 0x000D5498 File Offset: 0x000D3698
		// (set) Token: 0x060294EC RID: 169196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061C8")]
		public Act6FunAchieveRewardItemState rewardState
		{
			[Token(Token = "0x60294EB")]
			[Address(RVA = "0x24B1E60", Offset = "0x24B0A60", VA = "0x1824B1E60")]
			[CompilerGenerated]
			get
			{
				return Act6FunAchieveRewardItemState.LOCKED;
			}
			[Token(Token = "0x60294EC")]
			[Address(RVA = "0x24B2090", Offset = "0x24B0C90", VA = "0x1824B2090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060294ED RID: 169197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294ED")]
		[Address(RVA = "0x24B1960", Offset = "0x24B0560", VA = "0x1824B1960")]
		public void LoadData(string id, Act6FunAchievementRewardData data)
		{
		}

		// Token: 0x060294EE RID: 169198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294EE")]
		[Address(RVA = "0x24B1B50", Offset = "0x24B0750", VA = "0x1824B1B50")]
		public void RefreshData(int playerAchieveCount, List<string> claimedRewardIdList)
		{
		}

		// Token: 0x060294EF RID: 169199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294EF")]
		[Address(RVA = "0x24B1CE0", Offset = "0x24B08E0", VA = "0x1824B1CE0")]
		public Act6FunZoneMapAchieveRewardItemViewModel()
		{
		}

		// Token: 0x0403AFC5 RID: 241605
		[Token(Token = "0x403AFC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rewardId;

		// Token: 0x0403AFC6 RID: 241606
		[Token(Token = "0x403AFC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rewardId;

		// Token: 0x0403AFC7 RID: 241607
		[Token(Token = "0x403AFC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rewardData;

		// Token: 0x0403AFC8 RID: 241608
		[Token(Token = "0x403AFC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_rewardData;

		// Token: 0x0403AFC9 RID: 241609
		[Token(Token = "0x403AFC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0403AFCA RID: 241610
		[Token(Token = "0x403AFCA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x0403AFCB RID: 241611
		[Token(Token = "0x403AFCB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_achievementCount;

		// Token: 0x0403AFCC RID: 241612
		[Token(Token = "0x403AFCC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_achievementCount;

		// Token: 0x0403AFCD RID: 241613
		[Token(Token = "0x403AFCD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_rewardState;

		// Token: 0x0403AFCE RID: 241614
		[Token(Token = "0x403AFCE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_rewardState;

		// Token: 0x0403AFCF RID: 241615
		[Token(Token = "0x403AFCF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AFD0 RID: 241616
		[Token(Token = "0x403AFD0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403AFD1 RID: 241617
		[Token(Token = "0x403AFD1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
