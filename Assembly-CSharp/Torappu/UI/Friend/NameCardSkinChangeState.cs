using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D69 RID: 19817
	[Token(Token = "0x2004D69")]
	public class NameCardSkinChangeState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x0601DA70 RID: 121456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA70")]
		[Address(RVA = "0x1737100", Offset = "0x1735D00", VA = "0x181737100")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DA71 RID: 121457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DA71")]
		[Address(RVA = "0x17361D0", Offset = "0x1734DD0", VA = "0x1817361D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DA72 RID: 121458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA72")]
		[Address(RVA = "0x17364B0", Offset = "0x17350B0", VA = "0x1817364B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DA73 RID: 121459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DA73")]
		[Address(RVA = "0x1736A90", Offset = "0x1735690", VA = "0x181736A90")]
		private string _ConsumeRoutedNameCardSkinId()
		{
			return null;
		}

		// Token: 0x0601DA74 RID: 121460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA74")]
		[Address(RVA = "0x1736FA0", Offset = "0x1735BA0", VA = "0x181736FA0")]
		private void _HandleSelectSkin(string selectedId)
		{
		}

		// Token: 0x0601DA75 RID: 121461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA75")]
		[Address(RVA = "0x1737060", Offset = "0x1735C60", VA = "0x181737060")]
		private void _HandleToChangeSkinTmpl(string skinId)
		{
		}

		// Token: 0x0601DA76 RID: 121462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA76")]
		[Address(RVA = "0x1736EB0", Offset = "0x1735AB0", VA = "0x181736EB0")]
		private void _HandleHideChangeSkinTmpl()
		{
		}

		// Token: 0x0601DA77 RID: 121463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA77")]
		[Address(RVA = "0x1736F20", Offset = "0x1735B20", VA = "0x181736F20")]
		private void _HandleSelectSkinTmpl(int skinTmpl)
		{
		}

		// Token: 0x0601DA78 RID: 121464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA78")]
		[Address(RVA = "0x1736BF0", Offset = "0x17357F0", VA = "0x181736BF0")]
		private void _HandleConfirmSkinTmpl(ValueBundle vb)
		{
		}

		// Token: 0x0601DA79 RID: 121465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA79")]
		[Address(RVA = "0x1736B80", Offset = "0x1735780", VA = "0x181736B80")]
		private void _HandleCancelSkinTmpl()
		{
		}

		// Token: 0x0601DA7A RID: 121466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA7A")]
		[Address(RVA = "0x1736230", Offset = "0x1734E30", VA = "0x181736230")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x0601DA7B RID: 121467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA7B")]
		[Address(RVA = "0x1736130", Offset = "0x1734D30", VA = "0x181736130")]
		public void CloseState()
		{
		}

		// Token: 0x0601DA7C RID: 121468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA7C")]
		[Address(RVA = "0x1736660", Offset = "0x1735260", VA = "0x181736660", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601DA7D RID: 121469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA7D")]
		[Address(RVA = "0x17374A0", Offset = "0x17360A0", VA = "0x1817374A0")]
		public NameCardSkinChangeState()
		{
		}

		// Token: 0x0601DA80 RID: 121472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA80")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040272B9 RID: 160441
		[Token(Token = "0x40272B9")]
		public const int SELECT_SKIN = 0;

		// Token: 0x040272BA RID: 160442
		[Token(Token = "0x40272BA")]
		public const int TO_CHANGE_SKIN_TMPL = 1;

		// Token: 0x040272BB RID: 160443
		[Token(Token = "0x40272BB")]
		public const int HIDE_CHANGE_SKIN_TMPL = 2;

		// Token: 0x040272BC RID: 160444
		[Token(Token = "0x40272BC")]
		public const int SELECT_SKIN_TMPL = 3;

		// Token: 0x040272BD RID: 160445
		[Token(Token = "0x40272BD")]
		public const int CONFIRM_SKIN_TMPL = 4;

		// Token: 0x040272BE RID: 160446
		[Token(Token = "0x40272BE")]
		public const int CANCEL_SKIN_TMPL = 5;

		// Token: 0x040272BF RID: 160447
		[Token(Token = "0x40272BF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _rectCancel;

		// Token: 0x040272C0 RID: 160448
		[Token(Token = "0x40272C0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private NameCardSkinChangeView _changeView;

		// Token: 0x040272C1 RID: 160449
		[Token(Token = "0x40272C1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private NameCardSkinTmplChangeView _skinTmplChangeViewPrefab;

		// Token: 0x040272C2 RID: 160450
		[Token(Token = "0x40272C2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _skinTmplChangeViewContent;

		// Token: 0x040272C3 RID: 160451
		[Token(Token = "0x40272C3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _nameCardContainer;

		// Token: 0x040272C4 RID: 160452
		[Token(Token = "0x40272C4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _nameCardScale;

		// Token: 0x040272C5 RID: 160453
		[Token(Token = "0x40272C5")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_isInited;

		// Token: 0x040272C6 RID: 160454
		[Token(Token = "0x40272C6")]
		[FieldOffset(Offset = "0xA0")]
		private NameCardSkinTmplChangeView m_skinTmplChangeView;

		// Token: 0x040272C7 RID: 160455
		[Token(Token = "0x40272C7")]
		[FieldOffset(Offset = "0xA8")]
		private NameCardV2View m_nameCardView;

		// Token: 0x040272C8 RID: 160456
		[Token(Token = "0x40272C8")]
		[FieldOffset(Offset = "0xB0")]
		private NameCardSkinChangeStateBean m_stateBean;

		// Token: 0x040272C9 RID: 160457
		[Token(Token = "0x40272C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040272CA RID: 160458
		[Token(Token = "0x40272CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040272CB RID: 160459
		[Token(Token = "0x40272CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040272CC RID: 160460
		[Token(Token = "0x40272CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ConsumeRoutedNameCardSkinId;

		// Token: 0x040272CD RID: 160461
		[Token(Token = "0x40272CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HandleSelectSkin;

		// Token: 0x040272CE RID: 160462
		[Token(Token = "0x40272CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HandleToChangeSkinTmpl;

		// Token: 0x040272CF RID: 160463
		[Token(Token = "0x40272CF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleHideChangeSkinTmpl;

		// Token: 0x040272D0 RID: 160464
		[Token(Token = "0x40272D0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleSelectSkinTmpl;

		// Token: 0x040272D1 RID: 160465
		[Token(Token = "0x40272D1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleConfirmSkinTmpl;

		// Token: 0x040272D2 RID: 160466
		[Token(Token = "0x40272D2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleCancelSkinTmpl;

		// Token: 0x040272D3 RID: 160467
		[Token(Token = "0x40272D3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x040272D4 RID: 160468
		[Token(Token = "0x40272D4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CloseState;

		// Token: 0x040272D5 RID: 160469
		[Token(Token = "0x40272D5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040272D6 RID: 160470
		[Token(Token = "0x40272D6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
