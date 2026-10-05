using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D89 RID: 19849
	[Token(Token = "0x2004D89")]
	public class NameCardV2CollectModuleModel : NameCardV2ModuleBaseModel
	{
		// Token: 0x0601DB36 RID: 121654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB36")]
		[Address(RVA = "0x1745F60", Offset = "0x1744B60", VA = "0x181745F60", Slot = "9")]
		protected override void OnLoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB37 RID: 121655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB37")]
		[Address(RVA = "0x1746650", Offset = "0x1745250", VA = "0x181746650", Slot = "7")]
		protected override void OnLoadSelfData()
		{
		}

		// Token: 0x0601DB38 RID: 121656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB38")]
		[Address(RVA = "0x1746C00", Offset = "0x1745800", VA = "0x181746C00", Slot = "8")]
		protected override void OnRefreshSelfData()
		{
		}

		// Token: 0x0601DB39 RID: 121657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB39")]
		[Address(RVA = "0x1746F10", Offset = "0x1745B10", VA = "0x181746F10")]
		private void _InitTeamCountListIfNot()
		{
		}

		// Token: 0x0601DB3A RID: 121658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB3A")]
		[Address(RVA = "0x1746DD0", Offset = "0x17459D0", VA = "0x181746DD0")]
		private void _CleanTeamCountList()
		{
		}

		// Token: 0x0601DB3B RID: 121659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB3B")]
		[Address(RVA = "0x17472A0", Offset = "0x1745EA0", VA = "0x1817472A0")]
		private void _LoadSpThemeInfo()
		{
		}

		// Token: 0x0601DB3C RID: 121660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB3C")]
		[Address(RVA = "0x1746D50", Offset = "0x1745950", VA = "0x181746D50")]
		public void SwitchOperatorStyle()
		{
		}

		// Token: 0x0601DB3D RID: 121661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB3D")]
		[Address(RVA = "0x1747360", Offset = "0x1745F60", VA = "0x181747360")]
		public NameCardV2CollectModuleModel()
		{
		}

		// Token: 0x040273F3 RID: 160755
		[Token(Token = "0x40273F3")]
		[FieldOffset(Offset = "0x38")]
		public string nickName;

		// Token: 0x040273F4 RID: 160756
		[Token(Token = "0x40273F4")]
		[FieldOffset(Offset = "0x40")]
		public string nickNameId;

		// Token: 0x040273F5 RID: 160757
		[Token(Token = "0x40273F5")]
		[FieldOffset(Offset = "0x48")]
		public bool isSpTheme;

		// Token: 0x040273F6 RID: 160758
		[Token(Token = "0x40273F6")]
		[FieldOffset(Offset = "0x50")]
		public string themeName;

		// Token: 0x040273F7 RID: 160759
		[Token(Token = "0x40273F7")]
		[FieldOffset(Offset = "0x58")]
		public string themeEnName;

		// Token: 0x040273F8 RID: 160760
		[Token(Token = "0x40273F8")]
		[FieldOffset(Offset = "0x60")]
		public DateTime registerDate;

		// Token: 0x040273F9 RID: 160761
		[Token(Token = "0x40273F9")]
		[FieldOffset(Offset = "0x68")]
		public int birthMonth;

		// Token: 0x040273FA RID: 160762
		[Token(Token = "0x40273FA")]
		[FieldOffset(Offset = "0x6C")]
		public int birthDay;

		// Token: 0x040273FB RID: 160763
		[Token(Token = "0x40273FB")]
		[FieldOffset(Offset = "0x70")]
		public int charCount;

		// Token: 0x040273FC RID: 160764
		[Token(Token = "0x40273FC")]
		[FieldOffset(Offset = "0x74")]
		public int charCollectPercent;

		// Token: 0x040273FD RID: 160765
		[Token(Token = "0x40273FD")]
		[FieldOffset(Offset = "0x78")]
		public NameCardV2CollectModuleModel.OperatorProgressStyle operatorShowStyle;

		// Token: 0x040273FE RID: 160766
		[Token(Token = "0x40273FE")]
		[FieldOffset(Offset = "0x7C")]
		public int skinCount;

		// Token: 0x040273FF RID: 160767
		[Token(Token = "0x40273FF")]
		[FieldOffset(Offset = "0x80")]
		public CharacterData charData;

		// Token: 0x04027400 RID: 160768
		[Token(Token = "0x4027400")]
		[FieldOffset(Offset = "0x88")]
		public List<NameCardV2CollectModuleModel.NameCardTeamViewModel> teamCountList;

		// Token: 0x04027401 RID: 160769
		[Token(Token = "0x4027401")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasTeamIconInited;

		// Token: 0x04027402 RID: 160770
		[Token(Token = "0x4027402")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoadFriendData;

		// Token: 0x04027403 RID: 160771
		[Token(Token = "0x4027403")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoadSelfData;

		// Token: 0x04027404 RID: 160772
		[Token(Token = "0x4027404")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRefreshSelfData;

		// Token: 0x04027405 RID: 160773
		[Token(Token = "0x4027405")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitTeamCountListIfNot;

		// Token: 0x04027406 RID: 160774
		[Token(Token = "0x4027406")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CleanTeamCountList;

		// Token: 0x04027407 RID: 160775
		[Token(Token = "0x4027407")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadSpThemeInfo;

		// Token: 0x04027408 RID: 160776
		[Token(Token = "0x4027408")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SwitchOperatorStyle;

		// Token: 0x04027409 RID: 160777
		[Token(Token = "0x4027409")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D8A RID: 19850
		[Token(Token = "0x2004D8A")]
		public class NameCardTeamViewModel : IComparable<NameCardV2CollectModuleModel.NameCardTeamViewModel>
		{
			// Token: 0x0601DB3E RID: 121662 RVA: 0x000AC4D0 File Offset: 0x000AA6D0
			[Token(Token = "0x601DB3E")]
			[Address(RVA = "0x17456D0", Offset = "0x17442D0", VA = "0x1817456D0", Slot = "4")]
			public int CompareTo(NameCardV2CollectModuleModel.NameCardTeamViewModel anotherTeam)
			{
				return 0;
			}

			// Token: 0x0601DB3F RID: 121663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB3F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NameCardTeamViewModel()
			{
			}

			// Token: 0x0402740A RID: 160778
			[Token(Token = "0x402740A")]
			[FieldOffset(Offset = "0x10")]
			public HandbookTeamData teamData;

			// Token: 0x0402740B RID: 160779
			[Token(Token = "0x402740B")]
			[FieldOffset(Offset = "0x18")]
			public int teamCount;

			// Token: 0x0402740C RID: 160780
			[Token(Token = "0x402740C")]
			[FieldOffset(Offset = "0x1C")]
			public int totalCount;
		}

		// Token: 0x02004D8B RID: 19851
		[Token(Token = "0x2004D8B")]
		public enum OperatorProgressStyle
		{
			// Token: 0x0402740E RID: 160782
			[Token(Token = "0x402740E")]
			NUMBER,
			// Token: 0x0402740F RID: 160783
			[Token(Token = "0x402740F")]
			PERCENT
		}
	}
}
