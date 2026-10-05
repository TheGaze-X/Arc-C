using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071B7 RID: 29111
	[Token(Token = "0x20071B7")]
	public class Act6FunZoneMapAchievePluginViewModel : IHotfixable
	{
		// Token: 0x170061CB RID: 25035
		// (get) Token: 0x060294F7 RID: 169207 RVA: 0x000D54E0 File Offset: 0x000D36E0
		// (set) Token: 0x060294F8 RID: 169208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061CB")]
		public int curAchievementCount
		{
			[Token(Token = "0x60294F7")]
			[Address(RVA = "0x24B1240", Offset = "0x24AFE40", VA = "0x1824B1240")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60294F8")]
			[Address(RVA = "0x24B13C0", Offset = "0x24AFFC0", VA = "0x1824B13C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061CC RID: 25036
		// (get) Token: 0x060294F9 RID: 169209 RVA: 0x000D54F8 File Offset: 0x000D36F8
		// (set) Token: 0x060294FA RID: 169210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061CC")]
		public int maxAchievementCount
		{
			[Token(Token = "0x60294F9")]
			[Address(RVA = "0x24B12A0", Offset = "0x24AFEA0", VA = "0x1824B12A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60294FA")]
			[Address(RVA = "0x24B1430", Offset = "0x24B0030", VA = "0x1824B1430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061CD RID: 25037
		// (get) Token: 0x060294FB RID: 169211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061CD")]
		public List<Act6FunZoneMapAchieveRewardItemViewModel> rewardsItemList
		{
			[Token(Token = "0x60294FB")]
			[Address(RVA = "0x24B1360", Offset = "0x24AFF60", VA = "0x1824B1360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061CE RID: 25038
		// (get) Token: 0x060294FC RID: 169212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061CE")]
		public List<Act6FunZoneMapAchieveProgressItemViewModel> progressItemList
		{
			[Token(Token = "0x60294FC")]
			[Address(RVA = "0x24B1300", Offset = "0x24AFF00", VA = "0x1824B1300")]
			get
			{
				return null;
			}
		}

		// Token: 0x060294FD RID: 169213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294FD")]
		[Address(RVA = "0x24B03E0", Offset = "0x24AEFE0", VA = "0x1824B03E0")]
		public void LoadData(Act6FunData actData)
		{
		}

		// Token: 0x060294FE RID: 169214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294FE")]
		[Address(RVA = "0x24B0B80", Offset = "0x24AF780", VA = "0x1824B0B80")]
		public void RefreshByPlayerData(PlayerActFun6 playerActFun6Data)
		{
		}

		// Token: 0x060294FF RID: 169215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294FF")]
		[Address(RVA = "0x24B1140", Offset = "0x24AFD40", VA = "0x1824B1140")]
		public Act6FunZoneMapAchievePluginViewModel()
		{
		}

		// Token: 0x0403AFDD RID: 241629
		[Token(Token = "0x403AFDD")]
		[FieldOffset(Offset = "0x18")]
		private List<Act6FunZoneMapAchieveRewardItemViewModel> m_rewardsItemList;

		// Token: 0x0403AFDE RID: 241630
		[Token(Token = "0x403AFDE")]
		[FieldOffset(Offset = "0x20")]
		private List<Act6FunZoneMapAchieveProgressItemViewModel> m_progressItemList;

		// Token: 0x0403AFDF RID: 241631
		[Token(Token = "0x403AFDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curAchievementCount;

		// Token: 0x0403AFE0 RID: 241632
		[Token(Token = "0x403AFE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_curAchievementCount;

		// Token: 0x0403AFE1 RID: 241633
		[Token(Token = "0x403AFE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxAchievementCount;

		// Token: 0x0403AFE2 RID: 241634
		[Token(Token = "0x403AFE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_maxAchievementCount;

		// Token: 0x0403AFE3 RID: 241635
		[Token(Token = "0x403AFE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rewardsItemList;

		// Token: 0x0403AFE4 RID: 241636
		[Token(Token = "0x403AFE4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_progressItemList;

		// Token: 0x0403AFE5 RID: 241637
		[Token(Token = "0x403AFE5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AFE6 RID: 241638
		[Token(Token = "0x403AFE6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshByPlayerData;

		// Token: 0x0403AFE7 RID: 241639
		[Token(Token = "0x403AFE7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
