using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D64 RID: 19812
	[Token(Token = "0x2004D64")]
	public class FriendShowCharacterState : PopupFloatState
	{
		// Token: 0x0601DA44 RID: 121412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DA44")]
		[Address(RVA = "0x172CF20", Offset = "0x172BB20", VA = "0x18172CF20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DA45 RID: 121413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA45")]
		[Address(RVA = "0x172CF80", Offset = "0x172BB80", VA = "0x18172CF80")]
		public void LoadNecessarySprite(CharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x0601DA46 RID: 121414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA46")]
		[Address(RVA = "0x172CE70", Offset = "0x172BA70", VA = "0x18172CE70")]
		public void BackToState()
		{
		}

		// Token: 0x0601DA47 RID: 121415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA47")]
		[Address(RVA = "0x172D050", Offset = "0x172BC50", VA = "0x18172D050", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DA48 RID: 121416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA48")]
		[Address(RVA = "0x172D370", Offset = "0x172BF70", VA = "0x18172D370")]
		public FriendShowCharacterState()
		{
		}

		// Token: 0x0601DA49 RID: 121417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA49")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04027262 RID: 160354
		[Token(Token = "0x4027262")]
		private const int CARDMAXNUM = 3;

		// Token: 0x04027263 RID: 160355
		[Token(Token = "0x4027263")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FriendListStateBean _stateBean;

		// Token: 0x04027264 RID: 160356
		[Token(Token = "0x4027264")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform[] _cardContainer;

		// Token: 0x04027265 RID: 160357
		[Token(Token = "0x4027265")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private FriendStateControl _stateControl;

		// Token: 0x04027266 RID: 160358
		[Token(Token = "0x4027266")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private FriendCardView _cardView;

		// Token: 0x04027267 RID: 160359
		[Token(Token = "0x4027267")]
		[FieldOffset(Offset = "0x90")]
		private List<FriendCardView> m_cardViewList;

		// Token: 0x04027268 RID: 160360
		[Token(Token = "0x4027268")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027269 RID: 160361
		[Token(Token = "0x4027269")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadNecessarySprite;

		// Token: 0x0402726A RID: 160362
		[Token(Token = "0x402726A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BackToState;

		// Token: 0x0402726B RID: 160363
		[Token(Token = "0x402726B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402726C RID: 160364
		[Token(Token = "0x402726C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
