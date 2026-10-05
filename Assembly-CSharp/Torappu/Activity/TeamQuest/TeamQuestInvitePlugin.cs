using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CommonInviteDialog;
using Torappu.UI.Friend;
using XLua;

namespace Torappu.Activity.TeamQuest
{
	// Token: 0x02006EAD RID: 28333
	[Token(Token = "0x2006EAD")]
	public class TeamQuestInvitePlugin : CommonInviteDialog.Plugin
	{
		// Token: 0x060284D4 RID: 165076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284D4")]
		[Address(RVA = "0x2397580", Offset = "0x2396180", VA = "0x182397580", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060284D5 RID: 165077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284D5")]
		[Address(RVA = "0x2397360", Offset = "0x2395F60", VA = "0x182397360", Slot = "8")]
		public override List<string> DefineFriendSortInfoKeys()
		{
			return null;
		}

		// Token: 0x060284D6 RID: 165078 RVA: 0x000D1520 File Offset: 0x000CF720
		[Token(Token = "0x60284D6")]
		[Address(RVA = "0x23973E0", Offset = "0x2395FE0", VA = "0x1823973E0", Slot = "5")]
		public override CommonInviteSortInfo.CustomImpl HandleFriendCustomSortInfo(FriendSortViewModel respModel)
		{
			return default(CommonInviteSortInfo.CustomImpl);
		}

		// Token: 0x060284D7 RID: 165079 RVA: 0x000D1538 File Offset: 0x000CF738
		[Token(Token = "0x60284D7")]
		[Address(RVA = "0x2397510", Offset = "0x2396110", VA = "0x182397510", Slot = "6")]
		public override CommonInviteSortInfo.CustomImpl HandleInviteCustomSortInfo(PlayerInviteInfo inviteInfo)
		{
			return default(CommonInviteSortInfo.CustomImpl);
		}

		// Token: 0x060284D8 RID: 165080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284D8")]
		[Address(RVA = "0x2397660", Offset = "0x2396260", VA = "0x182397660")]
		public TeamQuestInvitePlugin()
		{
		}

		// Token: 0x060284D9 RID: 165081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284D9")]
		[Address(RVA = "0x1F223E0", Offset = "0x1F20FE0", VA = "0x181F223E0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x060284DA RID: 165082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284DA")]
		[Address(RVA = "0x1F223C0", Offset = "0x1F20FC0", VA = "0x181F223C0")]
		private List<string> <>xLuaBaseProxy_DefineFriendSortInfoKeys()
		{
			return null;
		}

		// Token: 0x0403946D RID: 234605
		[Token(Token = "0x403946D")]
		private const string FIELD_IN_TEAM = "inTeam";

		// Token: 0x0403946E RID: 234606
		[Token(Token = "0x403946E")]
		private const string FIELD_LEAVE_TS = "leaveTs";

		// Token: 0x0403946F RID: 234607
		[Token(Token = "0x403946F")]
		[FieldOffset(Offset = "0x28")]
		private string m_actId;

		// Token: 0x04039470 RID: 234608
		[Token(Token = "0x4039470")]
		[FieldOffset(Offset = "0x30")]
		private string m_actType;

		// Token: 0x04039471 RID: 234609
		[Token(Token = "0x4039471")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04039472 RID: 234610
		[Token(Token = "0x4039472")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DefineFriendSortInfoKeys;

		// Token: 0x04039473 RID: 234611
		[Token(Token = "0x4039473")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleFriendCustomSortInfo;

		// Token: 0x04039474 RID: 234612
		[Token(Token = "0x4039474")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleInviteCustomSortInfo;

		// Token: 0x04039475 RID: 234613
		[Token(Token = "0x4039475")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
