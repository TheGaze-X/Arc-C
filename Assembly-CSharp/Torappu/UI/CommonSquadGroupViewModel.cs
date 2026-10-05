using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035D8 RID: 13784
	[Token(Token = "0x20035D8")]
	public class CommonSquadGroupViewModel : IHotfixable
	{
		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x06015EE6 RID: 89830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034B4")]
		public CommonSquadSingleSquadViewModel curSelectSquad
		{
			[Token(Token = "0x6015EE6")]
			[Address(RVA = "0xE76970", Offset = "0xE75570", VA = "0x180E76970")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x06015EE7 RID: 89831 RVA: 0x0008EB30 File Offset: 0x0008CD30
		// (set) Token: 0x06015EE8 RID: 89832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034B5")]
		public int selectedIndex
		{
			[Token(Token = "0x6015EE7")]
			[Address(RVA = "0xE76AF0", Offset = "0xE756F0", VA = "0x180E76AF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6015EE8")]
			[Address(RVA = "0xE76E20", Offset = "0xE75A20", VA = "0x180E76E20")]
			set
			{
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x06015EE9 RID: 89833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034B6")]
		public string actId
		{
			[Token(Token = "0x6015EE9")]
			[Address(RVA = "0xE76820", Offset = "0xE75420", VA = "0x180E76820")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x06015EEA RID: 89834 RVA: 0x0008EB48 File Offset: 0x0008CD48
		[Token(Token = "0x170034B7")]
		public StageId stageId
		{
			[Token(Token = "0x6015EEA")]
			[Address(RVA = "0xE76BB0", Offset = "0xE757B0", VA = "0x180E76BB0")]
			get
			{
				return default(StageId);
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x06015EEB RID: 89835 RVA: 0x0008EB60 File Offset: 0x0008CD60
		// (set) Token: 0x06015EEC RID: 89836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034B8")]
		public bool canAssist
		{
			[Token(Token = "0x6015EEB")]
			[Address(RVA = "0xE76910", Offset = "0xE75510", VA = "0x180E76910")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015EEC")]
			[Address(RVA = "0xE76D30", Offset = "0xE75930", VA = "0x180E76D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x06015EED RID: 89837 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015EEE RID: 89838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034B9")]
		public SquadFriendData assistCharModel
		{
			[Token(Token = "0x6015EED")]
			[Address(RVA = "0xE768B0", Offset = "0xE754B0", VA = "0x180E768B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6015EEE")]
			[Address(RVA = "0xE76C50", Offset = "0xE75850", VA = "0x180E76C50")]
			set
			{
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x06015EEF RID: 89839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015EF0 RID: 89840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034BA")]
		public List<CommonSquadSingleSquadViewModel> squads
		{
			[Token(Token = "0x6015EEF")]
			[Address(RVA = "0xE76B50", Offset = "0xE75750", VA = "0x180E76B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015EF0")]
			[Address(RVA = "0xE76F50", Offset = "0xE75B50", VA = "0x180E76F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x06015EF1 RID: 89841 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015EF2 RID: 89842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034BB")]
		public ICustomSquadGroupViewModel customViewModel
		{
			[Token(Token = "0x6015EF1")]
			[Address(RVA = "0xE76A30", Offset = "0xE75630", VA = "0x180E76A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015EF2")]
			[Address(RVA = "0xE76DA0", Offset = "0xE759A0", VA = "0x180E76DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x06015EF3 RID: 89843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034BC")]
		public ExternalRuneChecker externalRuneChecker
		{
			[Token(Token = "0x6015EF3")]
			[Address(RVA = "0xE76A90", Offset = "0xE75690", VA = "0x180E76A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015EF4 RID: 89844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015EF4")]
		[Address(RVA = "0xE76330", Offset = "0xE74F30", VA = "0x180E76330")]
		public CommonSquadGroupViewModel LoadData(ICommonSquadPage.ISquadInputs squadInputs)
		{
			return null;
		}

		// Token: 0x06015EF5 RID: 89845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015EF5")]
		[Address(RVA = "0xE765C0", Offset = "0xE751C0", VA = "0x180E765C0")]
		public CommonSquadGroupViewModel SetSquads(List<CommonSquadSingleSquadViewModel> squads)
		{
			return null;
		}

		// Token: 0x06015EF6 RID: 89846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015EF6")]
		[Address(RVA = "0xE764F0", Offset = "0xE750F0", VA = "0x180E764F0")]
		public CommonSquadGroupViewModel SetCustomGroupViewModel(ICustomSquadGroupViewModel customViewModel)
		{
			return null;
		}

		// Token: 0x06015EF7 RID: 89847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EF7")]
		[Address(RVA = "0xE76690", Offset = "0xE75290", VA = "0x180E76690")]
		private void _LoadDataFromStage(string stageId)
		{
		}

		// Token: 0x06015EF8 RID: 89848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EF8")]
		[Address(RVA = "0xE76120", Offset = "0xE74D20", VA = "0x180E76120")]
		public void ClearAssistCharIfConflict(CommonSquadSingleSquadViewModel squad)
		{
		}

		// Token: 0x06015EF9 RID: 89849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EF9")]
		[Address(RVA = "0xE76770", Offset = "0xE75370", VA = "0x180E76770")]
		public CommonSquadGroupViewModel()
		{
		}

		// Token: 0x0401A5CD RID: 107981
		[Token(Token = "0x401A5CD")]
		[FieldOffset(Offset = "0x10")]
		private ExternalRuneChecker m_externalRuneChecker;

		// Token: 0x0401A5CE RID: 107982
		[Token(Token = "0x401A5CE")]
		[FieldOffset(Offset = "0x18")]
		private int m_selectedIndex;

		// Token: 0x0401A5CF RID: 107983
		[Token(Token = "0x401A5CF")]
		[FieldOffset(Offset = "0x20")]
		private SquadFriendData m_assistCharModel;

		// Token: 0x0401A5D0 RID: 107984
		[Token(Token = "0x401A5D0")]
		[FieldOffset(Offset = "0x28")]
		public ICommonSquadPage.ISquadInputs squadInputs;

		// Token: 0x0401A5D1 RID: 107985
		[Token(Token = "0x401A5D1")]
		[FieldOffset(Offset = "0x30")]
		public bool isFriendAssist;

		// Token: 0x0401A5D2 RID: 107986
		[Token(Token = "0x401A5D2")]
		[FieldOffset(Offset = "0x38")]
		public SquadHomeStateBean.FriendAssistDataStruct friendDataCache;

		// Token: 0x0401A5D3 RID: 107987
		[Token(Token = "0x401A5D3")]
		[FieldOffset(Offset = "0x48")]
		public ProfessionCategory assistProfession;

		// Token: 0x0401A5D4 RID: 107988
		[Token(Token = "0x401A5D4")]
		[FieldOffset(Offset = "0x50")]
		public CommonSquadGroupConstrainPolicy constrainPolicy;

		// Token: 0x0401A5D8 RID: 107992
		[Token(Token = "0x401A5D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curSelectSquad;

		// Token: 0x0401A5D9 RID: 107993
		[Token(Token = "0x401A5D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedIndex;

		// Token: 0x0401A5DA RID: 107994
		[Token(Token = "0x401A5DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_selectedIndex;

		// Token: 0x0401A5DB RID: 107995
		[Token(Token = "0x401A5DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0401A5DC RID: 107996
		[Token(Token = "0x401A5DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0401A5DD RID: 107997
		[Token(Token = "0x401A5DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_canAssist;

		// Token: 0x0401A5DE RID: 107998
		[Token(Token = "0x401A5DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_canAssist;

		// Token: 0x0401A5DF RID: 107999
		[Token(Token = "0x401A5DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_assistCharModel;

		// Token: 0x0401A5E0 RID: 108000
		[Token(Token = "0x401A5E0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_assistCharModel;

		// Token: 0x0401A5E1 RID: 108001
		[Token(Token = "0x401A5E1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_squads;

		// Token: 0x0401A5E2 RID: 108002
		[Token(Token = "0x401A5E2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_squads;

		// Token: 0x0401A5E3 RID: 108003
		[Token(Token = "0x401A5E3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_customViewModel;

		// Token: 0x0401A5E4 RID: 108004
		[Token(Token = "0x401A5E4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_customViewModel;

		// Token: 0x0401A5E5 RID: 108005
		[Token(Token = "0x401A5E5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_externalRuneChecker;

		// Token: 0x0401A5E6 RID: 108006
		[Token(Token = "0x401A5E6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401A5E7 RID: 108007
		[Token(Token = "0x401A5E7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetSquads;

		// Token: 0x0401A5E8 RID: 108008
		[Token(Token = "0x401A5E8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetCustomGroupViewModel;

		// Token: 0x0401A5E9 RID: 108009
		[Token(Token = "0x401A5E9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadDataFromStage;

		// Token: 0x0401A5EA RID: 108010
		[Token(Token = "0x401A5EA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ClearAssistCharIfConflict;

		// Token: 0x0401A5EB RID: 108011
		[Token(Token = "0x401A5EB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
