using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DAA RID: 19882
	[Token(Token = "0x2004DAA")]
	public class FriendListItem : FriendListItemBase
	{
		// Token: 0x0601DBC2 RID: 121794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBC2")]
		[Address(RVA = "0x17416B0", Offset = "0x17402B0", VA = "0x1817416B0")]
		public void UpdateStarStatus(bool isInEditStarMode, bool isEditSelect, bool isCurrStar)
		{
		}

		// Token: 0x0601DBC3 RID: 121795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBC3")]
		[Address(RVA = "0x17415C0", Offset = "0x17401C0", VA = "0x1817415C0")]
		public void EventOnEditStar()
		{
		}

		// Token: 0x0601DBC4 RID: 121796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBC4")]
		[Address(RVA = "0x1741810", Offset = "0x1740410", VA = "0x181741810")]
		public FriendListItem()
		{
		}

		// Token: 0x0402752A RID: 161066
		[Token(Token = "0x402752A")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _funcBtnPartGO;

		// Token: 0x0402752B RID: 161067
		[Token(Token = "0x402752B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _starEditPartGO;

		// Token: 0x0402752C RID: 161068
		[Token(Token = "0x402752C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _starIconGO;

		// Token: 0x0402752D RID: 161069
		[Token(Token = "0x402752D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private CanvasGroup _starSelectAlphaHandler;

		// Token: 0x0402752E RID: 161070
		[Token(Token = "0x402752E")]
		[FieldOffset(Offset = "0x128")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402752F RID: 161071
		[Token(Token = "0x402752F")]
		[FieldOffset(Offset = "0x138")]
		private FadeSwitchTween m_selectFadeTween;

		// Token: 0x04027530 RID: 161072
		[Token(Token = "0x4027530")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStarStatus;

		// Token: 0x04027531 RID: 161073
		[Token(Token = "0x4027531")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnEditStar;

		// Token: 0x04027532 RID: 161074
		[Token(Token = "0x4027532")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
