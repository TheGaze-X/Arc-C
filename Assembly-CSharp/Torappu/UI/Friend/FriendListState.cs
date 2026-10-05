using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D54 RID: 19796
	[Token(Token = "0x2004D54")]
	public class FriendListState : State, IValueMsgReceiver
	{
		// Token: 0x0601D9FB RID: 121339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9FB")]
		[Address(RVA = "0x17278D0", Offset = "0x17264D0", VA = "0x1817278D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D9FC RID: 121340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9FC")]
		[Address(RVA = "0x1727D40", Offset = "0x1726940", VA = "0x181727D40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D9FD RID: 121341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9FD")]
		[Address(RVA = "0x1728010", Offset = "0x1726C10", VA = "0x181728010")]
		public void OnFriendShow(FriendData friendData)
		{
		}

		// Token: 0x0601D9FE RID: 121342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9FE")]
		[Address(RVA = "0x1727B30", Offset = "0x1726730", VA = "0x181727B30")]
		public void OnDeleteFriend(string uid)
		{
		}

		// Token: 0x0601D9FF RID: 121343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9FF")]
		[Address(RVA = "0x1727930", Offset = "0x1726530", VA = "0x181727930")]
		public void OnAliasRequest(string alias, string uid)
		{
		}

		// Token: 0x0601DA00 RID: 121344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA00")]
		[Address(RVA = "0x17279F0", Offset = "0x17265F0", VA = "0x1817279F0")]
		public void OnAliasSendRequest(string uid, string alias)
		{
		}

		// Token: 0x0601DA01 RID: 121345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA01")]
		[Address(RVA = "0x1727AB0", Offset = "0x17266B0", VA = "0x181727AB0")]
		public void OnCancelAlias()
		{
		}

		// Token: 0x0601DA02 RID: 121346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA02")]
		[Address(RVA = "0x1728B70", Offset = "0x1727770", VA = "0x181728B70")]
		private void _SendFriendList(int index)
		{
		}

		// Token: 0x0601DA03 RID: 121347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA03")]
		[Address(RVA = "0x17283F0", Offset = "0x1726FF0", VA = "0x1817283F0")]
		public void SendFriendListRequest()
		{
		}

		// Token: 0x0601DA04 RID: 121348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA04")]
		[Address(RVA = "0x1728310", Offset = "0x1726F10", VA = "0x181728310")]
		public void SendFriendListRequestContinue()
		{
		}

		// Token: 0x0601DA05 RID: 121349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA05")]
		[Address(RVA = "0x1728910", Offset = "0x1727510", VA = "0x181728910")]
		private void _SendDeleteFriend(string uid)
		{
		}

		// Token: 0x0601DA06 RID: 121350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA06")]
		[Address(RVA = "0x1728FD0", Offset = "0x1727BD0", VA = "0x181728FD0")]
		private void _SendSetFriendAliasRequest(string uid, string alias)
		{
		}

		// Token: 0x0601DA07 RID: 121351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA07")]
		[Address(RVA = "0x1727510", Offset = "0x1726110", VA = "0x181727510")]
		public void EventOnClearEditStar()
		{
		}

		// Token: 0x0601DA08 RID: 121352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA08")]
		[Address(RVA = "0x17275D0", Offset = "0x17261D0", VA = "0x1817275D0")]
		public void EventOnConfrimEditStar()
		{
		}

		// Token: 0x0601DA09 RID: 121353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA09")]
		[Address(RVA = "0x1728150", Offset = "0x1726D50", VA = "0x181728150", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601DA0A RID: 121354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA0A")]
		[Address(RVA = "0x17287F0", Offset = "0x17273F0", VA = "0x1817287F0")]
		private void _EventOnToggleFriendStar(string uid)
		{
		}

		// Token: 0x0601DA0B RID: 121355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA0B")]
		[Address(RVA = "0x1729260", Offset = "0x1727E60", VA = "0x181729260")]
		public FriendListState()
		{
		}

		// Token: 0x0601DA0D RID: 121357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA0D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402720B RID: 160267
		[Token(Token = "0x402720B")]
		public const int MSG_TOGGLE_FRIEND_STAR = 1;

		// Token: 0x0402720C RID: 160268
		[Token(Token = "0x402720C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private FriendListStateBean _stateBean;

		// Token: 0x0402720D RID: 160269
		[Token(Token = "0x402720D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FriendStateControl _stateControl;

		// Token: 0x0402720E RID: 160270
		[Token(Token = "0x402720E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private FriendAliasView _aliasView;

		// Token: 0x0402720F RID: 160271
		[Token(Token = "0x402720F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027210 RID: 160272
		[Token(Token = "0x4027210")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027211 RID: 160273
		[Token(Token = "0x4027211")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFriendShow;

		// Token: 0x04027212 RID: 160274
		[Token(Token = "0x4027212")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDeleteFriend;

		// Token: 0x04027213 RID: 160275
		[Token(Token = "0x4027213")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAliasRequest;

		// Token: 0x04027214 RID: 160276
		[Token(Token = "0x4027214")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnAliasSendRequest;

		// Token: 0x04027215 RID: 160277
		[Token(Token = "0x4027215")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCancelAlias;

		// Token: 0x04027216 RID: 160278
		[Token(Token = "0x4027216")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendFriendList;

		// Token: 0x04027217 RID: 160279
		[Token(Token = "0x4027217")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SendFriendListRequest;

		// Token: 0x04027218 RID: 160280
		[Token(Token = "0x4027218")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SendFriendListRequestContinue;

		// Token: 0x04027219 RID: 160281
		[Token(Token = "0x4027219")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SendDeleteFriend;

		// Token: 0x0402721A RID: 160282
		[Token(Token = "0x402721A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SendSetFriendAliasRequest;

		// Token: 0x0402721B RID: 160283
		[Token(Token = "0x402721B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnClearEditStar;

		// Token: 0x0402721C RID: 160284
		[Token(Token = "0x402721C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnConfrimEditStar;

		// Token: 0x0402721D RID: 160285
		[Token(Token = "0x402721D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402721E RID: 160286
		[Token(Token = "0x402721E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnToggleFriendStar;

		// Token: 0x0402721F RID: 160287
		[Token(Token = "0x402721F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
