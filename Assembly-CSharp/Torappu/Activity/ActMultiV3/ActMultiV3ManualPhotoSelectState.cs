using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F48 RID: 28488
	[Token(Token = "0x2006F48")]
	public class ActMultiV3ManualPhotoSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06028752 RID: 165714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028752")]
		[Address(RVA = "0x23C0ED0", Offset = "0x23BFAD0", VA = "0x1823C0ED0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028753 RID: 165715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028753")]
		[Address(RVA = "0x23C0F30", Offset = "0x23BFB30", VA = "0x1823C0F30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028754 RID: 165716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028754")]
		[Address(RVA = "0x23C1740", Offset = "0x23C0340", VA = "0x1823C1740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028755 RID: 165717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028755")]
		[Address(RVA = "0x23C10C0", Offset = "0x23BFCC0", VA = "0x1823C10C0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028756 RID: 165718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028756")]
		[Address(RVA = "0x23C22C0", Offset = "0x23C0EC0", VA = "0x1823C22C0")]
		private void _OnSelectPhoto(int photoIdx)
		{
		}

		// Token: 0x06028757 RID: 165719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028757")]
		[Address(RVA = "0x23C1930", Offset = "0x23C0530", VA = "0x1823C1930")]
		private void _OnApplyFriend()
		{
		}

		// Token: 0x06028758 RID: 165720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028758")]
		[Address(RVA = "0x23C23A0", Offset = "0x23C0FA0", VA = "0x1823C23A0")]
		private void _OnSendFriendReqSuc(string uid)
		{
		}

		// Token: 0x06028759 RID: 165721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028759")]
		[Address(RVA = "0x23C1DD0", Offset = "0x23C09D0", VA = "0x1823C1DD0")]
		private void _OnCheckNameCard()
		{
		}

		// Token: 0x0602875A RID: 165722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602875A")]
		[Address(RVA = "0x23C2960", Offset = "0x23C1560", VA = "0x1823C2960")]
		private void _OpenNameCardDisplayPage(FriendDataWithNameCard friendData)
		{
		}

		// Token: 0x0602875B RID: 165723 RVA: 0x000D1D78 File Offset: 0x000CFF78
		[Token(Token = "0x602875B")]
		[Address(RVA = "0x23C2A80", Offset = "0x23C1680", VA = "0x1823C2A80")]
		private bool _TryGetNameCardData(string uid, out FriendDataWithNameCard data)
		{
			return default(bool);
		}

		// Token: 0x0602875C RID: 165724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602875C")]
		[Address(RVA = "0x23C15F0", Offset = "0x23C01F0", VA = "0x1823C15F0")]
		private void _CacheNameCardData(string uid, FriendDataWithNameCard data)
		{
		}

		// Token: 0x0602875D RID: 165725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602875D")]
		[Address(RVA = "0x23C2630", Offset = "0x23C1230", VA = "0x1823C2630")]
		private void _OnSubmitPhoto()
		{
		}

		// Token: 0x0602875E RID: 165726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602875E")]
		[Address(RVA = "0x23C21D0", Offset = "0x23C0DD0", VA = "0x1823C21D0")]
		private void _OnClickComittedPhoto()
		{
		}

		// Token: 0x0602875F RID: 165727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602875F")]
		[Address(RVA = "0x23C2560", Offset = "0x23C1160", VA = "0x1823C2560")]
		private void _OnShowHideDetail()
		{
		}

		// Token: 0x06028760 RID: 165728 RVA: 0x000D1D90 File Offset: 0x000CFF90
		[Token(Token = "0x6028760")]
		[Address(RVA = "0x23C1850", Offset = "0x23C0450", VA = "0x1823C1850")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x06028761 RID: 165729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028761")]
		[Address(RVA = "0x23C2BE0", Offset = "0x23C17E0", VA = "0x1823C2BE0")]
		public ActMultiV3ManualPhotoSelectState()
		{
		}

		// Token: 0x06028764 RID: 165732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028764")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040398C3 RID: 235715
		[Token(Token = "0x40398C3")]
		[NonSerialized]
		public const int ON_SELECT_PHOTO = 1;

		// Token: 0x040398C4 RID: 235716
		[Token(Token = "0x40398C4")]
		[NonSerialized]
		public const int ON_APPLY_FRIEND = 2;

		// Token: 0x040398C5 RID: 235717
		[Token(Token = "0x40398C5")]
		[NonSerialized]
		public const int ON_CHECK_NAMECARD = 3;

		// Token: 0x040398C6 RID: 235718
		[Token(Token = "0x40398C6")]
		[NonSerialized]
		public const int ON_SUBMIT_PHOTO = 4;

		// Token: 0x040398C7 RID: 235719
		[Token(Token = "0x40398C7")]
		[NonSerialized]
		public const int ON_CLICK_COMITTED_PHOTO = 5;

		// Token: 0x040398C8 RID: 235720
		[Token(Token = "0x40398C8")]
		[NonSerialized]
		public const int ON_SHOW_HIDE_DETAIL = 6;

		// Token: 0x040398C9 RID: 235721
		[Token(Token = "0x40398C9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040398CA RID: 235722
		[Token(Token = "0x40398CA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActMultiV3PhotoSelectView _view;

		// Token: 0x040398CB RID: 235723
		[Token(Token = "0x40398CB")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x040398CC RID: 235724
		[Token(Token = "0x40398CC")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3ManualPhotoSelectStateBean m_stateBean;

		// Token: 0x040398CD RID: 235725
		[Token(Token = "0x40398CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040398CE RID: 235726
		[Token(Token = "0x40398CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040398CF RID: 235727
		[Token(Token = "0x40398CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040398D0 RID: 235728
		[Token(Token = "0x40398D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040398D1 RID: 235729
		[Token(Token = "0x40398D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSelectPhoto;

		// Token: 0x040398D2 RID: 235730
		[Token(Token = "0x40398D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnApplyFriend;

		// Token: 0x040398D3 RID: 235731
		[Token(Token = "0x40398D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSendFriendReqSuc;

		// Token: 0x040398D4 RID: 235732
		[Token(Token = "0x40398D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCheckNameCard;

		// Token: 0x040398D5 RID: 235733
		[Token(Token = "0x40398D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OpenNameCardDisplayPage;

		// Token: 0x040398D6 RID: 235734
		[Token(Token = "0x40398D6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryGetNameCardData;

		// Token: 0x040398D7 RID: 235735
		[Token(Token = "0x40398D7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CacheNameCardData;

		// Token: 0x040398D8 RID: 235736
		[Token(Token = "0x40398D8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSubmitPhoto;

		// Token: 0x040398D9 RID: 235737
		[Token(Token = "0x40398D9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnClickComittedPhoto;

		// Token: 0x040398DA RID: 235738
		[Token(Token = "0x40398DA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnShowHideDetail;

		// Token: 0x040398DB RID: 235739
		[Token(Token = "0x40398DB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x040398DC RID: 235740
		[Token(Token = "0x40398DC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
