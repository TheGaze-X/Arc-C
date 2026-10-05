using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Activity.AutoChess;
using Torappu.UI.AutoChess.Server;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200624C RID: 25164
	[Token(Token = "0x200624C")]
	public class AutoChessPrepareModel : IHotfixable
	{
		// Token: 0x1700559E RID: 21918
		// (get) Token: 0x06024512 RID: 148754 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024513 RID: 148755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700559E")]
		public string actId
		{
			[Token(Token = "0x6024512")]
			[Address(RVA = "0x1F2D2F0", Offset = "0x1F2BEF0", VA = "0x181F2D2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024513")]
			[Address(RVA = "0x1F2D840", Offset = "0x1F2C440", VA = "0x181F2D840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700559F RID: 21919
		// (get) Token: 0x06024514 RID: 148756 RVA: 0x000C3C30 File Offset: 0x000C1E30
		// (set) Token: 0x06024515 RID: 148757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700559F")]
		public bool isLocalMode
		{
			[Token(Token = "0x6024514")]
			[Address(RVA = "0x1F2D5F0", Offset = "0x1F2C1F0", VA = "0x181F2D5F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024515")]
			[Address(RVA = "0x1F2DC20", Offset = "0x1F2C820", VA = "0x181F2DC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A0 RID: 21920
		// (get) Token: 0x06024516 RID: 148758 RVA: 0x000C3C48 File Offset: 0x000C1E48
		// (set) Token: 0x06024517 RID: 148759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A0")]
		public ActAutoChessModeType modeType
		{
			[Token(Token = "0x6024516")]
			[Address(RVA = "0x1F2D720", Offset = "0x1F2C320", VA = "0x181F2D720")]
			[CompilerGenerated]
			get
			{
				return ActAutoChessModeType.LOCAL;
			}
			[Token(Token = "0x6024517")]
			[Address(RVA = "0x1F2DD10", Offset = "0x1F2C910", VA = "0x181F2DD10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A1 RID: 21921
		// (get) Token: 0x06024518 RID: 148760 RVA: 0x000C3C60 File Offset: 0x000C1E60
		// (set) Token: 0x06024519 RID: 148761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A1")]
		public ActAutoChessMultiModeSubType multiModeSubType
		{
			[Token(Token = "0x6024518")]
			[Address(RVA = "0x1F2D780", Offset = "0x1F2C380", VA = "0x181F2D780")]
			[CompilerGenerated]
			get
			{
				return ActAutoChessMultiModeSubType.NONE;
			}
			[Token(Token = "0x6024519")]
			[Address(RVA = "0x1F2DD80", Offset = "0x1F2C980", VA = "0x181F2DD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A2 RID: 21922
		// (get) Token: 0x0602451A RID: 148762 RVA: 0x000C3C78 File Offset: 0x000C1E78
		// (set) Token: 0x0602451B RID: 148763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A2")]
		public FromBattleSource fromBattleSource
		{
			[Token(Token = "0x602451A")]
			[Address(RVA = "0x1F2D590", Offset = "0x1F2C190", VA = "0x181F2D590")]
			[CompilerGenerated]
			get
			{
				return FromBattleSource.NOT_FROM_BATTLE;
			}
			[Token(Token = "0x602451B")]
			[Address(RVA = "0x1F2DBB0", Offset = "0x1F2C7B0", VA = "0x181F2DBB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A3 RID: 21923
		// (get) Token: 0x0602451C RID: 148764 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602451D RID: 148765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A3")]
		public ActAutoChessSyncInfoBattleInfo battleInfo
		{
			[Token(Token = "0x602451C")]
			[Address(RVA = "0x1F2D350", Offset = "0x1F2BF50", VA = "0x181F2D350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602451D")]
			[Address(RVA = "0x1F2D8C0", Offset = "0x1F2C4C0", VA = "0x181F2D8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A4 RID: 21924
		// (get) Token: 0x0602451E RID: 148766 RVA: 0x000C3C90 File Offset: 0x000C1E90
		// (set) Token: 0x0602451F RID: 148767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A4")]
		public AutoChessPrepareStateViewType curViewType
		{
			[Token(Token = "0x602451E")]
			[Address(RVA = "0x1F2D470", Offset = "0x1F2C070", VA = "0x181F2D470")]
			[CompilerGenerated]
			get
			{
				return AutoChessPrepareStateViewType.NONE;
			}
			[Token(Token = "0x602451F")]
			[Address(RVA = "0x1F2DA40", Offset = "0x1F2C640", VA = "0x181F2DA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A5 RID: 21925
		// (get) Token: 0x06024520 RID: 148768 RVA: 0x000C3CA8 File Offset: 0x000C1EA8
		[Token(Token = "0x170055A5")]
		public bool isServiceStarted
		{
			[Token(Token = "0x6024520")]
			[Address(RVA = "0x1F2D650", Offset = "0x1F2C250", VA = "0x181F2D650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170055A6 RID: 21926
		// (get) Token: 0x06024521 RID: 148769 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024522 RID: 148770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A6")]
		public string selfUid
		{
			[Token(Token = "0x6024521")]
			[Address(RVA = "0x1F2D7E0", Offset = "0x1F2C3E0", VA = "0x181F2D7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024522")]
			[Address(RVA = "0x1F2DDF0", Offset = "0x1F2C9F0", VA = "0x181F2DDF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A7 RID: 21927
		// (get) Token: 0x06024523 RID: 148771 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024524 RID: 148772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A7")]
		public string cachedPartnerUid
		{
			[Token(Token = "0x6024523")]
			[Address(RVA = "0x1F2D410", Offset = "0x1F2C010", VA = "0x181F2D410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024524")]
			[Address(RVA = "0x1F2D9C0", Offset = "0x1F2C5C0", VA = "0x181F2D9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A8 RID: 21928
		// (get) Token: 0x06024525 RID: 148773 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024526 RID: 148774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A8")]
		public FriendDataWithNameCard cachedPartnerNameCardData
		{
			[Token(Token = "0x6024525")]
			[Address(RVA = "0x1F2D3B0", Offset = "0x1F2BFB0", VA = "0x181F2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024526")]
			[Address(RVA = "0x1F2D940", Offset = "0x1F2C540", VA = "0x181F2D940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055A9 RID: 21929
		// (get) Token: 0x06024527 RID: 148775 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024528 RID: 148776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055A9")]
		public Dictionary<string, FriendInfo> friendInfoDict
		{
			[Token(Token = "0x6024527")]
			[Address(RVA = "0x1F2D4D0", Offset = "0x1F2C0D0", VA = "0x181F2D4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024528")]
			[Address(RVA = "0x1F2DAB0", Offset = "0x1F2C6B0", VA = "0x181F2DAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055AA RID: 21930
		// (get) Token: 0x06024529 RID: 148777 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602452A RID: 148778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055AA")]
		public HashSet<string> friendRequsetCDSet
		{
			[Token(Token = "0x6024529")]
			[Address(RVA = "0x1F2D530", Offset = "0x1F2C130", VA = "0x181F2D530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602452A")]
			[Address(RVA = "0x1F2DB30", Offset = "0x1F2C730", VA = "0x181F2DB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055AB RID: 21931
		// (get) Token: 0x0602452B RID: 148779 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602452C RID: 148780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055AB")]
		public List<string> likeMeUidList
		{
			[Token(Token = "0x602452B")]
			[Address(RVA = "0x1F2D6C0", Offset = "0x1F2C2C0", VA = "0x181F2D6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602452C")]
			[Address(RVA = "0x1F2DC90", Offset = "0x1F2C890", VA = "0x181F2DC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602452D RID: 148781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602452D")]
		[Address(RVA = "0x1F2BDD0", Offset = "0x1F2A9D0", VA = "0x181F2BDD0")]
		public void LoadData(AutoChessPreparePage.Input input, [Optional] ActAutoChessSyncInfoBattleInfo battleInfo)
		{
		}

		// Token: 0x0602452E RID: 148782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602452E")]
		[Address(RVA = "0x1F2C5E0", Offset = "0x1F2B1E0", VA = "0x181F2C5E0")]
		public void RefreshData(AutoChessPrepareStateViewType viewType = AutoChessPrepareStateViewType.NONE)
		{
		}

		// Token: 0x0602452F RID: 148783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602452F")]
		[Address(RVA = "0x1F2C840", Offset = "0x1F2B440", VA = "0x181F2C840")]
		public void ResetFromBattleFlag()
		{
		}

		// Token: 0x06024530 RID: 148784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024530")]
		[Address(RVA = "0x1F2C190", Offset = "0x1F2AD90", VA = "0x181F2C190")]
		public void LoadFriendInfo(GetFriendAndRequestSendListResponse resp)
		{
		}

		// Token: 0x06024531 RID: 148785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024531")]
		[Address(RVA = "0x1F2C4F0", Offset = "0x1F2B0F0", VA = "0x181F2C4F0")]
		public void MarkFriendRequestSent(string uid)
		{
		}

		// Token: 0x06024532 RID: 148786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024532")]
		[Address(RVA = "0x1F2C8E0", Offset = "0x1F2B4E0", VA = "0x181F2C8E0")]
		public void SetPartnerNameCardData(string uid, FriendDataWithNameCard data)
		{
		}

		// Token: 0x06024533 RID: 148787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024533")]
		[Address(RVA = "0x1F2B990", Offset = "0x1F2A590", VA = "0x181F2B990")]
		public AutoChessServiceParam GetServiceParam()
		{
			return null;
		}

		// Token: 0x06024534 RID: 148788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024534")]
		[Address(RVA = "0x1F2BA30", Offset = "0x1F2A630", VA = "0x181F2BA30")]
		public AutoChessServiceTeamInfo GetTeamInfo()
		{
			return null;
		}

		// Token: 0x06024535 RID: 148789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024535")]
		[Address(RVA = "0x1F2B660", Offset = "0x1F2A260", VA = "0x181F2B660")]
		public AutoChessServiceBattleInfo GetBattleInfo()
		{
			return null;
		}

		// Token: 0x06024536 RID: 148790 RVA: 0x000C3CC0 File Offset: 0x000C1EC0
		[Token(Token = "0x6024536")]
		[Address(RVA = "0x1F2B700", Offset = "0x1F2A300", VA = "0x181F2B700")]
		public AutoChessTeamState GetCurTeamState()
		{
			return AutoChessTeamState.NONE;
		}

		// Token: 0x06024537 RID: 148791 RVA: 0x000C3CD8 File Offset: 0x000C1ED8
		[Token(Token = "0x6024537")]
		[Address(RVA = "0x1F2BB30", Offset = "0x1F2A730", VA = "0x181F2BB30")]
		public bool IsInRoom()
		{
			return default(bool);
		}

		// Token: 0x06024538 RID: 148792 RVA: 0x000C3CF0 File Offset: 0x000C1EF0
		[Token(Token = "0x6024538")]
		[Address(RVA = "0x1F2BCE0", Offset = "0x1F2A8E0", VA = "0x181F2BCE0")]
		public bool IsRoomOwner()
		{
			return default(bool);
		}

		// Token: 0x06024539 RID: 148793 RVA: 0x000C3D08 File Offset: 0x000C1F08
		[Token(Token = "0x6024539")]
		[Address(RVA = "0x1F2BBB0", Offset = "0x1F2A7B0", VA = "0x181F2BBB0")]
		public bool IsInTeam()
		{
			return default(bool);
		}

		// Token: 0x0602453A RID: 148794 RVA: 0x000C3D20 File Offset: 0x000C1F20
		[Token(Token = "0x602453A")]
		[Address(RVA = "0x1F2BC30", Offset = "0x1F2A830", VA = "0x181F2BC30")]
		public bool IsMultiMode()
		{
			return default(bool);
		}

		// Token: 0x0602453B RID: 148795 RVA: 0x000C3D38 File Offset: 0x000C1F38
		[Token(Token = "0x602453B")]
		[Address(RVA = "0x1F2B7C0", Offset = "0x1F2A3C0", VA = "0x181F2B7C0")]
		public FriendState GetFriendState(string uid)
		{
			return FriendState.NOT_FRIEND;
		}

		// Token: 0x0602453C RID: 148796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602453C")]
		[Address(RVA = "0x1F2B510", Offset = "0x1F2A110", VA = "0x181F2B510")]
		public AutoChessStageInfoGroupViewModel.Input GenStageInfoGroupViewModelInput()
		{
			return null;
		}

		// Token: 0x0602453D RID: 148797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602453D")]
		[Address(RVA = "0x1F2C720", Offset = "0x1F2B320", VA = "0x181F2C720")]
		public void RefreshLikeMeUidList(string uid)
		{
		}

		// Token: 0x0602453E RID: 148798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602453E")]
		[Address(RVA = "0x1F2CA30", Offset = "0x1F2B630", VA = "0x181F2CA30")]
		public void TryRefreshChannelInfoFromSettleGame(List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo> teamInfo)
		{
		}

		// Token: 0x0602453F RID: 148799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602453F")]
		[Address(RVA = "0x1F2B4A0", Offset = "0x1F2A0A0", VA = "0x181F2B4A0")]
		public string ConsumeInvitationTeamCode()
		{
			return null;
		}

		// Token: 0x06024540 RID: 148800 RVA: 0x000C3D50 File Offset: 0x000C1F50
		[Token(Token = "0x6024540")]
		[Address(RVA = "0x1F2CE00", Offset = "0x1F2BA00", VA = "0x181F2CE00")]
		private AutoChessPrepareStateViewType _InitViewType()
		{
			return AutoChessPrepareStateViewType.NONE;
		}

		// Token: 0x06024541 RID: 148801 RVA: 0x000C3D68 File Offset: 0x000C1F68
		[Token(Token = "0x6024541")]
		[Address(RVA = "0x1F2CD30", Offset = "0x1F2B930", VA = "0x181F2CD30")]
		private AutoChessPrepareStateViewType _GetViewTypeByCurTeamState()
		{
			return AutoChessPrepareStateViewType.NONE;
		}

		// Token: 0x06024542 RID: 148802 RVA: 0x000C3D80 File Offset: 0x000C1F80
		[Token(Token = "0x6024542")]
		[Address(RVA = "0x1F2CB60", Offset = "0x1F2B760", VA = "0x181F2CB60")]
		private int _GetPlayerGsChannel(string uid)
		{
			return 0;
		}

		// Token: 0x06024543 RID: 148803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024543")]
		[Address(RVA = "0x1F2D150", Offset = "0x1F2BD50", VA = "0x181F2D150")]
		public AutoChessPrepareModel()
		{
		}

		// Token: 0x040327FE RID: 206846
		[Token(Token = "0x40327FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, int> m_playerGsChannels;

		// Token: 0x040327FF RID: 206847
		[Token(Token = "0x40327FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_invitationTeamCode;

		// Token: 0x0403280D RID: 206861
		[Token(Token = "0x403280D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403280E RID: 206862
		[Token(Token = "0x403280E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403280F RID: 206863
		[Token(Token = "0x403280F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isLocalMode;

		// Token: 0x04032810 RID: 206864
		[Token(Token = "0x4032810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isLocalMode;

		// Token: 0x04032811 RID: 206865
		[Token(Token = "0x4032811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x04032812 RID: 206866
		[Token(Token = "0x4032812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_modeType;

		// Token: 0x04032813 RID: 206867
		[Token(Token = "0x4032813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_multiModeSubType;

		// Token: 0x04032814 RID: 206868
		[Token(Token = "0x4032814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_multiModeSubType;

		// Token: 0x04032815 RID: 206869
		[Token(Token = "0x4032815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_fromBattleSource;

		// Token: 0x04032816 RID: 206870
		[Token(Token = "0x4032816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_fromBattleSource;

		// Token: 0x04032817 RID: 206871
		[Token(Token = "0x4032817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04032818 RID: 206872
		[Token(Token = "0x4032818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_battleInfo;

		// Token: 0x04032819 RID: 206873
		[Token(Token = "0x4032819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_curViewType;

		// Token: 0x0403281A RID: 206874
		[Token(Token = "0x403281A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_curViewType;

		// Token: 0x0403281B RID: 206875
		[Token(Token = "0x403281B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_isServiceStarted;

		// Token: 0x0403281C RID: 206876
		[Token(Token = "0x403281C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_selfUid;

		// Token: 0x0403281D RID: 206877
		[Token(Token = "0x403281D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_selfUid;

		// Token: 0x0403281E RID: 206878
		[Token(Token = "0x403281E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_cachedPartnerUid;

		// Token: 0x0403281F RID: 206879
		[Token(Token = "0x403281F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_cachedPartnerUid;

		// Token: 0x04032820 RID: 206880
		[Token(Token = "0x4032820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_cachedPartnerNameCardData;

		// Token: 0x04032821 RID: 206881
		[Token(Token = "0x4032821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_cachedPartnerNameCardData;

		// Token: 0x04032822 RID: 206882
		[Token(Token = "0x4032822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_friendInfoDict;

		// Token: 0x04032823 RID: 206883
		[Token(Token = "0x4032823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_friendInfoDict;

		// Token: 0x04032824 RID: 206884
		[Token(Token = "0x4032824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_friendRequsetCDSet;

		// Token: 0x04032825 RID: 206885
		[Token(Token = "0x4032825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_friendRequsetCDSet;

		// Token: 0x04032826 RID: 206886
		[Token(Token = "0x4032826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_likeMeUidList;

		// Token: 0x04032827 RID: 206887
		[Token(Token = "0x4032827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_likeMeUidList;

		// Token: 0x04032828 RID: 206888
		[Token(Token = "0x4032828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032829 RID: 206889
		[Token(Token = "0x4032829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403282A RID: 206890
		[Token(Token = "0x403282A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ResetFromBattleFlag;

		// Token: 0x0403282B RID: 206891
		[Token(Token = "0x403282B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_LoadFriendInfo;

		// Token: 0x0403282C RID: 206892
		[Token(Token = "0x403282C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_MarkFriendRequestSent;

		// Token: 0x0403282D RID: 206893
		[Token(Token = "0x403282D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SetPartnerNameCardData;

		// Token: 0x0403282E RID: 206894
		[Token(Token = "0x403282E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetServiceParam;

		// Token: 0x0403282F RID: 206895
		[Token(Token = "0x403282F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetTeamInfo;

		// Token: 0x04032830 RID: 206896
		[Token(Token = "0x4032830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetBattleInfo;

		// Token: 0x04032831 RID: 206897
		[Token(Token = "0x4032831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetCurTeamState;

		// Token: 0x04032832 RID: 206898
		[Token(Token = "0x4032832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_IsInRoom;

		// Token: 0x04032833 RID: 206899
		[Token(Token = "0x4032833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_IsRoomOwner;

		// Token: 0x04032834 RID: 206900
		[Token(Token = "0x4032834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_IsInTeam;

		// Token: 0x04032835 RID: 206901
		[Token(Token = "0x4032835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_IsMultiMode;

		// Token: 0x04032836 RID: 206902
		[Token(Token = "0x4032836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetFriendState;

		// Token: 0x04032837 RID: 206903
		[Token(Token = "0x4032837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GenStageInfoGroupViewModelInput;

		// Token: 0x04032838 RID: 206904
		[Token(Token = "0x4032838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_RefreshLikeMeUidList;

		// Token: 0x04032839 RID: 206905
		[Token(Token = "0x4032839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_TryRefreshChannelInfoFromSettleGame;

		// Token: 0x0403283A RID: 206906
		[Token(Token = "0x403283A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_ConsumeInvitationTeamCode;

		// Token: 0x0403283B RID: 206907
		[Token(Token = "0x403283B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__InitViewType;

		// Token: 0x0403283C RID: 206908
		[Token(Token = "0x403283C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__GetViewTypeByCurTeamState;

		// Token: 0x0403283D RID: 206909
		[Token(Token = "0x403283D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__GetPlayerGsChannel;

		// Token: 0x0403283E RID: 206910
		[Token(Token = "0x403283E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
