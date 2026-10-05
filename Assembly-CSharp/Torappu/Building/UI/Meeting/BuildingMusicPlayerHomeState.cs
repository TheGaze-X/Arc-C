using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D47 RID: 7495
	[Token(Token = "0x2001D47")]
	public class BuildingMusicPlayerHomeState : State, IValueMsgReceiver
	{
		// Token: 0x0600B913 RID: 47379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B913")]
		[Address(RVA = "0x3360B40", Offset = "0x335F740", VA = "0x183360B40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B914 RID: 47380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B914")]
		[Address(RVA = "0x3361040", Offset = "0x335FC40", VA = "0x183361040", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0600B915 RID: 47381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B915")]
		[Address(RVA = "0x3360BA0", Offset = "0x335F7A0", VA = "0x183360BA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B916 RID: 47382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B916")]
		[Address(RVA = "0x3361170", Offset = "0x335FD70", VA = "0x183361170", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B917")]
		[Address(RVA = "0x3361740", Offset = "0x3360340", VA = "0x183361740")]
		private void _OnChangeSortOrder()
		{
		}

		// Token: 0x0600B918 RID: 47384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B918")]
		[Address(RVA = "0x3361D10", Offset = "0x3360910", VA = "0x183361D10")]
		private void _OnSetBgmBtnClicked()
		{
		}

		// Token: 0x0600B919 RID: 47385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B919")]
		[Address(RVA = "0x3361A20", Offset = "0x3360620", VA = "0x183361A20")]
		private void _OnMusicItemClicked(MusicPlayInfo musicPlayInfo)
		{
		}

		// Token: 0x0600B91A RID: 47386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B91A")]
		[Address(RVA = "0x3361670", Offset = "0x3360270", VA = "0x183361670")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B91B")]
		[Address(RVA = "0x33614E0", Offset = "0x33600E0", VA = "0x1833614E0")]
		private void _InitRoomTitle()
		{
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B91C")]
		[Address(RVA = "0x3361840", Offset = "0x3360440", VA = "0x183361840")]
		private void _OnClickClose()
		{
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B91D")]
		[Address(RVA = "0x3362050", Offset = "0x3360C50", VA = "0x183362050")]
		private IEnumerator _PlayEntryAnim()
		{
			return null;
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B91E")]
		[Address(RVA = "0x3362100", Offset = "0x3360D00", VA = "0x183362100")]
		public BuildingMusicPlayerHomeState()
		{
		}

		// Token: 0x0600B922 RID: 47394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B922")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B923 RID: 47395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B923")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0400B74F RID: 46927
		[Token(Token = "0x400B74F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0400B750 RID: 46928
		[Token(Token = "0x400B750")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingUIRoomTitle _roomTitle;

		// Token: 0x0400B751 RID: 46929
		[Token(Token = "0x400B751")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BuildingMusicPlayerView _view;

		// Token: 0x0400B752 RID: 46930
		[Token(Token = "0x400B752")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x0400B753 RID: 46931
		[Token(Token = "0x400B753")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animOut;

		// Token: 0x0400B754 RID: 46932
		[Token(Token = "0x400B754")]
		[NonSerialized]
		public const int MSG_MUSIC_ITEM_CLICK = 0;

		// Token: 0x0400B755 RID: 46933
		[Token(Token = "0x400B755")]
		[NonSerialized]
		public const int MSG_SET_MUSIC_CLICK = 1;

		// Token: 0x0400B756 RID: 46934
		[Token(Token = "0x400B756")]
		[FieldOffset(Offset = "0x88")]
		private BuildingMusicPlayerPage m_page;

		// Token: 0x0400B757 RID: 46935
		[Token(Token = "0x400B757")]
		[FieldOffset(Offset = "0x90")]
		private BuildingMusicPlayerStateBean m_stateBean;

		// Token: 0x0400B758 RID: 46936
		[Token(Token = "0x400B758")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_entryTween;

		// Token: 0x0400B759 RID: 46937
		[Token(Token = "0x400B759")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_outTween;

		// Token: 0x0400B75A RID: 46938
		[Token(Token = "0x400B75A")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_firstResume;

		// Token: 0x0400B75B RID: 46939
		[Token(Token = "0x400B75B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B75C RID: 46940
		[Token(Token = "0x400B75C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0400B75D RID: 46941
		[Token(Token = "0x400B75D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B75E RID: 46942
		[Token(Token = "0x400B75E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400B75F RID: 46943
		[Token(Token = "0x400B75F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnChangeSortOrder;

		// Token: 0x0400B760 RID: 46944
		[Token(Token = "0x400B760")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSetBgmBtnClicked;

		// Token: 0x0400B761 RID: 46945
		[Token(Token = "0x400B761")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnMusicItemClicked;

		// Token: 0x0400B762 RID: 46946
		[Token(Token = "0x400B762")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0400B763 RID: 46947
		[Token(Token = "0x400B763")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitRoomTitle;

		// Token: 0x0400B764 RID: 46948
		[Token(Token = "0x400B764")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnClickClose;

		// Token: 0x0400B765 RID: 46949
		[Token(Token = "0x400B765")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0400B766 RID: 46950
		[Token(Token = "0x400B766")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
