using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D62 RID: 19810
	[Token(Token = "0x2004D62")]
	public class FriendSearchState : PopupFloatState
	{
		// Token: 0x0601DA36 RID: 121398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA36")]
		[Address(RVA = "0x172BBA0", Offset = "0x172A7A0", VA = "0x18172BBA0")]
		public void RemoveTop()
		{
		}

		// Token: 0x0601DA37 RID: 121399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DA37")]
		[Address(RVA = "0x172B960", Offset = "0x172A560", VA = "0x18172B960", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DA38 RID: 121400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA38")]
		[Address(RVA = "0x172BA40", Offset = "0x172A640", VA = "0x18172BA40")]
		public void OnSearch(string searchKeyWord)
		{
		}

		// Token: 0x0601DA39 RID: 121401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA39")]
		[Address(RVA = "0x172B9C0", Offset = "0x172A5C0", VA = "0x18172B9C0")]
		public void OnFriendRequest(FriendData friend)
		{
		}

		// Token: 0x0601DA3A RID: 121402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA3A")]
		[Address(RVA = "0x172BDB0", Offset = "0x172A9B0", VA = "0x18172BDB0")]
		public void SendSearchRequest(string inputNickName, string inputNickId)
		{
		}

		// Token: 0x0601DA3B RID: 121403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA3B")]
		[Address(RVA = "0x172C9B0", Offset = "0x172B5B0", VA = "0x18172C9B0")]
		private void _SendSearchContinue(int index)
		{
		}

		// Token: 0x0601DA3C RID: 121404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA3C")]
		[Address(RVA = "0x172C1F0", Offset = "0x172ADF0", VA = "0x18172C1F0")]
		public void SendSearchResultNextPage(int index)
		{
		}

		// Token: 0x0601DA3D RID: 121405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA3D")]
		[Address(RVA = "0x172C110", Offset = "0x172AD10", VA = "0x18172C110")]
		public void SendSearchResultNextPage()
		{
		}

		// Token: 0x0601DA3E RID: 121406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA3E")]
		[Address(RVA = "0x172C790", Offset = "0x172B390", VA = "0x18172C790")]
		private void _SendFriendProcessRequestListRequest(FriendData friend)
		{
		}

		// Token: 0x0601DA3F RID: 121407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA3F")]
		[Address(RVA = "0x172CE10", Offset = "0x172BA10", VA = "0x18172CE10")]
		public FriendSearchState()
		{
		}

		// Token: 0x0402724F RID: 160335
		[Token(Token = "0x402724F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FriendListStateBean _stateBean;

		// Token: 0x04027250 RID: 160336
		[Token(Token = "0x4027250")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private FriendSearchView _searchView;

		// Token: 0x04027251 RID: 160337
		[Token(Token = "0x4027251")]
		[FieldOffset(Offset = "0x80")]
		private string m_cacheInputNickName;

		// Token: 0x04027252 RID: 160338
		[Token(Token = "0x4027252")]
		[FieldOffset(Offset = "0x88")]
		private string m_inputNickId;

		// Token: 0x04027253 RID: 160339
		[Token(Token = "0x4027253")]
		private const string NICKNAME_PARAM = "nickName";

		// Token: 0x04027254 RID: 160340
		[Token(Token = "0x4027254")]
		private const string NICKID_PARAM = "nickNumber";

		// Token: 0x04027255 RID: 160341
		[Token(Token = "0x4027255")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RemoveTop;

		// Token: 0x04027256 RID: 160342
		[Token(Token = "0x4027256")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027257 RID: 160343
		[Token(Token = "0x4027257")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSearch;

		// Token: 0x04027258 RID: 160344
		[Token(Token = "0x4027258")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFriendRequest;

		// Token: 0x04027259 RID: 160345
		[Token(Token = "0x4027259")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SendSearchRequest;

		// Token: 0x0402725A RID: 160346
		[Token(Token = "0x402725A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendSearchContinue;

		// Token: 0x0402725B RID: 160347
		[Token(Token = "0x402725B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SendSearchResultNextPage;

		// Token: 0x0402725C RID: 160348
		[Token(Token = "0x402725C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_SendSearchResultNextPage;

		// Token: 0x0402725D RID: 160349
		[Token(Token = "0x402725D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SendFriendProcessRequestListRequest;

		// Token: 0x0402725E RID: 160350
		[Token(Token = "0x402725E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
