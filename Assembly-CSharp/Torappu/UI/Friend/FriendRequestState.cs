using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D5F RID: 19807
	[Token(Token = "0x2004D5F")]
	public class FriendRequestState : State
	{
		// Token: 0x0601DA28 RID: 121384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA28")]
		[Address(RVA = "0x172AA80", Offset = "0x1729680", VA = "0x18172AA80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DA29 RID: 121385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA29")]
		[Address(RVA = "0x172AC80", Offset = "0x1729880", VA = "0x18172AC80")]
		public void OnFriendDealRequest(FriendData requestPlayer, FriendDealEnum dealAction)
		{
		}

		// Token: 0x0601DA2A RID: 121386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA2A")]
		[Address(RVA = "0x172AE00", Offset = "0x1729A00", VA = "0x18172AE00")]
		public void SendFriendRequestListRequest()
		{
		}

		// Token: 0x0601DA2B RID: 121387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA2B")]
		[Address(RVA = "0x172AD20", Offset = "0x1729920", VA = "0x18172AD20")]
		public void SendFriendRequestListRequestContinue()
		{
		}

		// Token: 0x0601DA2C RID: 121388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA2C")]
		[Address(RVA = "0x172B4A0", Offset = "0x172A0A0", VA = "0x18172B4A0")]
		private void _SendFriendRequestListRequest(int index)
		{
		}

		// Token: 0x0601DA2D RID: 121389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA2D")]
		[Address(RVA = "0x172B230", Offset = "0x1729E30", VA = "0x18172B230")]
		private void _SendFriendDealRequest(FriendData requestPlayer, FriendDealEnum dealAction)
		{
		}

		// Token: 0x0601DA2E RID: 121390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DA2E")]
		[Address(RVA = "0x172AA20", Offset = "0x1729620", VA = "0x18172AA20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DA2F RID: 121391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA2F")]
		[Address(RVA = "0x172B900", Offset = "0x172A500", VA = "0x18172B900")]
		public FriendRequestState()
		{
		}

		// Token: 0x0601DA31 RID: 121393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA31")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04027240 RID: 160320
		[Token(Token = "0x4027240")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private FriendListStateBean _stateBean;

		// Token: 0x04027241 RID: 160321
		[Token(Token = "0x4027241")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FriendStateControl _stateControl;

		// Token: 0x04027242 RID: 160322
		[Token(Token = "0x4027242")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027243 RID: 160323
		[Token(Token = "0x4027243")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFriendDealRequest;

		// Token: 0x04027244 RID: 160324
		[Token(Token = "0x4027244")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendFriendRequestListRequest;

		// Token: 0x04027245 RID: 160325
		[Token(Token = "0x4027245")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendFriendRequestListRequestContinue;

		// Token: 0x04027246 RID: 160326
		[Token(Token = "0x4027246")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendFriendRequestListRequest;

		// Token: 0x04027247 RID: 160327
		[Token(Token = "0x4027247")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendFriendDealRequest;

		// Token: 0x04027248 RID: 160328
		[Token(Token = "0x4027248")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027249 RID: 160329
		[Token(Token = "0x4027249")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
