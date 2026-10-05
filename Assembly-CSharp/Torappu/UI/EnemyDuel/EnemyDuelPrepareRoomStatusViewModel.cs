using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005040 RID: 20544
	[Token(Token = "0x2005040")]
	public class EnemyDuelPrepareRoomStatusViewModel : IHotfixable
	{
		// Token: 0x0601E771 RID: 124785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E771")]
		[Address(RVA = "0x1829960", Offset = "0x1828560", VA = "0x181829960")]
		private void LoadModeData(string modeId)
		{
		}

		// Token: 0x0601E772 RID: 124786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E772")]
		[Address(RVA = "0x1829B00", Offset = "0x1828700", VA = "0x181829B00")]
		public void LoadStableData(string actId)
		{
		}

		// Token: 0x0601E773 RID: 124787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E773")]
		[Address(RVA = "0x1829BD0", Offset = "0x18287D0", VA = "0x181829BD0")]
		public void UpdateFriendData(GetFriendAndRequestSendListResponse resp)
		{
		}

		// Token: 0x0601E774 RID: 124788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E774")]
		[Address(RVA = "0x18298A0", Offset = "0x18284A0", VA = "0x1818298A0")]
		public void AddSentFriendRequestId(string id)
		{
		}

		// Token: 0x0601E775 RID: 124789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E775")]
		[Address(RVA = "0x1829DC0", Offset = "0x18289C0", VA = "0x181829DC0")]
		public void UpdateTeamSvrData()
		{
		}

		// Token: 0x0601E776 RID: 124790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E776")]
		[Address(RVA = "0x182A310", Offset = "0x1828F10", VA = "0x18182A310")]
		public EnemyDuelPrepareRoomStatusViewModel()
		{
		}

		// Token: 0x04028C91 RID: 167057
		[Token(Token = "0x4028C91")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04028C92 RID: 167058
		[Token(Token = "0x4028C92")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;

		// Token: 0x04028C93 RID: 167059
		[Token(Token = "0x4028C93")]
		[FieldOffset(Offset = "0x20")]
		public EnemyDuelPrepareRoomStatusViewModel.ReadyState readyState;

		// Token: 0x04028C94 RID: 167060
		[Token(Token = "0x4028C94")]
		[FieldOffset(Offset = "0x28")]
		public long roomEndTs;

		// Token: 0x04028C95 RID: 167061
		[Token(Token = "0x4028C95")]
		[FieldOffset(Offset = "0x30")]
		public EnemyDuelServiceTeamInfo teamInfo;

		// Token: 0x04028C96 RID: 167062
		[Token(Token = "0x4028C96")]
		[FieldOffset(Offset = "0x38")]
		public ActivityEnemyDuelModeData modeData;

		// Token: 0x04028C97 RID: 167063
		[Token(Token = "0x4028C97")]
		[FieldOffset(Offset = "0x40")]
		public List<EnemyDuelPrepareRoomPlayerCardViewModel> playerCardViewModels;

		// Token: 0x04028C98 RID: 167064
		[Token(Token = "0x4028C98")]
		[FieldOffset(Offset = "0x48")]
		public EnemyDuelPrepareRoomPlayerCardViewModel selfCardViewModel;

		// Token: 0x04028C99 RID: 167065
		[Token(Token = "0x4028C99")]
		[FieldOffset(Offset = "0x50")]
		public bool allowNpc;

		// Token: 0x04028C9A RID: 167066
		[Token(Token = "0x4028C9A")]
		[FieldOffset(Offset = "0x58")]
		private ActivityEnemyDuelData actData;

		// Token: 0x04028C9B RID: 167067
		[Token(Token = "0x4028C9B")]
		[FieldOffset(Offset = "0x60")]
		private ActivityEnemyDuelConstData constData;

		// Token: 0x04028C9C RID: 167068
		[Token(Token = "0x4028C9C")]
		[FieldOffset(Offset = "0x68")]
		public HashSet<string> friendIds;

		// Token: 0x04028C9D RID: 167069
		[Token(Token = "0x4028C9D")]
		[FieldOffset(Offset = "0x70")]
		public HashSet<string> friendRequestSentIds;

		// Token: 0x04028C9E RID: 167070
		[Token(Token = "0x4028C9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadModeData;

		// Token: 0x04028C9F RID: 167071
		[Token(Token = "0x4028C9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadStableData;

		// Token: 0x04028CA0 RID: 167072
		[Token(Token = "0x4028CA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateFriendData;

		// Token: 0x04028CA1 RID: 167073
		[Token(Token = "0x4028CA1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AddSentFriendRequestId;

		// Token: 0x04028CA2 RID: 167074
		[Token(Token = "0x4028CA2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateTeamSvrData;

		// Token: 0x04028CA3 RID: 167075
		[Token(Token = "0x4028CA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005041 RID: 20545
		[Token(Token = "0x2005041")]
		public enum ReadyState
		{
			// Token: 0x04028CA5 RID: 167077
			[Token(Token = "0x4028CA5")]
			CAN_START,
			// Token: 0x04028CA6 RID: 167078
			[Token(Token = "0x4028CA6")]
			LACK_OF_PLAYER,
			// Token: 0x04028CA7 RID: 167079
			[Token(Token = "0x4028CA7")]
			HAS_RETURNING_PLAYER
		}
	}
}
